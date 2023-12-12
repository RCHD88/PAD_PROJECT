using PROJECT_PAD_2022.controllers;
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
    public partial class SalesForm : Form
    {
        protected SalesController controller;
        public SalesForm(SalesController controller)
        {
            InitializeComponent();
            this.controller = controller;   
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            resetTransactionTabData();
            nameLabel.Text = controller.getEmployeeName();
            saleslastyearLabel.Text = controller.getSalesLastYear().ToString();
            salesytdLabel.Text = controller.getSalesYTD().ToString();   
        }

        #region TRANSACTION TAB
        public void resetTransactionTabData()
        {
            transactionDataGridView.DataSource = controller.getTransaction();
            //add button column change status
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Print Transaction";
            buttonColumn.Name = "transactionButton";
            buttonColumn.DefaultCellStyle.NullValue = "Print Preview";
            transactionDataGridView.Columns.Add(buttonColumn);
        }
        #endregion


        private void transactionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                int salesOrderID = Convert.ToInt32(transactionDataGridView.Rows[e.RowIndex].Cells[0].Value);
                SalesReportPreview previewForm = new SalesReportPreview(salesOrderID);
                previewForm.ShowDialog();
            }
        }
    }
}
