namespace SUC.Forms
{
    partial class frmAbout
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.lblAPIVersion = new System.Windows.Forms.Label();
            this.linkDev = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SUC.Properties.Resources.suc_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.AutoEllipsis = true;
            this.lblAppVersion.Location = new System.Drawing.Point(120, 122);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(126, 23);
            this.lblAppVersion.TabIndex = 1;
            this.lblAppVersion.Text = "Application Version: 1.0";
            this.lblAppVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAPIVersion
            // 
            this.lblAPIVersion.AutoEllipsis = true;
            this.lblAPIVersion.Location = new System.Drawing.Point(102, 99);
            this.lblAPIVersion.Name = "lblAPIVersion";
            this.lblAPIVersion.Size = new System.Drawing.Size(163, 23);
            this.lblAPIVersion.TabIndex = 2;
            this.lblAPIVersion.Text = "Snow Product API Version: 1.0";
            this.lblAPIVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkDev
            // 
            this.linkDev.AutoSize = true;
            this.linkDev.Location = new System.Drawing.Point(244, 145);
            this.linkDev.Name = "linkDev";
            this.linkDev.Size = new System.Drawing.Size(123, 13);
            this.linkDev.TabIndex = 3;
            this.linkDev.TabStop = true;
            this.linkDev.Text = "Made by Laim McKenzie";
            this.linkDev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDev_LinkClicked);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(367, 163);
            this.Controls.Add(this.linkDev);
            this.Controls.Add(this.lblAPIVersion);
            this.Controls.Add(this.lblAppVersion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About SUC";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAppVersion;
        private System.Windows.Forms.Label lblAPIVersion;
        private System.Windows.Forms.LinkLabel linkDev;
    }
}