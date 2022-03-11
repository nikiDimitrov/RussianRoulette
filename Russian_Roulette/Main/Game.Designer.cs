
namespace Russian_Roulette
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shootButton = new System.Windows.Forms.Button();
            this.spinButton = new System.Windows.Forms.Button();
            this.bulletsLeftTextBox = new System.Windows.Forms.TextBox();
            this.introButton = new System.Windows.Forms.Button();
            this.tryAgainButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(336, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // shootButton
            // 
            this.shootButton.Location = new System.Drawing.Point(148, 349);
            this.shootButton.Name = "shootButton";
            this.shootButton.Size = new System.Drawing.Size(136, 49);
            this.shootButton.TabIndex = 1;
            this.shootButton.Text = "Shoot";
            this.shootButton.UseVisualStyleBackColor = true;
            this.shootButton.Click += new System.EventHandler(this.shootButton_Click);
            // 
            // spinButton
            // 
            this.spinButton.Location = new System.Drawing.Point(513, 349);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(126, 49);
            this.spinButton.TabIndex = 2;
            this.spinButton.Text = "Spin";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // bulletsLeftTextBox
            // 
            this.bulletsLeftTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.bulletsLeftTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bulletsLeftTextBox.Location = new System.Drawing.Point(38, 143);
            this.bulletsLeftTextBox.Name = "bulletsLeftTextBox";
            this.bulletsLeftTextBox.ReadOnly = true;
            this.bulletsLeftTextBox.Size = new System.Drawing.Size(100, 13);
            this.bulletsLeftTextBox.TabIndex = 3;
            this.bulletsLeftTextBox.TabStop = false;
            this.bulletsLeftTextBox.Text = "Bullets left:";
            // 
            // introButton
            // 
            this.introButton.Location = new System.Drawing.Point(623, 133);
            this.introButton.Name = "introButton";
            this.introButton.Size = new System.Drawing.Size(126, 23);
            this.introButton.TabIndex = 4;
            this.introButton.Text = "Back to Menu";
            this.introButton.UseVisualStyleBackColor = true;
            this.introButton.Click += new System.EventHandler(this.introButton_Click);
            // 
            // tryAgainButton
            // 
            this.tryAgainButton.Location = new System.Drawing.Point(623, 104);
            this.tryAgainButton.Name = "tryAgainButton";
            this.tryAgainButton.Size = new System.Drawing.Size(126, 23);
            this.tryAgainButton.TabIndex = 5;
            this.tryAgainButton.Text = "Try Again";
            this.tryAgainButton.UseVisualStyleBackColor = true;
            this.tryAgainButton.Visible = false;
            this.tryAgainButton.Click += new System.EventHandler(this.tryAgainButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(623, 75);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(126, 23);
            this.newGameButton.TabIndex = 6;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Visible = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.tryAgainButton);
            this.Controls.Add(this.introButton);
            this.Controls.Add(this.bulletsLeftTextBox);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.shootButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Russian Roulette";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button shootButton;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.TextBox bulletsLeftTextBox;
        private System.Windows.Forms.Button introButton;
        private System.Windows.Forms.Button tryAgainButton;
        private System.Windows.Forms.Button newGameButton;
    }
}