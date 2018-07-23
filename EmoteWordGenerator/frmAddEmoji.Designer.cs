namespace EmoteWordGenerator
{
    partial class frmAddEmoji
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
            this.txtEmoji = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmoji
            // 
            this.txtEmoji.Location = new System.Drawing.Point(12, 12);
            this.txtEmoji.Name = "txtEmoji";
            this.txtEmoji.Size = new System.Drawing.Size(288, 20);
            this.txtEmoji.TabIndex = 0;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(12, 38);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(141, 23);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "&Save";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(159, 38);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddEmoji
            // 
            this.AcceptButton = this.btnAction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 72);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txtEmoji);
            this.Name = "frmAddEmoji";
            this.Text = "Emoji";
            this.Load += new System.EventHandler(this.frmAddEmoji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmoji;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
    }
}