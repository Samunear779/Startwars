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

namespace Startwars
{
    public partial class Form1 : Form
    {
        Font drawFont = new Font("Arial", 12, FontStyle.Bold);
        SolidBrush drawBrush = new SolidBrush(Color.LimeGreen);
        Pen drawPen = new Pen(Color.White, 5);
        int BombY;
        int bombX = 200;
        int x;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics fg = this.CreateGraphics();
            titleLabel1.Visible = false;
            titleLabel2.Visible = false;

            fg.DrawString("Welcome Adveturer, your task is to destroy the\n death star. It's pretty simple  ", drawFont, drawBrush, 20, 40);
            Thread.Sleep(1000);

            int y = 10;
            int x = 450;

            while (x >= 190)
            {
                fg.Clear(Color.Black);
                fg.DrawEllipse(drawPen, x, y, 50, 25);
                fg.DrawEllipse(drawPen, 80, 75, 250, 250);
                x = x - 1;

                while (x == 190 & BombY < 200)
                {
                    drawBrush.Color = Color.Red;
                    fg.Clear(Color.Black);
                    fg.DrawEllipse(drawPen, 80, 75, 250, 250);
                    fg.FillEllipse(drawBrush, 200, BombY, 20, 20);
                    fg.DrawEllipse(drawPen, x, y, 50, 25);
                    BombY++;
                }
                Thread.Sleep(10);

            }
            for (int bombX = 1; x < 200; bombX++)
            {
                //act
                fg.Clear(Color.Black);
                //fg.FillEllipse(drawBrush, 190 + bombX/2, 200 + bombX/2, 10 + x, 10 + x);  
                fg.FillEllipse(drawBrush, 50, 75, 5 + bombX, 5 + bombX);
                Thread.Sleep(5);
            }
        }
    }
}

