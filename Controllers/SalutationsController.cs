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
    public class SalutationsController : Controller
    {
        private readonly LibraryAPIContext _context;

        public SalutationsController(LibraryAPIContext context)
        {
            _context = context;
        }

        // GET: Salutations
        [HttpGet("salutations")]
        public IEnumerable<Salutation> Index()
        {
            return _context.Salutations.ToList();
        }

        ///// <summary>
        ///// Add a new salutation.
        ///// </summary>
        //[HttpPost("add")]
        //public async Task<ActionResult<Salutation>> AddSalutation([FromBody] Salutation salutation)
        //{
        //    _context.Salutations.Add(salutation);
        //    await _context.SaveChangesAsync();
        //    return CreatedAtAction(nameof(GetSalutationById), new { id = salutation.SalutationId }, salutation);
        //}

        ///// <summary>
        ///// Edit an existing salutation.
        ///// </summary>
        //[HttpPut("edit/{id}")]
        //public async Task<IActionResult> EditSalutation(int id, [FromBody] Salutation updatedSalutation)
        //{
        //    var salutation = await _context.Salutations.FindAsync(id);
        //    if (salutation == null) return NotFound();

        //    salutation.SalutationDesc = updatedSalutation.SalutationDesc;

        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Delete a salutation by ID.
        ///// </summary>
        //[HttpDelete("delete/{id}")]
        //public async Task<IActionResult> DeleteSalutation(int id)
        //{
        //    var salutation = await _context.Salutations.FindAsync(id);
        //    if (salutation == null) return NotFound();

        //    _context.Salutations.Remove(salutation);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Get a salutation by ID.
        ///// </summary>
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Salutation>> GetSalutationById(int id)
        //{
        //    var salutation = await _context.Salutations.FindAsync(id);
        //    if (salutation == null) return NotFound();
        //    return salutation;
        //}
    }
}
