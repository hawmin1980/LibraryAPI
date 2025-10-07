using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Models.Entities
{
    public class BorrowStatus
    {
        [Key]
        public int BorrowStatusId { get; set; }
        [Required]
        [MaxLength(100)]
        [Column("BorrowStatus")]
        public string StatusName { get; set; }
    }
}
