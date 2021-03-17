using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebDemoFunctions.Web.Models;
using WebDemoFunctions.Web.Services;

namespace WebDemoFunctions.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Date()
        {
            return View(DateTime.Now);
        }

        [HttpPost]
        public IActionResult StringComparison(InMemoryStringChecker model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("StringComparisonResult",model);
            }
            else
            {
                return View(model);
            }
            
        }

        [HttpGet]
        public IActionResult StringComparison()
        {
            return View();
        }

        public IActionResult StringComparisonResult(InMemoryStringChecker model)
        {
            return View(model);
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
    }
}
