    using EmployeeManagement.MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL
{
    public class EmployeeRepository
    {
        public void Add(Employee e)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.conStr))
            {
                SqlCommand cmd = new SqlCommand("sp_curdForEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", 2);
                cmd.Parameters.AddWithValue("@name", e.Name);
                cmd.Parameters.AddWithValue("@deptId", e.DepartmentID);
                cmd.Parameters.AddWithValue("@salary", e.Salary);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Employee e)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.conStr))
            {
                SqlCommand cmd = new SqlCommand("sp_curdForEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", 3);
                cmd.Parameters.AddWithValue("@name", e.Name);
                cmd.Parameters.AddWithValue("@deptId", e.DepartmentID);
                cmd.Parameters.AddWithValue("@salary", e.Salary);
                cmd.Parameters.AddWithValue("@id", e.ID);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.conStr))
            {
                SqlCommand cmd = new SqlCommand("sp_curdForEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", 4);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Employee> GetAll()
        {
            List<Employee> list = new List<Employee>();

            using (SqlConnection con = new SqlConnection(DBHelper.conStr))
            {
                SqlCommand cmd = new SqlCommand("sp_curdForEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", 1);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(new Employee
                    {
                        ID = (int)dr["Id"],
                        Name = dr["Name"].ToString(),
                        DepartmentID = (int)dr["DepartmentId"],
                        Salary = (decimal)dr["Salary"]
                    });
                }
            }
            return list;
        }



    }
}
