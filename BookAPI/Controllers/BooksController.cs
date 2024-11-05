using BookAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers;
//localhost:xxxx/api/books
[Route("api/[Controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly List<Book> _bookList;

    public BooksController()
    {
        _bookList = new List<Book>
        {
            new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" },
            new Book { Id = 2, Title = "Hellow world", Author = "Ian Q" },
            new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" }
        };
    }

    [HttpGet]
    public ActionResult<IEnumerable<Book>> GetBooks() 
    {
        return Ok(_bookList);
    }
}
