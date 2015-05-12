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
            assistC1.Visible = false;
            assistMC1.Visible = false;
            assistD1.Visible = false;
            assistMD1.Visible = false;
            assistE1.Visible = false;
            
            assistF1.Visible = false;
            assistMF1.Visible = false;
            assistG1.Visible = false;
            assistMG1.Visible = false;
            assistA1.Visible = false;
            assistMA1.Visible = false;
            assistB1.Visible = false;

            assistC2.Visible = false;
            assistMC2.Visible = false;
            assistD2.Visible = false;
            assistMD2.Visible = false;
            assistE2.Visible = false;

            assistF2.Visible = false;
            assistMF2.Visible = false;
            assistG2.Visible = false;
            assistMG2.Visible = false;
            assistA2.Visible = false;
            assistMA2.Visible = false;
            assistB2.Visible = false;

            assistC3.Visible = false;
            assistMC3.Visible = false;
            assistD3.Visible = false;
            assistMD3.Visible = false;
            assistE3.Visible = false;

            assistF3.Visible = false;
            assistMF3.Visible = false;
            assistG3.Visible = false;
            assistMG3.Visible = false;
            assistA3.Visible = false;
            assistMA3.Visible = false;
            assistB3.Visible = false;

            
            assistC4.Visible = false;
            assistMC4.Visible = false;
            assistD4.Visible = false;
            assistMD4.Visible = false;
            assistE4.Visible = false;
            
            assistF4.Visible = false;
            assistMF4.Visible = false;
            assistG4.Visible = false;
            assistMG4.Visible = false;
            assistA4.Visible = false;
            assistMA4.Visible = false;
            assistB4.Visible = false;

            assistC5.Visible = false;
            assistMC5.Visible = false;
            assistD5.Visible = false;
            assistMD5.Visible = false;
            assistE5.Visible = false;

            assistF5.Visible = false;
            assistMF5.Visible = false;
            assistG5.Visible = false;
            assistMG5.Visible = false;
            assistA5.Visible = false;
            assistMA5.Visible = false;
            assistB5.Visible = false;

            assistC6.Visible = false;
            
        }

        //SoundPlayer keySound = new SoundPlayer();   
        
        
