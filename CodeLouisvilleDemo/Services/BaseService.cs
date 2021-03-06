using CodeLouisvilleDemo.Interfaces;
using System.Text.Json;

namespace CodeLouisvilleDemo.Services
{
    public class BaseService<T> : IBaseService<T>
    {
        private string FileName;


        public BaseService(string fileName)
        {
            FileName = fileName;
        }

        public async Task<T> CreateAsync(T item)
        {
            List<T> items = new List<T>();

            using (Stream stream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                if (File.Exists(FileName) && stream.Length > 0)
                {
                    items = await JsonSerializer.DeserializeAsync<List<T>>(stream) ?? new List<T>();                    
                }

                items.Add(item);

                stream.SetLength(0); // rewrite instead of appending to the stream

                var options = new JsonSerializerOptions { WriteIndented = true };

                await JsonSerializer.SerializeAsync(stream, items, options);
            }

            return item;
        }

        public async Task<IEnumerable<T>?> GetAllAsync()
        {
            if (File.Exists(FileName))
            {
                using FileStream stream = File.OpenRead(FileName);

                return await JsonSerializer.DeserializeAsync<IEnumerable<T>>(stream);
            }
            else
            {
                return null;
            }
        }
    }
}
