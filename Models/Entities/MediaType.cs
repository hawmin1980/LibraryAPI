using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Models.Entities
{
    public class MediaType
    {
        [Key]
        public int MediaTypeId { get; set; }
        [Required]
        [MaxLength(100)]
        [Column("MediaType")]
        public string MediaTypeName { get; set; }
    }
}
