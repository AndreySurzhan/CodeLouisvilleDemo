namespace CodeLouisvilleDemo.Services
{
    internal class ComincBookService<ComicBookModel> : BaseService<ComicBookModel>
    {
        public ComincBookService(string fileName) : base(fileName)
        {
        }
    }
}
