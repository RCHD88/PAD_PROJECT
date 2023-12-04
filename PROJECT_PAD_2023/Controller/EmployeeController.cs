using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PAD_2023.Controller
{
    internal class EmployeeController
    {
        AdventureWorks2022Entities database;
        public EmployeeController()
        {
            database = new AdventureWorks2022Entities();
        }
        public Employee loginAuthentication(string email)
        {
            try
            {
                Employee employee = database.EmailAddresses.Where(em => em.EmailAddress1.Equals(email)).FirstOrDefault().Person.Employee;
                return employee;
            }
            catch (NullReferenceException ex)
            {
                return null;
            }
        }
    }
}
