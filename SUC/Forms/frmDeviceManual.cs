using OfficeOpenXml;
using SUC.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SUC.Forms
{
    public partial class frmDeviceManual : Form
    {
        #region Constructor
        public frmDeviceManual()
        {
            InitializeComponent();
        }
        #endregion

        #region Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtComputer.TextLength > 0)
            {
                lvDevicesAD.Items.Add(txtComputer.Text);
                txtComputer.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a computer name", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                lvDevicesAD.SelectedItems[0].Remove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(txtPath.Text))
                {
                    ImportFile(txtPath.Text);
                }
                else
                {
                    var filePath = string.Empty;

                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Documents";
                        openFileDialog.Filter = "Microsoft Excel File (*.xlsx)|*.xlsx";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                        }
                    }

                    txtPath.Text = filePath;
                    ImportFile(txtPath.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int CheckCount = 0;
            foreach (ListViewItem item in lvDevicesAD.Items)
            {
                CheckCount += 1;
                Globals.DeviceList.Add(new DeviceModel { Name = item.Text });
            }

            if (CheckCount > 0)
            {
                MessageBox.Show("Computer List saved to Memory, the form will now close", "Manual Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("An empty computer list cannot be saved", "Manual Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Functions
        private void ImportFile(string path)
        {
            // code from https://riptutorial.com/epplus/example/26603/import-data-from-excel-file

            //create a list to hold all the values
            List<string> excelData = new List<string>();

            //read the Excel file as byte array
            byte[] bin = File.ReadAllBytes(path);

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            //create a new Excel package in a memorystream
            using (MemoryStream stream = new MemoryStream(bin))
            using (ExcelPackage excelPackage = new ExcelPackage(stream))
            {
                //loop all worksheets
                foreach (ExcelWorksheet worksheet in excelPackage.Workbook.Worksheets)
                {
                    //loop all rows
                    for (int i = worksheet.Dimension.Start.Row; i <= worksheet.Dimension.End.Row; i++)
                    {
                        //loop all columns in a row
                        for (int j = worksheet.Dimension.Start.Column; j <= worksheet.Dimension.End.Column; j++)
                        {
                            //add the cell data to the List
                            if (worksheet.Cells[i, j].Value != null)
                            {
                                excelData.Add(worksheet.Cells[i, j].Value.ToString());
                            }
                        }
                    }
                }
            }

            foreach (string i in excelData)
            {
                if (i == "Computer Name" == false)
                {
                    lvDevicesAD.Items.Add(i);
                }
            }
        }
        #endregion
    }
}
