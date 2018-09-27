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
    public partial class frmEditStudent : Form
    {
        public static int count = 0, count1 = 0, count2 = 0;
        public frmEditStudent()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        frmAddStudent add = new frmAddStudent();
        private void btn_Find_Click(object sender, EventArgs e)
        {
            try {
                string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(_Connectionstring))
                {
                    connection.Open();
                    string sqlQuery = string.Format("SELECT * FROM tbl_Student WHERE Student_Id = '{0}'", Convert.ToInt32(tb_ID.Text));
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
                        this.tb_Tutor.Text = rdr[8].ToString();
                        this.cbo_Status.Text = rdr[9].ToString();

                        add.showBalloonTip("Success", "Successfully Found Student");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                int rowsaffected = MitchellDAL.EditStudent(Convert.ToInt32(tb_ID.Text), tb_Name.Text, tb_Surname.Text, tb_Address1.Text, tb_Address2.Text, tb_Postcode.Text, tb_Tel.Text, Convert.ToInt32(tb_Tutor.Text), tb_Instrument.Text, cbo_Status.Text,cboClass.Text,checkBox1.Checked,cboLevel.Text);
                if (rowsaffected == 1) { add.showBalloonTip("Success", "Successfully Updated Student Details"); }
                else { add.showBalloonTip("UnSuccessful", "Could not update Student Details"); }
               // 
                this.Hide();
                StudentDetails mynextscreen = new StudentDetails();
                mynextscreen.ShowDialog();
                this.Dispose();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //
            this.Hide();
            StudentDetails mynextscreen = new StudentDetails();
            mynextscreen.ShowDialog();
            this.Dispose();
        }

        private void frmEditStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnSurnameSearch_Click(object sender, EventArgs e)
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

                        string sqlQuery = string.Format("SELECT * FROM tbl_Student WHERE Student_Surname  LIKE '{0}'", tb_Surname.Text);
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
                            this.tb_Tutor.Text = rdr[8].ToString();
                            this.cbo_Status.Text = rdr[9].ToString();
                            this.cboClass.Text = rdr[11].ToString();
                            this.checkBox1.Checked = Convert.ToBoolean(rdr[12].ToString());
                            this.cboLevel.Text = rdr[13].ToString();


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
                        string sqlQuery = string.Format("SELECT * FROM tbl_Student WHERE Student_Surname  LIKE '{0}' and Student_Name LIKE '{1}'", tb_Surname.Text, tb_Name.Text);
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
                            this.tb_Tutor.Text = rdr[8].ToString();
                            this.cbo_Status.Text = rdr[9].ToString();
                            this.cboClass.Text = rdr[11].ToString();
                            this.checkBox1.Checked = Convert.ToBoolean(rdr[12].ToString());
                            this.cboLevel.Text = rdr[13].ToString();

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

        private void frmEditStudent_FormClosing(object sender, FormClosingEventArgs e)
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
