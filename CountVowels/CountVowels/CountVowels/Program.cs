using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            int languageId = 0;

            Console.WriteLine("WELCOME TO THE ALL MIGHTY VOWEL COUNTER! \n" +
                              "Currently the following Languages are supported: \n" +
                              "Danish, English'");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Enter the desired language id for the vowel you want to provide.\n" +
                              "1 for Danish. \n" +
                              "2 for English.");
            Console.WriteLine("------------------------------------");
            languageId = Int32.Parse(Console.ReadLine());
            switch (languageId)
            {
                default:
                    break;

                case 1:
                    Console.WriteLine("Skriv et ord med en eller flere vokaler!");
                    string input = Console.ReadLine();
                    Console.WriteLine(VowelCounter.CountDanishVowels(input.ToLower()));
                    break;

                case 2:
                    Console.WriteLine("Enter your almighty word! And I will count the number of weak vowels!");
                    string userInput = Console.ReadLine();
                    Console.WriteLine(VowelCounter.CountEnglishVowels(userInput.ToLower()));
                    break;
            }

            Console.WriteLine("Press any key to close the program..");
            Console.ReadKey();






        }
    }
}
