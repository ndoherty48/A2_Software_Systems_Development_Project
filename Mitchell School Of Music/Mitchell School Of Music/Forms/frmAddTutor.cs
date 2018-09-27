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
using System.Data.SqlClient;

namespace Mitchell_School_Of_Music.Forms
{
    public partial class frmAddTutor : Form
    {
        frmAddStudent add = new frmAddStudent();
        public frmAddTutor()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        public static int count = 0;
        frmAddStudent student = new frmAddStudent();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                if (Controls.OfType<TextBox>().Any(t => t.Text == ""))
                {
                    student.showBalloonTip("Field entries", "All Fields must be used");
                }
                else if (Controls.OfType<ComboBox>().Any(t => t.Text == ""))
                {
                    student.showBalloonTip("Field entries", "All Fields must be used");
                }
                else
                {
                    int rowsAffected = MitchellDAL.AddNewTutor(Convert.ToInt32(tb_ID.Text), tb_Name.Text, tb_Surname.Text, tb_Address1.Text, tb_Address2.Text, tb_Postcode.Text, tb_Tel.Text, tb_Instrument.Text, tb_DOB.Text);
                    if (rowsAffected == 1)
                    {

                        student.showBalloonTip("Success", "Successfully Added Tutor");
                    }
                    else
                    {

                        student.showBalloonTip("Unsuccessful", "Could not add Tutor");
                    }
                    //this.Dispose();
                    this.Hide();
                    Tutor_Details mynextscreen = new Tutor_Details();
                    mynextscreen.ShowDialog();
                    Dispose();
                }
            }
            catch (Exception ex)
            {
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

        private void frmAddTutor_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutor_Details mynextscreen = new Tutor_Details();
            mynextscreen.ShowDialog();
            this.Dispose();
        }

        private void frmAddTutor_Load(object sender, EventArgs e)
        {
            tb_ID.Enabled = false;
            #region FindMax
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            frmAddStudent add = new frmAddStudent();
            using (SqlConnection connection = new SqlConnection(_Connectionstring))
            {
                connection.Open();
                string sqlQuery = string.Format("SELECT MAX(Tutor_Id) FROM Tbl_Tutor");
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader rdr = insertCommand.ExecuteReader();
                int x;
                //
                if (rdr.Read())
                {
                    x = Convert.ToInt32(rdr[0].ToString());
                    this.tb_ID.Text = Convert.ToString(x + 1);

                    rdr.Close();
                }
                connection.Dispose();
                connection.Close();
                //this.tb_ID.Text = Convert.ToString(x + 1);
            }

            #endregion
        }
    }
}
