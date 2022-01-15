using Cau1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAL
{
    class EmployeeDAL : DBConnection
    {
        public EmployeeDAL() : base()
        {

        }
        public List<EmployeeDAO> ReadEmployee()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            //SqlCommand cmd = new SqlCommand("select * from Employee_2119110353", conn);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select_Employee";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();
            List<EmployeeDAO> lstEmp = new List<EmployeeDAO>();
            DepartmentDAL dep = new DepartmentDAL();
            while (reader.Read())
            {
                EmployeeDAO emp = new EmployeeDAO();
                emp.IdEmployee = reader["IdEmployee"].ToString();
                emp.NameEmp = reader["NameEmp"].ToString();
                emp.Department = dep.ReadDepartment(reader["IdDepartment"].ToString());
                emp.PlaceBirth = reader["PlaceBirth"].ToString();
                emp.DateBirth = Convert.ToDateTime(reader["DateBirth"].ToString());
                emp.Gender = int.Parse(reader["Gender"].ToString());
                lstEmp.Add(emp);
            }
            conn.Close();
            return lstEmp;
        }
        public void DeleteEmployee(EmployeeDAO emp)
        {
            //SqlConnection conn = CreateConnection();
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("delete from Employee_2119110353 where IdEmployee = @IdEmployee", conn);
            //cmd.Parameters.Add(new SqlParameter("@IdEmployee", emp.IdEmployee));
            //cmd.ExecuteNonQuery();
            //conn.Close();

            SqlConnection conn = CreateConnection();
            conn.Open();

            try
            {
                //khỏi tạo instance của class SqlCommand
                SqlCommand cmd = new SqlCommand();
                //sử dụng thuộc tính CommandText để chỉ định tên Proc
                cmd.CommandText = "spDeleteEmployee";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //khai báo các thông tin của tham số truyền vào
                cmd.Parameters.Add("@IdEmployee", SqlDbType.NVarChar).Value = emp.IdEmployee;
                //mở chuỗi kết nối
                conn.Open();
                //sử dụng ExecuteNonQuery để thực thi
                cmd.ExecuteNonQuery();
                //đóng chuỗi kết nối.
                conn.Close();

                Console.WriteLine("Xoa thanh cong !!!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Co loi xay ra !!!" + e);
            }
            // dóng chuỗi kết nối
            finally
            {
                conn.Close();
            }
        }
        public void NewEmployee(EmployeeDAO emp)
        {
            //SqlConnection conn = CreateConnection();
            //conn.Open();
            //SqlCommand cmd = new SqlCommand(
            //    "insert into Employee_2119110353(IdEmployee,NameEmp,IdDepartment,PlaceBirth,DateBirth,Gender) values(@IdEmployee,@NameEmp,@IdDepartment,@PlaceBirth,@DateBirth,@Gender)", conn);
            //cmd.Parameters.Add(new SqlParameter("@NameEmp", emp.NameEmp));
            //cmd.Parameters.Add(new SqlParameter("@IdDepartment", emp.Department.IdDepartment));
            //cmd.Parameters.Add(new SqlParameter("@PlaceBirth", emp.PlaceBirth));
            //cmd.Parameters.Add(new SqlParameter("@DateBirth", emp.DateBirth));
            //cmd.Parameters.Add(new SqlParameter("@Gender", emp.Gender));
            //cmd.Parameters.Add(new SqlParameter("@IdEmployee", emp.IdEmployee));            
            //cmd.ExecuteNonQuery();
            //conn.Close();

            SqlConnection conn = CreateConnection();
            conn.Open();
            try
            {
                //khỏi tạo instance của class SqlCommand
                SqlCommand cmd = new SqlCommand();
                //sử dụng thuộc tính CommandText để chỉ định tên Proc
                cmd.CommandText = "spInsertEmployee";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //khai báo các thông tin của tham số truyền vào
                cmd.Parameters.Add("@IdEmployee", SqlDbType.NVarChar).Value = emp.IdEmployee;
                cmd.Parameters.Add("@NameEmp", SqlDbType.NVarChar).Value = emp.NameEmp;
                cmd.Parameters.Add("@IdDepartment", SqlDbType.NVarChar).Value = emp.Department;
                cmd.Parameters.Add("@PlaceBirth", SqlDbType.NVarChar).Value = emp.PlaceBirth;
                cmd.Parameters.Add("@DateBirth", SqlDbType.Date).Value = emp.DateBirth;
                cmd.Parameters.Add("@Gender", SqlDbType.Int).Value = emp.Gender;
                //mở chuỗi kết nối
                conn.Open();
                //sử dụng ExecuteNonQuery để thực thi
                cmd.ExecuteNonQuery();
                //đóng chuỗi kết nối.
                conn.Close();
                Console.WriteLine("Them thanh cong !!!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Co loi xay ra !!!" + e);
            }
            // dóng chuỗi kết nối
            finally
            {
                conn.Close();
            }
        }
        public void EditEmployee(EmployeeDAO emp)
        {
            //SqlConnection conn = CreateConnection();
            //conn.Open();
            //SqlCommand cmd = new SqlCommand(
            //    "update Employee_2119110353 set NameEmp = @NameEmp, IdEmployee = @IdEmployee," +
            //    "IdDepartment=@IdDepartment, PlaceBirth=@PlaceBirth," +
            //    "DateBirth=@DateBirth, Gender=@Gender where @IdEmployee = IdEmployee", conn);
            //cmd.Parameters.Add(new SqlParameter("@IdEmployee", emp.IdEmployee));
            //cmd.Parameters.Add(new SqlParameter("@NameEmp", emp.NameEmp));
            //cmd.Parameters.Add(new SqlParameter("@IdDepartment", emp.Department.IdDepartment));
            //cmd.Parameters.Add(new SqlParameter("@PlaceBirth", emp.PlaceBirth));
            //cmd.Parameters.Add(new SqlParameter("@DateBirth", emp.DateBirth));
            //cmd.Parameters.Add(new SqlParameter("@Gender", emp.Gender));
            //cmd.ExecuteNonQuery();
            //conn.Close();

            SqlConnection conn = CreateConnection();
            conn.Open();
            try
            {
                //khỏi tạo instance của class SqlCommand
                SqlCommand cmd = new SqlCommand();
                //sử dụng thuộc tính CommandText để chỉ định tên Proc
                cmd.CommandText = " spEditEmployee";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //khai báo các thông tin của tham số truyền vào
                cmd.Parameters.Add("@IdEmployee", SqlDbType.NVarChar).Value = emp.IdEmployee;
                cmd.Parameters.Add("@NameEmp", SqlDbType.NVarChar).Value = emp.NameEmp;
                cmd.Parameters.Add("@IdDepartment", SqlDbType.NVarChar).Value = emp.Department;
                cmd.Parameters.Add("@PlaceBirth", SqlDbType.NVarChar).Value = emp.PlaceBirth;
                cmd.Parameters.Add("@DateBirth", SqlDbType.Date).Value = emp.DateBirth;
                cmd.Parameters.Add("@Gender", SqlDbType.Int).Value = emp.Gender;
                //mở chuỗi kết nối
                conn.Open();
                //sử dụng ExecuteNonQuery để thực thi
                cmd.ExecuteNonQuery();
                //đóng chuỗi kết nối.
                conn.Close();

                Console.WriteLine("Sua thanh cong !!!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Co loi xay ra !!!" + e);
            }
            // dóng chuỗi kết nối
            finally
            {
                conn.Close();
            }
        }
    }
}
