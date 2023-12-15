using PROJECT_PAD_2022.controllers;
using PROJECT_PAD_2022.forms;
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

namespace PROJECT_PAD_2022
{
    [ExcludeFromCodeCoverage]
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
            string loginid = emailTextBox.Text;
            bool success = employeeController.loginEmployee(loginid);
            if(success)
            {
                string department_name = employeeController.getDepartmentName();
                if(department_name == "Sales")
                {
                    if (employeeController.isSalesPerson())
                    {
                        SalesForm form = new SalesForm(employeeController.GetSalesControllerWithDB());
                        this.Hide();
                        form.ShowDialog();
                    }
                }
                else if (department_name == "Purchasing")
                {
                    PurchasingForm form = new PurchasingForm(employeeController.getPurchasingControllerWithDB());
                    this.Hide();
                    form.ShowDialog();
                }
                else if(department_name == "Human Resources")
                {
                    HumanResourceForm form = new HumanResourceForm(employeeController.getHumanResourcesControllerWithDB());
                    this.Hide();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Aplikasi hanya disediakan untuk employee pada department tertentu !");
                }
                emailTextBox.Text = string.Empty;
                this.Show();

                employeeController.logoutEmployee();
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
