using Animals.UI.UIEngineHandshake.Support;
using System;

namespace Animals.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.cmdStartGame = new System.Windows.Forms.Button();
            this.playerConsole = new System.Windows.Forms.TextBox();
            this.opponentConsole = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRound = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxWinner = new System.Windows.Forms.TextBox();
            this.userLifeBar = new System.Windows.Forms.ProgressBar();
            this.opponentLifeBar = new System.Windows.Forms.ProgressBar();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxOpponent = new System.Windows.Forms.PictureBox();
            PlayerCardLabels = new CardLabels();
            PCCardLabels = new CardLabels();            
            this.playerScoreTxtBox = new System.Windows.Forms.TextBox();
            this.pcScoreTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpponent)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdStartGame
            // 
            this.cmdStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStartGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmdStartGame.Location = new System.Drawing.Point(1172, 527);
            this.cmdStartGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdStartGame.Name = "cmdStartGame";
            this.cmdStartGame.Size = new System.Drawing.Size(209, 41);
            this.cmdStartGame.TabIndex = 0;
            this.cmdStartGame.Text = "Start Game";
            this.cmdStartGame.UseVisualStyleBackColor = true;
            this.cmdStartGame.Click += new System.EventHandler(this.cmdStartGame_Click);
            // 
            // playerConsole
            // 
            this.playerConsole.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.playerConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerConsole.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.playerConsole.Location = new System.Drawing.Point(709, 47);
            this.playerConsole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerConsole.Multiline = true;
            this.playerConsole.Name = "playerConsole";
            this.playerConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.playerConsole.Size = new System.Drawing.Size(671, 203);
            this.playerConsole.TabIndex = 1;
            // 
            // opponentConsole
            // 
            this.opponentConsole.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.opponentConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentConsole.ForeColor = System.Drawing.Color.Red;
            this.opponentConsole.Location = new System.Drawing.Point(709, 271);
            this.opponentConsole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.opponentConsole.Multiline = true;
            this.opponentConsole.Name = "opponentConsole";
            this.opponentConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.opponentConsole.Size = new System.Drawing.Size(671, 203);
            this.opponentConsole.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(163, 539);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(268, 23);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Text = "Symeon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(16, 537);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name:";
            // 
            // txtRound
            // 
            this.txtRound.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRound.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRound.ForeColor = System.Drawing.Color.Transparent;
            this.txtRound.Location = new System.Drawing.Point(1248, 4);
            this.txtRound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(132, 23);
            this.txtRound.TabIndex = 5;
            this.txtRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(1125, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Round:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(704, 505);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Winner:";
            // 
            // txtBoxWinner
            // 
            this.txtBoxWinner.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxWinner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtBoxWinner.Location = new System.Drawing.Point(833, 505);
            this.txtBoxWinner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxWinner.Name = "txtBoxWinner";
            this.txtBoxWinner.Size = new System.Drawing.Size(132, 23);
            this.txtBoxWinner.TabIndex = 8;
            // 
            // userLifeBar
            // 
            this.userLifeBar.Location = new System.Drawing.Point(21, 401);
            this.userLifeBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userLifeBar.Name = "userLifeBar";
            this.userLifeBar.Size = new System.Drawing.Size(303, 28);
            this.userLifeBar.TabIndex = 9;
            // 
            // opponentLifeBar
            // 
            this.opponentLifeBar.Location = new System.Drawing.Point(369, 401);
            this.opponentLifeBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.opponentLifeBar.Name = "opponentLifeBar";
            this.opponentLifeBar.Size = new System.Drawing.Size(303, 28);
            this.opponentLifeBar.TabIndex = 10;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Location = new System.Drawing.Point(21, 15);
            this.pictureBoxPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(303, 379);
            this.pictureBoxPlayer.TabIndex = 11;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // pictureBoxOpponent
            // 
            this.pictureBoxOpponent.Location = new System.Drawing.Point(369, 15);
            this.pictureBoxOpponent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxOpponent.Name = "pictureBoxOpponent";
            this.pictureBoxOpponent.Size = new System.Drawing.Size(303, 379);
            this.pictureBoxOpponent.TabIndex = 12;
            this.pictureBoxOpponent.TabStop = false;
            // 
            // PlayerCardLabels.Defence
            // 
            this.PlayerCardLabels.Defence.AutoSize = true;
            this.PlayerCardLabels.Defence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCardLabels.Defence.ForeColor = System.Drawing.Color.Cyan;
            this.PlayerCardLabels.Defence.Location = new System.Drawing.Point(17, 459);
            this.PlayerCardLabels.Defence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerCardLabels.Defence.Name = "PlayerCardLabels.Defence";
            this.PlayerCardLabels.Defence.Size = new System.Drawing.Size(36, 20);
            this.PlayerCardLabels.Defence.TabIndex = 13;
            this.PlayerCardLabels.Defence.Text = "xxx";
            // 
            // PlayerCardLabels.Attack
            // 
            this.PlayerCardLabels.Attack.AutoSize = true;
            this.PlayerCardLabels.Attack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCardLabels.Attack.ForeColor = System.Drawing.Color.Red;
            this.PlayerCardLabels.Attack.Location = new System.Drawing.Point(17, 433);
            this.PlayerCardLabels.Attack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerCardLabels.Attack.Name = "PlayerCardLabels.Attack";
            this.PlayerCardLabels.Attack.Size = new System.Drawing.Size(36, 20);
            this.PlayerCardLabels.Attack.TabIndex = 14;
            this.PlayerCardLabels.Attack.Text = "xxx";
            // 
            // PlayerCardLabels.Life
            // 
            this.PlayerCardLabels.Life.AutoSize = true;
            this.PlayerCardLabels.Life.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCardLabels.Life.ForeColor = System.Drawing.Color.Lime;
            this.PlayerCardLabels.Life.Location = new System.Drawing.Point(255, 433);
            this.PlayerCardLabels.Life.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerCardLabels.Life.Name = "PlayerCardLabels.Life";
            this.PlayerCardLabels.Life.Size = new System.Drawing.Size(69, 20);
            this.PlayerCardLabels.Life.TabIndex = 15;
            this.PlayerCardLabels.Life.Text = "xxx:yyy";
            // 
            // PCCardLabels.Life
            // 
            this.PCCardLabels.Life.AutoSize = true;
            this.PCCardLabels.Life.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCCardLabels.Life.ForeColor = System.Drawing.Color.Lime;
            this.PCCardLabels.Life.Location = new System.Drawing.Point(603, 433);
            this.PCCardLabels.Life.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PCCardLabels.Life.Name = "PCCardLabels.Life";
            this.PCCardLabels.Life.Size = new System.Drawing.Size(69, 20);
            this.PCCardLabels.Life.TabIndex = 16;
            this.PCCardLabels.Life.Text = "xxx:yyy";
            // 
            // PCCardLabels.Attack
            // 
            this.PCCardLabels.Attack.AutoSize = true;
            this.PCCardLabels.Attack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCCardLabels.Attack.ForeColor = System.Drawing.Color.Red;
            this.PCCardLabels.Attack.Location = new System.Drawing.Point(365, 433);
            this.PCCardLabels.Attack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PCCardLabels.Attack.Name = "PCCardLabels.Attack";
            this.PCCardLabels.Attack.Size = new System.Drawing.Size(36, 20);
            this.PCCardLabels.Attack.TabIndex = 17;
            this.PCCardLabels.Attack.Text = "xxx";
            // 
            // PCCardLabels.Defence
            // 
            this.PCCardLabels.Defence.AutoSize = true;
            this.PCCardLabels.Defence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCCardLabels.Defence.ForeColor = System.Drawing.Color.Cyan;
            this.PCCardLabels.Defence.Location = new System.Drawing.Point(365, 459);
            this.PCCardLabels.Defence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PCCardLabels.Defence.Name = "PCCardLabels.Defence";
            this.PCCardLabels.Defence.Size = new System.Drawing.Size(36, 20);
            this.PCCardLabels.Defence.TabIndex = 18;
            this.PCCardLabels.Defence.Text = "xxx";
            // 
            // PlayerCardLabels.SpecialAbility
            // 
            this.PlayerCardLabels.SpecialAbility.AutoSize = true;
            this.PlayerCardLabels.SpecialAbility.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCardLabels.SpecialAbility.ForeColor = System.Drawing.Color.Yellow;
            this.PlayerCardLabels.SpecialAbility.Location = new System.Drawing.Point(19, 479);
            this.PlayerCardLabels.SpecialAbility.Name = "PlayerCardLabels.SpecialAbility";
            this.PlayerCardLabels.SpecialAbility.Size = new System.Drawing.Size(0, 17);
            this.PlayerCardLabels.SpecialAbility.TabIndex = 19;
            // 
            // PCCardLabels.SpecialAbility
            // 
            this.PCCardLabels.SpecialAbility.AutoSize = true;
            this.PCCardLabels.SpecialAbility.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCCardLabels.SpecialAbility.ForeColor = System.Drawing.Color.Yellow;
            this.PCCardLabels.SpecialAbility.Location = new System.Drawing.Point(365, 479);
            this.PCCardLabels.SpecialAbility.Name = "PCCardLabels.SpecialAbility";
            this.PCCardLabels.SpecialAbility.Size = new System.Drawing.Size(0, 17);
            this.PCCardLabels.SpecialAbility.TabIndex = 20;
            // 
            // playerScoreTxtBox
            // 
            this.playerScoreTxtBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.playerScoreTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerScoreTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreTxtBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.playerScoreTxtBox.Location = new System.Drawing.Point(709, 15);
            this.playerScoreTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerScoreTxtBox.Name = "playerScoreTxtBox";
            this.playerScoreTxtBox.Size = new System.Drawing.Size(100, 20);
            this.playerScoreTxtBox.TabIndex = 21;
            this.playerScoreTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pcScoreTxtBox
            // 
            this.pcScoreTxtBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pcScoreTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pcScoreTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcScoreTxtBox.ForeColor = System.Drawing.Color.Red;
            this.pcScoreTxtBox.Location = new System.Drawing.Point(833, 15);
            this.pcScoreTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcScoreTxtBox.Name = "pcScoreTxtBox";
            this.pcScoreTxtBox.Size = new System.Drawing.Size(100, 20);
            this.pcScoreTxtBox.TabIndex = 22;
            this.pcScoreTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1397, 593);
            this.Controls.Add(this.pcScoreTxtBox);
            this.Controls.Add(this.playerScoreTxtBox);
            this.Controls.Add(this.PCCardLabels.SpecialAbility);
            this.Controls.Add(this.PlayerCardLabels.SpecialAbility);
            this.Controls.Add(this.PCCardLabels.Defence);
            this.Controls.Add(this.PCCardLabels.Attack);
            this.Controls.Add(this.PCCardLabels.Life);
            this.Controls.Add(this.PlayerCardLabels.Life);
            this.Controls.Add(this.PlayerCardLabels.Attack);
            this.Controls.Add(this.PlayerCardLabels.Defence);
            this.Controls.Add(this.pictureBoxOpponent);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.opponentLifeBar);
            this.Controls.Add(this.userLifeBar);
            this.Controls.Add(this.txtBoxWinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.opponentConsole);
            this.Controls.Add(this.playerConsole);
            this.Controls.Add(this.cmdStartGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameForm";
            this.Text = "Animals";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdStartGame;
        private System.Windows.Forms.TextBox playerConsole;
        private System.Windows.Forms.TextBox opponentConsole;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxWinner;
        private System.Windows.Forms.ProgressBar userLifeBar;
        private System.Windows.Forms.ProgressBar opponentLifeBar;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxOpponent;
        //private System.Windows.Forms.Label PlayerCardLabels.Defence;
        //private System.Windows.Forms.Label PlayerCardLabels.Attack;
        //private System.Windows.Forms.Label PlayerCardLabels.Life;
        //private System.Windows.Forms.Label PCCardLabels.Life;
        //private System.Windows.Forms.Label PCCardLabels.Attack;
        //private System.Windows.Forms.Label PCCardLabels.Defence;
        //private System.Windows.Forms.Label PlayerCardLabels.SpecialAbility;
        //private System.Windows.Forms.Label PCCardLabels.SpecialAbility;
        private CardLabels PlayerCardLabels;
        private CardLabels PCCardLabels;
        private System.Windows.Forms.TextBox playerScoreTxtBox;
        private System.Windows.Forms.TextBox pcScoreTxtBox;
    }
}

