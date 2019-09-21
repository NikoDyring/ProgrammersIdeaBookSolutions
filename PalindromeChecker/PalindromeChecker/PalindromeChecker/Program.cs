using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE PALINDROME CHECKER!\n" +
                              "Type in your word you want to have checked if it's a\n" +
                              "palindrome or not!");
            Console.WriteLine("--------------------------");
            string input = Console.ReadLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine(PalindromeChecker.Check(input));
            Console.WriteLine("Press any key to close the program..");
            Console.ReadKey();


        }
    }
}
