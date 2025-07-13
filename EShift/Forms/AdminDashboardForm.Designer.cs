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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            tbvAdmin = new TabControl();
            tabPageDashboard = new TabPage();
            groupBoxTotalCustomers = new GroupBox();
            pictureBox7 = new PictureBox();
            lblTotalCustomers = new Label();
            groupBoxAvailableDrivers = new GroupBox();
            pictureBox6 = new PictureBox();
            lblAvailableDrivers = new Label();
            groupBoxAvailableLorries = new GroupBox();
            pictureBox5 = new PictureBox();
            lblAvailableLorries = new Label();
            groupBoxJobRequests = new GroupBox();
            pictureBox4 = new PictureBox();
            lblPendingRequests = new Label();
            groupBoxActiveJobs = new GroupBox();
            pictureBox3 = new PictureBox();
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
            lblNotificationCount = new Label();
            btnRefreshNotifications = new Button();
            btnMarkAsRead = new Button();
            dgvNotifications = new DataGridView();
            tabPageUserManagement = new TabPage();
            btnToggleUserActiveStatus = new Button();
            btnEditUserRole = new Button();
            btnAddUser = new Button();
            dgvUsers = new DataGridView();
            panel1 = new Panel();
            pbLogout = new PictureBox();
            lblLoggedUsername = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnJobsPDF = new Button();
            btnJobsExcel = new Button();
            btnCustomersPDF = new Button();
            btnCustomersExcel = new Button();
            tbvAdmin.SuspendLayout();
            tabPageDashboard.SuspendLayout();
            groupBoxTotalCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            groupBoxAvailableDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            groupBoxAvailableLorries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBoxJobRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBoxActiveJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).BeginInit();
            tabPageUserManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbvAdmin
            // 
            tbvAdmin.Controls.Add(tabPageDashboard);
            tbvAdmin.Controls.Add(tabPageJobs);
            tbvAdmin.Controls.Add(tabPageCustomers);
            tbvAdmin.Controls.Add(tabPageResources);
            tbvAdmin.Controls.Add(tabPageAdminNotifications);
            tbvAdmin.Controls.Add(tabPageUserManagement);
            tbvAdmin.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbvAdmin.ItemSize = new Size(161, 40);
            tbvAdmin.Location = new Point(1, 96);
            tbvAdmin.Name = "tbvAdmin";
            tbvAdmin.SelectedIndex = 0;
            tbvAdmin.Size = new Size(1165, 617);
            tbvAdmin.TabIndex = 0;
            // 
            // tabPageDashboard
            // 
            tabPageDashboard.BackgroundImage = (Image)resources.GetObject("tabPageDashboard.BackgroundImage");
            tabPageDashboard.BackgroundImageLayout = ImageLayout.Stretch;
            tabPageDashboard.Controls.Add(btnCustomersExcel);
            tabPageDashboard.Controls.Add(btnCustomersPDF);
            tabPageDashboard.Controls.Add(btnJobsExcel);
            tabPageDashboard.Controls.Add(btnJobsPDF);
            tabPageDashboard.Controls.Add(groupBoxTotalCustomers);
            tabPageDashboard.Controls.Add(groupBoxAvailableDrivers);
            tabPageDashboard.Controls.Add(groupBoxAvailableLorries);
            tabPageDashboard.Controls.Add(groupBoxJobRequests);
            tabPageDashboard.Controls.Add(groupBoxActiveJobs);
            tabPageDashboard.Location = new Point(4, 44);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Padding = new Padding(3);
            tabPageDashboard.Size = new Size(1157, 569);
            tabPageDashboard.TabIndex = 0;
            tabPageDashboard.Text = "Dashboard Overview";
            tabPageDashboard.UseVisualStyleBackColor = true;
            // 
            // groupBoxTotalCustomers
            // 
            groupBoxTotalCustomers.Controls.Add(pictureBox7);
            groupBoxTotalCustomers.Controls.Add(lblTotalCustomers);
            groupBoxTotalCustomers.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            groupBoxTotalCustomers.ForeColor = Color.Navy;
            groupBoxTotalCustomers.Location = new Point(678, 288);
            groupBoxTotalCustomers.Name = "groupBoxTotalCustomers";
            groupBoxTotalCustomers.Size = new Size(294, 168);
            groupBoxTotalCustomers.TabIndex = 2;
            groupBoxTotalCustomers.TabStop = false;
            groupBoxTotalCustomers.Text = "Total Customers:";
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(15, 39);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(120, 120);
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold);
            lblTotalCustomers.ForeColor = Color.DarkCyan;
            lblTotalCustomers.Location = new Point(159, 50);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(84, 91);
            lblTotalCustomers.TabIndex = 1;
            lblTotalCustomers.Text = "0";
            // 
            // groupBoxAvailableDrivers
            // 
            groupBoxAvailableDrivers.Controls.Add(pictureBox6);
            groupBoxAvailableDrivers.Controls.Add(lblAvailableDrivers);
            groupBoxAvailableDrivers.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            groupBoxAvailableDrivers.ForeColor = Color.Navy;
            groupBoxAvailableDrivers.Location = new Point(260, 288);
            groupBoxAvailableDrivers.Name = "groupBoxAvailableDrivers";
            groupBoxAvailableDrivers.Size = new Size(294, 168);
            groupBoxAvailableDrivers.TabIndex = 2;
            groupBoxAvailableDrivers.TabStop = false;
            groupBoxAvailableDrivers.Text = "Available Drivers:";
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(17, 39);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(120, 120);
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // lblAvailableDrivers
            // 
            lblAvailableDrivers.AutoSize = true;
            lblAvailableDrivers.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold);
            lblAvailableDrivers.ForeColor = SystemColors.MenuHighlight;
            lblAvailableDrivers.Location = new Point(164, 50);
            lblAvailableDrivers.Name = "lblAvailableDrivers";
            lblAvailableDrivers.Size = new Size(84, 91);
            lblAvailableDrivers.TabIndex = 1;
            lblAvailableDrivers.Text = "0";
            // 
            // groupBoxAvailableLorries
            // 
            groupBoxAvailableLorries.Controls.Add(pictureBox5);
            groupBoxAvailableLorries.Controls.Add(lblAvailableLorries);
            groupBoxAvailableLorries.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            groupBoxAvailableLorries.ForeColor = Color.Navy;
            groupBoxAvailableLorries.Location = new Point(801, 87);
            groupBoxAvailableLorries.Name = "groupBoxAvailableLorries";
            groupBoxAvailableLorries.Size = new Size(294, 168);
            groupBoxAvailableLorries.TabIndex = 2;
            groupBoxAvailableLorries.TabStop = false;
            groupBoxAvailableLorries.Text = "Available Lorries:";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(20, 35);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(120, 120);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // lblAvailableLorries
            // 
            lblAvailableLorries.AutoSize = true;
            lblAvailableLorries.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold);
            lblAvailableLorries.ForeColor = Color.GreenYellow;
            lblAvailableLorries.Location = new Point(167, 51);
            lblAvailableLorries.Name = "lblAvailableLorries";
            lblAvailableLorries.Size = new Size(84, 91);
            lblAvailableLorries.TabIndex = 1;
            lblAvailableLorries.Text = "0";
            // 
            // groupBoxJobRequests
            // 
            groupBoxJobRequests.Controls.Add(pictureBox4);
            groupBoxJobRequests.Controls.Add(lblPendingRequests);
            groupBoxJobRequests.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            groupBoxJobRequests.ForeColor = Color.Navy;
            groupBoxJobRequests.Location = new Point(424, 87);
            groupBoxJobRequests.Name = "groupBoxJobRequests";
            groupBoxJobRequests.Size = new Size(294, 168);
            groupBoxJobRequests.TabIndex = 2;
            groupBoxJobRequests.TabStop = false;
            groupBoxJobRequests.Text = "Pending Job Requests:";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(19, 35);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(120, 120);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // lblPendingRequests
            // 
            lblPendingRequests.AutoSize = true;
            lblPendingRequests.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold);
            lblPendingRequests.ForeColor = Color.Tomato;
            lblPendingRequests.Location = new Point(158, 51);
            lblPendingRequests.Name = "lblPendingRequests";
            lblPendingRequests.Size = new Size(84, 91);
            lblPendingRequests.TabIndex = 1;
            lblPendingRequests.Text = "0";
            // 
            // groupBoxActiveJobs
            // 
            groupBoxActiveJobs.Controls.Add(pictureBox3);
            groupBoxActiveJobs.Controls.Add(lblTotalActiveJobs);
            groupBoxActiveJobs.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            groupBoxActiveJobs.ForeColor = Color.Navy;
            groupBoxActiveJobs.Location = new Point(60, 87);
            groupBoxActiveJobs.Name = "groupBoxActiveJobs";
            groupBoxActiveJobs.Size = new Size(294, 168);
            groupBoxActiveJobs.TabIndex = 0;
            groupBoxActiveJobs.TabStop = false;
            groupBoxActiveJobs.Text = "Total Active Jobs:";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(19, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 120);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // lblTotalActiveJobs
            // 
            lblTotalActiveJobs.AutoSize = true;
            lblTotalActiveJobs.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold);
            lblTotalActiveJobs.ForeColor = Color.Gold;
            lblTotalActiveJobs.Location = new Point(152, 51);
            lblTotalActiveJobs.Name = "lblTotalActiveJobs";
            lblTotalActiveJobs.Size = new Size(84, 91);
            lblTotalActiveJobs.TabIndex = 1;
            lblTotalActiveJobs.Text = "0";
            // 
            // tabPageJobs
            // 
            tabPageJobs.Controls.Add(btnUpdateJobStatus);
            tabPageJobs.Controls.Add(btnAssignTransportUnit);
            tabPageJobs.Controls.Add(btnViewJobDetails);
            tabPageJobs.Controls.Add(cmbJobStatusFilter);
            tabPageJobs.Controls.Add(txtSearchJobs);
            tabPageJobs.Controls.Add(dgvJobs);
            tabPageJobs.Location = new Point(4, 44);
            tabPageJobs.Name = "tabPageJobs";
            tabPageJobs.Padding = new Padding(3);
            tabPageJobs.Size = new Size(1157, 569);
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
            btnUpdateJobStatus.Click += btnUpdateJobStatus_Click_1;
            // 
            // btnAssignTransportUnit
            // 
            btnAssignTransportUnit.Location = new Point(785, 446);
            btnAssignTransportUnit.Name = "btnAssignTransportUnit";
            btnAssignTransportUnit.Size = new Size(261, 29);
            btnAssignTransportUnit.TabIndex = 4;
            btnAssignTransportUnit.Text = "Assign Transport Unit";
            btnAssignTransportUnit.UseVisualStyleBackColor = true;
            btnAssignTransportUnit.Click += btnAssignTransportUnit_Click_1;
            // 
            // btnViewJobDetails
            // 
            btnViewJobDetails.Location = new Point(785, 389);
            btnViewJobDetails.Name = "btnViewJobDetails";
            btnViewJobDetails.Size = new Size(261, 29);
            btnViewJobDetails.TabIndex = 3;
            btnViewJobDetails.Text = "View Job Details";
            btnViewJobDetails.UseVisualStyleBackColor = true;
            btnViewJobDetails.Click += btnViewJobDetails_Click_1;
            // 
            // cmbJobStatusFilter
            // 
            cmbJobStatusFilter.FormattingEnabled = true;
            cmbJobStatusFilter.Location = new Point(304, 379);
            cmbJobStatusFilter.Name = "cmbJobStatusFilter";
            cmbJobStatusFilter.Size = new Size(282, 29);
            cmbJobStatusFilter.TabIndex = 2;
            // 
            // txtSearchJobs
            // 
            txtSearchJobs.Location = new Point(8, 380);
            txtSearchJobs.Name = "txtSearchJobs";
            txtSearchJobs.PlaceholderText = "Enter keyword here to search jobs....";
            txtSearchJobs.Size = new Size(274, 28);
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
            tabPageCustomers.Location = new Point(4, 44);
            tabPageCustomers.Name = "tabPageCustomers";
            tabPageCustomers.Padding = new Padding(3);
            tabPageCustomers.Size = new Size(1157, 569);
            tabPageCustomers.TabIndex = 2;
            tabPageCustomers.Text = "Customer Management";
            tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // txtSearchCustomers
            // 
            txtSearchCustomers.Location = new Point(8, 368);
            txtSearchCustomers.Name = "txtSearchCustomers";
            txtSearchCustomers.PlaceholderText = "Search...";
            txtSearchCustomers.Size = new Size(333, 28);
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
            tabPageResources.Location = new Point(4, 44);
            tabPageResources.Name = "tabPageResources";
            tabPageResources.Padding = new Padding(3);
            tabPageResources.Size = new Size(1157, 569);
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
            tabControl2.Size = new Size(1154, 569);
            tabControl2.TabIndex = 0;
            // 
            // tabPageLorries
            // 
            tabPageLorries.Controls.Add(btnDeleteLorry);
            tabPageLorries.Controls.Add(btnEditLorry);
            tabPageLorries.Controls.Add(btnAddLorry);
            tabPageLorries.Controls.Add(dgvLorries);
            tabPageLorries.Location = new Point(4, 30);
            tabPageLorries.Name = "tabPageLorries";
            tabPageLorries.Padding = new Padding(3);
            tabPageLorries.Size = new Size(1146, 535);
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
            tabPageDrivers.Size = new Size(1146, 536);
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
            btnDeleteDriver.Click += btnDeleteDriver_Click;
            // 
            // btnEditDriver
            // 
            btnEditDriver.Location = new Point(7, 427);
            btnEditDriver.Name = "btnEditDriver";
            btnEditDriver.Size = new Size(345, 29);
            btnEditDriver.TabIndex = 6;
            btnEditDriver.Text = "Edit Driver";
            btnEditDriver.UseVisualStyleBackColor = true;
            btnEditDriver.Click += btnEditDriver_Click;
            // 
            // btnAddDriver
            // 
            btnAddDriver.Location = new Point(7, 392);
            btnAddDriver.Name = "btnAddDriver";
            btnAddDriver.Size = new Size(345, 29);
            btnAddDriver.TabIndex = 5;
            btnAddDriver.Text = "Add Driver";
            btnAddDriver.UseVisualStyleBackColor = true;
            btnAddDriver.Click += btnAddDriver_Click;
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
            tabPageAssistants.Size = new Size(1146, 536);
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
            btnDeleteAssistant.Click += btnDeleteAssistant_Click;
            // 
            // btnEditAssistant
            // 
            btnEditAssistant.Location = new Point(7, 427);
            btnEditAssistant.Name = "btnEditAssistant";
            btnEditAssistant.Size = new Size(345, 29);
            btnEditAssistant.TabIndex = 10;
            btnEditAssistant.Text = "Edit Assistant";
            btnEditAssistant.UseVisualStyleBackColor = true;
            btnEditAssistant.Click += btnEditAssistant_Click;
            // 
            // btnAddAssistant
            // 
            btnAddAssistant.Location = new Point(7, 392);
            btnAddAssistant.Name = "btnAddAssistant";
            btnAddAssistant.Size = new Size(345, 29);
            btnAddAssistant.TabIndex = 9;
            btnAddAssistant.Text = "Add Assistant";
            btnAddAssistant.UseVisualStyleBackColor = true;
            btnAddAssistant.Click += btnAddAssistant_Click;
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
            tabPageContainers.Size = new Size(1146, 536);
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
            btnDeleteContainer.Click += btnDeleteContainer_Click;
            // 
            // btnEditContainer
            // 
            btnEditContainer.Location = new Point(7, 427);
            btnEditContainer.Name = "btnEditContainer";
            btnEditContainer.Size = new Size(345, 29);
            btnEditContainer.TabIndex = 14;
            btnEditContainer.Text = "Edit Container";
            btnEditContainer.UseVisualStyleBackColor = true;
            btnEditContainer.Click += btnEditContainer_Click;
            // 
            // btnAddContainer
            // 
            btnAddContainer.Location = new Point(7, 392);
            btnAddContainer.Name = "btnAddContainer";
            btnAddContainer.Size = new Size(345, 29);
            btnAddContainer.TabIndex = 13;
            btnAddContainer.Text = "Add Container";
            btnAddContainer.UseVisualStyleBackColor = true;
            btnAddContainer.Click += btnAddContainer_Click;
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
            tabPageTransportUnits.Size = new Size(1146, 536);
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
            btnDeleteTransportUnit.Click += btnDeleteTransportUnit_Click;
            // 
            // btnEditTransportUnit
            // 
            btnEditTransportUnit.Location = new Point(7, 427);
            btnEditTransportUnit.Name = "btnEditTransportUnit";
            btnEditTransportUnit.Size = new Size(345, 29);
            btnEditTransportUnit.TabIndex = 18;
            btnEditTransportUnit.Text = "Edit Transport Unit";
            btnEditTransportUnit.UseVisualStyleBackColor = true;
            btnEditTransportUnit.Click += btnEditTransportUnit_Click;
            // 
            // btnAddTransportUnit
            // 
            btnAddTransportUnit.Location = new Point(7, 392);
            btnAddTransportUnit.Name = "btnAddTransportUnit";
            btnAddTransportUnit.Size = new Size(345, 29);
            btnAddTransportUnit.TabIndex = 17;
            btnAddTransportUnit.Text = "Add Transport Unit";
            btnAddTransportUnit.UseVisualStyleBackColor = true;
            btnAddTransportUnit.Click += btnAddTransportUnit_Click;
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
            tabPageAdminNotifications.Controls.Add(lblNotificationCount);
            tabPageAdminNotifications.Controls.Add(btnRefreshNotifications);
            tabPageAdminNotifications.Controls.Add(btnMarkAsRead);
            tabPageAdminNotifications.Controls.Add(dgvNotifications);
            tabPageAdminNotifications.Location = new Point(4, 44);
            tabPageAdminNotifications.Name = "tabPageAdminNotifications";
            tabPageAdminNotifications.Padding = new Padding(3);
            tabPageAdminNotifications.Size = new Size(1157, 569);
            tabPageAdminNotifications.TabIndex = 4;
            tabPageAdminNotifications.Text = "Admin Notifications";
            tabPageAdminNotifications.UseVisualStyleBackColor = true;
            // 
            // lblNotificationCount
            // 
            lblNotificationCount.AutoSize = true;
            lblNotificationCount.Location = new Point(621, 469);
            lblNotificationCount.Name = "lblNotificationCount";
            lblNotificationCount.Size = new Size(53, 21);
            lblNotificationCount.TabIndex = 3;
            lblNotificationCount.Text = "label1";
            // 
            // btnRefreshNotifications
            // 
            btnRefreshNotifications.Location = new Point(17, 495);
            btnRefreshNotifications.Name = "btnRefreshNotifications";
            btnRefreshNotifications.Size = new Size(388, 29);
            btnRefreshNotifications.TabIndex = 2;
            btnRefreshNotifications.Text = "Refresh Notifications";
            btnRefreshNotifications.UseVisualStyleBackColor = true;
            btnRefreshNotifications.Click += btnRefreshNotifications_Click;
            // 
            // btnMarkAsRead
            // 
            btnMarkAsRead.Location = new Point(17, 448);
            btnMarkAsRead.Name = "btnMarkAsRead";
            btnMarkAsRead.Size = new Size(388, 29);
            btnMarkAsRead.TabIndex = 1;
            btnMarkAsRead.Text = "Mark Selected as Read";
            btnMarkAsRead.UseVisualStyleBackColor = true;
            btnMarkAsRead.Click += btnMarkAsRead_Click;
            // 
            // dgvNotifications
            // 
            dgvNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotifications.Location = new Point(0, 0);
            dgvNotifications.Name = "dgvNotifications";
            dgvNotifications.RowHeadersWidth = 51;
            dgvNotifications.Size = new Size(1154, 427);
            dgvNotifications.TabIndex = 0;
            // 
            // tabPageUserManagement
            // 
            tabPageUserManagement.Controls.Add(btnToggleUserActiveStatus);
            tabPageUserManagement.Controls.Add(btnEditUserRole);
            tabPageUserManagement.Controls.Add(btnAddUser);
            tabPageUserManagement.Controls.Add(dgvUsers);
            tabPageUserManagement.Location = new Point(4, 44);
            tabPageUserManagement.Name = "tabPageUserManagement";
            tabPageUserManagement.Padding = new Padding(3);
            tabPageUserManagement.Size = new Size(1157, 569);
            tabPageUserManagement.TabIndex = 5;
            tabPageUserManagement.Text = "User Management";
            tabPageUserManagement.UseVisualStyleBackColor = true;
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
            panel1.Size = new Size(1166, 90);
            panel1.TabIndex = 1;
            // 
            // pbLogout
            // 
            pbLogout.BackgroundImage = (Image)resources.GetObject("pbLogout.BackgroundImage");
            pbLogout.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogout.Location = new Point(1112, 18);
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
            lblLoggedUsername.Location = new Point(973, 36);
            lblLoggedUsername.Name = "lblLoggedUsername";
            lblLoggedUsername.Size = new Size(78, 20);
            lblLoggedUsername.TabIndex = 5;
            lblLoggedUsername.Text = "username";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(927, 28);
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
            label2.Location = new Point(416, 36);
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
            // btnJobsPDF
            // 
            btnJobsPDF.Location = new Point(303, 513);
            btnJobsPDF.Name = "btnJobsPDF";
            btnJobsPDF.Size = new Size(94, 29);
            btnJobsPDF.TabIndex = 3;
            btnJobsPDF.Text = "Jobs PDF";
            btnJobsPDF.UseVisualStyleBackColor = true;
            btnJobsPDF.Click += btnJobsPDF_Click;
            // 
            // btnJobsExcel
            // 
            btnJobsExcel.Location = new Point(460, 513);
            btnJobsExcel.Name = "btnJobsExcel";
            btnJobsExcel.Size = new Size(94, 29);
            btnJobsExcel.TabIndex = 4;
            btnJobsExcel.Text = "Jobs Excel";
            btnJobsExcel.UseVisualStyleBackColor = true;
            btnJobsExcel.Click += btnJobsExcel_Click;
            // 
            // btnCustomersPDF
            // 
            btnCustomersPDF.Location = new Point(612, 513);
            btnCustomersPDF.Name = "btnCustomersPDF";
            btnCustomersPDF.Size = new Size(145, 29);
            btnCustomersPDF.TabIndex = 5;
            btnCustomersPDF.Text = "Customers PDF";
            btnCustomersPDF.UseVisualStyleBackColor = true;
            btnCustomersPDF.Click += btnCustomersPDF_Click;
            // 
            // btnCustomersExcel
            // 
            btnCustomersExcel.Location = new Point(821, 513);
            btnCustomersExcel.Name = "btnCustomersExcel";
            btnCustomersExcel.Size = new Size(161, 29);
            btnCustomersExcel.TabIndex = 6;
            btnCustomersExcel.Text = "Customers Excel";
            btnCustomersExcel.UseVisualStyleBackColor = true;
            btnCustomersExcel.Click += btnCustomersExcel_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 714);
            Controls.Add(panel1);
            Controls.Add(tbvAdmin);
            Cursor = Cursors.Hand;
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard Form";
            tbvAdmin.ResumeLayout(false);
            tabPageDashboard.ResumeLayout(false);
            groupBoxTotalCustomers.ResumeLayout(false);
            groupBoxTotalCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            groupBoxAvailableDrivers.ResumeLayout(false);
            groupBoxAvailableDrivers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            groupBoxAvailableLorries.ResumeLayout(false);
            groupBoxAvailableLorries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBoxJobRequests.ResumeLayout(false);
            groupBoxJobRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBoxActiveJobs.ResumeLayout(false);
            groupBoxActiveJobs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
            tabPageAdminNotifications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).EndInit();
            tabPageUserManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbvAdmin;
        private TabPage tabPageJobs;
        private TabPage tabPageCustomers;
        private TabPage tabPageResources;
        private TabPage tabPageAdminNotifications;
        private TabPage tabPageUserManagement;
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
        private DataGridView dgvNotifications;
        private Button btnToggleUserActiveStatus;
        private Button btnEditUserRole;
        private Button btnAddUser;
        private DataGridView dgvUsers;
        private Label lblNotificationCount;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pbLogout;
        private Label lblLoggedUsername;
        private PictureBox pictureBox2;
        private TabPage tabPageDashboard;
        private GroupBox groupBoxTotalCustomers;
        private Label lblTotalCustomers;
        private GroupBox groupBoxAvailableDrivers;
        private Label lblAvailableDrivers;
        private GroupBox groupBoxAvailableLorries;
        private Label lblAvailableLorries;
        private GroupBox groupBoxJobRequests;
        private Label lblPendingRequests;
        private GroupBox groupBoxActiveJobs;
        private Label lblTotalActiveJobs;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button btnCustomersExcel;
        private Button btnCustomersPDF;
        private Button btnJobsExcel;
        private Button btnJobsPDF;
    }
}