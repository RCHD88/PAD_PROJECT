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
            ResetDataTabPage();
        }
        public void ResetDataTabPage()
        {
            dataGridView.DataSource = controller.getData();
            labelTotal.Text = controller.getData().Count.ToString();
            addActionButton();
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

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
