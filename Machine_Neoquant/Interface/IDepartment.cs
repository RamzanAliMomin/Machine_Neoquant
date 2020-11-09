using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Machine_Neoquant.Models;
namespace Machine_Neoquant.Interface
{
    public interface IDepartment
    {
        IEnumerable<ModelDepartment> GetAllDepartment();
        
    }
}
