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
    [Route("[controller]")]
    public class EmployeesController : Controller
    {
        private readonly LibraryAPIContext _context;

        public EmployeesController(LibraryAPIContext context)
        {
            _context = context;
        }

        // GET: Books
        [HttpGet(Name = "GetAllEmployees")]
        public IEnumerable<Employee> Index()
        {
            return _context.Employees.ToList();
        }

        /// <summary>
        /// Add a new employee.
        /// </summary>
        [HttpPost("add")]
        public async Task<ActionResult<Employee>> AddEmployee([FromBody] Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.EmployeeId }, employee);
        }

        /// <summary>
        /// Edit an existing employee.
        /// </summary>
        [HttpPut("edit/{id}")]
        public async Task<IActionResult> EditEmployee(int id, [FromBody] Employee updatedEmployee)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null) return NotFound();

            employee.SalutationId = updatedEmployee.SalutationId;
            employee.Name = updatedEmployee.Name;
            employee.IdNumber = updatedEmployee.IdNumber;
            employee.IdTypeId = updatedEmployee.IdTypeId;
            employee.DateOfBirth = updatedEmployee.DateOfBirth;
            employee.Gender = updatedEmployee.Gender;
            employee.Nationality = updatedEmployee.Nationality;
            employee.EmployeeRoleId = updatedEmployee.EmployeeRoleId;
            employee.SupervisorId = updatedEmployee.SupervisorId;
            employee.ModifiedDate = DateTime.Now;
            employee.ModifiedBy = updatedEmployee.ModifiedBy;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        /// <summary>
        /// Delete an employee by ID.
        /// </summary>
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null) return NotFound();

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        /// <summary>
        /// Get an employee by ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployeeById(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null) return NotFound();
            return employee;
        }
    }
}
