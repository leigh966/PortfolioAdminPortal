namespace PortfollioAdminPortal
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPassword = new Label();
            txtPass = new TextBox();
            txtVerCode = new TextBox();
            lblVerCode = new Label();
            btnSub = new Button();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(87, 9);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(12, 32);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(223, 27);
            txtPass.TabIndex = 1;
            txtPass.TextAlign = HorizontalAlignment.Center;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtVerCode
            // 
            txtVerCode.Location = new Point(12, 101);
            txtVerCode.Name = "txtVerCode";
            txtVerCode.Size = new Size(223, 27);
            txtVerCode.TabIndex = 2;
            txtVerCode.TextAlign = HorizontalAlignment.Center;
            // 
            // lblVerCode
            // 
            lblVerCode.AutoSize = true;
            lblVerCode.Location = new Point(65, 78);
            lblVerCode.Name = "lblVerCode";
            lblVerCode.Size = new Size(123, 20);
            lblVerCode.TabIndex = 3;
            lblVerCode.Text = "Verification Code";
            // 
            // btnSub
            // 
            btnSub.Location = new Point(76, 148);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(94, 29);
            btnSub.TabIndex = 4;
            btnSub.Text = "Submit";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 199);
            Controls.Add(btnSub);
            Controls.Add(lblVerCode);
            Controls.Add(txtVerCode);
            Controls.Add(txtPass);
            Controls.Add(lblPassword);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private TextBox txtPass;
        private TextBox txtVerCode;
        private Label lblVerCode;
        private Button btnSub;
    }
}
