using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public List<Object> getCustomerList()
        {
            var customers = (from c in database.Customers
                            join s in database.Stores on c.StoreID equals s.BusinessEntityID
                            join p in database.People on c.CustomerID equals p.BusinessEntityID
                            select new
                            {
                                customerId= c.CustomerID,
                                Name = s != null ? s.Name : p.FirstName+p.LastName,
                                BusinessEntityId = s != null ? s.BusinessEntityID : p.BusinessEntityID,
                            }).ToList();
            return customers.Cast<object>().ToList();
        }
        public void insertCustomer(int mode, int code,int teritoryID, string AccountNumber)
        {
            Customer customer = new Customer();
            if (mode == 1)
            {
                customer.PersonID = code;
                customer.StoreID = null;
                customer.TerritoryID = teritoryID;
                customer.AccountNumber = AccountNumber;
            }
            else
            {
                customer.StoreID = code;
                customer.PersonID = null;
                customer.TerritoryID = teritoryID;
                customer.AccountNumber = AccountNumber;
            }
            database.Customers.Add(customer);
            database.SaveChanges();
        }
        public List<Object> getSalesPersonList()
        {
            var salesPerson = (from sp in database.SalesPersons
                             join t in database.SalesTerritories on sp.TerritoryID equals t.TerritoryID
                             join e in database.Employees on sp.BusinessEntityID equals e.BusinessEntityID
                             join p in database.People on sp.BusinessEntityID equals p.BusinessEntityID
                             select new
                             {
                                Id = sp.BusinessEntityID,
                                Name = p.FirstName+" "+ p.LastName,
                                Teritory =t != null ? t.CountryRegion + t.Name: "-",
                                SalesThisYear = sp.SalesYTD,
                             }).ToList();
            return salesPerson.Cast<object>().ToList();
        }
        public void insertSalesPerson(int salesPersonId, int teritoryID,int salesQuota)
        {
            SalesPerson salesPerson = new SalesPerson();
            salesPerson.TerritoryID= teritoryID;
            salesPerson.SalesQuota= salesQuota;
            salesPerson.BusinessEntityID= salesPersonId;
            salesPerson.Bonus = 0;
            salesPerson.CommissionPct= 0;
            salesPerson.SalesLastYear = 0;
            database.SalesPersons.Add(salesPerson);
            database.SaveChanges();
        }
    }
}
