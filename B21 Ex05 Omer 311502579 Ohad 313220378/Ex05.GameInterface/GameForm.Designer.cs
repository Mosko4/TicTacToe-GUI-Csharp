﻿using System;

namespace Ex05.GameInterface
{
    partial class GameForm
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
            this.Player1Name = new System.Windows.Forms.Label();
            this.Player1Score = new System.Windows.Forms.Label();
            this.Player2Name = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.Label();
            this.ClientSize = new System.Drawing.Size(r_BoardSize * k_ButtonSize + 20, r_BoardSize * k_ButtonSize + 140);
            this.SuspendLayout();

            // 
            // Player1Score
            // 
            this.Player1Score.AutoSize = true;
            this.Player1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Player1Score.Location = new System.Drawing.Point(Width / 2 - 5, Bottom - 60);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(14, 13);
            this.Player1Score.TabIndex = 1;
            this.Player1Score.Text = "0";


            // 
            // Player1Name
            // 
            this.Player1Name.AutoSize = true;
            this.Player1Name.Size = new System.Drawing.Size(53, 13);
            this.Player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Player1Name.Location = new System.Drawing.Point(Player1Score.Location.X - Player1Name.Width - 15, Player1Score.Location.Y);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.TabIndex = 0;
            this.Player1Name.Text = string.Format("{0}: ", r_Player1Name);
            
            // 
            // Player2Name
            // 
            this.Player2Name.AutoSize = true;
            this.Player2Name.Location = new System.Drawing.Point(this.Player1Score.Size.Width + this.Player1Score.Location.X + 10, this.Player1Score.Location.Y);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(45, 13);
            this.Player2Name.TabIndex = 3;
            this.Player2Name.Text = string.Format(r_IsPlayer2AI ? "Computer: " : "{0}: ", r_Player2Name);
            // 
            // Player2Score
            // 
            this.Player2Score.AutoSize = true;
            this.Player2Score.Location = new System.Drawing.Point(this.Player2Name.Size.Width + this.Player2Name.Location.X + 25, this.Player2Name.Location.Y);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(13, 13);
            this.Player2Score.TabIndex = 2;
            this.Player2Score.Text = "0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.Player2Score);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.Player1Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GameForm";
            this.Text = "Tic-Tac-Toe 2021";
            this.Load += GameForm_Load;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label Player1Name;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label Player2Name;
        private System.Windows.Forms.Label Player2Score;
    }
}