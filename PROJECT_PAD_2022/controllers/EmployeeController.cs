using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PAD_2022.controllers
{
    public class EmployeeController
    {
        protected AdventureWorks2022Entities database;
        protected Employee employee;
        public EmployeeController()
        {
            database = new AdventureWorks2022Entities();
        }
        public EmployeeController(AdventureWorks2022Entities database)
        {
            this.database = database;
        }
        public Employee getCurrentLoggedInEmployee()
        {
            return employee;
        }
        public bool loginEmployee(string email)
        {
            if(database.EmailAddresses.Any(em => em.EmailAddress1 == email))
            {
                employee = database.EmailAddresses.Where(em => em.EmailAddress1 == email).FirstOrDefault().Person.Employee;
                return true;
            }
            return false;
        }
        public string getDepartmentName()
        {
            if(employee.EmployeeDepartmentHistories.Any(dh => dh.Employee == employee && dh.EndDate == null))
            {
                return employee.EmployeeDepartmentHistories
                               .Where(dh => dh.Employee == employee && dh.EndDate == null)
                               .FirstOrDefault().Department.Name;
            }
            return "";
        }
        public HumanResourcesController getHumanResourcesControllerWithDB()
        {
            return new HumanResourcesController(database, employee);
        }
        public SalesController GetSalesControllerWithDB()
        {
            return new SalesController(database, employee);
        }
        public PurchasingController getPurchasingControllerWithDB()
        {
            return new PurchasingController(database, employee);
        }
    }
}
