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
            vendorDGV.DataSource = controller.LoadVendor(true);
            vendorinactive.DataSource = controller.LoadVendor(false);
            
            //add button column change status
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Change Status";
            buttonColumn.Name = "DeactiveBtn";
            buttonColumn.DefaultCellStyle.NullValue = "Deactive";
            vendorDGV.Columns.Add(buttonColumn);

            //button delete dgv active
            DataGridViewButtonColumn buttonColumnDelete = new DataGridViewButtonColumn();
            buttonColumnDelete.HeaderText = "Delete";
            buttonColumnDelete.Name = "DeleteBtn";
            buttonColumnDelete.DefaultCellStyle.NullValue = "Delete";
            vendorDGV.Columns.Add(buttonColumnDelete);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void vendorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void purchaseTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (purchaseTab.SelectedIndex == 0)
            {
                vendorDGV.DataSource = controller.LoadVendor(true);
            }else if(purchaseTab.SelectedIndex == 1)
            {
                vendorinactive.DataSource = controller.LoadVendor(false);
            }
        }

        

        private void vendorDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int changeID = Convert.ToInt32(vendorDGV.Rows[e.RowIndex].Cells[0].Value);
            MessageBox.Show(e.ColumnIndex.ToString());

            if (e.ColumnIndex == 4)
            {
                if (controller.updateData(false, changeID))
                {
                    MessageBox.Show("berhasil");
                }
                else
                {
                    MessageBox.Show("kontol reddy");
                }
            }

            vendorDGV.DataSource = controller.LoadVendor(true);
        }
    }
}
