namespace Dbex
{
    partial class Organizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Organizer));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            username_btn = new TextBox();
            organizerid_btn = new TextBox();
            password_btn = new TextBox();
            back_btn = new Button();
            Login_btn = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(229, 170);
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
            label2.Location = new Point(229, 219);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(229, 272);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 2;
            label3.Text = "Organizer ID ";
            // 
            // username_btn
            // 
            username_btn.BackColor = Color.DarkSeaGreen;
            username_btn.BorderStyle = BorderStyle.None;
            username_btn.Location = new Point(402, 181);
            username_btn.Name = "username_btn";
            username_btn.Size = new Size(200, 16);
            username_btn.TabIndex = 3;
            // 
            // organizerid_btn
            // 
            organizerid_btn.BackColor = Color.DarkSeaGreen;
            organizerid_btn.BorderStyle = BorderStyle.None;
            organizerid_btn.Location = new Point(402, 283);
            organizerid_btn.Name = "organizerid_btn";
            organizerid_btn.Size = new Size(200, 16);
            organizerid_btn.TabIndex = 4;
            // 
            // password_btn
            // 
            password_btn.BackColor = Color.DarkSeaGreen;
            password_btn.BorderStyle = BorderStyle.None;
            password_btn.Location = new Point(402, 230);
            password_btn.Name = "password_btn";
            password_btn.Size = new Size(200, 16);
            password_btn.TabIndex = 5;
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.SeaGreen;
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.ForeColor = SystemColors.ButtonHighlight;
            back_btn.Location = new Point(50, 460);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(86, 48);
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
            Login_btn.Location = new Point(349, 348);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(160, 41);
            Login_btn.TabIndex = 7;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 20F);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(287, 83);
            label4.Name = "label4";
            label4.Size = new Size(246, 37);
            label4.TabIndex = 8;
            label4.Text = "ORGANIZER LOGIN";
            // 
            // Organizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(806, 541);
            Controls.Add(label4);
            Controls.Add(Login_btn);
            Controls.Add(back_btn);
            Controls.Add(password_btn);
            Controls.Add(organizerid_btn);
            Controls.Add(username_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Organizer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Organizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username_btn;
        private TextBox organizerid_btn;
        private TextBox password_btn;
        private Button back_btn;
        private Button Login_btn;
        private Label label4;
    }
}