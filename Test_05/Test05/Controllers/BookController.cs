using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test05.Connect;
using Test05.Models;
using Test05.viewsModel;

namespace Test05.Controllers
{
    public class BookController : Controller
    {        
        private readonly BooksDBcontext _booksDBcontext;

        public BookController(BooksDBcontext booksDBcontext, ILogger<HomeController> logger)
        {
            
            _booksDBcontext = booksDBcontext;
        }
        // GET: BookController
        public IActionResult Index()
        {
            return View(_booksDBcontext._Book.ToList());
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            Book book = _booksDBcontext._Book.Include(s => s._shelf).ThenInclude(s => s._library).FirstOrDefault(f => f.Id == id);
            return View(book);
        }
        // GET: BookController/Create
        public IActionResult Create()
        {
            
            List<library> library = _booksDBcontext._library.ToList();


            List<Shelf> l = _booksDBcontext._Shelf.Include(s => s._library).ToList();

            var viewModel = new modelBookShelflibrary
            {
                library = library,
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(modelBookShelflibrary _modelBookShelflibrary)
        {
            try
            {
                List<Shelf> shelves = _booksDBcontext._Shelf.Where(s => s._library.Id == _modelBookShelflibrary.SelectedlibraryId).ToList();

                foreach (var shelf in shelves) 
                {
                    if(shelf.width > _modelBookShelflibrary.book.width && shelf.height > _modelBookShelflibrary.book.height) 
                    {
                        shelf.width = shelf.width - _modelBookShelflibrary.book.width;
                        shelf.height = shelf.height - _modelBookShelflibrary.book.height;
                        _modelBookShelflibrary.book._shelf = shelf;
                        break;
                    }
                }                       
                    _booksDBcontext._Book.Add(_modelBookShelflibrary.book);
                    _booksDBcontext.SaveChanges();
                    return RedirectToAction("Index");
            }
            //return  new ContentResult { Content = "\"אין מקום צריך לפתוח מדף חדש\" " }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Createset(modelBookShelflibrary _modelBookShelflibrary)
        {
            List<library> library = _booksDBcontext._library.ToList();

            _modelBookShelflibrary.library = library;
            

           
            return View(_modelBookShelflibrary);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatesetAdd(modelBookShelflibrary _modelBookShelflibrary)
        {
            try
            {
                List<Shelf> shelves = _booksDBcontext._Shelf.Where(s => s._library.Id == _modelBookShelflibrary.SelectedlibraryId).ToList();
                int sum = _modelBookShelflibrary.bookset.Sum(S => S.width);
                bool ecsses = true;

                foreach (var shelf in shelves)
                {            
                    if (ecsses == false) break;
                    if (shelf.width > sum) 
                    {
                        shelf.width -= sum; 
                        foreach(var book in _modelBookShelflibrary.bookset) 
                        {

                            book._shelf = shelf;
                            _booksDBcontext._Book.Add(book);
                            _booksDBcontext.SaveChanges();
                            ecsses = false;
                        }
                    }
                    else 
                    {
                        Console.WriteLine("אין מקום צריך לפתוח מדף חדש");
                        //return  new ContentResult { Content = "\"אין מקום צריך לפתוח מדף חדש\" " }
                    }                   
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            Book book = _booksDBcontext._Book.FirstOrDefault(f => f.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            _booksDBcontext._Book.Remove(book);
            _booksDBcontext.SaveChanges();
            return RedirectToAction("Index");            
        }
        // POST: BookController/Delete/5
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
