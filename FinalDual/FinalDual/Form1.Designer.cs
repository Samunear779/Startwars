namespace FinalDual
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
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Papyrus", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(348, 33);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(277, 151);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Dual";
            // 
            // howToPlayButton
            // 
            this.howToPlayButton.BackColor = System.Drawing.Color.Silver;
            this.howToPlayButton.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlayButton.Location = new System.Drawing.Point(138, 299);
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
            this.playButton.Location = new System.Drawing.Point(615, 299);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(230, 62);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play!";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // classSelect1
            // 
            this.classSelect1.BackColor = System.Drawing.Color.IndianRed;
            this.classSelect1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classSelect1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classSelect1.Location = new System.Drawing.Point(741, 158);
            this.classSelect1.Name = "classSelect1";
            this.classSelect1.Size = new System.Drawing.Size(34, 26);
            this.classSelect1.TabIndex = 4;
            // 
            // classSelect2
            // 
            this.classSelect2.BackColor = System.Drawing.Color.IndianRed;
            this.classSelect2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classSelect2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classSelect2.Location = new System.Drawing.Point(741, 223);
            this.classSelect2.Name = "classSelect2";
            this.classSelect2.Size = new System.Drawing.Size(34, 26);
            this.classSelect2.TabIndex = 5;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(971, 475);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.classSelect2);
            this.Controls.Add(this.classSelect1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.howToPlayButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

