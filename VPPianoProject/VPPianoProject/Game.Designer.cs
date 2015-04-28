namespace VPPianoProject
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
            this.pianoContainer = new System.Windows.Forms.SplitContainer();
            this.keyMG1 = new System.Windows.Forms.Button();
            this.keyMA1 = new System.Windows.Forms.Button();
            this.keyMF1 = new System.Windows.Forms.Button();
            this.keyB1 = new System.Windows.Forms.Button();
            this.keyA1 = new System.Windows.Forms.Button();
            this.keyG1 = new System.Windows.Forms.Button();
            this.keyF1 = new System.Windows.Forms.Button();
            this.keyMD1 = new System.Windows.Forms.Button();
            this.keyE1 = new System.Windows.Forms.Button();
            this.keyC1M = new System.Windows.Forms.Button();
            this.keyD1 = new System.Windows.Forms.Button();
            this.keyC1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pianoContainer)).BeginInit();
            this.pianoContainer.Panel1.SuspendLayout();
            this.pianoContainer.Panel2.SuspendLayout();
            this.pianoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pianoContainer
            // 
            this.pianoContainer.BackColor = System.Drawing.Color.Transparent;
            this.pianoContainer.Location = new System.Drawing.Point(-1, 2);
            this.pianoContainer.Name = "pianoContainer";
            this.pianoContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // pianoContainer.Panel1
            // 
            this.pianoContainer.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.pianoContainer.Panel1.Controls.Add(this.pictureBox1);
            // 
            // pianoContainer.Panel2
            // 
            this.pianoContainer.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.pianoContainer.Panel2.Controls.Add(this.keyMG1);
            this.pianoContainer.Panel2.Controls.Add(this.keyMA1);
            this.pianoContainer.Panel2.Controls.Add(this.keyMF1);
            this.pianoContainer.Panel2.Controls.Add(this.keyB1);
            this.pianoContainer.Panel2.Controls.Add(this.keyA1);
            this.pianoContainer.Panel2.Controls.Add(this.keyG1);
            this.pianoContainer.Panel2.Controls.Add(this.keyF1);
            this.pianoContainer.Panel2.Controls.Add(this.keyMD1);
            this.pianoContainer.Panel2.Controls.Add(this.keyE1);
            this.pianoContainer.Panel2.Controls.Add(this.keyC1M);
            this.pianoContainer.Panel2.Controls.Add(this.keyD1);
            this.pianoContainer.Panel2.Controls.Add(this.keyC1);
            this.pianoContainer.Size = new System.Drawing.Size(853, 377);
            this.pianoContainer.SplitterDistance = 162;
            this.pianoContainer.TabIndex = 1;
            // 
            // keyMG1
            // 
            this.keyMG1.BackColor = System.Drawing.Color.Black;
            this.keyMG1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyMG1.Location = new System.Drawing.Point(189, 3);
            this.keyMG1.Name = "keyMG1";
            this.keyMG1.Size = new System.Drawing.Size(37, 144);
            this.keyMG1.TabIndex = 23;
            this.keyMG1.UseVisualStyleBackColor = false;
            this.keyMG1.Click += new System.EventHandler(this.keyMG1_Click);
            // 
            // keyMA1
            // 
            this.keyMA1.BackColor = System.Drawing.Color.Black;
            this.keyMA1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyMA1.Location = new System.Drawing.Point(232, 3);
            this.keyMA1.Name = "keyMA1";
            this.keyMA1.Size = new System.Drawing.Size(37, 144);
            this.keyMA1.TabIndex = 22;
            this.keyMA1.UseVisualStyleBackColor = false;
            this.keyMA1.Click += new System.EventHandler(this.keyMA1_Click);
            // 
            // keyMF1
            // 
            this.keyMF1.BackColor = System.Drawing.Color.Black;
            this.keyMF1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyMF1.Location = new System.Drawing.Point(146, 3);
            this.keyMF1.Name = "keyMF1";
            this.keyMF1.Size = new System.Drawing.Size(37, 144);
            this.keyMF1.TabIndex = 21;
            this.keyMF1.UseVisualStyleBackColor = false;
            this.keyMF1.Click += new System.EventHandler(this.keyMF1_Click);
            // 
            // keyB1
            // 
            this.keyB1.BackColor = System.Drawing.Color.White;
            this.keyB1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyB1.Location = new System.Drawing.Point(249, 3);
            this.keyB1.Name = "keyB1";
            this.keyB1.Size = new System.Drawing.Size(45, 207);
            this.keyB1.TabIndex = 20;
            this.keyB1.UseVisualStyleBackColor = false;
            this.keyB1.Click += new System.EventHandler(this.keyB1_Click);
            // 
            // keyA1
            // 
            this.keyA1.BackColor = System.Drawing.Color.White;
            this.keyA1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyA1.Location = new System.Drawing.Point(207, 3);
            this.keyA1.Name = "keyA1";
            this.keyA1.Size = new System.Drawing.Size(45, 207);
            this.keyA1.TabIndex = 19;
            this.keyA1.UseVisualStyleBackColor = false;
            this.keyA1.Click += new System.EventHandler(this.keyA1_Click);
            // 
            // keyG1
            // 
            this.keyG1.BackColor = System.Drawing.Color.White;
            this.keyG1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyG1.Location = new System.Drawing.Point(165, 3);
            this.keyG1.Name = "keyG1";
            this.keyG1.Size = new System.Drawing.Size(45, 207);
            this.keyG1.TabIndex = 18;
            this.keyG1.UseVisualStyleBackColor = false;
            this.keyG1.Click += new System.EventHandler(this.keyG1_Click);
            // 
            // keyF1
            // 
            this.keyF1.BackColor = System.Drawing.Color.White;
            this.keyF1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyF1.Location = new System.Drawing.Point(123, 3);
            this.keyF1.Name = "keyF1";
            this.keyF1.Size = new System.Drawing.Size(45, 207);
            this.keyF1.TabIndex = 17;
            this.keyF1.UseVisualStyleBackColor = false;
            this.keyF1.Click += new System.EventHandler(this.keyF1_Click);
            // 
            // keyMD1
            // 
            this.keyMD1.BackColor = System.Drawing.Color.Black;
            this.keyMD1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyMD1.Location = new System.Drawing.Point(65, 3);
            this.keyMD1.Name = "keyMD1";
            this.keyMD1.Size = new System.Drawing.Size(37, 144);
            this.keyMD1.TabIndex = 16;
            this.keyMD1.UseVisualStyleBackColor = false;
            this.keyMD1.Click += new System.EventHandler(this.keyMD1_Click);
            // 
            // keyE1
            // 
            this.keyE1.BackColor = System.Drawing.Color.White;
            this.keyE1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyE1.Location = new System.Drawing.Point(81, 3);
            this.keyE1.Name = "keyE1";
            this.keyE1.Size = new System.Drawing.Size(45, 207);
            this.keyE1.TabIndex = 15;
            this.keyE1.UseVisualStyleBackColor = false;
            this.keyE1.Click += new System.EventHandler(this.keyE1_Click);
            // 
            // keyC1M
            // 
            this.keyC1M.BackColor = System.Drawing.Color.Black;
            this.keyC1M.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyC1M.Location = new System.Drawing.Point(22, 3);
            this.keyC1M.Name = "keyC1M";
            this.keyC1M.Size = new System.Drawing.Size(37, 144);
            this.keyC1M.TabIndex = 12;
            this.keyC1M.UseVisualStyleBackColor = false;
            this.keyC1M.Click += new System.EventHandler(this.keyC1M_Click);
            // 
            // keyD1
            // 
            this.keyD1.BackColor = System.Drawing.Color.White;
            this.keyD1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyD1.Location = new System.Drawing.Point(39, 3);
            this.keyD1.Name = "keyD1";
            this.keyD1.Size = new System.Drawing.Size(45, 207);
            this.keyD1.TabIndex = 14;
            this.keyD1.UseVisualStyleBackColor = false;
            this.keyD1.Click += new System.EventHandler(this.keyD1_Click);
            // 
            // keyC1
            // 
            this.keyC1.BackColor = System.Drawing.Color.White;
            this.keyC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.keyC1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyC1.Location = new System.Drawing.Point(0, 3);
            this.keyC1.Name = "keyC1";
            this.keyC1.Size = new System.Drawing.Size(45, 207);
            this.keyC1.TabIndex = 13;
            this.keyC1.UseVisualStyleBackColor = false;
            this.keyC1.Click += new System.EventHandler(this.keyC1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VPPianoProject.Properties.Resources._28FC9B29B84846FAB3127A4E46A95B48_12073_d0d66fe5085f4bda772bafe49a07f500;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 379);
            this.Controls.Add(this.pianoContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.pianoContainer.Panel1.ResumeLayout(false);
            this.pianoContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pianoContainer)).EndInit();
            this.pianoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer pianoContainer;
        private System.Windows.Forms.Button keyMG1;
        private System.Windows.Forms.Button keyMA1;
        private System.Windows.Forms.Button keyMF1;
        private System.Windows.Forms.Button keyB1;
        private System.Windows.Forms.Button keyA1;
        private System.Windows.Forms.Button keyG1;
        private System.Windows.Forms.Button keyF1;
        private System.Windows.Forms.Button keyMD1;
        private System.Windows.Forms.Button keyE1;
        private System.Windows.Forms.Button keyC1M;
        private System.Windows.Forms.Button keyD1;
        private System.Windows.Forms.Button keyC1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}