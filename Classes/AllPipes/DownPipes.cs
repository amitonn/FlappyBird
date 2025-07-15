using flappyBird.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyBird.Classes
{
    class DownPipes : Pipe
    {
        private Image pic;
        public DownPipes(float x, float y, float sizex, float sizey, Size arenasize, int pipecolor) 
            : base(x,y-sizey,sizex,sizey,arenasize)
        {
            switch (pipecolor)
            {
                case 0:
                    this.pic = Resources.DownAmod;
                    break;
                case 1:
                    this.pic = Resources.PDownPipe;
                    break;
                case 2:
                    this.pic = Resources.RDownPipe;
                    break;
                case 3:
                    this.pic = Resources.YDownPipe;
                    break;
                case 4:
                    this.pic = Resources.BDownPipe;
                    break;
                case 5:
                    this.pic = Resources.PinkDownPipe;
                    break;
                case 6:
                    this.pic = Resources.FDownPipe;
                    break;
                case 7:
                    this.pic = Resources.SDownPipe;
                    break;
                case 8:
                    this.pic = Resources.GDownPipe;
                    break;
                case 9:
                    this.pic = Resources.LDownPipe;
                    break;
                case 10:
                    this.pic = Resources.GPDown;
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
