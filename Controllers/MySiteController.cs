using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab9_2_MVC.Controllers
{
    public class MySiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MyPage()
        {
            ViewData["FirstName"] = "Jeremy";
            ViewData["LastName"] = "Jones";
            return View();
        }

        public IActionResult MyForm()
        {
            return View();
        }
        public IActionResult ThankYou(string FirstName, string LastName, string Email)
        {
            ViewData["FirstName"] = FirstName;
            ViewData["LastName"] = LastName;
            ViewData["Email"] = Email;
            return View();
        }
    }
}
