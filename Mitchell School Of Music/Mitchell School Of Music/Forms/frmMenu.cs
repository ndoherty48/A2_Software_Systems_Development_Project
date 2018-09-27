using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mitchell_School_Of_Music.DAL;
using Mitchell_School_Of_Music.Forms;

namespace Mitchell_School_Of_Music
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            DoubleBuffered = true;
            

        }
        frmLogin login = new frmLogin();
        private void frmMenu_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //This portion of code hides the current form. will declare and open which form has to be opened next
            //Before Disposing of resources used by current Form
            this.Hide();
            frmViewBookings nextForm = new frmViewBookings();
            nextForm.ShowDialog();
            this.Dispose();
            
            
        }

        private void btnTutorDetails_Click(object sender, EventArgs e)
        {
            //See Comments for above code to see what this does
            this.Hide();
            Tutor_Details nextForm = new Tutor_Details();
            nextForm.ShowDialog();
            this.Dispose();
        }

        private void btnStudentDetails_Click(object sender, EventArgs e)
        {
            //See Comments for above code to see what this does
            this.Hide();
            StudentDetails nextForm = new StudentDetails();
            nextForm.ShowDialog();
            this.Dispose();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if the user is the one to close the form then a prompt is thrown to make sure that the user 
            //would like to continue with closing the application. If Yes is pressed application closes 
            //and leaves no trace of the application in the thread. Otherwise the request to close form 
            //is cancelled and form stays open
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult DR = new DialogResult();
                DR = MessageBox.Show("Are you sure you wish to exit!", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);


                if (DR == DialogResult.OK) { Application.ExitThread(); }
                else { e.Cancel = true; }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //When user clicks the Logout Picture Box user is prompted to make sure they would want to logout
            //if the user clicks the ok button then the current form is closed and disposed of after the login
            //form is re-opened, otherwise the current form remains opened
            DialogResult dr = MessageBox.Show("Are you sure you would like to Logout?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                this.Hide();
                
                frmLogin login = new frmLogin();
                login.ShowDialog();
                this.Dispose();
            }
            else
            {
                
            }
            
        }
    } 
}
