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

namespace Mitchell_School_Of_Music.Forms
{
    public partial class frmDeleteStudent : Form
    {
        public frmDeleteStudent()
        {
            InitializeComponent();
            DoubleBuffered = true;

        }

        public static int count = 0;
        frmAddStudent add = new frmAddStudent();

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try {
                frmAddStudent student = new frmAddStudent();
                
                int rowsAffected = MitchellDAL.DeleteStudent(Convert.ToInt32(tb_Student_Delete.Text));
               
                if(rowsAffected == 0)
                {
                    student.showBalloonTip("Delete Successful", "Successfully deleted Student");
                }
                else
                {
                    student.showBalloonTip("Delete Unsuccessful", "Could not delete Student");
                }
                //this.Dispose();
                this.Hide();
                StudentDetails mynextscreen = new StudentDetails();
                mynextscreen.ShowDialog();
                Close();
            }
            catch (Exception ex){
                if (count < 1)
                {
                    add.showBalloonTip("Error", "Something Went Wrong");
                }
                System.IO.StreamWriter writer = new System.IO.StreamWriter("../../ErrorLog.txt", true);
                writer.WriteLine("- " + DateTime.Now + " " + ex.Message, true);
                writer.Flush();
                writer.Close();
                count++;
                this.Hide();
                StudentDetails nextScreen = new StudentDetails();
                nextScreen.ShowDialog();
                //this.Dispose();
                Close();
               
            }
        }

        private void tb_Student_Delete_TextChanged(object sender, EventArgs e)
        {
            if(tb_Student_Delete.Text == "x" )
            { 
                //this.Dispose();
                this.Hide();
                StudentDetails nextForm = new StudentDetails();
                nextForm.ShowDialog();
                Close();
            }
            else{ }
        }
    }
}
