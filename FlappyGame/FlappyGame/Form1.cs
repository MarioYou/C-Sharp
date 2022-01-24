using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyGame
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            PipeBottom.Left -= pipeSpeed;
            PipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (PipeBottom.Left < -150)
            {
                PipeBottom.Left = 800;
                score++;
            }
            if(PipeTop.Left < -180)
            {
                PipeTop.Left = 950;
                score++;
            }
            if (FlappyBird.Bounds.IntersectsWith(PipeBottom.Bounds) || 
                FlappyBird.Bounds.IntersectsWith(PipeTop.Bounds) || 
                FlappyBird.Bounds.IntersectsWith(Ground.Bounds) || 
                FlappyBird.Top < -25)
            {
                endGame();
            }
            if (score > 5 && score <= 14)
            {
                pipeSpeed = 10;
            }
            else if (score > 15 && score <= 19)
            {
                pipeSpeed = 15;
            }
            else if (score > 20 && score <= 24)
            {
                pipeSpeed = 20;
            }
            else if (score > 25 && score <= 29)
            {
                pipeSpeed = 25;
            }
            else if (score > 30 && score <= 34)
            {
                pipeSpeed = 30;
            }
            else if (score > 35 && score <= 39)
            {
                pipeSpeed = 35;
            }
        }
        private void GameKeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }
        private void GameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

        }
        private void endGame()
        {
            GameTimer.Stop();
            scoreText.Text += " Game Over !!!"; // += doesnt overwrite whats already in the text prior.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PipeTop_Click(object sender, EventArgs e)
        {

        }

        private void PipeBottom_Click(object sender, EventArgs e)
        {

        }
    }
}
