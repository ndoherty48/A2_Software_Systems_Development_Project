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
    public partial class frmDeleteTutor : Form
    {
        public frmDeleteTutor()
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
                
                int rowsAffected = MitchellDAL.DeleteTutor(Convert.ToInt32(tb_Tutor_Delete.Text));
                if(rowsAffected == 0) { student.showBalloonTip("Delete Successful", "Successfully deleted Tutor"); }
                else { student.showBalloonTip("Delete UnSuccessful", "Could Not Delete Tutor"); }
                // this.Dispose();
                this.Hide();
                Tutor_Details mynextscreen = new Tutor_Details();
                mynextscreen.ShowDialog();
                Close();
            }
            catch (Exception ex){
                this.Hide();
                Tutor_Details nextScreen = new Tutor_Details();
                nextScreen.ShowDialog();
                //this.Dispose();
                Close();
                if (count < 1)
                {
                    add.showBalloonTip("Error", "Something Went Wrong");
                }
                System.IO.StreamWriter writer = new System.IO.StreamWriter("../../ErrorLog.txt", true);
                writer.WriteLine("- " + DateTime.Now + " " + ex.Message, true);
                writer.Flush();
                writer.Close();
                count++;
            }
        }

        private void tb_Tutor_Delete_TextChanged(object sender, EventArgs e)
        {
            if (tb_Tutor_Delete.Text == "x")
            {
                //this.Dispose();
                this.Hide();
                Tutor_Details nextForm = new Tutor_Details();
                nextForm.ShowDialog();
                Close();
            }
            else { }
        }
    }
}
