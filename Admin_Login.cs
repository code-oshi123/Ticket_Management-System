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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            Roleselection rs = new Roleselection();
            rs.Show();
            this.Hide();
        }
        private void Adminlogin_btn_Click(object sender, EventArgs e)
        {

        }

        private void Adminlogin_btn_Click_1(object sender, EventArgs e)
        {
            Adminlogin_btn.BackColor = Color.MediumSlateBlue;
            string adminId = AdminID_tb.Text.Trim();
            string username = username_tb.Text.Trim();
            string password = password_tb.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(adminId))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string connStr = "server=localhost;user=root;database=admin;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM tbl_admin WHERE adminID = @id AND username = @uname AND password = @pass";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", adminId);
                        cmd.Parameters.AddWithValue("@uname", username);
                        cmd.Parameters.AddWithValue("@pass", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Login successful.");
                                AdminDashboardForm admindashboard = new AdminDashboardForm();
                                admindashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("User not found. Please check your credentials.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }

        private void back_btn_Click_1(object sender, EventArgs e)
        {
            back_btn.BackColor = Color.DarkSlateBlue;
            Roleselection rs = new Roleselection();
            rs.Show();
            this.Hide();

        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
