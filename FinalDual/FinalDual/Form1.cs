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
        menuButton 


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
            normaltank.Visible = true;
            glasscanon.Visible = true;
            juggernaut.Visible = true;

        }

        private void howToPlayButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.IndianRed;
            playButton.Visible = false;
            howToPlayButton.Visible = false;
            titleLabel.Visible = false;
            menuButton.Visible = true;
        }

      }
    }

