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
    public partial class ForgetpasswordForm : Form
    {
        public ForgetpasswordForm()
        {
            InitializeComponent();
        }
        private void reset_btn_Click(object sender, EventArgs e)
        {
            string userId = username_tb.Text;
            string newPass = newpass_tb.Text;
            string confirmPass = confirmpass_tb.Text;

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }

        private void reset_btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
