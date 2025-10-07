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
    [Route("master")]
    public class GenresController : Controller
    {
        private readonly LibraryAPIContext _context;

        public GenresController(LibraryAPIContext context)
        {
            _context = context;
        }

        // GET: Genres
        [HttpGet("genres")]
        public IEnumerable<Genre> genres()
        {
            return _context.Genres.ToList();
        }

        ///// <summary>
        ///// Add a new genre.
        ///// </summary>
        //[HttpPost("add")]
        //public async Task<ActionResult<Genre>> AddGenre([FromBody] Genre genre)
        //{
        //    _context.Genres.Add(genre);
        //    await _context.SaveChangesAsync();
        //    return CreatedAtAction(nameof(GetGenreById), new { id = genre.GenreId }, genre);
        //}

        ///// <summary>
        ///// Edit an existing genre.
        ///// </summary>
        //[HttpPut("edit/{id}")]
        //public async Task<IActionResult> EditGenre(int id, [FromBody] Genre updatedGenre)
        //{
        //    var genre = await _context.Genres.FindAsync(id);
        //    if (genre == null) return NotFound();

        //    genre.GenreDesc = updatedGenre.GenreDesc;

        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Delete a genre by ID.
        ///// </summary>
        //[HttpDelete("delete/{id}")]
        //public async Task<IActionResult> DeleteGenre(int id)
        //{
        //    var genre = await _context.Genres.FindAsync(id);
        //    if (genre == null) return NotFound();

        //    _context.Genres.Remove(genre);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Get a genre by ID.
        ///// </summary>
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Genre>> GetGenreById(int id)
        //{
        //    var genre = await _context.Genres.FindAsync(id);
        //    if (genre == null) return NotFound();
        //    return genre;
        //}
    }
}
