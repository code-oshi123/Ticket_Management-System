namespace Dbex
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            username_tb = new TextBox();
            password_tb = new TextBox();
            signin_btn = new Button();
            back_btn = new Button();
            Login_btn = new Button();
            forgetPW_label = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(236, 170);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(236, 239);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(360, 85);
            label3.Name = "label3";
            label3.Size = new Size(165, 37);
            label3.TabIndex = 2;
            label3.Text = "USER LOGIN";
            // 
            // username_tb
            // 
            username_tb.BackColor = Color.DarkSeaGreen;
            username_tb.BorderStyle = BorderStyle.None;
            username_tb.Location = new Point(424, 181);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(200, 16);
            username_tb.TabIndex = 3;
            // 
            // password_tb
            // 
            password_tb.BackColor = Color.DarkSeaGreen;
            password_tb.BorderStyle = BorderStyle.None;
            password_tb.Location = new Point(424, 255);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(200, 16);
            password_tb.TabIndex = 4;
            // 
            // signin_btn
            // 
            signin_btn.BackColor = Color.FromArgb(192, 255, 192);
            signin_btn.FlatStyle = FlatStyle.Flat;
            signin_btn.ForeColor = Color.DarkGreen;
            signin_btn.Location = new Point(217, 327);
            signin_btn.Name = "signin_btn";
            signin_btn.Size = new Size(155, 38);
            signin_btn.TabIndex = 5;
            signin_btn.Text = "Sign in";
            signin_btn.UseVisualStyleBackColor = false;
            signin_btn.Click += signin_btn_Click;
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.SeaGreen;
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.ForeColor = SystemColors.ControlLightLight;
            back_btn.Location = new Point(61, 463);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(85, 43);
            back_btn.TabIndex = 6;
            back_btn.Text = "← Back";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click_1;
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.FromArgb(192, 255, 192);
            Login_btn.FlatStyle = FlatStyle.Flat;
            Login_btn.ForeColor = Color.DarkGreen;
            Login_btn.Location = new Point(493, 327);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(155, 38);
            Login_btn.TabIndex = 7;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click_1;
            // 
            // forgetPW_label
            // 
            forgetPW_label.AutoSize = true;
            forgetPW_label.BackColor = Color.Transparent;
            forgetPW_label.LinkColor = Color.ForestGreen;
            forgetPW_label.Location = new Point(538, 394);
            forgetPW_label.Name = "forgetPW_label";
            forgetPW_label.Size = new Size(110, 15);
            forgetPW_label.TabIndex = 9;
            forgetPW_label.TabStop = true;
            forgetPW_label.Text = "🔗 Forgot Password";
            forgetPW_label.LinkClicked += forgetPW_label_LinkClicked_1;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(815, 541);
            Controls.Add(forgetPW_label);
            Controls.Add(Login_btn);
            Controls.Add(back_btn);
            Controls.Add(signin_btn);
            Controls.Add(password_tb);
            Controls.Add(username_tb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DarkGreen;
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username_tb;
        private TextBox password_tb;
        private Button signin_btn;
        private Button back_btn;
        private Button Login_btn;
        private LinkLabel forgetPW_label;
    }
}