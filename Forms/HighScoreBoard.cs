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
    public partial class HighScoreBoard : Form
    {
        public HighScoreBoard()
        {
            InitializeComponent();
            NormalL.Text = Highest(@"NHighScoreFB.txt");
            NormalL.Parent = StagePic;
            Normaltitle.Parent = StagePic;
            EasyL.Text = Highest(@"EHighScoreFB.txt");
            EasyL.Parent = StagePic;
            Easytitle.Parent = StagePic;
            HardL.Text = Highest(@"HHighScoreFB.txt");
            HardL.Parent = StagePic;
            Hardtitle.Parent = StagePic;
            
           
        }
        private string Highest(string s)
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

        private void _1Place_Load(object sender, EventArgs e)
        {

        }
    }
}
