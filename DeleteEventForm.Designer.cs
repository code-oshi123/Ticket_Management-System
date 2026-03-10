namespace Dbex
{
    partial class DeleteEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteEventForm));
            label1 = new Label();
            label = new Label();
            label3 = new Label();
            deleteeventidtextBox = new TextBox();
            deleteeventnametextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(296, 89);
            label1.Name = "label1";
            label1.Size = new Size(226, 37);
            label1.TabIndex = 0;
            label1.Text = "Delete Your Event";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 13F);
            label.ForeColor = Color.DarkGreen;
            label.Location = new Point(208, 177);
            label.Name = "label";
            label.Size = new Size(80, 25);
            label.TabIndex = 1;
            label.Text = "Event Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(208, 247);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 2;
            label3.Text = "Event Name:";
            // 
            // deleteeventidtextBox
            // 
            deleteeventidtextBox.BackColor = Color.DarkSeaGreen;
            deleteeventidtextBox.BorderStyle = BorderStyle.None;
            deleteeventidtextBox.Location = new Point(377, 183);
            deleteeventidtextBox.Margin = new Padding(3, 2, 3, 2);
            deleteeventidtextBox.Name = "deleteeventidtextBox";
            deleteeventidtextBox.Size = new Size(242, 16);
            deleteeventidtextBox.TabIndex = 3;
            deleteeventidtextBox.TextChanged += deleteeventnametextBox_TextChanged;
            // 
            // deleteeventnametextBox
            // 
            deleteeventnametextBox.BackColor = Color.DarkSeaGreen;
            deleteeventnametextBox.BorderStyle = BorderStyle.None;
            deleteeventnametextBox.Location = new Point(377, 253);
            deleteeventnametextBox.Margin = new Padding(3, 2, 3, 2);
            deleteeventnametextBox.Name = "deleteeventnametextBox";
            deleteeventnametextBox.Size = new Size(242, 16);
            deleteeventnametextBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(333, 344);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(189, 42);
            button1.TabIndex = 5;
            button1.Text = "Delete Event";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(39, 464);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(87, 44);
            button2.TabIndex = 6;
            button2.Text = "← Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(256, 401);
            label4.Name = "label4";
            label4.Size = new Size(329, 19);
            label4.TabIndex = 7;
            label4.Text = "⚠️When you delete Event ,Tickets will also be delete";
            // 
            // DeleteEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(814, 543);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(deleteeventnametextBox);
            Controls.Add(deleteeventidtextBox);
            Controls.Add(label3);
            Controls.Add(label);
            Controls.Add(label1);
            ForeColor = Color.DarkGreen;
            Margin = new Padding(3, 2, 3, 2);
            Name = "DeleteEventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteEventForm";
            Load += DeleteEventForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label;
        private Label label3;
        private TextBox deleteeventidtextBox;
        private TextBox deleteeventnametextBox;
        private Button button1;
        private Button button2;
        private Label label4;
    }
}