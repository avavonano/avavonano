namespace Animals.UI.Forms
{
    partial class WarningForm
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
            this.warningTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // warningTxtBox
            // 
            this.warningTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.warningTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningTxtBox.ForeColor = System.Drawing.Color.Red;
            this.warningTxtBox.Location = new System.Drawing.Point(12, 12);
            this.warningTxtBox.Multiline = true;
            this.warningTxtBox.Name = "warningTxtBox";
            this.warningTxtBox.Size = new System.Drawing.Size(337, 229);
            this.warningTxtBox.TabIndex = 0;
            // 
            // WarningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 253);
            this.Controls.Add(this.warningTxtBox);
            this.Name = "WarningForm";
            this.Text = "Warning!!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox warningTxtBox;
    }
}