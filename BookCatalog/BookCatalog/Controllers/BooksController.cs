using BookCatalog.Models;
using BookCatalog.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookRepository _bookRepository;
        public BooksController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return _bookRepository.Get();
        }

        [HttpGet("{id}")]
        public  ActionResult<Book> GetBooks(int id)
        {
            return _bookRepository.GetBook(id);
        }

        [HttpPost]
        public ActionResult<int> CreateBook([FromBody] Book book)
        {
            return _bookRepository.Create(book);
        }

        [HttpPut]
        public ActionResult<Book> UpdateBook(int id, [FromBody] Book book)
        {
            if (id != book.BID)
            {
                return BadRequest();
            }

            var _book = _bookRepository.Update(book);

            return CreatedAtAction(nameof(GetBooks), new { id = _book.BID }, _book);

        }
    }
}
