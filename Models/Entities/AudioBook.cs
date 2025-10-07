namespace LibraryAPI.Models.Entities
{
    public class AudioBook : MediaItem
    {
        public string Narrator { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}
