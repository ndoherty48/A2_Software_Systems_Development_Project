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
    public partial class frmEditBookings : Form
    {
        public static int count = 0, count1 = 0;
        public frmEditBookings()
        {
            InitializeComponent();
        }
        frmAddStudent add = new frmAddStudent();
        private void frmEditBookings_Load(object sender, EventArgs e)
        {
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";

            #region Student Names
            using (SqlConnection connection = new SqlConnection(_Connectionstring))
            {
                connection.Open();
                string sqlQuery = string.Format("SELECT * FROM tbl_Student ");
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader rdr = insertCommand.ExecuteReader();

                //
                if (rdr.Read())
                {
                    int b = 0;
                    cboStudent.Items.Add(rdr[1].ToString() + " " + rdr[2].ToString() + " " + "(" + rdr[7].ToString() + ")");
                    while (rdr.Read())
                    {
                        cboStudent.Items.Add(rdr[1].ToString() + " " + rdr[2].ToString() + " " + "(" + rdr[7].ToString() + ")");
                        b++;
                    }
                    rdr.Close();
                }
                connection.Dispose();
                connection.Close();
            }
            #endregion
            #region Tutor Names
            using (SqlConnection connection = new SqlConnection(_Connectionstring))
            {
                connection.Open();
                string sqlQuery = string.Format("SELECT * FROM Tbl_Tutor ");
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader rdr = insertCommand.ExecuteReader();
                if (rdr.Read())
                {
                    int b = 0;
                    cboTutor.Items.Add(rdr[1].ToString() + " " + rdr[2].ToString() + " " + "(" + rdr[7].ToString() + ")");
                    while (rdr.Read())
                    {
                        cboTutor.Items.Add(rdr[1].ToString() + " " + rdr[2].ToString() + " " + "(" + rdr[7].ToString() + ")");
                        b++;
                    }
                    rdr.Close();
                }
                connection.Dispose();
                connection.Close();
            }
            #endregion
            #region Rooms
            using (SqlConnection connection = new SqlConnection(_Connectionstring))
            {
                connection.Open();
                string sqlQuery = string.Format("SELECT * FROM Tbl_Room");
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader rdr = insertCommand.ExecuteReader();
                if (rdr.Read())
                {
                    int b = 0;
                    while (rdr.Read())
                    {
                        cboRooms.Items.Add(rdr[0].ToString());
                        b++;
                    }
                    rdr.Close();
                }
                connection.Dispose();
                connection.Close();
            }
            #endregion
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEditBookings_FormClosing(object sender, FormClosingEventArgs e)
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
            frmViewBookings nextScreen = new frmViewBookings();
            nextScreen.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
                int studentID, TutorID, RoomID;

                string[] nameParts = cboStudent.Text.Split(' ');

                string firstName = nameParts[0];
                string lastName = nameParts[1];

                string[] nameParts1 = cboTutor.Text.Split(' ');

                string firstName1 = nameParts1[0];
                string lastName1 = nameParts1[1];


                bool studentBooking = false, TutorAvailable = true, RoomUsed = false;
                using (SqlConnection connection = new SqlConnection(_Connectionstring))
                {
                    connection.Open();
                    string sqlQuery = string.Format("SELECT * FROM tbl_Student where Student_Name = '{0}' and Student_Surname = '{1}'", firstName, lastName);
                    string sqlQuery1 = string.Format("SELECT * FROM Tbl_Tutor where Tutor_Name = '{0}' and Tutor_Surname = '{1}'", firstName1, lastName1);
                    // string sqlQuery2 = string.Format("SELECT * FROM tbl_Lesson where Student_ID = '{0}' and Lesson_Allocated = '{1}'", studentID, cboBlock.Text);
                    SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                    //SqlCommand insertCommand1 = new SqlCommand(sqlQuery1, connection);
                    SqlDataReader rdr = insertCommand.ExecuteReader();

                    //
                    if (rdr.Read())
                    {
                        studentID = int.Parse(rdr[0].ToString());
                        rdr.Close();
                    }
                    else { studentID = 0; }
                    rdr.Close();
                    SqlCommand insertCommand1 = new SqlCommand(sqlQuery1, connection);
                    SqlDataReader rdr1 = insertCommand1.ExecuteReader();
                    if (rdr1.Read())
                    {
                        TutorID = int.Parse(rdr1[0].ToString());
                        rdr1.Close();
                    }
                    else { TutorID = 0; }
                    #region student Double Booked Check
                    string sqlQuery2 = string.Format("SELECT * FROM tbl_Lesson where Student_ID = '{0}' and Lesson_Allocated = '{1}'", studentID, cboBlock.Text);
                    SqlCommand insertCommand2 = new SqlCommand(sqlQuery2, connection);
                    SqlDataReader rdr2 = insertCommand2.ExecuteReader();
                    if (rdr2.HasRows)
                    {
                        studentBooking = false;
                    }
                    else
                    {
                        studentBooking = true;
                    }
                    rdr2.Close();
                    #endregion
                    #region Room Check
                    string sqlQuery3 = string.Format("SELECT * FROM tbl_Lesson where Room_ID = '{0}' and Lesson_Allocated = '{1}' and Lesson_Day = '{2}' and Lesson_Time = '{3}'", int.Parse(cboRooms.Text), cboBlock.Text, cboDay.Text, cboTime.Text);
                    SqlCommand insertCommand3 = new SqlCommand(sqlQuery3, connection);
                    SqlDataReader rdr3 = insertCommand3.ExecuteReader();
                    if (rdr3.HasRows)
                    {
                        RoomUsed = false;
                    }
                    else
                    {
                        RoomUsed = true;
                    }
                    rdr3.Close();
                    #endregion
                    #region Tutor Already used
                    string sqlQuery4 = string.Format("SELECT * FROM tbl_Lesson where Tutor_ID = '{0}' and Lesson_Allocated = '{1}' and Lesson_Day = '{2}' and Lesson_Time = '{3}'", TutorID, cboBlock.Text, cboDay.Text, cboTime.Text);
                    SqlCommand insertCommand4 = new SqlCommand(sqlQuery4, connection);
                    SqlDataReader rdr4 = insertCommand3.ExecuteReader();
                    if (rdr4.HasRows)
                    {
                        TutorAvailable = false;
                    }
                    else
                    {
                        TutorAvailable = true;
                    }
                    rdr4.Close();
                    #endregion
                    connection.Dispose();
                    connection.Close();
                    //MessageBox.Show("Student ID: " + studentID.ToString() + "Tutor ID: " + TutorID.ToString());




                }
                RoomID = int.Parse(cboRooms.Text);
                try
                {

                    DAL.BookingDAL.UpdateBooking(studentID, TutorID, cboBlock.Text, int.Parse(cboLessons.Text), cboPayment.Text, int.Parse(tbAmount.Text), cboTime.Text, cboDay.Text);




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
                this.Hide();
                frmViewBookings nextScreen = new frmViewBookings();
                nextScreen.ShowDialog();
                this.Dispose();
                this.Hide();
            }
            catch( Exception ex)
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

        private void cboStudent_TextChanged(object sender, EventArgs e)
        {
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";

            string[] nameParts = cboStudent.Text.Split(' ');

            string firstName = nameParts[0];
            string lastName = nameParts[1];

            using (SqlConnection connection = new SqlConnection(_Connectionstring))
            {
                int student,tutor;
                connection.Open();
                string sqlQuery1 = string.Format("SELECT * FROM tbl_Student WHERE Student_Name = '{0}' AND Student_Surname = '{1}'", firstName, lastName);
                SqlCommand insertCommand1 = new SqlCommand(sqlQuery1, connection);
                SqlDataReader rdr1 = insertCommand1.ExecuteReader();
                //
                if (rdr1.Read())
                {
                    student = int.Parse(rdr1[0].ToString());
                }
                else { student = 0; }
                rdr1.Close();
                string sqlQuery = string.Format("SELECT * FROM tbl_Lesson where Student_ID = '{0}'",student);
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader rdr = insertCommand.ExecuteReader();
                if (rdr.Read())
                {
                    tutor = int.Parse(rdr[2].ToString());
                    cboRooms.Text = rdr[3].ToString();
                    cboBlock.Text = rdr[4].ToString();
                    cboDay.Text = rdr[5].ToString();
                    cboTime.Text = rdr[6].ToString();
                    //tbAmount.Text = "Successful";
                    rdr.Close();
                }
                else { tutor = 0; }
                rdr.Close();
                string sqlQuery2 = string.Format("SELECT * FROM Tbl_Tutor where Tutor_ID = '{0}'", tutor);
                SqlCommand insertCommand2 = new SqlCommand(sqlQuery2, connection);
                SqlDataReader rdr2 = insertCommand2.ExecuteReader();
                if (rdr2.Read())
                {
                    cboTutor.Text = rdr2[1].ToString() + " " + rdr2[2].ToString() + " ("+rdr2[7].ToString() +")";
                    
                }
                rdr2.Close();
                string sqlQuery3 = string.Format("SELECT * FROM Tbl_Booking where Student_ID = '{0}'", student);
                SqlCommand insertCommand3 = new SqlCommand(sqlQuery3, connection);
                SqlDataReader rdr3 = insertCommand3.ExecuteReader();
                if (rdr3.Read())
                {
                    cboPayment.Text = rdr3[2].ToString();
                    tbAmount.Text = rdr3[3].ToString();
                    //cboLessons.Text = rdr[4].ToString();
                    rdr3.Close();
                }
                
                connection.Dispose();
                connection.Close();
            }
        }
    }
}
