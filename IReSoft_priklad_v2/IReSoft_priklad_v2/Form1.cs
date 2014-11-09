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
            label2.Visible = false;
            checkBoxes = new CheckBox[] { checkBoxDiacritics, checkBoxEmptyLines, checkBoxSpacesAndPunctuation };
        }

        internal CheckBox[] checkBoxes;

        private string inputText;
        private string editedText;
        private string path;
        private int progressBarModifier = 1;
        private Thread thread;

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
                    panel1.Visible = true;
                    panel2.Visible = true;
                    label2.Visible = true;

                    inputText = System.IO.File.ReadAllText(path);

                    //kontrola vstupu
                    textBoxKontrola.Text = inputText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error - este neviem aky", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally // mozno prec
            {
            }
        }

        private void createOutput(string s)
        {
            //neskor - nejak inak spravit path
            System.IO.File.WriteAllText(path.Substring(0, path.Length - 4) + " - vystup.txt", s);
        }
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            createOutput(inputText);
            MessageBox.Show("Vystup sa vytvoril v adresari otvoreneho txt suboru s povodnym znenim a pridanym stringom '- vystup'.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAplikujNastavenia_Click(object sender, EventArgs e)
        {
            /*buttonAplikujNastavenia.Enabled = false;
            foreach (var item in checkBoxes)
            {
                item.Enabled = false;
            }*/
            panel1.Enabled = false;

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
                            editedText = op[i].Run(editedText, u);
                            SetControlPropertyThreadSafe(textBoxKontrola, "Text", editedText);
                        }
                    }

                    createOutput(editedText);
                    /*foreach (var item in checkBoxes)
                    {
                        item.Enabled = true;
                    }*/
                });
                thread.IsBackground = true;
                thread.Start();
            }
            else
            {
                MessageBox.Show("File is empty! Select another file.");
            }
        }

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
    }
}
