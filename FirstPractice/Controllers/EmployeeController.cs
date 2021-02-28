using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using FirstPractice.Models;
using System.Web.Mvc;

namespace FirstPractice.Controllers
{
    public class EmployeeController : Controller
    {
       
            public ActionResult Index()
            {
                List<Employee> employees = EmployeeDataContext.LoadEmployees();
                 return View(employees);
            }

            public ActionResult Insert()
            {
                if (Request.Form.Count > 0)
                {
                    Employee _employee = new Employee();
                    _employee.LastName = Request.Form["LastName"];
                    _employee.FirstName = Request.Form["FirstName"];
                    //_employee.BirthDate = Convert.ToDateTime(Request.Form["BirthDate"]);
                    //_employee.HireDate = Convert.ToDateTime(Request.Form["HireDate"]);
                //    _employee.Title = Request.Form["Title"];
                //    _employee.TitleOfCourtesy = Request.Form["TitleOfCourtesy"];
                //    _employee.Address = Request.Form["Address"];
                //    _employee.City = Request.Form["City"];
                //    _employee.PostalCode = Request.Form["PostalCode"];
                //    _employee.Country = Request.Form["Country"];
                //    _employee.HomePhone = Request.Form["HomePhone"];
                //    _employee.Extension = Request.Form["Extension"];
                //_employee.Extension = Request.Form["Photo"];
                //_employee.Extension = Request.Form["Notes"];
                    EmployeeDataContext.InsertEmployees(_employee);
                    return RedirectToAction("Index");
                }
                return View();
            }

        public ActionResult Delete(int id = 0)
        {
            EmployeeDataContext.DeleteEmployees(id);
            return RedirectToAction("Index");
        }
    }


    }
