using LibraryAPI.Data;
using LibraryAPI.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AudioBookController : MediaController<AudioBook>
    {
        public AudioBookController(LibraryAPIContext context) : base(context) { }
    }
}