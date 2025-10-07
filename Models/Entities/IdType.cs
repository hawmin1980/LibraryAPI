using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Models.Entities
{
    public class IdType
    {
        [Key]
        public int IdTypeId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("IdType")]
        public string IdTypeDesc { get; set; }
    }
}
