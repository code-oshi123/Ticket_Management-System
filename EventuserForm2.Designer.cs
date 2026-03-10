namespace Dbex
{
    partial class EventuserForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventuserForm2));
            vieweventuserlistBox1 = new ListBox();
            bookticketbutton1 = new Button();
            label1 = new Label();
            vieweventUserbutton1 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // vieweventuserlistBox1
            // 
            vieweventuserlistBox1.BackColor = Color.FromArgb(192, 255, 192);
            vieweventuserlistBox1.Font = new Font("Segoe UI", 11F);
            vieweventuserlistBox1.ForeColor = Color.DarkGreen;
            vieweventuserlistBox1.FormattingEnabled = true;
            vieweventuserlistBox1.ItemHeight = 20;
            vieweventuserlistBox1.Location = new Point(151, 91);
            vieweventuserlistBox1.Margin = new Padding(3, 2, 3, 2);
            vieweventuserlistBox1.Name = "vieweventuserlistBox1";
            vieweventuserlistBox1.Size = new Size(507, 264);
            vieweventuserlistBox1.TabIndex = 0;
            // 
            // bookticketbutton1
            // 
            bookticketbutton1.BackColor = Color.FromArgb(192, 255, 192);
            bookticketbutton1.FlatStyle = FlatStyle.Flat;
            bookticketbutton1.ForeColor = Color.DarkGreen;
            bookticketbutton1.Location = new Point(538, 389);
            bookticketbutton1.Margin = new Padding(3, 2, 3, 2);
            bookticketbutton1.Name = "bookticketbutton1";
            bookticketbutton1.Size = new Size(179, 35);
            bookticketbutton1.TabIndex = 1;
            bookticketbutton1.Text = "Book Ticket";
            bookticketbutton1.UseVisualStyleBackColor = false;
            bookticketbutton1.Click += bookticketbutton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(216, 42);
            label1.Name = "label1";
            label1.Size = new Size(401, 37);
            label1.TabIndex = 2;
            label1.Text = "View Event And Book your Event";
            // 
            // vieweventUserbutton1
            // 
            vieweventUserbutton1.BackColor = Color.FromArgb(192, 255, 192);
            vieweventUserbutton1.FlatStyle = FlatStyle.Flat;
            vieweventUserbutton1.ForeColor = Color.DarkGreen;
            vieweventUserbutton1.Location = new Point(93, 389);
            vieweventUserbutton1.Margin = new Padding(3, 2, 3, 2);
            vieweventUserbutton1.Name = "vieweventUserbutton1";
            vieweventUserbutton1.Size = new Size(179, 35);
            vieweventUserbutton1.TabIndex = 3;
            vieweventUserbutton1.Text = "View Events";
            vieweventUserbutton1.UseVisualStyleBackColor = false;
            vieweventUserbutton1.Click += vieweventUserbutton1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(48, 465);
            button1.Name = "button1";
            button1.Size = new Size(77, 42);
            button1.TabIndex = 4;
            button1.Text = "← Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EventuserForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(813, 546);
            Controls.Add(button1);
            Controls.Add(vieweventUserbutton1);
            Controls.Add(label1);
            Controls.Add(bookticketbutton1);
            Controls.Add(vieweventuserlistBox1);
            ForeColor = Color.DarkGreen;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EventuserForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventuserForm2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox vieweventuserlistBox1;
        private Button bookticketbutton1;
        private Label label1;
        private Button vieweventUserbutton1;
        private Button button1;
    }
}