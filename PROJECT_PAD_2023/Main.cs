using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using PROJECT_PAD_2023.Controller;

namespace PROJECT_PAD_2023
{
    public partial class Main : Form
    {
        EmployeeController employeeController;
        Employee employee;
        public Main()
        {
            InitializeComponent();
            employeeController = new EmployeeController(); 
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            employee =  employeeController.loginAuthentication(email);
            if(employee != null )
            {
                MessageBox.Show("Berhasil login");
            }
            else
            {
                MessageBox.Show("Employee tersebut tidak terdaftar");
            }
        }
    }
}
