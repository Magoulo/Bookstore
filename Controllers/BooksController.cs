using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookstore.Models;

namespace Bookstore.Controllers;
/*
public class BooksController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public BooksController(ILogger<HomeController> logger)
    {
        _logger = logger;
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
*/
public class BooksController : Controller
{
    private readonly BooksRepository _bookRepository;

    public BooksController(ApplicationDbContext context)
    {
        _bookRepository = new BooksRepository(context);
    }

    public IActionResult Index()
    {
        var books = _bookRepository.GetAllBooks();
        return View(books);
    }


    // Create GET and POST
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Book book)
    {
        if (ModelState.IsValid)
        {
            _bookRepository.AddBook(book);
            return RedirectToAction("Index");
        }

        return View(book);
    }


}
