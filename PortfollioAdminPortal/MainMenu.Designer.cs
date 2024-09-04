namespace PortfollioAdminPortal
{
    partial class MainMenu
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
            btnProjects = new Button();
            btnEmployment = new Button();
            btnEducation = new Button();
            SuspendLayout();
            // 
            // btnProjects
            // 
            btnProjects.Location = new Point(12, 12);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(146, 29);
            btnProjects.TabIndex = 0;
            btnProjects.Text = "Projects";
            btnProjects.UseVisualStyleBackColor = true;
            btnProjects.Click += btnProjects_Click;
            // 
            // btnEmployment
            // 
            btnEmployment.Location = new Point(12, 47);
            btnEmployment.Name = "btnEmployment";
            btnEmployment.Size = new Size(146, 29);
            btnEmployment.TabIndex = 1;
            btnEmployment.Text = "Employment";
            btnEmployment.UseVisualStyleBackColor = true;
            btnEmployment.Click += btnEmployment_Click;
            // 
            // btnEducation
            // 
            btnEducation.Location = new Point(12, 82);
            btnEducation.Name = "btnEducation";
            btnEducation.Size = new Size(146, 29);
            btnEducation.TabIndex = 2;
            btnEducation.Text = "Education";
            btnEducation.UseVisualStyleBackColor = true;
            btnEducation.Click += btnEducation_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(170, 124);
            Controls.Add(btnEducation);
            Controls.Add(btnEmployment);
            Controls.Add(btnProjects);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProjects;
        private Button btnEmployment;
        private Button btnEducation;
    }
}