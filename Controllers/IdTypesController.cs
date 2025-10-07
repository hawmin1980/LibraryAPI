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
    public class IdTypesController : Controller
    {
        private readonly LibraryAPIContext _context;

        public IdTypesController(LibraryAPIContext context)
        {
            _context = context;
        }

        // GET: IdTypes
        [HttpGet("idtypes")]
        public IEnumerable<IdType> Index()
        {
            return _context.IdType.ToList();
        }

        ///// <summary>
        ///// Add a new ID type.
        ///// </summary>
        //[HttpPost("add")]
        //public async Task<ActionResult<IdType>> AddIdType([FromBody] IdType idType)
        //{
        //    _context.IdTypes.Add(idType);
        //    await _context.SaveChangesAsync();
        //    return CreatedAtAction(nameof(GetIdTypeById), new { id = idType.IdTypeId }, idType);
        //}

        ///// <summary>
        ///// Edit an existing ID type.
        ///// </summary>
        //[HttpPut("edit/{id}")]
        //public async Task<IActionResult> EditIdType(int id, [FromBody] IdType updatedIdType)
        //{
        //    var idType = await _context.IdTypes.FindAsync(id);
        //    if (idType == null) return NotFound();

        //    idType.IdTypeDesc = updatedIdType.IdTypeDesc;

        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Delete an ID type by ID.
        ///// </summary>
        //[HttpDelete("delete/{id}")]
        //public async Task<IActionResult> DeleteIdType(int id)
        //{
        //    var idType = await _context.IdTypes.FindAsync(id);
        //    if (idType == null) return NotFound();

        //    _context.IdTypes.Remove(idType);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Get an ID type by ID.
        ///// </summary>
        //[HttpGet("{id}")]
        //public async Task<ActionResult<IdType>> GetIdTypeById(int id)
        //{
        //    var idType = await _context.IdTypes.FindAsync(id);
        //    if (idType == null) return NotFound();
        //    return idType;
        //}
    }
}
