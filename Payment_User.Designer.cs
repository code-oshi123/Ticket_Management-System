namespace Dbex
{
    partial class Payment_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_User));
            label1 = new Label();
            lblRevenue = new Label();
            lblEvents = new Label();
            lblTickets = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(312, 55);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 0;
            label1.Text = "Admin Summary";
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.BackColor = Color.Transparent;
            lblRevenue.Font = new Font("Segoe UI", 15F);
            lblRevenue.ForeColor = Color.DarkGreen;
            lblRevenue.Location = new Point(220, 167);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(141, 28);
            lblRevenue.TabIndex = 1;
            lblRevenue.Text = "Total Revenue :";
            // 
            // lblEvents
            // 
            lblEvents.AutoSize = true;
            lblEvents.BackColor = Color.Transparent;
            lblEvents.Font = new Font("Segoe UI", 15F);
            lblEvents.ForeColor = Color.DarkGreen;
            lblEvents.Location = new Point(220, 237);
            lblEvents.Name = "lblEvents";
            lblEvents.Size = new Size(124, 28);
            lblEvents.TabIndex = 2;
            lblEvents.Text = "Total Events :";
            // 
            // lblTickets
            // 
            lblTickets.AutoSize = true;
            lblTickets.BackColor = Color.Transparent;
            lblTickets.Font = new Font("Segoe UI", 15F);
            lblTickets.ForeColor = Color.DarkGreen;
            lblTickets.Location = new Point(220, 308);
            lblTickets.Name = "lblTickets";
            lblTickets.Size = new Size(152, 28);
            lblTickets.TabIndex = 3;
            lblTickets.Text = "Tickets Booked :";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SeaGreen;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(54, 467);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 41);
            btnBack.TabIndex = 4;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Payment_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(823, 550);
            Controls.Add(btnBack);
            Controls.Add(lblTickets);
            Controls.Add(lblEvents);
            Controls.Add(lblRevenue);
            Controls.Add(label1);
            ForeColor = Color.DarkGreen;
            Name = "Payment_User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment_User";
            Load += Payment_User_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblRevenue;
        private Label lblEvents;
        private Label lblTickets;
        private Button btnBack;
    }
}