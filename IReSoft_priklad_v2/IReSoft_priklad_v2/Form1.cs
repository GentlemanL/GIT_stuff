using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private string fileText;
        private string path;
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

                    fileText = System.IO.File.ReadAllText(path);
                    //kontrola vstupu
                    textBoxKontrola.Text = fileText;
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

        private void createCopy()
        {
            //neskor - nejak inak spravit path
            System.IO.File.WriteAllText(path.Substring(0, path.Length - 4) + " - vystup.txt", fileText);
        }
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            createCopy();
            MessageBox.Show("Vystup sa vytvoril v adresari otvoreneho txt suboru s povodnym znenim a pridanym stringom '- vystup'.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAplikujNastavenia_Click(object sender, EventArgs e)
        {
            if (checkBoxDiacritics.Checked)
            {
                textBoxKontrola.Text = ex.runOperation(rd, fileText);
            }
            if (checkBoxEmptyLines.Checked)
            {
                textBoxKontrola.Text = ex.runOperation(rel, fileText);
            }
            if (checkBoxSpacesAndPunctuation.Checked)
            {
                textBoxKontrola.Text = ex.runOperation(rsap, fileText);
            }
        }


    }
}
