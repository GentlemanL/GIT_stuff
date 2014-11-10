using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IReSoft_priklad_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            buttonApplySettings.Enabled = false;
            checkBoxes = new CheckBox[] { checkBoxDiacritics, checkBoxEmptyLines, checkBoxSpacesAndPunctuation };
        }

        #region default needed properties
        internal CheckBox[] checkBoxes;
        private string inputText;
        private string editedText;
        private string path;
        private int progressBarModifier = 0;
        private Thread thread;
        private int operationNumber = 0;
        #endregion

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Text File";
            ofd.Filter = "Text Files|*.txt*";
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;

                    //mabye use array and foreach
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;

                    inputText = System.IO.File.ReadAllText(path);

                    //text control
                    textBoxTextCheck.Text = inputText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error - none so fary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Function that creates output file
        /// </summary>
        /// <param name="s">input text to write into file</param>
        private void createOutput(string s)
        {
            //later - some better representation of path
            System.IO.File.WriteAllText(path.Substring(0, path.Length - 4) + " - vystup.txt", s);
        }
        
        /// <summary>
        /// Creates copy of input adn shows specifiing message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            createOutput(inputText);
            MessageBox.Show("Vystup sa vytvoril v adresari otvoreneho txt suboru s povodnym znenim a pridanym stringom '- vystup'.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Applies all functions to be performed on input text.
        /// Function creats another thread to perfomr tasks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAplikujNastavenia_Click(object sender, EventArgs e)
        {
            
            #region default settigns for each run
            panel1.Enabled = false;
            operationNumber = 0;
            progressBar1.Value = 0;
            labelPercent.Text = "0 %";
            #endregion

            
            if (inputText.Length != 0)
            {
                editedText = inputText;
                thread = new Thread(() =>
                {
                    IUpdater u = new FormUpdater(this);
                    IOperation[] op = new IOperation[] { new RemoveDiacritics(), new RemoveEmptyLines(), new RemoveSpacesAndPunctuation() };
                    for (int i = 0; i < checkBoxes.Length; i++)
                    {
                        if (checkBoxes[i].Checked)
                        {
                            operationNumber++;
                            editedText = op[i].Run(editedText, u, progressBarModifier, operationNumber);
                            SetControlPropertyThreadSafe(textBoxTextCheck, "Text", editedText);
                        }
                    }
                    SetControlPropertyThreadSafe(labelOutputLines, "Text", "Lines: " + editedText.Count(c => c == '\n'));
                    createOutput(editedText);
                });
                thread.IsBackground = true;
                thread.Start();
            }
            else
            {
                MessageBox.Show("File is empty! Select another file.");
            }
        }
        
        //later - do this nicer
        private delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);
        public static void SetControlPropertyThreadSafe(Control control, string propertyName, object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate(SetControlPropertyThreadSafe), new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(propertyName, BindingFlags.SetProperty, null, control, new object[] { propertyValue });
            }
        }

        /// <summary>
        /// Sets number of progress bar modifiers so progress bar can be adjusted during run.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == true)
            {
                progressBarModifier++;
            }
            else
            {
                progressBarModifier--;
            }
            if (progressBarModifier == 0) buttonApplySettings.Enabled = false;
            else buttonApplySettings.Enabled = true;
        }
    }
}
