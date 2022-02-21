namespace CodeLouisvilleDemo.Interfaces
{
    internal interface IBaseService<T>
    {
        public string FilePath { get; set; }

        public IEnumerable<T> GetItemsByParialName(string name);

        public T GetItemById(int id);

        public T Cerate(T item);

        public T Update(T item);

        public bool DeleteById(int id);
    }
}
