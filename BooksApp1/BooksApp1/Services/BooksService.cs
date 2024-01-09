using BooksApp1.Entities;
using BooksApp1.Repository;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

namespace BooksApp1.Services;

public class BookService:IBookService{

public BookService()
{
    Console.WriteLine("In BookService");
}
public List<Books> GetAll()
{
    List<Books> bookList=new List<Books>();
    MySqlRepository mgr=new MySqlRepository();
    bookList=mgr.GetAll();
    return bookList;
}
}