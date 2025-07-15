
using flappyBird.Classes;
using flappyBird.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyBird
{
    //Heara
    class FlappyB
    {
        private Image[] pic;
        private RectangleF rect;
        private float speedy = 0;
        private Timer moveTimer;
        private Timer animationTimer;
        private int IndexPicture=0;
        private Size arenasize;
        public FlappyB(float x, float y,float sizex,float sizey,Size z,int color)
        {
            this.pic = new Image[3];
            this.arenasize = z;
            this.rect = new RectangleF(x, y, sizex,sizey);
            this.moveTimer = new Timer();
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 1;
            this.moveTimer.Tick += moveTimer_Tick;
            //--------------------------------
            this.animationTimer = new Timer();
            this.animationTimer.Enabled = true;
            this.animationTimer.Interval = 100;
            this.animationTimer.Tick += this.Animationtimer_Tick;
            //--------------------------------
            switch (color)
            {
                case 0:
                    this.pic[0] = Resources.GBird1;
                    this.pic[1] = Resources.GBird2;
                    this.pic[2] = Resources.GBird3;
                    break;
                case 1:
                    this.pic[0] = Resources.OBird1;
                    this.pic[1] = Resources.OBird2;
                    this.pic[2] = Resources.OBird3;
                    break;  
                case 2:
                    this.pic[0] = Resources.BBird1;
                    this.pic[1] = Resources.BBird2;
                    this.pic[2] = Resources.BBird3;
                    break;
                case 3:
                    this.pic[0] = Resources.PBird1;
                    this.pic[1] = Resources.PBird2;
                    this.pic[2] = Resources.PBird3;
                    break;
                case 4:
                    this.pic[0] = Resources.RBird1;
                    this.pic[1] = Resources.RBird2;
                    this.pic[2] = Resources.RBird3;
                    break;
                case 5:
                    this.pic[0] = Resources.BGBird1;
                    this.pic[1] = Resources.BGBird2;
                    this.pic[2] = Resources.BGBird3;
                    break;
                case 6:
                    this.pic[0] = Resources.GRBird1;
                    this.pic[1] = Resources.GRBird2;
                    this.pic[2] = Resources.GRBird3;
                    break;
                case 7:
                    this.pic[0] = Resources.ABird1;
                    this.pic[1] = Resources.ABird2;
                    this.pic[2] = Resources.ABird3;
                    break;
                case 8:
                    this.pic[0] = Resources.Turtle1;
                    this.pic[1] = Resources.Turtle2;
                    this.pic[2] = Resources.Turtle3;
                    break;
            }
                    
        }
        public void Jump()
        {
            this.speedy = (float)-3; 
        }
        private void Animationtimer_Tick(object sender, EventArgs e)
        {
            this.IndexPicture++;
            if (this.IndexPicture == 3)
            {
                this.IndexPicture = 0;
            }
        }
        private void moveTimer_Tick(object sender, EventArgs e)
        {
            this.speedy+=(float)0.1;
            this.rect.Y += speedy;
            if (this.rect.Y >= this.arenasize.Height - 20)
            {
                this.speedy = -5 ;
            }
            if (this.rect.Y <= -1)
            {
                this.ChangeY();
            }
        }
        public void ShowMe(PaintEventArgs e)
        {
            e.Graphics.DrawImage(pic[this.IndexPicture], rect); // pic - תמונה , rect - מרובע
        }
        public void ChangeY()
        {
            this.speedy *= -1;
        }
        public bool InArena()
        {
            if (this.rect.X >= arenasize.Width - 20)
            {
                return true;
            }
            if (this.rect.Y >= this.arenasize.Height - 20)
            {
                return true;
            }
            if (this.rect.X <= -1)
            {
                return true;
            }
            if (this.rect.Y <= -1)
            {
                return true;
            }
            return false;
        }
        public bool TouchFigu(UpPipes s)
        {
            return (this.rect.IntersectsWith(s.GetRect()));
        }
        public bool TouchFigu(DownPipes s)
        {
            return (this.rect.IntersectsWith(s.GetRect()));
        }
        public void Pause()
        {
           this.moveTimer.Enabled = false;
        }
        public void Continue()
        {
            this.moveTimer.Enabled = true;
        }
    }
    
}
