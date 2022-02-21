using CodeLouisvilleDemo.Models;

namespace CodeLouisvilleDemo.Services
{
    internal class ComicBookService : BaseService<ComicBookModel>
    {
        public ComicBookService(string fileName) : base(fileName)
        {
        }
    }
}
