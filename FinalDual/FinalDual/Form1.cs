﻿using System;
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
        //variables
        int classPlayer1 = 0;
        int classPlayer2 = 0;
        int xPlayer1 = 50;
        int xPlayer2 = 900;
        int yPlayer1 = 245;
        int yPlayer2 = 245;
        int speedPlayer1 = 7;
        int speedPlayer2 = 7;
        int widthPlayer1 = 20;
        int widthPlayer2 = 20;
        int heightPlayer1 = 20;
        int heightPlayer2 = 20;
        int healthplayer1 = 200;
        int healthplayer2 = 200;
        int fireratePlayer1 = 500;
        int fireratePlayer2 = 500;
        int damagePlayer1 = 20;
        int damagePlayer2 = 20;
        int livesplayer1 = 3;
        int livesplayer2 = 3;
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown,aplayer1,sPlayer1,dPlayer1,wPlayer1, gameOn;
        //tank colors
        SolidBrush player1Brush = new SolidBrush(Color.Black);
        SolidBrush player2Brush = new SolidBrush(Color.White);
     
        public Form1()
        {
            InitializeComponent();
             
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //player movement up
            #region Player2 Key Up
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
                case Keys.A:
                    aplayer1 = false;
                    break;
                case Keys.S:
                    sPlayer1 = false;
                    break;
                case Keys.W:
                    wPlayer1 = false;
                    break;
                case Keys.D:
                    dPlayer1 = false;
                    break;
                default:
                    break;

            }
            #endregion
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //player movement down
            #region Player2 Key Down 
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
                case Keys.A:
                    aplayer1 = true;
                    break;
                case Keys.S:
                    sPlayer1 = true;
                    break;
                case Keys.W:
                    wPlayer1 = true;
                    break;
                case Keys.D:
                    dPlayer1 = true;
                    break; 
                default:
                    break;
            }
            #endregion
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {   
            //graphics
            Graphics fg = this.CreateGraphics();
            SolidBrush smallbrush = new SolidBrush(Color.Black);
            SolidBrush titelbrush = new SolidBrush(Color.Black);
            Font titelFont = new Font("Papyrus", 48, FontStyle.Regular);
            
            // collision 
            #region Check for movement and collisions 

            if (leftArrowDown == true)
            {
                if (xPlayer2 > 202)
                {
                    xPlayer2 = xPlayer2 - speedPlayer2;
                }
            }

            if (downArrowDown == true)
            {
                if (yPlayer2 < this.Height - heightPlayer2 - 45)
                {
                    yPlayer2 = yPlayer2 + speedPlayer2;
                }
            }

            if (rightArrowDown == true)
            {
                if (xPlayer2 < this.Width - widthPlayer2 - 21)
                {
                    xPlayer2 = xPlayer2 + speedPlayer2;
                }
            }

            if (upArrowDown == true)
            {
                if (yPlayer2 > 4)
                {
                    yPlayer2 = yPlayer2 - speedPlayer2;
                }
            }


            if (aplayer1 == true)
            {
                if (xPlayer1 > 3)
                {
                    xPlayer1 = xPlayer1 - speedPlayer1;
                }
            }

            if (sPlayer1 == true)
            {
                if (yPlayer1 < this.Height - heightPlayer1 - 45)
                {
                    yPlayer1 = yPlayer1 + speedPlayer1;
                }
            }

            if (dPlayer1 == true)
            {
                if (xPlayer1 < this.Width - 200 - widthPlayer1 + 1)
                {
                    xPlayer1 = xPlayer1 + speedPlayer1;
                }
            }

            if (wPlayer1 == true)
            {
                if (yPlayer1 > 4)
                {
                    yPlayer1 = yPlayer1 - speedPlayer1;
                }
            }
            if (livesplayer1 == 0)
            {
                fg.DrawString("PLAYER 2 WINS", titelFont, titelbrush, 290, 20);
                gameOn = false;
            }
            else if (livesplayer2 == 0)
            {
                fg.DrawString("PLAYER 1 WINS", titelFont, titelbrush, 290, 20);
                gameOn = false;
            }

            Refresh();
            #endregion        
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //any graphics on the game screen
            if (gameOn == true)
            {
                e.Graphics.FillRectangle(player1Brush, 200, 0, 5, this.Width);
                e.Graphics.FillRectangle(player2Brush, this.Width - 200, 0, 5, this.Height);
                e.Graphics.FillRectangle(player2Brush, xPlayer2, yPlayer2, widthPlayer2, heightPlayer2);
                e.Graphics.FillRectangle(player1Brush, xPlayer1, yPlayer1, widthPlayer1, heightPlayer1);
               

            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // sets up tank options
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
            chooselabel.Visible = true;
            player1label.Visible = true;
            player2label.Visible = true;
            #endregion
        }

        private void howToPlayButton_Click(object sender, EventArgs e)
        {
            //instructions
            #region How to play screen
            //Graphics
            Graphics fg = this.CreateGraphics();
            Pen redpen = new Pen(Color.Red, 10);
            SolidBrush titelbrush = new SolidBrush(Color.Black);
            SolidBrush smallbrush = new SolidBrush(Color.Black);
            Font titelFont = new Font("Papyrus", 48, FontStyle.Regular);
            Font textFont = new Font("Papyrus", 20, FontStyle.Regular);
            menuButton.Visible = true;
            dualimage.Visible = false;
            howToPlayButton.Visible = false;
            playButton.Visible = false;
            titleLabel.Visible = false;
            fg.DrawString("How To Play", titelFont, titelbrush, 290, 20);
            chooselabel.Visible = false;
            fg.DrawString("This is a 1v1 tank game, player 1 uses wasd and spacebar,\n  player 2 uses arrow keys and right control button. \n each player has 3 lives and can choose from 3 different tanks, \n each have different features listed in the play screen.\n First tank to destroy the other 3 times wins!", textFont, smallbrush, 175, 150);
            player1label.Visible = false;
            player2label.Visible = false;        
            #endregion
        }

        private void menuButton_Click(object sender, EventArgs e)
        {   //main menu 
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
            chooselabel.Visible = false;
            player1label.Visible = false;
            player2label.Visible = false;
            #endregion
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            //starts the game
            #region Start Game
            gameOn = true;
            gametimer.Enabled = true;
            gametimer.Start();     
            classPlayer1 = Convert.ToInt32(classSelect1.Text);
            classPlayer2 = Convert.ToInt32(classSelect2.Text);
            startbutton.Visible = false;
            chooselabel.Visible = false;
            player1label.Visible = false;
            player2label.Visible = false;
            
            //player 1 and 2 variables
            if (classPlayer2 == 2)
            {
                fireratePlayer2 = 100;
                healthplayer2 = 100;
                damagePlayer2 = 10;
                speedPlayer2 = 10;
            }

            else if (classPlayer2 == 3)
            {
                fireratePlayer2 = 1000;
                healthplayer2 = 300;
                damagePlayer2 = 50;
                speedPlayer2 = 5;
            }

             if (classPlayer1 == 2)
            {
                fireratePlayer2 = 100;
                healthplayer2 = 100;
                damagePlayer2 = 10;
                speedPlayer1 = 10;
            }

            else if (classPlayer1 == 3)
            {
                fireratePlayer2 = 1000;
                healthplayer2 = 300;
                damagePlayer2 = 50;
                speedPlayer1 = 5;
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

