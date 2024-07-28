using Microsoft.AspNetCore.Mvc;
using MvcShus.Models;
using System;
using System.Diagnostics;

namespace MvcShus.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public static List<Frinds> classhopList = new List<Frinds>
            {
                new Frinds("Moshe", "14", 12345),
                new Frinds("David", "15", 67890),
                new Frinds("Rachel", "16", 11223),
                new Frinds("Leah", "17", 44556),
                new Frinds("Shimon", "18", 78901)
            };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(classhopList);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            var item = classhopList.FirstOrDefault(c => c._id == id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        public IActionResult Update(Frinds model)
        {
            var item = classhopList.FirstOrDefault(c => c._id == model._id);

            if (item != null)
            {
                // ????? ?????
                item._name = model._name;
                item._age = model._age;
                item._id = model._id;
                return RedirectToAction("Index");
            }

            return NotFound();
        }
        public IActionResult test()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Frinds model)
        {
            if (ModelState.IsValid)
            {
                // ????? ????? ??????
                classhopList.Add(model);
                // ???? ?? ?????? ????? ?????? ???? ??????
                return RedirectToAction("Index");
            }

            // ?? ????? ???? ????, ???? ?? ?????? ????? ?????
            return View();
        }
        public IActionResult AddNew()
        {

            return View();
        }
        [HttpGet("/Home/Details/{name}")]
        public IActionResult Details(string name)
        {
            var item = classhopList.FirstOrDefault(c => c._name == name);
            if (item == null)
            {
                return NotFound();
            }
            return View(item); 
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
