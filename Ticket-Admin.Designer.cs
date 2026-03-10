namespace Dbex
{
    partial class Ticket_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket_Admin));
            dataGridViewTickets = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnViewTickets = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTickets
            // 
            dataGridViewTickets.BackgroundColor = Color.FromArgb(192, 255, 192);
            dataGridViewTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTickets.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewTickets.GridColor = Color.DarkGreen;
            dataGridViewTickets.Location = new Point(129, 73);
            dataGridViewTickets.Name = "dataGridViewTickets";
            dataGridViewTickets.Size = new Size(544, 244);
            dataGridViewTickets.TabIndex = 0;
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
            btnViewTickets.Location = new Point(320, 346);
            btnViewTickets.Name = "btnViewTickets";
            btnViewTickets.Size = new Size(155, 42);
            btnViewTickets.TabIndex = 1;
            btnViewTickets.Text = "View Tickets";
            btnViewTickets.UseVisualStyleBackColor = false;
            btnViewTickets.Click += btnViewTickets_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(39, 475);
            button1.Name = "button1";
            button1.Size = new Size(83, 40);
            button1.TabIndex = 2;
            button1.Text = "← Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Ticket_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(810, 551);
            Controls.Add(button1);
            Controls.Add(btnViewTickets);
            Controls.Add(dataGridViewTickets);
            ForeColor = Color.DarkGreen;
            Name = "Ticket_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket_Admin";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTickets;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnViewTickets;
        private Button button1;
    }
}