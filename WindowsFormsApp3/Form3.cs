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

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        private string connectionString = "Server=ADMIN\\SQLEXPRESS;Database=asm2;Integrated Security = true;";
        SqlConnection connection;
        public Form3()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        public void FillData()
        {
            string query = "select * from CourseAttendanceStatistics";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            dtgvAttendancePercentage.DataSource = tbl;
            connection.Close();
        }
        private void LoadAttendanceData()
        {
            string query = "SELECT * FROM CourseAttendanceStatistics";

            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Log the number of rows fetched
                MessageBox.Show($"Number of rows fetched: {dataTable.Rows.Count}");

                // Check column names
                foreach (DataColumn column in dataTable.Columns)
                {
                    Console.WriteLine("Column: " + column.ColumnName);
                }

                // Ensure the DataGridView is bound properly
                dtgvAttendancePercentage.AutoGenerateColumns = true;
                dtgvAttendancePercentage.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 loginForm = new Form2();
            loginForm.ShowDialog();
            this.Dispose();
        }

        private void dtgvAttendancePercentage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            connection.Open();
            LoadAttendanceData();
            FillData();
        }
    }
}
