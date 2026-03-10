namespace Dbex
{
    partial class OrganizerMenuEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizerMenuEventForm));
            organizeraddeventlinkLabel = new LinkLabel();
            organizerdeleteevntlinkLabel = new LinkLabel();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // organizeraddeventlinkLabel
            // 
            organizeraddeventlinkLabel.AutoSize = true;
            organizeraddeventlinkLabel.BackColor = Color.Transparent;
            organizeraddeventlinkLabel.Font = new Font("Segoe UI", 15F);
            organizeraddeventlinkLabel.ForeColor = Color.DarkGreen;
            organizeraddeventlinkLabel.LinkColor = Color.ForestGreen;
            organizeraddeventlinkLabel.Location = new Point(338, 225);
            organizeraddeventlinkLabel.Name = "organizeraddeventlinkLabel";
            organizeraddeventlinkLabel.Size = new Size(153, 28);
            organizeraddeventlinkLabel.TabIndex = 0;
            organizeraddeventlinkLabel.TabStop = true;
            organizeraddeventlinkLabel.Text = "ADD/EDIT Event";
            organizeraddeventlinkLabel.LinkClicked += organizeraddeventlinkLabel_LinkClicked;
            // 
            // organizerdeleteevntlinkLabel
            // 
            organizerdeleteevntlinkLabel.AutoSize = true;
            organizerdeleteevntlinkLabel.BackColor = Color.Transparent;
            organizerdeleteevntlinkLabel.Font = new Font("Segoe UI", 15F);
            organizerdeleteevntlinkLabel.ForeColor = Color.DarkGreen;
            organizerdeleteevntlinkLabel.LinkColor = Color.ForestGreen;
            organizerdeleteevntlinkLabel.Location = new Point(350, 289);
            organizerdeleteevntlinkLabel.Name = "organizerdeleteevntlinkLabel";
            organizerdeleteevntlinkLabel.Size = new Size(121, 28);
            organizerdeleteevntlinkLabel.TabIndex = 2;
            organizerdeleteevntlinkLabel.TabStop = true;
            organizerdeleteevntlinkLabel.Text = "Delete Event";
            organizerdeleteevntlinkLabel.LinkClicked += organizerdeleteevntlinkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(311, 116);
            label1.Name = "label1";
            label1.Size = new Size(208, 37);
            label1.TabIndex = 4;
            label1.Text = "Organizer Menu";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 15F);
            linkLabel1.ForeColor = Color.DarkGreen;
            linkLabel1.LinkColor = Color.ForestGreen;
            linkLabel1.Location = new Point(350, 360);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(141, 28);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "View Payments";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(35, 481);
            button1.Name = "button1";
            button1.Size = new Size(87, 41);
            button1.TabIndex = 6;
            button1.Text = "← Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // OrganizerMenuEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(824, 550);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(organizerdeleteevntlinkLabel);
            Controls.Add(organizeraddeventlinkLabel);
            ForeColor = Color.DarkGreen;
            Margin = new Padding(3, 2, 3, 2);
            Name = "OrganizerMenuEventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrganizerMenuEventForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel organizeraddeventlinkLabel;
        private LinkLabel organizerdeleteevntlinkLabel;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}