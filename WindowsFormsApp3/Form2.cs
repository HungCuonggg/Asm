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
    public partial class Form2 : Form
    {
        SqlConnection connection;
        public Form2()
        {
            connection = new SqlConnection("Server=ADMIN\\SQLEXPRESS;Database=asm2;Integrated Security = true;");
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string query = "SELECT * FROM Account WHERE username = @username AND u_password = @password";

            try
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            string role = reader["u_role"].ToString();

                            // Display a success message
                            MessageBox.Show("Login successful!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Hide the current form
                            this.Hide();

                            // Show the appropriate form based on the user's role
                            if (role == "admin")
                            {
                                Form3 adminForm = new Form3();
                                adminForm.ShowDialog();
                            }
                            else if (role == "user")
                            {
                                Form1 userForm = new Form1(username);
                                userForm.ShowDialog();
                            }

                            // Dispose of the current form
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Wrong username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
