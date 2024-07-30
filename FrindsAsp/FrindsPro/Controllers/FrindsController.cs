using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FrindsPro.DAL;
using FrindsPro.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FrindsPro.Controllers
{
    public class FrindsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FrindsDBcontext _frindsDBcontext;

        public FrindsController(FrindsDBcontext frindsDBcontext, ILogger<HomeController> logger)
        {
            _logger = logger;
            _frindsDBcontext = frindsDBcontext;
        }

        public IActionResult Index()
        {
            return View(_frindsDBcontext.Frinds.ToList());
        }
        // GET: FrindsController1/Details/5
        public ActionResult Details(int id)
        {           
            ClassFrind frind = _frindsDBcontext.Frinds.Include(f => f.Images).FirstOrDefault(f => f.Id == id);
            if (frind == null)
            {
                return NotFound();
            }
            return View(frind);            
        }

        // GET: FrindsController1/Create
        public ActionResult Create()
        {
            return View();
        }
        
       

        // POST: FrindsController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClassFrind frind)
        {
            try
            {
                if (frind == null) return RedirectToAction("Index");
                _frindsDBcontext.Frinds.Add(frind);
                _frindsDBcontext.SaveChanges();               
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FrindsController1/Edit/5
        public ActionResult Edit(int id)
        {
            ClassFrind frind = _frindsDBcontext.Frinds.Include(f => f.Images).FirstOrDefault(f => f.Id == id);
            return View(frind);
        }

        // POST: FrindsController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClassFrind frind)
        {
            try
            {
                var existFrind = _frindsDBcontext.Frinds.Include(f => f.Images).FirstOrDefault(f => f.Id == frind.Id);
                if (existFrind == null)
                {
                    return NotFound();
                }
                existFrind.FirstName = frind.FirstName;
                existFrind.LastName = frind.LastName;
                existFrind.PhoneNumber = frind.PhoneNumber;
                existFrind.Email = frind.Email;
                existFrind.Images.AddRange(frind.Images);
                _frindsDBcontext.SaveChanges();
                return RedirectToAction("Details", new { id = existFrind.Id });
                
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult DeleteImage(int friendId, string imageId)
        {
            var friend = _frindsDBcontext.Frinds.Include(f => f.Images).FirstOrDefault(f => f.Id == friendId);
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
            _frindsDBcontext.SaveChanges();

            return RedirectToAction("Edit", new { id = friendId });
        }
       
        
        public IActionResult Delete(int id)
        {
            try
            {
                var friend = _frindsDBcontext.Frinds.FirstOrDefault(f => f.Id == id);
                _frindsDBcontext.Frinds.Remove(friend);
                _frindsDBcontext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
