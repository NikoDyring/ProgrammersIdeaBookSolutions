using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("WELCOME TO THE STRING REVERSER! \n Try it out by writing a sentence, a paragraph or just a single word!");
            string userInput = Console.ReadLine();

            Console.WriteLine(StringReverser.Reverse(userInput));
            Console.WriteLine("--------------------------");
            Console.WriteLine("Hope I got it right ;)");
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();

        }
    }
}
