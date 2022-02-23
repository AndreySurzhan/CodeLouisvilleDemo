namespace CodeLouisvilleDemo.Interfaces
{
    public interface IBaseService<T>
    {
        public Task<T> CreateAsync(T item);

        public Task<IEnumerable<T>?> GetAllAsync();
    }
}
