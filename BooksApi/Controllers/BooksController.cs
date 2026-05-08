using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BooksApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBooks()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "books.json");
            var json = System.IO.File.ReadAllText(filePath);
            var books = JsonSerializer.Deserialize<List<Book>>(json);
            return Ok(books);
        }
    }
}