namespace Dbex
{
    partial class Ticket_Organizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket_Organizer));
            txtEventID = new TextBox();
            txtDeleteTicketID = new TextBox();
            txtNewPrice = new TextBox();
            txtUpdateTicketID = new TextBox();
            txtAvailability = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnUpdatePrice = new Button();
            btnAddTicket = new Button();
            btnDeleteTicket = new Button();
            dataGridViewTickets = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnViewTickets = new Button();
            cmbType = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).BeginInit();
            SuspendLayout();
            // 
            // txtEventID
            // 
            txtEventID.BackColor = Color.DarkSeaGreen;
            txtEventID.Location = new Point(235, 59);
            txtEventID.Name = "txtEventID";
            txtEventID.Size = new Size(143, 23);
            txtEventID.TabIndex = 0;
            // 
            // txtDeleteTicketID
            // 
            txtDeleteTicketID.BackColor = Color.DarkSeaGreen;
            txtDeleteTicketID.Location = new Point(558, 179);
            txtDeleteTicketID.Name = "txtDeleteTicketID";
            txtDeleteTicketID.Size = new Size(143, 23);
            txtDeleteTicketID.TabIndex = 2;
            // 
            // txtNewPrice
            // 
            txtNewPrice.BackColor = Color.DarkSeaGreen;
            txtNewPrice.Location = new Point(558, 92);
            txtNewPrice.Name = "txtNewPrice";
            txtNewPrice.Size = new Size(143, 23);
            txtNewPrice.TabIndex = 3;
            // 
            // txtUpdateTicketID
            // 
            txtUpdateTicketID.BackColor = Color.DarkSeaGreen;
            txtUpdateTicketID.Location = new Point(558, 59);
            txtUpdateTicketID.Name = "txtUpdateTicketID";
            txtUpdateTicketID.Size = new Size(143, 23);
            txtUpdateTicketID.TabIndex = 4;
            // 
            // txtAvailability
            // 
            txtAvailability.BackColor = Color.DarkSeaGreen;
            txtAvailability.Location = new Point(234, 178);
            txtAvailability.Name = "txtAvailability";
            txtAvailability.Size = new Size(143, 23);
            txtAvailability.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.DarkSeaGreen;
            txtPrice.Location = new Point(234, 136);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(143, 23);
            txtPrice.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(91, 58);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 8;
            label1.Text = "Event ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(91, 95);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 9;
            label2.Text = "Ticket Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(464, 59);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 10;
            label3.Text = "Ticket ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(464, 100);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 11;
            label4.Text = "New Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(464, 182);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 12;
            label5.Text = "Ticket ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(91, 177);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 13;
            label6.Text = "Availability:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(91, 135);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 14;
            label7.Text = "Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 16F);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(282, 9);
            label8.Name = "label8";
            label8.Size = new Size(316, 30);
            label8.TabIndex = 15;
            label8.Text = "--Ticket Management System--";
            // 
            // btnUpdatePrice
            // 
            btnUpdatePrice.BackColor = Color.FromArgb(192, 255, 192);
            btnUpdatePrice.ForeColor = Color.DarkGreen;
            btnUpdatePrice.Location = new Point(583, 133);
            btnUpdatePrice.Name = "btnUpdatePrice";
            btnUpdatePrice.Size = new Size(118, 40);
            btnUpdatePrice.TabIndex = 16;
            btnUpdatePrice.Text = "Update Price";
            btnUpdatePrice.UseVisualStyleBackColor = false;
            btnUpdatePrice.Click += btnUpdatePrice_Click;
            // 
            // btnAddTicket
            // 
            btnAddTicket.BackColor = Color.FromArgb(192, 255, 192);
            btnAddTicket.ForeColor = Color.DarkGreen;
            btnAddTicket.Location = new Point(260, 215);
            btnAddTicket.Name = "btnAddTicket";
            btnAddTicket.Size = new Size(118, 40);
            btnAddTicket.TabIndex = 17;
            btnAddTicket.Text = "Add Ticket";
            btnAddTicket.UseVisualStyleBackColor = false;
            btnAddTicket.Click += btnAddTicket_Click;
            // 
            // btnDeleteTicket
            // 
            btnDeleteTicket.BackColor = Color.FromArgb(192, 255, 192);
            btnDeleteTicket.ForeColor = Color.DarkGreen;
            btnDeleteTicket.Location = new Point(583, 215);
            btnDeleteTicket.Name = "btnDeleteTicket";
            btnDeleteTicket.Size = new Size(118, 40);
            btnDeleteTicket.TabIndex = 18;
            btnDeleteTicket.Text = "Delete Ticket";
            btnDeleteTicket.UseVisualStyleBackColor = false;
            btnDeleteTicket.Click += btnDeleteTicket_Click;
            // 
            // dataGridViewTickets
            // 
            dataGridViewTickets.BackgroundColor = Color.FromArgb(192, 255, 192);
            dataGridViewTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTickets.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewTickets.Location = new Point(148, 277);
            dataGridViewTickets.Name = "dataGridViewTickets";
            dataGridViewTickets.Size = new Size(528, 194);
            dataGridViewTickets.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "EventID";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Type";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Availability";
            Column5.Name = "Column5";
            // 
            // btnViewTickets
            // 
            btnViewTickets.BackColor = Color.FromArgb(192, 255, 192);
            btnViewTickets.FlatStyle = FlatStyle.Flat;
            btnViewTickets.ForeColor = Color.DarkGreen;
            btnViewTickets.Location = new Point(364, 488);
            btnViewTickets.Name = "btnViewTickets";
            btnViewTickets.Size = new Size(124, 48);
            btnViewTickets.TabIndex = 20;
            btnViewTickets.Text = "View Tickets";
            btnViewTickets.UseVisualStyleBackColor = false;
            btnViewTickets.Click += btnViewTickets_Click;
            // 
            // cmbType
            // 
            cmbType.BackColor = Color.DarkSeaGreen;
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "VIP", "Genaral" });
            cmbType.Location = new Point(236, 97);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(141, 23);
            cmbType.TabIndex = 21;
            cmbType.SelectedIndexChanged += cmbTicketType_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(50, 465);
            button1.Name = "button1";
            button1.Size = new Size(85, 44);
            button1.TabIndex = 22;
            button1.Text = "← Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Ticket_Organizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(829, 548);
            Controls.Add(button1);
            Controls.Add(cmbType);
            Controls.Add(btnViewTickets);
            Controls.Add(dataGridViewTickets);
            Controls.Add(btnDeleteTicket);
            Controls.Add(btnAddTicket);
            Controls.Add(btnUpdatePrice);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtAvailability);
            Controls.Add(txtUpdateTicketID);
            Controls.Add(txtNewPrice);
            Controls.Add(txtDeleteTicketID);
            Controls.Add(txtEventID);
            ForeColor = Color.DarkGreen;
            Name = "Ticket_Organizer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket_Organizer";
            Load += Ticket_Organizer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEventID;
        private TextBox txtDeleteTicketID;
        private TextBox txtNewPrice;
        private TextBox txtUpdateTicketID;
        private TextBox txtAvailability;
        private TextBox txtPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnUpdatePrice;
        private Button btnAddTicket;
        private Button btnDeleteTicket;
        private DataGridView dataGridViewTickets;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnViewTickets;
        private ComboBox cmbType;
        private Button button1;
    }
}