using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Models.Entities
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("Country")]
        public string CountryDesc { get; set; }
    }
}
