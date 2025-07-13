namespace EShift.Forms
{
    partial class AssignTransportUnitForm
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
            groupBoxJobStatus = new GroupBox();
            lblJobStatus = new Label();
            groupBoxPickupDate = new GroupBox();
            lblPickupDate = new Label();
            groupBoxRequestedDate = new GroupBox();
            lblRequestedDate = new Label();
            groupBoxDelivaryLocation = new GroupBox();
            lblDeliveryLocation = new Label();
            groupBoxPickUpLocation = new GroupBox();
            lblPickupLocation = new Label();
            groupBoxJobNumber = new GroupBox();
            lblJobNumber = new Label();
            cmbTransportUnits = new ComboBox();
            lblTransportUnit = new Label();
            btnAssign = new Button();
            groupBoxCustomerEmail = new GroupBox();
            lblCustomerEmail = new Label();
            groupBoxCustomerPhoneNumber = new GroupBox();
            lblCustomerPhoneNumber = new Label();
            groupBoxCustomerLastName = new GroupBox();
            lblCustomerLastName = new Label();
            groupBoxCustomerFirstName = new GroupBox();
            lblCustomerFirstName = new Label();
            groupBoxCustomerNumber = new GroupBox();
            lblCustomerNumber = new Label();
            dtpActualPickupDate = new DateTimePicker();
            dtpActualDeliveryDate = new DateTimePicker();
            lblActualPickup = new Label();
            lblActualDelivery = new Label();
            txtRemarks = new TextBox();
            txtQuotedPrice = new TextBox();
            txtFinalPrice = new TextBox();
            btnCancel = new Button();
            groupBoxJobStatus.SuspendLayout();
            groupBoxPickupDate.SuspendLayout();
            groupBoxRequestedDate.SuspendLayout();
            groupBoxDelivaryLocation.SuspendLayout();
            groupBoxPickUpLocation.SuspendLayout();
            groupBoxJobNumber.SuspendLayout();
            groupBoxCustomerEmail.SuspendLayout();
            groupBoxCustomerPhoneNumber.SuspendLayout();
            groupBoxCustomerLastName.SuspendLayout();
            groupBoxCustomerFirstName.SuspendLayout();
            groupBoxCustomerNumber.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxJobStatus
            // 
            groupBoxJobStatus.Controls.Add(lblJobStatus);
            groupBoxJobStatus.Location = new Point(295, 12);
            groupBoxJobStatus.Name = "groupBoxJobStatus";
            groupBoxJobStatus.Size = new Size(250, 69);
            groupBoxJobStatus.TabIndex = 8;
            groupBoxJobStatus.TabStop = false;
            groupBoxJobStatus.Text = "JobStatus";
            // 
            // lblJobStatus
            // 
            lblJobStatus.AutoSize = true;
            lblJobStatus.Location = new Point(6, 32);
            lblJobStatus.Name = "lblJobStatus";
            lblJobStatus.Size = new Size(76, 20);
            lblJobStatus.TabIndex = 0;
            lblJobStatus.Text = "Job Status";
            // 
            // groupBoxPickupDate
            // 
            groupBoxPickupDate.Controls.Add(lblPickupDate);
            groupBoxPickupDate.Location = new Point(12, 342);
            groupBoxPickupDate.Name = "groupBoxPickupDate";
            groupBoxPickupDate.Size = new Size(250, 69);
            groupBoxPickupDate.TabIndex = 7;
            groupBoxPickupDate.TabStop = false;
            groupBoxPickupDate.Text = "Pick-Up Date";
            // 
            // lblPickupDate
            // 
            lblPickupDate.AutoSize = true;
            lblPickupDate.Location = new Point(6, 32);
            lblPickupDate.Name = "lblPickupDate";
            lblPickupDate.Size = new Size(96, 20);
            lblPickupDate.TabIndex = 0;
            lblPickupDate.Text = "Pick-Up Date";
            // 
            // groupBoxRequestedDate
            // 
            groupBoxRequestedDate.Controls.Add(lblRequestedDate);
            groupBoxRequestedDate.Location = new Point(12, 256);
            groupBoxRequestedDate.Name = "groupBoxRequestedDate";
            groupBoxRequestedDate.Size = new Size(250, 69);
            groupBoxRequestedDate.TabIndex = 9;
            groupBoxRequestedDate.TabStop = false;
            groupBoxRequestedDate.Text = "Requested Date";
            // 
            // lblRequestedDate
            // 
            lblRequestedDate.AutoSize = true;
            lblRequestedDate.Location = new Point(6, 32);
            lblRequestedDate.Name = "lblRequestedDate";
            lblRequestedDate.Size = new Size(115, 20);
            lblRequestedDate.TabIndex = 0;
            lblRequestedDate.Text = "Requested Date";
            // 
            // groupBoxDelivaryLocation
            // 
            groupBoxDelivaryLocation.Controls.Add(lblDeliveryLocation);
            groupBoxDelivaryLocation.Location = new Point(12, 172);
            groupBoxDelivaryLocation.Name = "groupBoxDelivaryLocation";
            groupBoxDelivaryLocation.Size = new Size(250, 69);
            groupBoxDelivaryLocation.TabIndex = 10;
            groupBoxDelivaryLocation.TabStop = false;
            groupBoxDelivaryLocation.Text = "Delivary Location";
            // 
            // lblDeliveryLocation
            // 
            lblDeliveryLocation.AutoSize = true;
            lblDeliveryLocation.Location = new Point(6, 32);
            lblDeliveryLocation.Name = "lblDeliveryLocation";
            lblDeliveryLocation.Size = new Size(124, 20);
            lblDeliveryLocation.TabIndex = 0;
            lblDeliveryLocation.Text = "Delivary Location";
            lblDeliveryLocation.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBoxPickUpLocation
            // 
            groupBoxPickUpLocation.Controls.Add(lblPickupLocation);
            groupBoxPickUpLocation.Location = new Point(12, 87);
            groupBoxPickUpLocation.Name = "groupBoxPickUpLocation";
            groupBoxPickUpLocation.Size = new Size(250, 69);
            groupBoxPickUpLocation.TabIndex = 11;
            groupBoxPickUpLocation.TabStop = false;
            groupBoxPickUpLocation.Text = "Pick-Up Location";
            // 
            // lblPickupLocation
            // 
            lblPickupLocation.AutoSize = true;
            lblPickupLocation.Location = new Point(6, 32);
            lblPickupLocation.Name = "lblPickupLocation";
            lblPickupLocation.Size = new Size(121, 20);
            lblPickupLocation.TabIndex = 0;
            lblPickupLocation.Text = "Pick-Up Location";
            // 
            // groupBoxJobNumber
            // 
            groupBoxJobNumber.Controls.Add(lblJobNumber);
            groupBoxJobNumber.Location = new Point(12, 12);
            groupBoxJobNumber.Name = "groupBoxJobNumber";
            groupBoxJobNumber.Size = new Size(250, 69);
            groupBoxJobNumber.TabIndex = 12;
            groupBoxJobNumber.TabStop = false;
            groupBoxJobNumber.Text = "Job Number";
            // 
            // lblJobNumber
            // 
            lblJobNumber.AutoSize = true;
            lblJobNumber.Location = new Point(6, 32);
            lblJobNumber.Name = "lblJobNumber";
            lblJobNumber.Size = new Size(90, 20);
            lblJobNumber.TabIndex = 0;
            lblJobNumber.Text = "Job Number";
            // 
            // cmbTransportUnits
            // 
            cmbTransportUnits.FormattingEnabled = true;
            cmbTransportUnits.Location = new Point(861, 41);
            cmbTransportUnits.Name = "cmbTransportUnits";
            cmbTransportUnits.Size = new Size(244, 28);
            cmbTransportUnits.TabIndex = 13;
            // 
            // lblTransportUnit
            // 
            lblTransportUnit.AutoSize = true;
            lblTransportUnit.Location = new Point(861, 12);
            lblTransportUnit.Name = "lblTransportUnit";
            lblTransportUnit.Size = new Size(102, 20);
            lblTransportUnit.TabIndex = 14;
            lblTransportUnit.Text = "Transport Unit";
            // 
            // btnAssign
            // 
            btnAssign.Location = new Point(301, 382);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(94, 29);
            btnAssign.TabIndex = 15;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click;
            // 
            // groupBoxCustomerEmail
            // 
            groupBoxCustomerEmail.Controls.Add(lblCustomerEmail);
            groupBoxCustomerEmail.Location = new Point(576, 342);
            groupBoxCustomerEmail.Name = "groupBoxCustomerEmail";
            groupBoxCustomerEmail.Size = new Size(250, 69);
            groupBoxCustomerEmail.TabIndex = 17;
            groupBoxCustomerEmail.TabStop = false;
            groupBoxCustomerEmail.Text = "Customer Email";
            // 
            // lblCustomerEmail
            // 
            lblCustomerEmail.AutoSize = true;
            lblCustomerEmail.Location = new Point(6, 32);
            lblCustomerEmail.Name = "lblCustomerEmail";
            lblCustomerEmail.Size = new Size(113, 20);
            lblCustomerEmail.TabIndex = 0;
            lblCustomerEmail.Text = "Customer Email";
            // 
            // groupBoxCustomerPhoneNumber
            // 
            groupBoxCustomerPhoneNumber.Controls.Add(lblCustomerPhoneNumber);
            groupBoxCustomerPhoneNumber.Location = new Point(576, 256);
            groupBoxCustomerPhoneNumber.Name = "groupBoxCustomerPhoneNumber";
            groupBoxCustomerPhoneNumber.Size = new Size(250, 69);
            groupBoxCustomerPhoneNumber.TabIndex = 18;
            groupBoxCustomerPhoneNumber.TabStop = false;
            groupBoxCustomerPhoneNumber.Text = "Customer Phone Number";
            // 
            // lblCustomerPhoneNumber
            // 
            lblCustomerPhoneNumber.AutoSize = true;
            lblCustomerPhoneNumber.Location = new Point(6, 32);
            lblCustomerPhoneNumber.Name = "lblCustomerPhoneNumber";
            lblCustomerPhoneNumber.Size = new Size(175, 20);
            lblCustomerPhoneNumber.TabIndex = 0;
            lblCustomerPhoneNumber.Text = "Customer Phone Number";
            // 
            // groupBoxCustomerLastName
            // 
            groupBoxCustomerLastName.Controls.Add(lblCustomerLastName);
            groupBoxCustomerLastName.Location = new Point(576, 172);
            groupBoxCustomerLastName.Name = "groupBoxCustomerLastName";
            groupBoxCustomerLastName.Size = new Size(250, 69);
            groupBoxCustomerLastName.TabIndex = 19;
            groupBoxCustomerLastName.TabStop = false;
            groupBoxCustomerLastName.Text = "Customer Last Name";
            // 
            // lblCustomerLastName
            // 
            lblCustomerLastName.AutoSize = true;
            lblCustomerLastName.Location = new Point(6, 32);
            lblCustomerLastName.Name = "lblCustomerLastName";
            lblCustomerLastName.Size = new Size(146, 20);
            lblCustomerLastName.TabIndex = 0;
            lblCustomerLastName.Text = "Customer Last Name";
            // 
            // groupBoxCustomerFirstName
            // 
            groupBoxCustomerFirstName.Controls.Add(lblCustomerFirstName);
            groupBoxCustomerFirstName.Location = new Point(576, 87);
            groupBoxCustomerFirstName.Name = "groupBoxCustomerFirstName";
            groupBoxCustomerFirstName.Size = new Size(250, 69);
            groupBoxCustomerFirstName.TabIndex = 20;
            groupBoxCustomerFirstName.TabStop = false;
            groupBoxCustomerFirstName.Text = "Customer First Name";
            // 
            // lblCustomerFirstName
            // 
            lblCustomerFirstName.AutoSize = true;
            lblCustomerFirstName.Location = new Point(6, 32);
            lblCustomerFirstName.Name = "lblCustomerFirstName";
            lblCustomerFirstName.Size = new Size(147, 20);
            lblCustomerFirstName.TabIndex = 0;
            lblCustomerFirstName.Text = "Customer First Name";
            // 
            // groupBoxCustomerNumber
            // 
            groupBoxCustomerNumber.Controls.Add(lblCustomerNumber);
            groupBoxCustomerNumber.Location = new Point(576, 12);
            groupBoxCustomerNumber.Name = "groupBoxCustomerNumber";
            groupBoxCustomerNumber.Size = new Size(250, 69);
            groupBoxCustomerNumber.TabIndex = 16;
            groupBoxCustomerNumber.TabStop = false;
            groupBoxCustomerNumber.Text = "Customer Number";
            // 
            // lblCustomerNumber
            // 
            lblCustomerNumber.AutoSize = true;
            lblCustomerNumber.Location = new Point(6, 32);
            lblCustomerNumber.Name = "lblCustomerNumber";
            lblCustomerNumber.Size = new Size(130, 20);
            lblCustomerNumber.TabIndex = 0;
            lblCustomerNumber.Text = "Customer Number";
            // 
            // dtpActualPickupDate
            // 
            dtpActualPickupDate.Location = new Point(283, 140);
            dtpActualPickupDate.Name = "dtpActualPickupDate";
            dtpActualPickupDate.Size = new Size(250, 27);
            dtpActualPickupDate.TabIndex = 1;
            // 
            // dtpActualDeliveryDate
            // 
            dtpActualDeliveryDate.Location = new Point(283, 239);
            dtpActualDeliveryDate.Name = "dtpActualDeliveryDate";
            dtpActualDeliveryDate.Size = new Size(250, 27);
            dtpActualDeliveryDate.TabIndex = 2;
            // 
            // lblActualPickup
            // 
            lblActualPickup.AutoSize = true;
            lblActualPickup.Location = new Point(283, 107);
            lblActualPickup.Name = "lblActualPickup";
            lblActualPickup.Size = new Size(142, 20);
            lblActualPickup.TabIndex = 21;
            lblActualPickup.Text = "Actual Pick-Up Date";
            // 
            // lblActualDelivery
            // 
            lblActualDelivery.AutoSize = true;
            lblActualDelivery.Location = new Point(283, 216);
            lblActualDelivery.Name = "lblActualDelivery";
            lblActualDelivery.Size = new Size(145, 20);
            lblActualDelivery.TabIndex = 22;
            lblActualDelivery.Text = "Actual Delivery Date";
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(872, 204);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.PlaceholderText = "Remarks";
            txtRemarks.Size = new Size(125, 27);
            txtRemarks.TabIndex = 23;
            // 
            // txtQuotedPrice
            // 
            txtQuotedPrice.Location = new Point(872, 271);
            txtQuotedPrice.Name = "txtQuotedPrice";
            txtQuotedPrice.PlaceholderText = "Quoted Price";
            txtQuotedPrice.Size = new Size(125, 27);
            txtQuotedPrice.TabIndex = 24;
            // 
            // txtFinalPrice
            // 
            txtFinalPrice.Location = new Point(872, 342);
            txtFinalPrice.Name = "txtFinalPrice";
            txtFinalPrice.PlaceholderText = "Final Price";
            txtFinalPrice.Size = new Size(125, 27);
            txtFinalPrice.TabIndex = 25;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(420, 382);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AssignTransportUnitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 450);
            Controls.Add(btnCancel);
            Controls.Add(txtFinalPrice);
            Controls.Add(txtQuotedPrice);
            Controls.Add(txtRemarks);
            Controls.Add(lblActualDelivery);
            Controls.Add(lblActualPickup);
            Controls.Add(dtpActualPickupDate);
            Controls.Add(dtpActualDeliveryDate);
            Controls.Add(groupBoxCustomerEmail);
            Controls.Add(groupBoxCustomerPhoneNumber);
            Controls.Add(groupBoxCustomerLastName);
            Controls.Add(groupBoxCustomerFirstName);
            Controls.Add(groupBoxCustomerNumber);
            Controls.Add(btnAssign);
            Controls.Add(lblTransportUnit);
            Controls.Add(cmbTransportUnits);
            Controls.Add(groupBoxJobStatus);
            Controls.Add(groupBoxPickupDate);
            Controls.Add(groupBoxRequestedDate);
            Controls.Add(groupBoxDelivaryLocation);
            Controls.Add(groupBoxPickUpLocation);
            Controls.Add(groupBoxJobNumber);
            Name = "AssignTransportUnitForm";
            Text = "AssignTransportUnitForm";
            groupBoxJobStatus.ResumeLayout(false);
            groupBoxJobStatus.PerformLayout();
            groupBoxPickupDate.ResumeLayout(false);
            groupBoxPickupDate.PerformLayout();
            groupBoxRequestedDate.ResumeLayout(false);
            groupBoxRequestedDate.PerformLayout();
            groupBoxDelivaryLocation.ResumeLayout(false);
            groupBoxDelivaryLocation.PerformLayout();
            groupBoxPickUpLocation.ResumeLayout(false);
            groupBoxPickUpLocation.PerformLayout();
            groupBoxJobNumber.ResumeLayout(false);
            groupBoxJobNumber.PerformLayout();
            groupBoxCustomerEmail.ResumeLayout(false);
            groupBoxCustomerEmail.PerformLayout();
            groupBoxCustomerPhoneNumber.ResumeLayout(false);
            groupBoxCustomerPhoneNumber.PerformLayout();
            groupBoxCustomerLastName.ResumeLayout(false);
            groupBoxCustomerLastName.PerformLayout();
            groupBoxCustomerFirstName.ResumeLayout(false);
            groupBoxCustomerFirstName.PerformLayout();
            groupBoxCustomerNumber.ResumeLayout(false);
            groupBoxCustomerNumber.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxJobStatus;
        private Label lblJobStatus;
        private GroupBox groupBoxPickupDate;
        private Label lblPickupDate;
        private GroupBox groupBoxRequestedDate;
        private Label lblRequestedDate;
        private GroupBox groupBoxDelivaryLocation;
        private Label lblDeliveryLocation;
        private GroupBox groupBoxPickUpLocation;
        private Label lblPickupLocation;
        private GroupBox groupBoxJobNumber;
        private Label lblJobNumber;
        private ComboBox cmbTransportUnits;
        private Label lblTransportUnit;
        private Button btnAssign;
        private GroupBox groupBoxCustomerEmail;
        private Label lblCustomerEmail;
        private GroupBox groupBoxCustomerPhoneNumber;
        private Label lblCustomerPhoneNumber;
        private GroupBox groupBoxCustomerLastName;
        private Label lblCustomerLastName;
        private GroupBox groupBoxCustomerFirstName;
        private Label lblCustomerFirstName;
        private GroupBox groupBoxCustomerNumber;
        private Label lblCustomerNumber;
        private DateTimePicker dtpActualPickupDate;
        private DateTimePicker dtpActualDeliveryDate;
        private Label lblActualPickup;
        private Label lblActualDelivery;
        private TextBox txtRemarks;
        private TextBox txtQuotedPrice;
        private TextBox txtFinalPrice;
        private Button btnCancel;
    }
}