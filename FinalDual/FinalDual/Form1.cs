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
        int xPlayer2 = 900;
        int yPlayer1 = 245;
        int yPlayer2 = 245;
        int speedPlayer1 = 7;
        int speedPlayer2 = 7;
        int widthPlayer1 = 20;
        int widthPlayer2 = 20;
        int heightPlayer1 = 20;
        int heightPlayer2 = 20;
        int healthPlayer1 = 200;
        int healthPlayer2 = 200;
        int fireratePlayer1 = 60;
        int fireratePlayer2 = 60;
        int damagePlayer1 = 50;
        int damagePlayer2 = 50;
        int x1Bullet = 10000;
        int y1Bullet = 10000;
        int x2Bullet = 10000;
        int y2Bullet = 10000;
        int bulletSpeed1 = 15;
        int bulletSpeed2 = 15;
        int livesPlayer1 = 3;
        int livesPlayer2 = 3;
        string directionPlayer1 = "right";
        string directionPlayer2 = "left";
        string directionB1;
        string directionB2;
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, aplayer1, sPlayer1, dPlayer1, wPlayer1, gameOn, shootPlayer1, shootPlayer2, escapeButton, resetButton;

        SoundPlayer themeSong = new SoundPlayer(Properties.Resources.RuneScape_old_Theme__1___mp3cut_net_);
        SoundPlayer victorySong = new SoundPlayer(Properties.Resources.Victory_Sound_Effect__mp3cut_net_);
        SolidBrush player1Brush = new SolidBrush(Color.Black);
        SolidBrush player2Brush = new SolidBrush(Color.White);
        SolidBrush blockBrush = new SolidBrush(Color.Gray);
        SolidBrush bullet1Brush = new SolidBrush(Color.Red);
        SolidBrush bullet2Brush = new SolidBrush(Color.LimeGreen);
        SolidBrush titelbrush = new SolidBrush(Color.Black);
        SolidBrush smallbrush = new SolidBrush(Color.Black);
        Pen redpen = new Pen(Color.Red, 10);
        Font titelFont = new Font("Papyrus", 48, FontStyle.Regular);
        Font textFont = new Font("Papyrus", 20, FontStyle.Regular);

        public Form1()
        {
            InitializeComponent();
            themeSong.PlayLooping();      
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
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
                case Keys.Space:
                    shootPlayer1 = false;
                    break;
                case Keys.L:
                    shootPlayer2 = false;
                    break;
                case Keys.Escape:
                    escapeButton = false;
                    break;
                case Keys.R:
                    resetButton = false;
                    break;
                default:
                    break;
            }
            #endregion
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
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
                case Keys.Space:
                    shootPlayer1 = true;
                    break;
                case Keys.L:
                    shootPlayer2 = true;
                    break;
                case Keys.Escape:
                    escapeButton = true;
                    break;
                case Keys.R:
                    resetButton = true;
                    break;
                default:
                    break;
            }
            #endregion
        }

        private void gametimer_Tick(object sender, EventArgs e)         
        {
            #region Check for movement 
            int xplayer1Temp = xPlayer1;
            int yPlayer1Temp = yPlayer1;
            int xPlayer2Temp = xPlayer2;
            int yPlayer2Temp = yPlayer2;

            if (leftArrowDown == true)
            {
                if(xPlayer2 > 202) 
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
            #endregion
            #region Player 1 + 2 Firing 

            //player 1 bullet directions
            if (dPlayer1 == true)
            {
                directionPlayer1 = "right";
            }

            if (wPlayer1 == true)
            {
                directionPlayer1 = "up";
            }

            if (aplayer1 == true)
            {
                directionPlayer1 = "left";
            }

            if (sPlayer1 == true)
            {
                directionPlayer1 = "down";
            }

            //Player 2 Bullet direction

            if (rightArrowDown == true)
            {
                directionPlayer2 = "right";
            }

            if (upArrowDown == true)
            {
                directionPlayer2 = "up";
            }

            if (leftArrowDown == true)
            {
                directionPlayer2 = "left";
            }

            if (downArrowDown == true)
            {
                directionPlayer2 = "down";
            }

            //Player 1 shooting 
            if (shootPlayer1 == true && (fireratePlayer1 > 60))
            {
                x1Bullet = xPlayer1;
                y1Bullet = yPlayer1;
                fireratePlayer1 = 0;
                directionB1 = directionPlayer1;

            }

            fireratePlayer1++;


            if (directionB1 == "right")
            {
                x1Bullet = x1Bullet + bulletSpeed1;
            }

            if (directionB1 == "up")
            {
                y1Bullet = y1Bullet - bulletSpeed1;
            }

            if (directionB1 == "left")
            {
                x1Bullet = x1Bullet - bulletSpeed1;
            }

            if (directionB1 == "down")
            {
                y1Bullet = y1Bullet + bulletSpeed1;
            }

            //Player 2 Shooting


            if (shootPlayer2 == true && (fireratePlayer2 > 60))
            {
                x2Bullet = xPlayer2;
                y2Bullet = yPlayer2;
                fireratePlayer2 = 0;
                directionB2 = directionPlayer2;


            }

            if (directionB2 == "right")
            {
                x2Bullet = x2Bullet + bulletSpeed2;
            }

            if (directionB2 == "up")
            {
                y2Bullet = y2Bullet - bulletSpeed2;
            }

            if (directionB2 == "left")
            {
                x2Bullet = x2Bullet - bulletSpeed2;
            }

            if (directionB2 == "down")
            {
                y2Bullet = y2Bullet + bulletSpeed2;
            }
            fireratePlayer2++;
            #endregion
            #region Player 1 + 2 Collisions

            Rectangle recPlayer1Bullet = new Rectangle(x1Bullet, y1Bullet, widthPlayer1 - 20, heightPlayer1 - 20);
            Rectangle recPlayer2Bullet = new Rectangle(x2Bullet, y2Bullet, widthPlayer2 - 20, heightPlayer2 - 20);
            Rectangle recPlayer1 = new Rectangle(xPlayer1, yPlayer1, heightPlayer1, widthPlayer1);
            Rectangle recPlayer2 = new Rectangle(xPlayer2, yPlayer2, heightPlayer2, widthPlayer2);
            Rectangle topLeftBlock = new Rectangle(275, 30, 50, 178);
            Rectangle bottomLeftBlock = new Rectangle(275, 270, 50, 178);
            Rectangle topRightBlock = new Rectangle(this.Width - 275, 30, 50, 178);
            Rectangle bottomRightBlock = new Rectangle(this.Width - 275, 270, 50, 178);
            Rectangle topBlock = new Rectangle(375, 30, 284, 50);
            Rectangle bottomBlock = new Rectangle(375, 395, 284, 50);
            Rectangle middleBlock = new Rectangle(492, 215, 50, 50);         

            if (recPlayer1.IntersectsWith(topLeftBlock))
            {
                xPlayer1 = xplayer1Temp;
                yPlayer1 = yPlayer1Temp;
            }

            if (recPlayer1.IntersectsWith(bottomLeftBlock))
            {
                xPlayer1 = xplayer1Temp;
                yPlayer1 = yPlayer1Temp;
            }

            if (recPlayer1.IntersectsWith(middleBlock))
            {
                xPlayer1 = xplayer1Temp;
                yPlayer1 = yPlayer1Temp;
            }

            if (recPlayer1.IntersectsWith(topBlock))
            {
                xPlayer1 = xplayer1Temp;
                yPlayer1 = yPlayer1Temp;
            }

            if (recPlayer1.IntersectsWith(bottomBlock))
            {
                xPlayer1 = xplayer1Temp;
                yPlayer1 = yPlayer1Temp;
            }

            if (recPlayer1.IntersectsWith(topRightBlock))
            {
                xPlayer1 = xplayer1Temp;
                yPlayer1 = yPlayer1Temp;
            }

            if (recPlayer1.IntersectsWith(bottomRightBlock))
            {
                xPlayer1 = xplayer1Temp;
                yPlayer1 = yPlayer1Temp;
            }

            #region Player 2 Collisions
            if (recPlayer2.IntersectsWith(topLeftBlock))
            {
                xPlayer2 = xPlayer2Temp;
                yPlayer2 = yPlayer2Temp;
            }

            if (recPlayer2.IntersectsWith(bottomLeftBlock))
            {
                xPlayer2 = xPlayer2Temp;
                yPlayer2 = yPlayer2Temp;
            }

            if (recPlayer2.IntersectsWith(middleBlock))
            {
                xPlayer2 = xPlayer2Temp;
                yPlayer2 = yPlayer2Temp;
            }

            if (recPlayer2.IntersectsWith(topBlock))
            {
                xPlayer2 = xPlayer2Temp;
                yPlayer2 = yPlayer2Temp;
            }

            if (recPlayer2.IntersectsWith(bottomBlock))
            {
                xPlayer2 = xPlayer2Temp;
                yPlayer2 = yPlayer2Temp;
            }

            if (recPlayer2.IntersectsWith(topRightBlock))
            {
                xPlayer2 = xPlayer2Temp;
                yPlayer2 = yPlayer2Temp;
            }

            if (recPlayer2.IntersectsWith(bottomRightBlock))
            {
                xPlayer2 = xPlayer2Temp;
                yPlayer2 = yPlayer2Temp;
            }

            #endregion

            Refresh();
            #endregion          
            #region Bullet Collision 

            //Bullet and wall collisions player 1
            if (recPlayer1Bullet.IntersectsWith(topLeftBlock))
            {
                x1Bullet = 10000;
                y1Bullet = 10000;
            }

            if (recPlayer1Bullet.IntersectsWith(bottomLeftBlock))
            {
                x1Bullet = 10000;
                y1Bullet = 10000;
            }

            if (recPlayer1Bullet.IntersectsWith(topRightBlock))
            {
                x1Bullet = 10000;
                y1Bullet = 10000;
            }

            if (recPlayer1Bullet.IntersectsWith(bottomRightBlock))
            {
                x1Bullet = 10000;
                y1Bullet = 10000;
            }

            if (recPlayer1Bullet.IntersectsWith(topBlock))
            {
                x1Bullet = 10000;
                y1Bullet = 10000;
            }

            if (recPlayer1Bullet.IntersectsWith(bottomBlock))
            {
                x1Bullet = 10000;
                y1Bullet = 10000;
            }

            if (recPlayer1Bullet.IntersectsWith(middleBlock))
            {
                x1Bullet = 10000;
                y1Bullet = 10000;
            }

            //player 2 bullet hits walll
            if (recPlayer2Bullet.IntersectsWith(topLeftBlock))
            {
                x2Bullet = 10000;
                y2Bullet = 10000;
            }

            if (recPlayer2Bullet.IntersectsWith(bottomLeftBlock))
            {
                x2Bullet = 10000;
                y2Bullet = 10000;
            }

            if (recPlayer2Bullet.IntersectsWith(topRightBlock))
            {
                x2Bullet = 10000;
                y2Bullet = 10000;
            }

            if (recPlayer2Bullet.IntersectsWith(bottomRightBlock))
            {
                x2Bullet = 10000;
                y2Bullet = 10000;
            }

            if (recPlayer2Bullet.IntersectsWith(topBlock))
            {
                x2Bullet = 10000;
                y2Bullet = 10000;
            }

            if (recPlayer2Bullet.IntersectsWith(bottomBlock))
            {
                x2Bullet = 10000;
                y2Bullet = 10000;
            }

            if (recPlayer2Bullet.IntersectsWith(middleBlock))
            {
                x2Bullet = 10000;
                y2Bullet = 10000;
            }

            // player hits bullet
            if (recPlayer1.IntersectsWith(recPlayer2Bullet))
            {
                x2Bullet = 10000;
                y2Bullet = 10000;

                healthPlayer1 = healthPlayer1 - damagePlayer2;

                if (healthPlayer1 <= 0)
                {
                    livesPlayer1--;
                    if (classPlayer1 == 1)
                    {
                        healthPlayer1 = 200;
                    }

                    else if(classPlayer1 == 2)
                    {
                        healthPlayer1 = 100;
                    }

                    else if(classPlayer1 == 3)
                    {
                        healthPlayer1 = 300;
                    }

                    xPlayer1 = 50;
                    yPlayer1 = 245;
                }
            }

            if (recPlayer2.IntersectsWith(recPlayer1Bullet))
            {
                x1Bullet = 10000;
                y1Bullet = 10000;

                healthPlayer2 = healthPlayer2 - damagePlayer1;

                if (healthPlayer2 <= 0)
                {
                    livesPlayer2--;
                    if (classPlayer2 == 1)
                    {
                        healthPlayer2 = 200;
                    }

                    else if (classPlayer2 == 2)
                    {
                        healthPlayer2 = 100;
                    }

                    else if(classPlayer2 == 3)
                    {
                        healthPlayer2 = 300;
                    }
                    xPlayer2 = 900;
                    yPlayer2 = 245;
                }
            }

            livesPlayer1Label.Text = "Lives:" + livesPlayer1;
            healthPlayer1Label.Text = "Health:" + healthPlayer1;
            livesPlayer2Label.Text = "Lives:" + livesPlayer2;
            healthPlayer2Label.Text = "Health:" + healthPlayer2;

            #endregion
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            #region Draw Players and graphics 

            if (gameOn == true)
            {
                //draw spawn areas 
                e.Graphics.FillRectangle(player1Brush, 200, 0, 5, this.Width);
                e.Graphics.FillRectangle(player2Brush, this.Width - 200, 0, 5, this.Height);
                //draw gray blocks
                e.Graphics.FillRectangle(blockBrush, 275, 30, 50, 178);
                e.Graphics.FillRectangle(blockBrush, 275, 270, 50, 178);
                //right blocks
                e.Graphics.FillRectangle(blockBrush, this.Width - 275, 30, 50, 178);
                e.Graphics.FillRectangle(blockBrush, this.Width - 275, 270, 50, 178);
                //Top and Bottom blocks 
                e.Graphics.FillRectangle(blockBrush, 375, 30, 284, 50);
                e.Graphics.FillRectangle(blockBrush, 375,395, 284, 50);
                //middle block
                e.Graphics.FillRectangle(blockBrush, 492, 215, 50, 50);
                //Draw Players 
                e.Graphics.FillRectangle(player2Brush, xPlayer2, yPlayer2, widthPlayer2, heightPlayer2);
                e.Graphics.FillRectangle(player1Brush, xPlayer1, yPlayer1, widthPlayer1, heightPlayer1);
                //Draw Bullets 
                e.Graphics.FillRectangle(bullet2Brush, x2Bullet, y2Bullet, widthPlayer2 - 10, heightPlayer2 - 10);
                e.Graphics.FillRectangle(bullet1Brush, x1Bullet, y1Bullet, widthPlayer1 - 10, heightPlayer1 - 10);

                if(livesPlayer1 == 0)
                {
                    themeSong.Stop();
                    e.Graphics.Clear(Color.IndianRed);
                    e.Graphics.DrawString("PLAYER TWO WINS", titelFont, smallbrush, 125, 200);
                    e.Graphics.DrawString("Press Esc to exit or press R to reset", textFont, smallbrush, 275, 300);
                    livesPlayer1Label.Visible = false;
                    healthPlayer1Label.Visible = false;
                    livesPlayer2Label.Visible = false;
                    healthPlayer2Label.Visible = false;

                    if (resetButton == true)
                    {
                        Refresh();
                        playButton.Visible = true;
                        howToPlayButton.Visible = true;
                        menuButton.Visible = false;
                        classSelect1.Visible = false;
                        classSelect2.Visible = false;
                        startbutton.Visible = false;
                        normaltankpic.Visible = false;
                        glasscanonpic.Visible = false;
                        glasscanonlable.Visible = false;
                        normaltanklabel.Visible = false;
                        juggernautlable.Visible = false;
                        dualimage.Visible = true;
                        titleLabel.Visible = true;
                        chooselabel.Visible = false;
                        player1label.Visible = false;
                        player2label.Visible = false;
                        gameOn = false;
                    }

                    if (escapeButton == true)
                    {
                        this.Close();
                    }

                    victorySong.Play();
                }

                else if(livesPlayer2 == 0)
                {
                    themeSong.Stop();
                    e.Graphics.Clear(Color.IndianRed);
                    e.Graphics.DrawString("PLAYER ONE WINS", titelFont, smallbrush, 125, 200);
                    e.Graphics.DrawString("Press Esc to exit or press R to reset", textFont, smallbrush, 275, 300);
                    livesPlayer2Label.Visible = false;
                    healthPlayer2Label.Visible = false;
                    livesPlayer1Label.Visible = false;
                    healthPlayer1Label.Visible = false;

                    if (resetButton == true)
                    {
                        Refresh();
                        playButton.Visible = true;
                        howToPlayButton.Visible = true;
                        menuButton.Visible = false;
                        classSelect1.Visible = false;
                        classSelect2.Visible = false;
                        startbutton.Visible = false;
                        normaltankpic.Visible = false;
                        glasscanonpic.Visible = false;
                        glasscanonlable.Visible = false;
                        normaltanklabel.Visible = false;
                        juggernautlable.Visible = false;
                        dualimage.Visible = true;
                        titleLabel.Visible = true;
                        chooselabel.Visible = false;
                        player1label.Visible = false;
                        player2label.Visible = false;
                        gameOn = false;
                        livesPlayer1 = 3;
                        livesPlayer2 = 3;
                    }

                    if (escapeButton == true)
                    {
                        this.Close();
                    }

                    victorySong.Play();
                }

            }
            #endregion
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            #region Class Select Screen
        
            playButton.Visible = false;
            howToPlayButton.Visible = false;
            menuButton.Visible = true;
            classSelect1.Visible = true;
            classSelect2.Visible = true;
            startbutton.Visible = true;
            normaltankpic.Visible = true;
            glasscanonpic.Visible = true;
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
            #region How to play screen
            //Graphics
            Graphics fg = this.CreateGraphics();
            menuButton.Visible = true;
            dualimage.Visible = false;
            howToPlayButton.Visible = false;
            playButton.Visible = false;
            titleLabel.Visible = false;          
            chooselabel.Visible = false;           
            player1label.Visible = false;
            player2label.Visible = false;
            Refresh();
            fg.DrawString("How To Play", titelFont, titelbrush, 290, 20);
            fg.DrawString("This is a 1v1 tank game, player 1 uses wasd and spacebar,\n  player 2 uses arrow keys and L key to shoot. \n each player has 3 lives and can choose from 3 different tanks, \n each have different features listed in the play screen.\n First tank to destroy the other 3 times wins!", textFont, smallbrush, 175, 150);
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
            #region Start Game
            gameOn = true;
            gametimer.Enabled = true;
            gametimer.Start();     
            classPlayer1 = Convert.ToInt32(classSelect1.Text);
            classPlayer2 = Convert.ToInt32(classSelect2.Text);
            dualimage.Visible = false;
            startbutton.Visible = false;
            chooselabel.Visible = false;
            player1label.Visible = false;
            player2label.Visible = false;
            livesPlayer1Label.Visible = true;
            livesPlayer2Label.Visible = true;
            healthPlayer1Label.Visible = true;
            healthPlayer2Label.Visible = true;
                   
            if (classPlayer2 == 2)
            {
                fireratePlayer2 = 40;
                healthPlayer2 = 100;
                damagePlayer2 = 100;
                speedPlayer2 = 10;
            }

            else if (classPlayer2 == 3)
            {
                fireratePlayer2 = 120;
                healthPlayer2 = 300;
                damagePlayer2 = 200;
                speedPlayer2 = 5;
            }

             if (classPlayer1 == 2)
            {
                fireratePlayer1 = 40;
                healthPlayer1 = 100;
                damagePlayer1 = 100;
                speedPlayer1 = 7;
            }

            else if (classPlayer1 == 3)
            {
                fireratePlayer1 = 120;
                healthPlayer1 = 300;
                damagePlayer1 = 200;
                speedPlayer1 = 5;
            }
                   
            titleLabel.Visible = false;
            juggernautlable.Visible = false;
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

