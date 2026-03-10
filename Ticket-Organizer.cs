using Dbex.Controller;
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
    public partial class Ticket_Organizer : Form
    {
        private TicketController ticketController = new TicketController();
        public Ticket_Organizer()
        {
            InitializeComponent();
            btnUpdatePrice.Click += btnUpdatePrice_Click;
            btnDeleteTicket.Click += btnDeleteTicket_Click;
            btnViewTickets.Click += btnViewTickets_Click;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewTickets.ColumnCount = 5;
            dataGridViewTickets.Columns[0].Name = "Ticket ID";
            dataGridViewTickets.Columns[1].Name = "Event ID";
            dataGridViewTickets.Columns[2].Name = "Type";
            dataGridViewTickets.Columns[3].Name = "Price";
            dataGridViewTickets.Columns[4].Name = "Availability";


            cmbType.SelectedIndex = 0;
        }
        private void RefreshTicketList()
        {
            dataGridViewTickets.Rows.Clear();

            foreach (var ticket in ticketController.GetAllTickets())
            {
                dataGridViewTickets.Rows.Add(ticket.TicketID, ticket.EventID, ticket.Type, ticket.Price, ticket.Availability);
            }
        }
        private void Ticket_Organizer_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            // Validate empty fields
            // 1. Input Validation
            if (string.IsNullOrWhiteSpace(txtEventID.Text) ||
                cmbType.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtAvailability.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Parse user input
                int eventId = int.Parse(txtEventID.Text);
                string type = cmbType.SelectedItem.ToString();
                decimal price = decimal.Parse(txtPrice.Text);
                int availability = int.Parse(txtAvailability.Text);

                // 3. Check if ticket already exists
                if (ticketController.TicketExists(eventId, type))
                {
                    MessageBox.Show("A ticket with this Event ID and Type already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 4. Add ticket if all is good
                ticketController.AddTicket(eventId, type, price, availability);
                RefreshTicketList(); // Reload updated data
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for Event ID, Price, and Availability.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnBook_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtEventID.Text, out int eventId))
            {
                MessageBox.Show("Invalid Event ID.");
                return;
            }

            string ticketType = cmbType.SelectedItem?.ToString();

            if (!ticketController.IsValidTicketType(eventId, ticketType))
            {
                MessageBox.Show("Invalid ticket type for this event.", "Invalid Ticket Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proceed with booking logic here
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUpdateTicketID.Text, out int ticketID))
            {
                MessageBox.Show("Please enter a valid Ticket ID.");
                return;
            }

            if (!decimal.TryParse(txtNewPrice.Text, out decimal newPrice))
            {
                MessageBox.Show("Please enter a valid new price.");
                return;
            }

            string result = ticketController.UpdateTicketPrice(ticketID, newPrice);
            MessageBox.Show(result); // This shows "Ticket not found." if it's invalid
            RefreshTicketList();
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtDeleteTicketID.Text.Trim(), out int ticketID))
            {
                MessageBox.Show("Please enter a valid Ticket ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = ticketController.DeleteTicket(ticketID);

                if (success)
                {
                    MessageBox.Show("Ticket deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshTicketList();
                }
                else
                {
                    MessageBox.Show("Ticket not found or already deleted.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnViewTickets_Click(object sender, EventArgs e)
        {
            RefreshTicketList(); // This will display all tickets in the DataGridView
        }

        private void cmbTicketType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdditemForm addit = new AdditemForm();
            addit.Show();
            this.Hide();
        }
    }
}
