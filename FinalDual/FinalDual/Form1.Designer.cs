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
            this.titleLabel = new System.Windows.Forms.Label();
            this.howToPlayButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.classSelect1 = new System.Windows.Forms.TextBox();
            this.classSelect2 = new System.Windows.Forms.TextBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.startbutton = new System.Windows.Forms.Button();
            this.juggernautpic = new System.Windows.Forms.PictureBox();
            this.glasscanonpic = new System.Windows.Forms.PictureBox();
            this.normaltankpic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.glasscanonlable = new System.Windows.Forms.Label();
            this.normaltanklabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.juggernautpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glasscanonpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normaltankpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.howToPlayButton.Location = new System.Drawing.Point(125, 299);
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
            this.playButton.Location = new System.Drawing.Point(671, 299);
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
            this.classSelect1.Location = new System.Drawing.Point(191, 252);
            this.classSelect1.Name = "classSelect1";
            this.classSelect1.Size = new System.Drawing.Size(34, 26);
            this.classSelect1.TabIndex = 4;
            this.classSelect1.Visible = false;
            // 
            // classSelect2
            // 
            this.classSelect2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.classSelect2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classSelect2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classSelect2.Location = new System.Drawing.Point(756, 252);
            this.classSelect2.Name = "classSelect2";
            this.classSelect2.Size = new System.Drawing.Size(34, 26);
            this.classSelect2.TabIndex = 5;
            this.classSelect2.Visible = false;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Silver;
            this.menuButton.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(12, 401);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(240, 62);
            this.menuButton.TabIndex = 6;
            this.menuButton.Text = "Return To Menu ";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Visible = false;
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.Silver;
            this.startbutton.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(376, 412);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(230, 62);
            this.startbutton.TabIndex = 8;
            this.startbutton.Text = "Start ";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Visible = false;
            // 
            // juggernautpic
            // 
            this.juggernautpic.BackColor = System.Drawing.Color.White;
            this.juggernautpic.Image = global::FinalDual.Properties.Resources.images__1_;
            this.juggernautpic.Location = new System.Drawing.Point(390, 197);
            this.juggernautpic.Name = "juggernautpic";
            this.juggernautpic.Size = new System.Drawing.Size(216, 193);
            this.juggernautpic.TabIndex = 11;
            this.juggernautpic.TabStop = false;
            this.juggernautpic.Visible = false;
            // 
            // glasscanonpic
            // 
            this.glasscanonpic.Image = global::FinalDual.Properties.Resources.download;
            this.glasscanonpic.Location = new System.Drawing.Point(660, 3);
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
            this.normaltankpic.Location = new System.Drawing.Point(45, 3);
            this.normaltankpic.Name = "normaltankpic";
            this.normaltankpic.Size = new System.Drawing.Size(207, 176);
            this.normaltankpic.TabIndex = 9;
            this.normaltankpic.TabStop = false;
            this.normaltankpic.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalDual.Properties.Resources.swords;
            this.pictureBox1.Location = new System.Drawing.Point(383, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 224);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // glasscanonlable
            // 
            this.glasscanonlable.AutoSize = true;
            this.glasscanonlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glasscanonlable.Location = new System.Drawing.Point(636, 197);
            this.glasscanonlable.Name = "glasscanonlable";
            this.glasscanonlable.Size = new System.Drawing.Size(292, 32);
            this.glasscanonlable.TabIndex = 12;
            this.glasscanonlable.Text = "2.Glass Canon:light armored tank that moes fast,\r\n hits hard, but has very low HP" +
    "";
            this.glasscanonlable.Visible = false;
            // 
            // normaltanklabel
            // 
            this.normaltanklabel.AutoSize = true;
            this.normaltanklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normaltanklabel.Location = new System.Drawing.Point(42, 197);
            this.normaltanklabel.Name = "normaltanklabel";
            this.normaltanklabel.Size = new System.Drawing.Size(261, 32);
            this.normaltanklabel.TabIndex = 13;
            this.normaltanklabel.Text = "1.Normal: normal hp, damage, and speed. \r\nthis tank is the definition of average";
            this.normaltanklabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(971, 475);
            this.Controls.Add(this.normaltanklabel);
            this.Controls.Add(this.glasscanonlable);
            this.Controls.Add(this.juggernautpic);
            this.Controls.Add(this.glasscanonpic);
            this.Controls.Add(this.normaltankpic);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.classSelect2);
            this.Controls.Add(this.classSelect1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.howToPlayButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.juggernautpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glasscanonpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normaltankpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.PictureBox normaltankpic;
        private System.Windows.Forms.PictureBox glasscanonpic;
        private System.Windows.Forms.PictureBox juggernautpic;
        private System.Windows.Forms.Label glasscanonlable;
        private System.Windows.Forms.Label normaltanklabel;
    }
}

