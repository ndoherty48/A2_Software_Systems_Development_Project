namespace Mitchell_School_Of_Music.Forms
{
    partial class frmAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStudent));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Surname = new System.Windows.Forms.TextBox();
            this.tb_Address2 = new System.Windows.Forms.TextBox();
            this.tb_Address1 = new System.Windows.Forms.TextBox();
            this.tb_Tutor = new System.Windows.Forms.TextBox();
            this.tb_Instrument = new System.Windows.Forms.TextBox();
            this.cbo_Status = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lbl_Address1 = new System.Windows.Forms.Label();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.lbl_Postcode = new System.Windows.Forms.Label();
            this.lbl_Address2 = new System.Windows.Forms.Label();
            this.lbl_Instrument = new System.Windows.Forms.Label();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbl_Tutor = new System.Windows.Forms.Label();
            this.lblBlockStart = new System.Windows.Forms.Label();
            this.tb_Postcode = new System.Windows.Forms.MaskedTextBox();
            this.tb_Tel = new System.Windows.Forms.MaskedTextBox();
            this.tb_Start = new System.Windows.Forms.MaskedTextBox();
            this.tblTutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitchellMusicDataSet = new Mitchell_School_Of_Music.MitchellMusicDataSet();
            this.tbl_TutorTableAdapter = new Mitchell_School_Of_Music.MitchellMusicDataSetTableAdapters.Tbl_TutorTableAdapter();
            this.lblClass = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.lblPrePaid = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblStudentClass = new System.Windows.Forms.Label();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblTutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(330, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "New Student Details";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(180, 52);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.ReadOnly = true;
            this.tb_ID.Size = new System.Drawing.Size(162, 20);
            this.tb_ID.TabIndex = 1;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(180, 78);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(162, 20);
            this.tb_Name.TabIndex = 2;
            // 
            // tb_Surname
            // 
            this.tb_Surname.Location = new System.Drawing.Point(180, 104);
            this.tb_Surname.Name = "tb_Surname";
            this.tb_Surname.Size = new System.Drawing.Size(162, 20);
            this.tb_Surname.TabIndex = 3;
            // 
            // tb_Address2
            // 
            this.tb_Address2.Location = new System.Drawing.Point(180, 156);
            this.tb_Address2.Name = "tb_Address2";
            this.tb_Address2.Size = new System.Drawing.Size(162, 20);
            this.tb_Address2.TabIndex = 5;
            // 
            // tb_Address1
            // 
            this.tb_Address1.Location = new System.Drawing.Point(180, 130);
            this.tb_Address1.Name = "tb_Address1";
            this.tb_Address1.Size = new System.Drawing.Size(162, 20);
            this.tb_Address1.TabIndex = 4;
            // 
            // tb_Tutor
            // 
            this.tb_Tutor.Location = new System.Drawing.Point(180, 260);
            this.tb_Tutor.Name = "tb_Tutor";
            this.tb_Tutor.Size = new System.Drawing.Size(162, 20);
            this.tb_Tutor.TabIndex = 9;
            this.tb_Tutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Tutor_KeyPress);
            // 
            // tb_Instrument
            // 
            this.tb_Instrument.Location = new System.Drawing.Point(180, 234);
            this.tb_Instrument.Name = "tb_Instrument";
            this.tb_Instrument.Size = new System.Drawing.Size(162, 20);
            this.tb_Instrument.TabIndex = 8;
            // 
            // cbo_Status
            // 
            this.cbo_Status.FormattingEnabled = true;
            this.cbo_Status.Items.AddRange(new object[] {
            "Enrolled",
            "Waiting List"});
            this.cbo_Status.Location = new System.Drawing.Point(180, 287);
            this.cbo_Status.Name = "cbo_Status";
            this.cbo_Status.Size = new System.Drawing.Size(162, 21);
            this.cbo_Status.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Red;
            this.btnSave.Location = new System.Drawing.Point(180, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 61);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(12, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 61);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_ID.Location = new System.Drawing.Point(12, 52);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(87, 20);
            this.lbl_ID.TabIndex = 15;
            this.lbl_ID.Text = "Student ID";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.White;
            this.lblStudentName.Location = new System.Drawing.Point(12, 78);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(112, 20);
            this.lblStudentName.TabIndex = 16;
            this.lblStudentName.Text = "Student Name";
            // 
            // lbl_Address1
            // 
            this.lbl_Address1.AutoSize = true;
            this.lbl_Address1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Address1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address1.ForeColor = System.Drawing.Color.White;
            this.lbl_Address1.Location = new System.Drawing.Point(12, 130);
            this.lbl_Address1.Name = "lbl_Address1";
            this.lbl_Address1.Size = new System.Drawing.Size(142, 20);
            this.lbl_Address1.TabIndex = 18;
            this.lbl_Address1.Text = "Student Address 1";
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentSurname.ForeColor = System.Drawing.Color.White;
            this.lblStudentSurname.Location = new System.Drawing.Point(12, 104);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(135, 20);
            this.lblStudentSurname.TabIndex = 17;
            this.lblStudentSurname.Text = "Student Surname";
            // 
            // lbl_Postcode
            // 
            this.lbl_Postcode.AutoSize = true;
            this.lbl_Postcode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Postcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Postcode.ForeColor = System.Drawing.Color.White;
            this.lbl_Postcode.Location = new System.Drawing.Point(12, 182);
            this.lbl_Postcode.Name = "lbl_Postcode";
            this.lbl_Postcode.Size = new System.Drawing.Size(137, 20);
            this.lbl_Postcode.TabIndex = 20;
            this.lbl_Postcode.Text = "Student Postcode";
            // 
            // lbl_Address2
            // 
            this.lbl_Address2.AutoSize = true;
            this.lbl_Address2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Address2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address2.ForeColor = System.Drawing.Color.White;
            this.lbl_Address2.Location = new System.Drawing.Point(12, 156);
            this.lbl_Address2.Name = "lbl_Address2";
            this.lbl_Address2.Size = new System.Drawing.Size(142, 20);
            this.lbl_Address2.TabIndex = 19;
            this.lbl_Address2.Text = "Student Address 2";
            // 
            // lbl_Instrument
            // 
            this.lbl_Instrument.AutoSize = true;
            this.lbl_Instrument.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Instrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instrument.ForeColor = System.Drawing.Color.White;
            this.lbl_Instrument.Location = new System.Drawing.Point(12, 234);
            this.lbl_Instrument.Name = "lbl_Instrument";
            this.lbl_Instrument.Size = new System.Drawing.Size(147, 20);
            this.lbl_Instrument.TabIndex = 22;
            this.lbl_Instrument.Text = "Student Instrument";
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tel.ForeColor = System.Drawing.Color.White;
            this.lbl_Tel.Location = new System.Drawing.Point(12, 208);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(91, 20);
            this.lbl_Tel.TabIndex = 21;
            this.lbl_Tel.Text = "Student Tel";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(12, 286);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(117, 20);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Student Status";
            // 
            // lbl_Tutor
            // 
            this.lbl_Tutor.AutoSize = true;
            this.lbl_Tutor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tutor.ForeColor = System.Drawing.Color.White;
            this.lbl_Tutor.Location = new System.Drawing.Point(12, 260);
            this.lbl_Tutor.Name = "lbl_Tutor";
            this.lbl_Tutor.Size = new System.Drawing.Size(67, 20);
            this.lbl_Tutor.TabIndex = 23;
            this.lbl_Tutor.Text = "Tutor ID";
            // 
            // lblBlockStart
            // 
            this.lblBlockStart.AutoSize = true;
            this.lblBlockStart.BackColor = System.Drawing.Color.Transparent;
            this.lblBlockStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockStart.ForeColor = System.Drawing.Color.White;
            this.lblBlockStart.Location = new System.Drawing.Point(12, 314);
            this.lblBlockStart.Name = "lblBlockStart";
            this.lblBlockStart.Size = new System.Drawing.Size(148, 20);
            this.lblBlockStart.TabIndex = 25;
            this.lblBlockStart.Text = "Student Block Start";
            // 
            // tb_Postcode
            // 
            this.tb_Postcode.Location = new System.Drawing.Point(180, 183);
            this.tb_Postcode.Mask = "BT00-0LL";
            this.tb_Postcode.Name = "tb_Postcode";
            this.tb_Postcode.Size = new System.Drawing.Size(162, 20);
            this.tb_Postcode.TabIndex = 6;
            // 
            // tb_Tel
            // 
            this.tb_Tel.Location = new System.Drawing.Point(180, 208);
            this.tb_Tel.Mask = "00000000000";
            this.tb_Tel.Name = "tb_Tel";
            this.tb_Tel.Size = new System.Drawing.Size(162, 20);
            this.tb_Tel.TabIndex = 7;
            // 
            // tb_Start
            // 
            this.tb_Start.Location = new System.Drawing.Point(180, 314);
            this.tb_Start.Mask = "00/00/0000";
            this.tb_Start.Name = "tb_Start";
            this.tb_Start.Size = new System.Drawing.Size(162, 20);
            this.tb_Start.TabIndex = 11;
            // 
            // tblTutorBindingSource
            // 
            this.tblTutorBindingSource.DataMember = "Tbl_Tutor";
            this.tblTutorBindingSource.DataSource = this.mitchellMusicDataSet;
            // 
            // mitchellMusicDataSet
            // 
            this.mitchellMusicDataSet.DataSetName = "MitchellMusicDataSet";
            this.mitchellMusicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_TutorTableAdapter
            // 
            this.tbl_TutorTableAdapter.ClearBeforeFill = true;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.Transparent;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.Color.White;
            this.lblClass.Location = new System.Drawing.Point(12, 341);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(129, 20);
            this.lblClass.TabIndex = 26;
            this.lblClass.Text = "Instrument Class";
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Items.AddRange(new object[] {
            "String",
            "Woodwind",
            "Percussion",
            "Singing"});
            this.cboClass.Location = new System.Drawing.Point(181, 340);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(162, 21);
            this.cboClass.TabIndex = 27;
            // 
            // lblPrePaid
            // 
            this.lblPrePaid.AutoSize = true;
            this.lblPrePaid.BackColor = System.Drawing.Color.Transparent;
            this.lblPrePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrePaid.ForeColor = System.Drawing.Color.White;
            this.lblPrePaid.Location = new System.Drawing.Point(12, 361);
            this.lblPrePaid.Name = "lblPrePaid";
            this.lblPrePaid.Size = new System.Drawing.Size(68, 20);
            this.lblPrePaid.TabIndex = 28;
            this.lblPrePaid.Text = "Pre Paid";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(181, 364);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 17);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Yes";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // lblStudentClass
            // 
            this.lblStudentClass.AutoSize = true;
            this.lblStudentClass.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentClass.ForeColor = System.Drawing.Color.White;
            this.lblStudentClass.Location = new System.Drawing.Point(12, 381);
            this.lblStudentClass.Name = "lblStudentClass";
            this.lblStudentClass.Size = new System.Drawing.Size(163, 20);
            this.lblStudentClass.TabIndex = 30;
            this.lblStudentClass.Text = "Student Classification";
            // 
            // cboLevel
            // 
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "Initial (Beginner)",
            "Grade 1 (Beginner)",
            "Grade 2 (Beginner)",
            "Grade 3 (Intermediate)",
            "Grade 4 (Intermediate)",
            "Grade 5 (Intermediate)",
            "Grade 6 (Advanced)",
            "Grade 7 (Advanced)",
            "Grade 8 (Advanced)",
            "Diploma"});
            this.cboLevel.Location = new System.Drawing.Point(180, 380);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(162, 21);
            this.cboLevel.TabIndex = 31;
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(355, 466);
            this.Controls.Add(this.cboLevel);
            this.Controls.Add(this.lblStudentClass);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblPrePaid);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.tb_Start);
            this.Controls.Add(this.tb_Tel);
            this.Controls.Add(this.tb_Postcode);
            this.Controls.Add(this.lblBlockStart);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lbl_Tutor);
            this.Controls.Add(this.lbl_Instrument);
            this.Controls.Add(this.lbl_Tel);
            this.Controls.Add(this.lbl_Postcode);
            this.Controls.Add(this.lbl_Address2);
            this.Controls.Add(this.lbl_Address1);
            this.Controls.Add(this.lblStudentSurname);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbo_Status);
            this.Controls.Add(this.tb_Tutor);
            this.Controls.Add(this.tb_Instrument);
            this.Controls.Add(this.tb_Address2);
            this.Controls.Add(this.tb_Address1);
            this.Controls.Add(this.tb_Surname);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Student | Mitchell School of Music";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddStudent_FormClosing);
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblTutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.ComboBox cbo_Status;
        private System.Windows.Forms.TextBox tb_Instrument;
        private System.Windows.Forms.TextBox tb_Tutor;
        private System.Windows.Forms.TextBox tb_Address1;
        private System.Windows.Forms.TextBox tb_Address2;
        private System.Windows.Forms.TextBox tb_Surname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lbl_Address1;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.Label lbl_Postcode;
        private System.Windows.Forms.Label lbl_Address2;
        private System.Windows.Forms.Label lbl_Instrument;
        private System.Windows.Forms.Label lbl_Tel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lbl_Tutor;
        private System.Windows.Forms.Label lblBlockStart;
        private System.Windows.Forms.MaskedTextBox tb_Postcode;
        private System.Windows.Forms.MaskedTextBox tb_Tel;
        private System.Windows.Forms.MaskedTextBox tb_Start;
        private MitchellMusicDataSet mitchellMusicDataSet;
        private System.Windows.Forms.BindingSource tblTutorBindingSource;
        private MitchellMusicDataSetTableAdapters.Tbl_TutorTableAdapter tbl_TutorTableAdapter;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label lblPrePaid;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblStudentClass;
        private System.Windows.Forms.ComboBox cboLevel;
    }
}