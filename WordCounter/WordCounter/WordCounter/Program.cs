using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            string testString =
                "I'm just not into trying to convince people like me. I always say to myself," +
                " It is what it is.' I walk into a situation knowing that people are either" +
                " going to love me or they're not, and that's OK." +
                " I'm just going to be me. You can't be everything to everyone.";

            Console.WriteLine("The total amount of words in the given string is: " + WordCounter.CountWords(testString));
            Console.WriteLine("------------------");
            Console.WriteLine("Press any key to exit the program..");
            Console.ReadKey();
        }
    }
}
