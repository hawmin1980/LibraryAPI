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
    public class CountriesController : Controller
    {
        private readonly LibraryAPIContext _context;

        public CountriesController(LibraryAPIContext context)
        {
            _context = context;
        }

        // GET: Countries
        [HttpGet("countries")]
        public IEnumerable<Country> Index()
        {
            return _context.Countries.ToList();
        }

        ///// <summary>
        ///// Add a new country.
        ///// </summary>
        //[HttpPost("add")]
        //public async Task<ActionResult<Country>> AddCountry([FromBody] Country country)
        //{
        //    _context.Countries.Add(country);
        //    await _context.SaveChangesAsync();
        //    return CreatedAtAction(nameof(GetCountryById), new { id = country.CountryId }, country);
        //}

        ///// <summary>
        ///// Edit an existing country.
        ///// </summary>
        //[HttpPut("edit/{id}")]
        //public async Task<IActionResult> EditCountry(int id, [FromBody] Country updatedCountry)
        //{
        //    var country = await _context.Countries.FindAsync(id);
        //    if (country == null) return NotFound();

        //    country.CountryDesc = updatedCountry.CountryDesc;

        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Delete a country by ID.
        ///// </summary>
        //[HttpDelete("delete/{id}")]
        //public async Task<IActionResult> DeleteCountry(int id)
        //{
        //    var country = await _context.Countries.FindAsync(id);
        //    if (country == null) return NotFound();

        //    _context.Countries.Remove(country);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Get a country by ID.
        ///// </summary>
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Country>> GetCountryById(int id)
        //{
        //    var country = await _context.Countries.FindAsync(id);
        //    if (country == null) return NotFound();
        //    return country;
        //}
    }
}
