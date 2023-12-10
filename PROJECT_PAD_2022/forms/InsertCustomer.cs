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
    public partial class InsertCustomer : Form
    {
        SalesController controller;
        public InsertCustomer(SalesController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (storeRbt.Checked)
            {
                controller.insertCustomer(0,int.Parse(textBox1.Text), int.Parse(teritoryCmb.SelectedValue.ToString()),accountIdTb.Text);
            }else if (personRbt.Checked)
            {
                controller.insertCustomer(1, int.Parse(textBox1.Text),int.Parse(teritoryCmb.SelectedValue.ToString()), accountIdTb.Text);
            }
        }
    }
}
