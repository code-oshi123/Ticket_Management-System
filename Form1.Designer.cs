namespace Dbex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            loginbtn = new Button();
            txtname = new TextBox();
            txtpass = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkbtn
            // 
            checkbtn.Location = new Point(410, 183);
            checkbtn.Margin = new Padding(3, 2, 3, 2);
            checkbtn.Name = "checkbtn";
            checkbtn.Size = new Size(145, 22);
            checkbtn.TabIndex = 0;
            checkbtn.Text = "check connection";
            checkbtn.UseVisualStyleBackColor = true;
            checkbtn.Click += checkbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 80);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 112);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "password";
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(171, 183);
            loginbtn.Margin = new Padding(3, 2, 3, 2);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(82, 22);
            loginbtn.TabIndex = 3;
            loginbtn.Text = "login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(256, 80);
            txtname.Margin = new Padding(3, 2, 3, 2);
            txtname.Name = "txtname";
            txtname.Size = new Size(110, 23);
            txtname.TabIndex = 4;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(256, 112);
            txtpass.Margin = new Padding(3, 2, 3, 2);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(110, 23);
            txtpass.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(72, 294);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "← Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(txtpass);
            Controls.Add(txtname);
            Controls.Add(loginbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkbtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button checkbtn;
        private Label label1;
        private Label label2;
        private Button loginbtn;
        private TextBox txtname;
        private TextBox txtpass;
        private Button button1;
    }
}
