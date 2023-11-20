using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsExperiment
{
    public partial class Dart : Form
    {
        int speed = 5;
        int score = 0;
        Random rand  = new Random();
        bool gameOver = false;
        public Dart()
        {
            InitializeComponent();
            resetGame();
        }

        private void BalloonClicked(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                 var balloon = (PictureBox)sender;
                balloon.Top = rand.Next(700, 1000);
                balloon.Left = rand.Next(5, 500);
                score++;
            }
        }

        private void BombClicked(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                bomb.Image = Properties.Resources.boom;
                gameTimer.Stop();
                lbl_score.Text += " Game Over! Press enter to retry";
                gameOver = true;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && gameOver == true)
            {
                resetGame();
            }
        }

        private void GameEngine(object sender, EventArgs e)
        {
            lbl_score.Text = score.ToString();
            foreach (Control x  in this.Controls)
            {
                if(x is PictureBox)
                {
                    x.Top -= speed;

                    if(x.Top + x.Height < 0)
                    {
                        x.Top = rand.Next(700, 1000);
                        x.Left = rand.Next(5, 500);
                    }
                }
                if (x.Tag == "Balloon" && x.Top < -50)
                {
                    // Remove a life only when the balloon hasn't been reset
                    if (x.Top != this.Height)
                    {
                        lbl_lives.Text = lbl_lives.Text.Substring(0, lbl_lives.Text.Length - 1);
                        x.Top = this.Height;
                    }

                    if (lbl_lives.Text.Length == 0)
                        {
                            gameTimer.Stop();
                            lbl_score.Text += " Game Over! Press enter to retry";
                            gameOver = true;
                        }
                }
                if (score >= 20)
                    speed = 8;
                if (score >= 40)
                    speed = 16;
                if (score >= 35)
                    speed = 20;
            }
        }
        private void resetGame()
        {
            foreach (Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    x.Top = rand.Next(700, 1000);
                    x.Left = rand.Next(5, 500);
                }
            }

            bomb.Image = Properties.Resources.bomb;
            speed = 5;
            score = 0;
            lbl_lives.Text = "❤️❤️❤️";
            gameOver = false;
            lbl_score.Text += "" + score;
            gameTimer.Start();

        }

        private async void freeze_ClickAsync(object sender, EventArgs e)
        {


            freeze.Image = null;
           this.BackColor = Color.Aqua;
            gameTimer.Stop();

      
            await Task.Delay(3000);

                this.BackColor = Color.Pink;
            gameTimer.Start();
        }

    }
}
