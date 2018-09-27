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
using Mitchell_School_Of_Music.DAL;

namespace Mitchell_School_Of_Music.Forms
{
    public partial class frmViewBookings : Form
    {
        public frmViewBookings()
        {
            InitializeComponent();
        }
        //Counters for each of the catch events and should it catch the same thing in the same catch it
        //will not display multiple notification popups.
        public static int count = 0, count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0, count7 = 0;
        frmAddStudent add = new frmAddStudent();
        private void frmViewBookings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mitchellMusicDBDataSet2.Tbl_Tutor' table. You can move, or remove it, as needed.
            this.tbl_TutorTableAdapter.Fill(this.mitchellMusicDBDataSet2.Tbl_Tutor);
            // TODO: This line of code loads data into the 'mitchellMusicDBDataSet2.tbl_Student' table. You can move, or remove it, as needed.
            this.tbl_StudentTableAdapter.Fill(this.mitchellMusicDBDataSet2.tbl_Student);

            this.tbl_LessonTableAdapter.FillBy(this.mitchellMusicDBDataSet2.tbl_Lesson);
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            //This code sets up a connection between the project and the database and creates and executes
            //the query before filling a datatable with the results of the query
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(_Connectionstring))
                {
                    connection.Open();
                    string sqlQuery = string.Format("SELECT * FROM tbl_Lesson WHERE Tutor_ID = '{0}'",int.Parse(textBox1.Text));
                    SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    DataTable table = new DataTable();
                    SqlDataAdapter a = new SqlDataAdapter(sqlQuery, connection);
                    a.Fill(table);
                    connection.Dispose();
                    connection.Close();
                    dgvViewBookings.DataSource = table;
                }
            }
            //Any Exception that is caught by the Try-Catch will be checked if this has been caught by the
            //try catch if so will not display a Notification message but will still write to the Error Log
            //Text File
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

        private void btnStudent_Click(object sender, EventArgs e)
        {
            //This code sets up a connection between the project and the database and creates and executes
            //the query before filling a datatable with the results of the query
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(_Connectionstring))
                {
                    connection.Open();
                    string sqlQuery = string.Format("SELECT * FROM tbl_Lesson WHERE Student_ID = '{0}'", int.Parse(textBox2.Text));
                    SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    DataTable table = new DataTable();
                    SqlDataAdapter a = new SqlDataAdapter(sqlQuery, connection);
                    a.Fill(table);
                    connection.Dispose();
                    connection.Close();
                    dgvViewBookings.DataSource = table;
                }
            }
            //Any Exception that is caught by the Try-Catch will be checked if this has been caught by the
            //try catch if so will not display a Notification message but will still write to the Error Log
            //Text File
            catch (Exception ex)
            {
                if (count1 < 1)
                {
                    add.showBalloonTip("Error", "Something Went Wrong");
                }
                System.IO.StreamWriter writer = new System.IO.StreamWriter("../../ErrorLog.txt", true);
                writer.WriteLine("- " + DateTime.Now + " " + ex.Message, true);
                writer.Flush();
                writer.Close();
                count1++;
            }
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            //This code sets up a connection between the project and the database and creates and executes
            //the query before filling a datatable with the results of the query
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(_Connectionstring))
                {
                    connection.Open();
                    string sqlQuery = string.Format("SELECT * FROM tbl_Lesson WHERE Room_ID = '{0}'", int.Parse(textBox3.Text));
                    SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    DataTable table = new DataTable();
                    SqlDataAdapter a = new SqlDataAdapter(sqlQuery, connection);
                    a.Fill(table);
                    connection.Dispose();
                    connection.Close();
                    dgvViewBookings.DataSource = table;
                }
            }
            //Any Exception that is caught by the Try-Catch will be checked if this has been caught by the
            //try catch if so will not display a Notification message but will still write to the Error Log
            //Text File
            catch (Exception ex)
            {
                if (count2 < 1)
                {
                    add.showBalloonTip("Error", "Something Went Wrong");
                }
                System.IO.StreamWriter writer = new System.IO.StreamWriter("../../ErrorLog.txt", true);
                writer.WriteLine("- " + DateTime.Now + " " + ex.Message, true);
                writer.Flush();
                writer.Close();
                count2++;
            }
        }

     
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //This code sets up a connection between the project and the database and creates and executes
            //the query's before filling a dataGridView's with the results of the query'
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(_Connectionstring))
                {
                    connection.Open();
                    string sqlQuery = string.Format("SELECT * FROM tbl_Lesson");
                    string sqlQuery1 = string.Format("SELECT * FROM tbl_Student");
                    SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    SqlCommand insertCommand1 = new SqlCommand(sqlQuery1, connection);
                    int rowsAffected1 = insertCommand1.ExecuteNonQuery();
                    DataTable table = new DataTable();
                    SqlDataAdapter a = new SqlDataAdapter(sqlQuery, connection);
                    a.Fill(table);
                    DataTable table1 = new DataTable();
                    SqlDataAdapter b = new SqlDataAdapter(sqlQuery1, connection);
                    b.Fill(table1);
                    connection.Dispose();
                    connection.Close();
                    dgvViewBookings.DataSource = table;
                    dataGridView1.DataSource = table1;

                    dataGridView1.Visible = true;
                    dataGridView2.Visible = false;
                }
            }
            //Any Exception that is caught by the Try-Catch will be checked if this has been caught by the
            //try catch if so will not display a Notification message but will still write to the Error Log
            //Text File
            catch (Exception ex)
            {
                if (count3 < 1)
                {
                    add.showBalloonTip("Error", "Something Went Wrong");
                }
                System.IO.StreamWriter writer = new System.IO.StreamWriter("../../ErrorLog.txt", true);
                writer.WriteLine("- " + DateTime.Now + " " + ex.Message, true);
                writer.Flush();
                writer.Close();
                count3++;
            }
        }
        public int a;

        private void btnAbsent_Click(object sender, EventArgs e)
        {
            //Checks column index and if it is equal to the second column represented as '1' it proceeds
            if (dgvViewBookings.CurrentCell.ColumnIndex == 1)
            {
                string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
                int student = int.Parse(dgvViewBookings.CurrentCell.Value.ToString());

                //Creates a connection and reads the absent data into local variable from an 
                //SQL Query
                int absent = 0;
                using (SqlConnection connection = new SqlConnection(_Connectionstring))
                {
                    connection.Open();
                    string sqlQuery = string.Format("SELECT * FROM tbl_Lesson WHERE Student_ID = '{0}'", student);
                    SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    SqlDataReader rdr = insertCommand.ExecuteReader();
                    if (rdr.Read())
                    {
                        absent = int.Parse(rdr[7].ToString());
                        rdr.Close();
                        
                    }
                    //The next query uses the local variable to update the user information with the updated
                    //Absent information as it adds one to the previous amount before another query reads
                    //the updated Absences into another local Variable
                    string sqlQuery1 = string.Format("UPDATE tbl_Lesson Set Absent_Amount = '{1}'+1 WHERE Student_ID = '{0}' ", student, absent);
                    SqlCommand insertCommand1 = new SqlCommand(sqlQuery1, connection);
                    int rowsAffected1 = insertCommand1.ExecuteNonQuery();
                    int CurrentAbscences = 0;
                    string sqlQuery2 = string.Format("Select Absent_Amount FROM tbl_Lesson WHERE Student_ID = '{0}'", student);
                    SqlCommand insertCommand2 = new SqlCommand(sqlQuery2, connection);
                    int rowsAffected2 = insertCommand2.ExecuteNonQuery();
                    SqlDataReader rdr2 = insertCommand2.ExecuteReader();
                    if (rdr2.Read())
                    {
                        CurrentAbscences = int.Parse(rdr2[0].ToString());
                        rdr2.Close();
                    }
                    this.tbl_LessonTableAdapter.FillBy(this.mitchellMusicDBDataSet2.tbl_Lesson);
                    //if the current abscences is greater than or equal to 3 then the user is prompted
                    //if they wish to Delete the booking
                    if (CurrentAbscences >= 3)
                    {
                        DialogResult DR =  MessageBox.Show("The Current Student has reached their max Abscence Allowance! Would You like to give away their Place?","",MessageBoxButtons.YesNo);
                        if(DR == DialogResult.Yes)
                        {
                            btnDeleteBooking.PerformClick();
                        }
                    }
                }
            }
            //Message that appears if an id from the student id Column is selected
            else
            {
                MessageBox.Show("Please Select A Student ID");
            }
        }

        private void dgvViewBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             //Checks column index and if it is equal to the second column represented as '1' it proceeds

            if (dgvViewBookings.CurrentCell.ColumnIndex == 1)
            {
               
                //Creates and executes a query through the connection and reads the results of the query
                //into a datatable and sets the datagridview to display the datatable
                string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
                try
                {
                    
                    using (SqlConnection connection = new SqlConnection(_Connectionstring))
                    {

                        connection.Open();
                        string sqlQuery = string.Format("SELECT * FROM tbl_Student where Student_ID = '{0}'", int.Parse(dgvViewBookings.CurrentCell.Value.ToString()));
                        SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        DataTable table = new DataTable();
                        SqlDataAdapter a = new SqlDataAdapter(sqlQuery, connection);
                        a.Fill(table);
                        connection.Dispose();
                        connection.Close();
                        dataGridView1.DataSource = table;
                    }
                }
                //Any Exception that is caught by the Try-Catch will be checked if this has been caught by the
                //try catch if so will not display a Notification message but will still write to the Error Log
                //Text File
                catch (Exception ex)
                {
                    if (count4 < 1)
                    {
                        add.showBalloonTip("Error", "Something Went Wrong");
                    }
                    System.IO.StreamWriter writer = new System.IO.StreamWriter("../../ErrorLog.txt", true);
                    writer.WriteLine("- " + DateTime.Now + " " + ex.Message, true);
                    writer.Flush();
                    writer.Close();
                    count4++;
                }
            }
            else if(dgvViewBookings.CurrentCell.ColumnIndex == 2)
            {
                //Creates and executes a query through the connection and reads the results of the query
                //into a datatable and sets the datagridview to display the datatable
                string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
                try
                {

                    using (SqlConnection connection = new SqlConnection(_Connectionstring))
                    {

                        connection.Open();
                        string sqlQuery = string.Format("SELECT * FROM Tbl_Tutor where Tutor_ID = '{0}'", int.Parse(dgvViewBookings.CurrentCell.Value.ToString()));
                        SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        DataTable table = new DataTable();
                        SqlDataAdapter a = new SqlDataAdapter(sqlQuery, connection);
                        a.Fill(table);
                        connection.Dispose();
                        connection.Close();
                        dataGridView1.DataSource = table;
                    }
                }
                //Any Exception that is caught by the Try-Catch will be checked if this has been caught by the
                //try catch if so will not display a Notification message but will still write to the Error Log
                //Text File
                catch (Exception ex)
                {
                    if (count5 < 1)
                    {
                        add.showBalloonTip("Error", "Something Went Wrong");
                    }
                    System.IO.StreamWriter writer = new System.IO.StreamWriter("../../ErrorLog.txt", true);
                    writer.WriteLine("- " + DateTime.Now + " " + ex.Message, true);
                    writer.Flush();
                    writer.Close();
                    count5++;
                }
            }
        }

        private void dgvViewBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Checks column index and if it is equal to the second column represented as '1' it proceeds
            if (dgvViewBookings.CurrentCell.ColumnIndex == 1)
            {
                string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
                try
                {
                    //This code executes a query with the data being wrote to a datatable which is viewed
                    //in a datagridview with the other datagridview .visible command becomming false
                    using (SqlConnection connection = new SqlConnection(_Connectionstring))
                    {

                        connection.Open();
                        string sqlQuery = string.Format("SELECT * FROM tbl_Student where Student_ID = '{0}'", int.Parse(dgvViewBookings.CurrentCell.Value.ToString()));
                        SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        DataTable table = new DataTable();
                        SqlDataAdapter a = new SqlDataAdapter(sqlQuery, connection);
                        a.Fill(table);
                        connection.Dispose();
                        dataGridView2.Visible = false;
                        dataGridView1.Visible = true;
                        connection.Close();
                        dataGridView1.DataSource = table;
                    }
                }
                //Any Exception that is caught by the Try-Catch will be checked if this has been caught by the
                //try catch if so will not display a Notification message but will still write to the Error Log
                //Text File
                catch (Exception ex)
                {
                    if (count6 < 1)
                    {
                        add.showBalloonTip("Error", "Something Went Wrong");
                    }
                    System.IO.StreamWriter writer = new System.IO.StreamWriter("../../ErrorLog.txt", true);
                    writer.WriteLine("- " + DateTime.Now + " " + ex.Message, true);
                    writer.Flush();
                    writer.Close();
                    count6++;
                }
            }
            //This code executes a query with the data being wrote to a datatable which is viewed
            //in a datagridview with the other datagridview .visible command becomming false
            else if (dgvViewBookings.CurrentCell.ColumnIndex == 2)
            {
                dataGridView1.DataSource = mitchellMusicDBDataSet2.Tbl_Tutor;
                
                string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
                try
                {

                    using (SqlConnection connection = new SqlConnection(_Connectionstring))
                    {

                        connection.Open();
                        string sqlQuery = string.Format("SELECT * FROM Tbl_Tutor where Tutor_ID = '{0}'", int.Parse(dgvViewBookings.CurrentCell.Value.ToString()));
                        SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        DataTable table = new DataTable();
                        table.Columns.Add("Tutor ID");
                        table.Columns.Add("Tutor Name");
                        table.Columns.Add("Tutor Surname");
                        SqlDataAdapter a = new SqlDataAdapter(sqlQuery, connection);
                        a.Fill(table);
                        connection.Dispose();
                        connection.Close();
                        dataGridView1.Visible = false;
                        dataGridView2.Visible = true;
                        dataGridView2.DataSource = table;
                        
                    }
                }
                //Any Exception that is caught by the Try-Catch will be checked if this has been caught by the
                //try catch if so will not display a Notification message but will still write to the Error Log
                //Text File
                catch (Exception ex)
                {
                    if (count7 < 1)
                    {
                        add.showBalloonTip("Error", "Something Went Wrong");
                    }
                    System.IO.StreamWriter writer = new System.IO.StreamWriter("../../ErrorLog.txt", true);
                    writer.WriteLine("- " + DateTime.Now + " " + ex.Message, true);
                    writer.Flush();
                    writer.Close();
                    count7++;
                }
            }
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            //This code checks if a student id is selected before reading it to a local variable
            //It then passes that data to a method in a seperate class. if any errors are found they
            //will be caught by Try-Catch. if No ID selected User prompted to select a Student ID
            if(dgvViewBookings.CurrentCell.ColumnIndex == 1)
            {
                int x = int.Parse(dgvViewBookings.CurrentCell.Value.ToString());
                try
                {
                    BookingDAL.TerminateBooking(x);
                    dgvViewBookings.Update();
                }
                catch
                {
                    add.showBalloonTip("Error", "Something Went Wrong");
                }
            }
            else
            {
                add.showBalloonTip("Student ID", "Please Select a Student ID");
            }
        }

        private void BtnAddBooking_Click(object sender, EventArgs e)
        {
            //Form Hidden, New Form opened, Current Resources Disposed of
            this.Hide();
            frmAddNewBooking nextScreen = new frmAddNewBooking();
            nextScreen.ShowDialog();
            this.Dispose();
        }

        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            //See Above
            this.Hide();
            frmEditBookings nextScreen = new frmEditBookings();
            nextScreen.ShowDialog();
            this.Dispose();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            //See Above
            this.Hide();
            frmMenu nextScreen = new frmMenu();
            nextScreen.ShowDialog();
            this.Dispose();
        }

        private void frmViewBookings_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
