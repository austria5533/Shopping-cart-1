using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using FirstPractice.Models;

namespace FirstPractice.Models
{
    public class CategoryDataContext
    {
        static string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;

        //讀取所有產品分類資料
        public static List<Category> LoadCategories(int CategoryID)
        {
            List<Category> categories = new List<Category>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                
                string strCmd = "select CategoryID,CategoryName,Description,Picture from Categories";
                string strCmd1 = "select distinct ProductID,ProductName,CategoryID from Products  Order by  ProductID ";
              
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Category _category = new Category();
                        _category.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                        _category.CategoryName = dr["CategoryName"].ToString();
                        _category.Description = dr["Description"].ToString();
                        _category.Picture = (byte[])dr["Picture"];
                        categories.Add(_category);
                    }
                    dr.Close();
                    conn.Close();
                }
                  using (SqlCommand cmd = new SqlCommand(strCmd1, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Category category = new Category();
                        category.ProductID = Convert.ToInt32(dr["ProductID"]);
                        category.ProductName = dr["ProductName"].ToString();
                        category.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                        categories.Add(category);
                    }
                    dr.Close();
                    conn.Close();

                }
            }
            return categories;
        }


        //根據分類編號讀取要修改的產品分類資料
        public static Category LoadCategoryByID(int CategoryID)
        {
            Category _category = new Category();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strCmd = "select CategoryID,CategoryName,Description from Categories where CategoryID = @CategoryID";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        _category.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                        _category.CategoryName = dr["CategoryName"].ToString();
                        _category.Description = dr["Description"].ToString();
                    }
                    dr.Close();
                    conn.Close();

                }
            }
            return _category;
        }

        //新增產品分類資料
        public static void InsertCategory(Category category)
        {
            string strCmd = "insert Categories(CategoryName,Description) values(@CategoryName,@Description)";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                    cmd.Parameters.AddWithValue("@Description", category.Description);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        //修改產品分類資料
        public static void EditCategory(Category _category)
                {
                    string strCmd = "update Categories set CategoryName = @CategoryName, Description = @Description where CategoryID = @CategoryID";
                    using (SqlConnection conn = new SqlConnection(strConn))
                    {
                        using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                        {
                            cmd.Parameters.AddWithValue("@CategoryID", _category.CategoryID);
                            cmd.Parameters.AddWithValue("@CategoryName", _category.CategoryName);
                            cmd.Parameters.AddWithValue("@Description", _category.Description);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
        //刪除產品分類資料
        public static void DeleteCategory(int CategoryID)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "Delete Categories where CategoryID=@CategoryID";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public static List<Product> LoadProducts5(int ProductID)
        {
            List<Product> Products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strCmd = "select ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products Where ProductID=@ProductID";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", ProductID);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Product product = new Product();
                        product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                        product.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                        product.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);
                        product.UnitsInStock = Convert.ToInt16(dr["UnitsInStock"]);
                        product.UnitsOnOrder = Convert.ToInt16(dr["UnitsOnOrder"]);
                        Products.Add(product);
                    }
                    dr.Close();
                    conn.Close();
                }
            }
            return Products;
        }

      
    }
}
