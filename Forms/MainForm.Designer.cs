namespace flappyBird
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PlayBtn = new System.Windows.Forms.Button();
            this.HighScoreBtn = new System.Windows.Forms.Button();
            this.Levelchoosing = new System.Windows.Forms.ComboBox();
            this.ResetScoreBtn = new System.Windows.Forms.Button();
            this.flpColorchoosing = new System.Windows.Forms.ComboBox();
            this.flappypresentpic = new System.Windows.Forms.PictureBox();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeColorchoosing = new System.Windows.Forms.ComboBox();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.editgamepic = new System.Windows.Forms.PictureBox();
            this.ChoosePipespic = new System.Windows.Forms.PictureBox();
            this.chooseflappypic = new System.Windows.Forms.PictureBox();
            this.choosebackgroundpic = new System.Windows.Forms.PictureBox();
            this.Musicbtn = new System.Windows.Forms.Button();
            this.BackgroundChoosing = new System.Windows.Forms.ComboBox();
            this.pipepresentpic = new System.Windows.Forms.PictureBox();
            this.Applybtn = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Infobtn = new System.Windows.Forms.Button();
            this.ChooseLvlPic = new System.Windows.Forms.PictureBox();
            this.Titlestimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappypresentpic)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editgamepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoosePipespic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseflappypic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosebackgroundpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipepresentpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseLvlPic)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayBtn.BackgroundImage = global::flappyBird.Properties.Resources.PlayBtn;
            this.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayBtn.FlatAppearance.BorderSize = 0;
            this.PlayBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PlayBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PlayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Location = new System.Drawing.Point(181, 204);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(88, 57);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            this.PlayBtn.MouseEnter += new System.EventHandler(this.PlayBtn_MouseEnter);
            this.PlayBtn.MouseLeave += new System.EventHandler(this.PlayBtn_MouseLeave);
            // 
            // HighScoreBtn
            // 
            this.HighScoreBtn.BackColor = System.Drawing.Color.Transparent;
            this.HighScoreBtn.BackgroundImage = global::flappyBird.Properties.Resources.RanksBtn;
            this.HighScoreBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HighScoreBtn.FlatAppearance.BorderSize = 0;
            this.HighScoreBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.HighScoreBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HighScoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HighScoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HighScoreBtn.Location = new System.Drawing.Point(281, 204);
            this.HighScoreBtn.Name = "HighScoreBtn";
            this.HighScoreBtn.Size = new System.Drawing.Size(88, 57);
            this.HighScoreBtn.TabIndex = 1;
            this.HighScoreBtn.UseVisualStyleBackColor = false;
            this.HighScoreBtn.Click += new System.EventHandler(this.HighScoreBtn_Click);
            this.HighScoreBtn.MouseEnter += new System.EventHandler(this.HighScoreBtn_MouseEnter);
            this.HighScoreBtn.MouseLeave += new System.EventHandler(this.HighScoreBtn_MouseLeave);
            // 
            // Levelchoosing
            // 
            this.Levelchoosing.FormattingEnabled = true;
            this.Levelchoosing.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard"});
            this.Levelchoosing.Location = new System.Drawing.Point(125, 58);
            this.Levelchoosing.Name = "Levelchoosing";
            this.Levelchoosing.Size = new System.Drawing.Size(193, 21);
            this.Levelchoosing.TabIndex = 3;
            // 
            // ResetScoreBtn
            // 
            this.ResetScoreBtn.BackColor = System.Drawing.Color.Transparent;
            this.ResetScoreBtn.BackgroundImage = global::flappyBird.Properties.Resources.ResetHighScoreBtn;
            this.ResetScoreBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetScoreBtn.FlatAppearance.BorderSize = 0;
            this.ResetScoreBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ResetScoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ResetScoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetScoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ResetScoreBtn.ForeColor = System.Drawing.Color.Black;
            this.ResetScoreBtn.Location = new System.Drawing.Point(12, 152);
            this.ResetScoreBtn.Name = "ResetScoreBtn";
            this.ResetScoreBtn.Size = new System.Drawing.Size(138, 31);
            this.ResetScoreBtn.TabIndex = 5;
            this.ResetScoreBtn.UseVisualStyleBackColor = false;
            this.ResetScoreBtn.Click += new System.EventHandler(this.ResetScoreBtn_Click_1);
            this.ResetScoreBtn.MouseEnter += new System.EventHandler(this.ResetScoreBtn_MouseEnter);
            this.ResetScoreBtn.MouseLeave += new System.EventHandler(this.ResetScoreBtn_MouseLeave);
            // 
            // flpColorchoosing
            // 
            this.flpColorchoosing.FormattingEnabled = true;
            this.flpColorchoosing.Items.AddRange(new object[] {
            "Green",
            "Orange",
            "Blue",
            "Purple",
            "Red",
            "Bold Green",
            "Gray",
            "Angry Bird",
            "Turtle"});
            this.flpColorchoosing.Location = new System.Drawing.Point(12, 73);
            this.flpColorchoosing.Name = "flpColorchoosing";
            this.flpColorchoosing.Size = new System.Drawing.Size(121, 21);
            this.flpColorchoosing.TabIndex = 6;
            this.flpColorchoosing.Text = "Blue";
            this.flpColorchoosing.SelectedIndexChanged += new System.EventHandler(this.Colorchoosing_SelectedIndexChanged);
            // 
            // flappypresentpic
            // 
            this.flappypresentpic.BackColor = System.Drawing.Color.Transparent;
            this.flappypresentpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flappypresentpic.Location = new System.Drawing.Point(36, 147);
            this.flappypresentpic.Name = "flappypresentpic";
            this.flappypresentpic.Size = new System.Drawing.Size(64, 51);
            this.flappypresentpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappypresentpic.TabIndex = 8;
            this.flappypresentpic.TabStop = false;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // pipeColorchoosing
            // 
            this.pipeColorchoosing.FormattingEnabled = true;
            this.pipeColorchoosing.Items.AddRange(new object[] {
            "Green",
            "Purple",
            "Red",
            "Yellow",
            "Blue",
            "Pink",
            "Fire",
            "Silver",
            "Gold",
            "Laba",
            "Golden Pillar"});
            this.pipeColorchoosing.Location = new System.Drawing.Point(314, 73);
            this.pipeColorchoosing.Name = "pipeColorchoosing";
            this.pipeColorchoosing.Size = new System.Drawing.Size(121, 21);
            this.pipeColorchoosing.TabIndex = 11;
            this.pipeColorchoosing.Text = "Green";
            this.pipeColorchoosing.SelectedIndexChanged += new System.EventHandler(this.pipeColorchoosing_SelectedIndexChanged);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackgroundImage = global::flappyBird.Properties.Resources.RegularBackground;
            this.SettingsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsPanel.Controls.Add(this.editgamepic);
            this.SettingsPanel.Controls.Add(this.ChoosePipespic);
            this.SettingsPanel.Controls.Add(this.chooseflappypic);
            this.SettingsPanel.Controls.Add(this.choosebackgroundpic);
            this.SettingsPanel.Controls.Add(this.Musicbtn);
            this.SettingsPanel.Controls.Add(this.BackgroundChoosing);
            this.SettingsPanel.Controls.Add(this.pipepresentpic);
            this.SettingsPanel.Controls.Add(this.Applybtn);
            this.SettingsPanel.Controls.Add(this.pipeColorchoosing);
            this.SettingsPanel.Controls.Add(this.flappypresentpic);
            this.SettingsPanel.Controls.Add(this.flpColorchoosing);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(439, 303);
            this.SettingsPanel.TabIndex = 12;
            this.SettingsPanel.Visible = false;
            // 
            // editgamepic
            // 
            this.editgamepic.BackColor = System.Drawing.Color.Transparent;
            this.editgamepic.BackgroundImage = global::flappyBird.Properties.Resources.EditTheGameInYourOwnImage;
            this.editgamepic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editgamepic.Location = new System.Drawing.Point(68, 261);
            this.editgamepic.Name = "editgamepic";
            this.editgamepic.Size = new System.Drawing.Size(301, 35);
            this.editgamepic.TabIndex = 21;
            this.editgamepic.TabStop = false;
            // 
            // ChoosePipespic
            // 
            this.ChoosePipespic.BackColor = System.Drawing.Color.Transparent;
            this.ChoosePipespic.BackgroundImage = global::flappyBird.Properties.Resources.choosepipescolorimage1;
            this.ChoosePipespic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChoosePipespic.Location = new System.Drawing.Point(310, 31);
            this.ChoosePipespic.Name = "ChoosePipespic";
            this.ChoosePipespic.Size = new System.Drawing.Size(125, 36);
            this.ChoosePipespic.TabIndex = 20;
            this.ChoosePipespic.TabStop = false;
            // 
            // chooseflappypic
            // 
            this.chooseflappypic.BackColor = System.Drawing.Color.Transparent;
            this.chooseflappypic.BackgroundImage = global::flappyBird.Properties.Resources.chooseflappycolor1;
            this.chooseflappypic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chooseflappypic.Location = new System.Drawing.Point(9, 31);
            this.chooseflappypic.Name = "chooseflappypic";
            this.chooseflappypic.Size = new System.Drawing.Size(130, 36);
            this.chooseflappypic.TabIndex = 19;
            this.chooseflappypic.TabStop = false;
            // 
            // choosebackgroundpic
            // 
            this.choosebackgroundpic.BackColor = System.Drawing.Color.Transparent;
            this.choosebackgroundpic.BackgroundImage = global::flappyBird.Properties.Resources.backgroundcolorimage1;
            this.choosebackgroundpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.choosebackgroundpic.Location = new System.Drawing.Point(151, 23);
            this.choosebackgroundpic.Name = "choosebackgroundpic";
            this.choosebackgroundpic.Size = new System.Drawing.Size(144, 44);
            this.choosebackgroundpic.TabIndex = 18;
            this.choosebackgroundpic.TabStop = false;
            // 
            // Musicbtn
            // 
            this.Musicbtn.BackColor = System.Drawing.Color.Transparent;
            this.Musicbtn.BackgroundImage = global::flappyBird.Properties.Resources.StopMusic;
            this.Musicbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Musicbtn.FlatAppearance.BorderSize = 0;
            this.Musicbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Musicbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Musicbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Musicbtn.Location = new System.Drawing.Point(400, 270);
            this.Musicbtn.Name = "Musicbtn";
            this.Musicbtn.Size = new System.Drawing.Size(26, 23);
            this.Musicbtn.TabIndex = 17;
            this.Musicbtn.UseVisualStyleBackColor = false;
            this.Musicbtn.Click += new System.EventHandler(this.Musicbtn_Click_1);
            this.Musicbtn.MouseEnter += new System.EventHandler(this.Musicbtn_MouseEnter);
            this.Musicbtn.MouseLeave += new System.EventHandler(this.Musicbtn_MouseLeave);
            // 
            // BackgroundChoosing
            // 
            this.BackgroundChoosing.FormattingEnabled = true;
            this.BackgroundChoosing.Items.AddRange(new object[] {
            "Laba",
            "Ocean",
            "Regular Night",
            "Regular",
            "Aquarium",
            "Mario"});
            this.BackgroundChoosing.Location = new System.Drawing.Point(161, 73);
            this.BackgroundChoosing.Name = "BackgroundChoosing";
            this.BackgroundChoosing.Size = new System.Drawing.Size(121, 21);
            this.BackgroundChoosing.TabIndex = 15;
            this.BackgroundChoosing.Text = "Regular";
            this.BackgroundChoosing.SelectedIndexChanged += new System.EventHandler(this.BackgroundChoosing_SelectedIndexChanged);
            // 
            // pipepresentpic
            // 
            this.pipepresentpic.BackColor = System.Drawing.Color.Transparent;
            this.pipepresentpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipepresentpic.Location = new System.Drawing.Point(344, 131);
            this.pipepresentpic.Name = "pipepresentpic";
            this.pipepresentpic.Size = new System.Drawing.Size(50, 99);
            this.pipepresentpic.TabIndex = 13;
            this.pipepresentpic.TabStop = false;
            // 
            // Applybtn
            // 
            this.Applybtn.BackColor = System.Drawing.Color.Transparent;
            this.Applybtn.BackgroundImage = global::flappyBird.Properties.Resources.applyimage;
            this.Applybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Applybtn.FlatAppearance.BorderSize = 0;
            this.Applybtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Applybtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Applybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Applybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Applybtn.Location = new System.Drawing.Point(161, 147);
            this.Applybtn.Name = "Applybtn";
            this.Applybtn.Size = new System.Drawing.Size(121, 51);
            this.Applybtn.TabIndex = 12;
            this.Applybtn.UseVisualStyleBackColor = false;
            this.Applybtn.Click += new System.EventHandler(this.Applybtn_Click);
            this.Applybtn.MouseEnter += new System.EventHandler(this.Applybtn_MouseEnter);
            this.Applybtn.MouseLeave += new System.EventHandler(this.Applybtn_MouseLeave);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BackgroundImage = global::flappyBird.Properties.Resources.settingspic;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SettingsButton.Location = new System.Drawing.Point(330, 147);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(83, 40);
            this.SettingsButton.TabIndex = 13;
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            this.SettingsButton.MouseEnter += new System.EventHandler(this.SettingsButton_MouseEnter);
            this.SettingsButton.MouseLeave += new System.EventHandler(this.SettingsButton_MouseLeave);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 303);
            this.splitter1.TabIndex = 14;
            this.splitter1.TabStop = false;
            // 
            // Infobtn
            // 
            this.Infobtn.BackColor = System.Drawing.Color.Transparent;
            this.Infobtn.BackgroundImage = global::flappyBird.Properties.Resources.Infobtn;
            this.Infobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Infobtn.FlatAppearance.BorderSize = 0;
            this.Infobtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Infobtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Infobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Infobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Infobtn.Location = new System.Drawing.Point(81, 204);
            this.Infobtn.Name = "Infobtn";
            this.Infobtn.Size = new System.Drawing.Size(88, 57);
            this.Infobtn.TabIndex = 18;
            this.Infobtn.UseVisualStyleBackColor = false;
            this.Infobtn.Click += new System.EventHandler(this.Infobtn_Click);
            this.Infobtn.MouseEnter += new System.EventHandler(this.Infobtn_MouseEnter);
            this.Infobtn.MouseLeave += new System.EventHandler(this.Infobtn_MouseLeave);
            // 
            // ChooseLvlPic
            // 
            this.ChooseLvlPic.BackColor = System.Drawing.Color.Transparent;
            this.ChooseLvlPic.BackgroundImage = global::flappyBird.Properties.Resources.chooselevel;
            this.ChooseLvlPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChooseLvlPic.Location = new System.Drawing.Point(106, 12);
            this.ChooseLvlPic.Name = "ChooseLvlPic";
            this.ChooseLvlPic.Size = new System.Drawing.Size(226, 31);
            this.ChooseLvlPic.TabIndex = 19;
            this.ChooseLvlPic.TabStop = false;
            // 
            // Titlestimer
            // 
            this.Titlestimer.Interval = 1000;
            this.Titlestimer.Tick += new System.EventHandler(this.Titlestimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flappyBird.Properties.Resources.MainPhot;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(439, 303);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.ResetScoreBtn);
            this.Controls.Add(this.Levelchoosing);
            this.Controls.Add(this.HighScoreBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.Infobtn);
            this.Controls.Add(this.ChooseLvlPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlappyBird";
            ((System.ComponentModel.ISupportInitialize)(this.flappypresentpic)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editgamepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoosePipespic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseflappypic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosebackgroundpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipepresentpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseLvlPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button HighScoreBtn;
        private System.Windows.Forms.ComboBox Levelchoosing;
        private System.Windows.Forms.Button ResetScoreBtn;
        private System.Windows.Forms.ComboBox flpColorchoosing;
        private System.Windows.Forms.PictureBox flappypresentpic;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.ComboBox pipeColorchoosing;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button Applybtn;
        private System.Windows.Forms.PictureBox pipepresentpic;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ComboBox BackgroundChoosing;
        private System.Windows.Forms.Button Musicbtn;
        private System.Windows.Forms.Button Infobtn;
        private System.Windows.Forms.PictureBox choosebackgroundpic;
        private System.Windows.Forms.PictureBox chooseflappypic;
        private System.Windows.Forms.PictureBox ChoosePipespic;
        private System.Windows.Forms.PictureBox editgamepic;
        private System.Windows.Forms.PictureBox ChooseLvlPic;
        private System.Windows.Forms.Timer Titlestimer;
    }
}