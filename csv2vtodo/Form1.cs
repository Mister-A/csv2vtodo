using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace csv2vtodo
{
    public partial class MainForm : Form
    {
        private List<WorkastCSVFile> InputRecords;
        private List<WorkastCSVFile> ListsOnly;
        private List<WorkastCSVFile> ListsWithSubtasks;
        private string Results;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Select input csv from file browser dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBrowseCsv_Click(object sender, EventArgs e)
        {
            if (BrowseCSV.ShowDialog() == DialogResult.OK)
            {
                TxtCSVFile.Text = BrowseCSV.FileName;
            }
        }

        /// <summary>
        /// Select folder to export results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExportTo_Click(object sender, EventArgs e)
        {
            if (BrowseExport.ShowDialog() == DialogResult.OK)
            {
                TxtExportPath.Text = BrowseExport.SelectedPath;
            }
        }

        /// <summary>
        /// Convert using T4 template
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if (TxtExportPath.Text != "" && TxtCSVFile.Text != "")
            {
                try
                {
                    using (var reader = new StreamReader(TxtCSVFile.Text))
                    using (var csv = new CsvReader(reader, CultureInfo.GetCultureInfo("en-GB")))
                    {
                        csv.Context.TypeConverterOptionsCache.GetOptions<DateTime?>().NullValues.AddRange(new[] { "NULL", "0" });
                        InputRecords = csv.GetRecords<WorkastCSVFile>().ToList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.InnerException.Message.ToString() + "\r\n\r\n" + ex.Message.ToString());
                    return;
                }

                ListsOnly = InputRecords.GroupBy(x => x.List, (key, g) => g.OrderBy(z => z.List).First()).ToList();
                ListsWithSubtasks = InputRecords.Where(a => a.Subtask != "").GroupBy(x => x.Task, (key, g) => g.OrderBy(z => z.List).First()).ToList();
                VTODO converter = new VTODO
                {
                    Session = new Dictionary<string, object>()
                };
                converter.Session["csv"] = InputRecords;
                converter.Session["lists"] = ListsOnly;
                converter.Session["listssub"] = ListsWithSubtasks;
                converter.Initialize();
                try
                {
                    Results = converter.TransformText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.InnerException.Message.ToString() + "\r\n\r\n" + ex.Message.ToString());
                    return;
                }
                var exportFilename = Path.GetFileNameWithoutExtension(TxtCSVFile.Text);
                var fullPath = TxtExportPath.Text + "\\" + exportFilename + ".ics";
                File.WriteAllText(fullPath, Results);
            }
            else
            {
                MessageBox.Show("Your input file and/or output path don't look right, please check!");
            }
        }
    }
}