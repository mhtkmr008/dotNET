using AspNetCore;
using BooksApp1.Entities;
using BooksApp1.Services;
using Microsoft.AspNetCore.Mvc;
namespace BooksApp1.Controllers;

public class BooksApp1Controller : Controller
{
    private IBookService _svc;
    public BooksApp1Controller(IBookService svc)
    {
        Console.WriteLine("In Booksapp1 Constructor");
        this._svc=svc;
    }

    [HttpGet]
    public IActionResult getAll()
    {
        List<Books>bookList=_svc.GetAll();
        TempData["allBooks"]=bookList;
        return View();
    }
}