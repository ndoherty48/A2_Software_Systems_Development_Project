namespace Mitchell_School_Of_Music.Forms
{
    partial class frmViewBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewBookings));
            this.tblLessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitchellMusicDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitchellMusicDBDataSet2 = new Mitchell_School_Of_Music.MitchellMusicDBDataSet2();
            this.tblLessonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvViewBookings = new System.Windows.Forms.DataGridView();
            this.lessonIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lesson_Allocated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lesson_Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lesson_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Absent_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLessonBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnTutor = new System.Windows.Forms.Button();
            this.lblTutor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStudent = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRoom = new System.Windows.Forms.Button();
            this.pctRefresh = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInstrumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tutorIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutor_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutor_Instrument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAddBooking = new System.Windows.Forms.Button();
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.btnAbsent = new System.Windows.Forms.Button();
            this.tbl_LessonTableAdapter = new Mitchell_School_Of_Music.MitchellMusicDBDataSet2TableAdapters.tbl_LessonTableAdapter();
            this.tbl_StudentTableAdapter = new Mitchell_School_Of_Music.MitchellMusicDBDataSet2TableAdapters.tbl_StudentTableAdapter();
            this.tbl_TutorTableAdapter = new Mitchell_School_Of_Music.MitchellMusicDBDataSet2TableAdapters.Tbl_TutorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLessonBindingSource
            // 
            this.tblLessonBindingSource.DataMember = "tbl_Lesson";
            this.tblLessonBindingSource.DataSource = this.mitchellMusicDBDataSet2BindingSource;
            // 
            // mitchellMusicDBDataSet2BindingSource
            // 
            this.mitchellMusicDBDataSet2BindingSource.DataSource = this.mitchellMusicDBDataSet2;
            this.mitchellMusicDBDataSet2BindingSource.Position = 0;
            // 
            // mitchellMusicDBDataSet2
            // 
            this.mitchellMusicDBDataSet2.DataSetName = "MitchellMusicDBDataSet2";
            this.mitchellMusicDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLessonBindingSource1
            // 
            this.tblLessonBindingSource1.DataMember = "tbl_Lesson";
            this.tblLessonBindingSource1.DataSource = this.mitchellMusicDBDataSet2BindingSource;
            // 
            // dgvViewBookings
            // 
            this.dgvViewBookings.AllowUserToAddRows = false;
            this.dgvViewBookings.AllowUserToDeleteRows = false;
            this.dgvViewBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewBookings.AutoGenerateColumns = false;
            this.dgvViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lessonIdDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.tutorIDDataGridViewTextBoxColumn,
            this.roomIDDataGridViewTextBoxColumn,
            this.Lesson_Allocated,
            this.Lesson_Day,
            this.Lesson_Time,
            this.Absent_Amount});
            this.dgvViewBookings.DataSource = this.tblLessonBindingSource2;
            this.dgvViewBookings.Location = new System.Drawing.Point(12, 12);
            this.dgvViewBookings.Name = "dgvViewBookings";
            this.dgvViewBookings.ReadOnly = true;
            this.dgvViewBookings.Size = new System.Drawing.Size(454, 403);
            this.dgvViewBookings.TabIndex = 0;
            this.dgvViewBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewBookings_CellClick);
            this.dgvViewBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewBookings_CellContentClick);
            // 
            // lessonIdDataGridViewTextBoxColumn
            // 
            this.lessonIdDataGridViewTextBoxColumn.DataPropertyName = "Lesson_Id";
            this.lessonIdDataGridViewTextBoxColumn.HeaderText = "Lesson ID";
            this.lessonIdDataGridViewTextBoxColumn.Name = "lessonIdDataGridViewTextBoxColumn";
            this.lessonIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tutorIDDataGridViewTextBoxColumn
            // 
            this.tutorIDDataGridViewTextBoxColumn.DataPropertyName = "Tutor_ID";
            this.tutorIDDataGridViewTextBoxColumn.HeaderText = "Tutor ID";
            this.tutorIDDataGridViewTextBoxColumn.Name = "tutorIDDataGridViewTextBoxColumn";
            this.tutorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "Room ID";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Lesson_Allocated
            // 
            this.Lesson_Allocated.DataPropertyName = "Lesson_Allocated";
            this.Lesson_Allocated.HeaderText = "Allocated";
            this.Lesson_Allocated.Name = "Lesson_Allocated";
            this.Lesson_Allocated.ReadOnly = true;
            // 
            // Lesson_Day
            // 
            this.Lesson_Day.DataPropertyName = "Lesson_Day";
            this.Lesson_Day.HeaderText = "Day";
            this.Lesson_Day.Name = "Lesson_Day";
            this.Lesson_Day.ReadOnly = true;
            // 
            // Lesson_Time
            // 
            this.Lesson_Time.DataPropertyName = "Lesson_Time";
            this.Lesson_Time.HeaderText = "Time";
            this.Lesson_Time.Name = "Lesson_Time";
            this.Lesson_Time.ReadOnly = true;
            // 
            // Absent_Amount
            // 
            this.Absent_Amount.DataPropertyName = "Absent_Amount";
            this.Absent_Amount.HeaderText = "Absent Amount";
            this.Absent_Amount.Name = "Absent_Amount";
            this.Absent_Amount.ReadOnly = true;
            // 
            // tblLessonBindingSource2
            // 
            this.tblLessonBindingSource2.DataMember = "tbl_Lesson";
            this.tblLessonBindingSource2.DataSource = this.mitchellMusicDBDataSet2BindingSource;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Image = global::Mitchell_School_Of_Music.Properties.Resources.logo3;
            this.pbLogo.Location = new System.Drawing.Point(472, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(245, 114);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // btnTutor
            // 
            this.btnTutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTutor.Location = new System.Drawing.Point(640, 153);
            this.btnTutor.Name = "btnTutor";
            this.btnTutor.Size = new System.Drawing.Size(75, 20);
            this.btnTutor.TabIndex = 5;
            this.btnTutor.Text = "Find";
            this.btnTutor.UseVisualStyleBackColor = true;
            this.btnTutor.Click += new System.EventHandler(this.btnTutor_Click);
            // 
            // lblTutor
            // 
            this.lblTutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTutor.AutoSize = true;
            this.lblTutor.BackColor = System.Drawing.Color.Transparent;
            this.lblTutor.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutor.ForeColor = System.Drawing.Color.White;
            this.lblTutor.Location = new System.Drawing.Point(473, 133);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(76, 18);
            this.lblTutor.TabIndex = 6;
            this.lblTutor.Text = "Tutor ID";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(472, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(472, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(473, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student ID";
            // 
            // btnStudent
            // 
            this.btnStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudent.Location = new System.Drawing.Point(640, 196);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(75, 20);
            this.btnStudent.TabIndex = 8;
            this.btnStudent.Text = "Find";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(472, 239);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(473, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Room ID";
            // 
            // btnRoom
            // 
            this.btnRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoom.Location = new System.Drawing.Point(640, 239);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(75, 20);
            this.btnRoom.TabIndex = 11;
            this.btnRoom.Text = "Find";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // pctRefresh
            // 
            this.pctRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctRefresh.BackColor = System.Drawing.Color.Transparent;
            this.pctRefresh.Image = global::Mitchell_School_Of_Music.Properties.Resources.refesh_504;
            this.pctRefresh.Location = new System.Drawing.Point(472, 265);
            this.pctRefresh.Name = "pctRefresh";
            this.pctRefresh.Size = new System.Drawing.Size(57, 43);
            this.pctRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRefresh.TabIndex = 15;
            this.pctRefresh.TabStop = false;
            this.pctRefresh.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn1,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.studentInstrumentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 415);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 139);
            this.dataGridView1.TabIndex = 16;
            // 
            // studentIdDataGridViewTextBoxColumn1
            // 
            this.studentIdDataGridViewTextBoxColumn1.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.studentIdDataGridViewTextBoxColumn1.Name = "studentIdDataGridViewTextBoxColumn1";
            this.studentIdDataGridViewTextBoxColumn1.Width = 25;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "Student_Surname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            // 
            // studentInstrumentDataGridViewTextBoxColumn
            // 
            this.studentInstrumentDataGridViewTextBoxColumn.DataPropertyName = "Student_Instrument";
            this.studentInstrumentDataGridViewTextBoxColumn.HeaderText = "Instrument";
            this.studentInstrumentDataGridViewTextBoxColumn.Name = "studentInstrumentDataGridViewTextBoxColumn";
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "tbl_Student";
            this.tblStudentBindingSource.DataSource = this.mitchellMusicDBDataSet2BindingSource;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tutorIdDataGridViewTextBoxColumn1,
            this.Tutor_Name,
            this.tutorSurnameDataGridViewTextBoxColumn,
            this.Tutor_Instrument});
            this.dataGridView2.DataSource = this.tblTutorBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 415);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(454, 139);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.Visible = false;
            // 
            // tutorIdDataGridViewTextBoxColumn1
            // 
            this.tutorIdDataGridViewTextBoxColumn1.DataPropertyName = "Tutor_Id";
            this.tutorIdDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.tutorIdDataGridViewTextBoxColumn1.Name = "tutorIdDataGridViewTextBoxColumn1";
            this.tutorIdDataGridViewTextBoxColumn1.Width = 25;
            // 
            // Tutor_Name
            // 
            this.Tutor_Name.DataPropertyName = "Tutor_Name";
            this.Tutor_Name.HeaderText = "Name";
            this.Tutor_Name.Name = "Tutor_Name";
            // 
            // tutorSurnameDataGridViewTextBoxColumn
            // 
            this.tutorSurnameDataGridViewTextBoxColumn.DataPropertyName = "Tutor_Surname";
            this.tutorSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.tutorSurnameDataGridViewTextBoxColumn.Name = "tutorSurnameDataGridViewTextBoxColumn";
            // 
            // Tutor_Instrument
            // 
            this.Tutor_Instrument.DataPropertyName = "Tutor_Instrument";
            this.Tutor_Instrument.HeaderText = "Instrument";
            this.Tutor_Instrument.Name = "Tutor_Instrument";
            // 
            // tblTutorBindingSource
            // 
            this.tblTutorBindingSource.DataMember = "Tbl_Tutor";
            this.tblTutorBindingSource.DataSource = this.mitchellMusicDBDataSet2BindingSource;
            // 
            // BtnAddBooking
            // 
            this.BtnAddBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddBooking.BackColor = System.Drawing.Color.Black;
            this.BtnAddBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddBooking.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddBooking.ForeColor = System.Drawing.Color.Red;
            this.BtnAddBooking.Location = new System.Drawing.Point(472, 315);
            this.BtnAddBooking.Name = "BtnAddBooking";
            this.BtnAddBooking.Size = new System.Drawing.Size(245, 54);
            this.BtnAddBooking.TabIndex = 18;
            this.BtnAddBooking.Text = "New Booking";
            this.BtnAddBooking.UseVisualStyleBackColor = false;
            this.BtnAddBooking.Click += new System.EventHandler(this.BtnAddBooking_Click);
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditBooking.BackColor = System.Drawing.Color.Black;
            this.btnEditBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBooking.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBooking.ForeColor = System.Drawing.Color.Red;
            this.btnEditBooking.Location = new System.Drawing.Point(472, 375);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(245, 54);
            this.btnEditBooking.TabIndex = 19;
            this.btnEditBooking.Text = "Edit Booking";
            this.btnEditBooking.UseVisualStyleBackColor = false;
            this.btnEditBooking.Click += new System.EventHandler(this.btnEditBooking_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBooking.BackColor = System.Drawing.Color.Black;
            this.btnDeleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBooking.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBooking.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteBooking.Location = new System.Drawing.Point(472, 435);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(245, 54);
            this.btnDeleteBooking.TabIndex = 20;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = false;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // pbHome
            // 
            this.pbHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHome.BackColor = System.Drawing.Color.Transparent;
            this.pbHome.BackgroundImage = global::Mitchell_School_Of_Music.Properties.Resources.home_150499_1280;
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHome.Image = global::Mitchell_School_Of_Music.Properties.Resources.home_150499_1280;
            this.pbHome.Location = new System.Drawing.Point(640, 485);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(88, 69);
            this.pbHome.TabIndex = 21;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // btnAbsent
            // 
            this.btnAbsent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbsent.BackColor = System.Drawing.Color.Black;
            this.btnAbsent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsent.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnAbsent.ForeColor = System.Drawing.Color.Red;
            this.btnAbsent.Location = new System.Drawing.Point(598, 266);
            this.btnAbsent.Name = "btnAbsent";
            this.btnAbsent.Size = new System.Drawing.Size(117, 43);
            this.btnAbsent.TabIndex = 22;
            this.btnAbsent.Text = "Absent";
            this.btnAbsent.UseVisualStyleBackColor = false;
            this.btnAbsent.Click += new System.EventHandler(this.btnAbsent_Click);
            // 
            // tbl_LessonTableAdapter
            // 
            this.tbl_LessonTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_StudentTableAdapter
            // 
            this.tbl_StudentTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_TutorTableAdapter
            // 
            this.tbl_TutorTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mitchell_School_Of_Music.Properties.Resources.rose_1905786_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 553);
            this.Controls.Add(this.btnAbsent);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.btnEditBooking);
            this.Controls.Add(this.BtnAddBooking);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pctRefresh);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRoom);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTutor);
            this.Controls.Add(this.btnTutor);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.dgvViewBookings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookings | Mitchell School of Music";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewBookings_FormClosing);
            this.Load += new System.EventHandler(this.frmViewBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource mitchellMusicDBDataSet2BindingSource;
        private MitchellMusicDBDataSet2 mitchellMusicDBDataSet2;
        private System.Windows.Forms.BindingSource tblLessonBindingSource;
        private MitchellMusicDBDataSet2TableAdapters.tbl_LessonTableAdapter tbl_LessonTableAdapter;
        private System.Windows.Forms.BindingSource tblLessonBindingSource1;
        private System.Windows.Forms.DataGridView dgvViewBookings;
        private System.Windows.Forms.BindingSource tblLessonBindingSource2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnTutor;
        private System.Windows.Forms.Label lblTutor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.PictureBox pctRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private MitchellMusicDBDataSet2TableAdapters.tbl_StudentTableAdapter tbl_StudentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentInstrumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tblTutorBindingSource;
        private MitchellMusicDBDataSet2TableAdapters.Tbl_TutorTableAdapter tbl_TutorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnAddBooking;
        private System.Windows.Forms.Button btnEditBooking;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutor_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutor_Instrument;
        private System.Windows.Forms.Button btnAbsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lesson_Allocated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lesson_Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lesson_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Absent_Amount;
    }
}