namespace Dbex
{
    partial class ForgetpasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetpasswordForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            username_tb = new TextBox();
            confirmpass_tb = new TextBox();
            newpass_tb = new TextBox();
            exit_btn = new Button();
            reset_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(30, 58, 138);
            label1.Location = new Point(170, 183);
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
            label2.ForeColor = Color.FromArgb(30, 58, 138);
            label2.Location = new Point(170, 236);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 1;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.FromArgb(30, 58, 138);
            label3.Location = new Point(170, 290);
            label3.Name = "label3";
            label3.Size = new Size(168, 28);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 20F);
            label4.ForeColor = Color.FromArgb(30, 58, 138);
            label4.Location = new Point(292, 98);
            label4.Name = "label4";
            label4.Size = new Size(198, 37);
            label4.TabIndex = 3;
            label4.Text = "Reset Password";
            // 
            // username_tb
            // 
            username_tb.BackColor = SystemColors.Menu;
            username_tb.Location = new Point(362, 180);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(265, 23);
            username_tb.TabIndex = 4;
            // 
            // confirmpass_tb
            // 
            confirmpass_tb.BackColor = SystemColors.Menu;
            confirmpass_tb.Location = new Point(362, 282);
            confirmpass_tb.Name = "confirmpass_tb";
            confirmpass_tb.Size = new Size(265, 23);
            confirmpass_tb.TabIndex = 5;
            // 
            // newpass_tb
            // 
            newpass_tb.BackColor = SystemColors.Menu;
            newpass_tb.Location = new Point(362, 228);
            newpass_tb.Name = "newpass_tb";
            newpass_tb.Size = new Size(265, 23);
            newpass_tb.TabIndex = 6;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.FromArgb(192, 255, 192);
            exit_btn.ForeColor = Color.DarkGreen;
            exit_btn.Location = new Point(402, 348);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(87, 41);
            exit_btn.TabIndex = 7;
            exit_btn.Text = "Exit";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += this.exit_btn_Click_1;
            // 
            // reset_btn
            // 
            reset_btn.BackColor = Color.FromArgb(192, 255, 192);
            reset_btn.ForeColor = Color.DarkGreen;
            reset_btn.Location = new Point(534, 348);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(87, 41);
            reset_btn.TabIndex = 8;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = false;
            reset_btn.Click += reset_btn_Click_1;
            // 
            // ForgetpasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(822, 564);
            Controls.Add(reset_btn);
            Controls.Add(exit_btn);
            Controls.Add(newpass_tb);
            Controls.Add(confirmpass_tb);
            Controls.Add(username_tb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DarkGreen;
            Name = "ForgetpasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgetpasswordForm";
            Load += this.ForgetpasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox username_tb;
        private TextBox confirmpass_tb;
        private TextBox newpass_tb;
        private Button exit_btn;
        private Button reset_btn;
    }
}