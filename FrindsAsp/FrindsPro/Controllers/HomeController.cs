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

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(Data.Get.Frinds.ToList());
        }

        public IActionResult Edit(int id)
        {
            ClassFrind frind = Data.Get.Frinds.Include(f => f.Images).FirstOrDefault(f => f.Id == id);
            return View(frind);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(ClassFrind frind)
        {                   
            var existFrind = Data.Get.Frinds.Include(f => f.Images).FirstOrDefault(f => f.Id == frind.Id);
            if (existFrind == null)
            {
                return NotFound();
            }
            existFrind.FirstName = frind.FirstName;
            existFrind.LastName = frind.LastName;
            existFrind.PhoneNumber = frind.PhoneNumber;
            existFrind.Email = frind.Email;
            existFrind.Images.AddRange(frind.Images);           
            Data.Get.SaveChanges();            
            return RedirectToAction("Details", new { id = existFrind.Id });
        }
        [HttpPost]
        public IActionResult DeleteImage(int friendId, string imageId)
        {
            var friend = Data.Get.Frinds.Include(f => f.Images).FirstOrDefault(f => f.Id == friendId);
            if (friend == null)
            {
                return NotFound();
            }

            var image = friend.Images.FirstOrDefault(i => i.Id == imageId);
            if (image == null)
            {
                return NotFound();
            }

            friend.Images.Remove(image);
            Data.Get.SaveChanges();

            return RedirectToAction("Edit", new { id = friendId });
        }


        public IActionResult Details(int id)
        {
            ClassFrind frind = Data.Get.Frinds.Include(f => f.Images).FirstOrDefault(f => f.Id == id);
            if (frind == null)
            {
                return NotFound();
            }
            return View(frind);
        }
        public IActionResult Delete(int id)
        {
            ClassFrind frind = Data.Get.Frinds.FirstOrDefault(f => f.Id == id);
            if (frind == null)
            {
                return NotFound();
            }
            Data.Get.Frinds.Remove(frind);
            Data.Get.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Create(ClassFrind frind )
        {
            if (frind == null) return RedirectToAction("Index");
            Data.Get.Frinds.Add(frind);
            Data.Get.SaveChanges();
            return RedirectToAction("Index");

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
