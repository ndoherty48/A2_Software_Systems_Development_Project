namespace Mitchell_School_Of_Music
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnStudentDetails = new System.Windows.Forms.Button();
            this.btnTutorDetails = new System.Windows.Forms.Button();
            this.btnTimetables = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pctLogout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudentDetails
            // 
            this.btnStudentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentDetails.BackColor = System.Drawing.Color.Black;
            this.btnStudentDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentDetails.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentDetails.ForeColor = System.Drawing.Color.Red;
            this.btnStudentDetails.Location = new System.Drawing.Point(9, 42);
            this.btnStudentDetails.Name = "btnStudentDetails";
            this.btnStudentDetails.Size = new System.Drawing.Size(584, 106);
            this.btnStudentDetails.TabIndex = 0;
            this.btnStudentDetails.Text = "Student Details";
            this.btnStudentDetails.UseVisualStyleBackColor = false;
            this.btnStudentDetails.Click += new System.EventHandler(this.btnStudentDetails_Click);
            // 
            // btnTutorDetails
            // 
            this.btnTutorDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTutorDetails.BackColor = System.Drawing.Color.Black;
            this.btnTutorDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutorDetails.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutorDetails.ForeColor = System.Drawing.Color.Red;
            this.btnTutorDetails.Location = new System.Drawing.Point(9, 184);
            this.btnTutorDetails.Margin = new System.Windows.Forms.Padding(0);
            this.btnTutorDetails.Name = "btnTutorDetails";
            this.btnTutorDetails.Size = new System.Drawing.Size(584, 106);
            this.btnTutorDetails.TabIndex = 1;
            this.btnTutorDetails.Text = "Tutor Details";
            this.btnTutorDetails.UseVisualStyleBackColor = false;
            this.btnTutorDetails.Click += new System.EventHandler(this.btnTutorDetails_Click);
            // 
            // btnTimetables
            // 
            this.btnTimetables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimetables.BackColor = System.Drawing.Color.Black;
            this.btnTimetables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimetables.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimetables.ForeColor = System.Drawing.Color.Red;
            this.btnTimetables.Location = new System.Drawing.Point(9, 317);
            this.btnTimetables.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimetables.Name = "btnTimetables";
            this.btnTimetables.Size = new System.Drawing.Size(584, 106);
            this.btnTimetables.TabIndex = 2;
            this.btnTimetables.Text = "Bookings ";
            this.btnTimetables.UseVisualStyleBackColor = false;
            this.btnTimetables.Click += new System.EventHandler(this.button3_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Image = global::Mitchell_School_Of_Music.Properties.Resources.logo3;
            this.pbLogo.Location = new System.Drawing.Point(606, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(245, 114);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // pctLogout
            // 
            this.pctLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pctLogout.BackColor = System.Drawing.Color.Transparent;
            this.pctLogout.Image = global::Mitchell_School_Of_Music.Properties.Resources.download;
            this.pctLogout.Location = new System.Drawing.Point(782, 409);
            this.pctLogout.Name = "pctLogout";
            this.pctLogout.Size = new System.Drawing.Size(80, 83);
            this.pctLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogout.TabIndex = 4;
            this.pctLogout.TabStop = false;
            this.pctLogout.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mitchell_School_Of_Music.Properties.Resources.rose_1905786_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 491);
            this.Controls.Add(this.pctLogout);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnTimetables);
            this.Controls.Add(this.btnTutorDetails);
            this.Controls.Add(this.btnStudentDetails);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mitchell School of Music";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentDetails;
        private System.Windows.Forms.Button btnTutorDetails;
        private System.Windows.Forms.Button btnTimetables;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pctLogout;
    }
}