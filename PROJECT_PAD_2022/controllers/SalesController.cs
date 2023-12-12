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
        protected Employee employee;
        public SalesController(AdventureWorks2022Entities database, Employee employee)
        {
            this.database = database;
            this.employee = employee;
        }
        public List<Object> getTransaction()
        {
            var transaction = (from SalesOrderHeader htrans in database.SalesOrderHeaders
                               join Customer customer in database.Customers on htrans.CustomerID equals customer.CustomerID
                               join Person person in database.People on customer.PersonID equals person.BusinessEntityID
                                    into personGroup from person in personGroup.DefaultIfEmpty()
                               join Store store in database.Stores on customer.StoreID equals store.BusinessEntityID
                                    into storeGroup from store in storeGroup.DefaultIfEmpty()
                               join ship_method in database.ShipMethods on htrans.ShipMethodID equals ship_method.ShipMethodID
                               where htrans.SalesPersonID == employee.BusinessEntityID
                               select new
                               {
                                   SalesOrderID = htrans.SalesOrderID,
                                   SalesOrderNumber = htrans.SalesOrderNumber,
                                   CustomerName = person != null ? (person.FirstName + " " + person.LastName + " (PERSON)") : store.Name + " (STORE)",
                                   OrderDate = htrans.OrderDate,
                                   Status = htrans.Status == 1 ? "In Process" : htrans.Status == 2 ? "Approved" : htrans.Status == 3 ? "Backordered" : htrans.Status == 4 ? "Rejected" : htrans.Status == 5 ? "Shipped" : "Cancelled",
                                   DueDate = htrans.DueDate,
                                   ShipMethod = ship_method.Name,
                                   SubTotal = htrans.SubTotal
                               });
            return transaction.ToList().Cast<object>().ToList();
        }
        public string getEmployeeName()
        {
            return employee.Person.FirstName + " " + employee.Person.LastName;
        }
        public decimal getSalesYTD()
        {
            return employee.SalesPerson.SalesYTD;
        }
        public decimal getSalesLastYear()
        {
            return employee.SalesPerson.SalesLastYear;
        }
    }
}
