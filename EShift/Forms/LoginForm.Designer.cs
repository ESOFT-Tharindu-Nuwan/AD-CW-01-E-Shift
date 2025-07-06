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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnLogin = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblRegister = new Label();
            lnkRegister = new LinkLabel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.System;
            btnLogin.Location = new Point(121, 299);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(115, 35);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(24, 126);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(24, 208);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(24, 149);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Username here...";
            txtUsername.Size = new Size(307, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(24, 231);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter Password here...";
            txtPassword.Size = new Size(307, 27);
            txtPassword.TabIndex = 4;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Location = new Point(24, 376);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(184, 20);
            lblRegister.TabIndex = 5;
            lblRegister.Text = "If you haven't register yet...";
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.Location = new Point(258, 376);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(73, 20);
            lnkRegister.TabIndex = 6;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "REGISTER";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 77);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(108, -1);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(223, 56);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "E - SHIFT";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Lucida Handwriting", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(76, 55);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(280, 17);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Powered by Trust, Driven by Tech";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 420);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(lnkRegister);
            Controls.Add(lblRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnLogin);
            ForeColor = SystemColors.Desktop;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblDescription;
    }
}