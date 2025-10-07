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
    public class LanguagesController : Controller
    {
        private readonly LibraryAPIContext _context;

        public LanguagesController(LibraryAPIContext context)
        {
            _context = context;
        }

        // GET: Languages
        [HttpGet("languages")]
        public IEnumerable<Language> Index()
        {
            return _context.Languages.ToList();
        }

        ///// <summary>
        ///// Add a new language.
        ///// </summary>
        //[HttpPost("add")]
        //public async Task<ActionResult<Language>> AddLanguage([FromBody] Language language)
        //{
        //    _context.Languages.Add(language);
        //    await _context.SaveChangesAsync();
        //    return CreatedAtAction(nameof(GetLanguageById), new { id = language.LanguageId }, language);
        //}

        ///// <summary>
        ///// Edit an existing language.
        ///// </summary>
        //[HttpPut("edit/{id}")]
        //public async Task<IActionResult> EditLanguage(int id, [FromBody] Language updatedLanguage)
        //{
        //    var language = await _context.Languages.FindAsync(id);
        //    if (language == null) return NotFound();

        //    language.LanguageDesc = updatedLanguage.LanguageDesc;

        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Delete a language by ID.
        ///// </summary>
        //[HttpDelete("delete/{id}")]
        //public async Task<IActionResult> DeleteLanguage(int id)
        //{
        //    var language = await _context.Languages.FindAsync(id);
        //    if (language == null) return NotFound();

        //    _context.Languages.Remove(language);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Get a language by ID.
        ///// </summary>
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Language>> GetLanguageById(int id)
        //{
        //    var language = await _context.Languages.FindAsync(id);
        //    if (language == null) return NotFound();
        //    return language;
        //}
    }
}
