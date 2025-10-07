using LibraryAPI.Data;
using LibraryAPI.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("master")]
    public class MediaTypeController : Controller
    {
        private readonly LibraryAPIContext _context;

        public MediaTypeController(LibraryAPIContext context)
        {
            _context = context;
        }

        // GET: MediaTypes
        [HttpGet("mediatypes")]
        public IEnumerable<MediaType> Index()
        {
            return _context.MediaTypes.ToList();
        }
    }
}
