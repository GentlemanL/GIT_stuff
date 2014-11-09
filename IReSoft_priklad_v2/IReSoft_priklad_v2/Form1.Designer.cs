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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusPercentLabel = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusPercentLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(588, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel1.Text = "Progress";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusPercentLabel
            // 
            this.toolStripStatusPercentLabel.Name = "toolStripStatusPercentLabel";
            this.toolStripStatusPercentLabel.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusPercentLabel.Text = "0 %";
            // 
            // panel1
            // 
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
            this.label2.Location = new System.Drawing.Point(157, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Progress";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxKontrola);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(150, 44);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 380);
            this.panel2.TabIndex = 4;
            // 
            // textBoxKontrola
            // 
            this.textBoxKontrola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxKontrola.Location = new System.Drawing.Point(0, 0);
            this.textBoxKontrola.Multiline = true;
            this.textBoxKontrola.Name = "textBoxKontrola";
            this.textBoxKontrola.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxKontrola.Size = new System.Drawing.Size(438, 380);
            this.textBoxKontrola.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(210, 27);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(310, 17);
            this.progressBar1.TabIndex = 20;
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(526, 28);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(24, 13);
            this.labelPercent.TabIndex = 21;
            this.labelPercent.Text = "0 %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 446);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(250, 484);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.CheckBox checkBoxSpacesAndPunctuation;
        private System.Windows.Forms.CheckBox checkBoxEmptyLines;
        private System.Windows.Forms.CheckBox checkBoxDiacritics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxKontrola;
        internal System.Windows.Forms.Label labelPocetZnakov;
        internal System.Windows.Forms.Label labelPocetRiadkov;
        internal System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusPercentLabel;
        internal System.Windows.Forms.Label labelPocetViet;
        internal System.Windows.Forms.Label labelPocetSlov;
        internal System.Windows.Forms.ProgressBar progressBar1;
        internal System.Windows.Forms.Button buttonAplikujNastavenia;
        internal System.Windows.Forms.Label labelPercent;
    }
}

