using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstPractice.Models;

namespace FirstPractice.Controllers
{
    public class SupplierController : Controller
    {
        // GET: Supplier
        public ActionResult Index()
        {
            List<Supplier> suppliers = SupplierDataContext.LoadSuppliers();
            return View(suppliers);
        }
        public ActionResult Delete(int id = 0)
        {
            SupplierDataContext.DeleteSupplier(id);
            return RedirectToAction("Index");
        }

        public ActionResult Insert()
        {
            if (Request.Form.Count > 0)
            {
                Supplier _supplier = new Supplier();
                _supplier.SupplierID = Convert.ToInt32(Request.Form["SupplierID"]);
                _supplier.CompanyName = Request.Form["CompanyName"];
                _supplier.ContactName = Request.Form["ContactName"];
                _supplier.ContactTitle = Request.Form["ContactTitle"];
                _supplier.Address = Request.Form["Address"];
                _supplier.City = Request.Form["City"];
                _supplier.PostalCode = Request.Form["PostalCode"];
                _supplier.Country = Request.Form["Country"];
                _supplier.Phone = Request.Form["Phone"];
                SupplierDataContext.InsertSuppliers(_supplier);
                return RedirectToAction("Index");
            }
            return View(Request.Form.Count);
        }
    }

}