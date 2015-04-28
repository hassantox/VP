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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        SoundPlayer keySound = new SoundPlayer();      

        private void keyC1_Click(object sender, EventArgs e)
        {
            keySound.SoundLocation = (@"C:\Users\Hassan\Documents\GitHub\VP\VPPianoProject\VPPianoProject\Resources\C25Start.wav");
            keySound.Play();
        }

        private void keyC1M_Click(object sender, EventArgs e)
        {
            keySound.SoundLocation = (@"C:\Users\Hassan\Documents\GitHub\VP\VPPianoProject\VPPianoProject\Resources\c#26.wav");
            keySound.Play();
        }

        private void keyD1_Click(object sender, EventArgs e)
        {
            keySound.SoundLocation = (@"C:\Users\Hassan\Documents\GitHub\VP\VPPianoProject\VPPianoProject\Resources\D27.wav");
            keySound.Play();
        }

        private void keyMD1_Click(object sender, EventArgs e)
        {
            keySound.SoundLocation = (@"C:\Users\Hassan\Documents\GitHub\VP\VPPianoProject\VPPianoProject\Resources\d#28.wav");
            keySound.Play();
        }

        private void keyE1_Click(object sender, EventArgs e)
        {
            keySound.SoundLocation = (@"C:\Users\Hassan\Documents\GitHub\VP\VPPianoProject\VPPianoProject\Resources\E29.wav");
            keySound.Play();
        }

        private void keyF1_Click(object sender, EventArgs e)
        {
            keySound.SoundLocation = (@"C:\Users\Hassan\Documents\GitHub\VP\VPPianoProject\VPPianoProject\Resources\F30.wav");
            keySound.Play();
        }

        private void keyMF1_Click(object sender, EventArgs e)
        {

        }

        private void keyG1_Click(object sender, EventArgs e)
        {

        }

        private void keyMG1_Click(object sender, EventArgs e)
        {

        }

        private void keyA1_Click(object sender, EventArgs e)
        {

        }

        private void keyMA1_Click(object sender, EventArgs e)
        {

        }

        private void keyB1_Click(object sender, EventArgs e)
        {
            //change this one
            keySound.SoundLocation = (@"C:\Users\Hassan\Documents\GitHub\VP\VPPianoProject\VPPianoProject\Resources\a#47.wav");
            keySound.Play();
        }

    }
}
