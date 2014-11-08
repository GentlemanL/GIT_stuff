namespace IReSoft_priklad
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
            this.toolStripStatusProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusPercentLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPocetZnakov = new System.Windows.Forms.Label();
            this.labelPocetViet = new System.Windows.Forms.Label();
            this.labelPocetRiadkov = new System.Windows.Forms.Label();
            this.labelPocetSlov = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonAplikujNastavenia = new System.Windows.Forms.Button();
            this.checkBoxMedzeryInterpunkcia = new System.Windows.Forms.CheckBox();
            this.checkBoxPrazdneRiadky = new System.Windows.Forms.CheckBox();
            this.checkBoxDiakritika = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(646, 24);
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
            this.toolStripStatusProgressLabel,
            this.toolStripProgressBar1,
            this.toolStripStatusPercentLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 507);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(646, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusProgressLabel
            // 
            this.toolStripStatusProgressLabel.Name = "toolStripStatusProgressLabel";
            this.toolStripStatusProgressLabel.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusProgressLabel.Text = "Progress";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(300, 16);
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
            this.panel1.Controls.Add(this.checkBoxMedzeryInterpunkcia);
            this.panel1.Controls.Add(this.checkBoxPrazdneRiadky);
            this.panel1.Controls.Add(this.checkBoxDiakritika);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 483);
            this.panel1.TabIndex = 2;
            // 
            // labelPocetZnakov
            // 
            this.labelPocetZnakov.AutoSize = true;
            this.labelPocetZnakov.Location = new System.Drawing.Point(4, 177);
            this.labelPocetZnakov.Name = "labelPocetZnakov";
            this.labelPocetZnakov.Size = new System.Drawing.Size(76, 13);
            this.labelPocetZnakov.TabIndex = 9;
            this.labelPocetZnakov.Text = "Pocet znakov:";
            // 
            // labelPocetViet
            // 
            this.labelPocetViet.AutoSize = true;
            this.labelPocetViet.Location = new System.Drawing.Point(4, 216);
            this.labelPocetViet.Name = "labelPocetViet";
            this.labelPocetViet.Size = new System.Drawing.Size(58, 13);
            this.labelPocetViet.TabIndex = 8;
            this.labelPocetViet.Text = "Pocet viet:";
            // 
            // labelPocetRiadkov
            // 
            this.labelPocetRiadkov.AutoSize = true;
            this.labelPocetRiadkov.Location = new System.Drawing.Point(4, 203);
            this.labelPocetRiadkov.Name = "labelPocetRiadkov";
            this.labelPocetRiadkov.Size = new System.Drawing.Size(76, 13);
            this.labelPocetRiadkov.TabIndex = 7;
            this.labelPocetRiadkov.Text = "Pocet riadkov:";
            // 
            // labelPocetSlov
            // 
            this.labelPocetSlov.AutoSize = true;
            this.labelPocetSlov.Location = new System.Drawing.Point(4, 190);
            this.labelPocetSlov.Name = "labelPocetSlov";
            this.labelPocetSlov.Size = new System.Drawing.Size(63, 13);
            this.labelPocetSlov.TabIndex = 6;
            this.labelPocetSlov.Text = "Pocet slov: ";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(2, 4);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(144, 23);
            this.buttonCopy.TabIndex = 5;
            this.buttonCopy.Text = "Vytvor kopiu vstupu";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonAplikujNastavenia
            // 
            this.buttonAplikujNastavenia.Location = new System.Drawing.Point(2, 135);
            this.buttonAplikujNastavenia.Name = "buttonAplikujNastavenia";
            this.buttonAplikujNastavenia.Size = new System.Drawing.Size(144, 23);
            this.buttonAplikujNastavenia.TabIndex = 4;
            this.buttonAplikujNastavenia.Text = "Aplikuj nastavenia";
            this.buttonAplikujNastavenia.UseVisualStyleBackColor = true;
            this.buttonAplikujNastavenia.Click += new System.EventHandler(this.buttonAplikujNastavenia_Click);
            // 
            // checkBoxMedzeryInterpunkcia
            // 
            this.checkBoxMedzeryInterpunkcia.AutoSize = true;
            this.checkBoxMedzeryInterpunkcia.Location = new System.Drawing.Point(12, 112);
            this.checkBoxMedzeryInterpunkcia.Name = "checkBoxMedzeryInterpunkcia";
            this.checkBoxMedzeryInterpunkcia.Size = new System.Drawing.Size(136, 17);
            this.checkBoxMedzeryInterpunkcia.TabIndex = 3;
            this.checkBoxMedzeryInterpunkcia.Text = "Medzery a interpunkciu";
            this.checkBoxMedzeryInterpunkcia.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrazdneRiadky
            // 
            this.checkBoxPrazdneRiadky.AutoSize = true;
            this.checkBoxPrazdneRiadky.Location = new System.Drawing.Point(12, 88);
            this.checkBoxPrazdneRiadky.Name = "checkBoxPrazdneRiadky";
            this.checkBoxPrazdneRiadky.Size = new System.Drawing.Size(96, 17);
            this.checkBoxPrazdneRiadky.TabIndex = 2;
            this.checkBoxPrazdneRiadky.Text = "Prazdne riadky";
            this.checkBoxPrazdneRiadky.UseVisualStyleBackColor = true;
            // 
            // checkBoxDiakritika
            // 
            this.checkBoxDiakritika.AutoSize = true;
            this.checkBoxDiakritika.Location = new System.Drawing.Point(12, 64);
            this.checkBoxDiakritika.Name = "checkBoxDiakritika";
            this.checkBoxDiakritika.Size = new System.Drawing.Size(70, 17);
            this.checkBoxDiakritika.TabIndex = 1;
            this.checkBoxDiakritika.Text = "Diakritiku";
            this.checkBoxDiakritika.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odstranit:";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(496, 463);
            this.textBox1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(150, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 463);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kontrola";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 529);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusProgressLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusPercentLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAplikujNastavenia;
        private System.Windows.Forms.CheckBox checkBoxMedzeryInterpunkcia;
        private System.Windows.Forms.CheckBox checkBoxPrazdneRiadky;
        private System.Windows.Forms.CheckBox checkBoxDiakritika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label labelPocetZnakov;
        private System.Windows.Forms.Label labelPocetViet;
        private System.Windows.Forms.Label labelPocetRiadkov;
        private System.Windows.Forms.Label labelPocetSlov;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}

