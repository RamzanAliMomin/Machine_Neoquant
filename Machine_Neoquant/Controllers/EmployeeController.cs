using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Machine_Neoquant.Interface;
using Machine_Neoquant.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Machine_Neoquant.Controllers
{
    [EnableCors("specificdomain")]
    public class EmployeeController : ControllerBase
    {
        private IEmployee _emp;

        public EmployeeController(IEmployee emp)
        {
            _emp = emp;
        }
        // GET api/values
        [Route("api/Employee/Index")]
        public IEnumerable<ModelEmployees> Index()
        {
            return _emp.GetAllEmployees();
        }

        [HttpGet]
        [Route("api/Employee/Details/{id}")]
        public ModelEmployees Details(int id)
        {
            return _emp.GetEmployeeData(id);
        }

        [HttpPost]
        [Route("api/Employee/Create")]
        public int Create([FromBody] ModelEmployees employee)
        {
            return _emp.AddEmployee(employee);
        }

        [HttpPut]
        [Route("api/Employee/Edit")]
        public int Edit([FromBody]ModelEmployees employee)
        {
            return _emp.UpdateEmployee(employee);
        }


        [HttpDelete]
        [Route("api/Employee/Delete/{id}")]
        public int Delete(int id)
        {
            return _emp.DeleteEmployee(id);
        }
    }
}
