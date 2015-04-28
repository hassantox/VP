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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Options = new System.Windows.Forms.Panel();
            this.labelPlay = new System.Windows.Forms.Label();
            this.imageExit = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageExit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.Color.Transparent;
            this.Options.Controls.Add(this.imageExit);
            this.Options.Controls.Add(this.labelPlay);
            this.Options.Location = new System.Drawing.Point(156, 101);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(317, 303);
            this.Options.TabIndex = 1;
            // 
            // labelPlay
            // 
            this.labelPlay.AutoSize = true;
            this.labelPlay.BackColor = System.Drawing.Color.Transparent;
            this.labelPlay.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlay.ForeColor = System.Drawing.Color.LightGray;
            this.labelPlay.Location = new System.Drawing.Point(30, 51);
            this.labelPlay.Name = "labelPlay";
            this.labelPlay.Size = new System.Drawing.Size(108, 36);
            this.labelPlay.TabIndex = 2;
            this.labelPlay.Text = "PLAY";
            this.labelPlay.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageExit
            // 
            this.imageExit.BackColor = System.Drawing.Color.Black;
            this.imageExit.Image = global::VPPianoProject.Properties.Resources._1386985357;
            this.imageExit.Location = new System.Drawing.Point(211, 218);
            this.imageExit.Name = "imageExit";
            this.imageExit.Size = new System.Drawing.Size(110, 87);
            this.imageExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageExit.TabIndex = 2;
            this.imageExit.TabStop = false;
            this.imageExit.Click += new System.EventHandler(this.imageExit_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VPPianoProject.Properties.Resources.Chapter_6_007_piano_puzzle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 403);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "mainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piano";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel Options;
        private System.Windows.Forms.Label labelPlay;
        private System.Windows.Forms.PictureBox imageExit;
    }
}

