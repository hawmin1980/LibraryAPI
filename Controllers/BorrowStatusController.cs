using LibraryAPI.Data;
using LibraryAPI.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("master")]
    public class BorrowStatusController : Controller
    {
        private readonly LibraryAPIContext _context;

        public BorrowStatusController(LibraryAPIContext context)
        {
            _context = context;
        }

        // GET: BorrowStatuses
        [HttpGet("borrowstatuses")]
        public IEnumerable<BorrowStatus> Index()
        {
            return _context.BorrowStatuses.ToList();
        }
    }
}
