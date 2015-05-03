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

//       ++++++++++++++++++++++++++++++++++++  Sound for each Key on Piano ++++++++++++++++++++++++++++++++++++++

        private void keyC1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.c1);           
            keySound.Play();
        }

        private void keyC1M_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.c_2);
            keySound.Play();
        }

        private void keyD1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.d3);
            keySound.Play();
        }

        private void keyMD1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.d_4);
            keySound.Play();
        }

        private void keyE1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.e5);
            keySound.Play();
        }

        private void keyF1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.f6);
            keySound.Play();
        }

        private void keyMF1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.f_7);
            keySound.Play();
        }

        private void keyG1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.g8);
            keySound.Play();
        }

        private void keyMG1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.g_9);
            keySound.Play();
        }

        private void keyA1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.a10);
            keySound.Play();
        }

        private void keyMA1_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.a_11);
            keySound.Play();
        }

        private void keyB1_Click(object sender, EventArgs e)
        {

            SoundPlayer keySound = new SoundPlayer(Notes.b12);
            keySound.Play();
        }

        //              SECOND OCTAVE
        //CHANGE
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

        //              THIRD OCTAVE

        private void keyC3_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyMC3_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyD3_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyMD3_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyE3_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyF3_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyMF3_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyG3_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyMG3_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyA3_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyMA3_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyB3_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        //          FOURTH OCTAVE

        private void keyC4_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyMC4_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyD4_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyMD4_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyE4_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyF4_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyMF4_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyG4_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyMG4_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyA4_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyMA4_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyB4_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        //          FIFTH OCTAVE

        private void keyC5_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyMC5_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyD5_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyMD5_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyE5_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyF5_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyMF5_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyG5_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyMG5_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyA5_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyMA5_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyB5_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

        private void keyC6Last_Click(object sender, EventArgs e)
        {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
        }

//            +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

//            -------------------------- KEYBOARD CONROLS ---------------------------------------

        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D1)
            {
                keyC1.PerformClick();
            }
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
