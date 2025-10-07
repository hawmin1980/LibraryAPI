using LibraryAPI.Models.Entities;

namespace LibraryAPI.Interfaces
{
    public interface IMediaRepository<T> where T : MediaItem
    {
        void Add (T item);
        IEnumerable<T> GetAll ();
    }
}
