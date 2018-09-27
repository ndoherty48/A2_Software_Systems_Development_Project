using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mitchell_School_Of_Music.DAL;
using System.Data.SqlClient;

namespace Mitchell_School_Of_Music.DAL
{
    class BookingDAL: MitchellDAL
    {
        public static int addNewBooking(int student, int tutor, int room, string block, string day,string time, string payment, int amount, int lessons)
        {
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            
            int StudentID = student;
            int TutorID = tutor;
            int RoomID = room;
            string Block = block;
            string Day = day;
            string Time = time;
            string Payment = payment;
            int Amount = amount;
            int Lessons = lessons;


            using (SqlConnection connection = new SqlConnection(_Connectionstring))
            {
                connection.Open();
                string sqlQuery = string.Format("INSERT INTO tbl_Lesson VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    StudentID,TutorID,RoomID,Block,Day,Time,0);
                string sqlQuery1 = string.Format("Insert INTO Tbl_Booking Values('{0}','{1}','{2}','{3}')",StudentID,Payment,Amount,Lessons);
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                SqlCommand insertCommand1 = new SqlCommand(sqlQuery1, connection);
                int rowsAffected = insertCommand.ExecuteNonQuery()& insertCommand1.ExecuteNonQuery();
                connection.Dispose();
                connection.Close();
                return rowsAffected;
            }
        }
        public static int TerminateBooking(int student)
        {
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            int StudentID = student;
            using (SqlConnection connection = new SqlConnection(_Connectionstring))
            {
                connection.Open();
                string sqlQuery = string.Format("DELETE FROM tbl_Lesson WHERE Student_ID = '{0}'", StudentID);
                string sqlQuery1 = string.Format("DELETE FROM Tbl_Booking WHERE Student_ID = '{0}'", StudentID);
                string sqlQuery2 = string.Format("UPDATE tbl_Student SET Student_Status = 'Terminated' where Student_Id = '{0}'", StudentID);
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                SqlCommand insertCommand1 = new SqlCommand(sqlQuery1, connection);
                SqlCommand insertCommand2 = new SqlCommand(sqlQuery2, connection);
                int rowsAffected = insertCommand.ExecuteNonQuery() & insertCommand1.ExecuteNonQuery() & insertCommand2.ExecuteNonQuery();
                connection.Dispose();
                connection.Close();
                return rowsAffected;
            }
        }
        public static int UpdateBooking(int student,int tutor,string block,int lessons, string Type, int amount, string time,string day)
        {
            string _Connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MitchellMusicDB.mdf;Integrated Security=True";
            int StudentID = student;
            int Tutorid = tutor;
            int Lessons = lessons;
            string Ptype = Type;
            string LessonTime = time;
            string Day = day;
            int Amount = amount;
            using (SqlConnection connection = new SqlConnection(_Connectionstring))
            {
                connection.Open();
                string sqlQuery = string.Format("UPDATE tbl_Lesson SET Lesson_Day = '{3}', Lesson_Time = '{2}', Lesson_Allocated = '{1}' WHERE Student_ID = '{0}'", StudentID,block,LessonTime,Day);
                string sqlQuery1 = string.Format("UPDATE Tbl_Booking SET Booking_Lessons = '{3}', Booking_Amount='{2}', Booking_Payment = '{1}' WHERE Student_ID='{0}'", StudentID, Ptype ,Amount,Lessons);
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                SqlCommand insertCommand1 = new SqlCommand(sqlQuery1, connection);
                int rowsAffected = insertCommand.ExecuteNonQuery() & insertCommand1.ExecuteNonQuery();
                connection.Dispose();
                connection.Close();
                return rowsAffected;
            }
        }
    }
}
