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
    public partial class frmLogin : Form
    {
        //int value used to count the errors in the program and not allow repeated popups to occur ... See Below
        public static int count = 0;
        public frmLogin()
        {
            InitializeComponent();
        }
        public string AdminPassword;
        public int Count=0, count1=0, count2=0;
        //Declares the add student form to use Methods in that form
        frmAddStudent add = new frmAddStudent();
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //Creates a connection to the sql Database using the connection string and uses the query string
            //to execute the command and retrieve data from the Database.
            //It then uses a Data Reader To retrieve the data and therefore check against user inputed 
            //Data
            try {
                
                string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(_Connectionstring))
                {
                    connection.Open();
                    string sqlQuery = string.Format("SELECT * FROM Login where Username = '{0}' AND Password ='{1}'", tbUsername.Text, tbPassword.Text);
                    SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);

                    SqlDataReader dr = insertCommand.ExecuteReader();
                    //Retrieves data from database and writes them to Local Variable
                    //Checks whether the user inputted the correct username and password
                    //To Access the program
                    if (dr.Read())
                    {
                        string username = dr[1 ].ToString();
                        string password = dr[2].ToString();
                        
                        if (tbUsername.Text == username)
                        {
                            if (tbPassword.Text == password)
                            {
                                
                                Hide();
                                AdminPassword = password;
                                frmMenu a = new frmMenu();
                                add.showBalloonTip("Success", "Successfully Logged on");
                                a.ShowDialog();
                                dr.Close();
                               
                            }
                            //If the user used incorrect Details it displays a Balloon Notification but
                            //if clicked multiple times it will only display one balloon tip
                            else
                            {
                                if(count < 1) {add.showBalloonTip("Unsuccessful", "Could Not Login!"); }
                                count++;
                                dr.Close();
                            }
                        }
                        else
                        {
                            if (count1 < 1) { add.showBalloonTip("Unsuccessful", "Could Not Login!"); }
                            count1++;
                            dr.Close();
                        }
                        dr.Close();
                    }
                    else
                    {
                        if (count2 < 1) { add.showBalloonTip("Unsuccessful", "Could Not Login!"); }
                        count2++;
                        dr.Close();
                    }


                    connection.Dispose();
                    connection.Close();

                }
            }
            //If Try Catch catches any error it will display a balloon notification aslong as it has
            //not already done so in this instance of the form.
            //It then Writes the error on a new line in a Error Log Text File. Before adding 1 to the Counter
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

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
