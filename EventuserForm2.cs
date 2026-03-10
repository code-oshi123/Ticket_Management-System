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
    public partial class EventuserForm2 : Form
    {
        public EventuserForm2()
        {
            InitializeComponent();
        }

        private void vieweventUserbutton1_Click(object sender, EventArgs e)
        {
            var items = EventconClass.ViewEvents();

            if (items == null)
            {
                MessageBox.Show("Failed to load items from database");
                return;
            }

            if (items.Count == 0)
            {
                MessageBox.Show("No items found in database");
                return;
            }

            // Clear and populate ListBox
            vieweventuserlistBox1.Items.Clear();
            vieweventuserlistBox1.Items.Add(" Event ID|Event Name|Event Location | Event Description");
            vieweventuserlistBox1.Items.Add("-------------------------------------------------------------");
            vieweventuserlistBox1.Items.AddRange(items.ToArray());
            MessageBox.Show($"Loaded {items.Count} items");
        }

        private void bookticketbutton1_Click(object sender, EventArgs e)
        {
            Ticket_User tikuser = new Ticket_User();
            tikuser.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserEventHomeForm3 tikuser = new UserEventHomeForm3();
            tikuser.Show();
            this.Hide();

        }
    }
}
