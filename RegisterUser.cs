using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbex
{
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {

            
        }
        private void Register_btn_Click(object sender, EventArgs e)
        {

            


        }
        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click_1(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }

        private void Register_btn_Click_1(object sender, EventArgs e)
        {
            string username = username_tb.Text.Trim().ToLower();
            string password = password_tb.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both Username and Password.");
                return;
            }

            string connStr = "server=localhost;user=root;database=user;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Check if username already exists
                    string checkQuery = "SELECT 1 FROM tbll_user WHERE username = @uname LIMIT 1";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@uname", username);
                        object exists = checkCmd.ExecuteScalar();
                        if (exists != null)
                        {
                            MessageBox.Show("Username already exists. Please choose a different one.");
                            return;
                        }
                    }

                    // Insert new user
                    string insertQuery = "INSERT INTO tbll_user (username, password) VALUES (@uname, @pass)";
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@uname", username);
                        insertCmd.Parameters.AddWithValue("@pass", password);

                        int result = insertCmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            long newUserId = insertCmd.LastInsertedId;
                            string formattedId = newUserId.ToString("D4"); // Format: 0001.......

                            MessageBox.Show($"Registration successful!\nYour User ID is: {formattedId}");

                            username_tb.Clear();
                            password_tb.Clear();


                            this.Hide();
                            new User().Show();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error: " + ex.Message);
                }
            }

        }
    }
}
