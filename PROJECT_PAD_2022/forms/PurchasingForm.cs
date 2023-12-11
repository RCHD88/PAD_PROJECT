using PROJECT_PAD_2022.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PAD_2022.forms
{
    public partial class PurchasingForm : Form
    {
        PurchasingController controller;
        public PurchasingForm(PurchasingController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void PurchasingForm_Load(object sender, EventArgs e)
        {
            refreshDgv();
            refreshDgvInactive();
            refreshProductDGV();

        }

        

        private void vendorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void purchaseTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (purchaseTab.SelectedIndex == 0)
            {
                refreshDgv();
            }
            else if(purchaseTab.SelectedIndex == 1)
            {
                refreshDgvInactive();
            }
        }

        

        private void vendorDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int changeID = Convert.ToInt32(vendorDGV.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 4)
            {
                if (controller.updateData(false, changeID))
                {
                    MessageBox.Show("berhasil mengubah status");
                }
                else
                {
                    MessageBox.Show("gagal mengubah status");
                }
                refreshDgv();
            }else if(e.ColumnIndex == 5)
            {
                Vendor selectedvendor = controller.searchVendor(Convert.ToInt32(vendorDGV.Rows[e.RowIndex].Cells[0].Value));
                
            }
            
        }
        public void refreshDgv()
        {
            vendorDGV.Columns.Clear();
            vendorDGV.DataSource = null;
            vendorDGV.DataSource = controller.LoadVendor(true);

            // Add other columns from the data source
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Change Status";
            buttonColumn.Name = "DeactiveBtn";
            buttonColumn.DefaultCellStyle.NullValue = "Deactive";
            vendorDGV.Columns.Add(buttonColumn);

            //select vendor
            DataGridViewButtonColumn select = new DataGridViewButtonColumn();
            select.HeaderText = "Change Status";
            select.Name = "Select";
            select.DefaultCellStyle.NullValue = "Select Vendor";
            vendorDGV.Columns.Add(select);
        }

        //tab page 2
        public void refreshDgvInactive()
        {
            vendorinactive.Columns.Clear();
            vendorinactive.DataSource = null;
            vendorinactive.DataSource = controller.LoadVendor(false);

            // Add other columns from the data source
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Change Status";
            buttonColumn.Name = "ActiveBtn";
            buttonColumn.DefaultCellStyle.NullValue = "Active";
            vendorinactive.Columns.Add(buttonColumn);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            vendorDGV.Columns.Clear();
            vendorDGV.DataSource = null;
            vendorDGV.DataSource = controller.OrderVendorAsc(true, comboBox2.SelectedIndex);

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Change Status";
            buttonColumn.Name = "DeactiveBtn";
            buttonColumn.DefaultCellStyle.NullValue = "Deactive";
            vendorDGV.Columns.Add(buttonColumn);

            DataGridViewButtonColumn select = new DataGridViewButtonColumn();
            select.HeaderText = "Change Status";
            select.Name = "Select";
            select.DefaultCellStyle.NullValue = "Select Vendor";
            vendorDGV.Columns.Add(select);

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            vendorinactive.Columns.Clear();
            vendorinactive.DataSource = null;
            vendorinactive.DataSource = controller.OrderVendorAsc(false, comboBox3.SelectedIndex);

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Change Status";
            buttonColumn.Name = "ActiveBtn";
            buttonColumn.DefaultCellStyle.NullValue = "Active";
            vendorinactive.Columns.Add(buttonColumn);
        }

        private void vendorinactive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int changeID = Convert.ToInt32(vendorinactive.Rows[e.RowIndex].Cells[0].Value);
            

            if (e.ColumnIndex == 4)
            {
                if (controller.updateData(true, changeID))
                {
                    MessageBox.Show("berhasil");
                }
                else
                {
                    MessageBox.Show("gagal");
                }
                refreshDgvInactive();
            }
            
        }

        //product DGV
        private void productDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                if (controller.LoadAvailableVendor(Convert.ToInt32(productDGV.Rows[e.RowIndex].Cells[1].Value)).Any())
                {
                    SelectVendorForm selectVendorForm = new SelectVendorForm(Convert.ToInt32(productDGV.Rows[e.RowIndex].Cells[1].Value), controller);
                    selectVendorForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tidak ada vendor yang menjual barangnya");
                }
                
            }
        }
        
        public void refreshProductDGV()
        {
            productDGV.DataSource = null;
            productDGV.DataSource = controller.loadProductItem();

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Buy";
            buttonColumn.Name = "BuyBtn";
            buttonColumn.DefaultCellStyle.NullValue = "Buy";
            productDGV.Columns.Add(buttonColumn);
            productDGV.Columns[1].Visible = false;
        }


    }
}
