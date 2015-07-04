using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using EOH_DataAccess;

namespace EOH_Service
{
    public class EOHService : IEOHService
    {
        public Person GetPerson()
        {
            return new DataAccess().GetPerson();
        }

        public List<Employee> GetEmployee()
        {
            return new DataAccess().GetEmployees();
        }

        public void AddEmployee(Employee employee)
        {
            new DataAccess().SaveEmployee(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            new DataAccess().UpdateEmployee(employee);
        }

        public void DeleteEmployee(int employeeID)
        {
            new DataAccess().DeleteEmployee(employeeID);
        }
    }
}
