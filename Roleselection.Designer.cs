namespace Dbex
{
    partial class Roleselection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roleselection));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 15F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(115, 359);
            label1.Name = "label1";
            label1.Size = new Size(69, 24);
            label1.TabIndex = 0;
            label1.Text = "ADMIN";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(334, 355);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 1;
            label2.Text = "ORGANIZER";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(606, 355);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 2;
            label3.Text = "USER";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(192, 255, 192);
            pictureBox2.Image = Properties.Resources.user_1281;
            pictureBox2.Location = new Point(322, 165);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 143);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(192, 255, 192);
            pictureBox3.Image = Properties.Resources.user_128;
            pictureBox3.Location = new Point(557, 167);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 143);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 255, 192);
            pictureBox1.Image = Properties.Resources.user_128;
            pictureBox1.Location = new Point(79, 165);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Roleselection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(819, 522);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DarkGreen;
            Name = "Roleselection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Roleselection";
            Load += Roleselection_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}