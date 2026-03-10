namespace Dbex
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            label1 = new Label();
            linkLabel4 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 15F);
            linkLabel1.ForeColor = Color.DarkGreen;
            linkLabel1.LinkColor = Color.ForestGreen;
            linkLabel1.Location = new Point(328, 166);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(193, 28);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Add/Delete Location";
            linkLabel1.VisitedLinkColor = Color.LightGreen;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Segoe UI", 15F);
            linkLabel2.ForeColor = Color.DarkGreen;
            linkLabel2.LinkColor = Color.ForestGreen;
            linkLabel2.Location = new Point(359, 218);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(114, 28);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "View Events";
            linkLabel2.VisitedLinkColor = Color.LightGreen;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.Transparent;
            linkLabel3.Font = new Font("Segoe UI", 15F);
            linkLabel3.ForeColor = Color.DarkGreen;
            linkLabel3.LinkColor = Color.ForestGreen;
            linkLabel3.Location = new Point(314, 268);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(218, 28);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "View Sales and Revenue";
            linkLabel3.VisitedLinkColor = Color.LightGreen;
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(294, 85);
            label1.Name = "label1";
            label1.Size = new Size(232, 37);
            label1.TabIndex = 3;
            label1.Text = "Admin Dashboard";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.BackColor = Color.Transparent;
            linkLabel4.Font = new Font("Segoe UI", 15F);
            linkLabel4.ForeColor = Color.DarkGreen;
            linkLabel4.LinkColor = Color.ForestGreen;
            linkLabel4.Location = new Point(359, 328);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(117, 28);
            linkLabel4.TabIndex = 4;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "View Tickets";
            linkLabel4.VisitedLinkColor = Color.LightGreen;
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.BackColor = Color.Transparent;
            linkLabel5.Font = new Font("Segoe UI", 15F);
            linkLabel5.ForeColor = Color.DarkGreen;
            linkLabel5.LinkColor = Color.ForestGreen;
            linkLabel5.Location = new Point(348, 393);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(141, 28);
            linkLabel5.TabIndex = 5;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "View Feedback";
            linkLabel5.VisitedLinkColor = Color.LightGreen;
            linkLabel5.LinkClicked += linkLabel5_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(51, 466);
            button1.Name = "button1";
            button1.Size = new Size(82, 43);
            button1.TabIndex = 6;
            button1.Text = "← Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(813, 545);
            Controls.Add(button1);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel4);
            Controls.Add(label1);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            ForeColor = Color.DarkGreen;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Label label1;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
        private Button button1;
    }
}