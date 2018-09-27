using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitchell_School_Of_Music.Forms
{
    public partial class frmStudentViewReport : Form
    {
        public frmStudentViewReport()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void frmStudentViewReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mitchellMusicDBDataSet2.tbl_Student' table. You can move, or remove it, as needed.
            this.tbl_StudentTableAdapter.Fill(this.mitchellMusicDBDataSet2.tbl_Student);
            //Sets the Default setting for the reports from the Different Margins to the report being
            //in Landscape
            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            pg.Margins.Top = 0;
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;
            pg.Landscape = true;
            reportViewer1.SetPageSettings(pg);
            this.reportViewer1.RefreshReport();

        }

        private void fillByStudentIDQueryToolStripButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.tbl_StudentTableAdapter.FillByStudentIDQuery(this.mitchellMusicDBDataSet2.tbl_Student, ((int)(System.Convert.ChangeType(student_IDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.tbl_StudentTableAdapter.Fill(this.mitchellMusicDBDataSet2.tbl_Student);
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            //Form Hidden, New Form opened, Current Resources Disposed of
            this.Hide();
            StudentDetails nextScreen = new StudentDetails();
            nextScreen.ShowDialog();
        }
    }
}
