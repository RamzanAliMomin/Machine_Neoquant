using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Machine_Neoquant.Interface;
using Machine_Neoquant.Models;

namespace Machine_Neoquant.Implementation
{
    public class Department : IDepartment
    {
       
        string connectionString = "data source=DESKTOP-VB05MHF; initial catalog=NeoquantEmployee;persist security info=True;user id=sa;password=sa@123;";
        //To View all department details
        public IEnumerable<Models.ModelDepartment> GetAllDepartment()
        {
            try
            {
                List<ModelDepartment> lstdepartment = new List<ModelDepartment>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllDepartment", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        ModelDepartment department = new ModelDepartment();
                        department.ID = Convert.ToInt32(rdr["DEPARTMENT_ID"]);
                        department.DeptName = rdr["DEPARTMENT_NAME"].ToString();

                        lstdepartment.Add(department);
                    }
                    con.Close();
                }
                return lstdepartment;
            }
            catch
            {
                throw;
            }
        }
       
    }
}