using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Globalization;

namespace IReSoft_priklad
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

        private Thread thread;

        // v pripade ak by to nedokazalo citat unicod ako ma
        //private Dictionary<char, char> czChars = new Dictionary<char, char>
        //{
        //    {'á', 'a'},{'č', 'c'},{'ď', 'd'},{'é', 'e'},{'ě', 'e'},{'í', 'i'},
        //    {'ň', 'n'},{'ó', 'o'},{'ř', 'r'},{'š', 's'},{'ť', 't'},{'ú', 'u'},
        //    {'ů', 'u'},{'ý', 'y'},{'ž', 'z'}
        //};

        private string fileText;
        private string path;
        private int numOfLines, numOfWords, numOfChars, numOfSentences;
        private int numOfLines_new, numOfWords_new, numOfChars_new, numOfSentences_new;
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
                    textBox1.Text = fileText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error - este neviem aky", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                labelPocetRiadkov.Text = "Pocet riadkov: " + numOfLines;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            createCopy();
            MessageBox.Show("Vystup sa vytvoril v adresari otvoreneho txt suboru s povodnym znenim a pridanym stringom \n '- vystup'.");
        }

        private void createCopy()
        {
            //neskor - nejak inak spravit path
            System.IO.File.WriteAllText(path.Substring(0, path.Length - 4) + " - vystup.txt", fileText);
        }

        private void threadComputations()
        {


        }




        //robim tu ja vypocty
        private void odstranDiakritiu()
        {
            fileText = fileText.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < fileText.Length; i++)
            {
                    if (CharUnicodeInfo.GetUnicodeCategory(fileText[i]) != UnicodeCategory.NonSpacingMark)
                        sb.Append(fileText[i]);
            }
            fileText = sb.ToString();
        }

        private void odstranMedzeryAinterpunkciu()
        {
            for (int i = 0; i < fileText.Length; i++)
            {
                
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAplikujNastavenia_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(threadComputations));
            thread.Start();

            if (checkBoxDiakritika.Checked == true)
            {
                odstranDiakritiu();
            }
            if (checkBoxMedzeryInterpunkcia.Checked == true)
            {
            }
            if (checkBoxPrazdneRiadky.Checked == true)
            {
            }

            //kotrola vystupu
            string s = new string(fileText.Where(c => !char.IsPunctuation(c)).ToArray());
            textBox1.Text = fileText + s;
        }

    }
}
