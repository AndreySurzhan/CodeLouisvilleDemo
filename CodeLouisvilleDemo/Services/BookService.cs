using AnotherDemo.Interfaces;
using CodeLouisvilleDemo.Models;

namespace CodeLouisvilleDemo.Services
{
    public class BookService : BaseService<BookModel>, IBookService
    {
        public BookService(string fileName) : base(fileName)
        {
        }

        public IEnumerable<BookModel> GetBooksByCoverType(string coverType)
        {
            throw new NotImplementedException();
        }
    }
}
