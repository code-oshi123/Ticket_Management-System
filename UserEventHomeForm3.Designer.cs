namespace Dbex
{
    partial class UserEventHomeForm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEventHomeForm3));
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            linkLabel2 = new LinkLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 15F);
            linkLabel1.LinkColor = Color.ForestGreen;
            linkLabel1.Location = new Point(358, 210);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(110, 28);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Book Event";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(281, 128);
            label1.Name = "label1";
            label1.Size = new Size(260, 37);
            label1.TabIndex = 1;
            label1.Text = "--Book Your Event --";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Segoe UI", 15F);
            linkLabel2.LinkColor = Color.ForestGreen;
            linkLabel2.Location = new Point(335, 268);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(159, 28);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Add your Review";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(51, 463);
            button1.Name = "button1";
            button1.Size = new Size(83, 45);
            button1.TabIndex = 3;
            button1.Text = "← Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserEventHomeForm3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(822, 546);
            Controls.Add(button1);
            Controls.Add(linkLabel2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserEventHomeForm3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserEventHomeForm3";
            Load += UserEventHomeForm3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label1;
        private LinkLabel linkLabel2;
        private Button button1;
    }
}