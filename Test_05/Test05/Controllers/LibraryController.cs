using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test05.Connect;
using Test05.Models;

namespace Test05.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BooksDBcontext _booksDBcontext;

        public LibraryController(BooksDBcontext booksDBcontext, ILogger<HomeController> logger)
        {
            _logger = logger;
            _booksDBcontext = booksDBcontext;
        }
        // GET: LibraryController
        public ActionResult Index()
        {
            return View(_booksDBcontext._library.ToList());
        }
        // GET: LibraryController/Details/5
        public ActionResult Details(int id)
        {   

            library _library = _booksDBcontext._library.FirstOrDefault(f => f.Id == id);
            if (_library == null)
            {
                return NotFound();
            }
            return View(_library);           
        }

        // GET: LibraryController/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: LibraryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(library newlibrary)
        {
            try
            {
                if (newlibrary == null) return RedirectToAction("Index");
                _booksDBcontext._library.Add(newlibrary);
                _booksDBcontext.SaveChanges();
                return RedirectToAction("Index");
                
            }
            catch
            {
                return View();
            }
        }
        // GET: LibraryController/Edit/5
        public IActionResult Edit(int id)
        {
            library _library = _booksDBcontext._library.FirstOrDefault(f => f.Id == id);
            if (_library == null)
            {
                return NotFound();
            }           
            return View(_library);
        }
        // POST: LibraryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(library Editlibrary)
        {
            try
            {
                _booksDBcontext.Update(Editlibrary);
                _booksDBcontext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: LibraryController/Delete/5
        public IActionResult Delete(int id)
        {
            library _library = _booksDBcontext._library.FirstOrDefault(f => f.Id == id);
            if (_library == null)
            {
                return NotFound();
            }
            _booksDBcontext._library.Remove(_library);
            _booksDBcontext.SaveChanges();
            return RedirectToAction("Index");            
        }

        // POST: LibraryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
