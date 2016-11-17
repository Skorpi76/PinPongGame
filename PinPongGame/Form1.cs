using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinPongGame
{
    public partial class Form1 : Form
    {
        public int speed_top = 4;
        public int  speed_left = 4; //speed of the ball       
        public int points = 0; // Scored points
        public Form1()
        {
            InitializeComponent();          
            timer1.Enabled = true;                          // Enable Timer (Можно сделать и через меню)
            Cursor.Hide();                                  // Hide The Cursor
            this.FormBorderStyle = FormBorderStyle.None;    // Remove any border
            this.TopMost = true;                            // Bring the form to the front 
            this.Bounds = Screen.PrimaryScreen.Bounds;      // Make it full screen

            Racket.Top = PlayGround.Bottom - (PlayGround.Bottom / 10);  // Set the position of racket 

            GameOver_lbl.Left = (PlayGround.Width / 2) - (GameOver_lbl.Width / 2); // Position to center 
            GameOver_lbl.Top = (PlayGround.Height / 2) - (GameOver_lbl.Height / 2);
            GameOver_lbl.Visible = false; // Hide 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Racket.Left = Cursor.Position.X - (Racket.Width / 2); // Set the center of the Racket of the cursor
            ball.Top += speed_top;
            ball.Left += speed_left; // Move the ball
            

            if (ball.Bottom >= Racket.Top && ball.Bottom <= Racket.Bottom && ball.Left >= Racket.Left && ball.Right <= Racket.Right)   // racket collision
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;  // Change diraction 
                points += 1;
                points_lbl.Text = points.ToString();
                Random r = new Random();
                PlayGround.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 250), r.Next (150,255)); // Get a random RGB color and set is as a playground backcolor


            }

            if (ball.Left <= PlayGround.Left)
            {
                speed_left = -speed_left;

            }
            if (ball.Right >= PlayGround.Right)
                {
                speed_left = -speed_left;
            }
            if (ball.Top <= PlayGround.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= PlayGround.Bottom)
            {
                timer1.Enabled = false;  // ball is out stop the game 
                GameOver_lbl.Visible = true;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); } //Press Escape to Quit
            if (e.KeyCode == Keys.F1) { ball.Top = 0;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points = 0;
                points_lbl.Text = "0";
                timer1.Enabled = true;
                GameOver_lbl.Visible = false;
                PlayGround.BackColor = Color.White;
            } 
        }

      
      
    }
}
