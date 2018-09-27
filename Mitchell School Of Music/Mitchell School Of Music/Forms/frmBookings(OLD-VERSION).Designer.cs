namespace Mitchell_School_Of_Music.Forms
{
    partial class frmBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookings));
            this.tblRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitchellMusicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitchellMusicDataSet = new Mitchell_School_Of_Music.MitchellMusicDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInstrumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRoomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tutorIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutor_Instrument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cboAllocated = new System.Windows.Forms.ComboBox();
            this.lblAllocated = new System.Windows.Forms.Label();
            this.cboDay = new System.Windows.Forms.ComboBox();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblLessonsBooked = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbl_RoomTableAdapter = new Mitchell_School_Of_Music.MitchellMusicDataSetTableAdapters.Tbl_RoomTableAdapter();
            this.tbl_StudentTableAdapter = new Mitchell_School_Of_Music.MitchellMusicDataSetTableAdapters.tbl_StudentTableAdapter();
            this.tbl_TutorTableAdapter = new Mitchell_School_Of_Music.MitchellMusicDataSetTableAdapters.Tbl_TutorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // tblRoomBindingSource
            // 
            this.tblRoomBindingSource.DataMember = "Tbl_Room";
            this.tblRoomBindingSource.DataSource = this.mitchellMusicDataSetBindingSource;
            // 
            // mitchellMusicDataSetBindingSource
            // 
            this.mitchellMusicDataSetBindingSource.DataSource = this.mitchellMusicDataSet;
            this.mitchellMusicDataSetBindingSource.Position = 0;
            // 
            // mitchellMusicDataSet
            // 
            this.mitchellMusicDataSet.DataSetName = "MitchellMusicDataSet";
            this.mitchellMusicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.studentInstrumentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(429, 94);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "Student_Surname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            this.studentSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentInstrumentDataGridViewTextBoxColumn
            // 
            this.studentInstrumentDataGridViewTextBoxColumn.DataPropertyName = "Student_Instrument";
            this.studentInstrumentDataGridViewTextBoxColumn.HeaderText = "Instrument";
            this.studentInstrumentDataGridViewTextBoxColumn.Name = "studentInstrumentDataGridViewTextBoxColumn";
            this.studentInstrumentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "tbl_Student";
            this.tblStudentBindingSource.DataSource = this.mitchellMusicDataSetBindingSource;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumberDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.roomLocationDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblRoomBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 264);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(429, 94);
            this.dataGridView2.TabIndex = 1;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "Room_Number";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "Room_Type";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomLocationDataGridViewTextBoxColumn
            // 
            this.roomLocationDataGridViewTextBoxColumn.DataPropertyName = "Room_Location";
            this.roomLocationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.roomLocationDataGridViewTextBoxColumn.Name = "roomLocationDataGridViewTextBoxColumn";
            this.roomLocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblRoomBindingSource1
            // 
            this.tblRoomBindingSource1.DataMember = "Tbl_Room";
            this.tblRoomBindingSource1.DataSource = this.mitchellMusicDataSetBindingSource;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tutorIdDataGridViewTextBoxColumn1,
            this.tutorNameDataGridViewTextBoxColumn,
            this.tutorSurnameDataGridViewTextBoxColumn,
            this.Tutor_Instrument});
            this.dataGridView3.DataSource = this.tblTutorBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 143);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(429, 102);
            this.dataGridView3.TabIndex = 2;
            // 
            // tutorIdDataGridViewTextBoxColumn1
            // 
            this.tutorIdDataGridViewTextBoxColumn1.DataPropertyName = "Tutor_Id";
            this.tutorIdDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.tutorIdDataGridViewTextBoxColumn1.Name = "tutorIdDataGridViewTextBoxColumn1";
            this.tutorIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tutorIdDataGridViewTextBoxColumn1.Width = 50;
            // 
            // tutorNameDataGridViewTextBoxColumn
            // 
            this.tutorNameDataGridViewTextBoxColumn.DataPropertyName = "Tutor_Name";
            this.tutorNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.tutorNameDataGridViewTextBoxColumn.Name = "tutorNameDataGridViewTextBoxColumn";
            this.tutorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tutorSurnameDataGridViewTextBoxColumn
            // 
            this.tutorSurnameDataGridViewTextBoxColumn.DataPropertyName = "Tutor_Surname";
            this.tutorSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.tutorSurnameDataGridViewTextBoxColumn.Name = "tutorSurnameDataGridViewTextBoxColumn";
            this.tutorSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Tutor_Instrument
            // 
            this.Tutor_Instrument.DataPropertyName = "Tutor_Instrument";
            this.Tutor_Instrument.HeaderText = "Instrument";
            this.Tutor_Instrument.Name = "Tutor_Instrument";
            this.Tutor_Instrument.ReadOnly = true;
            // 
            // tblTutorBindingSource
            // 
            this.tblTutorBindingSource.DataMember = "Tbl_Tutor";
            this.tblTutorBindingSource.DataSource = this.mitchellMusicDataSetBindingSource;
            // 
            // pbHome
            // 
            this.pbHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHome.BackColor = System.Drawing.Color.Transparent;
            this.pbHome.BackgroundImage = global::Mitchell_School_Of_Music.Properties.Resources.home_150499_1280;
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHome.Image = global::Mitchell_School_Of_Music.Properties.Resources.home_150499_1280;
            this.pbHome.Location = new System.Drawing.Point(617, 457);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(88, 69);
            this.pbHome.TabIndex = 7;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tutor";
            // 
            // lblRoom
            // 
            this.lblRoom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRoom.AutoSize = true;
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.Color.White;
            this.lblRoom.Location = new System.Drawing.Point(12, 245);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(49, 16);
            this.lblRoom.TabIndex = 10;
            this.lblRoom.Text = "Room";
            // 
            // cboAllocated
            // 
            this.cboAllocated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAllocated.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAllocated.FormattingEnabled = true;
            this.cboAllocated.Items.AddRange(new object[] {
            "Block 1 (January - March)",
            "Block 2 (March - June)",
            "Block 3 (September - December)"});
            this.cboAllocated.Location = new System.Drawing.Point(211, 364);
            this.cboAllocated.Name = "cboAllocated";
            this.cboAllocated.Size = new System.Drawing.Size(230, 21);
            this.cboAllocated.TabIndex = 11;
            // 
            // lblAllocated
            // 
            this.lblAllocated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAllocated.AutoSize = true;
            this.lblAllocated.BackColor = System.Drawing.Color.Transparent;
            this.lblAllocated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllocated.ForeColor = System.Drawing.Color.White;
            this.lblAllocated.Location = new System.Drawing.Point(12, 365);
            this.lblAllocated.Name = "lblAllocated";
            this.lblAllocated.Size = new System.Drawing.Size(117, 16);
            this.lblAllocated.TabIndex = 12;
            this.lblAllocated.Text = "Block Allocated";
            // 
            // cboDay
            // 
            this.cboDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDay.FormattingEnabled = true;
            this.cboDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cboDay.Location = new System.Drawing.Point(211, 391);
            this.cboDay.Name = "cboDay";
            this.cboDay.Size = new System.Drawing.Size(230, 21);
            this.cboDay.TabIndex = 13;
            // 
            // cboTime
            // 
            this.cboTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "13:00-13:30",
            "13:30-14:00",
            "14:00-14:30",
            "14:40-15:00",
            "15:00-15:30",
            "15:30-16:00",
            "16:00-16:30",
            "16:30-17:00",
            "17:00-17:30",
            "17:30-18:00",
            "18:00-18:30",
            "18:30-19:00",
            "19:00-19:30",
            "19:30-20:00",
            "20:00-20:30",
            "20:30-21:00"});
            this.cboTime.Location = new System.Drawing.Point(211, 418);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(230, 21);
            this.cboTime.TabIndex = 14;
            // 
            // lblDay
            // 
            this.lblDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(12, 391);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(90, 16);
            this.lblDay.TabIndex = 15;
            this.lblDay.Text = "Lesson Day";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(12, 418);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(97, 16);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "Lesson Time";
            // 
            // lblLessonsBooked
            // 
            this.lblLessonsBooked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLessonsBooked.AutoSize = true;
            this.lblLessonsBooked.BackColor = System.Drawing.Color.Transparent;
            this.lblLessonsBooked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLessonsBooked.ForeColor = System.Drawing.Color.White;
            this.lblLessonsBooked.Location = new System.Drawing.Point(12, 445);
            this.lblLessonsBooked.Name = "lblLessonsBooked";
            this.lblLessonsBooked.Size = new System.Drawing.Size(128, 16);
            this.lblLessonsBooked.TabIndex = 17;
            this.lblLessonsBooked.Text = "Lesson\'s Booked";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10",
            "20",
            "30"});
            this.comboBox1.Location = new System.Drawing.Point(211, 445);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // lblPayment
            // 
            this.lblPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.White;
            this.lblPayment.Location = new System.Drawing.Point(443, 9);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(111, 16);
            this.lblPayment.TabIndex = 19;
            this.lblPayment.Text = "Payment Made";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Full Payment",
            "Partial Payment",
            "No Payment"});
            this.comboBox2.Location = new System.Drawing.Point(447, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(258, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(447, 61);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(123, 16);
            this.lblAmount.TabIndex = 21;
            this.lblAmount.Text = "Payment Amount";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(447, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(446, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 52);
            this.button1.TabIndex = 23;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(446, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 52);
            this.button2.TabIndex = 24;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(446, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(259, 52);
            this.button3.TabIndex = 25;
            this.button3.Text = "Terminate Booking";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(633, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "When Editing Data you can only edit Day, Time, No of Lessons, Payment Type And Am" +
    "ount";
            // 
            // tbl_RoomTableAdapter
            // 
            this.tbl_RoomTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_StudentTableAdapter
            // 
            this.tbl_StudentTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_TutorTableAdapter
            // 
            this.tbl_TutorTableAdapter.ClearBeforeFill = true;
            // 
            // frmBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mitchell_School_Of_Music.Properties.Resources.rose_1905786_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 545);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblLessonsBooked);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.cboTime);
            this.Controls.Add(this.cboDay);
            this.Controls.Add(this.lblAllocated);
            this.Controls.Add(this.cboAllocated);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookings | Mitchell School of Music";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBookings_FormClosing);
            this.Load += new System.EventHandler(this.frmTimetables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource mitchellMusicDataSetBindingSource;
        private MitchellMusicDataSet mitchellMusicDataSet;
        private System.Windows.Forms.BindingSource tblRoomBindingSource;
        private MitchellMusicDataSetTableAdapters.Tbl_RoomTableAdapter tbl_RoomTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cboAllocated;
        private System.Windows.Forms.Label lblAllocated;
        private System.Windows.Forms.ComboBox cboDay;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblLessonsBooked;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private MitchellMusicDataSetTableAdapters.tbl_StudentTableAdapter tbl_StudentTableAdapter;
        private System.Windows.Forms.BindingSource tblTutorBindingSource;
        private MitchellMusicDataSetTableAdapters.Tbl_TutorTableAdapter tbl_TutorTableAdapter;
        private System.Windows.Forms.BindingSource tblRoomBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutor_Instrument;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentInstrumentDataGridViewTextBoxColumn;
    }
}