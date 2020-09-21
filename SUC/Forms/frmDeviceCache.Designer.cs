namespace SUC.Forms
{
    partial class frmDeviceCache
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeviceCache));
            this.lvDevicesAD = new System.Windows.Forms.ListView();
            this.DeviceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvDevicesAD
            // 
            this.lvDevicesAD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DeviceName});
            this.lvDevicesAD.GridLines = true;
            this.lvDevicesAD.HideSelection = false;
            this.lvDevicesAD.LabelEdit = true;
            this.lvDevicesAD.Location = new System.Drawing.Point(12, 12);
            this.lvDevicesAD.Name = "lvDevicesAD";
            this.lvDevicesAD.Size = new System.Drawing.Size(351, 295);
            this.lvDevicesAD.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvDevicesAD.TabIndex = 1;
            this.lvDevicesAD.UseCompatibleStateImageBehavior = false;
            this.lvDevicesAD.View = System.Windows.Forms.View.Details;
            // 
            // DeviceName
            // 
            this.DeviceName.Text = "Device Name";
            this.DeviceName.Width = 347;
            // 
            // frmDeviceCache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 319);
            this.Controls.Add(this.lvDevicesAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeviceCache";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Device Cache";
            this.Load += new System.EventHandler(this.frmDeviceCache_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDevicesAD;
        private System.Windows.Forms.ColumnHeader DeviceName;
    }
}