namespace EShift.Forms
{
    partial class AddEditTransportUnitForm
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
            lblUnitName = new Label();
            txtUnitName = new TextBox();
            lblLorry = new Label();
            cmbLorry = new ComboBox();
            cmbDriver = new ComboBox();
            lblDriver = new Label();
            cmbAssistant = new ComboBox();
            lblAssistant = new Label();
            cmbContainer = new ComboBox();
            lblContainer = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            chkIsOperational = new CheckBox();
            lblFormTitle = new Label();
            SuspendLayout();
            // 
            // lblUnitName
            // 
            lblUnitName.AutoSize = true;
            lblUnitName.Location = new Point(23, 49);
            lblUnitName.Name = "lblUnitName";
            lblUnitName.Size = new Size(80, 20);
            lblUnitName.TabIndex = 0;
            lblUnitName.Text = "Unit Name";
            // 
            // txtUnitName
            // 
            txtUnitName.Location = new Point(236, 46);
            txtUnitName.Name = "txtUnitName";
            txtUnitName.Size = new Size(266, 27);
            txtUnitName.TabIndex = 1;
            // 
            // lblLorry
            // 
            lblLorry.AutoSize = true;
            lblLorry.Location = new Point(23, 101);
            lblLorry.Name = "lblLorry";
            lblLorry.Size = new Size(42, 20);
            lblLorry.TabIndex = 2;
            lblLorry.Text = "Lorry";
            // 
            // cmbLorry
            // 
            cmbLorry.FormattingEnabled = true;
            cmbLorry.Location = new Point(236, 98);
            cmbLorry.Name = "cmbLorry";
            cmbLorry.Size = new Size(151, 28);
            cmbLorry.TabIndex = 3;
            // 
            // cmbDriver
            // 
            cmbDriver.FormattingEnabled = true;
            cmbDriver.Location = new Point(236, 150);
            cmbDriver.Name = "cmbDriver";
            cmbDriver.Size = new Size(151, 28);
            cmbDriver.TabIndex = 5;
            // 
            // lblDriver
            // 
            lblDriver.AutoSize = true;
            lblDriver.Location = new Point(23, 153);
            lblDriver.Name = "lblDriver";
            lblDriver.Size = new Size(49, 20);
            lblDriver.TabIndex = 4;
            lblDriver.Text = "Driver";
            // 
            // cmbAssistant
            // 
            cmbAssistant.FormattingEnabled = true;
            cmbAssistant.Location = new Point(236, 207);
            cmbAssistant.Name = "cmbAssistant";
            cmbAssistant.Size = new Size(151, 28);
            cmbAssistant.TabIndex = 7;
            // 
            // lblAssistant
            // 
            lblAssistant.AutoSize = true;
            lblAssistant.Location = new Point(23, 210);
            lblAssistant.Name = "lblAssistant";
            lblAssistant.Size = new Size(67, 20);
            lblAssistant.TabIndex = 6;
            lblAssistant.Text = "Assistant";
            // 
            // cmbContainer
            // 
            cmbContainer.FormattingEnabled = true;
            cmbContainer.Location = new Point(236, 260);
            cmbContainer.Name = "cmbContainer";
            cmbContainer.Size = new Size(151, 28);
            cmbContainer.TabIndex = 9;
            // 
            // lblContainer
            // 
            lblContainer.AutoSize = true;
            lblContainer.Location = new Point(23, 263);
            lblContainer.Name = "lblContainer";
            lblContainer.Size = new Size(73, 20);
            lblContainer.TabIndex = 8;
            lblContainer.Text = "Container";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(23, 375);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(408, 375);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // chkIsOperational
            // 
            chkIsOperational.AutoSize = true;
            chkIsOperational.Location = new Point(23, 319);
            chkIsOperational.Name = "chkIsOperational";
            chkIsOperational.Size = new Size(124, 24);
            chkIsOperational.TabIndex = 12;
            chkIsOperational.Text = "Is Operational";
            chkIsOperational.UseVisualStyleBackColor = true;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Location = new Point(602, 176);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(50, 20);
            lblFormTitle.TabIndex = 13;
            lblFormTitle.Text = "label1";
            // 
            // AddEditTransportUnitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFormTitle);
            Controls.Add(chkIsOperational);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(cmbContainer);
            Controls.Add(lblContainer);
            Controls.Add(cmbAssistant);
            Controls.Add(lblAssistant);
            Controls.Add(cmbDriver);
            Controls.Add(lblDriver);
            Controls.Add(cmbLorry);
            Controls.Add(lblLorry);
            Controls.Add(txtUnitName);
            Controls.Add(lblUnitName);
            Name = "AddEditTransportUnitForm";
            Text = "Add Edit Transport Unit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUnitName;
        private TextBox txtUnitName;
        private Label lblLorry;
        private ComboBox cmbLorry;
        private ComboBox cmbDriver;
        private Label lblDriver;
        private ComboBox cmbAssistant;
        private Label lblAssistant;
        private ComboBox cmbContainer;
        private Label lblContainer;
        private Button btnSubmit;
        private Button btnCancel;
        private CheckBox chkIsOperational;
        private Label lblFormTitle;
    }
}