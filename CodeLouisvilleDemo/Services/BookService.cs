using CodeLouisvilleDemo.Models;

namespace CodeLouisvilleDemo.Services
{
    internal class BookService : BaseService<BookModel>
    {
        public BookService(string fileName) : base(fileName)
        {
        }
    }
}
