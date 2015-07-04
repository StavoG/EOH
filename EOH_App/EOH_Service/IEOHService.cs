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
    [ServiceContract]
    public interface IEOHService
    {

        [OperationContract]
        Person GetPerson();

        [OperationContract]
        List<Employee> GetEmployee();

        [OperationContract]
        void AddEmployee(Employee employee);

        [OperationContract]
        void UpdateEmployee(Employee employee);

        [OperationContract]
        void DeleteEmployee(int employeeID);
    }
}
