using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Animals.UI
{
    partial class WinnerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
        /// <summary>
        /// Here the picture that indicates the winner appears.
        /// </summary>
        private PictureBox winnerPictureBox;
        /// <summary>
        /// Phrase said to the user when a winner is declared.
        /// </summary>
        private TextBox winnerTextBox;
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
            this.winnerPictureBox = new System.Windows.Forms.PictureBox();
            this.winnerTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // winnerPictureBox
            // 
            this.winnerPictureBox.Location = new System.Drawing.Point(12, 12);
            this.winnerPictureBox.Name = "winnerPictureBox";
            this.winnerPictureBox.Size = new System.Drawing.Size(458, 373);
            this.winnerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.winnerPictureBox.TabIndex = 0;
            this.winnerPictureBox.TabStop = false;
            this.winnerPictureBox.Click += new System.EventHandler(this.winnerPictureBox_Click);
            // 
            // winnerTextBox
            // 
            this.winnerTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.winnerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.winnerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerTextBox.Location = new System.Drawing.Point(12, 403);
            this.winnerTextBox.Multiline = true;
            this.winnerTextBox.Name = "winnerTextBox";
            this.winnerTextBox.Size = new System.Drawing.Size(458, 22);
            this.winnerTextBox.TabIndex = 1;
            // 
            // WinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.winnerTextBox);
            this.Controls.Add(this.winnerPictureBox);
            this.Name = "WinnerForm";
            this.Text = "Who\'s the winner?";
            ((System.ComponentModel.ISupportInitialize)(this.winnerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
    }
}