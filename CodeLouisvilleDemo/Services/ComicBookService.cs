using AnotherDemo.Interfaces;
using CodeLouisvilleDemo.Models;

namespace CodeLouisvilleDemo.Services
{
    public class ComicBookService : BaseService<ComicBookModel>, IComicBookService
    {
        public ComicBookService(string fileName) : base(fileName)
        {
        }

        public IEnumerable<ComicBookModel> GetComicbooksBySeries(string series)
        {
            throw new NotImplementedException();
        }
    }
}
