using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeBook.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace HomeBook.Api.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // GET api/books
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IList<Book> books = new List<Book>() {
                new Book() {
                    Key = Guid.Parse("19d2423a-1785-43ae-8063-0fa97ae4d0a3"),
                    Name = "Test1",
                    Pages = 1,
                    CreatedAt = DateTimeOffset.Now
                },
                new Book() {
                    Key = Guid.Parse("9e2b3c2f-0bf9-4537-adfc-7e4bedbf1d29"),
                    Name = "Test2",
                    Pages = 2,
                    CreatedAt = DateTimeOffset.Now
                }
            };

            return new OkObjectResult(books);
        }

        // GET api/books/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string bookKey)
        {
            Guid key;
            if (!Guid.TryParse(bookKey, out key)) return NotFound();

            return new OkObjectResult(new Book()
            {
                Key = key,
                Name = "Test2",
                Pages = 2,
                CreatedAt = DateTimeOffset.Now
            });
        }

        // POST api/books
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Book book)
        {
            return new CreatedAtActionResult(nameof(Get), nameof(BooksController), new { bookKey = book.Key }, book);
        }

        // PUT api/books/5
        [HttpPut("{bookKey}")]
        public async Task<IActionResult> Put(string bookKey, [FromBody] Book book)
        {
            Guid key;
            if (!Guid.TryParse(bookKey, out key)) return NotFound();

            return new OkObjectResult(book);
        }

        // DELETE api/books/5
        [HttpDelete("{bookKey}")]
        public async Task<IActionResult> Delete(string bookKey)
        {
            Guid key;
            if (!Guid.TryParse(bookKey, out key)) return NotFound();

            return new EmptyResult();
        }
    }
}
