namespace Dbex
{
    partial class ViewEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEventForm));
            ViewEventlistBox = new ListBox();
            Vieeventbutton = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // ViewEventlistBox
            // 
            ViewEventlistBox.BackColor = Color.FromArgb(192, 255, 192);
            ViewEventlistBox.Font = new Font("Segoe UI", 11F);
            ViewEventlistBox.FormattingEnabled = true;
            ViewEventlistBox.ItemHeight = 20;
            ViewEventlistBox.Location = new Point(132, 101);
            ViewEventlistBox.Margin = new Padding(3, 2, 3, 2);
            ViewEventlistBox.Name = "ViewEventlistBox";
            ViewEventlistBox.Size = new Size(515, 224);
            ViewEventlistBox.TabIndex = 0;
            // 
            // Vieeventbutton
            // 
            Vieeventbutton.BackColor = Color.FromArgb(192, 255, 192);
            Vieeventbutton.FlatStyle = FlatStyle.Flat;
            Vieeventbutton.ForeColor = Color.DarkGreen;
            Vieeventbutton.Location = new Point(325, 363);
            Vieeventbutton.Margin = new Padding(3, 2, 3, 2);
            Vieeventbutton.Name = "Vieeventbutton";
            Vieeventbutton.Size = new Size(150, 41);
            Vieeventbutton.TabIndex = 1;
            Vieeventbutton.Text = "View Event";
            Vieeventbutton.UseVisualStyleBackColor = false;
            Vieeventbutton.Click += Vieeventbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(242, 36);
            label1.Name = "label1";
            label1.Size = new Size(302, 37);
            label1.TabIndex = 2;
            label1.Text = "Press the button to view";
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(50, 466);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(84, 43);
            button1.TabIndex = 3;
            button1.Text = "← Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ViewEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(802, 541);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Vieeventbutton);
            Controls.Add(ViewEventlistBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewEventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewEventForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ViewEventlistBox;
        private Button Vieeventbutton;
        private Label label1;
        private Button button1;
    }
}