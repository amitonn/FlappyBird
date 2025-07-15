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

namespace flappyBird
{
    public partial class EasyGame : Form
    {
        int score = 0;
        EasyGameManager manager = new EasyGameManager();
        public EasyGame(int color,int pipecolor,int backgroundindex)
        {
            InitializeComponent(); 
            manager.Orgenize(color,pipecolor,backgroundindex,ArenaPic,TimerRefresh,Resultpanel,Scorelbl,finalscore, bestscore,Resultboard);
            sound.URL = "Getting_point_sound.wav";
            sound.Ctlcontrols.stop();
            Jumpsound.URL = "JumpSound.wav";
            Jumpsound.Ctlcontrols.stop();
            Paused.Parent = ArenaPic;
        }
        private void ArenaPic_Paint(object sender, PaintEventArgs e)
        {
            manager.ShowMe(e, TimerRefresh, score,Resultpanel,Resultboard);
            finalscore.Text = score.ToString();
            bestscore.Text = manager.GetHighestScore();

        }
        private void TimerRefresh_Tick(object sender, EventArgs e)
        {
            ArenaPic.Refresh();
            int x = score;
            score = manager.Refresh(score);
            if (score > x)
            {
                sound.Ctlcontrols.play();
            }
            Scorelbl.Text = "Score : " + score;
        }
        private void EasyGame_KeyDown(object sender, KeyEventArgs e)
        {
            manager.Jump(e,Jumpsound);
            manager.PauseGame(e,Paused);
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
    }
}
