namespace PortfollioAdminPortal
{
    partial class AlterEmployment
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
            datePickStart = new DateTimePicker();
            datePickEnd = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmployer = new TextBox();
            txtTitle = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // datePickStart
            // 
            datePickStart.Location = new Point(12, 138);
            datePickStart.Name = "datePickStart";
            datePickStart.Size = new Size(195, 27);
            datePickStart.TabIndex = 0;
            datePickStart.ValueChanged += StartDateUpdated;
            // 
            // datePickEnd
            // 
            datePickEnd.Location = new Point(232, 138);
            datePickEnd.Name = "datePickEnd";
            datePickEnd.Size = new Size(205, 27);
            datePickEnd.TabIndex = 1;
            datePickEnd.ValueChanged += EndDateUpdated;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 143);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 2;
            label1.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "Employer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 71);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Job Title";
            // 
            // txtSchool
            // 
            txtEmployer.Location = new Point(12, 34);
            txtEmployer.Name = "textBox1";
            txtEmployer.Size = new Size(424, 27);
            txtEmployer.TabIndex = 5;
            txtEmployer.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            txtTitle.Location = new Point(12, 94);
            txtTitle.Name = "textBox2";
            txtTitle.Size = new Size(424, 27);
            txtTitle.TabIndex = 6;
            txtTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(171, 176);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AlterEducation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 217);
            Controls.Add(btnSubmit);
            Controls.Add(txtTitle);
            Controls.Add(txtEmployer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datePickEnd);
            Controls.Add(datePickStart);
            Name = "AlterEducation";
            Text = "AlterEducation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker datePickStart;
        private DateTimePicker datePickEnd;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmployer;
        private TextBox txtTitle;
        private Button btnSubmit;
    }
}