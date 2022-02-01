using CodeLouisvilleDemo;
using System;

namespace AlphabetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var methodNames = GetMethodNames(typeof(AlphabetUtils), "print").ToList();

            Console.WriteLine("Available methods:\n");

            for (int i = 0; i < methodNames.Count(); i++)
            {
                var methodNumber = i + 1;

                Console.WriteLine($"{methodNumber} - {methodNames[i]}");
            }

            Console.WriteLine("\n ==================================== \n ");

            Console.WriteLine("Enter method number:");

            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    AlphabetUtils.PrintAlphabet();

                    break;
                case 2:
                    AlphabetUtils.PrintAlphabetBackwards();

                    break;
                case 3:
                    AlphabetUtils.PrintAlphabetSkipOneLetter();

                    break;
                case 4:
                    AlphabetUtils.PrintAlphabetUsingWhileLoop();

                    break;
                case 5:
                    AlphabetUtils.PrintAlphabetBackwardsUsingWhileLoop();

                    break;
                case 6:
                    AlphabetUtils.PrintAlphabetSkipOneLetterUsingWhileLoop();

                    break;
                default:
                    Console.WriteLine("Invalid input");
               break;
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