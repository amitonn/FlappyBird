namespace flappyBird
{
    partial class HighScoreBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScoreBoard));
            this.NormalL = new System.Windows.Forms.Label();
            this.Hardtitle = new System.Windows.Forms.Label();
            this.Normaltitle = new System.Windows.Forms.Label();
            this.Easytitle = new System.Windows.Forms.Label();
            this.HardL = new System.Windows.Forms.Label();
            this.EasyL = new System.Windows.Forms.Label();
            this.StagePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StagePic)).BeginInit();
            this.SuspendLayout();
            // 
            // NormalL
            // 
            this.NormalL.AutoSize = true;
            this.NormalL.BackColor = System.Drawing.Color.Transparent;
            this.NormalL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NormalL.ForeColor = System.Drawing.Color.Black;
            this.NormalL.Location = new System.Drawing.Point(168, 166);
            this.NormalL.Name = "NormalL";
            this.NormalL.Size = new System.Drawing.Size(0, 18);
            this.NormalL.TabIndex = 0;
            this.NormalL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hardtitle
            // 
            this.Hardtitle.AutoSize = true;
            this.Hardtitle.BackColor = System.Drawing.Color.Transparent;
            this.Hardtitle.Font = new System.Drawing.Font("Monotype Corsiva", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hardtitle.ForeColor = System.Drawing.Color.Black;
            this.Hardtitle.Location = new System.Drawing.Point(257, 39);
            this.Hardtitle.Name = "Hardtitle";
            this.Hardtitle.Size = new System.Drawing.Size(80, 17);
            this.Hardtitle.TabIndex = 1;
            this.Hardtitle.Text = "Hard Level";
            // 
            // Normaltitle
            // 
            this.Normaltitle.AutoSize = true;
            this.Normaltitle.BackColor = System.Drawing.Color.Transparent;
            this.Normaltitle.Font = new System.Drawing.Font("Monotype Corsiva", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Normaltitle.ForeColor = System.Drawing.Color.Black;
            this.Normaltitle.Location = new System.Drawing.Point(134, 78);
            this.Normaltitle.Name = "Normaltitle";
            this.Normaltitle.Size = new System.Drawing.Size(95, 17);
            this.Normaltitle.TabIndex = 2;
            this.Normaltitle.Text = "Normal Level";
            // 
            // Easytitle
            // 
            this.Easytitle.AutoSize = true;
            this.Easytitle.BackColor = System.Drawing.Color.Transparent;
            this.Easytitle.Font = new System.Drawing.Font("Monotype Corsiva", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Easytitle.ForeColor = System.Drawing.Color.Black;
            this.Easytitle.Location = new System.Drawing.Point(386, 102);
            this.Easytitle.Name = "Easytitle";
            this.Easytitle.Size = new System.Drawing.Size(78, 17);
            this.Easytitle.TabIndex = 3;
            this.Easytitle.Text = "Easy Level";
            // 
            // HardL
            // 
            this.HardL.AutoSize = true;
            this.HardL.BackColor = System.Drawing.Color.Transparent;
            this.HardL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.HardL.ForeColor = System.Drawing.Color.Black;
            this.HardL.Location = new System.Drawing.Point(288, 126);
            this.HardL.Name = "HardL";
            this.HardL.Size = new System.Drawing.Size(0, 18);
            this.HardL.TabIndex = 4;
            this.HardL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EasyL
            // 
            this.EasyL.AutoSize = true;
            this.EasyL.BackColor = System.Drawing.Color.Transparent;
            this.EasyL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EasyL.ForeColor = System.Drawing.Color.Black;
            this.EasyL.Location = new System.Drawing.Point(430, 192);
            this.EasyL.Name = "EasyL";
            this.EasyL.Size = new System.Drawing.Size(0, 18);
            this.EasyL.TabIndex = 5;
            this.EasyL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StagePic
            // 
            this.StagePic.BackColor = System.Drawing.Color.Transparent;
            this.StagePic.BackgroundImage = global::flappyBird.Properties.Resources.Winners_stage2;
            this.StagePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StagePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StagePic.Location = new System.Drawing.Point(0, 0);
            this.StagePic.Name = "StagePic";
            this.StagePic.Size = new System.Drawing.Size(603, 394);
            this.StagePic.TabIndex = 6;
            this.StagePic.TabStop = false;
            // 
            // HighScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flappyBird.Properties.Resources.HallOfFameBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 394);
            this.Controls.Add(this.EasyL);
            this.Controls.Add(this.HardL);
            this.Controls.Add(this.Easytitle);
            this.Controls.Add(this.Normaltitle);
            this.Controls.Add(this.Hardtitle);
            this.Controls.Add(this.NormalL);
            this.Controls.Add(this.StagePic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HighScoreBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Champions Stage";
            this.Load += new System.EventHandler(this._1Place_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StagePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NormalL;
        private System.Windows.Forms.Label Hardtitle;
        private System.Windows.Forms.Label Normaltitle;
        private System.Windows.Forms.Label Easytitle;
        private System.Windows.Forms.Label HardL;
        private System.Windows.Forms.Label EasyL;
        private System.Windows.Forms.PictureBox StagePic;
    }
}