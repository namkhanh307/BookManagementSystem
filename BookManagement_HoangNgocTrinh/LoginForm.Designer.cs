namespace BookManagement_HoangNgocTrinh
{
    partial class LoginForm
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
            btnLogin = new Button();
            btnCancel = new Button();
            lblEmail = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            grbLogin = new GroupBox();
            grbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(50, 153);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(128, 42);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(226, 153);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 42);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(39, 22);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(39, 89);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(148, 22);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 23);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(148, 89);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(179, 23);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // grbLogin
            // 
            grbLogin.Controls.Add(txtPassword);
            grbLogin.Controls.Add(txtEmail);
            grbLogin.Controls.Add(lblPassword);
            grbLogin.Controls.Add(lblEmail);
            grbLogin.Controls.Add(btnCancel);
            grbLogin.Controls.Add(btnLogin);
            grbLogin.Location = new Point(191, 101);
            grbLogin.Name = "grbLogin";
            grbLogin.Size = new Size(411, 245);
            grbLogin.TabIndex = 6;
            grbLogin.TabStop = false;
            grbLogin.Text = "Login";
            grbLogin.Enter += grbLogin_Enter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(800, 450);
            Controls.Add(grbLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            grbLogin.ResumeLayout(false);
            grbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnCancel;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private GroupBox grbLogin;
    }
}