using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PAD_2023.Controller
{
    public class EmployeeController
    {
        AdventureWorks2022Entities database;
        public EmployeeController()
        {
            database = new AdventureWorks2022Entities();
        }
        public Employee loginAuthentication(string email)
        {
            bool email_available = database.EmailAddresses.Any(em => em.EmailAddress1.Equals(email));
            if (email_available)
            {
                Employee employee = database.EmailAddresses.Where(em => em.EmailAddress1.Equals(email)).FirstOrDefault().Person.Employee;
                return employee;
            }
            else
            {
                return null;
            }
        }
    }
}
