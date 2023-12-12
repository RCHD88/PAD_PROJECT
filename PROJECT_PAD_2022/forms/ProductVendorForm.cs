using PROJECT_PAD_2022.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PAD_2022.forms
{
    public partial class ProductVendorForm : Form
    {
        PurchasingController controller;
        int VendorID;
        public ProductVendorForm(int id,PurchasingController controller)
        {
            InitializeComponent();
            dataGridView1.DataSource = this;
            cartDGV.Rows.Clear();
            this.controller = controller;
            if (controller.LoadAvailableProduct(id).Any())
            {
                dataGridView1.DataSource = controller.LoadAvailableProduct(id);
            }
            this.VendorID = id;
        }

        private void ProductVendorForm_Load(object sender, EventArgs e)
        {
            
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Buy";
            buttonColumn.Name = "BuyBtn";
            buttonColumn.DefaultCellStyle.NullValue = "Buy";
            dataGridView1.Columns.Add(buttonColumn);

            var shipment = controller.getShipmentMethod();
            comboBox1.DataSource = shipment;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ShipMethodID";
        }

        private void cartDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.ColumnIndex.ToString());
            if(e.ColumnIndex ==0)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.ColumnIndex.ToString());
            if(e.ColumnIndex == 7)
            {
                string namabarang = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                decimal price = Convert.ToDecimal(cellValue);
                bool tidakada = true;
                for (int i = 0; i < cartDGV.Rows.Count; i++)
                {
                    if (cartDGV.Rows[i].Cells[0].Value.ToString() == namabarang)
                    {
                        int currentQuantity = Convert.ToInt32(cartDGV.Rows[i].Cells[2].Value);
                        cartDGV.Rows[i].Cells[2].Value = currentQuantity + 1;

                        decimal pricePerItem = Convert.ToDecimal(cartDGV.Rows[i].Cells[1].Value);
                        decimal updatedQuantity = Convert.ToInt32(cartDGV.Rows[i].Cells[2].Value);
                        cartDGV.Rows[i].Cells[3].Value = pricePerItem * updatedQuantity;
                        tidakada = false;
                        break;
                    }
                }
                if (tidakada)
                {
                    cartDGV.Rows.Add(namabarang,price,1,price);
                }

                TotalHarga.Text = getTotalHarga().ToString(); 
                TotalBarang.Text = getTotalBarang().ToString();
                TotalPajak.Text = getTotalTax().ToString();
                ShipmentFeeLabel.Text = getShipmentFee().ToString();
                Total.Text = getOverAllCost().ToString();
            }
        }
        public decimal getTotalHarga()
        {
            decimal totalHarga = 0;
            for (int i = 0; i < cartDGV.Rows.Count; i++)
            {
                totalHarga += Convert.ToDecimal(cartDGV.Rows[i].Cells[3].Value);
            }
            return totalHarga;
        }
        
        public int getTotalBarang()
        {
            int totalBarang = 0;
            for (int i = 0; i < cartDGV.Rows.Count; i++)
            {
                totalBarang += Convert.ToInt32(cartDGV.Rows[i].Cells[2].Value);
            }
            return totalBarang;
        }

        public decimal getTotalTax()
        {
            decimal tax = Convert.ToDecimal(getTotalHarga());
            tax = tax / 12.5m;
            return tax;
        }

        public decimal getShipmentFee()
        {
            int totalBarang = 0;
            for (int i = 0; i < cartDGV.Rows.Count; i++)
            {
                totalBarang += Convert.ToInt32(cartDGV.Rows[i].Cells[2].Value);
            }
            int ShipmentID = Convert.ToInt32(comboBox1.SelectedValue);
            decimal fee = controller.getShipmentFee(ShipmentID,totalBarang);
            return fee;
        }
        public decimal getOverAllCost()
        {
            decimal totalHarga = 0;
            for (int i = 0; i < cartDGV.Rows.Count; i++)
            {
                totalHarga += Convert.ToDecimal(cartDGV.Rows[i].Cells[3].Value);
            }
            int totalBarang = 0;
            for (int i = 0; i < cartDGV.Rows.Count; i++)
            {
                totalBarang += Convert.ToInt32(cartDGV.Rows[i].Cells[2].Value);
            }
            int ShipmentID = Convert.ToInt32(comboBox1.SelectedValue);
            decimal fee = controller.getShipmentFee(ShipmentID, totalBarang);

            decimal tax = Convert.ToDecimal(getTotalHarga());
            tax = tax / 12.5m;

            decimal total = totalHarga + fee + tax;

            return total;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int employeeID = controller.getEmployeeID();
            int ShipMethodID = Convert.ToInt32(comboBox1.SelectedValue);
            DateTime OrderDate = dateTimePicker1.Value;
            DateTime ShipDate = dateTimePicker2.Value;
            decimal SubTotal = getTotalHarga();
            decimal TaxAmt = getTotalTax();
            decimal Freight = getShipmentFee();
            decimal TotalDue = getOverAllCost();

            controller.CheckOut(employeeID,this.VendorID,ShipMethodID,OrderDate,ShipDate,SubTotal,TaxAmt,Freight,TotalDue);
        }
    }
}
