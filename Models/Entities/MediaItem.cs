namespace LibraryAPI.Models.Entities
{
    public abstract class MediaItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int LanguageId { get; set; }
        public int GenreId { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
