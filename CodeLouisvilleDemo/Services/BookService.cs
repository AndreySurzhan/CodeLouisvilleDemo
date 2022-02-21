using CodeLouisvilleDemo.Interfaces;
using CodeLouisvilleDemo.Models;

namespace CodeLouisvilleDemo.Services
{
    internal class BookService : IBaseService<BookModel>
    {
        public string FilePath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public BookModel Cerate(BookModel item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public BookModel GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookModel> GetItemsByParialName(string name)
        {
            throw new NotImplementedException();
        }

        public BookModel Update(BookModel item)
        {
            throw new NotImplementedException();
        }
    }
}
