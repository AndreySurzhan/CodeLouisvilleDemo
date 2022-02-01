using CodeLouisvilleDemo;
using System;

namespace AlphabetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Available methods:\n");

            Console.WriteLine(@"
            1 - PrintAlphabet
            2 - PrintAlphabetBackwards
            3 - PrintAlphabetSkipOneLetter
            4 - PrintAlphabetUsingWhileLoop
            5 - PrintAlphabetBackwardsUsingWhileLoop
            6 - PrintAlphabetSkipOneLetterUsingWhileLoop");

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

    }
}