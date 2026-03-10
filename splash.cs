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
    public partial class splash : Form
    {
        private System.Windows.Forms.Timer timer;


        public splash()
        {
            InitializeComponent();
            // Set timer for 3 seconds
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000; // 3 seconds
            timer.Tick += Timer_Tick;
            timer.Start();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            // Show RoleSelectionForm
            Roleselection roleForm = new Roleselection();
            roleForm.Show();

            // Hide or close Splash
            this.Hide(); // or this.Close();
        }
    }
}
