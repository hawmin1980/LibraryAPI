using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Models.Entities
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("Language")]
        public string LanguageDesc { get; set; }
    }
}
