using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject1
{
    public partial class Form3 : Form
    {
        bool goleft;
        bool goright;

        int speed = 7;
        int score = 0;
        int missed = 0;

        Random rx = new Random();
        Random ry = new Random();

        PictureBox splash = new PictureBox();
        public Form3()
        {
            InitializeComponent();
            //popcatpic.Parent = pinkpic;
            //scorelbl.Parent = pinkpic;
            //missedlbl.Parent = pinkpic;
            //fish1.Parent = pinkpic;
            //fish2.Parent = pinkpic;
            //fish3.Parent = pinkpic;
           


            Restart();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SoundPlayer pop = new SoundPlayer(@"popcat.wav");
            pop.PlayLooping();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Scorelbl_Click(object sender, EventArgs e)
        {

        }

        private void MainGamerTimerEvent(object sender, EventArgs e)
        {
            scorelbl.Text = "Score: " + score;
            missedlbl.Text = "Missed: " + missed;

            if (goleft == true && cat.Left > 0)
            {
                cat.Left -= 12; //speed
                cat.Image = Properties.Resources.popcatleft;
            }

            if (goright == true && cat.Left + cat.Width < this.ClientSize.Width)
            {
                cat.Left += 12; //speed
                cat.Image = Properties.Resources.popcatright;

            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "fishes")
                {
                    x.Top += speed;

                    if (x.Top + x.Height > this.ClientSize.Height)
                    {

                        splash.Image = Properties.Resources.splash;
                        splash.Location = x.Location;
                        splash.Height = 60;
                        splash.Width = 60;
                        splash.BackColor = Color.Transparent;

                        this.Controls.Add(splash);

                        x.Top = ry.Next(80, 300) * -1;
                        x.Left = rx.Next(5, this.ClientSize.Width - x.Width);

                        missed += 1;
                        cat.Image = Properties.Resources.redcat;
                    }

                    if (cat.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Top = ry.Next(80, 300) * -1;
                        x.Left = rx.Next(5, this.ClientSize.Width - x.Width);
                        score += 1;

                    }



                }


            }
            if (score > 10)
            {
                speed = 11;
            }
            if (score >= 20)
            {
                speed = 15;
            }
            if (missed > 5)
            {
                GameTimer.Stop();
                //have gr0upbox show
            }

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

        }
        private void Restart()
        {


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "fishes")
                {
                    x.Top = ry.Next(80, 300) * -1;
                    x.Left = rx.Next(5, this.ClientSize.Width - x.Width);

                }
            }

            cat.Left = this.ClientSize.Width / 2;
            cat.Image = Properties.Resources.popcatleft;

            score = 0;
            missed = 0;
            speed = 8;

            goleft = false;
            goright = false;

            GameTimer.Start();


        }
    }
}
