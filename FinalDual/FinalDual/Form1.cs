using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FinalDual
{
    public partial class Form1 : Form
    {
        int player1Class;
        int player2Class;
        int player1X;
        int player2X;
        int player2Y;
      //Sam rly sucks


        public Form1()
        {
            InitializeComponent();  

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Visible = false;
            howToPlayButton.Visible = false;
            menuButton.Visible = true;
            classSelect1.Visible = true;
            classSelect2.Visible = true;
            startbutton.Visible = true;
            normaltankpic.Visible = true;
            glasscanonpic.Visible = true;
            juggernautpic.Visible = true;
            dualimage.Visible = false;
            glasscanonlable.Visible = true;
            normaltanklabel.Visible = true;
            juggernautlable.Visible = true;

            player1Class = Convert.ToInt32(classSelect1);
            player2Class = Convert.ToInt32(classSelect2);
            



        }
        
        private void howToPlayButton_Click(object sender, EventArgs e)
        {
            
            BackColor = Color.IndianRed;
            playButton.Visible = false;
            howToPlayButton.Visible = false;
            titleLabel.Visible = false;
            menuButton.Visible = true;
        }
             
            private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawString("Hello", drawFont, drawBrush, 50, 40);

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            playButton.Visible = true;
            howToPlayButton.Visible = true;
            menuButton.Visible = false;
            classSelect1.Visible = false;
            classSelect2.Visible = false;
            startbutton.Visible = false;
            normaltankpic.Visible = false;
            glasscanonpic.Visible = false;
            juggernautpic.Visible = false;
            glasscanonlable.Visible = false;
            normaltanklabel.Visible = false;
            juggernautlable.Visible = false;
            dualimage.Visible = true;
            titleLabel.Visible = true;



        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            


        }
    }
    }

