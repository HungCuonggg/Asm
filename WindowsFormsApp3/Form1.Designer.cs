namespace WindowsFormsApp3
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AttendanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coursename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendancedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtAttendance = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDetele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendanceID,
            this.StudentName,
            this.Dateofbirth,
            this.Classname,
            this.Coursename,
            this.Attendancedate});
            this.dataGridView1.Location = new System.Drawing.Point(63, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1324, 184);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AttendanceID
            // 
            this.AttendanceID.DataPropertyName = "AttendanceID";
            this.AttendanceID.HeaderText = "ID";
            this.AttendanceID.MinimumWidth = 6;
            this.AttendanceID.Name = "AttendanceID";
            this.AttendanceID.Width = 50;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 175;
            // 
            // Dateofbirth
            // 
            this.Dateofbirth.DataPropertyName = "DateOfBirth";
            this.Dateofbirth.HeaderText = "Date of Birth";
            this.Dateofbirth.MinimumWidth = 6;
            this.Dateofbirth.Name = "Dateofbirth";
            this.Dateofbirth.Width = 150;
            // 
            // Classname
            // 
            this.Classname.DataPropertyName = "ClassName";
            this.Classname.HeaderText = "Class Name";
            this.Classname.MinimumWidth = 6;
            this.Classname.Name = "Classname";
            this.Classname.Width = 150;
            // 
            // Coursename
            // 
            this.Coursename.DataPropertyName = "CourseName";
            this.Coursename.HeaderText = "Course Name";
            this.Coursename.MinimumWidth = 6;
            this.Coursename.Name = "Coursename";
            this.Coursename.Width = 125;
            // 
            // Attendancedate
            // 
            this.Attendancedate.DataPropertyName = "AttendanceDate";
            this.Attendancedate.HeaderText = "Attendance Date";
            this.Attendancedate.MinimumWidth = 6;
            this.Attendancedate.Name = "Attendancedate";
            this.Attendancedate.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attandance Overview";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(239, 44);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(73, 16);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "Username:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1050, 44);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(425, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(425, 139);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(132, 22);
            this.txtDate.TabIndex = 5;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(425, 182);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(115, 22);
            this.txtClass.TabIndex = 6;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(425, 225);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(100, 22);
            this.txtCourse.TabIndex = 7;
            // 
            // txtAttendance
            // 
            this.txtAttendance.Location = new System.Drawing.Point(914, 94);
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.Size = new System.Drawing.Size(121, 22);
            this.txtAttendance.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(316, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 16);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Student name";
            this.lblName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(319, 144);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(79, 16);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date of Birth";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(319, 225);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(90, 16);
            this.lblCourse.TabIndex = 12;
            this.lblCourse.Text = "Course Name";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(319, 188);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(81, 16);
            this.lblClass.TabIndex = 13;
            this.lblClass.Text = "Class Name";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(819, 144);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status";
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Location = new System.Drawing.Point(787, 100);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(107, 16);
            this.lblAttendance.TabIndex = 15;
            this.lblAttendance.Text = "Attendance Date";
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Late"});
            this.cbbStatus.Location = new System.Drawing.Point(914, 144);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(121, 24);
            this.cbbStatus.TabIndex = 16;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(978, 254);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(855, 254);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDetele
            // 
            this.btnDetele.Location = new System.Drawing.Point(738, 254);
            this.btnDetele.Name = "btnDetele";
            this.btnDetele.Size = new System.Drawing.Size(75, 23);
            this.btnDetele.TabIndex = 19;
            this.btnDetele.Text = "Delete";
            this.btnDetele.UseVisualStyleBackColor = true;
            this.btnDetele.Click += new System.EventHandler(this.btnDetele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 581);
            this.Controls.Add(this.btnDetele);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.lblAttendance);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAttendance);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dateofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coursename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendancedate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtAttendance;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDetele;
    }
}

