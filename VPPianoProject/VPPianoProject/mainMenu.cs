using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace VPPianoProject
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        Game gameObj = new Game();
        SoundPlayer key = new SoundPlayer(@"C:\Windows\Media\Ding.wav");

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            gameObj.Show();
            
            key.Play();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            gameObj.Show();
        }

        private void imageExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
