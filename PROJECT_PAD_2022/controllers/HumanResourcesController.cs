using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Object> getData()
        {
            var data = (from Employee e in database.Employees
                       select new
                       {
                           Business_ID = e.BusinessEntityID,
                           Name = e.Person.FirstName + " " + e.Person.LastName,
                           Job_Title = e.JobTitle,
                           Hire_Date = e.HireDate,
                           Salaried = e.SalariedFlag ? "salaried" : "hourly",
                           Vacation_Hours = e.VacationHours + " Hours",
                           Sick_Hours = e.SickLeaveHours + " Hours",
                           Gender = e.Gender == "M" ? "Laki-laki" : "Wanita",
                           Marital_Status = e.MaritalStatus == "M" ? "Maried" : "Single"
                       }).ToList();
            List<Object> dataList = data.Cast<Object>().ToList();
            return dataList;
        }
    }
}
