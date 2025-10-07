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
    public class EmployeeRolesController : Controller
    {
        private readonly LibraryAPIContext _context;

        public EmployeeRolesController(LibraryAPIContext context)
        {
            _context = context;
        }

        // GET: Employee Roles
        [HttpGet("employeeroles")]
        public IEnumerable<EmployeeRole> Index()
        {
            return _context.EmployeeRoles.ToList();
        }

        ///// <summary>
        ///// Add a new employee role.
        ///// </summary>
        //[HttpPost("add")]
        //public async Task<ActionResult<EmployeeRole>> AddEmployeeRole([FromBody] EmployeeRole role)
        //{
        //    _context.EmployeeRoles.Add(role);
        //    await _context.SaveChangesAsync();
        //    return CreatedAtAction(nameof(GetEmployeeRoleById), new { id = role.EmployeeRoleId }, role);
        //}

        ///// <summary>
        ///// Edit an existing employee role.
        ///// </summary>
        //[HttpPut("edit/{id}")]
        //public async Task<IActionResult> EditEmployeeRole(int id, [FromBody] EmployeeRole updatedRole)
        //{
        //    var role = await _context.EmployeeRoles.FindAsync(id);
        //    if (role == null) return NotFound();

        //    role.EmployeeRoleName = updatedRole.EmployeeRoleName;

        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Delete an employee role by ID.
        ///// </summary>
        //[HttpDelete("delete/{id}")]
        //public async Task<IActionResult> DeleteEmployeeRole(int id)
        //{
        //    var role = await _context.EmployeeRoles.FindAsync(id);
        //    if (role == null) return NotFound();

        //    _context.EmployeeRoles.Remove(role);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        ///// <summary>
        ///// Get an employee role by ID.
        ///// </summary>
        //[HttpGet("{id}")]
        //public async Task<ActionResult<EmployeeRole>> GetEmployeeRoleById(int id)
        //{
        //    var role = await _context.EmployeeRoles.FindAsync(id);
        //    if (role == null) return NotFound();
        //    return role;
        //}
    }
}
