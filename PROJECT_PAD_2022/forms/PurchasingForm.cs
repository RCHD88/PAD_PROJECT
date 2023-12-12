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
    public partial class PurchasingForm : Form
    {
        PurchasingController controller;
        public PurchasingForm(PurchasingController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
    }
}
