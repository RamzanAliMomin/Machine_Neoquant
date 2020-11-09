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
    public class DepartmentController : ControllerBase
    {
        private IDepartment _dept;

        public DepartmentController(IDepartment dept)
        {
            _dept = dept;
        }
        [Route("api/Department/GetDepartments")]
        public IEnumerable<ModelDepartment> Index()
        {
            return _dept.GetAllDepartment();
        }

    }
}
