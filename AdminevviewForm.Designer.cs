namespace Dbex
{
    partial class AdminevviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminevviewForm));
            label1 = new Label();
            adminevviewlistBox = new ListBox();
            vieweventadminbackbutton = new Button();
            vieweventsadminbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(308, 53);
            label1.Name = "label1";
            label1.Size = new Size(178, 37);
            label1.TabIndex = 0;
            label1.Text = "View location";
            // 
            // adminevviewlistBox
            // 
            adminevviewlistBox.BackColor = Color.FromArgb(192, 255, 192);
            adminevviewlistBox.Font = new Font("Segoe UI", 11F);
            adminevviewlistBox.ForeColor = Color.DarkGreen;
            adminevviewlistBox.FormattingEnabled = true;
            adminevviewlistBox.ItemHeight = 20;
            adminevviewlistBox.Location = new Point(71, 113);
            adminevviewlistBox.Margin = new Padding(3, 2, 3, 2);
            adminevviewlistBox.Name = "adminevviewlistBox";
            adminevviewlistBox.Size = new Size(626, 264);
            adminevviewlistBox.TabIndex = 1;
            // 
            // vieweventadminbackbutton
            // 
            vieweventadminbackbutton.BackColor = Color.SeaGreen;
            vieweventadminbackbutton.FlatStyle = FlatStyle.Flat;
            vieweventadminbackbutton.ForeColor = SystemColors.ControlLightLight;
            vieweventadminbackbutton.Location = new Point(42, 479);
            vieweventadminbackbutton.Margin = new Padding(3, 2, 3, 2);
            vieweventadminbackbutton.Name = "vieweventadminbackbutton";
            vieweventadminbackbutton.Size = new Size(84, 45);
            vieweventadminbackbutton.TabIndex = 2;
            vieweventadminbackbutton.Text = "← Back";
            vieweventadminbackbutton.UseVisualStyleBackColor = false;
            vieweventadminbackbutton.Click += vieweventadminbackbutton_Click;
            // 
            // vieweventsadminbutton
            // 
            vieweventsadminbutton.BackColor = Color.FromArgb(192, 255, 192);
            vieweventsadminbutton.FlatStyle = FlatStyle.Flat;
            vieweventsadminbutton.ForeColor = Color.DarkGreen;
            vieweventsadminbutton.Location = new Point(327, 406);
            vieweventsadminbutton.Margin = new Padding(3, 2, 3, 2);
            vieweventsadminbutton.Name = "vieweventsadminbutton";
            vieweventsadminbutton.Size = new Size(129, 45);
            vieweventsadminbutton.TabIndex = 3;
            vieweventsadminbutton.Text = "View Location";
            vieweventsadminbutton.UseVisualStyleBackColor = false;
            vieweventsadminbutton.Click += vieweventsadminbutton_Click;
            // 
            // AdminevviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(815, 545);
            Controls.Add(vieweventsadminbutton);
            Controls.Add(vieweventadminbackbutton);
            Controls.Add(adminevviewlistBox);
            Controls.Add(label1);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminevviewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminevviewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox adminevviewlistBox;
        private Button vieweventadminbackbutton;
        private Button vieweventsadminbutton;
    }
}