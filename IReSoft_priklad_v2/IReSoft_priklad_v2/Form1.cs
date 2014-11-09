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
        }

        private string inputText;
        private string editedText;
        private string path;
        private Thread thread;
        private Execute ex;
        private RemoveDiacritics rd = new RemoveDiacritics();
        private RemoveEmptyLines rel;
        private RemoveSpacesAndPunctuation rsap;
        //private int numOfLines, numOfWords, numOfChars, numOfSentences;

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
            updateStuff();
            //textBoxKontrola.Text = editedText;
        }

        private void updateStuff()
        {
            thread = new Thread(() =>
            {
                if (checkBoxDiacritics.Checked)
                {
                    ex = new Execute();
                    editedText = ex.runOperation(rd, inputText);
                    SetControlPropertyThreadSafe(textBoxKontrola, "Text", editedText);
                }
                if (checkBoxEmptyLines.Checked)
                {
                    textBoxKontrola.Text = ex.runOperation(rel, inputText);
                }
                if (checkBoxSpacesAndPunctuation.Checked)
                {
                    textBoxKontrola.Text = ex.runOperation(rsap, inputText);
                }
            });

            thread.Start();
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
