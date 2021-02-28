using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using FirstPractice.Models;
using System.ComponentModel.DataAnnotations;

namespace FirstPractice.Models
{
    public class ProductDataContext
    {
        static string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;

        public static object ViewBag { get; private set; }

        //讀取所有產品分類資料
        public static List<Product> LoadProducts(int ProductID)
        {
            List<Product> Products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select ProductID,CategoryID,ProductName,SupplierID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products where ProductID between 1 and 20";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmd.Parameters.AddWithValue("@ProductID", ProductID);
                        Product product = new Product();
                        product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        product.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
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
        public static List<Product> LoadProducts11(int ProductID)
        {
            List<Product> Products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select ProductID,CategoryID,ProductName,SupplierID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products where ProductID between 21 and 40";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmd.Parameters.AddWithValue("@ProductID", ProductID);
                        Product product = new Product();
                        product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        product.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
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
        public static List<Product> LoadProducts21(int ProductID)
        {
            List<Product> Products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select ProductID,CategoryID,ProductName,SupplierID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products where ProductID between 41 and 60";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmd.Parameters.AddWithValue("@ProductID", ProductID);
                        Product product = new Product();
                        product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        product.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
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
        public static List<Product> LoadProducts31(int ProductID)
        {
            List<Product> Products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select ProductID,CategoryID,ProductName,SupplierID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products where ProductID between 61 and 80";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmd.Parameters.AddWithValue("@ProductID", ProductID);
                        Product product = new Product();
                        product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        product.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
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
        public static List<Product> LoadProducts41(int ProductID)
        {
            List<Product> Products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select ProductID,CategoryID,ProductName,SupplierID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmd.Parameters.AddWithValue("@ProductID", ProductID);
                        Product product = new Product();
                        product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        product.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
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
        public static List<Product> LoadProducts51(int ProductID)
        {
            List<Product> Products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select distinct ProductID,CategoryID,ProductName,SupplierID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products Order by ProductID";

                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmd.Parameters.AddWithValue("@ProductID", ProductID);
                        Product product = new Product();
                        product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        product.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
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
        public static List<Product> LoadProducts52(int CategoryID)
        {
            List<Product> Products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select ProductID,CategoryID,ProductName,SupplierID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products where CategoryID = 1";

                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                        Product product = new Product();
                        product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        product.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
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
        public static List<Product> LoadProducts53(int CategoryID)
        {
            List<Product> Products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select ProductID,CategoryID,ProductName,SupplierID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products where CategoryID = 2 ";

                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                        Product product = new Product();
                        product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        product.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
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
        public static List<Product> LoadProducts54(int CategoryID)
        {
            List<Product> Products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select ProductID,CategoryID,ProductName,SupplierID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products where CategoryID = 3 ";

                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                        Product product = new Product();
                        product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        product.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
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
        public static List<Product> LoadProducts55(int CategoryID)
        {
            List<Product> Products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select ProductID,CategoryID,ProductName,SupplierID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products where CategoryID = 4 ";

                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                        Product product = new Product();
                        product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        product.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
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
        public static List<Product> LoadProducts56(int CategoryID)
        {
            List<Product> Products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select ProductID,CategoryID,ProductName,SupplierID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products where CategoryID = 5 ";

                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                        Product product = new Product();
                        product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        product.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
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
        public static List<Product> LoadProducts57(int CategoryID)
        {
            List<Product> Products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select ProductID,CategoryID,ProductName,SupplierID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products where CategoryID = 6 ";

                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                        Product product = new Product();
                        product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        product.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
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
        public static List<Product> LoadProducts58(int CategoryID)
        {
            List<Product> Products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select ProductID,CategoryID,ProductName,SupplierID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products where CategoryID = 7 ";

                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                        Product product = new Product();
                        product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        product.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
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
        public static List<Product> LoadProducts59(int CategoryID)
        {
            List<Product> Products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select ProductID,CategoryID,ProductName,SupplierID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products where CategoryID = 8 ";

                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                        Product product = new Product();
                        product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        product.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
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
        //根據產品編號讀取要修改
        public static Product LoadProductByID(int ProductID)
        {
            Product _product = new Product();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strCmd = "select ProductID,SupplierID,ProductName,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products where ProductID = @ProductID";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", ProductID);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        _product.ProductID = Convert.ToInt32(dr["ProductID"]);
                        _product.ProductName = dr["ProductName"].ToString();
                        _product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        _product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                        _product.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                        _product.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);
                        _product.UnitsInStock = Convert.ToInt16(dr["UnitsInStock"]);
                        _product.UnitsOnOrder = Convert.ToInt16(dr["UnitsOnOrder"]);


                    }
                    dr.Close();
                    conn.Close();

                }
              
            }
            return _product;
        }

        //修改
        public static void EditProduct(Product _product)
        {
            string strCmd = "update Products set ProductName = @ProductName,SupplierID = @SupplierID,CategoryID = @CategoryID,QuantityPerUnit = @QuantityPerUnit,UnitPrice = @UnitPrice,UnitsInStock = @UnitsInStock,UnitsOnOrder = @UnitsOnOrder where ProductID = @ProductID";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
               
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", _product.ProductID);
                    cmd.Parameters.AddWithValue("@ProductName", _product.ProductName);
                    cmd.Parameters.AddWithValue("@SupplierID", _product.SupplierID);
                    cmd.Parameters.AddWithValue("@CategoryID", _product.CategoryID);
                    cmd.Parameters.AddWithValue("@QuantityPerUnit", _product.QuantityPerUnit);
                    cmd.Parameters.AddWithValue("@UnitPrice", _product.UnitPrice);
                    cmd.Parameters.AddWithValue("@UnitsInStock", _product.UnitsInStock);
                    cmd.Parameters.AddWithValue("@UnitsOnOrder", _product.UnitsOnOrder);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        //刪除
        public static void DeleteProduct(int ProductID)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "Delete Products where ProductID = @ProductID";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", ProductID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }


        public static List<Product> LoadProducts1(int CategoryID)
        {
            List<Product> Products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder from Products Where CategoryID=@CategoryID Order by CategoryID";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
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


        public static List<Supplier> LoadProducts2(int SupplierID)
        {
            List<Supplier> Suppliers = new List<Supplier>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select SupplierID,CompanyName,ContactName,ContactTitle,Address,City,PostalCode,Country,Phone from Suppliers Where SupplierID=@SupplierID Order by SupplierID";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", SupplierID);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Supplier supplier = new Supplier();
                        supplier.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        supplier.CompanyName = dr["CompanyName"].ToString();
                        supplier.ContactName = dr["ContactName"].ToString();
                        supplier.ContactTitle = dr["ContactTitle"].ToString();
                        supplier.Address = dr["Address"].ToString();
                        supplier.City = dr["City"].ToString();
                        supplier.PostalCode = dr["PostalCode"].ToString();
                        supplier.Country = dr["Country"].ToString();
                        supplier.Phone = dr["Phone"].ToString();
                        Suppliers.Add(supplier);
                    }
                    dr.Close();
                    conn.Close();
                }
            }
            return Suppliers;
        }

        public static List<Category> LoadProducts3(int CategoryID)
        {
            List<Category> Categories = new List<Category>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select CategoryID,CategoryName,Description from Categories Where CategoryID=@CategoryID ";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Category category = new Category();
                        category.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                        category.CategoryName = dr["CategoryName"].ToString();
                        category.Description = dr["Description"].ToString();
                        Categories.Add(category);
                    }
                    dr.Close();
                    conn.Close();
                }
            }
            return Categories;
        }

        public static List<Supplier> LoadProducts4(int SupplierID)
        {
            List<Supplier> Suppliers = new List<Supplier>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                String strCmd = "select SupplierID,CompanyName,ContactName,ContactTitle,Address,City,PostalCode,Country,Phone from Suppliers Where SupplierID=@SupplierID Order by SupplierID";
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", SupplierID);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Supplier supplier = new Supplier();
                        supplier.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        supplier.CompanyName = dr["CompanyName"].ToString();
                        supplier.ContactName = dr["ContactName"].ToString();
                        supplier.ContactTitle = dr["ContactTitle"].ToString();
                        supplier.Address = dr["Address"].ToString();
                        supplier.City = dr["City"].ToString();
                        supplier.PostalCode = dr["PostalCode"].ToString();
                        supplier.Country = dr["Country"].ToString();
                        supplier.Phone = dr["Phone"].ToString();
                        Suppliers.Add(supplier);
                    }
                    dr.Close();
                    conn.Close();
                }
            }
            return Suppliers;
        }

        public static void InsertProducts4(Product product)
        {
          
            using (SqlConnection conn = new SqlConnection(strConn))
            {

                string strCmd1 = "insert into Products(SupplierID) select SupplierID from Suppliers";
                string strCmd2 = "insert into Categories (CategoryID) values(@CategoryID)";
                string strCmd = "insert Products(ProductName,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder) values(@ProductName,@QuantityPerUnit,@UnitPrice,@UnitsInStock,@UnitsOnOrder) " ;
               
                using (SqlCommand cmd = new SqlCommand(strCmd1, conn))
                {

                    
                    cmd.Parameters.AddWithValue("@SupplierID", product.SupplierID);
                    
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                using (SqlCommand cmd = new SqlCommand(strCmd2, conn))
                {

                    
                    cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID);
                
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {

                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("@QuantityPerUnit", product.QuantityPerUnit);
                    cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                    cmd.Parameters.AddWithValue("@UnitsInStock", product.UnitsInStock);
                    cmd.Parameters.AddWithValue("@UnitsOnOrder", product.UnitsOnOrder);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                

            }

        }


        public static List<Product> InsertProducts2(int CategoryID)
        {
            List<Product> products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strCmd = "select distinct CategoryName,CategoryID from Categories";
                string strCmd1 = "select distinct CompanyName,SupplierID from Suppliers order by SupplierID";

                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Product product = new Product();
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                        product.CategoryName = dr["CategoryName"].ToString();
                        products.Add(product);
                    }
                    dr.Close();
                    conn.Close();

                }
                using (SqlCommand cmd = new SqlCommand(strCmd1, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Product product = new Product();
                        product.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                        product.CompanyName = dr["CompanyName"].ToString();
                        products.Add(product);
                    }
                    dr.Close();
                    conn.Close();

                }



            }
            return products;
        }


        public static void InsertProducts(Product product)
        {

            using (SqlConnection conn = new SqlConnection(strConn))
            {

                string strCmd = "insert Products(ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder) values(@ProductName,@SupplierID,@CategoryID,@QuantityPerUnit,@UnitPrice,@UnitsInStock,@UnitsOnOrder) ";

                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("@SupplierID", product.SupplierID);
                    cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID);
                    cmd.Parameters.AddWithValue("@QuantityPerUnit", product.QuantityPerUnit);
                    cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                    cmd.Parameters.AddWithValue("@UnitsInStock", product.UnitsInStock);
                    cmd.Parameters.AddWithValue("@UnitsOnOrder", product.UnitsOnOrder);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }



            }

        }

        public static List<Product> InsertProducts21(int CategoryID)
        {
            List<Product> products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strCmd = "select distinct CategoryName,CategoryID from Categories";

                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Product product = new Product();
                        product.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                        product.CategoryName = dr["CategoryName"].ToString();
                        products.Add(product);
                    }
                    dr.Close();
                    conn.Close();

                }
            }
            return products;
        }
        public static void InsertProducts22(Product product)
        {

            using (SqlConnection conn = new SqlConnection(strConn))
            {

                string strCmd = "insert Products(ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder) values(@ProductName,@SupplierID,@CategoryID,@QuantityPerUnit,@UnitPrice,@UnitsInStock,@UnitsOnOrder) ";

                using (SqlCommand cmd = new SqlCommand(strCmd, conn))
                {
                    //cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("@SupplierID", product.SupplierID);
                    cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID);
                    cmd.Parameters.AddWithValue("@QuantityPerUnit", product.QuantityPerUnit);
                    cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                    cmd.Parameters.AddWithValue("@UnitsInStock", product.UnitsInStock);
                    cmd.Parameters.AddWithValue("@UnitsOnOrder", product.UnitsOnOrder);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }



            }

        }

    }


}





