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
    public partial class AdminevviewForm : Form
    {
        public AdminevviewForm()
        {
            InitializeComponent();
        }

        private void vieweventadminbackbutton_Click(object sender, EventArgs e)
        {
            AdditemForm newform = new AdditemForm();
            newform.Show();
            this.Hide();
        }

        private void vieweventsadminbutton_Click(object sender, EventArgs e)
        {
            var events = AdminConClass.ViewAdminLocation();

            if (events == null)
            {
                MessageBox.Show("Failed to load items from database,(Emety)");
                return;
            }

            if (events.Count == 0)
            {
                MessageBox.Show("No items found in database");
                return;
            }

            // Clear and populate ListBox
            adminevviewlistBox.Items.Clear();
            adminevviewlistBox.Items.Add(" Location ID | Location Name | Location Address | Location Ownwer | Morning Availability | Evening Availability");
            adminevviewlistBox.Items.Add("-------------------------------------------------------------");
            adminevviewlistBox.Items.AddRange(events.ToArray());

            MessageBox.Show($"Loaded {events.Count} items");
        }
    }
}
