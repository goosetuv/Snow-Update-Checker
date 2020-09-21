namespace SUC.Forms
{
    partial class frmDevicesAD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevicesAD));
            this.lvDevicesAD = new System.Windows.Forms.ListView();
            this.DeviceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtLDAP = new System.Windows.Forms.TextBox();
            this.btnADGrab = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLDAP = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtListFilter = new System.Windows.Forms.TextBox();
            this.btnListFilter = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.cmsComputerList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsComputerList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDevicesAD
            // 
            this.lvDevicesAD.CheckBoxes = true;
            this.lvDevicesAD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DeviceName});
            this.lvDevicesAD.ContextMenuStrip = this.cmsComputerList;
            this.lvDevicesAD.GridLines = true;
            this.lvDevicesAD.HideSelection = false;
            this.lvDevicesAD.Location = new System.Drawing.Point(12, 80);
            this.lvDevicesAD.Name = "lvDevicesAD";
            this.lvDevicesAD.Size = new System.Drawing.Size(351, 201);
            this.lvDevicesAD.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvDevicesAD.TabIndex = 0;
            this.lvDevicesAD.UseCompatibleStateImageBehavior = false;
            this.lvDevicesAD.View = System.Windows.Forms.View.Details;
            // 
            // DeviceName
            // 
            this.DeviceName.Text = "Device Name";
            this.DeviceName.Width = 347;
            // 
            // txtLDAP
            // 
            this.txtLDAP.Location = new System.Drawing.Point(56, 13);
            this.txtLDAP.Name = "txtLDAP";
            this.txtLDAP.Size = new System.Drawing.Size(195, 20);
            this.txtLDAP.TabIndex = 1;
            this.txtLDAP.Text = "LDAP://";
            // 
            // btnADGrab
            // 
            this.btnADGrab.Location = new System.Drawing.Point(257, 11);
            this.btnADGrab.Name = "btnADGrab";
            this.btnADGrab.Size = new System.Drawing.Size(80, 23);
            this.btnADGrab.TabIndex = 2;
            this.btnADGrab.Text = "Scan";
            this.btnADGrab.UseVisualStyleBackColor = true;
            this.btnADGrab.Click += new System.EventHandler(this.btnADGrab_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(343, 11);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(20, 23);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(283, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLDAP
            // 
            this.lblLDAP.AutoSize = true;
            this.lblLDAP.Location = new System.Drawing.Point(12, 16);
            this.lblLDAP.Name = "lblLDAP";
            this.lblLDAP.Size = new System.Drawing.Size(38, 13);
            this.lblLDAP.TabIndex = 5;
            this.lblLDAP.Text = "LDAP:";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(18, 48);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(32, 13);
            this.lblFilter.TabIndex = 6;
            this.lblFilter.Text = "Filter:";
            // 
            // txtListFilter
            // 
            this.txtListFilter.Enabled = false;
            this.txtListFilter.Location = new System.Drawing.Point(56, 45);
            this.txtListFilter.Name = "txtListFilter";
            this.txtListFilter.Size = new System.Drawing.Size(195, 20);
            this.txtListFilter.TabIndex = 7;
            // 
            // btnListFilter
            // 
            this.btnListFilter.Enabled = false;
            this.btnListFilter.Location = new System.Drawing.Point(257, 43);
            this.btnListFilter.Name = "btnListFilter";
            this.btnListFilter.Size = new System.Drawing.Size(80, 23);
            this.btnListFilter.TabIndex = 8;
            this.btnListFilter.Text = "Filter";
            this.btnListFilter.UseVisualStyleBackColor = true;
            this.btnListFilter.Click += new System.EventHandler(this.btnListFilter_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(12, 287);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 9;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Visible = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // cmsComputerList
            // 
            this.cmsComputerList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.cmsComputerList.Name = "cmsComputerList";
            this.cmsComputerList.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // frmDevicesAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 319);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnListFilter);
            this.Controls.Add(this.txtListFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblLDAP);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnADGrab);
            this.Controls.Add(this.txtLDAP);
            this.Controls.Add(this.lvDevicesAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDevicesAD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Active Directory";
            this.cmsComputerList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDevicesAD;
        private System.Windows.Forms.TextBox txtLDAP;
        private System.Windows.Forms.Button btnADGrab;
        private System.Windows.Forms.ColumnHeader DeviceName;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLDAP;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtListFilter;
        private System.Windows.Forms.Button btnListFilter;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.ContextMenuStrip cmsComputerList;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}