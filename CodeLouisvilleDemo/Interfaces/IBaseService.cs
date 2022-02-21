using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisvilleDemo.Interfaces
{
    internal interface IBaseService<T>
    {
        public IEnumerable<T> GetItemsByParialName(string name);

        public T GetItemById(int id);

        public T Cerate(T item);

        public T Update(T item);

        public bool DeleteById(int id);
    }
}
