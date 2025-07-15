using flappyBird.Classes;
using flappyBird.Classes.Managers;
using flappyBird.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyBird
{
    class EasyGameManager : MainManager
    {
        public void BuildUs(float width,float height,Size size,int flappycolor,int pipecolor)
        {
            Random rnd1 = new Random();
            p1 = new UpPipes[2];
            p2 = new DownPipes[2];
            p1[0] = new UpPipes(width, 0, 50, rnd1.Next(50, 150), size, pipecolor);
            p2[0] = new DownPipes(width + 75, height, 50, rnd1.Next(50, 150), size, pipecolor);
            p1[1] = new UpPipes(width + 300, 0, 50, rnd1.Next(50, 150), size, pipecolor);
            p2[1] = new DownPipes(width + 375, height, 50, rnd1.Next(50, 150), size, pipecolor);
            for (int i = 0; i < p1.Length; i++)
            {
                p1[i].MoveLeft();
                p2[i].MoveLeft();
            }
            flappy = new FlappyB(200, 200, 40, 40, size, flappycolor);
        }
        public void Orgenize(int color, int pipecolor, int backgroundindex, PictureBox ArenaPic,Timer TimerRefresh,
            Panel Resultpanel, Label Scorelbl, Label finalscore, Label bestscore, PictureBox Resultboard)
        {
            BuildUs(ArenaPic.Width, ArenaPic.Height, ArenaPic.Size, color, pipecolor);
            BackgroundImage(backgroundindex, ArenaPic);
            TimerRefresh.Enabled = true;
            Resultpanel.Parent = ArenaPic;
            Scorelbl.Parent = ArenaPic;
            finalscore.Parent = Resultboard;
            bestscore.Parent = Resultboard;
        }
        public new void ShowMe(PaintEventArgs e, Timer TimerRefresh, int score, Panel panelresult, PictureBox s)
        {
            base.ShowMe(e, TimerRefresh, score, panelresult, s);
            if (TimerRefresh.Enabled == false)
            {
                SaveScore(score, s);
            }
        }
        private void SaveScore(int score, PictureBox p)
        {
            base.SaveScore(score, p, @"\EHighScoreFB.txt", Resources.ResultScreenNew);
        }
        public string GetHighestScore()
        {
            return (base.Highest(@"EHighScoreFB.txt"));
        }
    }
}
