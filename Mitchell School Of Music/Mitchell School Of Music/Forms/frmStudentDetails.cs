using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mitchell_School_Of_Music.Forms
{
    public partial class StudentDetails : Form
    {
        frmLogin login = new frmLogin();
        public StudentDetails()
        {

            InitializeComponent();
            DoubleBuffered = true;

         
        }
        frmAddStudent add = new frmAddStudent();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Form Hidden, New Form opened, Current Resources Disposed of
            this.Dispose();
            this.Hide();
            frmDeleteStudent nextscreen = new frmDeleteStudent();
            nextscreen.ShowDialog();
            
        }

        private void btn_EditDetails_Click(object sender, EventArgs e)
        {
            //Form Hidden, New Form opened, Current Resources Disposed of
            this.Dispose();
            this.Hide();
            frmEditStudent nextscreen = new frmEditStudent();
            nextscreen.ShowDialog();
            
        }

        private void btn_AddDetails_Click(object sender, EventArgs e)
        {
            //Form Hidden, New Form opened, Current Resources Disposed of
            this.Dispose();
            this.Hide();
            frmAddStudent nextscreen = new frmAddStudent();
            nextscreen.ShowDialog();
            
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mitchellMusicDBDataSet2.tbl_Student' table. You can move, or remove it, as needed.
            this.tbl_StudentTableAdapter1.Fill(this.mitchellMusicDBDataSet2.tbl_Student);
            this.tbl_StudentTableAdapter.Fill(this.mitchellMusicDBDataSet.tbl_Student);

            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            try
            {
                //This code executes a query with the data being wrote to a datatable which is viewed
                //in a datagridview with the other datagridview .visible command becomming false
                using (SqlConnection connection = new SqlConnection(_Connectionstring))
                {
                    connection.Open();
                    string sqlQuery = string.Format("SELECT * FROM tbl_Student ");
                    SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    DataTable table = new DataTable();
                    SqlDataAdapter a = new SqlDataAdapter(sqlQuery, connection);
                    a.Fill(table);
                    connection.Dispose();
                    connection.Close();
                    DataStudentView.DataSource = table;

                }

                //Checks each record pre payment status and if the answer is 'False' the colour is changed to red
                for (int i = 0; i < DataStudentView.Rows.Count; i++)
                {
                    string val = DataStudentView.Rows[i].Cells[12].Value.ToString();
                    if (val == "False")
                    {
                        DataStudentView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }

                }
            }
            catch(Exception ex)
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
        

        private void btn_Update_Click(object sender, EventArgs e)
        {
            this.tbl_StudentTableAdapter.Fill(this.mitchellMusicDBDataSet.tbl_Student);
        }

        private void StudentDetails_FormClosing(object sender, FormClosingEventArgs e)
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
            //Form Hidden, New Form opened, Current Resources Disposed of
            this.Dispose();
            this.Hide();
            frmMenu nextScreen = new frmMenu();
            nextScreen.ShowDialog();
            
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            //Form Hidden, New Form opened, Current Resources Disposed of
            this.Hide();
            frmStudentViewReport nextScreen = new frmStudentViewReport();
            nextScreen.ShowDialog();
        }
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            try
            {
                //This code executes a query with the data being wrote to a datatable which is viewed
                //in a datagridview with the other datagridview .visible command becomming false
                using (SqlConnection connection = new SqlConnection(_Connectionstring))
                {
                    if (tbName.Text != "") { 
                    connection.Open();
                    string sqlQuery = string.Format("SELECT * FROM tbl_Student where Student_Surname = '{0}'", tbName.Text);
                    SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    DataTable table = new DataTable();
                    SqlDataAdapter a = new SqlDataAdapter(sqlQuery, connection);
                    a.Fill(table);
                    connection.Dispose();
                    connection.Close();
                    DataStudentView.DataSource = table;
                    }
                    else
                    {
                        connection.Open();
                        string sqlQuery = string.Format("SELECT * FROM tbl_Student");
                        SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        DataTable table = new DataTable();
                        SqlDataAdapter a = new SqlDataAdapter(sqlQuery, connection);
                        a.Fill(table);
                        connection.Dispose();
                        connection.Close();
                        DataStudentView.DataSource = table;
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_StudentTableAdapter1.FillBy(this.mitchellMusicDBDataSet2.tbl_Student);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
