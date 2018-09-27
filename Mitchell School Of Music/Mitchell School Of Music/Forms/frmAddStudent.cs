using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mitchell_School_Of_Music.DAL;

namespace Mitchell_School_Of_Music.Forms
{
    public partial class frmAddStudent : Form
    {
        
        public frmAddStudent()
        {
            InitializeComponent();
            DoubleBuffered = true;
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";

            

        }
        public void showBalloonTip(string title,string body)
        {
            NotifyIcon notify = new NotifyIcon();
            notify.Icon = SystemIcons.Information;
            notify.Visible = true;
            notify.BalloonTipTitle = title;
            notify.BalloonTipText = body;
            notify.ShowBalloonTip(30000);
            notify.Icon = this.Icon;
            
            notify.Dispose();
        }

        public static int x,count = 0;
        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mitchellMusicDataSet.Tbl_Tutor' table. You can move, or remove it, as needed.
            this.tbl_TutorTableAdapter.Fill(this.mitchellMusicDataSet.Tbl_Tutor);
            tb_ID.Enabled = false;
            #region FindMax
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            frmAddStudent add = new frmAddStudent();
            using (SqlConnection connection = new SqlConnection(_Connectionstring))
            {
                connection.Open();
                string sqlQuery = string.Format("SELECT MAX(Student_Id) FROM tbl_Student ");
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader rdr = insertCommand.ExecuteReader();

                //
                if (rdr.Read())
                {
                    x = Convert.ToInt32(rdr[0].ToString());


                    rdr.Close();
                }
                connection.Dispose();
                connection.Close();
                this.tb_ID.Text = Convert.ToString(x + 1);
            }

            #endregion
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            try {
                if (Controls.OfType<TextBox>().Any(t => t.Text == ""))
                {
                    showBalloonTip("Field entries", "All Fields must be used");
                }
                else if (Controls.OfType<ComboBox>().Any(t => t.Text == ""))
                {
                    showBalloonTip("Field entries", "All Fields must be used");
                }
                else
                {
                    int rowsAffected = MitchellDAL.AddNewStudent(Convert.ToInt32(tb_ID.Text), tb_Name.Text, tb_Surname.Text, tb_Address1.Text, tb_Address2.Text, tb_Postcode.Text, tb_Tel.Text, Convert.ToInt32(tb_Tutor.Text), tb_Instrument.Text, cbo_Status.Text, tb_Start.Text, cboClass.Text, (bool)checkBox1.Checked, cboLevel.Text);
                    if (rowsAffected == 1)
                    {
                        showBalloonTip("Successful", "Successfully Added Student");
                    }
                    else
                    {
                        showBalloonTip("UnSuccessful", "Could Not Add Student");
                    }
                    // this.Dispose();
                    this.Hide();
                    StudentDetails mynextscreen = new StudentDetails();
                    mynextscreen.ShowDialog();
                    Close();
                }

                
            }
            catch (Exception ex)
            {
                if(count < 1)
                {
                    showBalloonTip("Error", "Something Went Wrong");
                }
                System.IO.StreamWriter writer = new System.IO.StreamWriter("../../ErrorLog.txt", true);
                writer.WriteLine("- " + DateTime.Now + " " + ex.Message, true);
                writer.Flush();
                writer.Close();
                count++;
            }
            btnSave.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
            StudentDetails mynextscreen = new StudentDetails();
            mynextscreen.ShowDialog();
            
        }

        private void tb_Tutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void frmAddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
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
        
    }
}
