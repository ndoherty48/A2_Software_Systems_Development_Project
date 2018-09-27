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
    public partial class frmEditTutor : Form
    {
        public frmEditTutor()
        {
            InitializeComponent();
            DoubleBuffered = true;
           
        }
        public static int count = 0, count1 = 0, count2 = 0;
        private void btnCancel_Click(object sender, EventArgs e)
        {
           // 
            this.Hide();
            Tutor_Details mynextscreen = new Tutor_Details();
            mynextscreen.ShowDialog();
            this.Dispose();
        }
        frmAddStudent add = new frmAddStudent();
        private void btnFind_Click(object sender, EventArgs e)
        {
            try {
                string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
                frmAddStudent add = new frmAddStudent();
                using (SqlConnection connection = new SqlConnection(_Connectionstring))
                {
                    connection.Open();
                    string sqlQuery = string.Format("SELECT * FROM Tbl_Tutor WHERE Tutor_Id = '{0}'", Convert.ToInt32(tb_ID.Text));
                    SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);

                    SqlDataReader rdr = insertCommand.ExecuteReader();

                    //
                    if (rdr.Read())
                    {
                        this.tb_Name.Text = rdr[1].ToString();
                        this.tb_Surname.Text = rdr[2].ToString();
                        this.tb_Address1.Text = rdr[3].ToString();
                        this.tb_Address2.Text = rdr[4].ToString();
                        this.tb_Postcode.Text = rdr[5].ToString();
                        this.tb_Tel.Text = rdr[6].ToString();
                        this.tb_Instrument.Text = rdr[7].ToString();
                        this.tb_DOB.Text = rdr[8].ToString();


                        rdr.Close();
                    }
                    else
                    {
                        add.showBalloonTip("Unsuccessful", "Could Not find Data!");
                        rdr.Close();
                    }

                    connection.Dispose();
                    connection.Close();

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                int rowsaffected = MitchellDAL.EditTutor(Convert.ToInt32(tb_ID.Text), tb_Name.Text, tb_Surname.Text, tb_Address1.Text, tb_Address2.Text, tb_Postcode.Text, tb_Tel.Text, tb_Instrument.Text);
                if (rowsaffected == 1) { add.showBalloonTip("Success", "Successfully Updated Tutor Details"); }
                else { add.showBalloonTip("UnSuccessful", "Could not update Tutor Details"); }
               // this.Dispose();
                this.Hide();
                Tutor_Details mynextscreen = new Tutor_Details();
                mynextscreen.ShowDialog();
                Close();
            }
            catch(Exception ex)
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

        private void frmEditTutor_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // throw new IndexOutOfRangeException();

                string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
                frmAddStudent add = new frmAddStudent();
                using (SqlConnection connection = new SqlConnection(_Connectionstring))
                {
                    connection.Open();
                    if (tb_Name.Text == "")
                    {

                        string sqlQuery = string.Format("SELECT * FROM Tbl_Tutor WHERE Tutor_Surname  LIKE '{0}'", tb_Surname.Text);
                        SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                        SqlDataReader rdr = insertCommand.ExecuteReader();
                        //
                        if (rdr.Read())
                        {
                            this.tb_ID.Enabled = false;
                            this.tb_ID.Text = rdr[0].ToString();
                            this.tb_Name.Text = rdr[1].ToString();
                            this.tb_Surname.Text = rdr[2].ToString();
                            this.tb_Address1.Text = rdr[3].ToString();
                            this.tb_Address2.Text = rdr[4].ToString();
                            this.tb_Postcode.Text = rdr[5].ToString();
                            this.tb_Tel.Text = rdr[6].ToString();
                            this.tb_Instrument.Text = rdr[7].ToString();
                            this.tb_DOB.Text = rdr[8].ToString();


                            rdr.Close();
                        }
                        else
                        {
                            add.showBalloonTip("Unsuccessful", "Could Not find Data!");
                            rdr.Close();
                        }
                    }
                    else
                    {
                        string sqlQuery = string.Format("SELECT * FROM Tbl_Tutor WHERE Tutor_Surname  LIKE '{0}' and Tutor_Name LIKE '{1}'", tb_Surname.Text, tb_Name.Text);
                        SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                        SqlDataReader rdr = insertCommand.ExecuteReader();
                        if (rdr.Read())
                        {
                            this.tb_ID.Enabled = false;
                            this.tb_ID.Text = rdr[0].ToString();
                            this.tb_Name.Text = rdr[1].ToString();
                            this.tb_Surname.Text = rdr[2].ToString();
                            this.tb_Address1.Text = rdr[3].ToString();
                            this.tb_Address2.Text = rdr[4].ToString();
                            this.tb_Postcode.Text = rdr[5].ToString();
                            this.tb_Tel.Text = rdr[6].ToString();
                            this.tb_Instrument.Text = rdr[7].ToString();
                            this.tb_DOB.Text = rdr[8].ToString();


                            rdr.Close();
                        }
                        else
                        {
                            add.showBalloonTip("Unsuccessful", "Could Not find Data!");
                            rdr.Close();
                        }

                    }

                    connection.Dispose();
                    connection.Close();

                }
            }
            catch(Exception ex)
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
    }
}
