namespace Animals.UI
{
    partial class PickHeroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickHeroForm));
            this.firstHeroPictureBox = new System.Windows.Forms.PictureBox();
            this.secondHeroPictureBox = new System.Windows.Forms.PictureBox();
            this.thirdHeroPictureBox = new System.Windows.Forms.PictureBox();
            this.fourthHeroPictureBox = new System.Windows.Forms.PictureBox();
            this.fifthHeroPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.firstHeroPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondHeroPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdHeroPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthHeroPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthHeroPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // firstHeroPictureBox
            // 
            this.firstHeroPictureBox.Location = new System.Drawing.Point(12, 12);
            this.firstHeroPictureBox.Name = "firstHeroPictureBox";
            this.firstHeroPictureBox.Size = new System.Drawing.Size(303, 379);
            this.firstHeroPictureBox.TabIndex = 0;
            this.firstHeroPictureBox.TabStop = false;
            this.firstHeroPictureBox.Click += new System.EventHandler(this.firstHeroPictureBox_Click);
            // 
            // secondHeroPictureBox
            // 
            this.secondHeroPictureBox.Location = new System.Drawing.Point(321, 12);
            this.secondHeroPictureBox.Name = "secondHeroPictureBox";
            this.secondHeroPictureBox.Size = new System.Drawing.Size(303, 379);
            this.secondHeroPictureBox.TabIndex = 1;
            this.secondHeroPictureBox.TabStop = false;
            this.secondHeroPictureBox.Click += new System.EventHandler(this.secondHeroPictureBox_Click);
            // 
            // thirdHeroPictureBox
            // 
            this.thirdHeroPictureBox.Location = new System.Drawing.Point(630, 12);
            this.thirdHeroPictureBox.Name = "thirdHeroPictureBox";
            this.thirdHeroPictureBox.Size = new System.Drawing.Size(303, 379);
            this.thirdHeroPictureBox.TabIndex = 2;
            this.thirdHeroPictureBox.TabStop = false;
            this.thirdHeroPictureBox.Click += new System.EventHandler(this.thirdHeroPictureBox_Click);
            // 
            // fourthHeroPictureBox
            // 
            this.fourthHeroPictureBox.Location = new System.Drawing.Point(939, 12);
            this.fourthHeroPictureBox.Name = "fourthHeroPictureBox";
            this.fourthHeroPictureBox.Size = new System.Drawing.Size(303, 379);
            this.fourthHeroPictureBox.TabIndex = 3;
            this.fourthHeroPictureBox.TabStop = false;
            this.fourthHeroPictureBox.Click += new System.EventHandler(this.fourthHeroPictureBox_Click);
            // 
            // fifthHeroPictureBox
            // 
            this.fifthHeroPictureBox.Location = new System.Drawing.Point(1248, 12);
            this.fifthHeroPictureBox.Name = "fifthHeroPictureBox";
            this.fifthHeroPictureBox.Size = new System.Drawing.Size(303, 379);
            this.fifthHeroPictureBox.TabIndex = 4;
            this.fifthHeroPictureBox.TabStop = false;
            this.fifthHeroPictureBox.Click += new System.EventHandler(this.fifthHeroPictureBox_Click);
            // 
            // PickHeroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 402);
            this.Controls.Add(this.fifthHeroPictureBox);
            this.Controls.Add(this.fourthHeroPictureBox);
            this.Controls.Add(this.thirdHeroPictureBox);
            this.Controls.Add(this.secondHeroPictureBox);
            this.Controls.Add(this.firstHeroPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PickHeroForm";
            this.Text = "PickHero";
            ((System.ComponentModel.ISupportInitialize)(this.firstHeroPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondHeroPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdHeroPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthHeroPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthHeroPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox firstHeroPictureBox;
        private System.Windows.Forms.PictureBox secondHeroPictureBox;
        private System.Windows.Forms.PictureBox thirdHeroPictureBox;
        private System.Windows.Forms.PictureBox fourthHeroPictureBox;
        private System.Windows.Forms.PictureBox fifthHeroPictureBox;
    }
}