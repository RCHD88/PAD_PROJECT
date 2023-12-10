using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public List<Object> getActiveData(string department = "")
        {
            var data = (from Employee e in database.Employees
                       where e.CurrentFlag.Equals(true) && e.EmployeeDepartmentHistories.Where(emdep => emdep.EndDate == null).FirstOrDefault().Department.Name.Contains(department)
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
        public List<Object> getInactiveData()
        {
            var data = (from Employee e in database.Employees
                        where e.CurrentFlag.Equals(false)
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
        public void deactivateEmployee(int business_entity_id)
        {
            Employee employee = database.Employees.Where(em => em.BusinessEntityID == business_entity_id).FirstOrDefault();
            employee.CurrentFlag = false;
            database.SaveChanges();
        }
        public Employee getEmployeeByBusinessEntityId(int business_entity_id)
        {
            if (database.Employees.Any(em => em.BusinessEntityID == business_entity_id))
            {
                return database.Employees.Where(em => em.BusinessEntityID == business_entity_id).FirstOrDefault() as Employee;
            }
            return null;
        }
        public List<Object> getDepartments()
        {
            var data = from Department department in database.Departments
                       select new
                       {
                           department.DepartmentID,
                           department.Name
                       };
            return data.ToList().Cast<Object>().ToList();
        }

        // get sorted or selected item
        public List<Object> getHireDateSortedData (string department = "", string type = "Ascending")
        {
            if (type == "Ascending")
            {
                var data = (from Employee e in database.Employees
                            where e.CurrentFlag.Equals(true) && e.EmployeeDepartmentHistories.Where(emdep => emdep.EndDate == null).FirstOrDefault().Department.Name.Contains(department)
                            orderby e.HireDate ascending
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
            else
            {
                var data = (from Employee e in database.Employees
                            where e.CurrentFlag.Equals(true) && e.EmployeeDepartmentHistories.Where(emdep => emdep.EndDate == null).FirstOrDefault().Department.Name.Contains(department)
                            orderby e.HireDate descending
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
        public List<Object> getVacationHoursSortedData(string department = "", string type = "Ascending")
        {
            if (type == "Ascending")
            {
                var data = (from Employee e in database.Employees
                            where e.CurrentFlag.Equals(true) && e.EmployeeDepartmentHistories.Where(emdep => emdep.EndDate == null).FirstOrDefault().Department.Name.Contains(department)
                            orderby e.VacationHours ascending
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
            else
            {
                var data = (from Employee e in database.Employees
                            where e.CurrentFlag.Equals(true) && e.EmployeeDepartmentHistories.Where(emdep => emdep.EndDate == null).FirstOrDefault().Department.Name.Contains(department)
                            orderby e.VacationHours descending
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
        public List<Object> getSickLeaveHoursSortedData(string department = "", string type = "Ascending")
        {
            if (type == "Ascending")
            {
                var data = (from Employee e in database.Employees
                            where e.CurrentFlag.Equals(true) && e.EmployeeDepartmentHistories.Where(emdep => emdep.EndDate == null).FirstOrDefault().Department.Name.Contains(department)
                            orderby e.SickLeaveHours ascending
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
            else
            {
                var data = (from Employee e in database.Employees
                            where e.CurrentFlag.Equals(true) && e.EmployeeDepartmentHistories.Where(emdep => emdep.EndDate == null).FirstOrDefault().Department.Name.Contains(department)
                            orderby e.SickLeaveHours descending
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
}
