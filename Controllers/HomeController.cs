using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Chiropractic.Models;

namespace Chiropractic.Controllers
{
    public class HomeController : Controller
    {
        IDataProvider mDataProvider = new DataProvider(); // TODO
        int UserId = 1; // TODO 
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View(mDataProvider.GetUser(UserId));
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
