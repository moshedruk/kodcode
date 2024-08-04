using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test05.Connect;
using Test05.Models;
using Test05.viewsModel;
using Test05.viewsModel;

namespace Test05.Controllers
{
    public class ShelfController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BooksDBcontext _booksDBcontext;

        public ShelfController(BooksDBcontext booksDBcontext, ILogger<HomeController> logger)
        {
            _logger = logger;
            _booksDBcontext = booksDBcontext;
        }
        // GET: ShelfController
        public ActionResult Index()
        {
            return View(_booksDBcontext._Shelf.ToList());
        }

        // GET: ShelfController/Details/5
        public ActionResult Details(int id)
        {
            Shelf _Shelf = _booksDBcontext._Shelf.Include(s => s._library ).FirstOrDefault(f => f.Id == id);
            if (_Shelf == null)
            {
                return NotFound();
            }
            return View(_Shelf);
            
        }

        // GET: ShelfController/Create
        public ActionResult Create()
        {
            var _librarylist = _booksDBcontext._library.ToList();
            var viewModel = new modelsLibraryShelf
            {
                library = _librarylist,
            };
            return View(viewModel);
        }

        // POST: ShelfController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(modelsLibraryShelf viewModel)
        {
            try
            {
                viewModel.Shelf._library = _booksDBcontext._library.Find(viewModel.SelectedlibraryId);
                viewModel.Shelf.Title = viewModel.Shelf._library.Name;
                // כאן ניתן להשתמש ב-SelectedGrupId אם יש צורך
                _booksDBcontext._Shelf.Add(viewModel.Shelf);
                _booksDBcontext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ShelfController/Edit/5
        public ActionResult Edit(int id)
        {
            Shelf _Shelf = _booksDBcontext._Shelf.FirstOrDefault(f => f.Id == id);
            if (_Shelf == null)
            {
                return NotFound();
            }
            return View(_Shelf);
        }

        // POST: ShelfController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Shelf _Shelf)
        {
            try
            {
                _booksDBcontext.Update(_Shelf);
                _booksDBcontext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ShelfController/Delete/5
        public IActionResult Delete(int id)
        {
            Shelf _Shelf = _booksDBcontext._Shelf.FirstOrDefault(f => f.Id == id);
            if (_Shelf == null)
            {
                return NotFound();
            }
            _booksDBcontext._Shelf.Remove(_Shelf);
            _booksDBcontext.SaveChanges();
            return RedirectToAction("Index");
           
        }

        // POST: ShelfController/Delete/5
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
