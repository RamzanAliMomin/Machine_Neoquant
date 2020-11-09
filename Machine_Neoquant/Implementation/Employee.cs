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
    public class Employee : IEmployee
    {
       
        string connectionString = "data source=DESKTOP-VB05MHF; initial catalog=NeoquantEmployee;persist security info=True;user id=sa;password=sa@123;";
        //To View all employees details
        public IEnumerable<Models.ModelEmployees> GetAllEmployees()
        {
            try
            {
                List<ModelEmployees> lstemployee = new List<ModelEmployees>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        ModelEmployees employee = new ModelEmployees();
                        employee.ID = Convert.ToInt32(rdr["EMPLOYEE_ID"]);
                        employee.EmployeeName = rdr["EMP_NAME"].ToString();
                        employee.EmployeeAddress = rdr["EMP_ADDRESS"].ToString();
                        employee.JoingDate = Convert.ToDateTime(rdr["JOINING_DATE"]);
                        employee.Salary = rdr["SALARY"].ToString();
                        employee.DepartmentName = rdr["DEPARTMENT_NAME"].ToString();

                        lstemployee.Add(employee);
                    }
                    con.Close();
                }
                return lstemployee;
            }
            catch
            {
                throw;
            }
        }
        //To Add new employee record 
        public int AddEmployee(ModelEmployees employee)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", employee.EmployeeName);
                    cmd.Parameters.AddWithValue("@Address", employee.EmployeeAddress);
                    cmd.Parameters.AddWithValue("@JoiningDate", employee.JoingDate);
                    cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                    cmd.Parameters.AddWithValue("@Department", employee.DepartmentName);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar employee
        public int UpdateEmployee(ModelEmployees employee)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spUpdateEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpId", employee.ID);
                    cmd.Parameters.AddWithValue("@Name", employee.EmployeeName);
                    cmd.Parameters.AddWithValue("@Address", employee.EmployeeAddress);
                    cmd.Parameters.AddWithValue("@JoiningDate", employee.JoingDate);
                    cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                    cmd.Parameters.AddWithValue("@Department", employee.DepartmentName);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //Get the details of a particular employee
        public ModelEmployees GetEmployeeData(int id)
        {
            try
            {
                ModelEmployees employee = new ModelEmployees();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string sqlQuery = "SELECT * FROM employees WHERE EMPLOYEE_ID= " + id;
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        employee.ID = Convert.ToInt32(rdr["EMPLOYEE_ID"]);
                        employee.EmployeeName = rdr["EMP_NAME"].ToString();
                        employee.EmployeeAddress = rdr["EMP_ADDRESS"].ToString();
                        employee.JoingDate = Convert.ToDateTime(rdr["JOINING_DATE"]);
                        employee.Salary = rdr["SALARY"].ToString();
                        employee.DepartmentName = rdr["DEPARTMENT_ID"].ToString(); ;
                    }
                }
                return employee;
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record on a particular employee
        public int DeleteEmployee(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spDeleteEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpId", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return 1;
            }
            catch
            {
                throw;
            }
        }
    }
}