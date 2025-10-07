using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Models.Entities
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("Genre")]
        public string GenreDesc { get; set; }
    }
}
