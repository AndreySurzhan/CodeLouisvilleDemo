namespace CodeLouisvilleDemo.Models
{
    internal class BaseModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int NumberOfPages { get; set; }

        public string Author { get; set; }

        public IEnumerable<string> Genre { get; set; }
    }
}