//       ++++++++++++++++++++++++++++++++++++  Sound for each Key on Piano ++++++++++++++++++++++++++++++++++++++

        private void keyC1_Click(object sender, EventArgs e)
        {
            if (notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.c1);           
            keySound.Play();      
            }

            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_C1_1_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o1);
                keySound.Play();
            }
        }

        private void keyC1M_Click(object sender, EventArgs e)
        {
            if (notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.c_2);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_C1_1_mezzo_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o2);
                keySound.Play();
            }
        }

        private void keyD1_Click(object sender, EventArgs e)
        {
            if (notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.d3);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_D1_1_fortissimo_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o3);
                keySound.Play();
            }
        }

        private void keyMD1_Click(object sender, EventArgs e)
        {
            if (notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.d_4);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_D1_1_mezzo_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o4);
                keySound.Play();
            }
        }

        private void keyE1_Click(object sender, EventArgs e)
        {
            if (notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.e5);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_E1_1_fortissimo_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o5);
                keySound.Play();
            }
        }

        private void keyF1_Click(object sender, EventArgs e)
        {
            if (notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.f6);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_F1_1_fortissimo_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o6);
                keySound.Play();
            }
        }

        private void keyMF1_Click(object sender, EventArgs e)
        {
            if (notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.f_7);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_F1_15_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o7);
                keySound.Play();
            }
        }

        private void keyG1_Click(object sender, EventArgs e)
        {
            if (notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.g8);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_G1_1_fortissimo_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o8);
                keySound.Play();
            }
        }

        private void keyMG1_Click(object sender, EventArgs e)
        {
            if (notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.g_9);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_G1_15_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o9);
                keySound.Play();
            }
        }

        private void keyA1_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.a10);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_A1_1_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o10);
                keySound.Play();
            }
        }

        private void keyMA1_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.a_11);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_A1_1_mezzo_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o11);
                keySound.Play();
            }
        }

        private void keyB1_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.b12);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_B1_1_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o12);
                keySound.Play();
            }
        }

        //              SECOND OCTAVE
        
        private void keyC2_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.c13);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_C2_1_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o13);
                keySound.Play();
            }
        }

        private void keyMC2_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.c_14);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_C2_05_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o14);
                keySound.Play();
            }
        }

        private void keyD2_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.d15);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_D2_1_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o15);
                keySound.Play();
            }
        }

        private void keyMD2_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.d_16);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_D2_05_fortissimo_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o16);
                keySound.Play();
            }
        }

        private void keyE2_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.e17);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_E2_1_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o17);
                keySound.Play();
            }
        }

        private void keyF2_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.f18);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_F2_1_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o18);
                keySound.Play();
            }
        }

        private void keyMF2_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.f_19);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_F2_15_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o19);
                keySound.Play();
            }
        }

        private void keyG2_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.g20);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_G2_1_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o20);
                keySound.Play();
            }
        }

        private void keyMG2_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.g_21);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_G2_1_mezzo_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o21);
                keySound.Play();
            }
        }

        private void keyA2_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.a22);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_A2_1_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o22);
                keySound.Play();
            }
        }

        private void keyMA2_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.a_23);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_A2_1_fortissimo_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o23);
                keySound.Play();
            }
        }

        private void keyB2_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.b24);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_B2_1_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o24);
                keySound.Play();
            }
        }

        //              THIRD OCTAVE

        private void keyC3_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.C25Start);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_C3_1_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o25);
                keySound.Play();
            }
        }

        private void keyMC3_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.c_26);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_C3_1_mezzo_piano_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o26);
                keySound.Play();
            }
        }

        private void keyD3_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.D27);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_D3_1_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o27);
                keySound.Play();
            }
        }

        private void keyMD3_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.d_28);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_D3_1_fortissimo_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o28);
                keySound.Play();
            }
        }

        private void keyE3_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.E29);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_E3_1_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o29);
                keySound.Play();
            }
        }

        private void keyF3_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.F30);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_F3_1_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o30);
                keySound.Play();
            }
        }

        private void keyMF3_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.f_31);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_F3_15_fortissimo_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o31);
                keySound.Play();
            }
        }

        private void keyG3_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.G32);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_G3_1_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o32);
                keySound.Play();
            }
        }

        private void keyMG3_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.g_33);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_G3_15_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o33);
                keySound.Play();
            }
        }

        private void keyA3_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.A34);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_A3_1_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o34);
                keySound.Play();
            }
        }

        private void keyMA3_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.a_35);
            keySound.Play();
}
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_A3_05_fortissimo_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o35);
                keySound.Play();
            }
        }

        private void keyB3_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.b36);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_B3_1_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o36);
                keySound.Play();
            }
        }

        //          FOURTH OCTAVE

        private void keyC4_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.c37);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_C4_1_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o30_12);
                keySound.Play();
            }
        }

        private void keyMC4_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.c_38);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_C4_1_fortissimo_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o30_11);
                keySound.Play();
            }
        }

        private void keyD4_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.d39);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_D4_1_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o30_10);
                keySound.Play();
            }
        }

        private void keyMD4_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.d_40);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_D4_1_fortissimo_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o30_9);
                keySound.Play();
            }
        }

        private void keyE4_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.e41);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_E4_1_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o30_8);
                keySound.Play();
            }
        }

        private void keyF4_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.f42);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_F4_1_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o30_7);
                keySound.Play();
            }
        }

        private void keyMF4_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.f_43);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_F4_1_fortissimo_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o30_6);
                keySound.Play();
            }
        }

        private void keyG4_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.g44);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_Gs1_025_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o30_5);
                keySound.Play();
            }
        }

        private void keyMG4_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.g_45);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_Gs1_025_fortissimo_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o30_4);
                keySound.Play();
            }
        }

        private void keyA4_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.a46);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_As2_1_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o30_3);
                keySound.Play();
            }
        }

        private void keyMA4_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.a_47);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_As2_1_fortissimo_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o30_2);
                keySound.Play();
            }
        }

        private void keyB4_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.b48Last);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_bs4_15_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o30_1);
                keySound.Play();
            }
        }

        //          FIFTH OCTAVE

        private void keyC5_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.c49);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_Cs4_1_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o37);
                keySound.Play();
            }
        }

        private void keyMC5_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.c_50);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_Cs4_1_fortissimo_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o38);
                keySound.Play();
            }
        }

        private void keyD5_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.d51);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_Ds4_1_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o39);
                keySound.Play();
            }
        }

        private void keyMD5_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.d_52);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_Ds4_1_fortissimo_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o40);
                keySound.Play();
            }
        }

        private void keyE5_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.e53);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_Ds4_1_fortissimo_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o41);
                keySound.Play();
            }
        }

        private void keyF5_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.f54);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_Fs4_05_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o42);
                keySound.Play();
            }
        }

        private void keyMF5_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.f_55);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_Fs4_05_fortissimo_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o43);
                keySound.Play();
            }
        }

        private void keyG5_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.g56);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_Gs2_1_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o44);
                keySound.Play();
            }
        }

        private void keyMG5_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.g_57);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_Gs2_1_fortissimo_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o45);
                keySound.Play();
            }
        }

        private void keyA5_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.a58);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_As3_1_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o46);
                keySound.Play();
            }
        }

        private void keyMA5_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.a_59);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_As3_1_fortissimo_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o49);
                keySound.Play();
            }
        }

        private void keyB5_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.b60);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_bs5_15_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o50);
                keySound.Play();
            }
        }

        private void keyC6Last_Click(object sender, EventArgs e)
        {
            if(notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.c61);
            keySound.Play();
            }
            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_C6_15_forte_arco_normal);
                keySound.Play();
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o50);
                keySound.Play();
            }
        }

