using flappyBird.Classes;
using flappyBird.Classes.Managers;
using flappyBird.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyBird
{
    class HardGameManager: MainManager
    {
        public void BuildUs(float width, float height, Size size, int flappycolor,int pipecolor)
        {
            Random rnd1 = new Random();
            base.p1 = new UpPipes[3];
            base.p2 = new DownPipes[3];
            base.p1[0] = new UpPipes(width, 0, 50, rnd1.Next(50, 150), size, pipecolor);
            base.p2[0] = new DownPipes(width + 50, height, 50, rnd1.Next(50, 150), size, pipecolor);
            base.p1[1] = new UpPipes(width + 250, 0, 50, rnd1.Next(50, 150), size, pipecolor);
            base.p2[1] = new DownPipes(width + 300, height, 50, rnd1.Next(50, 150), size, pipecolor);
            base.p1[2] = new UpPipes(width + 450, 0, 50, rnd1.Next(50, 150), size, pipecolor);
            base.p2[2] = new DownPipes(width + 500, height, 50, rnd1.Next(50, 150), size, pipecolor);
            for (int i = 0; i < p1.Length; i++)
            {
                base.p1[i].MoveLeft();
                base.p2[i].MoveLeft();
                base.p1[i].StepLeft();
                base.p2[i].StepLeft();
                
            }
            base.flappy = new FlappyB(200, 200, 40, 40, size, flappycolor);
        }
        public new void ShowMe(PaintEventArgs e, Timer TimerRefresh, int score, Panel panelresult, PictureBox s)
        {
            base.ShowMe(e, TimerRefresh, score, panelresult, s);
            if (TimerRefresh.Enabled == false)
            {
                SaveScore(score, s);
            }
        }
        private void SaveScore(int score,PictureBox s)
        {
            base.SaveScore(score, s, @"\HHighScoreFB.txt", Resources.ResultScreenNewHard);
        }
        public string GetHighestScore()
        {
            return (base.Highest(@"HHighScoreFB.txt"));
        }
    }
}

