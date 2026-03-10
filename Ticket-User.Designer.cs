namespace Dbex
{
    partial class Ticket_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket_User));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEventID = new TextBox();
            txtQuantity = new TextBox();
            cmbTicketType = new ComboBox();
            btnLoadTickets = new Button();
            lblPrice = new Label();
            lblTotal = new Label();
            label6 = new Label();
            backtouserbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(210, 140);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Event ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(210, 196);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Ticket Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(210, 242);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Quantity :";
            // 
            // txtEventID
            // 
            txtEventID.BackColor = Color.DarkSeaGreen;
            txtEventID.Location = new Point(359, 140);
            txtEventID.Name = "txtEventID";
            txtEventID.Size = new Size(244, 23);
            txtEventID.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.DarkSeaGreen;
            txtQuantity.Location = new Point(359, 239);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(244, 23);
            txtQuantity.TabIndex = 4;
            // 
            // cmbTicketType
            // 
            cmbTicketType.BackColor = Color.DarkSeaGreen;
            cmbTicketType.FormattingEnabled = true;
            cmbTicketType.Items.AddRange(new object[] { "VIP", "Genaral" });
            cmbTicketType.Location = new Point(359, 196);
            cmbTicketType.Name = "cmbTicketType";
            cmbTicketType.Size = new Size(244, 23);
            cmbTicketType.TabIndex = 5;
            // 
            // btnLoadTickets
            // 
            btnLoadTickets.BackColor = Color.FromArgb(192, 255, 192);
            btnLoadTickets.FlatStyle = FlatStyle.Flat;
            btnLoadTickets.ForeColor = Color.DarkGreen;
            btnLoadTickets.Location = new Point(347, 306);
            btnLoadTickets.Name = "btnLoadTickets";
            btnLoadTickets.Size = new Size(145, 35);
            btnLoadTickets.TabIndex = 6;
            btnLoadTickets.Text = "Place Ticket";
            btnLoadTickets.UseVisualStyleBackColor = false;
            btnLoadTickets.Click += btnLoadTickets_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Segoe UI", 11F);
            lblPrice.ForeColor = Color.DarkGreen;
            lblPrice.Location = new Point(347, 365);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(156, 20);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "\"Price per ticket: Rs. 0\"";
            lblPrice.Click += lblPrice_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 11F);
            lblTotal.ForeColor = Color.DarkGreen;
            lblTotal.Location = new Point(340, 401);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(174, 20);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "\"Total Ticket Price : Rs. 0\"";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(289, 60);
            label6.Name = "label6";
            label6.Size = new Size(283, 28);
            label6.TabIndex = 9;
            label6.Text = "--Ticket Management System--";
            label6.Click += label6_Click;
            // 
            // backtouserbtn
            // 
            backtouserbtn.BackColor = Color.SeaGreen;
            backtouserbtn.FlatStyle = FlatStyle.Flat;
            backtouserbtn.ForeColor = SystemColors.ControlLightLight;
            backtouserbtn.Location = new Point(57, 463);
            backtouserbtn.Name = "backtouserbtn";
            backtouserbtn.Size = new Size(86, 47);
            backtouserbtn.TabIndex = 10;
            backtouserbtn.Text = "← Back";
            backtouserbtn.UseVisualStyleBackColor = false;
            backtouserbtn.Click += backtouserbtn_Click;
            // 
            // Ticket_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(823, 549);
            Controls.Add(backtouserbtn);
            Controls.Add(label6);
            Controls.Add(lblTotal);
            Controls.Add(lblPrice);
            Controls.Add(btnLoadTickets);
            Controls.Add(cmbTicketType);
            Controls.Add(txtQuantity);
            Controls.Add(txtEventID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DarkGreen;
            Name = "Ticket_User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket_User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEventID;
        private TextBox txtQuantity;
        private ComboBox cmbTicketType;
        private Button btnLoadTickets;
        private Label lblPrice;
        private Label lblTotal;
        private Label label6;
        private Button backtouserbtn;
    }
}