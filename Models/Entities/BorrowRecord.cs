namespace LibraryAPI.Models.Entities
{
    public class BorrowRecord
    {
        public Guid Id { get; set; }
        public long MemberId { get; set; }
        public int MediaTypeId { get; set; }
        public Guid MediaId { get; set; }
        public DateTime BorrowingDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int BorrowStatusId { get; set; }
        public double? Fine { get; set; }
        public string? Remark { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}
