using SUC.Classes;
using System;
using System.Windows.Forms;

namespace SUC.Forms
{
    public partial class frmDeviceCache : Form
    {
        public frmDeviceCache()
        {
            InitializeComponent();
        }

        private void frmDeviceCache_Load(object sender, EventArgs e)
        {
            foreach(DeviceModel i in Globals.DeviceList)
            {
                lvDevicesAD.Items.Add(i.Name);
            }
        }
    }
}
