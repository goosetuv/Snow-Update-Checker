using SUC.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Laim;
using Microsoft.VisualBasic;

namespace SUC.Forms
{
    public partial class frmDevicesAD : Form
    {
        #region Fields/Properties
        List<DeviceModel> tempDevices = new List<DeviceModel>();
        bool ItemEdited = false;
        #endregion

        #region Constructor
        public frmDevicesAD()
        {
            InitializeComponent();
            txtLDAP.Text = ActiveDirectory.GetLDAPAsync();
        }
        #endregion

        #region Buttons
        private void btnADGrab_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLDAP.TextLength > 7)
                {
                    if (txtLDAP.Text == @"LDAP://laim.scot")
                    {
                        #region DEV
                        tempDevices.Add(new DeviceModel() { Name = "Localhost" });
                        int DevCount = 0;
                        while (DevCount < 2)
                        {
                            tempDevices.Add(
                                new DeviceModel() { Name = "Test " + Utility.Random(false, false) }
                            );
                            DevCount += 1;
                        }
                        lvDevicesAD.Items.AddRange(tempDevices.Select(c => new ListViewItem(c.Name)).ToArray());
                        #endregion
                    }
                    else
                    {
                        #region PROD
                        lvDevicesAD.Items.Clear();
                        tempDevices.Clear();

                        foreach (string i in ActiveDirectory.GetComputers(txtLDAP.Text))
                        {
                            lvDevicesAD.Items.Add(i);
                            tempDevices.Add(new DeviceModel() { Name = i });
                        }
                        lvDevicesAD.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        #endregion
                    }
                    txtListFilter.Enabled = true;
                    btnListFilter.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please populate LDAP domain", "AD Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select the SQL Server that has your Snow Inventory and Snow License Manager database on it.  You can import multiple different platforms into the same, as long as you are selecting the relevant SQL Server for each." + Environment.NewLine + "Format can be LDAP://domain.extension or LDAP://dc=domain,dc=extension.", "AD Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int CheckCount = 0;
            foreach (ListViewItem item in lvDevicesAD.Items)
            {
                if (item.Checked)
                {
                    CheckCount += 1;
                    Classes.Globals.DeviceList.Add(new DeviceModel { Name = item.Text });
                }
            }

            if (CheckCount > 0)
            {
                MessageBox.Show("Computer List saved to Memory, the form will now close", "AD Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            } else
            {
                MessageBox.Show("An empty computer list cannot be saved", "AD Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnListFilter_Click(object sender, EventArgs e)
        {
            bool Filter = false;

            if(ItemEdited)
            {
                DialogResult dr = MessageBox.Show("You have edited items, if you filter these will be reverted.", "Filter Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {

                    Filter = true;
                }
            } else
            {
                Filter = true;
            }

            if(Filter)
            {
                lvDevicesAD.Items.Clear();
                lvDevicesAD.Items.AddRange(tempDevices.Where(i => string.IsNullOrEmpty(txtListFilter.Text) || i.Name.StartsWith(txtListFilter.Text) || i.Name.EndsWith(txtListFilter.Text) || i.Name.Contains(txtListFilter.Text))
                    .Select(c => new ListViewItem(c.Name)).ToArray());
                ItemEdited = false;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvDevicesAD.Items)
            {
                i.Checked = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lvDevicesAD.SelectedItems.Count == 1)
            {
                string input = Interaction.InputBox("Replace the below value with the new value.", "Edit Item", lvDevicesAD.SelectedItems[0].Text);
                lvDevicesAD.SelectedItems[0].Text = input;
                ItemEdited = true;
            } else
            {
                MessageBox.Show("Select an item to edit", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvDevicesAD.SelectedItems.Count == 1)
            {
                string input = Interaction.InputBox("Replace the below value with the new value.", "Edit Item", lvDevicesAD.SelectedItems[0].Text);
                lvDevicesAD.SelectedItems[0].Text = input;
                ItemEdited = true;
            }
            else
            {
                MessageBox.Show("Select an item to edit", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
