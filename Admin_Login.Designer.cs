namespace Dbex
{
    partial class Admin_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            username_tb = new TextBox();
            password_tb = new TextBox();
            AdminID_tb = new TextBox();
            back_btn = new Button();
            Adminlogin_btn = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(230, 153);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(230, 213);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(230, 276);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 2;
            label3.Text = "AdminID";
            // 
            // username_tb
            // 
            username_tb.BackColor = Color.DarkSeaGreen;
            username_tb.BorderStyle = BorderStyle.None;
            username_tb.ForeColor = Color.DarkSlateGray;
            username_tb.Location = new Point(390, 164);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(200, 16);
            username_tb.TabIndex = 4;
            // 
            // password_tb
            // 
            password_tb.BackColor = Color.DarkSeaGreen;
            password_tb.BorderStyle = BorderStyle.None;
            password_tb.ForeColor = Color.DarkSlateGray;
            password_tb.Location = new Point(390, 225);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(200, 16);
            password_tb.TabIndex = 5;
            // 
            // AdminID_tb
            // 
            AdminID_tb.BackColor = Color.DarkSeaGreen;
            AdminID_tb.BorderStyle = BorderStyle.None;
            AdminID_tb.ForeColor = Color.DarkSlateGray;
            AdminID_tb.Location = new Point(390, 287);
            AdminID_tb.Name = "AdminID_tb";
            AdminID_tb.Size = new Size(200, 16);
            AdminID_tb.TabIndex = 6;
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.SeaGreen;
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.ForeColor = SystemColors.Control;
            back_btn.Location = new Point(43, 474);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(75, 41);
            back_btn.TabIndex = 7;
            back_btn.Text = "← Back";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click_1;
            // 
            // Adminlogin_btn
            // 
            Adminlogin_btn.BackColor = Color.FromArgb(192, 255, 192);
            Adminlogin_btn.FlatStyle = FlatStyle.Flat;
            Adminlogin_btn.ForeColor = Color.DarkGreen;
            Adminlogin_btn.Location = new Point(352, 356);
            Adminlogin_btn.Name = "Adminlogin_btn";
            Adminlogin_btn.Size = new Size(156, 41);
            Adminlogin_btn.TabIndex = 8;
            Adminlogin_btn.Text = "Login";
            Adminlogin_btn.UseVisualStyleBackColor = false;
            Adminlogin_btn.Click += Adminlogin_btn_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 20F);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(319, 78);
            label4.Name = "label4";
            label4.Size = new Size(189, 37);
            label4.TabIndex = 9;
            label4.Text = "ADMIN LOGIN";
            // 
            // Admin_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(813, 540);
            Controls.Add(label4);
            Controls.Add(Adminlogin_btn);
            Controls.Add(back_btn);
            Controls.Add(AdminID_tb);
            Controls.Add(password_tb);
            Controls.Add(username_tb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Admin_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Login";
            Load += Admin_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox username_tb;
        private TextBox password_tb;
        private TextBox AdminID_tb;
        private Button back_btn;
        private Button Adminlogin_btn;
        private Label label4;
    }
}