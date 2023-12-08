using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PAD_2022.controllers
{
    public class HumanResourcesController
    {
        protected AdventureWorks2022Entities database;
        Employee employee;
        public HumanResourcesController(AdventureWorks2022Entities database, Employee employee)
        {
            this.database = database;
            this.employee = employee;
        }
        public List<object> LoadDgv()
        {
            var employeeList = (from Employee e in database.Employees
                                select new
                                {
                                    EmployeeID = e.BusinessEntityID,
                                    Jeniskelamin = e.Gender == "M" ? "Laki-laki" : "Wanita",
                                    tanggallahir = e.BirthDate
                                }).ToList();
            return employeeList.Cast<object>().ToList();
        }

    }
}
