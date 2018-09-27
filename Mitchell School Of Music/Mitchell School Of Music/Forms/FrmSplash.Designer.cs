namespace Mitchell_School_Of_Music
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl1stRow = new System.Windows.Forms.Label();
            this.lbl2ndRow = new System.Windows.Forms.Label();
            this.lbl3rdRow = new System.Windows.Forms.Label();
            this.lblInfoViewer = new System.Windows.Forms.Label();
            this.pctDeveloperLogo = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctDeveloperLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl1stRow
            // 
            this.lbl1stRow.AutoSize = true;
            this.lbl1stRow.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1stRow.ForeColor = System.Drawing.Color.White;
            this.lbl1stRow.Location = new System.Drawing.Point(9, 424);
            this.lbl1stRow.Name = "lbl1stRow";
            this.lbl1stRow.Size = new System.Drawing.Size(378, 15);
            this.lbl1stRow.TabIndex = 2;
            this.lbl1stRow.Text = "This Program is protected by International Copyright Laws";
            // 
            // lbl2ndRow
            // 
            this.lbl2ndRow.AutoSize = true;
            this.lbl2ndRow.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2ndRow.ForeColor = System.Drawing.Color.White;
            this.lbl2ndRow.Location = new System.Drawing.Point(9, 439);
            this.lbl2ndRow.Name = "lbl2ndRow";
            this.lbl2ndRow.Size = new System.Drawing.Size(243, 15);
            this.lbl2ndRow.TabIndex = 3;
            this.lbl2ndRow.Text = "© 2017 Nathan Doherty Applications ";
            // 
            // lbl3rdRow
            // 
            this.lbl3rdRow.AutoSize = true;
            this.lbl3rdRow.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3rdRow.ForeColor = System.Drawing.Color.White;
            this.lbl3rdRow.Location = new System.Drawing.Point(9, 454);
            this.lbl3rdRow.Name = "lbl3rdRow";
            this.lbl3rdRow.Size = new System.Drawing.Size(132, 15);
            this.lbl3rdRow.TabIndex = 4;
            this.lbl3rdRow.Text = "All Rights Reserved";
            // 
            // lblInfoViewer
            // 
            this.lblInfoViewer.AutoSize = true;
            this.lblInfoViewer.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoViewer.ForeColor = System.Drawing.Color.White;
            this.lblInfoViewer.Location = new System.Drawing.Point(162, 208);
            this.lblInfoViewer.Name = "lblInfoViewer";
            this.lblInfoViewer.Size = new System.Drawing.Size(225, 25);
            this.lblInfoViewer.TabIndex = 5;
            this.lblInfoViewer.Text = "Information Viewer";
            // 
            // pctDeveloperLogo
            // 
            this.pctDeveloperLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pctDeveloperLogo.Image = global::Mitchell_School_Of_Music.Properties.Resources.Nathan_Doherty_Software_Logo1;
            this.pctDeveloperLogo.Location = new System.Drawing.Point(232, 457);
            this.pctDeveloperLogo.Name = "pctDeveloperLogo";
            this.pctDeveloperLogo.Size = new System.Drawing.Size(184, 111);
            this.pctDeveloperLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctDeveloperLogo.TabIndex = 6;
            this.pctDeveloperLogo.TabStop = false;
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pctLogo.Image = global::Mitchell_School_Of_Music.Properties.Resources.logo3;
            this.pctLogo.Location = new System.Drawing.Point(12, 12);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(378, 266);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(412, 552);
            this.ControlBox = false;
            this.Controls.Add(this.pctDeveloperLogo);
            this.Controls.Add(this.lblInfoViewer);
            this.Controls.Add(this.lbl3rdRow);
            this.Controls.Add(this.lbl2ndRow);
            this.Controls.Add(this.lbl1stRow);
            this.Controls.Add(this.pctLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(400, 100);
            this.Name = "frmSplash";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mitchell School Of Music";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctDeveloperLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl3rdRow;
        private System.Windows.Forms.Label lbl2ndRow;
        private System.Windows.Forms.Label lbl1stRow;
        private System.Windows.Forms.Label lblInfoViewer;
        private System.Windows.Forms.PictureBox pctDeveloperLogo;
    }
}

