namespace Dbex
{
    partial class Payment_Organizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_Organizer));
            label1 = new Label();
            dgvPayments = new DataGridView();
            lblEventResult = new Label();
            txtEventId = new TextBox();
            btnCheckEvent = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(292, 42);
            label1.Name = "label1";
            label1.Size = new Size(242, 37);
            label1.TabIndex = 0;
            label1.Text = "Payments Received";
            // 
            // dgvPayments
            // 
            dgvPayments.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Location = new Point(111, 93);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.Size = new Size(581, 227);
            dgvPayments.TabIndex = 1;
            dgvPayments.CellContentClick += dgvPayments_CellContentClick;
            // 
            // lblEventResult
            // 
            lblEventResult.AutoSize = true;
            lblEventResult.BackColor = Color.Transparent;
            lblEventResult.Font = new Font("Segoe UI", 11F);
            lblEventResult.ForeColor = Color.DarkGreen;
            lblEventResult.Location = new Point(532, 374);
            lblEventResult.Name = "lblEventResult";
            lblEventResult.Size = new Size(95, 40);
            lblEventResult.TabIndex = 2;
            lblEventResult.Text = "Revenue :\nTickets Sold :";
            lblEventResult.Click += lblEventResult_Click;
            // 
            // txtEventId
            // 
            txtEventId.BackColor = Color.FromArgb(192, 255, 192);
            txtEventId.BorderStyle = BorderStyle.None;
            txtEventId.ForeColor = Color.DarkGreen;
            txtEventId.Location = new Point(137, 390);
            txtEventId.Name = "txtEventId";
            txtEventId.PlaceholderText = "Enter Event ID";
            txtEventId.Size = new Size(120, 16);
            txtEventId.TabIndex = 3;
            // 
            // btnCheckEvent
            // 
            btnCheckEvent.BackColor = Color.FromArgb(192, 255, 192);
            btnCheckEvent.FlatStyle = FlatStyle.Flat;
            btnCheckEvent.ForeColor = Color.DarkGreen;
            btnCheckEvent.Location = new Point(313, 374);
            btnCheckEvent.Name = "btnCheckEvent";
            btnCheckEvent.Size = new Size(142, 46);
            btnCheckEvent.TabIndex = 4;
            btnCheckEvent.Text = "Check Event";
            btnCheckEvent.UseVisualStyleBackColor = false;
            btnCheckEvent.Click += btnCheckEvent_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SeaGreen;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(48, 475);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 41);
            btnBack.TabIndex = 5;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Payment_Organizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(840, 553);
            Controls.Add(btnBack);
            Controls.Add(btnCheckEvent);
            Controls.Add(txtEventId);
            Controls.Add(lblEventResult);
            Controls.Add(dgvPayments);
            Controls.Add(label1);
            ForeColor = Color.DarkGreen;
            Name = "Payment_Organizer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment_Organizer";
            Load += Payment_Organizer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPayments;
        private Label lblEventResult;
        private TextBox txtEventId;
        private Button btnCheckEvent;
        private Button btnBack;
    }
}