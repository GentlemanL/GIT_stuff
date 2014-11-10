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
            this.labelOutputLines = new System.Windows.Forms.Label();
            this.labelOutputSentences = new System.Windows.Forms.Label();
            this.labelOutputWords = new System.Windows.Forms.Label();
            this.labelOutputCharacters = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelPocetZnakov = new System.Windows.Forms.Label();
            this.labelPocetViet = new System.Windows.Forms.Label();
            this.labelPocetRiadkov = new System.Windows.Forms.Label();
            this.labelNumberOfWords = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonApplySettings = new System.Windows.Forms.Button();
            this.checkBoxSpacesAndPunctuation = new System.Windows.Forms.CheckBox();
            this.checkBoxEmptyLines = new System.Windows.Forms.CheckBox();
            this.checkBoxDiacritics = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxTextCheck = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelPercent = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.labelNumberOfWords);
            this.panel1.Controls.Add(this.buttonCopy);
            this.panel1.Controls.Add(this.buttonApplySettings);
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
            // labelOutputLines
            // 
            this.labelOutputLines.AutoSize = true;
            this.labelOutputLines.Location = new System.Drawing.Point(4, 335);
            this.labelOutputLines.Name = "labelOutputLines";
            this.labelOutputLines.Size = new System.Drawing.Size(35, 13);
            this.labelOutputLines.TabIndex = 24;
            this.labelOutputLines.Text = "Lines:";
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
            // labelOutputWords
            // 
            this.labelOutputWords.AutoSize = true;
            this.labelOutputWords.Location = new System.Drawing.Point(5, 309);
            this.labelOutputWords.Name = "labelOutputWords";
            this.labelOutputWords.Size = new System.Drawing.Size(41, 13);
            this.labelOutputWords.TabIndex = 22;
            this.labelOutputWords.Text = "Words:";
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
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(4, 275);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(39, 13);
            this.labelOutput.TabIndex = 20;
            this.labelOutput.Text = "Output";
            // 
            // labelPocetZnakov
            // 
            this.labelPocetZnakov.AutoSize = true;
            this.labelPocetZnakov.Location = new System.Drawing.Point(5, 176);
            this.labelPocetZnakov.Name = "labelPocetZnakov";
            this.labelPocetZnakov.Size = new System.Drawing.Size(112, 13);
            this.labelPocetZnakov.TabIndex = 19;
            this.labelPocetZnakov.Text = "Number of characters:";
            // 
            // labelPocetViet
            // 
            this.labelPocetViet.AutoSize = true;
            this.labelPocetViet.Location = new System.Drawing.Point(5, 215);
            this.labelPocetViet.Name = "labelPocetViet";
            this.labelPocetViet.Size = new System.Drawing.Size(111, 13);
            this.labelPocetViet.TabIndex = 18;
            this.labelPocetViet.Text = "Number of sentences:";
            // 
            // labelPocetRiadkov
            // 
            this.labelPocetRiadkov.AutoSize = true;
            this.labelPocetRiadkov.Location = new System.Drawing.Point(5, 202);
            this.labelPocetRiadkov.Name = "labelPocetRiadkov";
            this.labelPocetRiadkov.Size = new System.Drawing.Size(86, 13);
            this.labelPocetRiadkov.TabIndex = 17;
            this.labelPocetRiadkov.Text = "Number of liens: ";
            // 
            // labelNumberOfWords
            // 
            this.labelNumberOfWords.AutoSize = true;
            this.labelNumberOfWords.Location = new System.Drawing.Point(5, 189);
            this.labelNumberOfWords.Name = "labelNumberOfWords";
            this.labelNumberOfWords.Size = new System.Drawing.Size(90, 13);
            this.labelNumberOfWords.TabIndex = 16;
            this.labelNumberOfWords.Text = "Number of words:";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(3, 3);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(144, 23);
            this.buttonCopy.TabIndex = 15;
            this.buttonCopy.Text = "Create copy of input";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonApplySettings
            // 
            this.buttonApplySettings.Location = new System.Drawing.Point(3, 134);
            this.buttonApplySettings.Name = "buttonApplySettings";
            this.buttonApplySettings.Size = new System.Drawing.Size(144, 23);
            this.buttonApplySettings.TabIndex = 14;
            this.buttonApplySettings.Text = "Apply settings";
            this.buttonApplySettings.UseVisualStyleBackColor = true;
            this.buttonApplySettings.Click += new System.EventHandler(this.buttonAplikujNastavenia_Click);
            // 
            // checkBoxSpacesAndPunctuation
            // 
            this.checkBoxSpacesAndPunctuation.AutoSize = true;
            this.checkBoxSpacesAndPunctuation.Location = new System.Drawing.Point(7, 110);
            this.checkBoxSpacesAndPunctuation.Name = "checkBoxSpacesAndPunctuation";
            this.checkBoxSpacesAndPunctuation.Size = new System.Drawing.Size(142, 17);
            this.checkBoxSpacesAndPunctuation.TabIndex = 13;
            this.checkBoxSpacesAndPunctuation.Text = "Spaces adn punctuation";
            this.checkBoxSpacesAndPunctuation.UseVisualStyleBackColor = true;
            this.checkBoxSpacesAndPunctuation.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateChanged);
            // 
            // checkBoxEmptyLines
            // 
            this.checkBoxEmptyLines.AutoSize = true;
            this.checkBoxEmptyLines.Location = new System.Drawing.Point(7, 86);
            this.checkBoxEmptyLines.Name = "checkBoxEmptyLines";
            this.checkBoxEmptyLines.Size = new System.Drawing.Size(79, 17);
            this.checkBoxEmptyLines.TabIndex = 12;
            this.checkBoxEmptyLines.Text = "Empty lines";
            this.checkBoxEmptyLines.UseVisualStyleBackColor = true;
            this.checkBoxEmptyLines.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateChanged);
            // 
            // checkBoxDiacritics
            // 
            this.checkBoxDiacritics.AutoSize = true;
            this.checkBoxDiacritics.Location = new System.Drawing.Point(7, 62);
            this.checkBoxDiacritics.Name = "checkBoxDiacritics";
            this.checkBoxDiacritics.Size = new System.Drawing.Size(69, 17);
            this.checkBoxDiacritics.TabIndex = 11;
            this.checkBoxDiacritics.Text = "Diacritics";
            this.checkBoxDiacritics.UseVisualStyleBackColor = true;
            this.checkBoxDiacritics.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Remove:";
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
            this.panel2.Controls.Add(this.textBoxTextCheck);
            this.panel2.Location = new System.Drawing.Point(150, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 345);
            this.panel2.TabIndex = 4;
            // 
            // textBoxTextCheck
            // 
            this.textBoxTextCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTextCheck.Location = new System.Drawing.Point(0, 0);
            this.textBoxTextCheck.Multiline = true;
            this.textBoxTextCheck.Name = "textBoxTextCheck";
            this.textBoxTextCheck.ReadOnly = true;
            this.textBoxTextCheck.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTextCheck.Size = new System.Drawing.Size(431, 342);
            this.textBoxTextCheck.TabIndex = 0;
            this.textBoxTextCheck.TabStop = false;
            this.textBoxTextCheck.WordWrap = false;
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
        private System.Windows.Forms.TextBox textBoxTextCheck;
        internal System.Windows.Forms.Label labelPocetZnakov;
        internal System.Windows.Forms.Label labelPocetRiadkov;
        internal System.Windows.Forms.Label labelPocetViet;
        internal System.Windows.Forms.Label labelNumberOfWords;
        internal System.Windows.Forms.ProgressBar progressBar1;
        internal System.Windows.Forms.Button buttonApplySettings;
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

