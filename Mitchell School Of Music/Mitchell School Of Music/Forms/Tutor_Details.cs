using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace Mitchell_School_Of_Music.Forms
{
    public partial class Tutor_Details : Form
    {
        frmAddStudent add = new frmAddStudent();
        public Tutor_Details()
        {
            
            InitializeComponent();
            DoubleBuffered = true;
        }

     
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //The code below hides the current screen before opening another
            //and then closing all utilised resources from current form
            this.Hide();
            frmDeleteTutor nextscreen = new frmDeleteTutor();
            nextscreen.ShowDialog();
            Close();
        }

        private void btn_EditDetails_Click(object sender, EventArgs e)
        {
            //See above Comment
            this.Hide();
            frmEditTutor nextscreen = new frmEditTutor();
            nextscreen.ShowDialog();
            Close();
        }

        private void btn_AddDetails_Click(object sender, EventArgs e)
        {
            //See First Set of Comments
            this.Hide();
            frmAddTutor nextscreen = new frmAddTutor();
            nextscreen.ShowDialog();
            Close();
        }

        private void tbAdminPassword_TextChanged(object sender, EventArgs e)
        {

        }
        public string userAnswer;
        private void Tutor_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mitchellMusicDataSet.Tbl_Tutor' table. You can move, or remove it, as needed.
            this.tbl_TutorTableAdapter1.Fill(this.mitchellMusicDataSet.Tbl_Tutor);
            //This code enables all the buttons on the form for the user to use
            btnDelete.Enabled = true;
            btn_AddDetails.Enabled = true;
            btn_EditDetails.Enabled = true;
            DataTutorView.Visible = true;
        }
        
        private void Tutor_Details_FormClosing(object sender, FormClosingEventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //When the user clicks the home button picture it Hides the current form and opens
            //the Menu form before closing all resources from this form
            this.Hide();
            frmMenu nextScreen = new frmMenu();
            nextScreen.ShowDialog();
            Close();
        }
        int count = 0;
        private void btnName_Click(object sender, EventArgs e)
        {

            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            try
            {
                //This code executes a query with the data being wrote to a datatable which is viewed
                //in a datagridview with the other datagridview .visible command becomming false
                using (SqlConnection connection = new SqlConnection(_Connectionstring))
                {
                    if (tbName.Text != "")
                    {
                        connection.Open();
                        string sqlQuery = string.Format("SELECT * FROM Tbl_Tutor where Tutor_Surname = '{0}'", tbName.Text);
                        SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        DataTable table = new DataTable();
                        SqlDataAdapter a = new SqlDataAdapter(sqlQuery, connection);
                        a.Fill(table);
                        connection.Dispose();
                        connection.Close();
                        DataTutorView.DataSource = table;
                    }
                    else
                    {
                        connection.Open();
                        string sqlQuery = string.Format("SELECT * FROM Tbl_Tutor");
                        SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        DataTable table = new DataTable();
                        SqlDataAdapter a = new SqlDataAdapter(sqlQuery, connection);
                        a.Fill(table);
                        connection.Dispose();
                        connection.Close();
                        DataTutorView.DataSource = table;
                    }
                }
            }
            //Any Exception that is caught by the Try-Catch will be checked if this has been caught by the
            //try catch if so will not display a Notification message but will still write to the Error Log
            //Text File

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
    }
}
