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

        //SoundPlayer keySound = new SoundPlayer();   

        private void keyC1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.C25Start);           
            keySound.Play();
        }

        private void keyC1M_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.c_26);
            keySound.Play();
        }

        private void keyD1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.D27);
            keySound.Play();
        }

        private void keyMD1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.d_28);
            keySound.Play();
        }

        private void keyE1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.E29);
            keySound.Play();
        }

        private void keyF1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.F30);
            keySound.Play();
        }

        private void keyMF1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.f_31);
            keySound.Play();
        }

        private void keyG1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.G32);
            keySound.Play();
        }

        private void keyMG1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.g_33);
            keySound.Play();
        }

        private void keyA1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.A34);
            keySound.Play();
        }

        private void keyMA1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.a_35);
            keySound.Play();
        }

        private void keyB1_Click(object sender, EventArgs e)
        {

            SoundPlayer keySound = new SoundPlayer(Notes.b36);
            keySound.Play();
        }

        private void keyC2_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.c37);
            keySound.Play();
        }

        private void keyMC2_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.c_38);
            keySound.Play();
        }

        private void keyD2_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.d39);
            keySound.Play();
        }

        private void keyMD2_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.d_40);
            keySound.Play();
        }

        private void keyE2_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.e41);
            keySound.Play();
        }

        private void keyF2_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.f42);
            keySound.Play();
        }

        private void keyMF2_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.f_43);
            keySound.Play();
        }

        private void keyG2_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.g44);
            keySound.Play();
        }

        private void keyMG2_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.g_45);
            keySound.Play();
        }

        private void keyA2_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.a46);
            keySound.Play();
        }

        private void keyMA2_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.a_47);
            keySound.Play();
        }

        private void keyB2_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }


        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

      
       



    }
}
