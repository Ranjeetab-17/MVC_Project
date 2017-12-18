using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        EmployeeDbContext empdb = new EmployeeDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginUser(UserLogin objLogin)
        {
            var checkuserlogin = empdb.Employees.Where(m => m.UserID == objLogin.UserID && m.Password == objLogin.Password);
            if (checkuserlogin.Count() > 0)
            {
                return RedirectToAction("Index","Home");
            }
            else {
                return View();
            }            
        }
    }
}