using OfficeOpenXml;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace SUC.Classes
{
    public class Globals
    {

        public static string SnowAPILMVersion { get; set; }
        public static string SnowAPIISVersion { get; set; }

        public static BindingList<DeviceModel> DeviceList = new BindingList<DeviceModel>();

        public static bool PingDevice(string HostName)
        {
            try
            {
                Ping p = new Ping();
                if (p.Send(HostName, 200).Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public static void ExportXlsxDgv(DataGridView dgv, string Directory, string ReportingWorkbookTitle, string ReportingWorkbookCompany, string ReportingWorksheetName)
        {

            // create the datatable because we don't have a data source in our dgv!
            DataTable dataTable = new DataTable();
            foreach(DataGridViewColumn col in dgv.Columns)
            {
                dataTable.Columns.Add(col.Name, col.CellTemplate.ValueType);
            }
            foreach(DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dataTable.NewRow();
                foreach(DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dataTable.Rows.Add(dRow);
            }


            FileInfo file = new FileInfo(Directory + "\\" + "AllPlatformsInformation" + DateTime.Now.ToString("ddMMyyyy-HHmmss") + ".xlsx");
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage ep = new ExcelPackage(file))
            {
                ExcelWorksheet ew = ep.Workbook.Worksheets.Add(ReportingWorksheetName);
                ew.Cells["A1"].LoadFromDataTable(dataTable, true);
                ew.Cells.AutoFitColumns(40);
                ep.Workbook.Properties.Application = Application.ProductName;
                ep.Workbook.Properties.AppVersion = Application.ProductVersion;
                ep.Workbook.Properties.Author = Environment.UserName;
                ep.Workbook.Properties.Title = ReportingWorkbookTitle + " Export";
                ep.Workbook.Properties.Company = ReportingWorkbookCompany;
                ep.Workbook.Properties.Comments = "https://laim.scot";
                ep.Save();
            }
        }

        public static void ExportXlsxList(BindingList<DeviceModel> list, string Directory, string ReportingWorkbookTitle, string ReportingWorkbookCompany, string ReportingWorksheetName)
        {

            // create the datatable because we don't have a data source in our dgv!
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Computer Name");
            foreach (DeviceModel dm in list)
            {
                dataTable.Rows.Add(dm.Name);
            }


            FileInfo file = new FileInfo(Directory + "\\" + "AllComputersCache" + DateTime.Now.ToString("ddMMyyyy-HHmmss") + ".xlsx");
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage ep = new ExcelPackage(file))
            {
                ExcelWorksheet ew = ep.Workbook.Worksheets.Add(ReportingWorksheetName);
                ew.Cells["A1"].LoadFromDataTable(dataTable, true);
                ew.Cells.AutoFitColumns(40);
                ep.Workbook.Properties.Application = Application.ProductName;
                ep.Workbook.Properties.AppVersion = Application.ProductVersion;
                ep.Workbook.Properties.Author = Environment.UserName;
                ep.Workbook.Properties.Title = ReportingWorkbookTitle + " Export";
                ep.Workbook.Properties.Company = ReportingWorkbookCompany;
                ep.Workbook.Properties.Comments = "https://laim.scot";
                ep.Save();
            }
        }

        public static void ExportTemplate(string Directory, string ReportingWorkbookTitle, string ReportingWorkbookCompany, string ReportingWorksheetName)
        {

            // create the datatable because we don't have a data source in our dgv!
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Computer Name");
            dataTable.Rows.Add("Localhost");


            FileInfo file = new FileInfo(Directory + @"\" + "ImportTemplate" + ".xlsx");
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage ep = new ExcelPackage(file))
            {
                ExcelWorksheet ew = ep.Workbook.Worksheets.Add(ReportingWorksheetName);
                ew.Cells["A1"].LoadFromDataTable(dataTable, true);
                ew.Cells.AutoFitColumns(40);
                ep.Workbook.Properties.Application = Application.ProductName;
                ep.Workbook.Properties.AppVersion = Application.ProductVersion;
                ep.Workbook.Properties.Author = Environment.UserName;
                ep.Workbook.Properties.Title = ReportingWorkbookTitle;
                ep.Workbook.Properties.Company = ReportingWorkbookCompany;
                ep.Workbook.Properties.Comments = "https://laim.scot";
                ep.Save();
            }
        }


    }
}
