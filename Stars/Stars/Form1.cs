using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000000; i++)
            {
                stars();
            }           
        }

        public void stars()
        {
            Random Randgen = new Random();
            Graphics fg = this.CreateGraphics();
            SolidBrush startBrush;

            int size = Randgen.Next(1, 10);
            int x = Randgen.Next(1, this.Width);
            int y = Randgen.Next(1, this.Height);
            int r = Randgen.Next(1, 256);
            int g = Randgen.Next(1, 256);
            int b = Randgen.Next(1, 256);

            startBrush = new SolidBrush(Color.FromArgb(r, g, b));
            fg.FillEllipse(startBrush, x, y, size, size);
        }
    }
}


