namespace EShift.Forms
{
    partial class CustomerDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboardForm));
            tabControlCustomer = new TabControl();
            tabPageNewJob = new TabPage();
            btnClear = new Button();
            btnSubmit = new Button();
            txtSpecialInstructions = new TextBox();
            lblSpecialInstructions = new Label();
            txtVolumeCBM = new TextBox();
            lblVolumeCBM = new Label();
            txtWeightKG = new TextBox();
            lblWeightKG = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            dateScheduledPickupDate = new DateTimePicker();
            lblScheduledPickupDate = new Label();
            txtDeliveryLocation = new TextBox();
            lblDeliveryLocation = new Label();
            txtPickupLocation = new TextBox();
            lblPickupLocation = new Label();
            tabPageMyJobs = new TabPage();
            btnCancelJob = new Button();
            btnViewMyJobDetails = new Button();
            dgvMyJobs = new DataGridView();
            tabPageProfile = new TabPage();
            btnUpdateProfile = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtPostalCode = new TextBox();
            lblPostalCode = new Label();
            txtProvince = new TextBox();
            lblProvince = new Label();
            txtCity = new TextBox();
            lblCity = new Label();
            txtAddressLine2 = new TextBox();
            lblAddressLine2 = new Label();
            txtAddressLine1 = new TextBox();
            lblAddressLine1 = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            tabPageCustomerNotifications = new TabPage();
            btnMarkNotificationAsRead = new Button();
            dgvCustomerNotifications = new DataGridView();
            panel1 = new Panel();
            pbLogout = new PictureBox();
            lblLoggedUsername = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            tabControlCustomer.SuspendLayout();
            tabPageNewJob.SuspendLayout();
            tabPageMyJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyJobs).BeginInit();
            tabPageProfile.SuspendLayout();
            tabPageCustomerNotifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerNotifications).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControlCustomer
            // 
            tabControlCustomer.Controls.Add(tabPageNewJob);
            tabControlCustomer.Controls.Add(tabPageMyJobs);
            tabControlCustomer.Controls.Add(tabPageProfile);
            tabControlCustomer.Controls.Add(tabPageCustomerNotifications);
            tabControlCustomer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlCustomer.ItemSize = new Size(126, 40);
            tabControlCustomer.Location = new Point(0, 96);
            tabControlCustomer.Name = "tabControlCustomer";
            tabControlCustomer.SelectedIndex = 0;
            tabControlCustomer.Size = new Size(896, 554);
            tabControlCustomer.TabIndex = 0;
            // 
            // tabPageNewJob
            // 
            tabPageNewJob.Controls.Add(btnClear);
            tabPageNewJob.Controls.Add(btnSubmit);
            tabPageNewJob.Controls.Add(txtSpecialInstructions);
            tabPageNewJob.Controls.Add(lblSpecialInstructions);
            tabPageNewJob.Controls.Add(txtVolumeCBM);
            tabPageNewJob.Controls.Add(lblVolumeCBM);
            tabPageNewJob.Controls.Add(txtWeightKG);
            tabPageNewJob.Controls.Add(lblWeightKG);
            tabPageNewJob.Controls.Add(txtDescription);
            tabPageNewJob.Controls.Add(lblDescription);
            tabPageNewJob.Controls.Add(dateScheduledPickupDate);
            tabPageNewJob.Controls.Add(lblScheduledPickupDate);
            tabPageNewJob.Controls.Add(txtDeliveryLocation);
            tabPageNewJob.Controls.Add(lblDeliveryLocation);
            tabPageNewJob.Controls.Add(txtPickupLocation);
            tabPageNewJob.Controls.Add(lblPickupLocation);
            tabPageNewJob.Location = new Point(4, 44);
            tabPageNewJob.Name = "tabPageNewJob";
            tabPageNewJob.Padding = new Padding(3);
            tabPageNewJob.Size = new Size(888, 506);
            tabPageNewJob.TabIndex = 0;
            tabPageNewJob.Text = "New Job Request";
            tabPageNewJob.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(8, 383);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 15;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(258, 383);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtSpecialInstructions
            // 
            txtSpecialInstructions.Location = new Point(258, 310);
            txtSpecialInstructions.Name = "txtSpecialInstructions";
            txtSpecialInstructions.Size = new Size(453, 30);
            txtSpecialInstructions.TabIndex = 13;
            // 
            // lblSpecialInstructions
            // 
            lblSpecialInstructions.AutoSize = true;
            lblSpecialInstructions.Location = new Point(8, 313);
            lblSpecialInstructions.Name = "lblSpecialInstructions";
            lblSpecialInstructions.Size = new Size(165, 23);
            lblSpecialInstructions.TabIndex = 12;
            lblSpecialInstructions.Text = "Special Instructions";
            // 
            // txtVolumeCBM
            // 
            txtVolumeCBM.Location = new Point(258, 259);
            txtVolumeCBM.Name = "txtVolumeCBM";
            txtVolumeCBM.Size = new Size(176, 30);
            txtVolumeCBM.TabIndex = 11;
            // 
            // lblVolumeCBM
            // 
            lblVolumeCBM.AutoSize = true;
            lblVolumeCBM.Location = new Point(8, 262);
            lblVolumeCBM.Name = "lblVolumeCBM";
            lblVolumeCBM.Size = new Size(125, 23);
            lblVolumeCBM.TabIndex = 10;
            lblVolumeCBM.Text = "Volume (CBM)";
            // 
            // txtWeightKG
            // 
            txtWeightKG.Location = new Point(258, 208);
            txtWeightKG.Name = "txtWeightKG";
            txtWeightKG.Size = new Size(176, 30);
            txtWeightKG.TabIndex = 9;
            // 
            // lblWeightKG
            // 
            lblWeightKG.AutoSize = true;
            lblWeightKG.Location = new Point(8, 211);
            lblWeightKG.Name = "lblWeightKG";
            lblWeightKG.Size = new Size(109, 23);
            lblWeightKG.TabIndex = 8;
            lblWeightKG.Text = "Weight (KG)";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(258, 159);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(176, 30);
            txtDescription.TabIndex = 7;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(8, 162);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 23);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";
            // 
            // dateScheduledPickupDate
            // 
            dateScheduledPickupDate.Location = new Point(258, 106);
            dateScheduledPickupDate.Name = "dateScheduledPickupDate";
            dateScheduledPickupDate.Size = new Size(250, 30);
            dateScheduledPickupDate.TabIndex = 5;
            // 
            // lblScheduledPickupDate
            // 
            lblScheduledPickupDate.AutoSize = true;
            lblScheduledPickupDate.Location = new Point(8, 111);
            lblScheduledPickupDate.Name = "lblScheduledPickupDate";
            lblScheduledPickupDate.Size = new Size(195, 23);
            lblScheduledPickupDate.TabIndex = 4;
            lblScheduledPickupDate.Text = "Scheduled Pickup Date";
            // 
            // txtDeliveryLocation
            // 
            txtDeliveryLocation.Location = new Point(258, 58);
            txtDeliveryLocation.Name = "txtDeliveryLocation";
            txtDeliveryLocation.Size = new Size(176, 30);
            txtDeliveryLocation.TabIndex = 3;
            // 
            // lblDeliveryLocation
            // 
            lblDeliveryLocation.AutoSize = true;
            lblDeliveryLocation.Location = new Point(8, 61);
            lblDeliveryLocation.Name = "lblDeliveryLocation";
            lblDeliveryLocation.Size = new Size(150, 23);
            lblDeliveryLocation.TabIndex = 2;
            lblDeliveryLocation.Text = "Delivery Location";
            // 
            // txtPickupLocation
            // 
            txtPickupLocation.Location = new Point(258, 12);
            txtPickupLocation.Name = "txtPickupLocation";
            txtPickupLocation.Size = new Size(176, 30);
            txtPickupLocation.TabIndex = 1;
            // 
            // lblPickupLocation
            // 
            lblPickupLocation.AutoSize = true;
            lblPickupLocation.Location = new Point(8, 15);
            lblPickupLocation.Name = "lblPickupLocation";
            lblPickupLocation.Size = new Size(137, 23);
            lblPickupLocation.TabIndex = 0;
            lblPickupLocation.Text = "Pickup Location";
            // 
            // tabPageMyJobs
            // 
            tabPageMyJobs.Controls.Add(btnCancelJob);
            tabPageMyJobs.Controls.Add(btnViewMyJobDetails);
            tabPageMyJobs.Controls.Add(dgvMyJobs);
            tabPageMyJobs.Location = new Point(4, 29);
            tabPageMyJobs.Name = "tabPageMyJobs";
            tabPageMyJobs.Padding = new Padding(3);
            tabPageMyJobs.Size = new Size(790, 509);
            tabPageMyJobs.TabIndex = 1;
            tabPageMyJobs.Text = "My Jobs";
            tabPageMyJobs.UseVisualStyleBackColor = true;
            // 
            // btnCancelJob
            // 
            btnCancelJob.Location = new Point(20, 448);
            btnCancelJob.Name = "btnCancelJob";
            btnCancelJob.Size = new Size(348, 29);
            btnCancelJob.TabIndex = 2;
            btnCancelJob.Text = "Cancel Job";
            btnCancelJob.UseVisualStyleBackColor = true;
            // 
            // btnViewMyJobDetails
            // 
            btnViewMyJobDetails.Location = new Point(20, 413);
            btnViewMyJobDetails.Name = "btnViewMyJobDetails";
            btnViewMyJobDetails.Size = new Size(348, 29);
            btnViewMyJobDetails.TabIndex = 1;
            btnViewMyJobDetails.Text = "View My Job Details";
            btnViewMyJobDetails.UseVisualStyleBackColor = true;
            // 
            // dgvMyJobs
            // 
            dgvMyJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyJobs.Location = new Point(8, 8);
            dgvMyJobs.Name = "dgvMyJobs";
            dgvMyJobs.RowHeadersWidth = 51;
            dgvMyJobs.Size = new Size(776, 363);
            dgvMyJobs.TabIndex = 0;
            // 
            // tabPageProfile
            // 
            tabPageProfile.Controls.Add(btnUpdateProfile);
            tabPageProfile.Controls.Add(txtEmail);
            tabPageProfile.Controls.Add(lblEmail);
            tabPageProfile.Controls.Add(txtPhoneNumber);
            tabPageProfile.Controls.Add(lblPhoneNumber);
            tabPageProfile.Controls.Add(txtPostalCode);
            tabPageProfile.Controls.Add(lblPostalCode);
            tabPageProfile.Controls.Add(txtProvince);
            tabPageProfile.Controls.Add(lblProvince);
            tabPageProfile.Controls.Add(txtCity);
            tabPageProfile.Controls.Add(lblCity);
            tabPageProfile.Controls.Add(txtAddressLine2);
            tabPageProfile.Controls.Add(lblAddressLine2);
            tabPageProfile.Controls.Add(txtAddressLine1);
            tabPageProfile.Controls.Add(lblAddressLine1);
            tabPageProfile.Controls.Add(txtLastName);
            tabPageProfile.Controls.Add(lblLastName);
            tabPageProfile.Controls.Add(txtFirstName);
            tabPageProfile.Controls.Add(lblFirstName);
            tabPageProfile.Controls.Add(txtNewPassword);
            tabPageProfile.Controls.Add(lblNewPassword);
            tabPageProfile.Controls.Add(txtUsername);
            tabPageProfile.Controls.Add(lblUsername);
            tabPageProfile.Location = new Point(4, 29);
            tabPageProfile.Name = "tabPageProfile";
            tabPageProfile.Padding = new Padding(3);
            tabPageProfile.Size = new Size(790, 509);
            tabPageProfile.TabIndex = 2;
            tabPageProfile.Text = "My Profile";
            tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Location = new Point(416, 439);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(307, 29);
            btnUpdateProfile.TabIndex = 48;
            btnUpdateProfile.Text = "Update Details";
            btnUpdateProfile.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(385, 329);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(338, 30);
            txtEmail.TabIndex = 47;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(385, 306);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 23);
            lblEmail.TabIndex = 46;
            lblEmail.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(21, 329);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(312, 30);
            txtPhoneNumber.TabIndex = 45;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(21, 306);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(130, 23);
            lblPhoneNumber.TabIndex = 44;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(523, 259);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(200, 30);
            txtPostalCode.TabIndex = 43;
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new Point(523, 236);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(103, 23);
            lblPostalCode.TabIndex = 42;
            lblPostalCode.Text = "Postal Code";
            // 
            // txtProvince
            // 
            txtProvince.Location = new Point(263, 259);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(200, 30);
            txtProvince.TabIndex = 41;
            // 
            // lblProvince
            // 
            lblProvince.AutoSize = true;
            lblProvince.Location = new Point(263, 236);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new Size(78, 23);
            lblProvince.TabIndex = 40;
            lblProvince.Text = "Province";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(21, 259);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(200, 30);
            txtCity.TabIndex = 39;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(21, 236);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(42, 23);
            lblCity.TabIndex = 38;
            lblCity.Text = "City";
            // 
            // txtAddressLine2
            // 
            txtAddressLine2.Location = new Point(385, 183);
            txtAddressLine2.Name = "txtAddressLine2";
            txtAddressLine2.Size = new Size(338, 30);
            txtAddressLine2.TabIndex = 37;
            // 
            // lblAddressLine2
            // 
            lblAddressLine2.AutoSize = true;
            lblAddressLine2.Location = new Point(385, 160);
            lblAddressLine2.Name = "lblAddressLine2";
            lblAddressLine2.Size = new Size(127, 23);
            lblAddressLine2.TabIndex = 36;
            lblAddressLine2.Text = "Address Line 2";
            // 
            // txtAddressLine1
            // 
            txtAddressLine1.Location = new Point(21, 183);
            txtAddressLine1.Name = "txtAddressLine1";
            txtAddressLine1.Size = new Size(312, 30);
            txtAddressLine1.TabIndex = 35;
            // 
            // lblAddressLine1
            // 
            lblAddressLine1.AutoSize = true;
            lblAddressLine1.Location = new Point(21, 160);
            lblAddressLine1.Name = "lblAddressLine1";
            lblAddressLine1.Size = new Size(127, 23);
            lblAddressLine1.TabIndex = 34;
            lblAddressLine1.Text = "Address Line 1";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(385, 111);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(338, 30);
            txtLastName.TabIndex = 33;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(385, 88);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(94, 23);
            lblLastName.TabIndex = 32;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(21, 111);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(312, 30);
            txtFirstName.TabIndex = 31;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(21, 88);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 23);
            lblFirstName.TabIndex = 30;
            lblFirstName.Text = "First Name";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(385, 38);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(338, 30);
            txtNewPassword.TabIndex = 27;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(385, 15);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(85, 23);
            lblNewPassword.TabIndex = 26;
            lblNewPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(21, 38);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(312, 30);
            txtUsername.TabIndex = 25;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(21, 15);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(89, 23);
            lblUsername.TabIndex = 24;
            lblUsername.Text = "Username";
            // 
            // tabPageCustomerNotifications
            // 
            tabPageCustomerNotifications.Controls.Add(btnMarkNotificationAsRead);
            tabPageCustomerNotifications.Controls.Add(dgvCustomerNotifications);
            tabPageCustomerNotifications.Location = new Point(4, 29);
            tabPageCustomerNotifications.Name = "tabPageCustomerNotifications";
            tabPageCustomerNotifications.Padding = new Padding(3);
            tabPageCustomerNotifications.Size = new Size(790, 509);
            tabPageCustomerNotifications.TabIndex = 3;
            tabPageCustomerNotifications.Text = "My Notifications";
            tabPageCustomerNotifications.UseVisualStyleBackColor = true;
            // 
            // btnMarkNotificationAsRead
            // 
            btnMarkNotificationAsRead.Location = new Point(374, 450);
            btnMarkNotificationAsRead.Name = "btnMarkNotificationAsRead";
            btnMarkNotificationAsRead.Size = new Size(410, 29);
            btnMarkNotificationAsRead.TabIndex = 1;
            btnMarkNotificationAsRead.Text = "Mark Notification As Read";
            btnMarkNotificationAsRead.UseVisualStyleBackColor = true;
            // 
            // dgvCustomerNotifications
            // 
            dgvCustomerNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerNotifications.Location = new Point(0, 0);
            dgvCustomerNotifications.Name = "dgvCustomerNotifications";
            dgvCustomerNotifications.RowHeadersWidth = 51;
            dgvCustomerNotifications.Size = new Size(790, 422);
            dgvCustomerNotifications.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pbLogout);
            panel1.Controls.Add(lblLoggedUsername);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 90);
            panel1.TabIndex = 2;
            // 
            // pbLogout
            // 
            pbLogout.BackgroundImage = (Image)resources.GetObject("pbLogout.BackgroundImage");
            pbLogout.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogout.Location = new Point(846, 18);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(43, 50);
            pbLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogout.TabIndex = 6;
            pbLogout.TabStop = false;
            pbLogout.Click += pbLogout_Click;
            // 
            // lblLoggedUsername
            // 
            lblLoggedUsername.AutoSize = true;
            lblLoggedUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoggedUsername.Location = new Point(707, 36);
            lblLoggedUsername.Name = "lblLoggedUsername";
            lblLoggedUsername.Size = new Size(78, 20);
            lblLoggedUsername.TabIndex = 5;
            lblLoggedUsername.Text = "username";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(661, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 18);
            label1.Name = "label1";
            label1.Size = new Size(205, 59);
            label1.TabIndex = 2;
            label1.Text = "E-SHIFT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(307, 36);
            label2.Name = "label2";
            label2.Size = new Size(323, 26);
            label2.TabIndex = 3;
            label2.Text = "Powered by Trust, Driven by Tech";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 648);
            Controls.Add(panel1);
            Controls.Add(tabControlCustomer);
            Name = "CustomerDashboardForm";
            Text = "CustomerDashboardForm";
            tabControlCustomer.ResumeLayout(false);
            tabPageNewJob.ResumeLayout(false);
            tabPageNewJob.PerformLayout();
            tabPageMyJobs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMyJobs).EndInit();
            tabPageProfile.ResumeLayout(false);
            tabPageProfile.PerformLayout();
            tabPageCustomerNotifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomerNotifications).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlCustomer;
        private TabPage tabPageNewJob;
        private TabPage tabPageMyJobs;
        private TabPage tabPageProfile;
        private TabPage tabPageCustomerNotifications;
        private TextBox txtWeightKG;
        private Label lblWeightKG;
        private TextBox txtDescription;
        private Label lblDescription;
        private DateTimePicker dateScheduledPickupDate;
        private Label lblScheduledPickupDate;
        private TextBox txtDeliveryLocation;
        private Label lblDeliveryLocation;
        private TextBox txtPickupLocation;
        private Label lblPickupLocation;
        private Button btnClear;
        private Button btnSubmit;
        private TextBox txtSpecialInstructions;
        private Label lblSpecialInstructions;
        private TextBox txtVolumeCBM;
        private Label lblVolumeCBM;
        private Button btnCancelJob;
        private Button btnViewMyJobDetails;
        private DataGridView dgvMyJobs;
        private Button btnUpdateProfile;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtPostalCode;
        private Label lblPostalCode;
        private TextBox txtProvince;
        private Label lblProvince;
        private TextBox txtCity;
        private Label lblCity;
        private TextBox txtAddressLine2;
        private Label lblAddressLine2;
        private TextBox txtAddressLine1;
        private Label lblAddressLine1;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TextBox txtNewPassword;
        private Label lblNewPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Button btnMarkNotificationAsRead;
        private DataGridView dgvCustomerNotifications;
        private Panel panel1;
        private PictureBox pbLogout;
        private Label lblLoggedUsername;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}