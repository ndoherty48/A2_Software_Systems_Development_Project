using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Mitchell_School_Of_Music.DAL
{
    class MitchellDAL
    {
        public static bool isAdmin;
        private static string _ConnectionString = ConfigurationManager.ConnectionStrings["MitchellConnection"].ConnectionString;
        public static int AddNewStudent(int ID, string Name, string Surname, string Address1, string Address2, string Postcode, string Tel, int Tutor, string Instrument, string Status, string Start, string Type, bool PrePay,string level)
        {

            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            int id = ID;
            string name = Name;
            string surname = Surname;
            string address1 = Address1;
            string address2 = Address2;
            string postcode = Postcode;
            string tel = Tel;
            string instrument = Instrument;
            int tutor = Tutor;
            string status = Status;
            string start = Start;
            string Class = Type;
            bool prePay = PrePay;
            string Level = level;
            using (SqlConnection connection = new SqlConnection(_Connectionstring))
            {
                connection.Open();
                string sqlQuery = string.Format("INSERT INTO tbl_Student VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
                    id, name, surname, address1, address2, postcode, tel, instrument, tutor, status, start,Class, prePay,Level);
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                int rowsAffected = insertCommand.ExecuteNonQuery();
                connection.Dispose();
                connection.Close();
                return rowsAffected;
            }
        }
        public static int DeleteStudent(int ID)
        {
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            int id = ID;
            using (SqlConnection connection = new SqlConnection(_Connectionstring))
            {
                connection.Open();
                
                string sqlQuery1 = string.Format("DELETE FROM tbl_Lesson WHERE Student_ID = '{0}'", id);
                string sqlQuery2 = string.Format("DELETE FROM Tbl_Booking WHERE Student_ID = '{0}'", id);
                string sqlQuery = string.Format("DELETE FROM tbl_Student WHERE Student_Id = '{0}'", id);
                SqlCommand insertCommand1 = new SqlCommand(sqlQuery1, connection);
                SqlCommand insertCommand2 = new SqlCommand(sqlQuery2, connection);
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                int rowsAffected =  insertCommand2.ExecuteNonQuery() & insertCommand1.ExecuteNonQuery() & insertCommand.ExecuteNonQuery();

                connection.Dispose();
                connection.Close();
                return rowsAffected;
            }
        }

        internal static int EditStudent(int v1, object text1, object text2, object text3, object text4, object text5, object text6, int v2, object text7, object text8)
        {
            throw new NotImplementedException();
        }

        public static int AddNewTutor(int ID, string Name, string Surname, string Address1, string Address2, string Postcode, string Tel,string Instrument, string dob)
        {
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            int id = ID;
            string name = Name;
            string surname = Surname;
            string address1 = Address1;
            string address2 = Address2;
            string postcode = Postcode;
            string tel = Tel;
            string instrument = Instrument;
            string DOB = dob;
            using (SqlConnection connection = new SqlConnection(_Connectionstring))
            {
                connection.Open();
                string sqlQuery = string.Format("INSERT INTO Tbl_Tutor VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                    id, name, surname, address1, address2, postcode, tel, instrument,DOB);
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                int rowsAffected = insertCommand.ExecuteNonQuery();
                connection.Dispose();
                connection.Close();
                return rowsAffected;
            }
        }
        public static int DeleteTutor(int ID)
        {
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            int id = ID;
            using (SqlConnection connection = new SqlConnection(_Connectionstring))
            {
                connection.Open();
                string sqlQuery10 = string.Format("DELETE FROM tbl_Lesson WHERE Tutor_ID = '{0}'", id);
                string sqlQuery12 = string.Format("UPDATE tbl_Student SET Tutor_ID = '0' WHERE Tutor_ID = '{0}'", id);
                string sqlQuery11 = string.Format("DELETE FROM Tbl_Tutor WHERE Tutor_Id = '{0}'", id);
                SqlCommand insertCommand10 = new SqlCommand(sqlQuery10, connection);
                SqlCommand insertCommand12 = new SqlCommand(sqlQuery12, connection);
                SqlCommand insertCommand11 = new SqlCommand(sqlQuery11, connection);
                int rowsAffected = insertCommand10.ExecuteNonQuery() &insertCommand12.ExecuteNonQuery() & insertCommand11.ExecuteNonQuery();

                connection.Dispose();
                connection.Close();
                return rowsAffected;
            }
        }
        public static int EditStudent(int ID, string Name, string Surname, string Address1, string Address2, string Postcode, string Tel, int Tutor, string Instrument, string Status,string InstClass,bool PrePaid, string StudentClass)
        {

            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            int id = ID;
            string name = Name;
            string surname = Surname;
            string address1 = Address1;
            string address2 = Address2;
            string postcode = Postcode;
            string tel = Tel;
            string instrument = Instrument;
            int tutor = Tutor;
            string status = Status;
            string instClass = InstClass;
            bool prePaid = PrePaid;
            string studentClass = StudentClass;
           
            using (SqlConnection connection = new SqlConnection(_Connectionstring))
            {
                connection.Open();
                string sqlQuery = string.Format("UPDATE tbl_Student SET Student_Name ='{1}', Student_Surname = '{2}', Student_Address_Line_1 = '{3}', Student_Address_Line_2 = '{4}', Student_Postcode = '{5}', Student_Tel = '{6}', Student_Instrument = '{7}', Tutor_ID = '{8}', Student_Status = '{9}', Instrument_Class = '{10}', Pre_Pay = '{11}', Student_Classification = '{12}' WHERE Student_Id = '{0}' ",
                    id, name, surname, address1, address2, postcode, tel, instrument, tutor, status,instClass,prePaid,studentClass);
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                int rowsAffected = insertCommand.ExecuteNonQuery();
                connection.Dispose();
                connection.Close();
                return rowsAffected;
            }
        }
        public static int EditTutor(int ID, string Name, string Surname, string Address1, string Address2, string Postcode, string Tel, string Instrument)
        {

            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            int id = ID;
            string name = Name;
            string surname = Surname;
            string address1 = Address1;
            string address2 = Address2;
            string postcode = Postcode;
            string tel = Tel;
            string instrument = Instrument;
            

            using (SqlConnection connection = new SqlConnection(_Connectionstring))
            {
                connection.Open();
                string sqlQuery = string.Format("UPDATE Tbl_Tutor SET Tutor_Name ='{1}', Tutor_Surname = '{2}', Tutor_Address_Line_1 = '{3}', Tutor_Address_Line_2 = '{4}', Tutor_Postcode = '{5}', Tutor_Tel = '{6}', Tutor_Instrument = '{7}'WHERE Tutor_Id = '{0}' ",
                    id, name, surname, address1, address2, postcode, tel, instrument);
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                int rowsAffected = insertCommand.ExecuteNonQuery();
                connection.Dispose();
                connection.Close();
                return rowsAffected;
            }
        }


    }

}

