using flappyBird.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using flappyBird.Classes;

namespace flappyBird
{
    class UpPipes : Pipe
    {
        private Image pic;
        public UpPipes(float x, float y, float sizex, float sizey, Size arenasize, int pipecolor)
            : base(x, y, sizex, sizey, arenasize)
        {

            switch (pipecolor)
            {
                case 0:
                    this.pic = Resources.UpAmod;
                    break;
                case 1:
                    this.pic = Resources.PUpPipe;
                    break;
                case 2:
                    this.pic = Resources.RUpPipe;
                    break;
                case 3:
                    this.pic = Resources.YUpPipe;
                    break;
                case 4:
                    this.pic = Resources.BUpPipe;
                    break;
                case 5:
                    this.pic = Resources.PinkUpPipe;
                    break;
                case 6:
                    this.pic = Resources.FUpPipe;
                    break;
                case 7:
                    this.pic = Resources.SUpPipe;
                    break;
                case 8:
                    this.pic = Resources.GUpPipe;
                    break;
                case 9:
                    this.pic = Resources.LUpPipe;
                    break;
                case 10:
                    this.pic = Resources.GPUp;
                    break;
            }

        }
        public void ShowMe(PaintEventArgs e)
        {
            e.Graphics.DrawImage(this.pic, base.rect);
        }
        public RectangleF GetRect()
        {
            return base.rect;
        }
        public int GetScore()
        {
            return base.score;
        }
    }
}
