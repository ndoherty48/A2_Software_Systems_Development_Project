using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mitchell_School_Of_Music.DAL;

namespace Mitchell_School_Of_Music.Forms
{
    public partial class frmBookings : Form
    {
        public frmBookings()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }


        int student;
        private void frmTimetables_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mitchellMusicDataSet.Tbl_Tutor' table. You can move, or remove it, as needed.
            this.tbl_TutorTableAdapter.Fill(this.mitchellMusicDataSet.Tbl_Tutor);
            // TODO: This line of code loads data into the 'mitchellMusicDataSet.tbl_Student' table. You can move, or remove it, as needed.
            this.tbl_StudentTableAdapter.Fill(this.mitchellMusicDataSet.tbl_Student);
            // TODO: This line of code loads data into the 'mitchellMusicDataSet.Tbl_Room' table. You can move, or remove it, as needed.
            this.tbl_RoomTableAdapter.Fill(this.mitchellMusicDataSet.Tbl_Room);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.MultiSelect = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView2.MultiSelect = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView3.MultiSelect = false;


        }

        private void frmBookings_FormClosing(object sender, FormClosingEventArgs e)
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

        private void pbHome_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            frmMenu nextScreen = new frmMenu();
            nextScreen.ShowDialog();
            this.Dispose();
        }
        int x, y, z;
        frmAddStudent add = new frmAddStudent();
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                int a = dataGridView1.CurrentCell.ColumnIndex;
                int b = dataGridView3.CurrentCell.ColumnIndex;
                int c = dataGridView2.CurrentCell.ColumnIndex;
                if (a == 0)
                {
                    //add.showBalloonTip( dataGridView1.CurrentCell.Value.ToString(), "Student ID Selected");

                    x = int.Parse(dataGridView1.CurrentCell.Value.ToString());
                    if (b == 0)
                    {
                        //add.showBalloonTip(dataGridView3.CurrentCell.Value.ToString(), "Tutor ID Selected");

                        y = int.Parse(dataGridView3.CurrentCell.Value.ToString());

                        if (c == 0)
                        {
                            //add.showBalloonTip(dataGridView2.CurrentCell.Value.ToString(), "Room ID Selected");
                            z = int.Parse(dataGridView2.CurrentCell.Value.ToString());
                            BookingDAL.addNewBooking(x, y, z, cboAllocated.Text, cboDay.Text, cboTime.Text, comboBox2.Text, int.Parse(textBox1.Text), int.Parse(comboBox1.Text));
                            add.showBalloonTip("Success", "Successfully Add Booking");
                            cboAllocated.SelectedIndex = -1;
                            cboDay.SelectedIndex = -1;
                            cboTime.SelectedIndex = -1;
                            comboBox1.SelectedIndex = -1;
                            comboBox2.SelectedIndex = -1;
                            textBox1.Text = "";
                            dataGridView1.ClearSelection();
                            dataGridView2.ClearSelection();
                            dataGridView3.ClearSelection();
                        }
                        else
                        {
                            add.showBalloonTip("Room Number ", "Please Select a Room Number");
                        }

                    }
                    else
                    {
                        add.showBalloonTip("Tutor ID ", "Please Select a Tutor ID");
                    }

                }
                else { add.showBalloonTip("Student ID ", "Please Select a Student ID"); }
            }
            catch(Exception ex)
            {
                add.showBalloonTip("Error", "Something Went Wrong");
                System.IO.StreamWriter writer = new System.IO.StreamWriter("../../ErrorLog.txt", true);
                writer.WriteLine("- " + DateTime.Now + " " + ex.Message, true);
                writer.Flush();
                writer.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //BookingDAL.UpdateBooking(x, y, int.Parse(cboAllocated.ToString()), comboBox2.Text, int.Parse(textBox1.Text), cboTime.Text, cboDay.Text);
                add.showBalloonTip("Success", "Successfully Updated Booking");
            }
            catch (Exception ex) {
                add.showBalloonTip("Error", "Something Went Wrong");
                System.IO.StreamWriter writer = new System.IO.StreamWriter("../../ErrorLog.txt", true);
                writer.WriteLine("- " + DateTime.Now + " " + ex.Message, true);
                writer.Flush();
                writer.Close();
            }
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                BookingDAL.TerminateBooking(x);
                add.showBalloonTip("Success", "Successfully Terminated Booking");
            }
            catch (Exception ex) {
                add.showBalloonTip("Error", "Something Went Wrong");
                System.IO.StreamWriter writer = new System.IO.StreamWriter("../../ErrorLog.txt", true);
                writer.WriteLine("- " + DateTime.Now + " " + ex.Message, true);
                writer.Flush();
                writer.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }       
}
