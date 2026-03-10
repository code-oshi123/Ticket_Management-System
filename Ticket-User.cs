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
    public partial class Ticket_User : Form
    {
        public Ticket_User()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadTickets_Click(object sender, EventArgs e)
        {
            TicketController controller = new TicketController();

            if (!int.TryParse(txtEventID.Text, out int eventID))
            {
                MessageBox.Show("Please enter a valid numeric Event ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTicketType.SelectedItem == null)
            {
                MessageBox.Show("Please select a ticket type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedType = cmbTicketType.SelectedItem.ToString();

            if (!controller.EventIDExists(eventID))
            {
                MessageBox.Show("Event ID does not exist.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!controller.IsTicketAvailable(eventID, selectedType, quantity, out string message))
            {
                MessageBox.Show(message, "Availability Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal? price = controller.GetTicketPriceByEventAndType(eventID, selectedType);
            if (price.HasValue)
            {
                lblPrice.Text = $"Price: Rs.{price.Value}";
                decimal total = price.Value * quantity;
                lblTotal.Text = $"Total: Rs.{total}";
                
            }
            else
            {
                MessageBox.Show("Price not found for selected ticket.", "Pricing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save and proceed
            try
            {
                string result = controller.SaveSale(eventID, selectedType, quantity);
                MessageBox.Show(result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate to payment form
                Payment_Admin paymentForm = new Payment_Admin();
                paymentForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backtouserbtn_Click(object sender, EventArgs e)
        {
            EventuserForm2 eventUserForm = new EventuserForm2();
            eventUserForm.Show();
            this.Hide();
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
