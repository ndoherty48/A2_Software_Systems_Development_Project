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
    public partial class frmAddNewBooking : Form
    {
        
        public frmAddNewBooking()
        {
            InitializeComponent();
        }

        public static int count = 0, count1 = 0;

        frmAddStudent add = new frmAddStudent();
        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void AdultClass(int studentID, int TutorID, int RoomID)
        {
                DialogResult DR = MessageBox.Show("This slot is reserved for Adults! Do you wish to proceed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(DR == DialogResult.Yes)
                {
                switch (cboLessons.Text)
                {
                    case "20":
                        MessageBox.Show("There is a 5% Discount available with the 20 Lessons. Please Use Promo Code: 20L5%");
                        break;
                    case "30":
                        MessageBox.Show("There is a 10% Discount available with the 30 Lessons. Please Use Promo Code: 30L10%");
                        break;
                    default:
                        MessageBox.Show("No Discount Available");
                        break;
                }
                DAL.BookingDAL.addNewBooking(studentID, TutorID, RoomID, cboBlock.Text, cboDay.Text, cboTime.Text, cboPayment.Text, int.Parse(tbAmount.Text), int.Parse(cboLessons.Text));
                this.Hide();
                frmViewBookings NextScreen = new frmViewBookings();
                NextScreen.ShowDialog();
                this.Dispose();
                }
                else
                {
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewBookings nextScreen = new frmViewBookings();
            nextScreen.ShowDialog();
            this.Dispose();
        }
        public static int x;
      
        private void frmAddNewBooking_Load(object sender, EventArgs e)
        {
            #region FindMax
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            //frmAddStudent add = new frmAddStudent();
            //using (SqlConnection connection = new SqlConnection(_Connectionstring))
            //{
            //    connection.Open();
            //    string sqlQuery = string.Format("SELECT MAX(Lesson_ID) FROM tbl_Lesson ");
            //    SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);

            //    SqlDataReader rdr = insertCommand.ExecuteReader();

            //    //
            //    if (rdr.Read())
            //    {
            //        x = Convert.ToInt32(rdr[0].ToString());


            //        rdr.Close();
            //    }
            //    connection.Dispose();
            //    connection.Close();
            //    this.textBox1.Text = Convert.ToString(x + 1);
            //}

            #endregion
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
                    cboStudent.Items.Add(rdr[1].ToString() + " " + rdr[2].ToString() + " " + "(" + rdr[7].ToString() + ")");
                    while (rdr.Read())
                    {
                        cboStudent.Items.Add(rdr[1].ToString() + " " + rdr[2].ToString() + " "+ "("+ rdr[7].ToString()+")");

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
                    
                    cboTutor.Items.Add(rdr[1].ToString() + " " + rdr[2].ToString() + " " + "(" + rdr[7].ToString() + ")");
                    while (rdr.Read())
                    {
                        cboTutor.Items.Add(rdr[1].ToString() + " " + rdr[2].ToString() + " " + "(" + rdr[7].ToString() + ")");
                        
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
                    cboRooms.Items.Add(rdr[0].ToString());
                    while (rdr.Read())
                    {
                        cboRooms.Items.Add(rdr[0].ToString());
                        
                    }
                    rdr.Close();
                }
                connection.Dispose();
                connection.Close();
            }
            #endregion
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Controls.OfType<TextBox>().Any(t => t.Text == ""))
                {
                    add.showBalloonTip("Field entries", "All Fields must be used");
                }
                else if (Controls.OfType<ComboBox>().Any(t => t.Text == ""))
                {
                    add.showBalloonTip("Field entries", "All Fields must be used");
                }
                else
                {
                    string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
                    int studentID, TutorID, RoomID;

                    string[] nameParts = cboStudent.Text.Split(' ');

                    string firstName = nameParts[0];
                    string lastName = nameParts[1];

                    string[] nameParts1 = cboTutor.Text.Split(' ');

                    string firstName1 = nameParts1[0];
                    string lastName1 = nameParts1[1];


                    bool studentBooking, TutorAvailable, RoomUsed;
                    using (SqlConnection connection = new SqlConnection(_Connectionstring))
                    {
                        connection.Open();
                        string sqlQuery = string.Format("SELECT * FROM tbl_Student where Student_Name = '{0}' and Student_Surname = '{1}'", firstName.ToString(), lastName.ToString());
                        string sqlQuery1 = string.Format("SELECT * FROM Tbl_Tutor where Tutor_Name = '{0}' and Tutor_Surname = '{1}'", firstName1.ToString(), lastName1.ToString());
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
                        string sqlQuery2 = string.Format("SELECT COUNT(*) FROM tbl_Lesson where Student_ID = '{0}' and Lesson_Allocated = '{1}'", studentID, cboBlock.Text);
                        SqlCommand insertCommand2 = new SqlCommand(sqlQuery2, connection);
                        SqlDataReader rdr2 = insertCommand2.ExecuteReader();
                        if (rdr2.Read())
                        {
                            int x = int.Parse(rdr2[0].ToString());
                            if (x <= 1)
                            {
                                studentBooking = true;
                            }
                            else
                            {
                                studentBooking = false;
                            }

                        }
                        else
                        {
                            studentBooking = false;
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
                        if (studentBooking == false)
                        {
                            MessageBox.Show("Student Booking Already Exists");
                        }
                        else if (TutorAvailable == false)
                        {
                            MessageBox.Show("Tutor already Utilised");
                        }
                        else if (RoomUsed == false)
                        {
                            MessageBox.Show("Room Already in use");
                        }
                        else
                        {
                            switch (cboTime.Text)
                            {
                                case "13:00-13:30":
                                    AdultClass(studentID, TutorID, RoomID);
                                    break;
                                case "13:30-14:00":
                                    AdultClass(studentID, TutorID, RoomID);
                                    break;
                                case "14:00-14:30":
                                    AdultClass(studentID, TutorID, RoomID);
                                    break;
                                case "14:30-15:00":
                                    AdultClass(studentID, TutorID, RoomID);
                                    break;
                                default:

                                    break;
                            }
                            switch (cboLessons.Text)
                            {
                                case "20":
                                    MessageBox.Show("There is a 5% Discount available with the 20 Lessons. Please Use Promo Code: 20L5%");
                                    break;
                                case "30":
                                    MessageBox.Show("There is a 10% Discount available with the 30 Lessons. Please Use Promo Code: 30L10%");
                                    break;
                                default:
                                    MessageBox.Show("No Discount Available");
                                    break;
                            }
                            int rowsAffected = DAL.BookingDAL.addNewBooking(studentID, TutorID, RoomID, cboBlock.Text, cboDay.Text, cboTime.Text, cboPayment.Text, int.Parse(tbAmount.Text), int.Parse(cboLessons.Text));
                            if (rowsAffected == 1)
                            {
                                this.Hide();
                                frmViewBookings nextScreen = new frmViewBookings();
                                nextScreen.ShowDialog();
                                this.Dispose();
                            }
                            else
                            {

                            }
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
            }
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

        private void frmAddNewBooking_FormClosing(object sender, FormClosingEventArgs e)
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
