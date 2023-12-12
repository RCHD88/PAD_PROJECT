using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PROJECT_PAD_2022.controllers;
using PROJECT_PAD_2022;
using System.Linq;

namespace UnitTesting
{
    [TestClass]
    public class GeneralTest
    {
        [TestMethod]
        public void testContructor()
        {
            AdventureWorks2022Entities database = new AdventureWorks2022Entities();
            EmployeeController employeeController = new EmployeeController();
            HumanResourcesController humanResourcesController = new HumanResourcesController(database, database.Employees.FirstOrDefault());
            SalesController salesController = new SalesController(database, database.Employees.FirstOrDefault());
            PurchasingController purchasingController = new PurchasingController(database, database.Employees.FirstOrDefault());
            
            Assert.IsNotNull(employeeController);
            Assert.IsNotNull(humanResourcesController);
            Assert.IsNotNull(salesController);
            Assert.IsNotNull(purchasingController);
        }
        [TestMethod]
        public void testCreateControllerFromEmployee()
        {
            EmployeeController controller = new EmployeeController();
            HumanResourcesController humanResourcesController = controller.getHumanResourcesControllerWithDB();
            SalesController salesController = controller.GetSalesControllerWithDB();
            PurchasingController purchasingController= controller.getPurchasingControllerWithDB();

            Assert.IsNotNull(humanResourcesController);
            Assert.IsNotNull(salesController);
            Assert.IsNotNull(purchasingController);
        }
    }
}
