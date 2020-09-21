namespace SUC
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgvDeviceList = new System.Windows.Forms.DataGridView();
            this.ComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenseManagerVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryServerVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenseManagerUpdateAvailable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.InventoryServerUpdateAvailable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openTemplateDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openReportsDirectoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openAppDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeviceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDeviceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.viewDeviceCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDeviceCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allComputerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allPlatformsUpdatesRequiredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.APIStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.importTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceList)).BeginInit();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDeviceList
            // 
            this.dgvDeviceList.AllowUserToAddRows = false;
            this.dgvDeviceList.AllowUserToDeleteRows = false;
            this.dgvDeviceList.AllowUserToResizeColumns = false;
            this.dgvDeviceList.AllowUserToResizeRows = false;
            this.dgvDeviceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeviceList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeviceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeviceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComputerName,
            this.ComputerStatus,
            this.LicenseManagerVersion,
            this.InventoryServerVersion,
            this.LicenseManagerUpdateAvailable,
            this.InventoryServerUpdateAvailable});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeviceList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeviceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeviceList.Location = new System.Drawing.Point(0, 24);
            this.dgvDeviceList.Name = "dgvDeviceList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeviceList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeviceList.RowHeadersVisible = false;
            this.dgvDeviceList.Size = new System.Drawing.Size(745, 313);
            this.dgvDeviceList.TabIndex = 0;
            // 
            // ComputerName
            // 
            this.ComputerName.HeaderText = "Computer           Name";
            this.ComputerName.Name = "ComputerName";
            // 
            // ComputerStatus
            // 
            this.ComputerStatus.HeaderText = "Computer            Status";
            this.ComputerStatus.Name = "ComputerStatus";
            // 
            // LicenseManagerVersion
            // 
            this.LicenseManagerVersion.HeaderText = "License Manager Version";
            this.LicenseManagerVersion.Name = "LicenseManagerVersion";
            // 
            // InventoryServerVersion
            // 
            this.InventoryServerVersion.HeaderText = "Inventory Server Version";
            this.InventoryServerVersion.Name = "InventoryServerVersion";
            // 
            // LicenseManagerUpdateAvailable
            // 
            this.LicenseManagerUpdateAvailable.HeaderText = "License Manager Update Available";
            this.LicenseManagerUpdateAvailable.Name = "LicenseManagerUpdateAvailable";
            this.LicenseManagerUpdateAvailable.ReadOnly = true;
            // 
            // InventoryServerUpdateAvailable
            // 
            this.InventoryServerUpdateAvailable.HeaderText = "Inventory Server Update Available";
            this.InventoryServerUpdateAvailable.Name = "InventoryServerUpdateAvailable";
            this.InventoryServerUpdateAvailable.ReadOnly = true;
            this.InventoryServerUpdateAvailable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.devicesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.debugDataToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(745, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "msMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startScanToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startScanToolStripMenuItem
            // 
            this.startScanToolStripMenuItem.Name = "startScanToolStripMenuItem";
            this.startScanToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.startScanToolStripMenuItem.Text = "Start Scan";
            this.startScanToolStripMenuItem.Click += new System.EventHandler(this.startScanToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTemplateDirectoryToolStripMenuItem,
            this.openReportsDirectoryToolStripMenuItem1,
            this.openAppDirectoryToolStripMenuItem});
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.openToolStripMenuItem1.Text = "Open";
            // 
            // openTemplateDirectoryToolStripMenuItem
            // 
            this.openTemplateDirectoryToolStripMenuItem.Name = "openTemplateDirectoryToolStripMenuItem";
            this.openTemplateDirectoryToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.openTemplateDirectoryToolStripMenuItem.Text = "Open Template Directory";
            this.openTemplateDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openTemplateDirectoryToolStripMenuItem_Click);
            // 
            // openReportsDirectoryToolStripMenuItem1
            // 
            this.openReportsDirectoryToolStripMenuItem1.Name = "openReportsDirectoryToolStripMenuItem1";
            this.openReportsDirectoryToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.openReportsDirectoryToolStripMenuItem1.Text = "Open Reports Directory";
            this.openReportsDirectoryToolStripMenuItem1.Click += new System.EventHandler(this.openReportsDirectoryToolStripMenuItem1_Click);
            // 
            // openAppDirectoryToolStripMenuItem
            // 
            this.openAppDirectoryToolStripMenuItem.Name = "openAppDirectoryToolStripMenuItem";
            this.openAppDirectoryToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.openAppDirectoryToolStripMenuItem.Text = "Open App Directory";
            this.openAppDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openAppDirectoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Visible = false;
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Enabled = false;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // devicesToolStripMenuItem
            // 
            this.devicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeviceListToolStripMenuItem,
            this.aDDeviceListToolStripMenuItem,
            this.toolStripSeparator3,
            this.viewDeviceCacheToolStripMenuItem,
            this.clearDeviceCacheToolStripMenuItem});
            this.devicesToolStripMenuItem.Name = "devicesToolStripMenuItem";
            this.devicesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.devicesToolStripMenuItem.Text = "Computers";
            // 
            // manualDeviceListToolStripMenuItem
            // 
            this.manualDeviceListToolStripMenuItem.Name = "manualDeviceListToolStripMenuItem";
            this.manualDeviceListToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.manualDeviceListToolStripMenuItem.Text = "Manual";
            this.manualDeviceListToolStripMenuItem.Click += new System.EventHandler(this.manualDeviceListToolStripMenuItem_Click);
            // 
            // aDDeviceListToolStripMenuItem
            // 
            this.aDDeviceListToolStripMenuItem.Name = "aDDeviceListToolStripMenuItem";
            this.aDDeviceListToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.aDDeviceListToolStripMenuItem.Text = "Active Directory";
            this.aDDeviceListToolStripMenuItem.Click += new System.EventHandler(this.aDDeviceListToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(191, 6);
            // 
            // viewDeviceCacheToolStripMenuItem
            // 
            this.viewDeviceCacheToolStripMenuItem.Name = "viewDeviceCacheToolStripMenuItem";
            this.viewDeviceCacheToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.viewDeviceCacheToolStripMenuItem.Text = "View Computer Cache";
            this.viewDeviceCacheToolStripMenuItem.Click += new System.EventHandler(this.viewDeviceCacheToolStripMenuItem_Click);
            // 
            // clearDeviceCacheToolStripMenuItem
            // 
            this.clearDeviceCacheToolStripMenuItem.Name = "clearDeviceCacheToolStripMenuItem";
            this.clearDeviceCacheToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.clearDeviceCacheToolStripMenuItem.Text = "Clear Computer Cache";
            this.clearDeviceCacheToolStripMenuItem.Click += new System.EventHandler(this.clearDeviceCacheToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceCacheToolStripMenuItem,
            this.allComputerInformationToolStripMenuItem,
            this.allPlatformsUpdatesRequiredToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // deviceCacheToolStripMenuItem
            // 
            this.deviceCacheToolStripMenuItem.Name = "deviceCacheToolStripMenuItem";
            this.deviceCacheToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.deviceCacheToolStripMenuItem.Text = "All Computers Cache";
            this.deviceCacheToolStripMenuItem.Click += new System.EventHandler(this.deviceCacheToolStripMenuItem_Click);
            // 
            // allComputerInformationToolStripMenuItem
            // 
            this.allComputerInformationToolStripMenuItem.Name = "allComputerInformationToolStripMenuItem";
            this.allComputerInformationToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.allComputerInformationToolStripMenuItem.Text = "All Platforms Information";
            this.allComputerInformationToolStripMenuItem.Click += new System.EventHandler(this.allComputerInformationToolStripMenuItem_Click);
            // 
            // allPlatformsUpdatesRequiredToolStripMenuItem
            // 
            this.allPlatformsUpdatesRequiredToolStripMenuItem.Name = "allPlatformsUpdatesRequiredToolStripMenuItem";
            this.allPlatformsUpdatesRequiredToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.allPlatformsUpdatesRequiredToolStripMenuItem.Text = "All Platforms Updates Required";
            this.allPlatformsUpdatesRequiredToolStripMenuItem.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.APIStatusToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator2,
            this.importTemplateToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // APIStatusToolStripMenuItem
            // 
            this.APIStatusToolStripMenuItem.Name = "APIStatusToolStripMenuItem";
            this.APIStatusToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.APIStatusToolStripMenuItem.Text = "API Status";
            this.APIStatusToolStripMenuItem.Click += new System.EventHandler(this.APIStatusToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // importTemplateToolStripMenuItem
            // 
            this.importTemplateToolStripMenuItem.Name = "importTemplateToolStripMenuItem";
            this.importTemplateToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.importTemplateToolStripMenuItem.Text = "Import Template";
            this.importTemplateToolStripMenuItem.Click += new System.EventHandler(this.importTemplateToolStripMenuItem_Click);
            // 
            // debugDataToolStripMenuItem
            // 
            this.debugDataToolStripMenuItem.Name = "debugDataToolStripMenuItem";
            this.debugDataToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.debugDataToolStripMenuItem.Text = "DebugData";
            this.debugDataToolStripMenuItem.Visible = false;
            this.debugDataToolStripMenuItem.Click += new System.EventHandler(this.debugDataToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 337);
            this.Controls.Add(this.dgvDeviceList);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.MinimumSize = new System.Drawing.Size(761, 376);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snow Update Checker";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceList)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeviceList;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeviceListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDeviceListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem APIStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem clearDeviceCacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDeviceCacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceCacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allComputerInformationToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenseManagerVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryServerVersion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LicenseManagerUpdateAvailable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn InventoryServerUpdateAvailable;
        private System.Windows.Forms.ToolStripMenuItem allPlatformsUpdatesRequiredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem importTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openTemplateDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openReportsDirectoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openAppDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugDataToolStripMenuItem;
    }
}

