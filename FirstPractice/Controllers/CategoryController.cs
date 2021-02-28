using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstPractice.Models;


namespace FirstPractice.Controllers
{
    //private NorthwindEntities db = new NorthwindEntities();
    

    public class CategoryController : Controller
    {
        //private Category db = new Category();

        // GET: Category
        public ActionResult Index(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Category> categories = CategoryDataContext.LoadCategories(id);
            return View(categories);
        }
        [HttpGet]
        public ActionResult Index6(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Category> categories = CategoryDataContext.LoadCategories(id);
            return Json(categories, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
               Category _category = CategoryDataContext.LoadCategoryByID(id);
                return View(_category);

        }

        [HttpPost]
        public ActionResult Edit()
        {
                Category _category = new Category();
                _category.CategoryID = Convert.ToInt32(Request.Form["CategoryID"]);
                _category.CategoryName = Request.Form["CategoryName"];
                _category.Description = Request.Form["Description"];
                CategoryDataContext.EditCategory(_category);
                return RedirectToAction("Index");

        }

        public ActionResult Insert()
        {
            if (Request.Form.Count > 0)
            {
                Category _category = new Category();
                _category.CategoryName = Request.Form["CategoryName"];
                _category.Description = Request.Form["Description"];
                CategoryDataContext.InsertCategory(_category);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id = 0)
        {
            CategoryDataContext.DeleteCategory(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Search4(int id = 0)
        {
            ViewBag.ProductID = id;
            List<Product> products = CategoryDataContext.LoadProducts5(id);
            return View(products);
        }

    }
}