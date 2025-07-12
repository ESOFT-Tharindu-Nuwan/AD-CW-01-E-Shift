namespace EShift.Forms
{
    partial class AddEditAssistantForm
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
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            SuspendLayout();
            // 
            // chkIsAvailable
            // 
            chkIsAvailable.AutoSize = true;
            chkIsAvailable.Location = new Point(72, 323);
            chkIsAvailable.Name = "chkIsAvailable";
            chkIsAvailable.Size = new Size(107, 24);
            chkIsAvailable.TabIndex = 47;
            chkIsAvailable.Text = "Is Available";
            chkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Location = new Point(606, 169);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(50, 20);
            lblFormTitle.TabIndex = 46;
            lblFormTitle.Text = "label1";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(460, 392);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 45;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(133, 392);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 44;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(276, 250);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(277, 27);
            txtAddress.TabIndex = 43;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(72, 257);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 42;
            lblAddress.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(276, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(277, 27);
            txtEmail.TabIndex = 41;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(72, 199);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 40;
            lblEmail.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(273, 134);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(277, 27);
            txtPhoneNumber.TabIndex = 39;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(69, 141);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(108, 20);
            lblPhoneNumber.TabIndex = 38;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(273, 80);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(277, 27);
            txtLastName.TabIndex = 35;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(69, 87);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 34;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(273, 29);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(277, 27);
            txtFirstName.TabIndex = 33;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(69, 36);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 32;
            lblFirstName.Text = "First Name";
            // 
            // AddEditAssistantForm
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
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Name = "AddEditAssistantForm";
            Text = "Add Edit Assistant Form";
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
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
    }
}