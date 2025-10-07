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
    public class OccupationsController : Controller
    {
        private readonly LibraryAPIContext _context;

        public OccupationsController(LibraryAPIContext context)
        {
            _context = context;
        }

        // GET: Occupations
        [HttpGet("occupations")]
        public IEnumerable<Occupation> Index()
        {
            return _context.Occupations.ToList();
        }

        ///// <summary>
        ///// Add a new occupation.
        ///// </summary>
        //[HttpPost("add")]
        //public async Task<ActionResult<Occupation>> AddOccupation([FromBody] Occupation occupation)
        //{
        //    _context.Occupations.Add(occupation);
        //    await _context.SaveChangesAsync();
        //    return CreatedAtAction(nameof(GetOccupationById), new { id = occupation.OccupationId }, occupation);
        //}

        ///// <summary>
        ///// Edit an existing occupation.
        ///// </summary>
        //[HttpPut("edit/{id}")]
        //public async Task<IActionResult> EditOccupation(int id, [FromBody] Occupation updatedOccupation)
        //{
        //    var occupation = await _context.Occupations.FindAsync(id);
        //    if (occupation == null) return NotFound();

        //    occupation.OccupationDesc = updatedOccupation.OccupationDesc;

        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Delete an occupation by ID.
        ///// </summary>
        //[HttpDelete("delete/{id}")]
        //public async Task<IActionResult> DeleteOccupation(int id)
        //{
        //    var occupation = await _context.Occupations.FindAsync(id);
        //    if (occupation == null) return NotFound();

        //    _context.Occupations.Remove(occupation);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Get an occupation by ID.
        ///// </summary>
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Occupation>> GetOccupationById(int id)
        //{
        //    var occupation = await _context.Occupations.FindAsync(id);
        //    if (occupation == null) return NotFound();
        //    return occupation;
        //}
    }
}
