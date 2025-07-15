using flappyBird.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyBird
{
    public partial class NormalGame : Form
    {
       
        int score = 0;
        NormalGameManager manager = new NormalGameManager();
        WorksType start;
        WorksType lightstartpic;
        public NormalGame(int color, int pipecolor, int backgroundindex)
        {
            InitializeComponent();
            sound.URL = "Getting_point_sound.wav";
            sound.Ctlcontrols.stop();
            Jumpsound.URL = "JumpSound.wav";
            Jumpsound.Ctlcontrols.stop();
            manager.BuildUs(ArenaPic.Width,ArenaPic.Height,ArenaPic.Size,color, pipecolor);
            manager.BackgroundImage(backgroundindex, ArenaPic);
            Scorelbl.Parent = ArenaPic;
            Resultpanel.Parent = ArenaPic;
            RefreshTimer.Enabled = true;
            Paused.Parent = ArenaPic;
            manager.PauseGame();
            start = WorksType.No;
            startpic.Parent = ArenaPic;
            lightstartpic = WorksType.No;
            StartTimer.Enabled = true;
        }

        private void NormalGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch(start)
            {
                case WorksType.No:
                    start = manager.StartGame(e,startpic);
                    break;
                case WorksType.Yes:
                    manager.Jump(e,Jumpsound);
                    manager.PauseGame(e,Paused);
                    break;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            manager.ShowMe(e,RefreshTimer,score,Resultpanel,Resultboard);
            finalscore.Text = score.ToString();
            bestscore.Text = manager.GetHighestScore();
        }
        

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            
            ArenaPic.Refresh();
            int x = score;
            this.score = manager.Refresh(score);
            if (score > x)
            {
                sound.Ctlcontrols.stop();
                sound.Ctlcontrols.play();
            }
            Scorelbl.Text = "Score : " + score;
        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menubtn_MouseEnter(object sender, EventArgs e)
        {
            Menubtn.BackColor = Color.DarkRed;
        }

        private void Menubtn_MouseLeave(object sender, EventArgs e)
        {
            Menubtn.BackColor = Color.White;
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            this.lightstartpic = manager.StartTimerTick(start,lightstartpic,startpic,StartTimer);       
        }

        
    }
}
