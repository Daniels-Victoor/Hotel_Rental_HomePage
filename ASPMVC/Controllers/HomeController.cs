using ASPMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //private ApplicationDbContext db = new ApplicationDbContext();

        public IActionResult Index()
        {
            return View();//(db.Fields.ToList());
        }

        public IActionResult Browseby()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Stories()
        {
            return View();// (db.Fields.ToList());
        }
        public IActionResult Agents()
        {
            return View();// (db.Fields.ToList());
        }
    }
}
