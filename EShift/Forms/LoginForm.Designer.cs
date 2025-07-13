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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblRegister = new Label();
            lnkRegister = new LinkLabel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblDescription = new Label();
            groupBoxUsername = new GroupBox();
            pictureBoxUsername = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBoxPassword = new GroupBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBoxPassword.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.HotTrack;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(591, 282);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(132, 41);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(21, 108);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 20);
            lblUsername.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(56, 43);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Username here...";
            txtUsername.Size = new Size(282, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(56, 43);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter Password here...";
            txtPassword.Size = new Size(282, 27);
            txtPassword.TabIndex = 4;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Location = new Point(452, 350);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(184, 20);
            lblRegister.TabIndex = 5;
            lblRegister.Text = "If you haven't register yet...";
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.Location = new Point(650, 350);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(73, 20);
            lnkRegister.TabIndex = 6;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "REGISTER";
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(6, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 77);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(101, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(223, 56);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "E - SHIFT";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Lucida Handwriting", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(34, 321);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(280, 17);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Powered by Trust, Driven by Tech";
            // 
            // groupBoxUsername
            // 
            groupBoxUsername.Controls.Add(pictureBoxUsername);
            groupBoxUsername.Controls.Add(txtUsername);
            groupBoxUsername.Location = new Point(385, 49);
            groupBoxUsername.Name = "groupBoxUsername";
            groupBoxUsername.Size = new Size(344, 79);
            groupBoxUsername.TabIndex = 10;
            groupBoxUsername.TabStop = false;
            groupBoxUsername.Text = "Username";
            // 
            // pictureBoxUsername
            // 
            pictureBoxUsername.AccessibleRole = AccessibleRole.MenuBar;
            pictureBoxUsername.BackgroundImageLayout = ImageLayout.None;
            pictureBoxUsername.Image = (Image)resources.GetObject("pictureBoxUsername.Image");
            pictureBoxUsername.Location = new Point(3, 26);
            pictureBoxUsername.Name = "pictureBoxUsername";
            pictureBoxUsername.Size = new Size(47, 44);
            pictureBoxUsername.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUsername.TabIndex = 4;
            pictureBoxUsername.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleRole = AccessibleRole.MenuBar;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // groupBoxPassword
            // 
            groupBoxPassword.Controls.Add(pictureBox2);
            groupBoxPassword.Controls.Add(txtPassword);
            groupBoxPassword.Location = new Point(385, 163);
            groupBoxPassword.Name = "groupBoxPassword";
            groupBoxPassword.Size = new Size(344, 79);
            groupBoxPassword.TabIndex = 11;
            groupBoxPassword.TabStop = false;
            groupBoxPassword.Text = "Password";
            // 
            // panel1
            // 
            panel1.Location = new Point(370, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 347);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblDescription);
            panel2.Controls.Add(lblTitle);
            panel2.Location = new Point(21, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 347);
            panel2.TabIndex = 13;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(23, 84);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(301, 234);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(760, 418);
            Controls.Add(groupBoxPassword);
            Controls.Add(lnkRegister);
            Controls.Add(lblRegister);
            Controls.Add(lblUsername);
            Controls.Add(btnLogin);
            Controls.Add(groupBoxUsername);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxUsername.ResumeLayout(false);
            groupBoxUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBoxPassword.ResumeLayout(false);
            groupBoxPassword.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblRegister;
        private LinkLabel lnkRegister;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblDescription;
        private GroupBox groupBoxUsername;
        private PictureBox pictureBoxUsername;
        private PictureBox pictureBox2;
        private GroupBox groupBoxPassword;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
    }
}