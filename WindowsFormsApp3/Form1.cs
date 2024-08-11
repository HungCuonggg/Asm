using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=ADMIN\\SQLEXPRESS;Database=asm2;Integrated Security = true;";
        SqlConnection connection;
        public Form1(string username)
        {
            connection = new SqlConnection("Server=ADMIN\\SQLEXPRESS;Database=asm2;Integrated Security = true;");
            LoadAttendanceData();
            InitializeComponent();
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            lbUser.Text = username;
        }
        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtClass.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return false;
            }
            if (!DateTime.TryParse(txtDate.Text, out DateTime date))
            {
                MessageBox.Show("Invalid date format.");
                return false;
            }
            if (cbbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status.");
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            MessageBox.Show(this, "Successful connection", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
            FillData();
        }
        public void FillData()
        {
            string query = "select * from Attendance";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            dataGridView1.DataSource = tbl;
            connection.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 login = new Form2();
            login.ShowDialog();
            this.Dispose();
        }

        private void LoadAttendanceData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Attendance";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns["Status"].DisplayIndex = 6;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private bool Validatee()
        {
            // Validate Name
            if (string.IsNullOrEmpty(txtName.Text) || !IsValidName(txtName.Text))
            {
                MessageBox.Show("Please enter a valid name.");
                return false;
            }

            // Validate Class
            if (string.IsNullOrEmpty(txtClass.Text))
            {
                MessageBox.Show("Class field cannot be empty.");
                return false;
            }

            // Validate Date of Birth
            if (!DateTime.TryParse(txtDate.Text, out DateTime dateOfBirth) || dateOfBirth > DateTime.Now)
            {
                MessageBox.Show("Invalid date format or date is in the future.");
                return false;
            }

            // Validate Attendance Date
            if (!DateTime.TryParse(txtAttendance.Text, out DateTime attendanceDate) || attendanceDate > DateTime.Now)
            {
                MessageBox.Show("Invalid attendance date format or date is in the future.");
                return false;
            }

            // Validate Status
            if (cbbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status.");
                return false;
            }

            return true;
        }

        private bool IsValidName(string name)
        {
            // Allow only letters and spaces
            return name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private void InsertAttendanceRecord(string studentName, DateTime dateOfBirth, string className, string courseName, DateTime attendanceDate, string status)
        {
            string query = "INSERT INTO Attendance (StudentName, DateOfBirth, ClassName, CourseName, AttendanceDate, Status) VALUES (@StudentName, @DateOfBirth, @ClassName, @CourseName, @AttendanceDate, @Status)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentName", studentName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@ClassName", className);
                    cmd.Parameters.AddWithValue("@CourseName", courseName);
                    cmd.Parameters.AddWithValue("@AttendanceDate", attendanceDate);
                    cmd.Parameters.AddWithValue("@Status", status);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Call ValidateForm before proceeding
            if (Validatee())
            {
                // Retrieve values from textboxes
                string studentName = txtName.Text;
                DateTime dateOfBirth = Convert.ToDateTime(txtDate.Text);
                string className = txtClass.Text;
                string courseName = txtCourse.Text;
                DateTime attendanceDate = Convert.ToDateTime(txtAttendance.Text);
                string status = cbbStatus.SelectedItem.ToString();

                // Insert the record
                InsertAttendanceRecord(studentName, dateOfBirth, className, courseName, attendanceDate, status);

                // Refresh the DataGridView to show the new record
                LoadAttendanceData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtName.Text = row.Cells["StudentName"].Value.ToString();
                txtDate.Text = row.Cells["DateOfBirth"].Value.ToString();
                txtClass.Text = row.Cells["ClassName"].Value.ToString();
                txtCourse.Text = row.Cells["CourseName"].Value.ToString();
                txtAttendance.Text = row.Cells["AttendanceDate"].Value.ToString();
                cbbStatus.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        }

        private void UpdateAttendanceRecord(int attendanceID, string studentName, DateTime dateOfBirth, string className, string courseName, DateTime attendanceDate, string status)
        {
            string query = "UPDATE Attendance SET StudentName = @StudentName, DateOfBirth = @DateOfBirth, ClassName = @ClassName, CourseName = @CourseName, AttendanceDate = @AttendanceDate, Status = @Status WHERE AttendanceID = @AttendanceID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AttendanceID", attendanceID);
                    cmd.Parameters.AddWithValue("@StudentName", studentName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@ClassName", className);
                    cmd.Parameters.AddWithValue("@CourseName", courseName);
                    cmd.Parameters.AddWithValue("@AttendanceDate", attendanceDate);
                    cmd.Parameters.AddWithValue("@Status", status);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Validatee())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    int attendanceID = Convert.ToInt32(selectedRow.Cells["AttendanceID"].Value);
                    string studentName = txtName.Text;
                    DateTime dateOfBirth = Convert.ToDateTime(txtDate.Text);
                    string className = txtClass.Text;
                    string courseName = txtCourse.Text;
                    DateTime attendanceDate = Convert.ToDateTime(txtAttendance.Text);
                    string status = cbbStatus.SelectedItem.ToString();

                    UpdateAttendanceRecord(attendanceID, studentName, dateOfBirth, className, courseName, attendanceDate, status);
                    LoadAttendanceData();
                }
                else
                {
                    MessageBox.Show("Please select a record to edit.");
                }
            }
        }

        private void DeleteAttendanceRecord(int attendanceID)
        {
            string query = "DELETE FROM Attendance WHERE AttendanceID = @AttendanceID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AttendanceID", attendanceID);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDetele_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int attendanceID = Convert.ToInt32(selectedRow.Cells["AttendanceID"].Value);

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteAttendanceRecord(attendanceID);

                    // Refresh the DataGridView to show the updated data
                    LoadAttendanceData();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }
        private int GetNextAttendanceID()
        {
            int nextID = 1;
            string query = "SELECT ISNULL(MAX(AttendanceID), 0) + 1 FROM Attendance";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out nextID))
                    {
                        return nextID;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return nextID;
        } 
    }
}
