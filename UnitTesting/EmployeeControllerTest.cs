using Microsoft.VisualStudio.TestTools.UnitTesting;
using PROJECT_PAD_2022;
using PROJECT_PAD_2022.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTesting
{
    /// <summary>
    /// Summary description for EmployeeControllerTest
    /// </summary>
    [TestClass]
    public class EmployeeControllerTest
    {
        EmployeeController controller;
        public EmployeeControllerTest()
        {
            controller = new EmployeeController();
        }

        [TestMethod]
        public void ConstructorTest()
        {
            AdventureWorks2022Entities database = new AdventureWorks2022Entities();
            EmployeeController new_controller = new EmployeeController();
            EmployeeController new_controller_withdb = new EmployeeController(database);

            Assert.IsNotNull(new_controller);   
            Assert.IsNotNull(new_controller_withdb);    
        }
        [TestMethod]
        public void getCurrentEmployeeTest()
        {
            EmployeeController new_controller = new EmployeeController();
            Assert.IsNotNull(new_controller);

            // ketika belum login
            Employee current_employee = new_controller.getCurrentLoggedInEmployee();
            Assert.IsNull(current_employee);


            // ketika sudah login
            new_controller.loginEmployee("adventure-works\\paula0");
            current_employee = new_controller.getCurrentLoggedInEmployee();
            Assert.IsNotNull(current_employee);
            Assert.AreEqual("adventure-works\\paula0", current_employee.LoginID);
        }
        [TestMethod]
        public void loginEmployeeTest()
        {
            EmployeeController new_controller = new EmployeeController();

            // login salah
            bool success = new_controller.loginEmployee("randomloginidyangdiberikan");
            Assert.IsFalse(success);

            success = new_controller.loginEmployee("adventure-works\\paula0");
            Assert.IsTrue(success);
            success = new_controller.loginEmployee("adventure-works\\grant0");
            Assert.IsTrue(success);

            success = new_controller.loginEmployee("adventure-works\\sheela0");
            Assert.IsTrue(success);
            success = new_controller.loginEmployee("adventure-works\\mikael0");
            Assert.IsTrue(success);

            success = new_controller.loginEmployee("adventure-works\\brian3");
            Assert.IsTrue(success);
            success = new_controller.loginEmployee("adventure-works\\stephen0");
            Assert.IsTrue(success);
        }
        [TestMethod]
        public void logoutEmployeTest()
        {
            controller.loginEmployee("adventure-works\\paula0");
            Assert.IsNotNull(controller.getCurrentLoggedInEmployee());
            controller.logoutEmployee();
            Assert.IsNull(controller.getCurrentLoggedInEmployee());
        }
        [TestMethod]
        public void getDepartmentName()
        {
            controller.loginEmployee("adventure-works\\paula0");
            Assert.AreEqual("Human Resources", controller.getDepartmentName());

            controller.loginEmployee("adventure-works\\sheela0");
            Assert.AreEqual("Purchasing", controller.getDepartmentName());

            controller.loginEmployee("adventure-works\\brian3");
            Assert.AreEqual("Sales", controller.getDepartmentName());
        }
        [TestMethod]
        public void isSalesPerson()
        {
            controller.loginEmployee("adventure-works\\paula0");
            Assert.IsNotNull(controller.getCurrentLoggedInEmployee());
            Assert.IsFalse(controller.isSalesPerson());

            controller.loginEmployee("adventure-works\\stephen0");
            Assert.IsTrue(controller.isSalesPerson());
        }
    }
}
