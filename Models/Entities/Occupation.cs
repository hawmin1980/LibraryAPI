using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Models.Entities
{
    public class Occupation
    {
        [Key]
        public int OccupationId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("Occupation")]
        public string OccupationDesc { get; set; }
    }
}
