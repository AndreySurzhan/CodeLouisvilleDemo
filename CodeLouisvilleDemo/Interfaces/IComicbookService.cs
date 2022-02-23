using CodeLouisvilleDemo.Interfaces;
using CodeLouisvilleDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherDemo.Interfaces
{
    public interface IComicBookService : IBaseService<ComicBookModel>
    {
        public IEnumerable<ComicBookModel> GetComicbooksBySeries(string series);
    }
}
