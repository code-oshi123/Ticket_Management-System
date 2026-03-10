using Dbex.Controller;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbex
{
    public partial class Payment_Admin : Form
    {
        public Payment_Admin()
        {
            InitializeComponent();
        }

        private void Payment_Admin_Load(object sender, EventArgs e)
        {
            txtCardNumber.MaxLength = 19; // 16 digits + 3 dashes
            txtExpiry.MaxLength = 7;      // MM/YYYY
            txtCVV.MaxLength = 3;
            txtCardNumber.PasswordChar = '\0';
            txtExpiry.PasswordChar = '\0';
            txtCVV.PasswordChar = '*';
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtCardNumber.Text == "" || txtExpiry.Text == "" || txtCVV.Text == "" || txtAmount.Text == "")
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(txtCardNumber.Text, @"^\d{4}-\d{4}-\d{4}-\d{4}$"))
            {
                MessageBox.Show("Card number must be in format 1111-2222-3333-4444", "Invalid Card", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txtCVV.Text, @"^\d{3}$"))
            {
                MessageBox.Show("CVV must be exactly 3 digits", "Invalid CVV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateExpiry(txtExpiry.Text))
            {
                MessageBox.Show("Expiry must be in MM/YYYY and not expired.", "Invalid Expiry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connStr = "server=localhost;user=root;password=;database=ticketdb;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "INSERT INTO payments (name, amount) VALUES (@name, @amount)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(txtAmount.Text));
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Payment Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payment: " + ex.Message);
            }
        }

        private bool ValidateExpiry(string expiry)
        {
            if (!Regex.IsMatch(expiry, @"^(0[1-9]|1[0-2])/20\d{2}$"))
                return false;

            var parts = expiry.Split('/');
            int mm = int.Parse(parts[0]);
            int yyyy = int.Parse(parts[1]);

            DateTime now = DateTime.Now;
            return yyyy > now.Year || (yyyy == now.Year && mm > now.Month);
        }


        private void txtCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            string raw = txtCardNumber.Text.Replace("-", "");
            if (raw.Length > 16) raw = raw.Substring(0, 16);

            string formatted = "";
            for (int i = 0; i < raw.Length; i++)
            {
                if (i > 0 && i % 4 == 0) formatted += "-";
                formatted += raw[i];
            }

            int selStart = txtCardNumber.SelectionStart;
            txtCardNumber.Text = formatted;
            txtCardNumber.SelectionStart = Math.Min(selStart + 1, txtCardNumber.Text.Length);
        }

        private void txtExpiry_TextChanged(object sender, EventArgs e)
        {
            string text = txtExpiry.Text.Replace("/", "");
            if (text.Length > 6) text = text.Substring(0, 6);

            if (text.Length >= 3)
                txtExpiry.Text = text.Insert(2, "/");
            else
                txtExpiry.Text = text;

            txtExpiry.SelectionStart = txtExpiry.Text.Length;
        }
        private void ClearFields()
        {
            txtName.Clear();
            txtCardNumber.Clear();
            txtExpiry.Clear();
            txtCVV.Clear();
            txtAmount.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Ticket_User tikuser = new Ticket_User();
            tikuser.Show();
            this.Hide();
        }
        
        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            TicketController controller = new TicketController();

            if (decimal.TryParse(txtAmount.Text, out decimal total))
            {
                string message = controller.Gettotalprice(total);
                txtAmount.Text = message; // Assume you have a Label named lblTotalPriceMessage
            }
            else
            {
                txtAmount.Text = "Invalid amount format.";
            }

        }

        
    }

}
