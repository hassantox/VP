namespace VPPianoProject
{
    partial class mainMenu
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
            this.imageExit = new System.Windows.Forms.PictureBox();
            this.labelPlay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageExit)).BeginInit();
            this.SuspendLayout();
            // 
            // imageExit
            // 
            this.imageExit.BackColor = System.Drawing.Color.Black;
            this.imageExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageExit.Image = global::VPPianoProject.Properties.Resources._1386985357;
            this.imageExit.Location = new System.Drawing.Point(570, 391);
            this.imageExit.Name = "imageExit";
            this.imageExit.Size = new System.Drawing.Size(110, 87);
            this.imageExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageExit.TabIndex = 2;
            this.imageExit.TabStop = false;
            this.imageExit.Click += new System.EventHandler(this.imageExit_Click);
            // 
            // labelPlay
            // 
            this.labelPlay.AutoSize = true;
            this.labelPlay.BackColor = System.Drawing.Color.Transparent;
            this.labelPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPlay.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlay.ForeColor = System.Drawing.Color.LightGray;
            this.labelPlay.Location = new System.Drawing.Point(0, 9);
            this.labelPlay.Name = "labelPlay";
            this.labelPlay.Size = new System.Drawing.Size(231, 36);
            this.labelPlay.TabIndex = 2;
            this.labelPlay.Text = "Start Playing";
            this.labelPlay.Click += new System.EventHandler(this.labelPlay_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VPPianoProject.Properties.Resources.surprising_instrument;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 490);
            this.Controls.Add(this.imageExit);
            this.Controls.Add(this.labelPlay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "mainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Menu";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlay;
        private System.Windows.Forms.PictureBox imageExit;
    }
}

