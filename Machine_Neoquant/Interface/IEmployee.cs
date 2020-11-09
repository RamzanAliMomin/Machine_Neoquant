using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Machine_Neoquant.Models;
namespace Machine_Neoquant.Interface
{
    public interface IEmployee
    {
        IEnumerable<ModelEmployees> GetAllEmployees();
        int AddEmployee(ModelEmployees employee);
        int UpdateEmployee(ModelEmployees employee);
        ModelEmployees GetEmployeeData(int id);
        int DeleteEmployee(int id);
    }
}
