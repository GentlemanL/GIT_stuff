namespace IReSoft_priklad_v2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPocetZnakov = new System.Windows.Forms.Label();
            this.labelPocetViet = new System.Windows.Forms.Label();
            this.labelPocetRiadkov = new System.Windows.Forms.Label();
            this.labelPocetSlov = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonAplikujNastavenia = new System.Windows.Forms.Button();
            this.checkBoxSpacesAndPunctuation = new System.Windows.Forms.CheckBox();
            this.checkBoxEmptyLines = new System.Windows.Forms.CheckBox();
            this.checkBoxDiacritics = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxKontrola = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelPercent = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelOutputCharacters = new System.Windows.Forms.Label();
            this.labelOutputWords = new System.Windows.Forms.Label();
            this.labelOutputSentences = new System.Windows.Forms.Label();
            this.labelOutputLines = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelOutputLines);
            this.panel1.Controls.Add(this.labelOutputSentences);
            this.panel1.Controls.Add(this.labelOutputWords);
            this.panel1.Controls.Add(this.labelOutputCharacters);
            this.panel1.Controls.Add(this.labelOutput);
            this.panel1.Controls.Add(this.labelPocetZnakov);
            this.panel1.Controls.Add(this.labelPocetViet);
            this.panel1.Controls.Add(this.labelPocetRiadkov);
            this.panel1.Controls.Add(this.labelPocetSlov);
            this.panel1.Controls.Add(this.buttonCopy);
            this.panel1.Controls.Add(this.buttonAplikujNastavenia);
            this.panel1.Controls.Add(this.checkBoxSpacesAndPunctuation);
            this.panel1.Controls.Add(this.checkBoxEmptyLines);
            this.panel1.Controls.Add(this.checkBoxDiacritics);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.MinimumSize = new System.Drawing.Size(150, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 400);
            this.panel1.TabIndex = 2;
            // 
            // labelPocetZnakov
            // 
            this.labelPocetZnakov.AutoSize = true;
            this.labelPocetZnakov.Location = new System.Drawing.Point(5, 176);
            this.labelPocetZnakov.Name = "labelPocetZnakov";
            this.labelPocetZnakov.Size = new System.Drawing.Size(76, 13);
            this.labelPocetZnakov.TabIndex = 19;
            this.labelPocetZnakov.Text = "Pocet znakov:";
            // 
            // labelPocetViet
            // 
            this.labelPocetViet.AutoSize = true;
            this.labelPocetViet.Location = new System.Drawing.Point(5, 215);
            this.labelPocetViet.Name = "labelPocetViet";
            this.labelPocetViet.Size = new System.Drawing.Size(58, 13);
            this.labelPocetViet.TabIndex = 18;
            this.labelPocetViet.Text = "Pocet viet:";
            // 
            // labelPocetRiadkov
            // 
            this.labelPocetRiadkov.AutoSize = true;
            this.labelPocetRiadkov.Location = new System.Drawing.Point(5, 202);
            this.labelPocetRiadkov.Name = "labelPocetRiadkov";
            this.labelPocetRiadkov.Size = new System.Drawing.Size(76, 13);
            this.labelPocetRiadkov.TabIndex = 17;
            this.labelPocetRiadkov.Text = "Pocet riadkov:";
            // 
            // labelPocetSlov
            // 
            this.labelPocetSlov.AutoSize = true;
            this.labelPocetSlov.Location = new System.Drawing.Point(5, 189);
            this.labelPocetSlov.Name = "labelPocetSlov";
            this.labelPocetSlov.Size = new System.Drawing.Size(63, 13);
            this.labelPocetSlov.TabIndex = 16;
            this.labelPocetSlov.Text = "Pocet slov: ";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(3, 3);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(144, 23);
            this.buttonCopy.TabIndex = 15;
            this.buttonCopy.Text = "Vytvor kopiu vstupu";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonAplikujNastavenia
            // 
            this.buttonAplikujNastavenia.Location = new System.Drawing.Point(3, 134);
            this.buttonAplikujNastavenia.Name = "buttonAplikujNastavenia";
            this.buttonAplikujNastavenia.Size = new System.Drawing.Size(144, 23);
            this.buttonAplikujNastavenia.TabIndex = 14;
            this.buttonAplikujNastavenia.Text = "Aplikuj nastavenia";
            this.buttonAplikujNastavenia.UseVisualStyleBackColor = true;
            this.buttonAplikujNastavenia.Click += new System.EventHandler(this.buttonAplikujNastavenia_Click);
            // 
            // checkBoxSpacesAndPunctuation
            // 
            this.checkBoxSpacesAndPunctuation.AutoSize = true;
            this.checkBoxSpacesAndPunctuation.Location = new System.Drawing.Point(13, 111);
            this.checkBoxSpacesAndPunctuation.Name = "checkBoxSpacesAndPunctuation";
            this.checkBoxSpacesAndPunctuation.Size = new System.Drawing.Size(136, 17);
            this.checkBoxSpacesAndPunctuation.TabIndex = 13;
            this.checkBoxSpacesAndPunctuation.Text = "Medzery a interpunkciu";
            this.checkBoxSpacesAndPunctuation.UseVisualStyleBackColor = true;
            this.checkBoxSpacesAndPunctuation.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateChanged);
            // 
            // checkBoxEmptyLines
            // 
            this.checkBoxEmptyLines.AutoSize = true;
            this.checkBoxEmptyLines.Location = new System.Drawing.Point(13, 87);
            this.checkBoxEmptyLines.Name = "checkBoxEmptyLines";
            this.checkBoxEmptyLines.Size = new System.Drawing.Size(96, 17);
            this.checkBoxEmptyLines.TabIndex = 12;
            this.checkBoxEmptyLines.Text = "Prazdne riadky";
            this.checkBoxEmptyLines.UseVisualStyleBackColor = true;
            this.checkBoxEmptyLines.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateChanged);
            // 
            // checkBoxDiacritics
            // 
            this.checkBoxDiacritics.AutoSize = true;
            this.checkBoxDiacritics.Location = new System.Drawing.Point(13, 63);
            this.checkBoxDiacritics.Name = "checkBoxDiacritics";
            this.checkBoxDiacritics.Size = new System.Drawing.Size(70, 17);
            this.checkBoxDiacritics.TabIndex = 11;
            this.checkBoxDiacritics.Text = "Diakritiku";
            this.checkBoxDiacritics.UseVisualStyleBackColor = true;
            this.checkBoxDiacritics.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Odstranit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Progress";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.textBoxKontrola);
            this.panel2.Location = new System.Drawing.Point(150, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 345);
            this.panel2.TabIndex = 4;
            // 
            // textBoxKontrola
            // 
            this.textBoxKontrola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKontrola.Location = new System.Drawing.Point(0, 0);
            this.textBoxKontrola.Multiline = true;
            this.textBoxKontrola.Name = "textBoxKontrola";
            this.textBoxKontrola.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxKontrola.Size = new System.Drawing.Size(431, 342);
            this.textBoxKontrola.TabIndex = 0;
            this.textBoxKontrola.TabStop = false;
            this.textBoxKontrola.WordWrap = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(59, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(310, 17);
            this.progressBar1.TabIndex = 20;
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(387, 7);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(24, 13);
            this.labelPercent.TabIndex = 21;
            this.labelPercent.Text = "0 %";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(4, 275);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(39, 13);
            this.labelOutput.TabIndex = 20;
            this.labelOutput.Text = "Output";
            // 
            // labelOutputCharacters
            // 
            this.labelOutputCharacters.AutoSize = true;
            this.labelOutputCharacters.Location = new System.Drawing.Point(4, 296);
            this.labelOutputCharacters.Name = "labelOutputCharacters";
            this.labelOutputCharacters.Size = new System.Drawing.Size(64, 13);
            this.labelOutputCharacters.TabIndex = 21;
            this.labelOutputCharacters.Text = "Cahracters: ";
            // 
            // labelOutputWords
            // 
            this.labelOutputWords.AutoSize = true;
            this.labelOutputWords.Location = new System.Drawing.Point(5, 309);
            this.labelOutputWords.Name = "labelOutputWords";
            this.labelOutputWords.Size = new System.Drawing.Size(41, 13);
            this.labelOutputWords.TabIndex = 22;
            this.labelOutputWords.Text = "Words:";
            // 
            // labelOutputSentences
            // 
            this.labelOutputSentences.AutoSize = true;
            this.labelOutputSentences.Location = new System.Drawing.Point(4, 322);
            this.labelOutputSentences.Name = "labelOutputSentences";
            this.labelOutputSentences.Size = new System.Drawing.Size(61, 13);
            this.labelOutputSentences.TabIndex = 23;
            this.labelOutputSentences.Text = "Sentences:";
            // 
            // labelOutputLines
            // 
            this.labelOutputLines.AutoSize = true;
            this.labelOutputLines.Location = new System.Drawing.Point(4, 335);
            this.labelOutputLines.Name = "labelOutputLines";
            this.labelOutputLines.Size = new System.Drawing.Size(35, 13);
            this.labelOutputLines.TabIndex = 24;
            this.labelOutputLines.Text = "Lines:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelPercent);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(150, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 26);
            this.panel3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 397);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 435);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxKontrola;
        internal System.Windows.Forms.Label labelPocetZnakov;
        internal System.Windows.Forms.Label labelPocetRiadkov;
        internal System.Windows.Forms.Label labelPocetViet;
        internal System.Windows.Forms.Label labelPocetSlov;
        internal System.Windows.Forms.ProgressBar progressBar1;
        internal System.Windows.Forms.Button buttonAplikujNastavenia;
        internal System.Windows.Forms.Label labelPercent;
        internal System.Windows.Forms.CheckBox checkBoxSpacesAndPunctuation;
        internal System.Windows.Forms.CheckBox checkBoxEmptyLines;
        internal System.Windows.Forms.CheckBox checkBoxDiacritics;
        internal System.Windows.Forms.Button buttonCopy;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label labelOutputLines;
        internal System.Windows.Forms.Label labelOutputSentences;
        internal System.Windows.Forms.Label labelOutputWords;
        internal System.Windows.Forms.Label labelOutputCharacters;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Panel panel3;
    }
}

