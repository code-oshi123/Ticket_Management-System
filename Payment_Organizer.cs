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
    public partial class Payment_Organizer : Form
    {
        private MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=ticketdb;");
        public Payment_Organizer()
        {
            InitializeComponent();
        }

        private void lblEventResult_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Organizer_Load(object sender, EventArgs e)
        {
            LoadPayments();
        }
        private void LoadPayments()
        {
            try
            {
                conn.Open();

                string query = "SELECT id, name, amount, payment_date FROM payments";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvPayments.AutoGenerateColumns = false;
                dgvPayments.Columns.Clear();

                // Add columns manually
                dgvPayments.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "id",
                    HeaderText = "Payment ID",
                    Name = "id"
                });

                dgvPayments.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "name",
                    HeaderText = "Name",
                    Name = "name"
                });

                dgvPayments.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "amount",
                    HeaderText = "Amount",
                    Name = "amount"
                });

                dgvPayments.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "payment_date",
                    HeaderText = "Payment Date",
                    Name = "payment_date"
                });

                //dgvPayments.Columns.Add(new DataGridViewTextBoxColumn()
                //{
                //DataPropertyName = "event_id",
                // HeaderText = "Event ID",
                // Name = "event_id"
                //s });

                dgvPayments.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCheckEvent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEventId.Text))
            {
                MessageBox.Show("Please enter an Event ID.");
                return;
            }

            if (!int.TryParse(txtEventId.Text, out int eventId))
            {
                MessageBox.Show("Invalid Event ID.");
                return;
            }

            try
            {
                conn.Open();

                // Calculate total revenue and sold tickets
                string revenueQuery = "SELECT SUM(TotalPrice) AS Revenue, SUM(Quantity) AS SoldTickets FROM sales WHERE EventID = @eventId";
                MySqlCommand cmd = new MySqlCommand(revenueQuery, conn);
                cmd.Parameters.AddWithValue("@eventId", eventId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        decimal totalRevenue = reader["Revenue"] != DBNull.Value ? Convert.ToDecimal(reader["Revenue"]) : 0;
                        int ticketsSold = reader["SoldTickets"] != DBNull.Value ? Convert.ToInt32(reader["SoldTickets"]) : 0;

                        lblEventResult.Text = $"Revenue: Rs. {totalRevenue:N2}\nTickets Sold: {ticketsSold}";
                    }
                    else
                    {
                        lblEventResult.Text = "No sales data found for this event.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching event data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OrganizerMenuEventForm admin = new OrganizerMenuEventForm();
            admin.Show();
            this.Hide();
        }
    }
}
