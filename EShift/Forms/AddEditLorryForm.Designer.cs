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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
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
            // textBox1
            // 
            textBox1.Location = new Point(217, 212);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 27);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 219);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 6;
            label1.Text = "Model";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 270);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 27);
            textBox2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 277);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 8;
            label2.Text = "Model";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(220, 328);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 27);
            textBox3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 335);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 10;
            label3.Text = "Model";
            // 
            // AddEditLorryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
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
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
    }
}