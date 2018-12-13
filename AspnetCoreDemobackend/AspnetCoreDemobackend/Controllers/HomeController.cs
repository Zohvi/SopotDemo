using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreDemobackend.Models;
using System.Text;

namespace AspnetCoreDemobackend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult TietokantaTesti()
        {
            StringBuilder teksti = new StringBuilder();

            NorthwindContext malli = new NorthwindContext();
            foreach (Customers asiakas in malli.Customers)
            {
                teksti.AppendLine(asiakas.CompanyName);
            }
            return Content(teksti.ToString());
        }

       
    }
}
