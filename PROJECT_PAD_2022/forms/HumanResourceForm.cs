using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using PROJECT_PAD_2022.controllers;
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
    public partial class HumanResourceForm : Form
    {
        HumanResourcesController controller;
        public HumanResourceForm(HumanResourcesController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void HumanResourceForm_Load(object sender, EventArgs e)
        {
            ResetActiveDataTabPage();
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                ResetActiveDataTabPage();
            }
            else
            {
                ResetInactiveDataTabPage();
            }
        }

        #region ACTIVE DATA TAB
        public void ResetActiveDataTabPage()
        {
            dataGridView.Columns.Clear();
            dataGridView.DataSource = controller.getActiveData();
            labelTotal.Text = controller.getActiveData().Count.ToString();
            departmentComboBox.DataSource = controller.getDepartments();
            departmentComboBox.DisplayMember = "Name";
            departmentComboBox.ValueMember = "Name";
            departmentComboBox.SelectedIndex = -1;
            if(labelTotal.Text != "0")
            {
                addActionButton();
            }
        }
        public void addActionButton()
        {
            //add button column change status
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Change Status";
            buttonColumn.Name = "DeactiveBtn";
            buttonColumn.DefaultCellStyle.NullValue = "Deactive";
            dataGridView.Columns.Add(buttonColumn);
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9 && e.RowIndex != -1)
            {
                int business_entity_id = (int)dataGridView.Rows[e.RowIndex].Cells[0].Value;
                controller.deactivateEmployee(business_entity_id);
                ResetActiveDataTabPage();
            }
        }
        private void generateButton_Click(object sender, EventArgs e)
        {
            string department = departmentComboBox.Text;
            string sortedby = sortComboBox.Text;
            string type = sorttypeComboBox.Text;

            List<Object> datasource = controller.getActiveData(department);
            if (sortComboBox.Text == "HireDate")
            {
                datasource = controller.getHireDateSortedData(department, type);
            }
            else if (sortComboBox.Text == "VacationHours")
            {
                datasource = controller.getVacationHoursSortedData(department, type);
            }
            else if (sortComboBox.Text == "SickHours")
            {
                datasource = controller.getSickLeaveHoursSortedData(department, type);
            }

            dataGridView.DataSource = datasource;
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = controller.getActiveData();
        }
        #endregion
        #region INACTIVE DATA TAB
        public void ResetInactiveDataTabPage()
        {
            inactiveDataGridView.DataSource = controller.getInactiveData();
            inactiveTotalEmployee.Text = controller.getInactiveData().Count.ToString();
        }


        #endregion

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            HumanResourceReport report = new HumanResourceReport();
            crystalReportViewer.ReportSource = report;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            // Get the report document from the CrystalReportViewer
            ReportDocument reportDocument = (ReportDocument)crystalReportViewer.ReportSource;

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
