using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Models.Entities
{
    public class EmployeeRole
    {
        [Key]
        public int EmployeeRoleId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("EmployeeRole")]
        public string EmployeeRoleName { get; set; }
    }
}
