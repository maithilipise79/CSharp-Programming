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
    public  class DepartmentRepository
    {
        public void Add(Department d)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.conStr))
            {
                SqlCommand cmd = new SqlCommand("sp_curdForDept", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", 2);
                cmd.Parameters.AddWithValue("@deptName", d.DepartmentName);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        
        public void Update(Department d)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.conStr))
            {
                SqlCommand cmd = new SqlCommand("sp_curdForDept", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@deptName", d.DepartmentName);
                cmd.Parameters.AddWithValue("@id", d.ID);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.conStr))
            {
                SqlCommand cmd = new SqlCommand("sp_curdForDept", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@action", 2);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }



        public List<Department> GetAll()
        {
            List<Department> list = new List<Department>();

            using (SqlConnection con = new SqlConnection(DBHelper.conStr))
            {
                SqlCommand cmd = new SqlCommand("sp_curdForDept", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", 1);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(new Department
                    {
                        ID = (int)dr["Id"],
                        DepartmentName = dr["DepartmentName"].ToString()
                    });
                }
            }
            return list;
        }



    }



}
