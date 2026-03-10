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
    public partial class Payment_User : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=ticketdb;");
        public Payment_User()
        {
            InitializeComponent();
        }

        private void Payment_User_Load(object sender, EventArgs e)
        {
            LoadDashboardSummary();
        }
        
        private void LoadDashboardSummary()
        {
            try
            {
                conn.Open();

                // Total revenue
                string revenueQuery = "SELECT COALESCE(SUM(TotalPrice), 0) FROM sales";
                MySqlCommand cmd1 = new MySqlCommand(revenueQuery, conn);
                object revenue = cmd1.ExecuteScalar();
                lblRevenue.Text = "Total Revenue: LKR " + Convert.ToDecimal(revenue).ToString("N2");

                // Total Events
                string eventQuery = "SELECT COUNT(DISTINCT SaleID) FROM sales";
                MySqlCommand cmd2 = new MySqlCommand(eventQuery, conn);
                object eventCount = cmd2.ExecuteScalar();
                lblEvents.Text = "Payments Held: " + Convert.ToInt32(eventCount);

                // Tickets Booked
                string ticketQuery = "SELECT COALESCE(SUM(Quantity), 0) FROM sales";
                MySqlCommand cmd3 = new MySqlCommand(ticketQuery, conn);
                object tickets = cmd3.ExecuteScalar();
                lblTickets.Text = "Tickets Sold: " + Convert.ToInt32(tickets);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboardForm adminDashboard = new AdminDashboardForm();
            adminDashboard.Show();
            this.Hide();
        }
    }
}
