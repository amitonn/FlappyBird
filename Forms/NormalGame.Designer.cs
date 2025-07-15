namespace flappyBird
{
    partial class NormalGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NormalGame));
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.Scorelbl = new System.Windows.Forms.Label();
            this.Resultpanel = new System.Windows.Forms.Panel();
            this.finalscore = new System.Windows.Forms.Label();
            this.bestscore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menubtn = new System.Windows.Forms.Button();
            this.Resultboard = new System.Windows.Forms.PictureBox();
            this.sound = new AxWMPLib.AxWindowsMediaPlayer();
            this.Jumpsound = new AxWMPLib.AxWindowsMediaPlayer();
            this.startpic = new System.Windows.Forms.PictureBox();
            this.Paused = new System.Windows.Forms.PictureBox();
            this.ArenaPic = new System.Windows.Forms.PictureBox();
            this.StartTimer = new System.Windows.Forms.Timer(this.components);
            this.Resultpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resultboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jumpsound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paused)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArenaPic)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // Scorelbl
            // 
            this.Scorelbl.AutoSize = true;
            this.Scorelbl.BackColor = System.Drawing.Color.Transparent;
            this.Scorelbl.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorelbl.Location = new System.Drawing.Point(280, 9);
            this.Scorelbl.Name = "Scorelbl";
            this.Scorelbl.Size = new System.Drawing.Size(0, 18);
            this.Scorelbl.TabIndex = 1;
            // 
            // Resultpanel
            // 
            this.Resultpanel.BackColor = System.Drawing.Color.Transparent;
            this.Resultpanel.Controls.Add(this.finalscore);
            this.Resultpanel.Controls.Add(this.bestscore);
            this.Resultpanel.Controls.Add(this.pictureBox1);
            this.Resultpanel.Controls.Add(this.Menubtn);
            this.Resultpanel.Controls.Add(this.Resultboard);
            this.Resultpanel.Location = new System.Drawing.Point(158, 43);
            this.Resultpanel.Name = "Resultpanel";
            this.Resultpanel.Size = new System.Drawing.Size(240, 287);
            this.Resultpanel.TabIndex = 3;
            this.Resultpanel.Visible = false;
            // 
            // finalscore
            // 
            this.finalscore.AutoSize = true;
            this.finalscore.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalscore.Location = new System.Drawing.Point(200, 137);
            this.finalscore.Name = "finalscore";
            this.finalscore.Size = new System.Drawing.Size(0, 18);
            this.finalscore.TabIndex = 2;
            // 
            // bestscore
            // 
            this.bestscore.AutoSize = true;
            this.bestscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bestscore.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestscore.Location = new System.Drawing.Point(200, 188);
            this.bestscore.Name = "bestscore";
            this.bestscore.Size = new System.Drawing.Size(0, 18);
            this.bestscore.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::flappyBird.Properties.Resources.GameOver;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(42, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 56);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Menubtn
            // 
            this.Menubtn.BackColor = System.Drawing.Color.White;
            this.Menubtn.BackgroundImage = global::flappyBird.Properties.Resources.Menu_Button;
            this.Menubtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menubtn.FlatAppearance.BorderSize = 0;
            this.Menubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menubtn.Location = new System.Drawing.Point(86, 244);
            this.Menubtn.Name = "Menubtn";
            this.Menubtn.Size = new System.Drawing.Size(75, 39);
            this.Menubtn.TabIndex = 1;
            this.Menubtn.UseVisualStyleBackColor = false;
            this.Menubtn.Click += new System.EventHandler(this.Menubtn_Click);
            this.Menubtn.MouseEnter += new System.EventHandler(this.Menubtn_MouseEnter);
            this.Menubtn.MouseLeave += new System.EventHandler(this.Menubtn_MouseLeave);
            // 
            // Resultboard
            // 
            this.Resultboard.BackColor = System.Drawing.Color.Transparent;
            this.Resultboard.BackgroundImage = global::flappyBird.Properties.Resources.ResultScreen;
            this.Resultboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Resultboard.Location = new System.Drawing.Point(0, 98);
            this.Resultboard.Name = "Resultboard";
            this.Resultboard.Size = new System.Drawing.Size(238, 140);
            this.Resultboard.TabIndex = 0;
            this.Resultboard.TabStop = false;
            // 
            // sound
            // 
            this.sound.Enabled = true;
            this.sound.Location = new System.Drawing.Point(8, 8);
            this.sound.Name = "sound";
            this.sound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("sound.OcxState")));
            this.sound.Size = new System.Drawing.Size(75, 23);
            this.sound.TabIndex = 4;
            this.sound.Visible = false;
            // 
            // Jumpsound
            // 
            this.Jumpsound.Enabled = true;
            this.Jumpsound.Location = new System.Drawing.Point(12, 86);
            this.Jumpsound.Name = "Jumpsound";
            this.Jumpsound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Jumpsound.OcxState")));
            this.Jumpsound.Size = new System.Drawing.Size(75, 23);
            this.Jumpsound.TabIndex = 5;
            this.Jumpsound.Visible = false;
            // 
            // startpic
            // 
            this.startpic.BackColor = System.Drawing.Color.Transparent;
            this.startpic.BackgroundImage = global::flappyBird.Properties.Resources.pressspace;
            this.startpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startpic.Location = new System.Drawing.Point(125, 145);
            this.startpic.Name = "startpic";
            this.startpic.Size = new System.Drawing.Size(314, 50);
            this.startpic.TabIndex = 7;
            this.startpic.TabStop = false;
            // 
            // Paused
            // 
            this.Paused.BackColor = System.Drawing.Color.Transparent;
            this.Paused.BackgroundImage = global::flappyBird.Properties.Resources.paused;
            this.Paused.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Paused.Location = new System.Drawing.Point(125, 123);
            this.Paused.Name = "Paused";
            this.Paused.Size = new System.Drawing.Size(302, 101);
            this.Paused.TabIndex = 6;
            this.Paused.TabStop = false;
            this.Paused.Visible = false;
            // 
            // ArenaPic
            // 
            this.ArenaPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ArenaPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArenaPic.Location = new System.Drawing.Point(0, 0);
            this.ArenaPic.Name = "ArenaPic";
            this.ArenaPic.Size = new System.Drawing.Size(565, 375);
            this.ArenaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArenaPic.TabIndex = 0;
            this.ArenaPic.TabStop = false;
            this.ArenaPic.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // StartTimer
            // 
            this.StartTimer.Interval = 1000;
            this.StartTimer.Tick += new System.EventHandler(this.StartTimer_Tick);
            // 
            // NormalGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(565, 375);
            this.ControlBox = false;
            this.Controls.Add(this.Scorelbl);
            this.Controls.Add(this.Resultpanel);
            this.Controls.Add(this.Paused);
            this.Controls.Add(this.ArenaPic);
            this.Controls.Add(this.sound);
            this.Controls.Add(this.Jumpsound);
            this.Controls.Add(this.startpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NormalGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Normal Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NormalGame_KeyDown);
            this.Resultpanel.ResumeLayout(false);
            this.Resultpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resultboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jumpsound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paused)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArenaPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ArenaPic;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.Label Scorelbl;
        private System.Windows.Forms.Panel Resultpanel;
        private System.Windows.Forms.Label finalscore;
        private System.Windows.Forms.Label bestscore;
        private System.Windows.Forms.Button Menubtn;
        private System.Windows.Forms.PictureBox Resultboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer sound;
        private AxWMPLib.AxWindowsMediaPlayer Jumpsound;
        private System.Windows.Forms.PictureBox Paused;
        private System.Windows.Forms.PictureBox startpic;
        private System.Windows.Forms.Timer StartTimer;
    }
}