//            +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

//            -------------------------- KEYBOARD CONROLS ---------------------------------------

        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D1)
            {
                
                keyC1.PerformClick();
            }

            if (e.KeyChar == (char)Keys.D2)
            {
                keyD1.PerformClick();
            }

            if (e.KeyChar == (char)Keys.D3)
            {
                keyE1.PerformClick();
            }

            if (e.KeyChar == (char)Keys.D4)
            {
                keyF1.PerformClick();
            }

            if (e.KeyChar == (char)Keys.D5)
            {
                keyG1.PerformClick();
            }

            if (e.KeyChar == (char)Keys.D6)
            {
                keyA1.PerformClick();
            }

            if (e.KeyChar == (char)Keys.D7)
            {
                keyB1.PerformClick();
            }
            //      SECOND

            if (e.KeyChar == (char)Keys.D8)
            {
                keyC2.PerformClick();
            }

            if (e.KeyChar == (char)Keys.D9)
            {
                keyD2.PerformClick();
            }

            if (e.KeyChar == (char)Keys.D0)
            {
                keyE2.PerformClick();
            }

            if (e.KeyChar == (char)Keys.Q)
            {
                keyF2.PerformClick();
            }

            if (e.KeyChar == (char)Keys.W)
            {
                keyG2.PerformClick();
            }
           
            if (e.KeyChar == (char)Keys.E)
            {
                keyA2.PerformClick();
            }

            if (e.KeyChar == (char)Keys.R)
            {
                keyB2.PerformClick();
            }
            // THIRD OCTAVE

            if (e.KeyChar == (char)Keys.T)
            {
                keyC3.PerformClick();
            }

            if (e.KeyChar == (char)Keys.Y)
            {
                keyD3.PerformClick();
            }

            if (e.KeyChar == (char)Keys.U)
            {
                keyE3.PerformClick();
            }

            if (e.KeyChar == (char)Keys.I)
            {
                keyF3.PerformClick();
            }

            if (e.KeyChar == (char)Keys.O)
            {
                keyG3.PerformClick();
            }

            if (e.KeyChar == (char)Keys.P)
            {
                keyA3.PerformClick();
            }

            if (e.KeyChar == (char)Keys.A)
            {
                keyB3.PerformClick();
            }
            // FOURTH

            if (e.KeyChar == (char)Keys.S)
            {
                keyC4.PerformClick();
            }

            if (e.KeyChar == (char)Keys.D)
            {
                keyD4.PerformClick();
            }

            if (e.KeyChar == (char)Keys.F)
            {
                keyE4.PerformClick();
            }

            if (e.KeyChar == (char)Keys.G)
            {
                keyF4.PerformClick();
            }

            if (e.KeyChar == (char)Keys.H)
            {
                keyG4.PerformClick();
            }

            if (e.KeyChar == (char)Keys.J)
            {
                keyA4.PerformClick();
            }

            if (e.KeyChar == (char)Keys.K)
            {
                keyB4.PerformClick();
            }

            //FIFTH
            if (e.KeyChar == (char)Keys.L)
            {
                keyC5.PerformClick();
            }

            if (e.KeyChar == (char)Keys.Z)
            {
                keyD5.PerformClick();
            } 

            if (e.KeyChar == (char)Keys.X)
            {
                keyE5.PerformClick();
            }

            if (e.KeyChar == (char)Keys.C)
            {
                keyF5.PerformClick();
            }

            if (e.KeyChar == (char)Keys.V)
            {
                keyG5.PerformClick();
            }

            if (e.KeyChar == (char)Keys.B)
            {
                keyA5.PerformClick();
            }

            if (e.KeyChar == (char)Keys.N)
            {
                keyB5.PerformClick();
            }

            if (e.KeyChar == (char)Keys.M)
            {
                keyC6Last.PerformClick();
            } 

        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D1)
            {
                keyC1M.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.D2)
            {
                keyMD1.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.D3)
            {
                keyMF1.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.D4)
            {
                keyMG1.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.D5)
            {
                keyMA1.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.D6)
            {
                keyMC2.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.D7)
            {
                keyMD2.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.D8)
            {
                keyMF2.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.D9)
            {
                keyMG2.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.D0)
            {
                keyMA2.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.Q)
            {
                keyMC3.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.W)
            {
                keyMD3.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.E)
            {
                keyMF3.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.R)
            {
                keyMG3.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.T)
            {
                keyMA3.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.Y)
            {
                keyMC4.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.U)
            {
                keyMD4.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.I)
            {
                keyMF4.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.O)
            {
                keyMG4.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.P)
            {
                keyMA4.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.A)
            {
                keyMC5.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                keyMD5.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.D)
            {
                keyMF5.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.F)
            {
                keyMG5.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.G)
            {
                keyMA5.PerformClick();
            }

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pianoImage_Click(object sender, EventArgs e)
        {

        }
        
        private void keyAssist_CheckedChanged(object sender, EventArgs e)
        {


            if (keyAssist.Checked == false)
            {
                assistC1.Visible = false;
                assistMC1.Visible = false;
                assistD1.Visible = false;
                assistMD1.Visible = false;
                assistE1.Visible = false;

                assistF1.Visible = false;
                assistMF1.Visible = false;
                assistG1.Visible = false;
                assistMG1.Visible = false;
                assistA1.Visible = false;
                assistMA1.Visible = false;
                assistB1.Visible = false;

                assistC2.Visible = false;
                assistMC2.Visible = false;
                assistD2.Visible = false;
                assistMD2.Visible = false;
                assistE2.Visible = false;

                assistF2.Visible = false;
                assistMF2.Visible = false;
                assistG2.Visible = false;
                assistMG2.Visible = false;
                assistA2.Visible = false;
                assistMA2.Visible = false;
                assistB2.Visible = false;

                assistC3.Visible = false;
                assistMC3.Visible = false;
                assistD3.Visible = false;
                assistMD3.Visible = false;
                assistE3.Visible = false;

                assistF3.Visible = false;
                assistMF3.Visible = false;
                assistG3.Visible = false;
                assistMG3.Visible = false;
                assistA3.Visible = false;
                assistMA3.Visible = false;
                assistB3.Visible = false;


                assistC4.Visible = false;
                assistMC4.Visible = false;
                assistD4.Visible = false;
                assistMD4.Visible = false;
                assistE4.Visible = false;

                assistF4.Visible = false;
                assistMF4.Visible = false;
                assistG4.Visible = false;
                assistMG4.Visible = false;
                assistA4.Visible = false;
                assistMA4.Visible = false;
                assistB4.Visible = false;

                assistC5.Visible = false;
                assistMC5.Visible = false;
                assistD5.Visible = false;
                assistMD5.Visible = false;
                assistE5.Visible = false;

                assistF5.Visible = false;
                assistMF5.Visible = false;
                assistG5.Visible = false;
                assistMG5.Visible = false;
                assistA5.Visible = false;
                assistMA5.Visible = false;
                assistB5.Visible = false;

                assistC6.Visible = false;
            }
            else
            {
                assistC1.Visible = true;
                assistMC1.Visible = true;
                assistD1.Visible = true;
                assistMD1.Visible = true;
                assistE1.Visible = true;

                assistF1.Visible = true;
                assistMF1.Visible = true;
                assistG1.Visible = true;
                assistMG1.Visible = true;
                assistA1.Visible = true;
                assistMA1.Visible = true;
                assistB1.Visible = true;

                assistC2.Visible = true;
                assistMC2.Visible = true;
                assistD2.Visible = true;
                assistMD2.Visible = true;
                assistE2.Visible = true;

                assistF2.Visible = true;
                assistMF2.Visible = true;
                assistG2.Visible = true;
                assistMG2.Visible = true;
                assistA2.Visible = true;
                assistMA2.Visible = true;
                assistB2.Visible = true;

                assistC3.Visible = true;
                assistMC3.Visible = true;
                assistD3.Visible = true;
                assistMD3.Visible = true;
                assistE3.Visible = true;

                assistF3.Visible = true;
                assistMF3.Visible = true;
                assistG3.Visible = true;
                assistMG3.Visible = true;
                assistA3.Visible = true;
                assistMA3.Visible = true;
                assistB3.Visible = true;


                assistC4.Visible = true;
                assistMC4.Visible = true;
                assistD4.Visible = true;
                assistMD4.Visible = true;
                assistE4.Visible = true;

                assistF4.Visible = true;
                assistMF4.Visible = true;
                assistG4.Visible = true;
                assistMG4.Visible = true;
                assistA4.Visible = true;
                assistMA4.Visible = true;
                assistB4.Visible = true;

                assistC5.Visible = true;
                assistMC5.Visible = true;
                assistD5.Visible = true;
                assistMD5.Visible = true;
                assistE5.Visible = true;

                assistF5.Visible = true;
                assistMF5.Visible = true;
                assistG5.Visible = true;
                assistMG5.Visible = true;
                assistA5.Visible = true;
                assistMA5.Visible = true;
                assistB5.Visible = true;

                assistC6.Visible = true;
            }
        }

      


        /*
        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Browse to find a song to play to :";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "MP3 Files (*.mp3)|*.mp3";
         * 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String file = openFileDialog1.FileName;
                WMPLib.WindowsMediaPlayer song = new WMPLib.WindowsMediaPlayer();
                song.URL = file;
                song.controls.play();
                
            }       
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
         */

      
    }
}
