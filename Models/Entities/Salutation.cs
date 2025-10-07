using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Models.Entities
{
    public class Salutation
    {
        [Key]
        public int SalutationId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("Salutation")]
        public string SalutationDesc { get; set; }
    }
}
