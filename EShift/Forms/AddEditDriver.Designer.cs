namespace EShift.Forms
{
    partial class AddEditDriver
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
            chkIsAvailable = new CheckBox();
            lblFormTitle = new Label();
            btnCancel = new Button();
            btnSubmit = new Button();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtLicenseNumber = new TextBox();
            lblLicenseNumber = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            SuspendLayout();
            // 
            // chkIsAvailable
            // 
            chkIsAvailable.AutoSize = true;
            chkIsAvailable.Location = new Point(586, 324);
            chkIsAvailable.Name = "chkIsAvailable";
            chkIsAvailable.Size = new Size(107, 24);
            chkIsAvailable.TabIndex = 31;
            chkIsAvailable.Text = "Is Available";
            chkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Location = new Point(567, 169);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(50, 20);
            lblFormTitle.TabIndex = 30;
            lblFormTitle.Text = "label1";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(421, 392);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(94, 392);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 28;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(238, 321);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(277, 27);
            txtAddress.TabIndex = 27;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(34, 328);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 26;
            lblAddress.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(238, 263);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(277, 27);
            txtEmail.TabIndex = 25;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(34, 270);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 24;
            lblEmail.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(235, 205);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(277, 27);
            txtPhoneNumber.TabIndex = 23;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(31, 212);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(108, 20);
            lblPhoneNumber.TabIndex = 22;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Location = new Point(234, 143);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(277, 27);
            txtLicenseNumber.TabIndex = 21;
            // 
            // lblLicenseNumber
            // 
            lblLicenseNumber.AutoSize = true;
            lblLicenseNumber.Location = new Point(30, 150);
            lblLicenseNumber.Name = "lblLicenseNumber";
            lblLicenseNumber.Size = new Size(115, 20);
            lblLicenseNumber.TabIndex = 20;
            lblLicenseNumber.Text = "License Number";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(234, 80);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(277, 27);
            txtLastName.TabIndex = 19;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(30, 87);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 18;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(234, 29);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(277, 27);
            txtFirstName.TabIndex = 17;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(30, 36);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 16;
            lblFirstName.Text = "First Name";
            // 
            // AddEditDriver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkIsAvailable);
            Controls.Add(lblFormTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtLicenseNumber);
            Controls.Add(lblLicenseNumber);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Name = "AddEditDriver";
            Text = "AddEditDriver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkIsAvailable;
        private Label lblFormTitle;
        private Button btnCancel;
        private Button btnSubmit;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtLicenseNumber;
        private Label lblLicenseNumber;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
    }
}