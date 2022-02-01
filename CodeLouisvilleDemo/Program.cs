using System;

namespace AlphabetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAlphabet();

            PrintAlphabetBackwards();

            PrintAlphabetSkipOneLetter();

            // these are just examples of same thing 
            // using while loops instead of for loops

            PrintAlphabetUsingWhileLoop();

            PrintAlphabetBackwardsUsingWhileLoop();

            PrintAlphabetSkipOneLetterUsingWhileLoop();

        }
        //TASK: Possible to starn app and have promt displaying list of available methods to run. 
        // Promt should ask a question which method to run
        // input corresponding number or name of the method
        //1. move methods to separate class file
        //2. Create method that prints out method names
        //3. Create logic to print out method names with question
        //4. Create logic to accept user's input 
        //5. based on user's input we should run method or promt an validation error

        static void PrintAlphabet()
        {
            string alphabet = string.Empty;
            for (char alpha = 'A'; alpha <= 'Z'; alpha++)
            {
                alphabet += alpha;
            }

            Console.WriteLine(alphabet);
        }

        static void PrintAlphabetBackwards()
        {
            string alphabet = string.Empty;
            for (char alpha = 'Z'; alpha >= 'A'; alpha--)
            {
                alphabet += alpha;
            }

            Console.WriteLine(alphabet);
        }

        static void PrintAlphabetSkipOneLetter()
        {
            string alphabet = string.Empty;
            for (char alpha = 'A'; alpha <= 'Z'; alpha = (char)(alpha + 2))
            {
                alphabet += alpha;
            }

            Console.WriteLine(alphabet);
        }

        static void PrintAlphabetUsingWhileLoop()
        {
            string alphabet = string.Empty;
            char alpha = 'A';
            while (alpha <= 'Z')
            {
                alphabet += alpha++;

                // above line in same as this.  C# programmers like to cram as much into one line as possible :)
                //alphabet += alpha;
                //alpha++;

                // it's also the same as.  but you have that ugly cast operation
                //alphabet = alphabet + alpha;
                //alpha = (char)(alpha + 1);
            }

            Console.WriteLine(alphabet);
        }

        static void PrintAlphabetBackwardsUsingWhileLoop()
        {
            string alphabet = string.Empty;
            char alpha = 'Z';
            while (alpha >= 'A')
            {
                alphabet += alpha--;

                // same as
                //alphabet += alpha;
                //alpha--;

                //and
                //alphabet = alphabet + alpha;
                //alpha = (char)(alpha - 1);
            }

            Console.WriteLine(alphabet);
        }

        static void PrintAlphabetSkipOneLetterUsingWhileLoop()
        {
            string alphabet = string.Empty;
            char alpha = 'A';
            while (alpha <= 'Z')
            {
                alphabet += alpha;
                alpha = (char)(alpha + 2);
            }

            Console.WriteLine(alphabet);
        }
    }
}