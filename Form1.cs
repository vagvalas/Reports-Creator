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
        public string? selectedFolder;
        public string? selectedTemplateFile;

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

            if (string.IsNullOrWhiteSpace(selectedFolder))
            {
                MessageBox.Show("Please select an output folder first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(selectedTemplateFile) || !File.Exists(selectedTemplateFile))
            {
                MessageBox.Show("Please select a valid Excel template file first.");
                return;
            }



            // 1. Get participants from textbox
            List<string> names = richTextBox1.Lines
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .ToList();

            if (names.Count == 0)
            {
                MessageBox.Show("Please enter at least one participant.");
                return;
            }

            // 2. Get professor and add to list
            string professorName = textBoxProfessorName.Text.Trim();
            if (!string.IsNullOrEmpty(professorName))
            {
                names.Add(professorName);
            }

            // 3. Keep the first participant as host
            string hostName = names[0];

            // 4. Sort the rest alphabetically
            List<string> sortedOthers = names
                .Skip(1)
                .OrderBy(n => n, StringComparer.OrdinalIgnoreCase)
                .ToList();

            // 5. Combine: host + sorted rest
            names = new List<string> { hostName };
            names.AddRange(sortedOthers);

            Random rnd = new Random();





            for (DateTime loopDate = startDate; loopDate <= endDate; loopDate = loopDate.AddDays(1))
            {
                FileInfo templateFileInfo = new FileInfo(selectedTemplateFile);
                using (ExcelPackage excelPackage = new ExcelPackage(templateFileInfo))
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0]; // Use first sheet
                    int startRow = 10;

                    // Write headers
                    worksheet.Cells[9, 1].Value = "Name (Original Name)";
                    worksheet.Cells[9, 2].Value = "User Email";
                    worksheet.Cells[9, 3].Value = "Join Time";
                    worksheet.Cells[9, 4].Value = "Leave Time";
                    worksheet.Cells[9, 5].Value = "Duration (Minutes)";
                    worksheet.Cells[9, 6].Value = "Guest";

                    int row = startRow;

                    // 1. First Participant (kdvm.argo@gmail.com)
                    string firstName = names[0];
                    worksheet.Cells[row, 1].Value = firstName;
                    worksheet.Cells[row, 2].Value = "kdvm.argo@gmail.com";
                    DateTime joinTime = loopDate
                        .AddHours((int)numericFirstHour.Value)
                        .AddMinutes(rnd.Next((int)numericFirstMinute.Value, (int)numericFirstMinute.Value + 16))
                        .AddSeconds(rnd.Next(0, 59));
                    DateTime leaveTime = loopDate
                        .AddHours((int)numericLastHour.Value)
                        .AddMinutes(rnd.Next((int)numericLastMinute.Value, (int)numericLastMinute.Value + 16))
                        .AddSeconds(rnd.Next(0, 59));
                    worksheet.Cells[row, 3].Value = joinTime;
                    worksheet.Cells[row, 4].Value = leaveTime;
                    worksheet.Cells[row, 3].Style.Numberformat.Format = "yyyy-MM-dd HH:mm:ss";
                    worksheet.Cells[row, 4].Style.Numberformat.Format = "yyyy-MM-dd HH:mm:ss";
                    worksheet.Cells[row, 5].Value = (int)Math.Round((leaveTime - joinTime).TotalMinutes);
                    worksheet.Cells[row, 6].Value = "No";
                    row++;


                    //  2. Optional 31user (always second if enabled)
                    if (checkBoxInclude31User.Checked)
                    {
                        worksheet.Cells[row, 1].Value = "31user";
                        //worksheet.Cells[row, 2].Value = "31user@example.com";

                        DateTime join31 = loopDate
                            .AddHours((int)numeric31JoinHour.Value)
                            .AddMinutes((int)numeric31JoinMinute.Value);
                        DateTime leave31 = loopDate
                            .AddHours((int)numeric31LeaveHour.Value)
                            .AddMinutes((int)numeric31LeaveMinute.Value);

                        worksheet.Cells[row, 3].Value = join31;
                        worksheet.Cells[row, 4].Value = leave31;
                        worksheet.Cells[row, 3].Style.Numberformat.Format = "yyyy-MM-dd HH:mm:ss";
                        worksheet.Cells[row, 4].Style.Numberformat.Format = "yyyy-MM-dd HH:mm:ss";
                        worksheet.Cells[row, 5].Value = (int)Math.Round((leave31 - join31).TotalMinutes);
                        worksheet.Cells[row, 6].Value = "Yes";
                        row++;
                    }

                    //  3. Remaining participants (start from names[1])
                    for (int i = 1; i < names.Count; i++)
                    {
                        worksheet.Cells[row, 1].Value = names[i];
                        worksheet.Cells[row, 2].Value = "";

                        DateTime join = loopDate
                            .AddHours((int)numericFirstHour.Value)
                            .AddMinutes(rnd.Next((int)numericFirstMinute.Value, (int)numericFirstMinute.Value + 16))
                            .AddSeconds(rnd.Next(0, 59));
                        DateTime leave = loopDate
                            .AddHours((int)numericLastHour.Value)
                            .AddMinutes(rnd.Next((int)numericLastMinute.Value, (int)numericLastMinute.Value + 16))
                            .AddSeconds(rnd.Next(0, 59));

                        worksheet.Cells[row, 3].Value = join;
                        worksheet.Cells[row, 4].Value = leave;
                        worksheet.Cells[row, 3].Style.Numberformat.Format = "yyyy-MM-dd HH:mm:ss";
                        worksheet.Cells[row, 4].Style.Numberformat.Format = "yyyy-MM-dd HH:mm:ss";
                        worksheet.Cells[row, 5].Value = (int)Math.Round((leave - join).TotalMinutes);
                        worksheet.Cells[row, 6].Value = "Yes";

                        row++;
                    }

                    // Insert date at A40
                    worksheet.Cells["A40"].Value = $"глеяолгмиа {loopDate:dd-MM-yyyy}";

                    string fileDate = loopDate.ToString("MM-dd");
                    string exportPath = Path.Combine(selectedFolder, $"{fileDate}.xlsx");
                    excelPackage.SaveAs(new FileInfo(exportPath));
                }
            }

            // MessageBox.Show("Reports created successfully!");
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            numeric31JoinHour.Enabled = false;
            numeric31JoinMinute.Enabled = false;
            numeric31LeaveHour.Enabled = false;
            numeric31LeaveMinute.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                openFileDialog.Title = "Select Excel Template";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedTemplateFile = openFileDialog.FileName;
                    MessageBox.Show("Template selected: " + selectedTemplateFile);
                }
            }
        }
        private void checkBoxInclude31User_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = checkBoxInclude31User.Checked;
            numeric31JoinHour.Enabled = enabled;
            numeric31JoinMinute.Enabled = enabled;
            numeric31LeaveHour.Enabled = enabled;
            numeric31LeaveMinute.Enabled = enabled;
        }

        
    }
}