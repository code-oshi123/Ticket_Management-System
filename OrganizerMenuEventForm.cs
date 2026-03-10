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
    public partial class OrganizerMenuEventForm : Form
    {
        public OrganizerMenuEventForm()
        {
            InitializeComponent();
        }

        private void organizeraddeventlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdditemForm additem = new AdditemForm();
            additem.Show();
            this.Hide();
        }

        private void organizervieweventlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewEventForm viewform = new ViewEventForm();
            viewform.Show();
            this.Hide();

        }

        private void organizerdeleteevntlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteEventForm deleteevent = new DeleteEventForm();
            deleteevent.Show();
            this.Hide();
        }

        private void organizereventlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewFeedbackForm viewfeed = new ViewFeedbackForm();
            viewfeed.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Payment_Organizer paymentOrganizer = new Payment_Organizer();
            paymentOrganizer.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Organizer orgnizer_login = new Organizer();
            orgnizer_login.Show();
            this.Hide();
        }
    }
}
