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
    class MainFormManager
    {
        public void PlayButton(int i, int flappycolor,int pipecolor,int backgroundindex)
        {
            switch (i)
            {
                    
                case 0:
                    EasyGame egame = new EasyGame(flappycolor, pipecolor, backgroundindex);
                    egame.Show();
                    break;
                case 1:
                    NormalGame ngame = new NormalGame(flappycolor, pipecolor, backgroundindex);
                    ngame.Show();
                    break;
                case 2:
                    HardGame hgame = new HardGame(flappycolor, pipecolor, backgroundindex);
                    hgame.Show();
                    break;
                default:
                    MessageBox.Show("You didn't Choose the level");
                    break;
            }
        }
        public void ResetScore(int index)
        {
            switch (index)
            {
                case 0:
                    ResetHighestScore(@"EHighScoreFB.txt");

                    break;
                case 1:
                    ResetHighestScore(@"NHighScoreFB.txt");
                    break;
                case 2:
                    ResetHighestScore(@"HHighScoreFB.txt");
                    break;
                default:
                    MessageBox.Show("You didn't choose the level you want to delete the highest score for.");
                    break;
            }
        }
        private void ResetHighestScore(string s)
        {
            string path = Path.GetTempPath() + s;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            MessageBox.Show("The Highest Score is now 0");
        }
        public void OpenHighScore()
        {
            HighScoreBoard c = new HighScoreBoard();
            
            c.Show();
        }
        public void FlappyChangingColor(int colorindex, Image[] pics)
        {
            switch (colorindex)
            {
                case 0:
                    pics[0] = Resources.GBird1;
                    pics[1] = Resources.GBird2;
                    pics[2] = Resources.GBird3;
                    break;
                case 1:
                    pics[0] = Resources.OBird1;
                    pics[1] = Resources.OBird2;
                    pics[2] = Resources.OBird3;
                    break;
                case 2:
                    pics[0] = Resources.BBird1;
                    pics[1] = Resources.BBird2;
                    pics[2] = Resources.BBird3;
                    break;
                case 3:
                   pics[0] = Resources.PBird1;
                   pics[1] = Resources.PBird2;
                   pics[2] = Resources.PBird3;
                    break;
                case 4:
                    pics[0] = Resources.RBird1;
                    pics[1] = Resources.RBird2;
                    pics[2] = Resources.RBird3;
                    break;
                case 5:
                    pics[0] = Resources.BGBird1;
                    pics[1] = Resources.BGBird2;
                    pics[2] = Resources.BGBird3;
                    break;
                case 6:
                    pics[0] = Resources.GRBird1;
                    pics[1] = Resources.GRBird2;
                    pics[2] = Resources.GRBird3;
                    break;
                case 7:
                    pics[0] = Resources.ABird1;
                    pics[1] = Resources.ABird2;
                    pics[2] = Resources.ABird3;
                    break;
                case 8:
                    pics[0] = Resources.Turtle1;
                    pics[1] = Resources.Turtle2;
                    pics[2] = Resources.Turtle3;
                    break;
            }
        }
        public Image PipeChangingColor(int colorindex)
        {
            switch (colorindex)
            {
                default:
                    return Resources.UpAmod;
                case 1:
                    return Resources.PUpPipe;
                case 2:
                    return Resources.RUpPipe;
                case 3:
                    return Resources.YUpPipe;
                case 4:
                    return Resources.BUpPipe;
                case 5:
                    return Resources.PinkUpPipe;
                case 6:
                    return Resources.FUpPipe;
                case 7:
                    return Resources.SUpPipe;
                case 8:
                    return Resources.GUpPipe;
                case 9:
                    return Resources.LUpPipe;
                case 10:
                    return Resources.GPUp;
            }
        }
        public Image BackgroundChanging(int backgroundindex)
        {
            switch (backgroundindex)
            {
                case 0:
                    return Resources.LabaBackground;
                case 1:
                    return Resources.Ocean;
                case 2:
                    return Resources.NightBackground;
                default:
                    return Resources.RegularBackground;
                case 4:
                    return Resources.Aquarium;
                case 5:
                    return Resources.Mario;
            }
        }
    }
}
