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
    public partial class ProductionForm : Form
    {
        ProductionController controller;
        public ProductionForm(ProductionController controller)
        {
            InitializeComponent();
            this.controller = controller;
            dataGridView1.DataSource=controller.getProductList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = controller.getSortedByListPrice();
            }else if(comboBox1.SelectedIndex == 1)
            {

            }
        }
    }
}
