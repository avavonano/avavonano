﻿using System;

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
            this.labelDefensePlayer = new System.Windows.Forms.Label();
            this.labelAttackPlayer = new System.Windows.Forms.Label();
            this.labelLifePlayer = new System.Windows.Forms.Label();
            this.labelLifeComputer = new System.Windows.Forms.Label();
            this.labelAttackComputer = new System.Windows.Forms.Label();
            this.labelDefenceComputer = new System.Windows.Forms.Label();
            this.labelUserSpecialAbilities = new System.Windows.Forms.Label();
            this.labelPCSpecialAbilities = new System.Windows.Forms.Label();
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
            this.cmdStartGame.Location = new System.Drawing.Point(879, 428);
            this.cmdStartGame.Name = "cmdStartGame";
            this.cmdStartGame.Size = new System.Drawing.Size(157, 33);
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
            this.playerConsole.Location = new System.Drawing.Point(532, 38);
            this.playerConsole.Multiline = true;
            this.playerConsole.Name = "playerConsole";
            this.playerConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.playerConsole.Size = new System.Drawing.Size(504, 166);
            this.playerConsole.TabIndex = 1;
            // 
            // opponentConsole
            // 
            this.opponentConsole.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.opponentConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentConsole.ForeColor = System.Drawing.Color.Red;
            this.opponentConsole.Location = new System.Drawing.Point(532, 220);
            this.opponentConsole.Multiline = true;
            this.opponentConsole.Name = "opponentConsole";
            this.opponentConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.opponentConsole.Size = new System.Drawing.Size(504, 166);
            this.opponentConsole.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(122, 438);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(201, 19);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Text = "Symeon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name:";
            // 
            // txtRound
            // 
            this.txtRound.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRound.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRound.ForeColor = System.Drawing.Color.Transparent;
            this.txtRound.Location = new System.Drawing.Point(936, 3);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(99, 19);
            this.txtRound.TabIndex = 5;
            this.txtRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(844, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Round:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(528, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Winner:";
            // 
            // txtBoxWinner
            // 
            this.txtBoxWinner.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxWinner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtBoxWinner.Location = new System.Drawing.Point(625, 410);
            this.txtBoxWinner.Name = "txtBoxWinner";
            this.txtBoxWinner.Size = new System.Drawing.Size(99, 19);
            this.txtBoxWinner.TabIndex = 8;
            // 
            // userLifeBar
            // 
            this.userLifeBar.Location = new System.Drawing.Point(16, 326);
            this.userLifeBar.Name = "userLifeBar";
            this.userLifeBar.Size = new System.Drawing.Size(227, 23);
            this.userLifeBar.TabIndex = 9;
            // 
            // opponentLifeBar
            // 
            this.opponentLifeBar.Location = new System.Drawing.Point(277, 326);
            this.opponentLifeBar.Name = "opponentLifeBar";
            this.opponentLifeBar.Size = new System.Drawing.Size(227, 23);
            this.opponentLifeBar.TabIndex = 10;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Location = new System.Drawing.Point(16, 12);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(227, 308);
            this.pictureBoxPlayer.TabIndex = 11;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // pictureBoxOpponent
            // 
            this.pictureBoxOpponent.Location = new System.Drawing.Point(277, 12);
            this.pictureBoxOpponent.Name = "pictureBoxOpponent";
            this.pictureBoxOpponent.Size = new System.Drawing.Size(227, 308);
            this.pictureBoxOpponent.TabIndex = 12;
            this.pictureBoxOpponent.TabStop = false;
            // 
            // labelDefensePlayer
            // 
            this.labelDefensePlayer.AutoSize = true;
            this.labelDefensePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefensePlayer.ForeColor = System.Drawing.Color.Cyan;
            this.labelDefensePlayer.Location = new System.Drawing.Point(13, 373);
            this.labelDefensePlayer.Name = "labelDefensePlayer";
            this.labelDefensePlayer.Size = new System.Drawing.Size(29, 16);
            this.labelDefensePlayer.TabIndex = 13;
            this.labelDefensePlayer.Text = "xxx";
            // 
            // labelAttackPlayer
            // 
            this.labelAttackPlayer.AutoSize = true;
            this.labelAttackPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttackPlayer.ForeColor = System.Drawing.Color.Red;
            this.labelAttackPlayer.Location = new System.Drawing.Point(13, 352);
            this.labelAttackPlayer.Name = "labelAttackPlayer";
            this.labelAttackPlayer.Size = new System.Drawing.Size(29, 16);
            this.labelAttackPlayer.TabIndex = 14;
            this.labelAttackPlayer.Text = "xxx";
            // 
            // labelLifePlayer
            // 
            this.labelLifePlayer.AutoSize = true;
            this.labelLifePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLifePlayer.ForeColor = System.Drawing.Color.Lime;
            this.labelLifePlayer.Location = new System.Drawing.Point(191, 352);
            this.labelLifePlayer.Name = "labelLifePlayer";
            this.labelLifePlayer.Size = new System.Drawing.Size(57, 16);
            this.labelLifePlayer.TabIndex = 15;
            this.labelLifePlayer.Text = "xxx:yyy";
            // 
            // labelLifeComputer
            // 
            this.labelLifeComputer.AutoSize = true;
            this.labelLifeComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLifeComputer.ForeColor = System.Drawing.Color.Lime;
            this.labelLifeComputer.Location = new System.Drawing.Point(452, 352);
            this.labelLifeComputer.Name = "labelLifeComputer";
            this.labelLifeComputer.Size = new System.Drawing.Size(57, 16);
            this.labelLifeComputer.TabIndex = 16;
            this.labelLifeComputer.Text = "xxx:yyy";
            // 
            // labelAttackComputer
            // 
            this.labelAttackComputer.AutoSize = true;
            this.labelAttackComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttackComputer.ForeColor = System.Drawing.Color.Red;
            this.labelAttackComputer.Location = new System.Drawing.Point(274, 352);
            this.labelAttackComputer.Name = "labelAttackComputer";
            this.labelAttackComputer.Size = new System.Drawing.Size(29, 16);
            this.labelAttackComputer.TabIndex = 17;
            this.labelAttackComputer.Text = "xxx";
            // 
            // labelDefenceComputer
            // 
            this.labelDefenceComputer.AutoSize = true;
            this.labelDefenceComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefenceComputer.ForeColor = System.Drawing.Color.Cyan;
            this.labelDefenceComputer.Location = new System.Drawing.Point(274, 373);
            this.labelDefenceComputer.Name = "labelDefenceComputer";
            this.labelDefenceComputer.Size = new System.Drawing.Size(29, 16);
            this.labelDefenceComputer.TabIndex = 18;
            this.labelDefenceComputer.Text = "xxx";
            // 
            // labelUserSpecialAbilities
            // 
            this.labelUserSpecialAbilities.AutoSize = true;
            this.labelUserSpecialAbilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserSpecialAbilities.ForeColor = System.Drawing.Color.Yellow;
            this.labelUserSpecialAbilities.Location = new System.Drawing.Point(14, 389);
            this.labelUserSpecialAbilities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserSpecialAbilities.Name = "labelUserSpecialAbilities";
            this.labelUserSpecialAbilities.Size = new System.Drawing.Size(0, 13);
            this.labelUserSpecialAbilities.TabIndex = 19;
            // 
            // labelPCSpecialAbilities
            // 
            this.labelPCSpecialAbilities.AutoSize = true;
            this.labelPCSpecialAbilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPCSpecialAbilities.ForeColor = System.Drawing.Color.Yellow;
            this.labelPCSpecialAbilities.Location = new System.Drawing.Point(274, 389);
            this.labelPCSpecialAbilities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPCSpecialAbilities.Name = "labelPCSpecialAbilities";
            this.labelPCSpecialAbilities.Size = new System.Drawing.Size(0, 13);
            this.labelPCSpecialAbilities.TabIndex = 20;
            // 
            // playerScoreTxtBox
            // 
            this.playerScoreTxtBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.playerScoreTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerScoreTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreTxtBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.playerScoreTxtBox.Location = new System.Drawing.Point(532, 12);
            this.playerScoreTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playerScoreTxtBox.Name = "playerScoreTxtBox";
            this.playerScoreTxtBox.Size = new System.Drawing.Size(75, 16);
            this.playerScoreTxtBox.TabIndex = 21;
            this.playerScoreTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pcScoreTxtBox
            // 
            this.pcScoreTxtBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pcScoreTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pcScoreTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcScoreTxtBox.ForeColor = System.Drawing.Color.Red;
            this.pcScoreTxtBox.Location = new System.Drawing.Point(625, 12);
            this.pcScoreTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcScoreTxtBox.Name = "pcScoreTxtBox";
            this.pcScoreTxtBox.Size = new System.Drawing.Size(75, 16);
            this.pcScoreTxtBox.TabIndex = 22;
            this.pcScoreTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1048, 482);
            this.Controls.Add(this.pcScoreTxtBox);
            this.Controls.Add(this.playerScoreTxtBox);
            this.Controls.Add(this.labelPCSpecialAbilities);
            this.Controls.Add(this.labelUserSpecialAbilities);
            this.Controls.Add(this.labelDefenceComputer);
            this.Controls.Add(this.labelAttackComputer);
            this.Controls.Add(this.labelLifeComputer);
            this.Controls.Add(this.labelLifePlayer);
            this.Controls.Add(this.labelAttackPlayer);
            this.Controls.Add(this.labelDefensePlayer);
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
        private System.Windows.Forms.Label labelDefensePlayer;
        private System.Windows.Forms.Label labelAttackPlayer;
        private System.Windows.Forms.Label labelLifePlayer;
        private System.Windows.Forms.Label labelLifeComputer;
        private System.Windows.Forms.Label labelAttackComputer;
        private System.Windows.Forms.Label labelDefenceComputer;
        private System.Windows.Forms.Label labelUserSpecialAbilities;
        private System.Windows.Forms.Label labelPCSpecialAbilities;
        private System.Windows.Forms.TextBox playerScoreTxtBox;
        private System.Windows.Forms.TextBox pcScoreTxtBox;
    }
}

