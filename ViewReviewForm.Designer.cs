namespace Dbex
{
    partial class ViewReviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReviewForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            reviewidtextBox = new TextBox();
            revieweventnametextBox = new TextBox();
            reviewtextBox = new TextBox();
            Addreviewbtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(206, 130);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Event Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(206, 197);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "Event Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(206, 264);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Review";
            // 
            // reviewidtextBox
            // 
            reviewidtextBox.BackColor = Color.DarkSeaGreen;
            reviewidtextBox.BorderStyle = BorderStyle.None;
            reviewidtextBox.Location = new Point(322, 122);
            reviewidtextBox.Margin = new Padding(3, 2, 3, 2);
            reviewidtextBox.Name = "reviewidtextBox";
            reviewidtextBox.Size = new Size(275, 16);
            reviewidtextBox.TabIndex = 3;
            // 
            // revieweventnametextBox
            // 
            revieweventnametextBox.BackColor = Color.DarkSeaGreen;
            revieweventnametextBox.BorderStyle = BorderStyle.None;
            revieweventnametextBox.Location = new Point(322, 197);
            revieweventnametextBox.Margin = new Padding(3, 2, 3, 2);
            revieweventnametextBox.Name = "revieweventnametextBox";
            revieweventnametextBox.Size = new Size(275, 16);
            revieweventnametextBox.TabIndex = 4;
            // 
            // reviewtextBox
            // 
            reviewtextBox.BackColor = Color.DarkSeaGreen;
            reviewtextBox.BorderStyle = BorderStyle.None;
            reviewtextBox.Location = new Point(322, 264);
            reviewtextBox.Margin = new Padding(3, 2, 3, 2);
            reviewtextBox.Name = "reviewtextBox";
            reviewtextBox.Size = new Size(275, 16);
            reviewtextBox.TabIndex = 5;
            // 
            // Addreviewbtn
            // 
            Addreviewbtn.BackColor = Color.FromArgb(192, 255, 192);
            Addreviewbtn.ForeColor = Color.DarkGreen;
            Addreviewbtn.Location = new Point(357, 331);
            Addreviewbtn.Margin = new Padding(3, 2, 3, 2);
            Addreviewbtn.Name = "Addreviewbtn";
            Addreviewbtn.Size = new Size(146, 43);
            Addreviewbtn.TabIndex = 6;
            Addreviewbtn.Text = "Add Review";
            Addreviewbtn.UseVisualStyleBackColor = false;
            Addreviewbtn.Click += Addreviewbtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(52, 466);
            button1.Name = "button1";
            button1.Size = new Size(91, 47);
            button1.TabIndex = 7;
            button1.Text = "← Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ViewReviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(812, 545);
            Controls.Add(button1);
            Controls.Add(Addreviewbtn);
            Controls.Add(reviewtextBox);
            Controls.Add(revieweventnametextBox);
            Controls.Add(reviewidtextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DarkGreen;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewReviewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewReviewForm";
            Load += ViewReviewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox reviewidtextBox;
        private TextBox revieweventnametextBox;
        private TextBox reviewtextBox;
        private Button Addreviewbtn;
        private Button button1;
    }
}