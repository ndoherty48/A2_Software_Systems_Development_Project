namespace Mitchell_School_Of_Music.Forms
{
    partial class frmStudentViewReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentViewReport));
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitchellMusicDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitchellMusicDBDataSet2 = new Mitchell_School_Of_Music.MitchellMusicDBDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fillByStudentIDQueryToolStrip = new System.Windows.Forms.ToolStrip();
            this.student_IDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.student_IDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByStudentIDQueryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tbl_StudentTableAdapter = new Mitchell_School_Of_Music.MitchellMusicDBDataSet2TableAdapters.tbl_StudentTableAdapter();
            this.pbHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSet2)).BeginInit();
            this.fillByStudentIDQueryToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "tbl_Student";
            this.tblStudentBindingSource.DataSource = this.mitchellMusicDBDataSet2BindingSource;
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
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetStudent";
            reportDataSource1.Value = this.tblStudentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Mitchell_School_Of_Music.Reports.StudentReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(494, 407);
            this.reportViewer1.TabIndex = 0;
            // 
            // fillByStudentIDQueryToolStrip
            // 
            this.fillByStudentIDQueryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.student_IDToolStripLabel,
            this.student_IDToolStripTextBox,
            this.fillByStudentIDQueryToolStripButton,
            this.toolStripButton1});
            this.fillByStudentIDQueryToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByStudentIDQueryToolStrip.Name = "fillByStudentIDQueryToolStrip";
            this.fillByStudentIDQueryToolStrip.Size = new System.Drawing.Size(593, 25);
            this.fillByStudentIDQueryToolStrip.TabIndex = 1;
            this.fillByStudentIDQueryToolStrip.Text = "fillByStudentIDQueryToolStrip";
            // 
            // student_IDToolStripLabel
            // 
            this.student_IDToolStripLabel.Name = "student_IDToolStripLabel";
            this.student_IDToolStripLabel.Size = new System.Drawing.Size(65, 22);
            this.student_IDToolStripLabel.Text = "Student ID:";
            // 
            // student_IDToolStripTextBox
            // 
            this.student_IDToolStripTextBox.Name = "student_IDToolStripTextBox";
            this.student_IDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByStudentIDQueryToolStripButton
            // 
            this.fillByStudentIDQueryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByStudentIDQueryToolStripButton.Name = "fillByStudentIDQueryToolStripButton";
            this.fillByStudentIDQueryToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillByStudentIDQueryToolStripButton.Text = "Search";
            this.fillByStudentIDQueryToolStripButton.Click += new System.EventHandler(this.fillByStudentIDQueryToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(77, 22);
            this.toolStripButton1.Text = "Reset Report";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tbl_StudentTableAdapter
            // 
            this.tbl_StudentTableAdapter.ClearBeforeFill = true;
            // 
            // pbHome
            // 
            this.pbHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHome.BackColor = System.Drawing.Color.Transparent;
            this.pbHome.BackgroundImage = global::Mitchell_School_Of_Music.Properties.Resources.returns__button_icon_72032;
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHome.Image = global::Mitchell_School_Of_Music.Properties.Resources.returns__button_icon_72032;
            this.pbHome.Location = new System.Drawing.Point(505, 366);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(88, 69);
            this.pbHome.TabIndex = 7;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // frmStudentViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mitchell_School_Of_Music.Properties.Resources.rose_1905786_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 447);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.fillByStudentIDQueryToolStrip);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStudentViewReport";
            this.Text = "frmStudentViewReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStudentViewReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitchellMusicDBDataSet2)).EndInit();
            this.fillByStudentIDQueryToolStrip.ResumeLayout(false);
            this.fillByStudentIDQueryToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mitchellMusicDBDataSet2BindingSource;
        private MitchellMusicDBDataSet2 mitchellMusicDBDataSet2;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private MitchellMusicDBDataSet2TableAdapters.tbl_StudentTableAdapter tbl_StudentTableAdapter;
        private System.Windows.Forms.ToolStrip fillByStudentIDQueryToolStrip;
        private System.Windows.Forms.ToolStripLabel student_IDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox student_IDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByStudentIDQueryToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox pbHome;
    }
}