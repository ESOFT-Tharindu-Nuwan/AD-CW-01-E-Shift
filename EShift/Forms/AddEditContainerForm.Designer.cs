namespace EShift.Forms
{
    partial class AddEditContainerForm
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
            txtCapacityCBM = new TextBox();
            lblCapacityCBM = new Label();
            txtType = new TextBox();
            lblType = new Label();
            txtContainerNumber = new TextBox();
            lblContainerNumber = new Label();
            SuspendLayout();
            // 
            // chkIsAvailable
            // 
            chkIsAvailable.AutoSize = true;
            chkIsAvailable.Location = new Point(36, 210);
            chkIsAvailable.Name = "chkIsAvailable";
            chkIsAvailable.Size = new Size(107, 24);
            chkIsAvailable.TabIndex = 57;
            chkIsAvailable.Text = "Is Available";
            chkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Location = new Point(570, 56);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(50, 20);
            lblFormTitle.TabIndex = 56;
            lblFormTitle.Text = "label1";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(424, 279);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 55;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(97, 279);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 54;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtCapacityCBM
            // 
            txtCapacityCBM.Location = new Point(240, 137);
            txtCapacityCBM.Name = "txtCapacityCBM";
            txtCapacityCBM.Size = new Size(277, 27);
            txtCapacityCBM.TabIndex = 53;
            // 
            // lblCapacityCBM
            // 
            lblCapacityCBM.AutoSize = true;
            lblCapacityCBM.Location = new Point(36, 144);
            lblCapacityCBM.Name = "lblCapacityCBM";
            lblCapacityCBM.Size = new Size(111, 20);
            lblCapacityCBM.TabIndex = 52;
            lblCapacityCBM.Text = "Capacity (CBM)";
            // 
            // txtType
            // 
            txtType.Location = new Point(240, 79);
            txtType.Name = "txtType";
            txtType.Size = new Size(277, 27);
            txtType.TabIndex = 51;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(36, 86);
            lblType.Name = "lblType";
            lblType.Size = new Size(40, 20);
            lblType.TabIndex = 50;
            lblType.Text = "Type";
            // 
            // txtContainerNumber
            // 
            txtContainerNumber.Location = new Point(237, 21);
            txtContainerNumber.Name = "txtContainerNumber";
            txtContainerNumber.Size = new Size(277, 27);
            txtContainerNumber.TabIndex = 49;
            // 
            // lblContainerNumber
            // 
            lblContainerNumber.AutoSize = true;
            lblContainerNumber.Location = new Point(33, 28);
            lblContainerNumber.Name = "lblContainerNumber";
            lblContainerNumber.Size = new Size(131, 20);
            lblContainerNumber.TabIndex = 48;
            lblContainerNumber.Text = "Container Number";
            // 
            // AddEditContainerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkIsAvailable);
            Controls.Add(lblFormTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtCapacityCBM);
            Controls.Add(lblCapacityCBM);
            Controls.Add(txtType);
            Controls.Add(lblType);
            Controls.Add(txtContainerNumber);
            Controls.Add(lblContainerNumber);
            Name = "AddEditContainerForm";
            Text = "Add Edit Containers Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkIsAvailable;
        private Label lblFormTitle;
        private Button btnCancel;
        private Button btnSubmit;
        private TextBox txtCapacityCBM;
        private Label lblCapacityCBM;
        private TextBox txtType;
        private Label lblType;
        private TextBox txtContainerNumber;
        private Label lblContainerNumber;
    }
}