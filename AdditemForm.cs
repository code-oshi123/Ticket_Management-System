
﻿using System;
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
    public partial class AdditemForm : Form
    {
        public AdditemForm()
        {
            InitializeComponent();
        }

        private void addevntbutton_Click(object sender, EventArgs e)
        {
            string result = EventconClass.AddEvent(
    eidtextBox.Text,
    organizeridevtextBox1.Text,
    enametextBox.Text,
    edestextBox.Text,
    edateTimePicker.Value,
    eloctextBox.Text,
    eventtimetextBox2.Text,
    locationaddidtextBox11.Text
);

            MessageBox.Show(result);

            if (result.ToLower().Contains("success")) // Adjust this based on actual message
            {
                eidtextBox.Clear();
                organizeridevtextBox1.Clear();
                enametextBox.Clear();
                edestextBox.Clear();
                eloctextBox.Clear();
                eventtimetextBox2.Clear();
                locationaddidtextBox11.Clear();

                Ticket_Organizer ticketOrganizer = new Ticket_Organizer();
                ticketOrganizer.Show();
                this.Hide();
            }

        }

        private void BackTobutton_Click(object sender, EventArgs e)
        {
            OrganizerMenuEventForm ormenuForm = new OrganizerMenuEventForm();
            ormenuForm.Show();
            this.Hide();
        }

        private void vieweventgobutton_Click(object sender, EventArgs e)
        {
            AdminevviewForm newview = new AdminevviewForm();
            newview.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdditemForm_Load(object sender, EventArgs e)
        {

        }
    }
}

