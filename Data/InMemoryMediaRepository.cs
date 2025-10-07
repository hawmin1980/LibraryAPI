using LibraryAPI.Interfaces;
using LibraryAPI.Models.Entities;

namespace LibraryAPI.Data
{
    public class InMemoryMediaRepository<T> : IMediaRepository<T> where T : MediaItem
    {
        private readonly List<T> _items = new();
        
        public void Add(T item) => _items.Add(item);
        public IEnumerable<T> GetAll() => _items;
    }
}
