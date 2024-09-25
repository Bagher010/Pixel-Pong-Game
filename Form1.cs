using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelPong
{
    public partial class Form1 : Form
    {
        public int ball_speed = 4;
        public int speed_top = 4;
        public int score = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true; // Form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds; // Fullscreen
            rack.Top = panel1.Bottom - (panel1.Bottom / 10); // Rack position

            finishing_lbl.Left = (panel1.Width / 2) - (finishing_lbl.Width / 2);
            finishing_lbl.Top = (panel1.Height / 2) - (finishing_lbl.Height / 2);
            finishing_lbl.Visible = false; //Hiding

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rack.Left = Cursor.Position.X - (rack.Width / 2); // Rack at the center 
            ball.Top += speed_top; // Ball movement vertically
            ball.Left += ball_speed; // Ball movement horizontally

            // Collision check for rack
            if (ball.Bottom >= rack.Top && ball.Bottom <= rack.Bottom && ball.Left >= rack.Left && ball.Right <= rack.Right)
            {
                speed_top += 2;
                ball_speed += 2;
                speed_top = -speed_top; // Reverse vertical direction
                score += 1;
                points_text.Text = score.ToString();



            }

            // Bounce off the left wall
            if (ball.Left <= panel1.Left)
            {
                ball_speed = -ball_speed; // Reverse horizontal direction
            }

            // Bounce off the right wall
            if (ball.Right >= panel1.Right)
            {
                ball_speed = -ball_speed; // Reverse horizontal direction
            }

            // Bounce off the top wall
            if (ball.Top <= panel1.Top)
            {
                speed_top = -speed_top; // Reverse vertical direction
            }

            // Ball reaches the bottom (game over)
            if (ball.Bottom >= panel1.Bottom)
            {
                timer1.Enabled = false; // Stopping the game
                finishing_lbl.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Exit with Esc
            }

            if (e.KeyCode == Keys.Enter) //Restart Game
            {
                ball.Top = 50;
                ball.Left = 50;
                ball_speed = 4;
                speed_top = 4;
                score = 0;
                points_text.Text = "0";
                timer1.Enabled = true;
                finishing_lbl.Visible = false;
            }

        }

     
    }
}

