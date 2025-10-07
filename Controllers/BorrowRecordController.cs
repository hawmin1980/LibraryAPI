using LibraryAPI.Data;
using LibraryAPI.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BorrowRecordController : Controller
    {
        private readonly LibraryAPIContext _context;

        public BorrowRecordController(LibraryAPIContext context)
        {
            _context = context;
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] BorrowRecord borrowRecord)
        {
            if (borrowRecord == null)
                return BadRequest("Borrow record cannot be null.");

            _context.BorrowRecords.Add(borrowRecord);
            _context.SaveChanges();
            return Ok(borrowRecord);
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var records = _context.BorrowRecords.ToList();
            return Ok(records);
        }
    }
}
