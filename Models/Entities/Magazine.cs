namespace LibraryAPI.Models.Entities
{
    public class Magazine : MediaItem
    {
        public string IssueNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}
