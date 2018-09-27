namespace Mitchell_School_Of_Music.Forms
{
    partial class Tutor_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutor_Details));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btn_EditDetails = new System.Windows.Forms.Button();
            this.btn_AddDetails = new System.Windows.Forms.Button();
            this.DataTutorView = new System.Windows.Forms.DataGridView();
            this.tutorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorAddressLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorAddressLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorPostcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorInstrumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTutorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mitchellMusicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitchellMusicDataSet = new Mitchell_School_Of_Music.MitchellMusicDataSet();
            this.tblTutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitchellMusicDBDataSet1 = new Mitchell_School_Of_Music.MitchellMusicDataSet();
            this.mitchellMusicDBDataSet = new Mitchell_School_Of_Music.MitchellMusicDataSet();
            this.mitchellMusicDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_TutorTableAdapter = new Mitchell_School_Of_Music.MitchellMusicDataSetTableAdapters.Tbl_TutorTableAdapter();
            this.tbl_TutorTableAdapter1 = new Mitchell_School_Of_Music.MitchellMusicDataSetTableAdapters.Tbl_TutorTableAdapter();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTutorView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTutorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(657, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(245, 44);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete Tutor";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn_EditDetails
            // 
            this.btn_EditDetails.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_EditDetails.BackColor = System.Drawing.Color.Black;
            this.btn_EditDetails.Enabled = false;
            this.btn_EditDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditDetails.ForeColor = System.Drawing.Color.Red;
            this.btn_EditDetails.Location = new System.Drawing.Point(657, 198);
            this.btn_EditDetails.Name = "btn_EditDetails";
            this.btn_EditDetails.Size = new System.Drawing.Size(245, 44);
            this.btn_EditDetails.TabIndex = 11;
            this.btn_EditDetails.Text = "Edit Tutor";
            this.btn_EditDetails.UseVisualStyleBackColor = false;
            this.btn_EditDetails.Click += new System.EventHandler(this.btn_EditDetails_Click);
            // 
            // btn_AddDetails
            // 
            this.btn_AddDetails.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_AddDetails.BackColor = System.Drawing.Color.Black;
            this.btn_AddDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddDetails.ForeColor = System.Drawing.Color.Red;
            this.btn_AddDetails.Location = new System.Drawing.Point(657, 148);
            this.btn_AddDetails.Name = "btn_AddDetails";
            this.btn_AddDetails.Size = new System.Drawing.Size(245, 44);
            this.btn_AddDetails.TabIndex = 10;
            this.btn_AddDetails.Text = "Add Tutor";
            this.btn_AddDetails.UseVisualStyleBackColor = false;
            this.btn_AddDetails.Click += new System.EventHandler(this.btn_AddDetails_Click);
            // 
            // DataTutorView
            // 
            this.DataTutorView.AllowUserToAddRows = false;
            this.DataTutorView.AllowUserToDeleteRows = false;
            this.DataTutorView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTutorView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTutorView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataTutorView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTutorView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tutorIdDataGridViewTextBoxColumn,
            this.tutorNameDataGridViewTextBoxColumn,
            this.tutorSurnameDataGridViewTextBoxColumn,
            this.tutorAddressLine1DataGridViewTextBoxColumn,
            this.tutorAddressLine2DataGridViewTextBoxColumn,
            this.tutorPostcodeDataGridViewTextBoxColumn,
            this.tutorTelDataGridViewTextBoxColumn,
            this.tutorInstrumentDataGridViewTextBoxColumn,
            this.tutorDOBDataGridViewTextBoxColumn});
            this.DataTutorView.DataSource = this.tblTutorBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataTutorView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataTutorView.Location = new System.Drawing.Point(12, 13);
            this.DataTutorView.Name = "DataTutorView";
            this.DataTutorView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTutorView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataTutorView.Size = new System.Drawing.Size(638, 472);
            this.DataTutorView.TabIndex = 8;
            this.DataTutorView.Visible = false;
            // 
            // tutorIdDataGridViewTextBoxColumn
            // 
            this.tutorIdDataGridViewTextBoxColumn.DataPropertyName = "Tutor_Id";
            this.tutorIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.tutorIdDataGridViewTextBoxColumn.Name = "tutorIdDataGridViewTextBoxColumn";
            this.tutorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tutorIdDataGridViewTextBoxColumn.Width = 25;
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
            // tutorAddressLine1DataGridViewTextBoxColumn
            // 
            this.tutorAddressLine1DataGridViewTextBoxColumn.DataPropertyName = "Tutor_Address_Line_1";
            this.tutorAddressLine1DataGridViewTextBoxColumn.HeaderText = "Address 1";
            this.tutorAddressLine1DataGridViewTextBoxColumn.Name = "tutorAddressLine1DataGridViewTextBoxColumn";
            this.tutorAddressLine1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tutorAddressLine2DataGridViewTextBoxColumn
            // 
            this.tutorAddressLine2DataGridViewTextBoxColumn.DataPropertyName = "Tutor_Address_Line_2";
            this.tutorAddressLine2DataGridViewTextBoxColumn.HeaderText = "Address 2";
            this.tutorAddressLine2DataGridViewTextBoxColumn.Name = "tutorAddressLine2DataGridViewTextBoxColumn";
            this.tutorAddressLine2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tutorPostcodeDataGridViewTextBoxColumn
            // 
            this.tutorPostcodeDataGridViewTextBoxColumn.DataPropertyName = "Tutor_Postcode";
            this.tutorPostcodeDataGridViewTextBoxColumn.HeaderText = "Postcode";
            this.tutorPostcodeDataGridViewTextBoxColumn.Name = "tutorPostcodeDataGridViewTextBoxColumn";
            this.tutorPostcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tutorTelDataGridViewTextBoxColumn
            // 
            this.tutorTelDataGridViewTextBoxColumn.DataPropertyName = "Tutor_Tel";
            this.tutorTelDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.tutorTelDataGridViewTextBoxColumn.Name = "tutorTelDataGridViewTextBoxColumn";
            this.tutorTelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tutorInstrumentDataGridViewTextBoxColumn
            // 
            this.tutorInstrumentDataGridViewTextBoxColumn.DataPropertyName = "Tutor_Instrument";
            this.tutorInstrumentDataGridViewTextBoxColumn.HeaderText = "Instrument";
            this.tutorInstrumentDataGridViewTextBoxColumn.Name = "tutorInstrumentDataGridViewTextBoxColumn";
            this.tutorInstrumentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tutorDOBDataGridViewTextBoxColumn
            // 
            this.tutorDOBDataGridViewTextBoxColumn.DataPropertyName = "Tutor_DOB";
            this.tutorDOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.tutorDOBDataGridViewTextBoxColumn.Name = "tutorDOBDataGridViewTextBoxColumn";
            this.tutorDOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblTutorBindingSource1
            // 
            this.tblTutorBindingSource1.DataMember = "Tbl_Tutor";
            this.tblTutorBindingSource1.DataSource = this.mitchellMusicDataSetBindingSource;
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
            // tblTutorBindingSource
            // 
            this.tblTutorBindingSource.DataMember = "Tbl_Tutor";
            this.tblTutorBindingSource.DataSource = this.mitchellMusicDBDataSet1;
            // 
            // mitchellMusicDBDataSet1
            // 
            this.mitchellMusicDBDataSet1.DataSetName = "MitchellMusicDBDataSet1";
            this.mitchellMusicDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mitchellMusicDBDataSet
            // 
            this.mitchellMusicDBDataSet.DataSetName = "MitchellMusicDBDataSet";
            this.mitchellMusicDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mitchellMusicDBDataSetBindingSource
            // 
            this.mitchellMusicDBDataSetBindingSource.DataSource = this.mitchellMusicDBDataSet;
            this.mitchellMusicDBDataSetBindingSource.Position = 0;
            // 
            // tbl_TutorTableAdapter
            // 
            this.tbl_TutorTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_TutorTableAdapter1
            // 
            this.tbl_TutorTableAdapter1.ClearBeforeFill = true;
            // 
            // pbHome
            // 
            this.pbHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHome.BackColor = System.Drawing.Color.Transparent;
            this.pbHome.BackgroundImage = global::Mitchell_School_Of_Music.Properties.Resources.home_150499_1280;
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHome.Image = global::Mitchell_School_Of_Music.Properties.Resources.home_150499_1280;
            this.pbHome.Location = new System.Drawing.Point(657, 416);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(88, 69);
            this.pbHome.TabIndex = 16;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Image = global::Mitchell_School_Of_Music.Properties.Resources.logo3;
            this.pbLogo.Location = new System.Drawing.Point(658, 13);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(245, 114);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 17;
            this.pbLogo.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.Location = new System.Drawing.Point(674, 303);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 18);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Surname:";
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbName.Location = new System.Drawing.Point(744, 300);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 19;
            // 
            // btnName
            // 
            this.btnName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnName.BackColor = System.Drawing.Color.Black;
            this.btnName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnName.ForeColor = System.Drawing.Color.Red;
            this.btnName.Location = new System.Drawing.Point(850, 298);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(52, 23);
            this.btnName.TabIndex = 18;
            this.btnName.Text = "Search";
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // Tutor_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mitchell_School_Of_Music.Properties.Resources.rose_1905786_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 497);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn_EditDetails);
            this.Controls.Add(this.btn_AddDetails);
            this.Controls.Add(this.DataTutorView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tutor_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutor Dertails | Mitchell School of Music";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tutor_Details_FormClosing);
            this.Load += new System.EventHandler(this.Tutor_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTutorView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTutorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btn_EditDetails;
        private System.Windows.Forms.Button btn_AddDetails;
        private System.Windows.Forms.DataGridView DataTutorView;
        private MitchellMusicDataSet mitchellMusicDBDataSet;
        private System.Windows.Forms.BindingSource mitchellMusicDBDataSetBindingSource;
        private MitchellMusicDataSet mitchellMusicDBDataSet1;
        private System.Windows.Forms.BindingSource tblTutorBindingSource;
        private MitchellMusicDataSetTableAdapters.Tbl_TutorTableAdapter tbl_TutorTableAdapter;
        private System.Windows.Forms.BindingSource mitchellMusicDataSetBindingSource;
        private MitchellMusicDataSet mitchellMusicDataSet;
        private System.Windows.Forms.BindingSource tblTutorBindingSource1;
        private MitchellMusicDataSetTableAdapters.Tbl_TutorTableAdapter tbl_TutorTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorAddressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorAddressLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorPostcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorInstrumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
    }
}