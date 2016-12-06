using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Steeltoe.Extensions.Configuration.ConfigServer;

namespace steelexample.Controllers
{
    public class HomeController : Controller
    {
        private IConfigurationRoot Config { get; set; }

        public HomeController(IConfigurationRoot config)
        {
            Config = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ConfigServer()
        {
            ViewData["Foo"] = Config["Foo"];
            ViewData["Bar"] = Config["Bar"];
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

        public IActionResult Error()
        {
            return View();
        }
    }
}
