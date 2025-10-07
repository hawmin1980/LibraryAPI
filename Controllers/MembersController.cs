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
    public class MembersController : Controller
    {
        private readonly LibraryAPIContext _context;

        public MembersController(LibraryAPIContext context)
        {
            _context = context;
        }

        // GET: Books
        [HttpGet(Name = "GetAllMembers")]
        public IEnumerable<Member> Index()
        {
            return _context.Members.ToList();
        }

        /// <summary>
        /// Add a new member.
        /// </summary>
        [HttpPost("add")]
        public async Task<ActionResult<Member>> AddMember([FromBody] Member member)
        {
            _context.Members.Add(member);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMemberById), new { id = member.MemberId }, member);
        }

        /// <summary>
        /// Edit an existing member.
        /// </summary>
        [HttpPut("edit/{id}")]
        public async Task<IActionResult> EditMember(long id, [FromBody] Member updatedMember)
        {
            var member = await _context.Members.FindAsync(id);
            if (member == null) return NotFound();

            member.SalutationId = updatedMember.SalutationId;
            member.Name = updatedMember.Name;
            member.IdNumber = updatedMember.IdNumber;
            member.IdTypeId = updatedMember.IdTypeId;
            member.DateOfBirth = updatedMember.DateOfBirth;
            member.Gender = updatedMember.Gender;
            member.Nationality = updatedMember.Nationality;
            member.OccupationId = updatedMember.OccupationId;
            member.JoinDate = updatedMember.JoinDate;
            member.ModifiedDate = DateTime.Now;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        /// <summary>
        /// Delete a member by ID.
        /// </summary>
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteMember(long id)
        {
            var member = await _context.Members.FindAsync(id);
            if (member == null) return NotFound();

            _context.Members.Remove(member);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        /// <summary>
        /// Get a member by ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<Member>> GetMemberById(long id)
        {
            var member = await _context.Members.FindAsync(id);
            if (member == null) return NotFound();
            return member;
        }
    }
}
