namespace LibraryAPI.Models.Entities
{
    public class Member
    {
        public long MemberId { get; set; }
        public int SalutationId { get; set; }
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public int IdTypeId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int Nationality { get; set; }
        public int OccupationId { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
