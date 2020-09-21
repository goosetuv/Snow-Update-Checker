using RestSharp;
using SUC.Classes;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SUC
{
    public partial class frmMain : Form
    {
        #region Fields/Properties
        
        #endregion

        #region Constructor
        public frmMain()
        {
            InitializeComponent();

#if DEBUG
            IfDebug();
#endif
        }
        #endregion

        #region Menu Strip
        private void aDDeviceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Forms.frmDevicesAD ad = new Forms.frmDevicesAD())
            {
                ad.ShowDialog();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startScanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.DeviceList.Count < 1)
                {
                    MessageBox.Show("Please populate the computers list", "Scan Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    GetAPIData();
                    dgvDeviceList.Rows.Clear(); //clear all existing data
                    foreach (DeviceModel i in Globals.DeviceList)
                    {
                        string status;
                        if (Globals.PingDevice(i.Name))
                        {
                            status = "Online";
                        }
                        else
                        {
                            status = "Offline";
                        }

                        string LMVersion = Laim.MSSqlServer.ExecuteReadString("Server=" + i.Name + ";Integrated Security=SSPI;Application Name=" + ProductName + ";", "SELECT DBVersion FROM SnowLicenseManager.dbo.tblSystemInfo");
                        string ISVersion = Laim.MSSqlServer.ExecuteReadString("Server=" + i.Name + ";Integrated Security=SSPI;Application Name=" + ProductName + ";", "SELECT TOP 1 ServerVersion FROM SnowInventory.inv.DbVersionHistory ORDER BY ServerVersion DESC"); ;

                        bool IsUpdatedRequiredLM = SnowAPI.VersionCheck(LMVersion, Globals.SnowAPILMVersion);
                        bool IsUpdateRequiredIS = SnowAPI.VersionCheck(ISVersion, Globals.SnowAPIISVersion);

                        // add the device to the row then move onto the next one
                        dgvDeviceList.Rows.Add(i.Name, status, LMVersion, ISVersion, IsUpdatedRequiredLM, IsUpdateRequiredIS);
                    }
                }
            } catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SqlException", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void APIStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient("https://ext.laim.scot/snowapi/api/1.0/?format=xml")
                {
                    Timeout = -1
                };
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                MessageBox.Show("Response: " + response.StatusCode.ToString(), "Snow Product API", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearDeviceCacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.DeviceList.Clear();

            if (Globals.DeviceList.Count > 0 == false)
            {
                MessageBox.Show("Computer cache cleared.", "Computer Cache", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void viewDeviceCacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Forms.frmDeviceCache dc = new Forms.frmDeviceCache())
            {
                dc.ShowDialog();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Forms.frmAbout a = new Forms.frmAbout())
            {
                a.ShowDialog();
            }
        }

        private void openReportsDirectoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Application.StartupPath + @"\Reports"))
            {
                Process.Start(Application.StartupPath + @"\Reports");
            }
            else
            {
                MessageBox.Show("Run a report to create the reports directory.", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void openAppDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath);
        }

        private void openTemplateDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Application.StartupPath + @"\Templates"))
            {
                Process.Start(Application.StartupPath + @"\Templates");
            }
            else
            {
                MessageBox.Show("Export the import template to create the templates directory..", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deviceCacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(Application.StartupPath + @"\Reports") == false)
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\Reports");
                }

                Globals.ExportXlsxList(Globals.DeviceList, Application.StartupPath + @"\Reports", "Report", "Laim McKenzie", "Computer Report");
                MessageBox.Show("Report Exported", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void allComputerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(Application.StartupPath + @"\Reports") == false)
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\Reports");
                }

                Globals.ExportXlsxDgv(dgvDeviceList, Application.StartupPath + @"\Reports", "Report", "Laim McKenzie", "Platform Report");
                MessageBox.Show("Report Exported", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void manualDeviceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Forms.frmDeviceManual m = new Forms.frmDeviceManual())
            {
                m.ShowDialog();
            }
        }

        private void debugDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetAPIData();
            dgvDeviceList.Rows.Clear();
            dgvDeviceList.Rows.Add("SVR01EXP01", "Online", "9.7.0", "6.4.0", SnowAPI.VersionCheck("9.7.0", Globals.SnowAPILMVersion), SnowAPI.VersionCheck("6.4.0", Globals.SnowAPIISVersion));
            dgvDeviceList.Rows.Add("SVR01EXP02", "Online", "8.3.12", "5.3.1", SnowAPI.VersionCheck("8.3.12", Globals.SnowAPILMVersion), SnowAPI.VersionCheck("5.3.1", Globals.SnowAPIISVersion));
            dgvDeviceList.Rows.Add("SVR01EXP03", "Online", Globals.SnowAPILMVersion, Globals.SnowAPIISVersion, SnowAPI.VersionCheck(Globals.SnowAPILMVersion, Globals.SnowAPILMVersion), SnowAPI.VersionCheck(Globals.SnowAPIISVersion, Globals.SnowAPIISVersion));
            dgvDeviceList.Rows.Add("SVR01EXP04", "Offline", "", "", false, false);
        }

        private void importTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(Application.StartupPath + @"\Templates") == false)
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\Templates");
                }
                if (File.Exists(Application.StartupPath + @"\Templates\ImportTemplate.xlsx"))
                {
                    File.Delete(Application.StartupPath + @"\Templates\ImportTemplate.xlsx");
                }
                Globals.ExportTemplate(Application.StartupPath + @"\Templates", "Import Template", "Laim McKenzie", "Import");
                MessageBox.Show("Import Template written to location.", "Template", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Functions
        private void GetAPIData()
        {
            SnowAPI snowAPI = new SnowAPI();
            var o = snowAPI.GetData().Content;

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(o);

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                if (node.InnerText.Contains("Snow License Manager 9"))
                {
                    foreach (XmlNode n1 in node.ChildNodes)
                    {
                        if (n1.Name == "Version")
                        {
                            Globals.SnowAPILMVersion = n1.InnerText;
                        }
                    }
                }

                if (node.InnerText.Contains("Snow Inventory Server 6"))
                {
                    foreach (XmlNode n1 in node.ChildNodes)
                    {
                        if (n1.Name == "Version")
                        {
                            Globals.SnowAPIISVersion = n1.InnerText;
                        }
                    }
                }
            }
        }

        private void IfDebug()
        {
            debugDataToolStripMenuItem.Visible = true;
        }
        #endregion
    }
}
