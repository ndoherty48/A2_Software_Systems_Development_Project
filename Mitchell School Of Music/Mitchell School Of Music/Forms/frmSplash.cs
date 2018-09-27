using Mitchell_School_Of_Music.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitchell_School_Of_Music
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            //This Code makes sure that the splash screen does not show in the taskbar
            //aswell as declaring the Soundplayer in order to play the intro Music
            //and declare the file location for the music which will be played and then starts the music
            
            InitializeComponent();
            this.ShowInTaskbar = false;

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "../../Sound/Mitchell School of music Intro V1.wav";
            player.Play();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            //Enables and starts timer and sets the tick event to happen on the 6th second
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 6000;
            

            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             
                //Stops the timer
                timer1.Stop();
                //Hides The Form
                this.Hide();
                // Opens the next form

                frmLogin mynextscreen = new frmLogin ();
               
                mynextscreen.ShowDialog();
                this.Close();

        }
    }
}
