﻿namespace FinalDual
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.howToPlayButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.classSelect1 = new System.Windows.Forms.TextBox();
            this.classSelect2 = new System.Windows.Forms.TextBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.startbutton = new System.Windows.Forms.Button();
            this.glasscanonpic = new System.Windows.Forms.PictureBox();
            this.normaltankpic = new System.Windows.Forms.PictureBox();
            this.dualimage = new System.Windows.Forms.PictureBox();
            this.glasscanonlable = new System.Windows.Forms.Label();
            this.normaltanklabel = new System.Windows.Forms.Label();
            this.juggernautlable = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.chooselabel = new System.Windows.Forms.Label();
            this.player2label = new System.Windows.Forms.Label();
            this.player1label = new System.Windows.Forms.Label();
            this.livesPlayer1Label = new System.Windows.Forms.Label();
            this.livesPlayer2Label = new System.Windows.Forms.Label();
            this.healthPlayer1Label = new System.Windows.Forms.Label();
            this.healthPlayer2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.glasscanonpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normaltankpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dualimage)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Papyrus", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(350, 3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(277, 151);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Dual";
            // 
            // howToPlayButton
            // 
            this.howToPlayButton.BackColor = System.Drawing.Color.Silver;
            this.howToPlayButton.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlayButton.Location = new System.Drawing.Point(106, 265);
            this.howToPlayButton.Name = "howToPlayButton";
            this.howToPlayButton.Size = new System.Drawing.Size(230, 62);
            this.howToPlayButton.TabIndex = 1;
            this.howToPlayButton.Text = "How To Play";
            this.howToPlayButton.UseVisualStyleBackColor = false;
            this.howToPlayButton.Click += new System.EventHandler(this.howToPlayButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Silver;
            this.playButton.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(656, 265);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(230, 62);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play!";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // classSelect1
            // 
            this.classSelect1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.classSelect1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classSelect1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classSelect1.Location = new System.Drawing.Point(768, 233);
            this.classSelect1.Name = "classSelect1";
            this.classSelect1.Size = new System.Drawing.Size(23, 26);
            this.classSelect1.TabIndex = 4;
            this.classSelect1.Text = "1";
            this.classSelect1.Visible = false;
            // 
            // classSelect2
            // 
            this.classSelect2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.classSelect2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classSelect2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classSelect2.Location = new System.Drawing.Point(768, 333);
            this.classSelect2.Name = "classSelect2";
            this.classSelect2.Size = new System.Drawing.Size(23, 26);
            this.classSelect2.TabIndex = 5;
            this.classSelect2.Text = "1\r\n";
            this.classSelect2.Visible = false;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Silver;
            this.menuButton.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(24, 408);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(240, 62);
            this.menuButton.TabIndex = 6;
            this.menuButton.Text = "Return To Menu ";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Visible = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.Silver;
            this.startbutton.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(383, 412);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(223, 62);
            this.startbutton.TabIndex = 8;
            this.startbutton.Text = "Start ";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Visible = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // glasscanonpic
            // 
            this.glasscanonpic.Image = global::FinalDual.Properties.Resources.download;
            this.glasscanonpic.Location = new System.Drawing.Point(673, 3);
            this.glasscanonpic.Name = "glasscanonpic";
            this.glasscanonpic.Size = new System.Drawing.Size(228, 186);
            this.glasscanonpic.TabIndex = 10;
            this.glasscanonpic.TabStop = false;
            this.glasscanonpic.Visible = false;
            // 
            // normaltankpic
            // 
            this.normaltankpic.BackColor = System.Drawing.Color.IndianRed;
            this.normaltankpic.Image = global::FinalDual.Properties.Resources.images;
            this.normaltankpic.Location = new System.Drawing.Point(85, 3);
            this.normaltankpic.Name = "normaltankpic";
            this.normaltankpic.Size = new System.Drawing.Size(207, 176);
            this.normaltankpic.TabIndex = 9;
            this.normaltankpic.TabStop = false;
            this.normaltankpic.Visible = false;
            // 
            // dualimage
            // 
            this.dualimage.Image = global::FinalDual.Properties.Resources.swords;
            this.dualimage.Location = new System.Drawing.Point(383, 182);
            this.dualimage.Name = "dualimage";
            this.dualimage.Size = new System.Drawing.Size(223, 224);
            this.dualimage.TabIndex = 7;
            this.dualimage.TabStop = false;
            // 
            // glasscanonlable
            // 
            this.glasscanonlable.AutoSize = true;
            this.glasscanonlable.BackColor = System.Drawing.Color.Transparent;
            this.glasscanonlable.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glasscanonlable.Location = new System.Drawing.Point(26, 265);
            this.glasscanonlable.Name = "glasscanonlable";
            this.glasscanonlable.Size = new System.Drawing.Size(354, 50);
            this.glasscanonlable.TabIndex = 12;
            this.glasscanonlable.Text = "2. Glass Canon: light armored tank that moves fast,\r\n hits hard, but has very low" +
    " hp\r\n";
            this.glasscanonlable.Visible = false;
            // 
            // normaltanklabel
            // 
            this.normaltanklabel.AutoSize = true;
            this.normaltanklabel.BackColor = System.Drawing.Color.Transparent;
            this.normaltanklabel.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normaltanklabel.Location = new System.Drawing.Point(26, 197);
            this.normaltanklabel.Name = "normaltanklabel";
            this.normaltanklabel.Size = new System.Drawing.Size(287, 50);
            this.normaltanklabel.TabIndex = 13;
            this.normaltanklabel.Text = "1. Normal: normal hp, damage, and speed. \r\nthis tank is the definition of average" +
    "";
            this.normaltanklabel.Visible = false;
            // 
            // juggernautlable
            // 
            this.juggernautlable.AutoSize = true;
            this.juggernautlable.BackColor = System.Drawing.Color.Transparent;
            this.juggernautlable.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juggernautlable.Location = new System.Drawing.Point(26, 330);
            this.juggernautlable.Name = "juggernautlable";
            this.juggernautlable.Size = new System.Drawing.Size(338, 75);
            this.juggernautlable.TabIndex = 14;
            this.juggernautlable.Text = "3.  Juggernaut: a Heavy tank with a lot of hp and \r\ndamage but is very slow \r\n\r\n";
            this.juggernautlable.Visible = false;
            // 
            // gametimer
            // 
            this.gametimer.Interval = 16;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // chooselabel
            // 
            this.chooselabel.AutoSize = true;
            this.chooselabel.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooselabel.Location = new System.Drawing.Point(612, 377);
            this.chooselabel.Name = "chooselabel";
            this.chooselabel.Size = new System.Drawing.Size(346, 76);
            this.chooselabel.TabIndex = 15;
            this.chooselabel.Text = "Insert the number corresponding\r\n to the class you want to select";
            this.chooselabel.Visible = false;
            // 
            // player2label
            // 
            this.player2label.AutoSize = true;
            this.player2label.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2label.Location = new System.Drawing.Point(708, 294);
            this.player2label.Name = "player2label";
            this.player2label.Size = new System.Drawing.Size(152, 33);
            this.player2label.TabIndex = 16;
            this.player2label.Text = "Player 2 Select";
            this.player2label.Visible = false;
            // 
            // player1label
            // 
            this.player1label.AutoSize = true;
            this.player1label.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1label.Location = new System.Drawing.Point(708, 197);
            this.player1label.Name = "player1label";
            this.player1label.Size = new System.Drawing.Size(152, 33);
            this.player1label.TabIndex = 17;
            this.player1label.Text = "Player 1 Select";
            this.player1label.Visible = false;
            // 
            // livesPlayer1Label
            // 
            this.livesPlayer1Label.AutoSize = true;
            this.livesPlayer1Label.BackColor = System.Drawing.Color.Transparent;
            this.livesPlayer1Label.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesPlayer1Label.Location = new System.Drawing.Point(2, 3);
            this.livesPlayer1Label.Name = "livesPlayer1Label";
            this.livesPlayer1Label.Size = new System.Drawing.Size(144, 38);
            this.livesPlayer1Label.TabIndex = 18;
            this.livesPlayer1Label.Text = "Label Lives ";
            this.livesPlayer1Label.Visible = false;
            // 
            // livesPlayer2Label
            // 
            this.livesPlayer2Label.AutoSize = true;
            this.livesPlayer2Label.BackColor = System.Drawing.Color.Transparent;
            this.livesPlayer2Label.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesPlayer2Label.Location = new System.Drawing.Point(827, 3);
            this.livesPlayer2Label.Name = "livesPlayer2Label";
            this.livesPlayer2Label.Size = new System.Drawing.Size(144, 38);
            this.livesPlayer2Label.TabIndex = 19;
            this.livesPlayer2Label.Text = "Label Lives ";
            this.livesPlayer2Label.Visible = false;
            // 
            // healthPlayer1Label
            // 
            this.healthPlayer1Label.AutoSize = true;
            this.healthPlayer1Label.BackColor = System.Drawing.Color.Transparent;
            this.healthPlayer1Label.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthPlayer1Label.Location = new System.Drawing.Point(2, 41);
            this.healthPlayer1Label.Name = "healthPlayer1Label";
            this.healthPlayer1Label.Size = new System.Drawing.Size(144, 38);
            this.healthPlayer1Label.TabIndex = 20;
            this.healthPlayer1Label.Text = "Label Lives ";
            this.healthPlayer1Label.Visible = false;
            // 
            // healthPlayer2Label
            // 
            this.healthPlayer2Label.AutoSize = true;
            this.healthPlayer2Label.BackColor = System.Drawing.Color.Transparent;
            this.healthPlayer2Label.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthPlayer2Label.Location = new System.Drawing.Point(827, 41);
            this.healthPlayer2Label.Name = "healthPlayer2Label";
            this.healthPlayer2Label.Size = new System.Drawing.Size(145, 38);
            this.healthPlayer2Label.TabIndex = 21;
            this.healthPlayer2Label.Text = "Health: 200";
            this.healthPlayer2Label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(971, 475);
            this.Controls.Add(this.healthPlayer2Label);
            this.Controls.Add(this.healthPlayer1Label);
            this.Controls.Add(this.livesPlayer2Label);
            this.Controls.Add(this.livesPlayer1Label);
            this.Controls.Add(this.player1label);
            this.Controls.Add(this.player2label);
            this.Controls.Add(this.chooselabel);
            this.Controls.Add(this.juggernautlable);
            this.Controls.Add(this.normaltanklabel);
            this.Controls.Add(this.glasscanonlable);
            this.Controls.Add(this.glasscanonpic);
            this.Controls.Add(this.normaltankpic);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.dualimage);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.classSelect2);
            this.Controls.Add(this.classSelect1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.howToPlayButton);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.glasscanonpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normaltankpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dualimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button howToPlayButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TextBox classSelect1;
        private System.Windows.Forms.TextBox classSelect2;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.PictureBox dualimage;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.PictureBox normaltankpic;
        private System.Windows.Forms.PictureBox glasscanonpic;
        private System.Windows.Forms.Label glasscanonlable;
        private System.Windows.Forms.Label normaltanklabel;
        private System.Windows.Forms.Label juggernautlable;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label chooselabel;
        private System.Windows.Forms.Label player2label;
        private System.Windows.Forms.Label player1label;
        private System.Windows.Forms.Label livesPlayer1Label;
        private System.Windows.Forms.Label livesPlayer2Label;
        private System.Windows.Forms.Label healthPlayer1Label;
        private System.Windows.Forms.Label healthPlayer2Label;
    }
}

