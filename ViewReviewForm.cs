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
    public partial class ViewReviewForm : Form
    {
        public ViewReviewForm()
        {
            InitializeComponent();
        }

        private void Addreviewbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ReviewConClass.AddReview(reviewidtextBox.Text, revieweventnametextBox.Text, reviewtextBox.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserEventHomeForm3 tikuser = new UserEventHomeForm3();
            tikuser.Show();
            this.Hide();

        }

        private void ViewReviewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
