namespace Mitchell_School_Of_Music.Forms
{
    partial class StudentDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDetails));
            this.DataStudentView = new System.Windows.Forms.DataGridView();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAddressLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAddressLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPostcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInstrumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBlockStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instrument_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pre_Pay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Student_Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mitchellMusicDBDataSet2 = new Mitchell_School_Of_Music.MitchellMusicDBDataSet2();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitchellMusicDBDataSet = new Mitchell_School_Of_Music.MitchellMusicDataSet();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btn_AddDetails = new System.Windows.Forms.Button();
            this.btn_EditDetails = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbl_StudentTableAdapter = new Mitchell_School_Of_Music.MitchellMusicDataSetTableAdapters.tbl_StudentTableAdapter();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbl_StudentTableAdapter1 = new Mitchell_School_Of_Music.MitchellMusicDBDataSet2TableAdapters.tbl_StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataStudentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // DataStudentView
            // 
            this.DataStudentView.AllowUserToAddRows = false;
            this.DataStudentView.AllowUserToDeleteRows = false;
            this.DataStudentView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataStudentView.AutoGenerateColumns = false;
            this.DataStudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataStudentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.studentAddressLine1DataGridViewTextBoxColumn,
            this.studentAddressLine2DataGridViewTextBoxColumn,
            this.studentPostcodeDataGridViewTextBoxColumn,
            this.studentTelDataGridViewTextBoxColumn,
            this.studentInstrumentDataGridViewTextBoxColumn,
            this.tutorIDDataGridViewTextBoxColumn,
            this.studentStatusDataGridViewTextBoxColumn,
            this.studentBlockStartDataGridViewTextBoxColumn,
            this.Instrument_Class,
            this.Pre_Pay,
            this.Student_Classification});
            this.DataStudentView.DataSource = this.tblStudentBindingSource1;
            this.DataStudentView.Location = new System.Drawing.Point(13, 13);
            this.DataStudentView.Name = "DataStudentView";
            this.DataStudentView.ReadOnly = true;
            this.DataStudentView.Size = new System.Drawing.Size(630, 464);
            this.DataStudentView.TabIndex = 0;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIdDataGridViewTextBoxColumn.Width = 25;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentNameDataGridViewTextBoxColumn.Width = 50;
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "Student_Surname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            this.studentSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentSurnameDataGridViewTextBoxColumn.Width = 80;
            // 
            // studentAddressLine1DataGridViewTextBoxColumn
            // 
            this.studentAddressLine1DataGridViewTextBoxColumn.DataPropertyName = "Student_Address_Line_1";
            this.studentAddressLine1DataGridViewTextBoxColumn.HeaderText = "Address 1";
            this.studentAddressLine1DataGridViewTextBoxColumn.Name = "studentAddressLine1DataGridViewTextBoxColumn";
            this.studentAddressLine1DataGridViewTextBoxColumn.ReadOnly = true;
            this.studentAddressLine1DataGridViewTextBoxColumn.Width = 150;
            // 
            // studentAddressLine2DataGridViewTextBoxColumn
            // 
            this.studentAddressLine2DataGridViewTextBoxColumn.DataPropertyName = "Student_Address_Line_2";
            this.studentAddressLine2DataGridViewTextBoxColumn.HeaderText = "Address 2";
            this.studentAddressLine2DataGridViewTextBoxColumn.Name = "studentAddressLine2DataGridViewTextBoxColumn";
            this.studentAddressLine2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentPostcodeDataGridViewTextBoxColumn
            // 
            this.studentPostcodeDataGridViewTextBoxColumn.DataPropertyName = "Student_Postcode";
            this.studentPostcodeDataGridViewTextBoxColumn.HeaderText = "Postcode";
            this.studentPostcodeDataGridViewTextBoxColumn.Name = "studentPostcodeDataGridViewTextBoxColumn";
            this.studentPostcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentTelDataGridViewTextBoxColumn
            // 
            this.studentTelDataGridViewTextBoxColumn.DataPropertyName = "Student_Tel";
            this.studentTelDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.studentTelDataGridViewTextBoxColumn.Name = "studentTelDataGridViewTextBoxColumn";
            this.studentTelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentInstrumentDataGridViewTextBoxColumn
            // 
            this.studentInstrumentDataGridViewTextBoxColumn.DataPropertyName = "Student_Instrument";
            this.studentInstrumentDataGridViewTextBoxColumn.HeaderText = "Instrument";
            this.studentInstrumentDataGridViewTextBoxColumn.Name = "studentInstrumentDataGridViewTextBoxColumn";
            this.studentInstrumentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tutorIDDataGridViewTextBoxColumn
            // 
            this.tutorIDDataGridViewTextBoxColumn.DataPropertyName = "Tutor_ID";
            this.tutorIDDataGridViewTextBoxColumn.HeaderText = "Tutor";
            this.tutorIDDataGridViewTextBoxColumn.Name = "tutorIDDataGridViewTextBoxColumn";
            this.tutorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tutorIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // studentStatusDataGridViewTextBoxColumn
            // 
            this.studentStatusDataGridViewTextBoxColumn.DataPropertyName = "Student_Status";
            this.studentStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.studentStatusDataGridViewTextBoxColumn.Name = "studentStatusDataGridViewTextBoxColumn";
            this.studentStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBlockStartDataGridViewTextBoxColumn
            // 
            this.studentBlockStartDataGridViewTextBoxColumn.DataPropertyName = "Student_Block_Start";
            this.studentBlockStartDataGridViewTextBoxColumn.HeaderText = "Block Start";
            this.studentBlockStartDataGridViewTextBoxColumn.Name = "studentBlockStartDataGridViewTextBoxColumn";
            this.studentBlockStartDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentBlockStartDataGridViewTextBoxColumn.Width = 150;
            // 
            // Instrument_Class
            // 
            this.Instrument_Class.DataPropertyName = "Instrument_Class";
            this.Instrument_Class.HeaderText = "Instrument Class";
            this.Instrument_Class.Name = "Instrument_Class";
            this.Instrument_Class.ReadOnly = true;
            // 
            // Pre_Pay
            // 
            this.Pre_Pay.DataPropertyName = "Pre_Pay";
            this.Pre_Pay.HeaderText = "Pre Pay";
            this.Pre_Pay.Name = "Pre_Pay";
            this.Pre_Pay.ReadOnly = true;
            // 
            // Student_Classification
            // 
            this.Student_Classification.DataPropertyName = "Student_Classification";
            this.Student_Classification.HeaderText = "Student Classification";
            this.Student_Classification.Name = "Student_Classification";
            this.Student_Classification.ReadOnly = true;
            // 
            // tblStudentBindingSource1
            // 
            this.tblStudentBindingSource1.DataMember = "tbl_Student";
            this.tblStudentBindingSource1.DataSource = this.mitchellMusicDBDataSet2;
            // 
            // mitchellMusicDBDataSet2
            // 
            this.mitchellMusicDBDataSet2.DataSetName = "MitchellMusicDBDataSet2";
            this.mitchellMusicDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "tbl_Student";
            this.tblStudentBindingSource.DataSource = this.mitchellMusicDBDataSet;
            // 
            // mitchellMusicDBDataSet
            // 
            this.mitchellMusicDBDataSet.DataSetName = "MitchellMusicDBDataSet";
            this.mitchellMusicDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Image = global::Mitchell_School_Of_Music.Properties.Resources.logo3;
            this.pbLogo.Location = new System.Drawing.Point(649, 13);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(245, 114);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // btn_AddDetails
            // 
            this.btn_AddDetails.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_AddDetails.BackColor = System.Drawing.Color.Black;
            this.btn_AddDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddDetails.ForeColor = System.Drawing.Color.Red;
            this.btn_AddDetails.Location = new System.Drawing.Point(650, 144);
            this.btn_AddDetails.Name = "btn_AddDetails";
            this.btn_AddDetails.Size = new System.Drawing.Size(245, 44);
            this.btn_AddDetails.TabIndex = 2;
            this.btn_AddDetails.Text = "Add Student";
            this.btn_AddDetails.UseVisualStyleBackColor = false;
            this.btn_AddDetails.Click += new System.EventHandler(this.btn_AddDetails_Click);
            // 
            // btn_EditDetails
            // 
            this.btn_EditDetails.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_EditDetails.AutoSize = true;
            this.btn_EditDetails.BackColor = System.Drawing.Color.Black;
            this.btn_EditDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditDetails.ForeColor = System.Drawing.Color.Red;
            this.btn_EditDetails.Location = new System.Drawing.Point(650, 194);
            this.btn_EditDetails.Name = "btn_EditDetails";
            this.btn_EditDetails.Size = new System.Drawing.Size(245, 44);
            this.btn_EditDetails.TabIndex = 3;
            this.btn_EditDetails.Text = "Edit Student";
            this.btn_EditDetails.UseVisualStyleBackColor = false;
            this.btn_EditDetails.Click += new System.EventHandler(this.btn_EditDetails_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(650, 244);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(245, 44);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbl_StudentTableAdapter
            // 
            this.tbl_StudentTableAdapter.ClearBeforeFill = true;
            // 
            // pbHome
            // 
            this.pbHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHome.BackColor = System.Drawing.Color.Transparent;
            this.pbHome.BackgroundImage = global::Mitchell_School_Of_Music.Properties.Resources.home_150499_1280;
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHome.Image = global::Mitchell_School_Of_Music.Properties.Resources.home_150499_1280;
            this.pbHome.Location = new System.Drawing.Point(650, 407);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(88, 69);
            this.pbHome.TabIndex = 6;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnViewReport
            // 
            this.btnViewReport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnViewReport.BackColor = System.Drawing.Color.Black;
            this.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReport.ForeColor = System.Drawing.Color.Red;
            this.btnViewReport.Location = new System.Drawing.Point(650, 294);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(245, 44);
            this.btnViewReport.TabIndex = 7;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = false;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // btnName
            // 
            this.btnName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnName.BackColor = System.Drawing.Color.Black;
            this.btnName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnName.ForeColor = System.Drawing.Color.Red;
            this.btnName.Location = new System.Drawing.Point(842, 344);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(52, 23);
            this.btnName.TabIndex = 8;
            this.btnName.Text = "Search";
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbName.Location = new System.Drawing.Point(736, 346);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.Location = new System.Drawing.Point(666, 349);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 18);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Surname:";
            // 
            // tbl_StudentTableAdapter1
            // 
            this.tbl_StudentTableAdapter1.ClearBeforeFill = true;
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mitchell_School_Of_Music.Properties.Resources.rose_1905786_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 497);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn_EditDetails);
            this.Controls.Add(this.btn_AddDetails);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.DataStudentView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details | Mitchell School of Music";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentDetails_FormClosing);
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataStudentView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataStudentView;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btn_AddDetails;
        private System.Windows.Forms.Button btn_EditDetails;
        private System.Windows.Forms.Button btnDelete;
        private MitchellMusicDataSet mitchellMusicDBDataSet;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private MitchellMusicDataSetTableAdapters.tbl_StudentTableAdapter tbl_StudentTableAdapter;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Button btnViewReport;
        private MitchellMusicDBDataSet2 mitchellMusicDBDataSet2;
        private System.Windows.Forms.BindingSource tblStudentBindingSource1;
        private MitchellMusicDBDataSet2TableAdapters.tbl_StudentTableAdapter tbl_StudentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAddressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAddressLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPostcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentInstrumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentBlockStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instrument_Class;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pre_Pay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Classification;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
    }
}