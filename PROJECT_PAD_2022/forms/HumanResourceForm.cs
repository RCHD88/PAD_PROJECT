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
            
            dataGridView1.DataSource = controller.LoadDgv();
            dataGridView1.Columns[1].HeaderText = "Jenis kelamin";
        }

        
        
    }
}
