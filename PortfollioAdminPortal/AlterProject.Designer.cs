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
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(23, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(254, 27);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(23, 147);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(254, 206);
            txtDescription.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(120, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(104, 124);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(104, 359);
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
            label1.Location = new Point(113, 71);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 5;
            label1.Text = "Tagline";
            // 
            // txtTagline
            // 
            txtTagline.Location = new Point(23, 94);
            txtTagline.Name = "txtTagline";
            txtTagline.Size = new Size(254, 27);
            txtTagline.TabIndex = 1;
            // 
            // AlterProject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 400);
            Controls.Add(txtTagline);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Name = "AlterProject";
            Text = "AlterProject";
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
    }
}