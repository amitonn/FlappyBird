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
    public partial class HardGame : Form
    {
        int score = 0;
        HardGameManager manager = new HardGameManager();
        public HardGame(int color, int pipecolor, int backgroundindex)
        {
            InitializeComponent();
            sound.URL = "Getting_point_sound.wav";
            sound.Ctlcontrols.stop();
            Jumpsound.URL = "JumpSound.wav";
            Jumpsound.Ctlcontrols.stop();
            manager.BuildUs(ArenaPic.Size.Width, ArenaPic.Size.Height, ArenaPic.Size, color, pipecolor);//The manager will create the flappybird and the pipes.
            manager.BackgroundImage(backgroundindex, ArenaPic);
            RefreshTimer.Enabled = true;
            Scorelbl.Parent = ArenaPic;
            Resultpanel.Parent = ArenaPic;
            finalscore.Parent = Resultboard;
            bestscore.Parent = Resultboard;
            Paused.Parent = ArenaPic;
        }

        private void HardGame_KeyDown(object sender, KeyEventArgs e)
        {
            manager.Jump(e,Jumpsound); //When the user press Space the flappybird will jump.
            manager.PauseGame(e,Paused);
        }

        private void ArenaPic_Paint(object sender, PaintEventArgs e)
        {
            manager.ShowMe(e, RefreshTimer, score, Resultpanel, Resultboard);// The manager will paint the figures(flappybird and pipes) on the ArenaPic.
            finalscore.Text = score.ToString();
            bestscore.Text = manager.GetHighestScore();
        }
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            ArenaPic.Refresh();
            int x = score;
            this.score = manager.Refresh(this.score);
            if (score>x)
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
    }
}
