using Cau1.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAL
{
    class DepartmentDAL : DBConnection
    {
        public List<DepartmentDAO> ReadDepartmentList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Department_2119110353", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<DepartmentDAO> lstDep = new List<DepartmentDAO>();
            while (reader.Read())
            {
                DepartmentDAO dep = new DepartmentDAO();
                dep.IdDepartment = reader["IdDepartment"].ToString();
                dep.NameDep = reader["NameDep"].ToString();
                lstDep.Add(dep);
            }
            conn.Close();
            return lstDep;
        }

        public DepartmentDAO ReadDepartment(string id)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "select * from Department_2119110353 where IdDepartment = '" + id + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DepartmentDAO dep = new DepartmentDAO();
            if (reader.HasRows && reader.Read())
            {
                dep.IdDepartment = reader["IdDepartment"].ToString();
                dep.NameDep = reader["NameDep"].ToString();
            }
            conn.Close();
            return dep;
        }
    }
}
