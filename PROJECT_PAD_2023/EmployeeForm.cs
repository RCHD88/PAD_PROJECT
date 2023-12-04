using PROJECT_PAD_2023.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PAD_2023
{
    public partial class EmployeeForm : Form
    {
        Employee employee;
        EmployeeController employeeController;
        public EmployeeForm(Employee employee, EmployeeController employeeController)
        {
            InitializeComponent();
            this.employee = employee;
            this.employeeController = employeeController;
        }
    }
}
