using Microsoft.VisualStudio.TestTools.UnitTesting;
using PROJECT_PAD_2022.controllers;
using PROJECT_PAD_2022;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data.OleDb;

namespace UnitTesting
{
    /// <summary>
    /// Summary description for HumanResourcesTest
    /// </summary>
    [TestClass]
    public class HumanResourcesTest
    {
        EmployeeController employeeController;
        HumanResourcesController controller;
        AdventureWorks2022Entities database;
        public HumanResourcesTest()
        {
            employeeController = new EmployeeController();
            controller = employeeController.getHumanResourcesControllerWithDB();
            database = new AdventureWorks2022Entities();
        }

        [TestMethod]
        public void constructorTest()
        {
            AdventureWorks2022Entities database = new AdventureWorks2022Entities();
            HumanResourcesController new_controller = new HumanResourcesController(database, database.Employees.Where(em => em.LoginID == "adventure-works\\stephen0").FirstOrDefault());
            Assert.IsNotNull(new_controller);

            HumanResourcesController new_hr_from_emp_controller = employeeController.getHumanResourcesControllerWithDB();
            Assert.IsNotNull(new_hr_from_emp_controller);
        }
        [TestMethod]
        public void getActiveDataTest()
        {
            List<Object> data = controller.getActiveData();
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);

            List<Object> dataActiveByDepartment = controller.getActiveData("Sales");
            Assert.IsNotNull(dataActiveByDepartment);
            Assert.IsTrue(dataActiveByDepartment.Count > 0);

            Assert.IsTrue(data.Count >= dataActiveByDepartment.Count);
        }
        [TestMethod]
        public void getInactiveDataAndActiveFlagTest()
        {
            
            List<Object> data = controller.getInactiveData();
            int actualData = database.Employees.Where(em => em.CurrentFlag == false).Count();
            Assert.AreEqual(data.Count, actualData);

            Employee emp = database.Employees.Where(em => em.BusinessEntityID.Equals(100)).FirstOrDefault();
            bool defaultFlag = emp.CurrentFlag;

            controller.deactivateEmployee(100);
            data = controller.getInactiveData();
            actualData = database.Employees.Where(em => em.CurrentFlag == false).Count();
            Assert.AreEqual(data.Count, actualData);
            
            controller.activateEmployee(100);
        }
        [TestMethod]
        public void getEmployeeByBusinessIDTest()
        {
            Employee temp = database.Employees.Where(em => em.CurrentFlag == true).FirstOrDefault();
            Employee emp = controller.getEmployeeByBusinessEntityId(temp.BusinessEntityID);
            Employee check_false_emp = controller.getEmployeeByBusinessEntityId(temp.BusinessEntityID);
            Assert.AreEqual(temp.LoginID, emp.LoginID);
            Assert.AreNotEqual(temp, check_false_emp);

            Employee check_notfound_emp = controller.getEmployeeByBusinessEntityId(0);
            Assert.IsNull(check_notfound_emp);
        }
        [TestMethod]
        public void getDepartmentsTest()
        {
            List<Object> data_from_controller = controller.getDepartments();
            List<Department> data_from_database = database.Departments.ToList();
            int total_from_controller = data_from_controller.Count;
            int total_from_database = data_from_database.Count;
            Assert.IsNotNull(data_from_controller);
            Assert.AreEqual(total_from_database, total_from_controller);
        }
        [TestMethod]
        public void getSortedAndSelectedData()
        {
            List<Object> hiredateSortAsc = controller.getHireDateSortedData("", "Ascending");
            List<Object> hiredateSortDesc = controller.getHireDateSortedData("", "Descending");
            Assert.IsNotNull(hiredateSortAsc);
            Assert.IsTrue(hiredateSortAsc.Count > 0);
            Assert.AreEqual(hiredateSortAsc.Count , hiredateSortDesc.Count);

            List<Object> vacationSortAsc = controller.getVacationHoursSortedData("Sales", "Ascending");
            List<Object> vacationSortDesc = controller.getVacationHoursSortedData("Sales", "Descending");
            Assert.IsNotNull(vacationSortAsc);
            Assert.IsTrue(vacationSortAsc.Count > 0);
            Assert.AreEqual(vacationSortAsc.Count, vacationSortDesc.Count);

            List<Object> leaveSickSortAsc = controller.getSickLeaveHoursSortedData("Human Resources", "Ascending");
            List<Object> leaveSickSortDesc = controller.getSickLeaveHoursSortedData("Human Resources", "Descending");
            Assert.IsNotNull(leaveSickSortAsc);
            Assert.IsTrue(leaveSickSortDesc.Count > 0);
            Assert.AreEqual(leaveSickSortAsc.Count, leaveSickSortDesc.Count);

            List<Object> hiredateData = controller.getHireDateSortedData();
            List<Object> vacationData = controller.getVacationHoursSortedData();
            List<Object> leaveSickData = controller.getSickLeaveHoursSortedData();

            Assert.IsNotNull(hiredateData);
            Assert.IsNotNull(vacationData);
            Assert.IsNotNull(leaveSickData);
        }
    }
}
