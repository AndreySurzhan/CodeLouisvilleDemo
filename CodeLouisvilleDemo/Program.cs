using CodeLouisvilleDemo;
using CodeLouisvilleDemo.Models;
using CodeLouisvilleDemo.Services;
using System;
using System.Reflection;

namespace AlphabetDemo
{
    class Program
    {
        

        static async Task Main(string[] args)
        {
            Console.WriteLine("Title:");

            var title = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Description:");

            var description = Convert.ToString(Console.ReadLine());

            Console.WriteLine("NumberOfPages:");

            var numberOfPages = Convert.ToInt32(Console.ReadLine());

            var book = new BookModel()
            {
                Title = title,
                Description = description,
                NumberOfPages = numberOfPages
            };

            var bookService = new BookService("books.json");

            _ = await bookService.CreateAsync(book);

        }

    }
}