namespace WindowsFormsApp3
{
    partial class Form3
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
            this.dtgvAttendancePercentage = new System.Windows.Forms.DataGridView();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendancePercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAttendancePercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvAttendancePercentage
            // 
            this.dtgvAttendancePercentage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAttendancePercentage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.Status,
            this.AttendancePercentage});
            this.dtgvAttendancePercentage.Location = new System.Drawing.Point(108, 107);
            this.dtgvAttendancePercentage.Name = "dtgvAttendancePercentage";
            this.dtgvAttendancePercentage.RowHeadersWidth = 51;
            this.dtgvAttendancePercentage.RowTemplate.Height = 24;
            this.dtgvAttendancePercentage.Size = new System.Drawing.Size(785, 260);
            this.dtgvAttendancePercentage.TabIndex = 0;
            this.dtgvAttendancePercentage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAttendancePercentage_CellContentClick);
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.MinimumWidth = 6;
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            this.CourseName.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // AttendancePercentage
            // 
            this.AttendancePercentage.DataPropertyName = "AttendancePercentage";
            this.AttendancePercentage.HeaderText = "Attendance Percentage";
            this.AttendancePercentage.MinimumWidth = 6;
            this.AttendancePercentage.Name = "AttendancePercentage";
            this.AttendancePercentage.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendance Statistics";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(460, 397);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.dtgvAttendancePercentage);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "AttendacePercent";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAttendancePercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvAttendancePercentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendancePercentage;
    }
}