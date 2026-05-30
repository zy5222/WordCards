namespace WordCards
{
    partial class frmWordCards
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWordCards));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.timPlayer = new System.Windows.Forms.Timer(this.components);
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtPhonogram = new System.Windows.Forms.TextBox();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnAutoPlay = new System.Windows.Forms.Button();
            this.palMain = new System.Windows.Forms.Panel();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.lstWordList = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.palMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(221)))), ((int)(((byte)(239)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 410);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1007, 40);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslMessage
            // 
            this.tsslMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(114, 30);
            this.tsslMessage.Text = "Message";
            // 
            // timPlayer
            // 
            this.timPlayer.Interval = 2000;
            this.timPlayer.Tick += new System.EventHandler(this.timPlayer_Tick);
            // 
            // txtWord
            // 
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.txtWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWord.Font = new System.Drawing.Font("Microsoft JhengHei", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWord.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtWord.Location = new System.Drawing.Point(237, 29);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(598, 71);
            this.txtWord.TabIndex = 1;
            this.txtWord.Text = "abacus";
            // 
            // txtPhonogram
            // 
            this.txtPhonogram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhonogram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.txtPhonogram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhonogram.Font = new System.Drawing.Font("Microsoft JhengHei", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhonogram.ForeColor = System.Drawing.Color.Green;
            this.txtPhonogram.Location = new System.Drawing.Point(237, 113);
            this.txtPhonogram.Name = "txtPhonogram";
            this.txtPhonogram.Size = new System.Drawing.Size(598, 36);
            this.txtPhonogram.TabIndex = 2;
            this.txtPhonogram.Text = "ˋæbəkəs";
            // 
            // txtExplain
            // 
            this.txtExplain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExplain.Font = new System.Drawing.Font("Microsoft JhengHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtExplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExplain.Location = new System.Drawing.Point(237, 169);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(598, 238);
            this.txtExplain.TabIndex = 3;
            this.txtExplain.Text = "<aba-=abax-:一種計算工具>+<-us: calculus 小圓石>\t一種利用小圓石幫助計算的工具";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(863, 29);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(113, 120);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // btnAutoPlay
            // 
            this.btnAutoPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoPlay.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAutoPlay.Location = new System.Drawing.Point(863, 161);
            this.btnAutoPlay.Name = "btnAutoPlay";
            this.btnAutoPlay.Size = new System.Drawing.Size(116, 65);
            this.btnAutoPlay.TabIndex = 6;
            this.btnAutoPlay.Text = "Play";
            this.btnAutoPlay.UseVisualStyleBackColor = true;
            this.btnAutoPlay.Click += new System.EventHandler(this.btnAutoPlay_Click);
            // 
            // palMain
            // 
            this.palMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.palMain.Controls.Add(this.txtHelp);
            this.palMain.Controls.Add(this.btnAutoPlay);
            this.palMain.Controls.Add(this.picLogo);
            this.palMain.Controls.Add(this.txtExplain);
            this.palMain.Controls.Add(this.txtPhonogram);
            this.palMain.Controls.Add(this.txtWord);
            this.palMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palMain.Location = new System.Drawing.Point(0, 0);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(1007, 450);
            this.palMain.TabIndex = 1;
            // 
            // txtHelp
            // 
            this.txtHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHelp.Font = new System.Drawing.Font("Microsoft JhengHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHelp.ForeColor = System.Drawing.Color.DarkRed;
            this.txtHelp.Location = new System.Drawing.Point(838, 327);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.Size = new System.Drawing.Size(169, 60);
            this.txtHelp.TabIndex = 8;
            this.txtHelp.Text = "Enter 下一個 Space 重覆";
            // 
            // lstWordList
            // 
            this.lstWordList.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstWordList.FormattingEnabled = true;
            this.lstWordList.ItemHeight = 24;
            this.lstWordList.Location = new System.Drawing.Point(0, 0);
            this.lstWordList.Name = "lstWordList";
            this.lstWordList.Size = new System.Drawing.Size(208, 410);
            this.lstWordList.TabIndex = 9;
            this.lstWordList.SelectedIndexChanged += new System.EventHandler(this.lstWordList_SelectedIndexChanged);
            this.lstWordList.DoubleClick += new System.EventHandler(this.lstWordList_DoubleClick);
            // 
            // frmWordCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 450);
            this.Controls.Add(this.lstWordList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.palMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmWordCards";
            this.Text = "單字卡";
            this.Load += new System.EventHandler(this.frmWordCards_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmWordCards_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.palMain.ResumeLayout(false);
            this.palMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslMessage;
        private System.Windows.Forms.Timer timPlayer;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtPhonogram;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnAutoPlay;
        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.ListBox lstWordList;
    }
}

