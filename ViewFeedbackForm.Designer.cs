namespace Dbex
{
    partial class ViewFeedbackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFeedbackForm));
            label1 = new Label();
            Feedbackviewlistbox = new ListBox();
            viewfeeedbackbtn = new Button();
            feedbackbacktomenubtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(178, 52);
            label1.Name = "label1";
            label1.Size = new Size(451, 37);
            label1.TabIndex = 0;
            label1.Text = "Press View Button to view Feedbacks";
            // 
            // Feedbackviewlistbox
            // 
            Feedbackviewlistbox.BackColor = Color.FromArgb(192, 255, 192);
            Feedbackviewlistbox.Font = new Font("Segoe UI", 11F);
            Feedbackviewlistbox.ForeColor = Color.DarkGreen;
            Feedbackviewlistbox.FormattingEnabled = true;
            Feedbackviewlistbox.ItemHeight = 20;
            Feedbackviewlistbox.Location = new Point(148, 120);
            Feedbackviewlistbox.Margin = new Padding(3, 2, 3, 2);
            Feedbackviewlistbox.Name = "Feedbackviewlistbox";
            Feedbackviewlistbox.Size = new Size(494, 244);
            Feedbackviewlistbox.TabIndex = 1;
            // 
            // viewfeeedbackbtn
            // 
            viewfeeedbackbtn.BackColor = Color.FromArgb(192, 255, 192);
            viewfeeedbackbtn.ForeColor = Color.DarkGreen;
            viewfeeedbackbtn.Location = new Point(311, 404);
            viewfeeedbackbtn.Margin = new Padding(3, 2, 3, 2);
            viewfeeedbackbtn.Name = "viewfeeedbackbtn";
            viewfeeedbackbtn.Size = new Size(185, 42);
            viewfeeedbackbtn.TabIndex = 2;
            viewfeeedbackbtn.Text = "View Feedback";
            viewfeeedbackbtn.UseVisualStyleBackColor = false;
            viewfeeedbackbtn.Click += viewfeeedbackbtn_Click;
            // 
            // feedbackbacktomenubtn
            // 
            feedbackbacktomenubtn.BackColor = Color.SeaGreen;
            feedbackbacktomenubtn.FlatStyle = FlatStyle.Flat;
            feedbackbacktomenubtn.ForeColor = SystemColors.ControlLightLight;
            feedbackbacktomenubtn.Location = new Point(64, 464);
            feedbackbacktomenubtn.Margin = new Padding(3, 2, 3, 2);
            feedbackbacktomenubtn.Name = "feedbackbacktomenubtn";
            feedbackbacktomenubtn.Size = new Size(91, 48);
            feedbackbacktomenubtn.TabIndex = 3;
            feedbackbacktomenubtn.Text = "← Back";
            feedbackbacktomenubtn.UseVisualStyleBackColor = false;
            feedbackbacktomenubtn.Click += feedbackbacktomenubtn_Click;
            // 
            // ViewFeedbackForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(807, 545);
            Controls.Add(feedbackbacktomenubtn);
            Controls.Add(viewfeeedbackbtn);
            Controls.Add(Feedbackviewlistbox);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewFeedbackForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewFeedbackForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox Feedbackviewlistbox;
        private Button viewfeeedbackbtn;
        private Button feedbackbacktomenubtn;
    }
}