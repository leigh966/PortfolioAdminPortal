namespace PortfollioAdminPortal
{
    partial class AlterProject
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
            txtName = new TextBox();
            txtDescription = new TextBox();
            lblName = new Label();
            lblDescription = new Label();
            btnSubmit = new Button();
            label1 = new Label();
            txtTagline = new TextBox();
            btnBanner = new Button();
            pbBanner = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbBanner).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(23, 193);
            txtName.Name = "txtName";
            txtName.Size = new Size(386, 27);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(23, 308);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(386, 206);
            txtDescription.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(183, 170);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(161, 285);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(161, 520);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 232);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 5;
            label1.Text = "Tagline";
            // 
            // txtTagline
            // 
            txtTagline.Location = new Point(23, 255);
            txtTagline.Name = "txtTagline";
            txtTagline.Size = new Size(386, 27);
            txtTagline.TabIndex = 1;
            // 
            // btnBanner
            // 
            btnBanner.ForeColor = SystemColors.ActiveCaptionText;
            btnBanner.Location = new Point(132, 75);
            btnBanner.Name = "btnBanner";
            btnBanner.Size = new Size(154, 29);
            btnBanner.TabIndex = 6;
            btnBanner.Text = "Select Banner Image";
            btnBanner.UseVisualStyleBackColor = true;
            btnBanner.Click += btnBanner_Click;
            // 
            // pbBanner
            // 
            pbBanner.Location = new Point(12, 12);
            pbBanner.Name = "pbBanner";
            pbBanner.Size = new Size(397, 155);
            pbBanner.SizeMode = PictureBoxSizeMode.Zoom;
            pbBanner.TabIndex = 7;
            pbBanner.TabStop = false;
            // 
            // AlterProject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 563);
            Controls.Add(btnBanner);
            Controls.Add(txtTagline);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(pbBanner);
            Name = "AlterProject";
            Text = "AlterProject";
            ((System.ComponentModel.ISupportInitialize)pbBanner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtDescription;
        private Label lblName;
        private Label lblDescription;
        private Button btnSubmit;
        private Label label1;
        private TextBox txtTagline;
        private Button btnBanner;
        private PictureBox pbBanner;
    }
}