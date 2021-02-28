using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using FirstPractice.Models;

namespace FirstPractice.Models
{
    public class EmployeeDataContext
    {
        static string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;

        //讀取所有產品分類資料
        public static List<Employee> LoadEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                
                String strCmd = "select EmployeeID,LastName,FirstName,BirthDate,HireDate,Title,TitleOfCourtesy,Address,City,PostalCode,Country,HomePhone,Extension,Photo,Notes from Employees";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Employee _employee = new Employee();
                        _employee.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                        _employee.LastName = dr["LastName"].ToString();
                        _employee.FirstName = dr["FirstName"].ToString();
                        _employee.BirthDate = Convert.ToDateTime(dr["BirthDate"]);
                        _employee.HireDate = Convert.ToDateTime(dr["HireDate"]);
                        _employee.Title = dr["Title"].ToString();
                        _employee.TitleOfCourtesy = dr["TitleOfCourtesy"].ToString();
                        _employee.Address = dr["Address"].ToString();
                        _employee.City = dr["City"].ToString();
                        _employee.PostalCode = dr["PostalCode"].ToString();
                        _employee.Country = dr["Country"].ToString();
                        _employee.HomePhone = dr["HomePhone"].ToString();
                        _employee.Extension = dr["Extension"].ToString();
                        _employee.Photo = (byte[])dr["Photo"];
                        _employee.Notes = dr["Notes"].ToString();
                        //_employee.PhotoPath = Convert.ToString(dr["PhotoPath"]);
                        employees.Add(_employee);
                    }
                    dr.Close();
                    conn.Close();
                }
            }
            return employees;
        }

        public static void InsertEmployees(Employee employee)
        {

            using (SqlConnection conn = new SqlConnection(strConn))
            {

                string strCmd = "insert Employees(LastName,FirstName,BirthDate,HireDate,Title,TitleOfCourtesy,City,PostalCode,Country,HomePhone,Extension) values(@LastName,@FirstName,@BirthDate,@HireDate,@Title,@TitleOfCourtesy,@City,@PostalCode,@Country,@HomePhone,@Extension) ";

                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                    cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@BirthDate", employee.BirthDate);
                    cmd.Parameters.AddWithValue("@HireDate", employee.HireDate);
                    cmd.Parameters.AddWithValue("@Title", employee.Title);
                    cmd.Parameters.AddWithValue("@TitleOfCourtesy", employee.TitleOfCourtesy);
                    cmd.Parameters.AddWithValue("@City", employee.City);
                    cmd.Parameters.AddWithValue("@PostalCode", employee.PostalCode);
                    cmd.Parameters.AddWithValue("@Country", employee.Country);
                    cmd.Parameters.AddWithValue("@HomePhone", employee.HomePhone);
                    cmd.Parameters.AddWithValue("@Extension", employee.Extension);
                    cmd.Parameters.AddWithValue("@PhotoPath", employee.PhotoPath);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }



            }

        }
        public static void DeleteEmployees(int EmployeeID)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "Delete Employees where EmployeeID=@EmployeeID";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }



    }
}
