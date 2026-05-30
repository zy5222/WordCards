namespace WordCards
{
    partial class frmEditWord
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
            this.grpWord = new System.Windows.Forms.GroupBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.grpPhonogram = new System.Windows.Forms.GroupBox();
            this.txtPhonogram = new System.Windows.Forms.TextBox();
            this.grpSoundPath = new System.Windows.Forms.GroupBox();
            this.txtSoundPath = new System.Windows.Forms.TextBox();
            this.grpExplain = new System.Windows.Forms.GroupBox();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpWord.SuspendLayout();
            this.grpPhonogram.SuspendLayout();
            this.grpSoundPath.SuspendLayout();
            this.grpExplain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWord
            // 
            this.grpWord.Controls.Add(this.txtWord);
            this.grpWord.Location = new System.Drawing.Point(10, 14);
            this.grpWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpWord.Name = "grpWord";
            this.grpWord.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpWord.Size = new System.Drawing.Size(426, 77);
            this.grpWord.TabIndex = 0;
            this.grpWord.TabStop = false;
            this.grpWord.Text = "單字";
            // 
            // txtWord
            // 
            this.txtWord.BackColor = System.Drawing.Color.White;
            this.txtWord.Location = new System.Drawing.Point(20, 30);
            this.txtWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(400, 40);
            this.txtWord.TabIndex = 0;
            // 
            // grpPhonogram
            // 
            this.grpPhonogram.Controls.Add(this.txtPhonogram);
            this.grpPhonogram.Location = new System.Drawing.Point(10, 103);
            this.grpPhonogram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPhonogram.Name = "grpPhonogram";
            this.grpPhonogram.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPhonogram.Size = new System.Drawing.Size(426, 108);
            this.grpPhonogram.TabIndex = 1;
            this.grpPhonogram.TabStop = false;
            this.grpPhonogram.Text = "音標";
            // 
            // txtPhonogram
            // 
            this.txtPhonogram.BackColor = System.Drawing.Color.White;
            this.txtPhonogram.Location = new System.Drawing.Point(20, 40);
            this.txtPhonogram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhonogram.Multiline = true;
            this.txtPhonogram.Name = "txtPhonogram";
            this.txtPhonogram.Size = new System.Drawing.Size(400, 40);
            this.txtPhonogram.TabIndex = 1;
            // 
            // grpSoundPath
            // 
            this.grpSoundPath.Controls.Add(this.txtSoundPath);
            this.grpSoundPath.Location = new System.Drawing.Point(10, 237);
            this.grpSoundPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSoundPath.Name = "grpSoundPath";
            this.grpSoundPath.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSoundPath.Size = new System.Drawing.Size(426, 108);
            this.grpSoundPath.TabIndex = 1;
            this.grpSoundPath.TabStop = false;
            this.grpSoundPath.Text = "音檔路徑";
            // 
            // txtSoundPath
            // 
            this.txtSoundPath.BackColor = System.Drawing.Color.White;
            this.txtSoundPath.Location = new System.Drawing.Point(20, 40);
            this.txtSoundPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoundPath.Multiline = true;
            this.txtSoundPath.Name = "txtSoundPath";
            this.txtSoundPath.Size = new System.Drawing.Size(400, 40);
            this.txtSoundPath.TabIndex = 2;
            // 
            // grpExplain
            // 
            this.grpExplain.Controls.Add(this.txtExplain);
            this.grpExplain.Location = new System.Drawing.Point(10, 369);
            this.grpExplain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpExplain.Name = "grpExplain";
            this.grpExplain.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpExplain.Size = new System.Drawing.Size(426, 208);
            this.grpExplain.TabIndex = 1;
            this.grpExplain.TabStop = false;
            this.grpExplain.Text = "解釋";
            // 
            // txtExplain
            // 
            this.txtExplain.BackColor = System.Drawing.Color.White;
            this.txtExplain.Location = new System.Drawing.Point(20, 40);
            this.txtExplain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(400, 147);
            this.txtExplain.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSave.Location = new System.Drawing.Point(307, 588);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 44);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEditWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(454, 640);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpExplain);
            this.Controls.Add(this.grpSoundPath);
            this.Controls.Add(this.grpPhonogram);
            this.Controls.Add(this.grpWord);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEditWord";
            this.Text = "音標";
            this.grpWord.ResumeLayout(false);
            this.grpWord.PerformLayout();
            this.grpPhonogram.ResumeLayout(false);
            this.grpPhonogram.PerformLayout();
            this.grpSoundPath.ResumeLayout(false);
            this.grpSoundPath.PerformLayout();
            this.grpExplain.ResumeLayout(false);
            this.grpExplain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWord;
        private System.Windows.Forms.GroupBox grpPhonogram;
        private System.Windows.Forms.GroupBox grpSoundPath;
        private System.Windows.Forms.GroupBox grpExplain;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtPhonogram;
        private System.Windows.Forms.TextBox txtSoundPath;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.Button btnSave;
    }
}