namespace LibraryAPI.Models.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int SalutationId { get; set; }
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public int IdTypeId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int Nationality { get; set; }
        public int EmployeeRoleId { get; set; }
        public int SupervisorId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}
