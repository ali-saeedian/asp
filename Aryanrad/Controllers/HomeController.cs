using Aryanrad.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Aryanrad.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Ruls()
        {
            return View();
        }

        

        public IActionResult ProductDetails()
        {
            return View();
        }

        public IActionResult ProductDetails2()
        {
            return View();
        }

        public IActionResult ProductDetails3()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }

        public IActionResult Category2()
        {
            return View();
        }

        public IActionResult Category3()
        {
            return View();
        }

        public IActionResult Category4()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
