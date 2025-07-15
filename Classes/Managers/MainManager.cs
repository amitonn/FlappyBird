using AxWMPLib;
using flappyBird.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyBird.Classes.Managers
{
    class MainManager
    {
        protected FlappyB flappy;
        protected UpPipes[] p1;
        protected DownPipes[] p2;
        private WorksType paused;
        public void Jump(KeyEventArgs e, AxWindowsMediaPlayer jumpsound)
        {
            if (e.KeyCode == Keys.Space)
            {
                flappy.Jump();
                jumpsound.Ctlcontrols.play();
            }
        }
        public void PauseGame(KeyEventArgs e,PictureBox pic)
        {
            if (e.KeyCode == Keys.V)
            {
                switch (this.paused)
                {
                    case WorksType.No:
                        PauseGame();
                        pic.Visible = true;
                        this.paused = WorksType.Yes;
                        break;
                    case WorksType.Yes:
                        ContinueGame();
                        pic.Visible = false;
                        this.paused = WorksType.No;
                        break;
                }
            }
        }
        public void PauseGame()
        {
            flappy.Pause();
            for (int i = 0; i < p1.Length; i++)
            {
                p1[i].Pause();
                p2[i].Pause();
            }
        }
        private void ContinueGame()
        {
            flappy.Continue();
            for (int i = 0; i < p1.Length; i++)
            {
                p1[i].Continue();
                p2[i].Continue();
            }
        }
        public int Refresh(int score)
        {
            score = 0;
            for (int i = 0; i < p1.Length; i++)
            {
                score += p1[i].GetScore() + p2[i].GetScore();
            }
            return score;
        }
        protected string Highest(string s)
        {
            string path = (Path.GetTempPath() + s);
            if (!File.Exists(path))
            {
                return "0";
            }
            else
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    return (sr.ReadLine());
                }
            }
        }
        protected void SaveScore(int score, PictureBox p,string s,Image Pic)
        {
            string path = (Path.GetTempPath() + s);
            if (File.Exists(path))
            {
                int i = 0;
                using (StreamReader sr = new StreamReader(path))
                {
                    int x = int.Parse(sr.ReadLine());
                    if (score > x)
                    {
                        i = 1;
                    }
                    sr.Close();
                }
                if (i == 1)
                {
                    p.BackgroundImage = Pic;
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(score.ToString());
                    }
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(score.ToString());
                }
            }
        }
        public void ShowMe(PaintEventArgs e, Timer TimerRefresh, int score, Panel panelresult, PictureBox s)
        {
            flappy.ShowMe(e);
            for (int i = 0; i < p1.Length; i++)
            {
                p1[i].ShowMe(e);
                p2[i].ShowMe(e);
                if (flappy.TouchFigu(p1[i]) == true || flappy.TouchFigu(p2[i]) == true)
                {
                    TimerRefresh.Enabled = false;
                    panelresult.Visible = true;
                    break;
                }

            }
        }
        public void BackgroundImage(int backgroundindex, PictureBox p)
        {
            switch (backgroundindex)
            {
                case 0:
                    p.BackgroundImage = Resources.LabaBackground;
                    break;
                case 1:
                    p.BackgroundImage = Resources.Ocean;
                    break;
                case 2:
                    p.BackgroundImage = Resources.NightBackground;
                    break;
                default:
                    p.BackgroundImage = Resources.RegularBackground;
                    break;
                case 4:
                    p.BackgroundImage = Resources.Aquarium;
                    break;
                case 5:
                    p.BackgroundImage = Resources.Mario;
                    break;
            }
        }
        public WorksType StartGame(KeyEventArgs e, PictureBox pic)
        {
            if (e.KeyCode == Keys.Space)
            {
                ContinueGame();
                pic.Visible = false;
                return WorksType.Yes;
            }
            else
            {
                return WorksType.No;
            }
        }
        public WorksType StartTimerTick(WorksType start, WorksType lightstartpic, PictureBox pic, Timer StartTimer)
        {
            switch (start)
            {
                case WorksType.No:
                    switch (lightstartpic)
                    {
                        case WorksType.No:
                            pic.BackgroundImage = Resources.pressspaceshining;
                            return WorksType.Yes;
                        case WorksType.Yes:
                            pic.BackgroundImage = Resources.pressspace;
                            return WorksType.No;
                    }
                    break;
                case WorksType.Yes:
                    StartTimer.Enabled = false;
                    break;
            }
            return WorksType.Off;
        }
    }
}
