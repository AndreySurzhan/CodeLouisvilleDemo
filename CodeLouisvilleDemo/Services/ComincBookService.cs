using CodeLouisvilleDemo.Interfaces;
using CodeLouisvilleDemo.Models;

namespace CodeLouisvilleDemo.Services
{
    internal class ComincBookService : IBaseService<ComicBookModel>
    {
        public string FilePath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ComicBookModel Cerate(ComicBookModel item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public ComicBookModel GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ComicBookModel> GetItemsByParialName(string name)
        {
            throw new NotImplementedException();
        }

        public ComicBookModel Update(ComicBookModel item)
        {
            throw new NotImplementedException();
        }
    }
}
