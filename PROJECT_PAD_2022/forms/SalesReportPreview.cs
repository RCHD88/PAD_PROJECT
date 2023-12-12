using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using PROJECT_PAD_2022.reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PAD_2022.forms
{
    [ExcludeFromCodeCoverage]
    public partial class SalesReportPreview : Form
    {
        SalesTransactionReport report;
        public SalesReportPreview(int salesOrderId)
        {
            InitializeComponent();
            report = new SalesTransactionReport();
            report.SetParameterValue("orderID", salesOrderId);
        }

        private void SalesReportPreview_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = report;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            // Get the report document from the CrystalReportViewer
            ReportDocument reportDocument = (ReportDocument)crystalReportViewer1.ReportSource;

            // Check if a report is loaded
            if (reportDocument != null)
            {
                // Set the export options
                ExportOptions exportOptions;
                DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
                exportOptions = reportDocument.ExportOptions;

                exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

                // Get the current project location
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                // Set propertinya sesuai kebutuhan
                saveFileDialog.Title = "Simpan Report PDF";
                saveFileDialog.Filter = "File PDF (*.pdf)|*.pdf";
                saveFileDialog.DefaultExt = "pdf";

                // Tampilkan dialog dan dapatkan hasilnya
                DialogResult result = saveFileDialog.ShowDialog();

                // Cek apakah pengguna menekan tombol OK
                if (result == DialogResult.OK)
                {
                    // Dapatkan path file yang dipilih
                    string selectedFilePath = saveFileDialog.FileName;

                    // Lakukan sesuatu dengan path file yang dipilih
                    diskFileDestinationOptions.DiskFileName = selectedFilePath;

                    exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                    exportOptions.DestinationOptions = diskFileDestinationOptions;
                }
                try
                {
                    // Export the report
                    reportDocument.Export();
                    MessageBox.Show("Report exported to PDF successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No report loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
