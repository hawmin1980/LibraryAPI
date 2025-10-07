namespace LibraryAPI.Models.Entities
{
    public class Book : MediaItem
    {
        public string Isbn { get; set; }
        public string BookAuthor { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}
