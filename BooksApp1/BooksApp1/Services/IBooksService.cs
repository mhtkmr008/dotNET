using BooksApp1.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BooksApp1.Services;

public interface IBookService{

public List<Books> GetAll();
}