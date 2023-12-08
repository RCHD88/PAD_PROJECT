using PROJECT_PAD_2022.controllers;
using PROJECT_PAD_2022.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PAD_2022
{
    public partial class LoginForm : Form
    {
        EmployeeController employeeController;
        public LoginForm()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email_value = emailTextBox.Text;
            bool success = employeeController.loginEmployee(email_value);
            if(success)
            {
                string department_name = employeeController.getDepartmentName();
                if(department_name == "Sales")
                {
                    SalesForm form = new SalesForm(employeeController.GetSalesControllerWithDB());
                    form.ShowDialog();
                }
                else if (department_name == "Purchasing")
                {
                    PurchasingForm form = new PurchasingForm(employeeController.getPurchasingControllerWithDB());
                    form.ShowDialog();
                }
                else if(department_name == "Production")
                {
                    ProductionForm form = new ProductionForm(employeeController.getProductionControllerWithDB());
                    form.ShowDialog();
                }
                else if(department_name == "Human Resources")
                {
                    HumanResourceForm form = new HumanResourceForm(employeeController.getHumanResourcesControllerWithDB());
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Aplikasi hanya disediakan untuk employee pada department tertentu !");
                }
            }
            else
            {
                MessageBox.Show("Email employee tidak terdaftar !");
            }
        }

        private void loginButton_DragEnter(object sender, DragEventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.Silver;
        }

        private void loginButton_DragLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.WhiteSmoke;
        }
    }
}
