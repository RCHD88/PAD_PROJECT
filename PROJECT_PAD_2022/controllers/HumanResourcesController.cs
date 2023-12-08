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
                           BusinessID = e.BusinessEntityID,
                           NationalID = e.NationalIDNumber,
                           JobTitle = e.JobTitle,
                           HireDate = e.HireDate,
                           Gender = e.Gender == "M" ? "Laki-laki" : "Wanita"
                       }).ToList();
            List<Object> dataList = data.Cast<Object>().ToList();
            return dataList;
        }
    }
}
