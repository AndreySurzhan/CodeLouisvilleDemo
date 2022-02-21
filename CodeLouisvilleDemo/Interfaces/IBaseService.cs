namespace CodeLouisvilleDemo.Interfaces
{
    internal interface IBaseService<T>
    {
        public Task<T> CreateAsync(T item);

        public Task<IEnumerable<T>?> GetAllAsync();
    }
}
