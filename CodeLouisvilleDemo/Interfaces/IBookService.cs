using CodeLouisvilleDemo.Interfaces;
using CodeLouisvilleDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherDemo.Interfaces
{
    public interface IBookService : IBaseService<BookModel>
    {
        public IEnumerable<BookModel> GetBooksByCoverType(string coverType);
    }
}
