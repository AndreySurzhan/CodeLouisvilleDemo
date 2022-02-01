using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisvilleDemo
{
    public static class AlphabetUtils
    {
        public static void PrintAlphabet()
        {
            string alphabet = string.Empty;
            for (char alpha = 'A'; alpha <= 'Z'; alpha++)
            {
                alphabet += alpha;
            }

            Console.WriteLine(alphabet);
        }

        public static void PrintAlphabetBackwards()
        {
            string alphabet = string.Empty;
            for (char alpha = 'Z'; alpha >= 'A'; alpha--)
            {
                alphabet += alpha;
            }

            Console.WriteLine(alphabet);
        }

        public static void PrintAlphabetSkipOneLetter()
        {
            string alphabet = string.Empty;
            for (char alpha = 'A'; alpha <= 'Z'; alpha = (char)(alpha + 2))
            {
                alphabet += alpha;
            }

            Console.WriteLine(alphabet);
        }

        public static void PrintAlphabetUsingWhileLoop()
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

        public static void PrintAlphabetBackwardsUsingWhileLoop()
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

        public static void PrintAlphabetSkipOneLetterUsingWhileLoop()
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
