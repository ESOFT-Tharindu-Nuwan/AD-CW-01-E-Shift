namespace EShift.Forms
{
    partial class AdminDashboardForm
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
            tabControl1 = new TabControl();
            tabPageDashboard = new TabPage();
            tabPageJobs = new TabPage();
            tabPageCustomers = new TabPage();
            tabPageResources = new TabPage();
            tabPageAdminNotifications = new TabPage();
            tabPageUserManagement = new TabPage();
            groupBoxActiveJobs = new GroupBox();
            lblTotalActiveJobs = new Label();
            lblPendingRequests = new Label();
            groupBoxJobRequests = new GroupBox();
            lblAvailableLorries = new Label();
            groupBoxAvailableLorries = new GroupBox();
            lblAvailableDrivers = new Label();
            groupBoxAvailableDrivers = new GroupBox();
            lblTotalCustomers = new Label();
            groupBoxTotalCustomers = new GroupBox();
            tabControl1.SuspendLayout();
            tabPageDashboard.SuspendLayout();
            groupBoxActiveJobs.SuspendLayout();
            groupBoxJobRequests.SuspendLayout();
            groupBoxAvailableLorries.SuspendLayout();
            groupBoxAvailableDrivers.SuspendLayout();
            groupBoxTotalCustomers.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageDashboard);
            tabControl1.Controls.Add(tabPageJobs);
            tabControl1.Controls.Add(tabPageCustomers);
            tabControl1.Controls.Add(tabPageResources);
            tabControl1.Controls.Add(tabPageAdminNotifications);
            tabControl1.Controls.Add(tabPageUserManagement);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1165, 578);
            tabControl1.TabIndex = 0;
            // 
            // tabPageDashboard
            // 
            tabPageDashboard.Controls.Add(groupBoxTotalCustomers);
            tabPageDashboard.Controls.Add(groupBoxAvailableDrivers);
            tabPageDashboard.Controls.Add(groupBoxAvailableLorries);
            tabPageDashboard.Controls.Add(groupBoxJobRequests);
            tabPageDashboard.Controls.Add(groupBoxActiveJobs);
            tabPageDashboard.Location = new Point(4, 29);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Padding = new Padding(3);
            tabPageDashboard.Size = new Size(1157, 545);
            tabPageDashboard.TabIndex = 0;
            tabPageDashboard.Text = "Dashboard Overview";
            tabPageDashboard.UseVisualStyleBackColor = true;
            // 
            // tabPageJobs
            // 
            tabPageJobs.Location = new Point(4, 29);
            tabPageJobs.Name = "tabPageJobs";
            tabPageJobs.Padding = new Padding(3);
            tabPageJobs.Size = new Size(1157, 545);
            tabPageJobs.TabIndex = 1;
            tabPageJobs.Text = "Job Management";
            tabPageJobs.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomers
            // 
            tabPageCustomers.Location = new Point(4, 29);
            tabPageCustomers.Name = "tabPageCustomers";
            tabPageCustomers.Padding = new Padding(3);
            tabPageCustomers.Size = new Size(1157, 545);
            tabPageCustomers.TabIndex = 2;
            tabPageCustomers.Text = "Customer Management";
            tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // tabPageResources
            // 
            tabPageResources.Location = new Point(4, 29);
            tabPageResources.Name = "tabPageResources";
            tabPageResources.Padding = new Padding(3);
            tabPageResources.Size = new Size(1157, 545);
            tabPageResources.TabIndex = 3;
            tabPageResources.Text = "Resource Management";
            tabPageResources.UseVisualStyleBackColor = true;
            // 
            // tabPageAdminNotifications
            // 
            tabPageAdminNotifications.Location = new Point(4, 29);
            tabPageAdminNotifications.Name = "tabPageAdminNotifications";
            tabPageAdminNotifications.Padding = new Padding(3);
            tabPageAdminNotifications.Size = new Size(1157, 545);
            tabPageAdminNotifications.TabIndex = 4;
            tabPageAdminNotifications.Text = "Admin Notifications";
            tabPageAdminNotifications.UseVisualStyleBackColor = true;
            // 
            // tabPageUserManagement
            // 
            tabPageUserManagement.Location = new Point(4, 29);
            tabPageUserManagement.Name = "tabPageUserManagement";
            tabPageUserManagement.Padding = new Padding(3);
            tabPageUserManagement.Size = new Size(1157, 545);
            tabPageUserManagement.TabIndex = 5;
            tabPageUserManagement.Text = "User Management";
            tabPageUserManagement.UseVisualStyleBackColor = true;
            // 
            // groupBoxActiveJobs
            // 
            groupBoxActiveJobs.Controls.Add(lblTotalActiveJobs);
            groupBoxActiveJobs.Location = new Point(60, 87);
            groupBoxActiveJobs.Name = "groupBoxActiveJobs";
            groupBoxActiveJobs.Size = new Size(185, 108);
            groupBoxActiveJobs.TabIndex = 0;
            groupBoxActiveJobs.TabStop = false;
            groupBoxActiveJobs.Text = "Total Active Jobs:";
            // 
            // lblTotalActiveJobs
            // 
            lblTotalActiveJobs.AutoSize = true;
            lblTotalActiveJobs.Location = new Point(31, 49);
            lblTotalActiveJobs.Name = "lblTotalActiveJobs";
            lblTotalActiveJobs.Size = new Size(120, 20);
            lblTotalActiveJobs.TabIndex = 1;
            lblTotalActiveJobs.Text = "Total Active Jobs";
            // 
            // lblPendingRequests
            // 
            lblPendingRequests.AutoSize = true;
            lblPendingRequests.Location = new Point(18, 49);
            lblPendingRequests.Name = "lblPendingRequests";
            lblPendingRequests.Size = new Size(152, 20);
            lblPendingRequests.TabIndex = 1;
            lblPendingRequests.Text = "Pending Job Requests";
            // 
            // groupBoxJobRequests
            // 
            groupBoxJobRequests.Controls.Add(lblPendingRequests);
            groupBoxJobRequests.Location = new Point(457, 87);
            groupBoxJobRequests.Name = "groupBoxJobRequests";
            groupBoxJobRequests.Size = new Size(185, 108);
            groupBoxJobRequests.TabIndex = 2;
            groupBoxJobRequests.TabStop = false;
            groupBoxJobRequests.Text = "Pending Job Requests:";
            // 
            // lblAvailableLorries
            // 
            lblAvailableLorries.AutoSize = true;
            lblAvailableLorries.Location = new Point(31, 49);
            lblAvailableLorries.Name = "lblAvailableLorries";
            lblAvailableLorries.Size = new Size(119, 20);
            lblAvailableLorries.TabIndex = 1;
            lblAvailableLorries.Text = "Available Lorries";
            // 
            // groupBoxAvailableLorries
            // 
            groupBoxAvailableLorries.Controls.Add(lblAvailableLorries);
            groupBoxAvailableLorries.Location = new Point(881, 87);
            groupBoxAvailableLorries.Name = "groupBoxAvailableLorries";
            groupBoxAvailableLorries.Size = new Size(185, 108);
            groupBoxAvailableLorries.TabIndex = 2;
            groupBoxAvailableLorries.TabStop = false;
            groupBoxAvailableLorries.Text = "Available Lorries:";
            // 
            // lblAvailableDrivers
            // 
            lblAvailableDrivers.AutoSize = true;
            lblAvailableDrivers.Location = new Point(31, 49);
            lblAvailableDrivers.Name = "lblAvailableDrivers";
            lblAvailableDrivers.Size = new Size(121, 20);
            lblAvailableDrivers.TabIndex = 1;
            lblAvailableDrivers.Text = "Available Drivers";
            // 
            // groupBoxAvailableDrivers
            // 
            groupBoxAvailableDrivers.Controls.Add(lblAvailableDrivers);
            groupBoxAvailableDrivers.Location = new Point(260, 288);
            groupBoxAvailableDrivers.Name = "groupBoxAvailableDrivers";
            groupBoxAvailableDrivers.Size = new Size(185, 108);
            groupBoxAvailableDrivers.TabIndex = 2;
            groupBoxAvailableDrivers.TabStop = false;
            groupBoxAvailableDrivers.Text = "Available Drivers:";
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Location = new Point(36, 49);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(115, 20);
            lblTotalCustomers.TabIndex = 1;
            lblTotalCustomers.Text = "Total Customers";
            // 
            // groupBoxTotalCustomers
            // 
            groupBoxTotalCustomers.Controls.Add(lblTotalCustomers);
            groupBoxTotalCustomers.Location = new Point(678, 288);
            groupBoxTotalCustomers.Name = "groupBoxTotalCustomers";
            groupBoxTotalCustomers.Size = new Size(185, 108);
            groupBoxTotalCustomers.TabIndex = 2;
            groupBoxTotalCustomers.TabStop = false;
            groupBoxTotalCustomers.Text = "Total Customers:";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 580);
            Controls.Add(tabControl1);
            Name = "AdminDashboardForm";
            Text = "Admin Dashboard Form";
            tabControl1.ResumeLayout(false);
            tabPageDashboard.ResumeLayout(false);
            groupBoxActiveJobs.ResumeLayout(false);
            groupBoxActiveJobs.PerformLayout();
            groupBoxJobRequests.ResumeLayout(false);
            groupBoxJobRequests.PerformLayout();
            groupBoxAvailableLorries.ResumeLayout(false);
            groupBoxAvailableLorries.PerformLayout();
            groupBoxAvailableDrivers.ResumeLayout(false);
            groupBoxAvailableDrivers.PerformLayout();
            groupBoxTotalCustomers.ResumeLayout(false);
            groupBoxTotalCustomers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageDashboard;
        private TabPage tabPageJobs;
        private TabPage tabPageCustomers;
        private TabPage tabPageResources;
        private TabPage tabPageAdminNotifications;
        private TabPage tabPageUserManagement;
        private GroupBox groupBoxAvailableLorries;
        private GroupBox groupBoxAvailableDrivers;
        private Label lblAvailableDrivers;
        private Label lblAvailableLorries;
        private GroupBox groupBoxJobRequests;
        private Label lblPendingRequests;
        private GroupBox groupBoxActiveJobs;
        private Label lblTotalActiveJobs;
        private GroupBox groupBoxTotalCustomers;
        private Label lblTotalCustomers;
    }
}