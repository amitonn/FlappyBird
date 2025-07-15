using flappyBird.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace flappyBird
{
    
    public partial class MainForm : Form
    {
        private WorksType chooselevel;
        private SoundPlayer backgroundsound = new SoundPlayer();
        private MainFormManager manager = new MainFormManager();
        private Image[] flppics = new Image[3];
        private Image pipepics;
        int flappyindex = 0;
        private WorksType music;
        public MainForm()
        {
           
            InitializeComponent();
            PlayBtn.Parent = this;
            RefreshTimer.Enabled = true;
            Titlestimer.Enabled = true;
            flppics[0] = Resources.BBird1;
            flppics[1] = Resources.BBird2;
            flppics[2] = Resources.BBird3;
            pipepics = Resources.UpAmod;
            backgroundsound.SoundLocation = "Flappy_Bird_Theme_Song.wav";
            backgroundsound.PlayLooping();
            music = WorksType.On;
            chooselevel = WorksType.No;
            
        }
        private void ResetScoreBtn_Click_1(object sender, EventArgs e)
        {
            int lvl = Levelchoosing.SelectedIndex; // Getting the index of the combobox into "lvl".
            manager.ResetScore(lvl); // Reseting the highest score of the level the user choose, the highest score will be 0 in the difficulty level the user chooses.
        }
        private void ResetScoreBtn_MouseEnter(object sender, EventArgs e)
        {
            ResetScoreBtn.BackgroundImage = Resources.ResetHighscoreBtnShining;
            ResetScoreBtn.BackColor = Color.Transparent;
        }
        private void ResetScoreBtn_MouseLeave(object sender, EventArgs e)
        {
            ResetScoreBtn.BackgroundImage = Resources.ResetHighScoreBtn;
        }
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            if (flappyindex == 3)
            {
                flappyindex = 0;
            }
            flappypresentpic.BackgroundImage = flppics[flappyindex];
            flappyindex++;
            pipepresentpic.BackgroundImage = pipepics;
            

        }
        private void Applybtn_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = false;
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = true;
        }
        private void SettingsButton_MouseEnter(object sender, EventArgs e)
        {
            SettingsButton.BackgroundImage = Resources.shiningsettings;
        }
        private void SettingsButton_MouseLeave(object sender, EventArgs e)
        {
            SettingsButton.BackgroundImage = Resources.settingspic;
        }
        private void Colorchoosing_SelectedIndexChanged(object sender, EventArgs e)
        {
            int colorindex = flpColorchoosing.SelectedIndex;
            manager.FlappyChangingColor(colorindex, this.flppics);
        }
        private void pipeColorchoosing_SelectedIndexChanged(object sender, EventArgs e)
        {
            int colorindex = pipeColorchoosing.SelectedIndex;
            pipepics = manager.PipeChangingColor(colorindex);
        }
        private void BackgroundChoosing_SelectedIndexChanged(object sender, EventArgs e)
        {
            int backgroundindex = BackgroundChoosing.SelectedIndex;
            SettingsPanel.BackgroundImage = manager.BackgroundChanging(backgroundindex);
        }
        private void Applybtn_MouseEnter(object sender, EventArgs e)
        {
            Applybtn.BackgroundImage = Resources.shiningApplyimage;
            Applybtn.BackColor = Color.Transparent;
        }
        private void Applybtn_MouseLeave(object sender, EventArgs e)
        {
            Applybtn.BackgroundImage = Resources.applyimage;
            Applybtn.BackColor = Color.Transparent;
        }
        private void Musicbtn_Click_1(object sender, EventArgs e)
        {
            switch (music)
            { 
                case WorksType.On:
                    music = WorksType.Off;
                    Musicbtn.BackgroundImage = Resources.PlayMusic;
                    backgroundsound.Stop();
                    break;
                case WorksType.Off:
                    music = WorksType.On;
                    Musicbtn.BackgroundImage = Resources.StopMusic;
                    backgroundsound.PlayLooping();
                    break;
            }
        }
        private void Infobtn_Click(object sender, EventArgs e)
        {
            InfoForm info = new InfoForm();
            info.Show();
        }
        private void Infobtn_MouseEnter(object sender, EventArgs e)
        {
            Infobtn.BackgroundImage = Resources.LightInfoBtn;

        }
        private void Infobtn_MouseLeave(object sender, EventArgs e)
        {
            Infobtn.BackgroundImage = Resources.Infobtn;
        }
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            int lvl = Levelchoosing.SelectedIndex; //Getting the index of the combobox into "lvl", the index shows the level of the difficulty the game will be.
            int color = flpColorchoosing.SelectedIndex; //Getting the index of the combobox into "color", the index shows the number of the color the user wants the flappy bird to be.
            int pipecolor = pipeColorchoosing.SelectedIndex;
            int backgroundindex = BackgroundChoosing.SelectedIndex;
            manager.PlayButton(lvl, color,pipecolor,backgroundindex);//The manager will now take the indexes and use it to build the form's game.
        }
        private void PlayBtn_MouseEnter(object sender, EventArgs e)
        {
            PlayBtn.BackgroundImage = Resources.LightPlayBtn;
        }
        private void PlayBtn_MouseLeave(object sender, EventArgs e)
        {
            PlayBtn.BackgroundImage = Resources.PlayBtn;
        }
        private void HighScoreBtn_Click(object sender, EventArgs e)
        {
            manager.OpenHighScore(); //The manager class will open the form called "HighScoreBoard" which will show the highest score in each difficulty level.
        }
        private void HighScoreBtn_MouseEnter(object sender, EventArgs e)
        {
            HighScoreBtn.BackgroundImage = Resources.LightRanksBtn;
        }
        private void HighScoreBtn_MouseLeave(object sender, EventArgs e)
        {
            HighScoreBtn.BackgroundImage = Resources.RanksBtn;
        }
        private void Musicbtn_MouseEnter(object sender, EventArgs e)
        {
            switch (music)
            {
                case WorksType.Off:
                    Musicbtn.BackgroundImage = Resources.ShiningPlayMusic;
                    break;
                case WorksType.On:
                    Musicbtn.BackgroundImage = Resources.ShinigStopMusic;
                    break;
            }
        }
        private void Musicbtn_MouseLeave(object sender, EventArgs e)
        {
            switch (music)
            {
                case WorksType.Off:
                    Musicbtn.BackgroundImage = Resources.PlayMusic;
                    break;
                case WorksType.On:
                    Musicbtn.BackgroundImage = Resources.StopMusic;
                    break;
            }
        }

        private void Titlestimer_Tick(object sender, EventArgs e)
        {
            switch (chooselevel)
            {
                case WorksType.No:
                    ChooseLvlPic.BackgroundImage = Resources.LightChooseLevel;
                    editgamepic.BackgroundImage = Resources.EditTheGameInYourOwnImageShining;
                    chooselevel = WorksType.Yes;
                    break;
                case WorksType.Yes:
                    ChooseLvlPic.BackgroundImage = Resources.chooselevel;
                    editgamepic.BackgroundImage = Resources.EditTheGameInYourOwnImage;
                    chooselevel = WorksType.No;
                    break;

            }
        }
    }

    public enum WorksType
    {
        On,Off
        ,Yes,No
    }
}
