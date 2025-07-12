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
            groupBoxTotalCustomers = new GroupBox();
            lblTotalCustomers = new Label();
            groupBoxAvailableDrivers = new GroupBox();
            lblAvailableDrivers = new Label();
            groupBoxAvailableLorries = new GroupBox();
            lblAvailableLorries = new Label();
            groupBoxJobRequests = new GroupBox();
            lblPendingRequests = new Label();
            groupBoxActiveJobs = new GroupBox();
            lblTotalActiveJobs = new Label();
            tabPageJobs = new TabPage();
            btnUpdateJobStatus = new Button();
            btnAssignTransportUnit = new Button();
            btnViewJobDetails = new Button();
            cmbJobStatusFilter = new ComboBox();
            txtSearchJobs = new TextBox();
            dgvJobs = new DataGridView();
            tabPageCustomers = new TabPage();
            txtSearchCustomers = new TextBox();
            btnViewCustomerDetails = new Button();
            dgvCustomers = new DataGridView();
            tabPageResources = new TabPage();
            tabControl2 = new TabControl();
            tabPageLorries = new TabPage();
            btnDeleteLorry = new Button();
            btnEditLorry = new Button();
            btnAddLorry = new Button();
            dgvLorries = new DataGridView();
            tabPageDrivers = new TabPage();
            btnDeleteDriver = new Button();
            btnEditDriver = new Button();
            btnAddDriver = new Button();
            dgvDrivers = new DataGridView();
            tabPageAssistants = new TabPage();
            btnDeleteAssistant = new Button();
            btnEditAssistant = new Button();
            btnAddAssistant = new Button();
            dgvAssistants = new DataGridView();
            tabPageContainers = new TabPage();
            btnDeleteContainer = new Button();
            btnEditContainer = new Button();
            btnAddContainer = new Button();
            dgvContainers = new DataGridView();
            tabPageTransportUnits = new TabPage();
            btnDeleteTransportUnit = new Button();
            btnEditTransportUnit = new Button();
            btnAddTransportUnit = new Button();
            dgvTransportUnits = new DataGridView();
            tabPageAdminNotifications = new TabPage();
            btnRefreshNotifications = new Button();
            btnMarkAsRead = new Button();
            dgvAdminNotifications = new DataGridView();
            tabPageUserManagement = new TabPage();
            btnLogout = new Button();
            btnToggleUserActiveStatus = new Button();
            btnEditUserRole = new Button();
            btnAddUser = new Button();
            dgvUsers = new DataGridView();
            tabControl1.SuspendLayout();
            tabPageDashboard.SuspendLayout();
            groupBoxTotalCustomers.SuspendLayout();
            groupBoxAvailableDrivers.SuspendLayout();
            groupBoxAvailableLorries.SuspendLayout();
            groupBoxJobRequests.SuspendLayout();
            groupBoxActiveJobs.SuspendLayout();
            tabPageJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            tabPageResources.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPageLorries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLorries).BeginInit();
            tabPageDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            tabPageAssistants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssistants).BeginInit();
            tabPageContainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContainers).BeginInit();
            tabPageTransportUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransportUnits).BeginInit();
            tabPageAdminNotifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminNotifications).BeginInit();
            tabPageUserManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
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
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Location = new Point(36, 49);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(115, 20);
            lblTotalCustomers.TabIndex = 1;
            lblTotalCustomers.Text = "Total Customers";
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
            // lblAvailableDrivers
            // 
            lblAvailableDrivers.AutoSize = true;
            lblAvailableDrivers.Location = new Point(31, 49);
            lblAvailableDrivers.Name = "lblAvailableDrivers";
            lblAvailableDrivers.Size = new Size(121, 20);
            lblAvailableDrivers.TabIndex = 1;
            lblAvailableDrivers.Text = "Available Drivers";
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
            // lblAvailableLorries
            // 
            lblAvailableLorries.AutoSize = true;
            lblAvailableLorries.Location = new Point(31, 49);
            lblAvailableLorries.Name = "lblAvailableLorries";
            lblAvailableLorries.Size = new Size(119, 20);
            lblAvailableLorries.TabIndex = 1;
            lblAvailableLorries.Text = "Available Lorries";
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
            // lblPendingRequests
            // 
            lblPendingRequests.AutoSize = true;
            lblPendingRequests.Location = new Point(18, 49);
            lblPendingRequests.Name = "lblPendingRequests";
            lblPendingRequests.Size = new Size(152, 20);
            lblPendingRequests.TabIndex = 1;
            lblPendingRequests.Text = "Pending Job Requests";
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
            // tabPageJobs
            // 
            tabPageJobs.Controls.Add(btnUpdateJobStatus);
            tabPageJobs.Controls.Add(btnAssignTransportUnit);
            tabPageJobs.Controls.Add(btnViewJobDetails);
            tabPageJobs.Controls.Add(cmbJobStatusFilter);
            tabPageJobs.Controls.Add(txtSearchJobs);
            tabPageJobs.Controls.Add(dgvJobs);
            tabPageJobs.Location = new Point(4, 29);
            tabPageJobs.Name = "tabPageJobs";
            tabPageJobs.Padding = new Padding(3);
            tabPageJobs.Size = new Size(1157, 545);
            tabPageJobs.TabIndex = 1;
            tabPageJobs.Text = "Job Management";
            tabPageJobs.UseVisualStyleBackColor = true;
            // 
            // btnUpdateJobStatus
            // 
            btnUpdateJobStatus.Location = new Point(785, 497);
            btnUpdateJobStatus.Name = "btnUpdateJobStatus";
            btnUpdateJobStatus.Size = new Size(261, 29);
            btnUpdateJobStatus.TabIndex = 5;
            btnUpdateJobStatus.Text = "Update Job Status";
            btnUpdateJobStatus.UseVisualStyleBackColor = true;
            // 
            // btnAssignTransportUnit
            // 
            btnAssignTransportUnit.Location = new Point(785, 446);
            btnAssignTransportUnit.Name = "btnAssignTransportUnit";
            btnAssignTransportUnit.Size = new Size(261, 29);
            btnAssignTransportUnit.TabIndex = 4;
            btnAssignTransportUnit.Text = "Assign Transport Unit";
            btnAssignTransportUnit.UseVisualStyleBackColor = true;
            // 
            // btnViewJobDetails
            // 
            btnViewJobDetails.Location = new Point(785, 389);
            btnViewJobDetails.Name = "btnViewJobDetails";
            btnViewJobDetails.Size = new Size(261, 29);
            btnViewJobDetails.TabIndex = 3;
            btnViewJobDetails.Text = "View Job Details";
            btnViewJobDetails.UseVisualStyleBackColor = true;
            // 
            // cmbJobStatusFilter
            // 
            cmbJobStatusFilter.FormattingEnabled = true;
            cmbJobStatusFilter.Location = new Point(304, 379);
            cmbJobStatusFilter.Name = "cmbJobStatusFilter";
            cmbJobStatusFilter.Size = new Size(282, 28);
            cmbJobStatusFilter.TabIndex = 2;
            // 
            // txtSearchJobs
            // 
            txtSearchJobs.Location = new Point(8, 380);
            txtSearchJobs.Name = "txtSearchJobs";
            txtSearchJobs.PlaceholderText = "Enter keyword here to search jobs....";
            txtSearchJobs.Size = new Size(274, 27);
            txtSearchJobs.TabIndex = 1;
            // 
            // dgvJobs
            // 
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Location = new Point(8, 8);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.RowHeadersWidth = 51;
            dgvJobs.Size = new Size(1143, 325);
            dgvJobs.TabIndex = 0;
            // 
            // tabPageCustomers
            // 
            tabPageCustomers.Controls.Add(txtSearchCustomers);
            tabPageCustomers.Controls.Add(btnViewCustomerDetails);
            tabPageCustomers.Controls.Add(dgvCustomers);
            tabPageCustomers.Location = new Point(4, 29);
            tabPageCustomers.Name = "tabPageCustomers";
            tabPageCustomers.Padding = new Padding(3);
            tabPageCustomers.Size = new Size(1157, 545);
            tabPageCustomers.TabIndex = 2;
            tabPageCustomers.Text = "Customer Management";
            tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // txtSearchCustomers
            // 
            txtSearchCustomers.Location = new Point(8, 368);
            txtSearchCustomers.Name = "txtSearchCustomers";
            txtSearchCustomers.PlaceholderText = "Search...";
            txtSearchCustomers.Size = new Size(333, 27);
            txtSearchCustomers.TabIndex = 2;
            // 
            // btnViewCustomerDetails
            // 
            btnViewCustomerDetails.Location = new Point(737, 366);
            btnViewCustomerDetails.Name = "btnViewCustomerDetails";
            btnViewCustomerDetails.Size = new Size(343, 29);
            btnViewCustomerDetails.TabIndex = 1;
            btnViewCustomerDetails.Text = "View Customer Details";
            btnViewCustomerDetails.UseVisualStyleBackColor = true;
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(8, 8);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(1143, 333);
            dgvCustomers.TabIndex = 0;
            // 
            // tabPageResources
            // 
            tabPageResources.Controls.Add(tabControl2);
            tabPageResources.Location = new Point(4, 29);
            tabPageResources.Name = "tabPageResources";
            tabPageResources.Padding = new Padding(3);
            tabPageResources.Size = new Size(1157, 545);
            tabPageResources.TabIndex = 3;
            tabPageResources.Text = "Resource Management";
            tabPageResources.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPageLorries);
            tabControl2.Controls.Add(tabPageDrivers);
            tabControl2.Controls.Add(tabPageAssistants);
            tabControl2.Controls.Add(tabPageContainers);
            tabControl2.Controls.Add(tabPageTransportUnits);
            tabControl2.Location = new Point(0, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1154, 539);
            tabControl2.TabIndex = 0;
            // 
            // tabPageLorries
            // 
            tabPageLorries.Controls.Add(btnDeleteLorry);
            tabPageLorries.Controls.Add(btnEditLorry);
            tabPageLorries.Controls.Add(btnAddLorry);
            tabPageLorries.Controls.Add(dgvLorries);
            tabPageLorries.Location = new Point(4, 29);
            tabPageLorries.Name = "tabPageLorries";
            tabPageLorries.Padding = new Padding(3);
            tabPageLorries.Size = new Size(1146, 506);
            tabPageLorries.TabIndex = 0;
            tabPageLorries.Text = "Lorries";
            tabPageLorries.UseVisualStyleBackColor = true;
            // 
            // btnDeleteLorry
            // 
            btnDeleteLorry.Location = new Point(7, 462);
            btnDeleteLorry.Name = "btnDeleteLorry";
            btnDeleteLorry.Size = new Size(345, 29);
            btnDeleteLorry.TabIndex = 3;
            btnDeleteLorry.Text = "Delete Lorry";
            btnDeleteLorry.UseVisualStyleBackColor = true;
            btnDeleteLorry.Click += btnDeleteLorry_Click;
            // 
            // btnEditLorry
            // 
            btnEditLorry.Location = new Point(7, 427);
            btnEditLorry.Name = "btnEditLorry";
            btnEditLorry.Size = new Size(345, 29);
            btnEditLorry.TabIndex = 2;
            btnEditLorry.Text = "Edit Lorry";
            btnEditLorry.UseVisualStyleBackColor = true;
            btnEditLorry.Click += btnEditLorry_Click;
            // 
            // btnAddLorry
            // 
            btnAddLorry.Location = new Point(7, 392);
            btnAddLorry.Name = "btnAddLorry";
            btnAddLorry.Size = new Size(345, 29);
            btnAddLorry.TabIndex = 1;
            btnAddLorry.Text = "Add Lorry";
            btnAddLorry.UseVisualStyleBackColor = true;
            btnAddLorry.Click += btnAddLorry_Click;
            // 
            // dgvLorries
            // 
            dgvLorries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLorries.Location = new Point(7, 15);
            dgvLorries.Name = "dgvLorries";
            dgvLorries.RowHeadersWidth = 51;
            dgvLorries.Size = new Size(1132, 336);
            dgvLorries.TabIndex = 0;
            // 
            // tabPageDrivers
            // 
            tabPageDrivers.Controls.Add(btnDeleteDriver);
            tabPageDrivers.Controls.Add(btnEditDriver);
            tabPageDrivers.Controls.Add(btnAddDriver);
            tabPageDrivers.Controls.Add(dgvDrivers);
            tabPageDrivers.Location = new Point(4, 29);
            tabPageDrivers.Name = "tabPageDrivers";
            tabPageDrivers.Padding = new Padding(3);
            tabPageDrivers.Size = new Size(1146, 506);
            tabPageDrivers.TabIndex = 1;
            tabPageDrivers.Text = "Drivers";
            tabPageDrivers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDriver
            // 
            btnDeleteDriver.Location = new Point(7, 462);
            btnDeleteDriver.Name = "btnDeleteDriver";
            btnDeleteDriver.Size = new Size(345, 29);
            btnDeleteDriver.TabIndex = 7;
            btnDeleteDriver.Text = "Delete Driver";
            btnDeleteDriver.UseVisualStyleBackColor = true;
            // 
            // btnEditDriver
            // 
            btnEditDriver.Location = new Point(7, 427);
            btnEditDriver.Name = "btnEditDriver";
            btnEditDriver.Size = new Size(345, 29);
            btnEditDriver.TabIndex = 6;
            btnEditDriver.Text = "Edit Driver";
            btnEditDriver.UseVisualStyleBackColor = true;
            // 
            // btnAddDriver
            // 
            btnAddDriver.Location = new Point(7, 392);
            btnAddDriver.Name = "btnAddDriver";
            btnAddDriver.Size = new Size(345, 29);
            btnAddDriver.TabIndex = 5;
            btnAddDriver.Text = "Add Driver";
            btnAddDriver.UseVisualStyleBackColor = true;
            // 
            // dgvDrivers
            // 
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.Location = new Point(7, 15);
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.RowHeadersWidth = 51;
            dgvDrivers.Size = new Size(1132, 336);
            dgvDrivers.TabIndex = 4;
            // 
            // tabPageAssistants
            // 
            tabPageAssistants.Controls.Add(btnDeleteAssistant);
            tabPageAssistants.Controls.Add(btnEditAssistant);
            tabPageAssistants.Controls.Add(btnAddAssistant);
            tabPageAssistants.Controls.Add(dgvAssistants);
            tabPageAssistants.Location = new Point(4, 29);
            tabPageAssistants.Name = "tabPageAssistants";
            tabPageAssistants.Padding = new Padding(3);
            tabPageAssistants.Size = new Size(1146, 506);
            tabPageAssistants.TabIndex = 2;
            tabPageAssistants.Text = "Assistants";
            tabPageAssistants.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAssistant
            // 
            btnDeleteAssistant.Location = new Point(7, 462);
            btnDeleteAssistant.Name = "btnDeleteAssistant";
            btnDeleteAssistant.Size = new Size(345, 29);
            btnDeleteAssistant.TabIndex = 11;
            btnDeleteAssistant.Text = "Delete Assistant";
            btnDeleteAssistant.UseVisualStyleBackColor = true;
            // 
            // btnEditAssistant
            // 
            btnEditAssistant.Location = new Point(7, 427);
            btnEditAssistant.Name = "btnEditAssistant";
            btnEditAssistant.Size = new Size(345, 29);
            btnEditAssistant.TabIndex = 10;
            btnEditAssistant.Text = "Edit Assistant";
            btnEditAssistant.UseVisualStyleBackColor = true;
            // 
            // btnAddAssistant
            // 
            btnAddAssistant.Location = new Point(7, 392);
            btnAddAssistant.Name = "btnAddAssistant";
            btnAddAssistant.Size = new Size(345, 29);
            btnAddAssistant.TabIndex = 9;
            btnAddAssistant.Text = "Add Assistant";
            btnAddAssistant.UseVisualStyleBackColor = true;
            // 
            // dgvAssistants
            // 
            dgvAssistants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssistants.Location = new Point(7, 15);
            dgvAssistants.Name = "dgvAssistants";
            dgvAssistants.RowHeadersWidth = 51;
            dgvAssistants.Size = new Size(1132, 336);
            dgvAssistants.TabIndex = 8;
            // 
            // tabPageContainers
            // 
            tabPageContainers.Controls.Add(btnDeleteContainer);
            tabPageContainers.Controls.Add(btnEditContainer);
            tabPageContainers.Controls.Add(btnAddContainer);
            tabPageContainers.Controls.Add(dgvContainers);
            tabPageContainers.Location = new Point(4, 29);
            tabPageContainers.Name = "tabPageContainers";
            tabPageContainers.Padding = new Padding(3);
            tabPageContainers.Size = new Size(1146, 506);
            tabPageContainers.TabIndex = 3;
            tabPageContainers.Text = "Containers";
            tabPageContainers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteContainer
            // 
            btnDeleteContainer.Location = new Point(7, 462);
            btnDeleteContainer.Name = "btnDeleteContainer";
            btnDeleteContainer.Size = new Size(345, 29);
            btnDeleteContainer.TabIndex = 15;
            btnDeleteContainer.Text = "Delete Container";
            btnDeleteContainer.UseVisualStyleBackColor = true;
            // 
            // btnEditContainer
            // 
            btnEditContainer.Location = new Point(7, 427);
            btnEditContainer.Name = "btnEditContainer";
            btnEditContainer.Size = new Size(345, 29);
            btnEditContainer.TabIndex = 14;
            btnEditContainer.Text = "Edit Container";
            btnEditContainer.UseVisualStyleBackColor = true;
            // 
            // btnAddContainer
            // 
            btnAddContainer.Location = new Point(7, 392);
            btnAddContainer.Name = "btnAddContainer";
            btnAddContainer.Size = new Size(345, 29);
            btnAddContainer.TabIndex = 13;
            btnAddContainer.Text = "Add Container";
            btnAddContainer.UseVisualStyleBackColor = true;
            // 
            // dgvContainers
            // 
            dgvContainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContainers.Location = new Point(7, 15);
            dgvContainers.Name = "dgvContainers";
            dgvContainers.RowHeadersWidth = 51;
            dgvContainers.Size = new Size(1132, 336);
            dgvContainers.TabIndex = 12;
            // 
            // tabPageTransportUnits
            // 
            tabPageTransportUnits.Controls.Add(btnDeleteTransportUnit);
            tabPageTransportUnits.Controls.Add(btnEditTransportUnit);
            tabPageTransportUnits.Controls.Add(btnAddTransportUnit);
            tabPageTransportUnits.Controls.Add(dgvTransportUnits);
            tabPageTransportUnits.Location = new Point(4, 29);
            tabPageTransportUnits.Name = "tabPageTransportUnits";
            tabPageTransportUnits.Padding = new Padding(3);
            tabPageTransportUnits.Size = new Size(1146, 506);
            tabPageTransportUnits.TabIndex = 4;
            tabPageTransportUnits.Text = "Transport Units";
            tabPageTransportUnits.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTransportUnit
            // 
            btnDeleteTransportUnit.Location = new Point(7, 462);
            btnDeleteTransportUnit.Name = "btnDeleteTransportUnit";
            btnDeleteTransportUnit.Size = new Size(345, 29);
            btnDeleteTransportUnit.TabIndex = 19;
            btnDeleteTransportUnit.Text = "Delete Transport Unit";
            btnDeleteTransportUnit.UseVisualStyleBackColor = true;
            // 
            // btnEditTransportUnit
            // 
            btnEditTransportUnit.Location = new Point(7, 427);
            btnEditTransportUnit.Name = "btnEditTransportUnit";
            btnEditTransportUnit.Size = new Size(345, 29);
            btnEditTransportUnit.TabIndex = 18;
            btnEditTransportUnit.Text = "Edit Transport Unit";
            btnEditTransportUnit.UseVisualStyleBackColor = true;
            // 
            // btnAddTransportUnit
            // 
            btnAddTransportUnit.Location = new Point(7, 392);
            btnAddTransportUnit.Name = "btnAddTransportUnit";
            btnAddTransportUnit.Size = new Size(345, 29);
            btnAddTransportUnit.TabIndex = 17;
            btnAddTransportUnit.Text = "Add Transport Unit";
            btnAddTransportUnit.UseVisualStyleBackColor = true;
            // 
            // dgvTransportUnits
            // 
            dgvTransportUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransportUnits.Location = new Point(7, 15);
            dgvTransportUnits.Name = "dgvTransportUnits";
            dgvTransportUnits.RowHeadersWidth = 51;
            dgvTransportUnits.Size = new Size(1132, 336);
            dgvTransportUnits.TabIndex = 16;
            // 
            // tabPageAdminNotifications
            // 
            tabPageAdminNotifications.Controls.Add(btnRefreshNotifications);
            tabPageAdminNotifications.Controls.Add(btnMarkAsRead);
            tabPageAdminNotifications.Controls.Add(dgvAdminNotifications);
            tabPageAdminNotifications.Location = new Point(4, 29);
            tabPageAdminNotifications.Name = "tabPageAdminNotifications";
            tabPageAdminNotifications.Padding = new Padding(3);
            tabPageAdminNotifications.Size = new Size(1157, 545);
            tabPageAdminNotifications.TabIndex = 4;
            tabPageAdminNotifications.Text = "Admin Notifications";
            tabPageAdminNotifications.UseVisualStyleBackColor = true;
            // 
            // btnRefreshNotifications
            // 
            btnRefreshNotifications.Location = new Point(17, 495);
            btnRefreshNotifications.Name = "btnRefreshNotifications";
            btnRefreshNotifications.Size = new Size(388, 29);
            btnRefreshNotifications.TabIndex = 2;
            btnRefreshNotifications.Text = "Refresh Notifications";
            btnRefreshNotifications.UseVisualStyleBackColor = true;
            // 
            // btnMarkAsRead
            // 
            btnMarkAsRead.Location = new Point(17, 448);
            btnMarkAsRead.Name = "btnMarkAsRead";
            btnMarkAsRead.Size = new Size(388, 29);
            btnMarkAsRead.TabIndex = 1;
            btnMarkAsRead.Text = "Mark Selected as Read";
            btnMarkAsRead.UseVisualStyleBackColor = true;
            // 
            // dgvAdminNotifications
            // 
            dgvAdminNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminNotifications.Location = new Point(0, 0);
            dgvAdminNotifications.Name = "dgvAdminNotifications";
            dgvAdminNotifications.RowHeadersWidth = 51;
            dgvAdminNotifications.Size = new Size(1154, 427);
            dgvAdminNotifications.TabIndex = 0;
            // 
            // tabPageUserManagement
            // 
            tabPageUserManagement.Controls.Add(btnLogout);
            tabPageUserManagement.Controls.Add(btnToggleUserActiveStatus);
            tabPageUserManagement.Controls.Add(btnEditUserRole);
            tabPageUserManagement.Controls.Add(btnAddUser);
            tabPageUserManagement.Controls.Add(dgvUsers);
            tabPageUserManagement.Location = new Point(4, 29);
            tabPageUserManagement.Name = "tabPageUserManagement";
            tabPageUserManagement.Padding = new Padding(3);
            tabPageUserManagement.Size = new Size(1157, 545);
            tabPageUserManagement.TabIndex = 5;
            tabPageUserManagement.Text = "User Management";
            tabPageUserManagement.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(946, 456);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(205, 29);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnToggleUserActiveStatus
            // 
            btnToggleUserActiveStatus.Location = new Point(8, 501);
            btnToggleUserActiveStatus.Name = "btnToggleUserActiveStatus";
            btnToggleUserActiveStatus.Size = new Size(418, 29);
            btnToggleUserActiveStatus.TabIndex = 3;
            btnToggleUserActiveStatus.Text = "Toggle User Active Status";
            btnToggleUserActiveStatus.UseVisualStyleBackColor = true;
            // 
            // btnEditUserRole
            // 
            btnEditUserRole.Location = new Point(8, 456);
            btnEditUserRole.Name = "btnEditUserRole";
            btnEditUserRole.Size = new Size(418, 29);
            btnEditUserRole.TabIndex = 2;
            btnEditUserRole.Text = "Edit User Role";
            btnEditUserRole.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(8, 406);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(418, 29);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(1157, 375);
            dgvUsers.TabIndex = 0;
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
            groupBoxTotalCustomers.ResumeLayout(false);
            groupBoxTotalCustomers.PerformLayout();
            groupBoxAvailableDrivers.ResumeLayout(false);
            groupBoxAvailableDrivers.PerformLayout();
            groupBoxAvailableLorries.ResumeLayout(false);
            groupBoxAvailableLorries.PerformLayout();
            groupBoxJobRequests.ResumeLayout(false);
            groupBoxJobRequests.PerformLayout();
            groupBoxActiveJobs.ResumeLayout(false);
            groupBoxActiveJobs.PerformLayout();
            tabPageJobs.ResumeLayout(false);
            tabPageJobs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            tabPageCustomers.ResumeLayout(false);
            tabPageCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            tabPageResources.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPageLorries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLorries).EndInit();
            tabPageDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            tabPageAssistants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAssistants).EndInit();
            tabPageContainers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContainers).EndInit();
            tabPageTransportUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransportUnits).EndInit();
            tabPageAdminNotifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdminNotifications).EndInit();
            tabPageUserManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
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
        private ComboBox cmbJobStatusFilter;
        private TextBox txtSearchJobs;
        private DataGridView dgvJobs;
        private Button btnUpdateJobStatus;
        private Button btnAssignTransportUnit;
        private Button btnViewJobDetails;
        private TextBox txtSearchCustomers;
        private Button btnViewCustomerDetails;
        private DataGridView dgvCustomers;
        private TabControl tabControl2;
        private TabPage tabPageLorries;
        private TabPage tabPageDrivers;
        private TabPage tabPageAssistants;
        private Button btnDeleteLorry;
        private Button btnEditLorry;
        private Button btnAddLorry;
        private DataGridView dgvLorries;
        private Button btnDeleteDriver;
        private Button btnEditDriver;
        private Button btnAddDriver;
        private DataGridView dgvDrivers;
        private TabPage tabPageContainers;
        private TabPage tabPageTransportUnits;
        private Button btnDeleteAssistant;
        private Button btnEditAssistant;
        private Button btnAddAssistant;
        private DataGridView dgvAssistants;
        private Button btnDeleteContainer;
        private Button btnEditContainer;
        private Button btnAddContainer;
        private DataGridView dgvContainers;
        private Button btnDeleteTransportUnit;
        private Button btnEditTransportUnit;
        private Button btnAddTransportUnit;
        private DataGridView dgvTransportUnits;
        private Button btnRefreshNotifications;
        private Button btnMarkAsRead;
        private DataGridView dgvAdminNotifications;
        private Button btnLogout;
        private Button btnToggleUserActiveStatus;
        private Button btnEditUserRole;
        private Button btnAddUser;
        private DataGridView dgvUsers;
    }
}