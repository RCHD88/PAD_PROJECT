using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PAD_2022.controllers
{
    public class SalesController
    {
        protected AdventureWorks2022Entities database;
        Employee employee;
        public SalesController(AdventureWorks2022Entities database, Employee employee)
        {
            this.database = database;
            this.employee = employee;
        }
    }
}
