using CodeLouisvilleDemo;
using System;
using System.Reflection;

namespace AlphabetDemo
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var methodNames = GetMethodNames(typeof(AlphabetUtils), "print").ToList();
            var methodNamesCollectionSize = methodNames.Count;

            Console.WriteLine("Available methods:\n");

            for (int i = 0; i < methodNamesCollectionSize; i++)
            {
                var methodNumber = i + 1;

                Console.WriteLine($"{methodNumber} - {methodNames[i]}");
            }

            Console.WriteLine("\n ==================================== \n ");

            Console.WriteLine("Enter method number:");

            var userInput = Convert.ToInt32(Console.ReadLine());
            

            if (userInput > methodNamesCollectionSize || userInput < 1)
            {
                Console.WriteLine("invalid user input");
            } else
            {
                var methodIndex = userInput - 1;
                var methodName = methodNames[methodIndex];
                var method = typeof(AlphabetUtils).GetMethod(methodName);

                method?.Invoke(null, null);
            }
        }

        //TASK: Possible to starn app and have promt displaying list of available methods to run. 
        // Promt should ask a question which method to run
        // input corresponding number or name of the method
        //1. move methods to separate class file
        //2. Create method that prints out method names
        //3. Create logic to print out method names with question
        //4. Create logic to accept user's input 
        //5. based on user's input we should run method or promt an validation error
        private static IEnumerable<string> GetMethodNames(Type type, string? containSubstring = default)
        {
            List<string> methodNames = new List<string>();

            var methodInfos = type.GetMethods();

            foreach (var methodInfo in methodInfos)
            {
                var name = methodInfo.Name;

                if (!string.IsNullOrEmpty(containSubstring) && !name.ToLower().Contains(containSubstring))
                {
                    continue;
                }

                methodNames.Add(methodInfo.Name);
            }

            return methodNames;
        }
    }
}