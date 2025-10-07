using LibraryAPI.Data;
using LibraryAPI.Interfaces;
using LibraryAPI.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MediaController<T> : ControllerBase where T : MediaItem
    {
        private readonly LibraryAPIContext _context;

        public MediaController(LibraryAPIContext context)
        {
            _context = context;
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] T item)
        {
            var dbSet = GetDbSet<T>();
            if (dbSet == null) return BadRequest("Unsupported media type.");

            dbSet.Add(item);
            _context.SaveChanges();
            return Ok(item);
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var dbSet = GetDbSet<T>();
            if (dbSet == null) return BadRequest("Unsupported media type.");

            return Ok(dbSet.ToList());
        }

        private DbSet<T>? GetDbSet<T>() where T : MediaItem
        {
            // Match known types to their DbSet
            if (typeof(T) == typeof(Book)) return _context.Books as DbSet<T>;
            if (typeof(T) == typeof(Magazine)) return _context.Magazines as DbSet<T>;
            if (typeof(T) == typeof(AudioBook)) return _context.AudioBooks as DbSet<T>;

            return null;
        }
    }
}
