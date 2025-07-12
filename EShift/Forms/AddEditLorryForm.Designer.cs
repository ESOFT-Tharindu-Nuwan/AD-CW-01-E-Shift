namespace EShift.Forms
{
    partial class AddEditLorryForm
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
            lblRegistrationNumber = new Label();
            txtRegistrationNumber = new TextBox();
            txtMake = new TextBox();
            lblMake = new Label();
            txtModel = new TextBox();
            lblModel = new Label();
            txtCapacity = new TextBox();
            lblCapacity = new Label();
            txtFuelType = new TextBox();
            lblFuelType = new Label();
            txtCurrentMilage = new TextBox();
            lblCurrentMilage = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            lblFormTitle = new Label();
            chkIsAvailable = new CheckBox();
            SuspendLayout();
            // 
            // lblRegistrationNumber
            // 
            lblRegistrationNumber.AutoSize = true;
            lblRegistrationNumber.Location = new Point(12, 43);
            lblRegistrationNumber.Name = "lblRegistrationNumber";
            lblRegistrationNumber.Size = new Size(147, 20);
            lblRegistrationNumber.TabIndex = 0;
            lblRegistrationNumber.Text = "Registration Number";
            // 
            // txtRegistrationNumber
            // 
            txtRegistrationNumber.Location = new Point(216, 36);
            txtRegistrationNumber.Name = "txtRegistrationNumber";
            txtRegistrationNumber.Size = new Size(277, 27);
            txtRegistrationNumber.TabIndex = 1;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(216, 87);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(277, 27);
            txtMake.TabIndex = 3;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(12, 94);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(45, 20);
            lblMake.TabIndex = 2;
            lblMake.Text = "Make";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(216, 150);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(277, 27);
            txtModel.TabIndex = 5;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(12, 157);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(52, 20);
            lblModel.TabIndex = 4;
            lblModel.Text = "Model";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(217, 212);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(277, 27);
            txtCapacity.TabIndex = 7;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Location = new Point(13, 219);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(66, 20);
            lblCapacity.TabIndex = 6;
            lblCapacity.Text = "Capacity";
            // 
            // txtFuelType
            // 
            txtFuelType.Location = new Point(220, 270);
            txtFuelType.Name = "txtFuelType";
            txtFuelType.Size = new Size(277, 27);
            txtFuelType.TabIndex = 9;
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Location = new Point(16, 277);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(71, 20);
            lblFuelType.TabIndex = 8;
            lblFuelType.Text = "Fuel Type";
            // 
            // txtCurrentMilage
            // 
            txtCurrentMilage.Location = new Point(220, 328);
            txtCurrentMilage.Name = "txtCurrentMilage";
            txtCurrentMilage.Size = new Size(277, 27);
            txtCurrentMilage.TabIndex = 11;
            // 
            // lblCurrentMilage
            // 
            lblCurrentMilage.AutoSize = true;
            lblCurrentMilage.Location = new Point(16, 335);
            lblCurrentMilage.Name = "lblCurrentMilage";
            lblCurrentMilage.Size = new Size(107, 20);
            lblCurrentMilage.TabIndex = 10;
            lblCurrentMilage.Text = "Current Milage";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(76, 399);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(403, 399);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Location = new Point(549, 176);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(50, 20);
            lblFormTitle.TabIndex = 14;
            lblFormTitle.Text = "label1";
            // 
            // chkIsAvailable
            // 
            chkIsAvailable.AutoSize = true;
            chkIsAvailable.Location = new Point(568, 331);
            chkIsAvailable.Name = "chkIsAvailable";
            chkIsAvailable.Size = new Size(107, 24);
            chkIsAvailable.TabIndex = 15;
            chkIsAvailable.Text = "Is Available";
            chkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // AddEditLorryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkIsAvailable);
            Controls.Add(lblFormTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtCurrentMilage);
            Controls.Add(lblCurrentMilage);
            Controls.Add(txtFuelType);
            Controls.Add(lblFuelType);
            Controls.Add(txtCapacity);
            Controls.Add(lblCapacity);
            Controls.Add(txtModel);
            Controls.Add(lblModel);
            Controls.Add(txtMake);
            Controls.Add(lblMake);
            Controls.Add(txtRegistrationNumber);
            Controls.Add(lblRegistrationNumber);
            Name = "AddEditLorryForm";
            Text = "Add Edit Lorry Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistrationNumber;
        private TextBox txtRegistrationNumber;
        private TextBox txtMake;
        private Label lblMake;
        private TextBox txtModel;
        private Label lblModel;
        private TextBox txtCapacity;
        private Label lblCapacity;
        private TextBox txtFuelType;
        private Label lblFuelType;
        private TextBox txtCurrentMilage;
        private Label lblCurrentMilage;
        private Button btnSubmit;
        private Button btnCancel;
        private Label lblFormTitle;
        private CheckBox chkIsAvailable;
    }
}