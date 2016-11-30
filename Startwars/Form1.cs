//Star Wars Formitive 
//ICS3U
//Mr.T
//Sam Near
//November 29, 2016 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Startwars
{
    public partial class Form1 : Form
    {
        //Set up Fonts,Brushes, and Pens 
        Font drawFont = new Font("Arial", 12, FontStyle.Bold);
        SolidBrush drawBrush = new SolidBrush(Color.LimeGreen);
        Pen drawPen = new Pen(Color.White, 2);
        int BombY;
        int x;
        SoundPlayer theme = new SoundPlayer(Properties.Resources.John_Williams___Star_Wars_Main_Theme__FULL___mp3cut_net_);
        SoundPlayer explosion = new SoundPlayer(Properties.Resources.Explosion_sound_effect__1___mp3cut_net_);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //Create Graphics and set starting labels to invisible 
            Graphics fg = this.CreateGraphics();
            titleLabel1.Visible = false;
            titleLabel2.Visible = false;
            fg.Clear(Color.Black);
            theme.Play();
            fg.DrawString("Welcome Adveturer, your task is to destroy the\n death star. It's pretty simple  ", drawFont, drawBrush, 20, 40);
            Thread.Sleep(3000);

            int y = 10;
            int x = 450;

            while (x >= 190)
            {
                //loop for the ship moving to the drop site
                fg.Clear(Color.Black);
                fg.DrawEllipse(drawPen, x, y, 50, 25);
                fg.DrawEllipse(drawPen, 80, 75, 250, 250);
                x = x - 1;

                while (x == 190 & BombY < 200)
                {
                    //loop for the bomb dropping down
                    drawBrush.Color = Color.Red;
                    fg.Clear(Color.Black);
                    fg.DrawEllipse(drawPen, 80, 75, 250, 250);
                    fg.FillEllipse(drawBrush, 200, BombY, 20, 20);
                    fg.DrawEllipse(drawPen, x, y, 50, 25);
                    BombY++;
                    Thread.Sleep(10);
                }

                Thread.Sleep(10);
            }
            theme.Stop();
            explosion.Play();
            for (int bombX = 1; bombX <= 450; bombX = bombX + 4)
            {
                //loop for bomb exploiding 
                fg.Clear(Color.Black);
                fg.FillEllipse(drawBrush, 200 - bombX / 2, 200 - bombX / 2, 5 + bombX, 5 + bombX);
                fg.DrawEllipse(drawPen, 190 - bombX, y, 50, 25);
                Thread.Sleep(10);
            }

            fg.Clear(Color.Black);
            fg.DrawString("Good Job You Did It ", drawFont, drawBrush, 20, 40);
            Thread.Sleep(10000);
        }
    }
}

