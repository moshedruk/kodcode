using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test05.Connect;
using Test05.Models;

namespace Test05.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BooksDBcontext _frindsDBcontext;

        public HomeController(BooksDBcontext frindsDBcontext, ILogger<HomeController> logger)
        {
            _logger = logger;
            _frindsDBcontext = frindsDBcontext;
        }

        public IActionResult Index()
        {
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
    }
}
