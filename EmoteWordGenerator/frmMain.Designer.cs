namespace EmoteWordGenerator
{
    partial class frmMain
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
            this.lblBackground = new System.Windows.Forms.Label();
            this.lblChar = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtPhrase = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cmbBackground = new System.Windows.Forms.ComboBox();
            this.cmbCharacter = new System.Windows.Forms.ComboBox();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBackground
            // 
            this.lblBackground.AutoSize = true;
            this.lblBackground.Location = new System.Drawing.Point(10, 30);
            this.lblBackground.Name = "lblBackground";
            this.lblBackground.Size = new System.Drawing.Size(101, 13);
            this.lblBackground.TabIndex = 0;
            this.lblBackground.Text = "Background Emote:";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Location = new System.Drawing.Point(22, 57);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(89, 13);
            this.lblChar.TabIndex = 1;
            this.lblChar.Text = "Character Emote:";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(5, 84);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(106, 13);
            this.lblWord.TabIndex = 4;
            this.lblWord.Text = "Phrase To Generate:";
            // 
            // txtPhrase
            // 
            this.txtPhrase.Location = new System.Drawing.Point(117, 81);
            this.txtPhrase.Name = "txtPhrase";
            this.txtPhrase.Size = new System.Drawing.Size(174, 20);
            this.txtPhrase.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(117, 107);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cmbBackground
            // 
            this.cmbBackground.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbBackground.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBackground.FormattingEnabled = true;
            this.cmbBackground.Location = new System.Drawing.Point(117, 27);
            this.cmbBackground.Name = "cmbBackground";
            this.cmbBackground.Size = new System.Drawing.Size(174, 21);
            this.cmbBackground.Sorted = true;
            this.cmbBackground.TabIndex = 7;
            // 
            // cmbCharacter
            // 
            this.cmbCharacter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCharacter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCharacter.FormattingEnabled = true;
            this.cmbCharacter.Location = new System.Drawing.Point(117, 54);
            this.cmbCharacter.Name = "cmbCharacter";
            this.cmbCharacter.Size = new System.Drawing.Size(174, 21);
            this.cmbCharacter.Sorted = true;
            this.cmbCharacter.TabIndex = 8;
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(313, 24);
            this.mnuStrip.TabIndex = 9;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addEmoteToolStripMenuItem
            // 
            this.addEmoteToolStripMenuItem.Name = "addEmoteToolStripMenuItem";
            this.addEmoteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addEmoteToolStripMenuItem.Text = "Edit Emoji List";
            this.addEmoteToolStripMenuItem.Click += new System.EventHandler(this.addEmoteToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 135);
            this.Controls.Add(this.cmbCharacter);
            this.Controls.Add(this.cmbBackground);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtPhrase);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblChar);
            this.Controls.Add(this.lblBackground);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "frmMain";
            this.Text = "Emote Word Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBackground;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtPhrase;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cmbBackground;
        private System.Windows.Forms.ComboBox cmbCharacter;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmoteToolStripMenuItem;
    }
}

