using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibraryAPI.Data;
using LibraryAPI.Models.Entities;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : MediaController<Book>
    {
        public BooksController(LibraryAPIContext context) : base(context) {}

        //// GET: Books
        //[HttpGet(Name = "GetAllBooks")]
        //public IEnumerable<Book> Index()
        //{
        //    return _context.Books.ToList();
        //}

        ///// <summary>
        ///// Add a new book to the library.
        ///// </summary>
        //[HttpPost("add")]
        //public async Task<ActionResult<Book>> AddBook([FromBody] Book book)
        //{
        //    book.Id = Guid.NewGuid();
        //    _context.Books.Add(book);
        //    await _context.SaveChangesAsync();
        //    return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
        //}

        ///// <summary>
        ///// Edit an existing book.
        ///// </summary>
        //[HttpPut("edit/{id}")]
        //public async Task<IActionResult> EditBook(Guid id, [FromBody] Book updatedBook)
        //{
        //    var book = await _context.Books.FindAsync(id);
        //    if (book == null) return NotFound();

        //    // Update fields
        //    book.Title = updatedBook.Title;
        //    book.LanguageId = updatedBook.LanguageId;
        //    book.GenreId = updatedBook.GenreId;
        //    book.PublishedDate = updatedBook.PublishedDate;
        //    book.Isbn = updatedBook.Isbn;
        //    book.BookAuthor = updatedBook.BookAuthor;
        //    book.ModifiedDate = DateTime.Now;
        //    book.ModifiedBy = updatedBook.ModifiedBy;

        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Delete a book by ID.
        ///// </summary>
        //[HttpDelete("delete/{id}")]
        //public async Task<IActionResult> DeleteBook(Guid id)
        //{
        //    var book = await _context.Books.FindAsync(id);
        //    if (book == null) return NotFound();

        //    _context.Books.Remove(book);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Get a book by ID.
        ///// </summary>
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Book>> GetBookById(Guid id)
        //{
        //    var book = await _context.Books.FindAsync(id);
        //    if (book == null) return NotFound();
        //    return book;
        //}
    }
}
