using FrindsPro.DAL;
using FrindsPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FrindsPro.Controllers
{
    public class HomeController : Controller
    {      

        private readonly ILogger<HomeController> _logger;
        private readonly FrindsDBcontext _frindsDBcontext;

        public HomeController(FrindsDBcontext frindsDBcontext, ILogger<HomeController> logger)
        {
            _logger = logger;
            _frindsDBcontext = frindsDBcontext;
        }

        public IActionResult Index()
        {
            return View(_frindsDBcontext.Frinds.ToList());
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
