namespace Animals.UI.Forms
{
    partial class PickAdvantageForm
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
            this.advantagesListBox = new System.Windows.Forms.ListBox();
            this.pickAdvantage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // advantagesListBox
            // 
            this.advantagesListBox.FormattingEnabled = true;
            this.advantagesListBox.ItemHeight = 16;
            this.advantagesListBox.Location = new System.Drawing.Point(12, 12);
            this.advantagesListBox.Name = "advantagesListBox";
            this.advantagesListBox.Size = new System.Drawing.Size(1300, 276);
            this.advantagesListBox.TabIndex = 0;
            // 
            // pickAdvantage
            // 
            this.pickAdvantage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickAdvantage.Location = new System.Drawing.Point(321, 294);
            this.pickAdvantage.Name = "pickAdvantage";
            this.pickAdvantage.Size = new System.Drawing.Size(700, 30);
            this.pickAdvantage.TabIndex = 1;
            this.pickAdvantage.Text = "Pick";
            this.pickAdvantage.UseVisualStyleBackColor = true;
            this.pickAdvantage.Click += new System.EventHandler(this.pickAdvantage_Click);
            // 
            // PickAdvantageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 337);
            this.Controls.Add(this.pickAdvantage);
            this.Controls.Add(this.advantagesListBox);
            this.Name = "PickAdvantageForm";
            this.Text = "Pick Advantage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox advantagesListBox;
        private System.Windows.Forms.Button pickAdvantage;
    }
}