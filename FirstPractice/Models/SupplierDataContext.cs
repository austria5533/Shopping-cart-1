using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using FirstPractice.Models;

namespace FirstPractice.Models
{
    public class SupplierDataContext
    {
        static string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;

        //讀取所有產品分類資料
        public static List<Supplier> LoadSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select SupplierID,CompanyName,ContactName,ContactTitle,Address,City,PostalCode,Country,Phone from Suppliers Order by SupplierID";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Supplier _supplier = new Supplier();
                        _supplier.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        _supplier.CompanyName = dr["CompanyName"].ToString();
                        _supplier.ContactName = dr["ContactName"].ToString();
                        _supplier.ContactTitle = dr["ContactTitle"].ToString();
                        _supplier.Address = dr["Address"].ToString();
                        _supplier.City = dr["City"].ToString();
                        _supplier.PostalCode  = dr["PostalCode"].ToString();
                        _supplier.Country = dr["Country"].ToString();
                        _supplier.Phone = dr["Phone"].ToString();
                        suppliers.Add(_supplier);
                    }
                    dr.Close();
                    conn.Close();
                }
            }
            return suppliers;
        }

        public static void DeleteSupplier(int SupplierID)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "Delete Suppliers where SupplierID=@SupplierID";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", SupplierID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }


        public static void InsertSuppliers(Supplier supplier)
        {

            using (SqlConnection conn = new SqlConnection(strConn))
            {

                string strCmd = "insert Suppliers(SupplierID,CompanyName,ContactName,ContactTitle,Address,City,PostalCode,Country,Phone) values(@SupplierID,@CompanyName,@ContactName,@ContactTitle,@Address,@City,@PostalCode,@Country,@Phone) ";

                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                    cmd.Parameters.AddWithValue("@CompanyName", supplier.CompanyName);
                    cmd.Parameters.AddWithValue("@ContactName", supplier.ContactName);
                    cmd.Parameters.AddWithValue("@ContactTitle", supplier.ContactTitle);
                    cmd.Parameters.AddWithValue("@Address", supplier.Address);
                    cmd.Parameters.AddWithValue("@City", supplier.City);
                    cmd.Parameters.AddWithValue("@PostalCode", supplier.PostalCode);
                    cmd.Parameters.AddWithValue("@Country", supplier.Country);
                    cmd.Parameters.AddWithValue("@Phone", supplier.Phone);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }



            }

        }


    }
}