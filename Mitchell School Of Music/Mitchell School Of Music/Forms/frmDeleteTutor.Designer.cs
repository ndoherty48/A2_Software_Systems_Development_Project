namespace Mitchell_School_Of_Music.Forms
{
    partial class frmDeleteTutor
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
            this.tb_Tutor_Delete = new System.Windows.Forms.TextBox();
            this.lblTutor = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Tutor_Delete
            // 
            this.tb_Tutor_Delete.Location = new System.Drawing.Point(104, 12);
            this.tb_Tutor_Delete.Name = "tb_Tutor_Delete";
            this.tb_Tutor_Delete.Size = new System.Drawing.Size(100, 20);
            this.tb_Tutor_Delete.TabIndex = 0;
            this.tb_Tutor_Delete.TextChanged += new System.EventHandler(this.tb_Tutor_Delete_TextChanged);
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.BackColor = System.Drawing.Color.Transparent;
            this.lblTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutor.ForeColor = System.Drawing.Color.White;
            this.lblTutor.Location = new System.Drawing.Point(22, 9);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(76, 24);
            this.lblTutor.TabIndex = 1;
            this.lblTutor.Text = "Tutor ID";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(211, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 48);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDeleteTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mitchell_School_Of_Music.Properties.Resources.backing;
            this.ClientSize = new System.Drawing.Size(284, 48);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTutor);
            this.Controls.Add(this.tb_Tutor_Delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeleteTutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeleteTutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Tutor_Delete;
        private System.Windows.Forms.Label lblTutor;
        private System.Windows.Forms.Button btnDelete;
    }
}