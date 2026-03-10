namespace Dbex
{
    partial class Payment_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_Admin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtExpiry = new TextBox();
            txtCardNumber = new TextBox();
            txtCVV = new TextBox();
            txtAmount = new TextBox();
            btnPay = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(336, 49);
            label1.Name = "label1";
            label1.Size = new Size(186, 37);
            label1.TabIndex = 0;
            label1.Text = "Payment Poral";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(225, 104);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 1;
            label2.Text = "Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(225, 159);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 2;
            label3.Text = "Card Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(225, 212);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 3;
            label4.Text = "Expiry (MM/YYYY):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13F);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(225, 265);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 4;
            label5.Text = "CVV:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13F);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(225, 318);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 5;
            label6.Text = "Amount (LKR):";
            // 
            // txtName
            // 
            txtName.BackColor = Color.DarkSeaGreen;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(421, 110);
            txtName.Name = "txtName";
            txtName.Size = new Size(210, 16);
            txtName.TabIndex = 6;
            // 
            // txtExpiry
            // 
            txtExpiry.BackColor = Color.DarkSeaGreen;
            txtExpiry.BorderStyle = BorderStyle.None;
            txtExpiry.Location = new Point(421, 218);
            txtExpiry.Name = "txtExpiry";
            txtExpiry.Size = new Size(210, 16);
            txtExpiry.TabIndex = 7;
            // 
            // txtCardNumber
            // 
            txtCardNumber.BackColor = Color.DarkSeaGreen;
            txtCardNumber.BorderStyle = BorderStyle.None;
            txtCardNumber.Location = new Point(421, 165);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(210, 16);
            txtCardNumber.TabIndex = 8;
            // 
            // txtCVV
            // 
            txtCVV.BackColor = Color.DarkSeaGreen;
            txtCVV.BorderStyle = BorderStyle.None;
            txtCVV.Location = new Point(421, 271);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(210, 16);
            txtCVV.TabIndex = 9;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.DarkSeaGreen;
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.Location = new Point(421, 324);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(210, 16);
            txtAmount.TabIndex = 10;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(192, 255, 192);
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.ForeColor = Color.DarkGreen;
            btnPay.Location = new Point(364, 392);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(158, 41);
            btnPay.TabIndex = 11;
            btnPay.Text = "Pay Now";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SeaGreen;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(47, 464);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 41);
            btnBack.TabIndex = 12;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Payment_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(831, 535);
            Controls.Add(btnBack);
            Controls.Add(btnPay);
            Controls.Add(txtAmount);
            Controls.Add(txtCVV);
            Controls.Add(txtCardNumber);
            Controls.Add(txtExpiry);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DarkGreen;
            Name = "Payment_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment_Admin";
            Load += Payment_Admin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtExpiry;
        private TextBox txtCardNumber;
        private TextBox txtCVV;
        private TextBox txtAmount;
        private Button btnPay;
        private Button btnBack;
    }
}