namespace Dbex
{
    partial class RegisterUser
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
            Button exit_btn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterUser));
            label1 = new Label();
            label2 = new Label();
            username_tb = new TextBox();
            password_tb = new TextBox();
            Register_btn = new Button();
            exit_btn = new Button();
            SuspendLayout();
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.SeaGreen;
            exit_btn.FlatStyle = FlatStyle.Flat;
            exit_btn.ForeColor = SystemColors.ControlLightLight;
            exit_btn.Location = new Point(50, 464);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(94, 48);
            exit_btn.TabIndex = 4;
            exit_btn.Text = "← Back";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(220, 159);
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
            label2.Location = new Point(220, 236);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // username_tb
            // 
            username_tb.BackColor = SystemColors.Menu;
            username_tb.BorderStyle = BorderStyle.None;
            username_tb.Location = new Point(374, 170);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(237, 16);
            username_tb.TabIndex = 2;
            // 
            // password_tb
            // 
            password_tb.BackColor = SystemColors.Menu;
            password_tb.BorderStyle = BorderStyle.None;
            password_tb.Location = new Point(374, 248);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(237, 16);
            password_tb.TabIndex = 3;
            // 
            // Register_btn
            // 
            Register_btn.BackColor = Color.FromArgb(192, 255, 192);
            Register_btn.FlatStyle = FlatStyle.Flat;
            Register_btn.ForeColor = Color.DarkGreen;
            Register_btn.Location = new Point(341, 336);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(159, 47);
            Register_btn.TabIndex = 5;
            Register_btn.Text = "Register";
            Register_btn.UseVisualStyleBackColor = false;
            Register_btn.Click += Register_btn_Click_1;
            // 
            // RegisterUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(822, 548);
            Controls.Add(Register_btn);
            Controls.Add(exit_btn);
            Controls.Add(password_tb);
            Controls.Add(username_tb);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DarkGreen;
            Name = "RegisterUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username_tb;
        private TextBox password_tb;
        private Button Register_btn;
    }
}