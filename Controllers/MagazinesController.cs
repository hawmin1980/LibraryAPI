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
    public class MagazinesController : MediaController<Magazine>
    {
        public MagazinesController(LibraryAPIContext context) : base(context) { }


        //// GET: Books
        //[HttpGet(Name = "GetAllMagazines")]
        //public IEnumerable<Magazine> Index()
        //{
        //    return _context.Magazines.ToList();
        //}

        ///// <summary>
        ///// Add a new magazine.
        ///// </summary>
        //[HttpPost("add")]
        //public async Task<ActionResult<Magazine>> AddMagazine([FromBody] Magazine Magazine)
        //{
        //    Magazine.Id = Guid.NewGuid();
        //    _context.Magazines.Add(Magazine);
        //    await _context.SaveChangesAsync();
        //    return CreatedAtAction(nameof(GetMagazineById), new { id = Magazine.Id }, Magazine);
        //}

        ///// <summary>
        ///// Edit an existing magazine.
        ///// </summary>
        //[HttpPut("edit/{id}")]
        //public async Task<IActionResult> EditMagazine(Guid id, [FromBody] Magazine updatedMagazine)
        //{
        //    var Magazine = await _context.Magazines.FindAsync(id);
        //    if (Magazine == null) return NotFound();

        //    Magazine.Title = updatedMagazine.Title;
        //    Magazine.LanguageId = updatedMagazine.LanguageId;
        //    Magazine.GenreId = updatedMagazine.GenreId;
        //    Magazine.PublishedDate = updatedMagazine.PublishedDate;
        //    Magazine.IssueNumber = updatedMagazine.IssueNumber;
        //    Magazine.IssueDate = updatedMagazine.IssueDate;
        //    Magazine.ModifiedDate = DateTime.Now;
        //    Magazine.ModifiedBy = updatedMagazine.ModifiedBy;

        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Delete a magazine by ID.
        ///// </summary>
        //[HttpDelete("delete/{id}")]
        //public async Task<IActionResult> DeleteMagazine(Guid id)
        //{
        //    var Magazine = await _context.Magazines.FindAsync(id);
        //    if (Magazine == null) return NotFound();

        //    _context.Magazines.Remove(Magazine);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Get a magazine by ID.
        ///// </summary>
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Magazine>> GetMagazineById(Guid id)
        //{
        //    var Magazine = await _context.Magazines.FindAsync(id);
        //    if (Magazine == null) return NotFound();
        //    return Magazine;
        //}
    }
}
