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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            //Roleselection rs = new Roleselection();
            //rs.Show();
            //this.Hide();
        }
        private void forgetPW_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ForgetpasswordForm resetForm = new ForgetpasswordForm();
            //resetForm.Show();
            //this.Hide();


        }
        //private void signin_btn_Click(object sender, EventArgs e)
        //{

        //    RegisterUser ru = new RegisterUser();
        //    ru.Show();
        //    this.Hide();
        //}
        private void Login_btn_Click(object sender, EventArgs e)
        {



        }

        private void Login_btn_Click_1(object sender, EventArgs e)
        {
            string username = username_tb.Text.Trim();
            string password = password_tb.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both Username and Password.");
                return;
            }

            string connectionString = "server=localhost;uid=root;pwd=;database=user";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT userid FROM tbll_user WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int userId = Convert.ToInt32(result);
                    MessageBox.Show("Login Successful");

                    UserEventHomeForm3 userevnt = new UserEventHomeForm3();
                    userevnt.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
            }

        }

        private void forgetPW_label_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = Microsoft.VisualBasic.Interaction.InputBox("Enter your username:", "Forgot Password");

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username is required.");
                return;
            }

            string connStr = "server=localhost;user=root;database=user;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT 1 FROM tbll_user WHERE username = @uname LIMIT 1";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@uname", username);

                    object exists = checkCmd.ExecuteScalar();
                    if (exists == null)
                    {
                        MessageBox.Show("Username not found.");
                        return;
                    }

                    string newPassword = Microsoft.VisualBasic.Interaction.InputBox("Enter your new password:", "Reset Password");

                    if (string.IsNullOrEmpty(newPassword))
                    {
                        MessageBox.Show("Password cannot be empty.");
                        return;
                    }

                    string updateQuery = "UPDATE tbll_user SET password = @pass WHERE username = @uname";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@pass", newPassword);
                    updateCmd.Parameters.AddWithValue("@uname", username);

                    int result = updateCmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Password updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Password update failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }

        }

        private void back_btn_Click_1(object sender, EventArgs e)
        {
            Roleselection ru = new Roleselection();
            ru.Show();
            this.Hide();

        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            RegisterUser registeruser = new RegisterUser();
            registeruser.Show();
            this.Hide();
        }
    }
}
