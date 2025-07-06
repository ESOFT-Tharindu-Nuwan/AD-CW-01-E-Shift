namespace EShift.Forms
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
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblRegister = new Label();
            lnkRegister = new LinkLabel();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.System;
            btnLogin.Location = new Point(118, 189);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(115, 35);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(21, 16);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(21, 98);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(21, 39);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Username here...";
            txtUsername.Size = new Size(307, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(21, 121);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter Password here...";
            txtPassword.Size = new Size(307, 27);
            txtPassword.TabIndex = 4;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Location = new Point(21, 266);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(184, 20);
            lblRegister.TabIndex = 5;
            lblRegister.Text = "If you haven't register yet...";
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.Location = new Point(255, 266);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(73, 20);
            lnkRegister.TabIndex = 6;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "REGISTER";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 313);
            Controls.Add(lnkRegister);
            Controls.Add(lblRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblRegister;
        private LinkLabel lnkRegister;
    }
}