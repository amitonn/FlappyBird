using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyBird.Classes
{
    class Pipe
    {
        protected RectangleF rect;
        private float speedx = 0;
        private Timer moveTimer;
        private Size arenasize;
        private bool s = true;
        protected int score = 0;
        public Pipe(float x, float y, float sizex, float sizey, Size arenasize)
        {
            rect = new RectangleF(x, y, sizex, sizey);
            this.moveTimer = new Timer();
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 100;
            this.moveTimer.Tick += MovingTimer_Tick;
            this.arenasize = arenasize;
        }
        private void MovingTimer_Tick(object sender, EventArgs e)
        {
            this.rect.X += this.speedx;
            if (this.rect.X < -50)
            {
                this.rect.X = arenasize.Width;
                    this.Resize();
                    if (this.rect.Y != 0)
                    {
                        this.rect.Y = this.arenasize.Height - this.rect.Height;
                    }
                
            }
            if (this.rect.X < 200)
            {
                if (this.s == true)
                {
                    score++;
                    s = false;
                }
            }

        }
        private void Resize()
        {
            Random x = new Random();
            float s1 = x.Next(75, 150);
            rect.Height = s1;
            this.s = true;

        }
        public void StepLeft()
        {
            this.speedx -= 2;
        }
        public void MoveLeft()
        {
            this.speedx = -12;
        }
        public void Pause()
        {
            this.moveTimer.Enabled = false; ;
        }
        public void Continue()
        {
            this.moveTimer.Enabled = true;
        }
    }
}
