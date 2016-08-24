using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestLibrary;

namespace TestWebAppCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            int value1 = 2;
            int value2 = 2;
            ViewData["Message"] = string.Format("{0} + {1} = {2}", value1, value2,
                Arithmetics.Add(value1, value2));

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = Markdown.ConvertToHtml("**Hello world!**"); ;

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
