using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EOH_DataAccess
{
    public class DataAccess
    {
        EOH_DBEntities1 entities = null;
        public DataAccess()
        {
            entities = new EOH_DBEntities1();
            entities.ContextOptions.LazyLoadingEnabled = false;
        }

        public Person GetPerson()
        {
            //var person = from persons in entities.People select persons;
            //return (Person)person;
            return entities.People.SingleOrDefault();
        }

        public List<Employee> GetEmployees()
        {
            //var employee = from employees in entities.Employees select employees;
            //return (List<Employee>)employee.ToList();
            return entities.Employees.ToList();
        }

        public void SaveEmployee(Employee employee)
        {
            entities.Employees.AddObject(employee);
            entities.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            Employee emp = entities.Employees.FirstOrDefault(e => e.EmployeeID == employee.EmployeeID);
            emp.EmployedDate = employee.EmployedDate;
            emp.EmployeeNum = employee.EmployeeNum;
            emp.TerminatedDate = employee.TerminatedDate;
            entities.SaveChanges();
        }

        public void DeleteEmployee(int employeeID)
        {
            Employee emp = entities.Employees.FirstOrDefault(e => e.EmployeeID == employeeID);
            entities.Employees.DeleteObject(emp);
            entities.SaveChanges();
        }
    }
}
