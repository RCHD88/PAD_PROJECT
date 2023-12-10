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
    public partial class SalesForm : Form
    {
        protected SalesController controller;
        public SalesForm(SalesController controller)
        {
            InitializeComponent();
            this.controller = controller;   
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=controller.getCustomerList();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
