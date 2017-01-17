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
        int classPlayer1 = 0;
        int classPlayer2 = 0;
        int xPlayer1 = 50;
        int xPlayer2 = 50;
        int yPlayer1 = 200;
        int yPlayer2 = 200;
        int speedPlayer1 = 10;
        int speedPlaeyr2 = 10;
        int widthPlayer1 = 20;
        int widthPlayer2 = 20;
        int heightPlayer1 = 20;
        int heightPlayer2 = 20;
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown;
        
        SolidBrush player1Brush = new SolidBrush(Color.Black);
        SolidBrush player2Brush = new SolidBrush(Color.White);

        public Form1()
        {
            InitializeComponent();
            gametimer.Enabled = true;
            gametimer.Start();

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            #region Player1 Key Up
            //check to see if a key has been released and set its KeyDown value to false if it has
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                default:
                    break;
            }
            #endregion
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            #region Player1 Key Down 
            //check to see if a key is pressed and set is KeyDown value to true if it has
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                default:
                    break;
            }
            #endregion
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            #region Check for movement and collisions 

            if (leftArrowDown == true)
            {
                xPlayer1 = xPlayer1 - speedPlayer1;
            }

            if (downArrowDown == true)
            {
                yPlayer1 = yPlayer1 + speedPlayer1;
            }

            if (rightArrowDown == true)
            {
                xPlayer1 = xPlayer1 + speedPlayer1;
            }

            if (upArrowDown == true)
            {
                yPlayer1 = yPlayer1 - speedPlayer1;
            }

            Refresh();
            #endregion        
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        { 
            e.Graphics.FillRectangle(player1Brush, xPlayer1, yPlayer1, widthPlayer1, heightPlayer1);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            #region Class Select Screen
            dualimage.Visible = false;
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
            #endregion
        }

        private void howToPlayButton_Click(object sender, EventArgs e)
        {
            #region How to play screen
            //Graphics
            Graphics fg = this.CreateGraphics();
            Pen redpen = new Pen(Color.Red, 10);
            SolidBrush titelbrush = new SolidBrush(Color.Black);
            SolidBrush smallbrush = new SolidBrush(Color.Black);
            Font titelFont = new Font("Papyrus", 48, FontStyle.Regular);
            menuButton.Visible = true;
            dualimage.Visible = false;
            howToPlayButton.Visible = false;
            playButton.Visible = false;
            titleLabel.Visible = false;
            fg.DrawString("How To Play", titelFont, titelbrush, 290, 20);

            #endregion
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            #region Return to Menu 
            Refresh();
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
            #endregion
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            #region Start Game
            classPlayer1 = Convert.ToInt32(classSelect1.Text);
            classPlayer2 = Convert.ToInt32(classSelect2.Text);
            startbutton.Visible = false;
           

            if (classPlayer1 == 1)
            {

            }


            }

            if (classPlayer2 == 1)
            {

            }

            else if (classPlayer2 == 2)
            {

            }

            else if (classPlayer2 == 3)
            {

            }

            if (classPlayer1 == 1)
            {

            }

            else if (classPlayer2 == 1)
            {

            }
            if (classPlayer1 == 1)
            {

            }

            else if (classPlayer2 == 1)
            {

            }


            titleLabel.Visible = false;
            juggernautlable.Visible = false;
            juggernautpic.Visible = false;
            normaltanklabel.Visible = false;
            normaltankpic.Visible = false;
            glasscanonlable.Visible = false;
            glasscanonpic.Visible = false;
            classSelect1.Visible = false;
            classSelect2.Visible = false;
            menuButton.Visible = false;
            #endregion

            this.Focus();
        }
    }
}

