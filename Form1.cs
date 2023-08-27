using OfficeOpenXml;
using System;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace Reports_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DateTime startDate = DateTime.Today.Date;
        public DateTime endDate = DateTime.Today.Date;
        public string selectedFolder;
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value.Date;
            startDate = dtpStartDate.Value.Date;
            endDate = dtpEndDate.Value.Date;
        }
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            endDate = dtpEndDate.Value.Date;
        }

        private void btnOutputDir_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                // Set the initial directory for the dialog
                dialog.SelectedPath = "C:\\";

                // Show the dialog and get the result
                DialogResult result = dialog.ShowDialog();


                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    // The user selected a directory
                    selectedFolder = dialog.SelectedPath;
                    //Debug.WriteLine(selectedFolder);


                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                    string[] lines = richTextBox1.Lines;
                    worksheet.Cells[1, 1].Value = "Name (Original Name)";
                    worksheet.Cells[1, 2].Value = "User Email";
                    worksheet.Cells[1, 3].Value = "Join Time";
                    worksheet.Cells[1, 4].Value = "Leave Time";
                    worksheet.Cells[1, 5].Value = "Duration (Minutes)";
                    worksheet.Cells[1, 6].Value = "Guest";


                    for (int i = 0; i < lines.Length; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = lines[i];
                        worksheet.Column(1).Width = 30;
                        Random rnd = new Random();
                        int firstminute = rnd.Next((int)numericFirstMinute.Value, (int)numericFirstMinute.Value + 16);  // creates a random minute
                        int firstsecond = rnd.Next(0, 59);
                        int lastminute = rnd.Next((int)numericLastMinute.Value, (int)numericLastMinute.Value + 16);  // creates a random minute
                        int lastsecond = rnd.Next(0, 59);
                        DateTime firstdate = currentDate.AddHours((int)numericFirstHour.Value).AddMinutes(firstminute).AddSeconds(firstsecond);
                        DateTime lastdate = currentDate.AddHours((int)numericLastHour.Value).AddMinutes(lastminute).AddSeconds(lastsecond);
                        Debug.WriteLine(lastdate);
                        worksheet.Cells[i + 2, 3].Value = firstdate;
                        worksheet.Cells[i + 2, 4].Value = lastdate;
                        worksheet.Cells[i + 2, 3].Style.Numberformat.Format = "yyyy-mm-dd hh:mm:ss";
                        worksheet.Cells[i + 2, 4].Style.Numberformat.Format = "yyyy-mm-dd hh:mm:ss";
                        TimeSpan difference = lastdate - firstdate;
                        double diffMinutes = difference.TotalMinutes;
                        int roundedDiffMinutes = (int)Math.Round(diffMinutes, MidpointRounding.AwayFromZero);
                        worksheet.Cells[i + 2, 5].Value = roundedDiffMinutes;
                        worksheet.Column(3).AutoFit();
                        worksheet.Column(4).AutoFit();
                        worksheet.Column(5).AutoFit();
                        if(i == 0)
                        {
                            worksheet.Cells[i + 2, 2].Value = lines[i]+"@pixelearnig.gr";
                            worksheet.Column(2).AutoFit();
                            worksheet.Cells[i + 2, 6].Value = "No";
                        }
                        else
                        {
                            worksheet.Cells[i + 2, 6].Value = "Yes";
                        }
                        worksheet.Column(6).AutoFit();

                    }

                    /* Random rnd = new Random();
                     int hours = rnd.Next(17, 22);  // creates a random hour
                     int minute = rnd.Next(0, 16);  // creates a random minute
                     int second = rnd.Next(0, 59);
                     DateTime date1 = new DateTime(2022, month, day, hours, minute, second);  //defaul date format
                     string date2 = date1.ToString("dd/MM/yyyy");*/
                    
                   // Debug.WriteLine(lastdate);
                    //Debug.WriteLine(firstdate);
                    string fileDate = currentDate.ToString("MM-dd");
                    string fileName = $"{fileDate}.xlsx";
                    string exportFilePath = Path.Combine(selectedFolder, fileName);
                    excelPackage.SaveAs(new FileInfo(exportFilePath));
                }

                //MessageBox.Show("XLS file created successfully.");
            }
        }
    }
}