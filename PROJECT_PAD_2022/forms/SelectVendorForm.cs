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
    public partial class SelectVendorForm : Form
    {
        PurchasingController controller;
        public SelectVendorForm(int id,PurchasingController controller)
        {
            InitializeComponent();
            dataGridView1.DataSource = this;
            this.controller = controller;
            if (controller.LoadAvailableVendor(id).Any())
            {
                dataGridView1.DataSource = controller.LoadAvailableVendor(id);
            }
            else
            {
                MessageBox.Show("k");
            }
        }
    }
}
