using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountVowels
{
    class VowelCounter
    {

        public static string CountDanishVowels(string input)
        {
            Dictionary<string, int> danishVowelsDictionary = new Dictionary<string, int>()
            {
                {"a", 0 }, {"e", 0}, {"i", 0}, {"o", 0}, {"u", 0}, {"y", 0}, {"æ", 0}, {"ø", 0}, {"å", 0}
            };

            int totalVowels = 0;
            char[] characterArray = input.ToCharArray();

            foreach (char vowel in characterArray)
            {
                if (danishVowelsDictionary.ContainsKey(vowel.ToString()))
                {
                    danishVowelsDictionary[vowel.ToString()]++;
                    totalVowels++;
                    
                }
            }


            return $"Total amount of danish vowels in your input was {totalVowels}.";
        }

        public static string CountEnglishVowels(string input)
        {
            Dictionary<string, int> englishVowelsDictionary = new Dictionary<string, int>()
            {
                {"a", 0 }, {"e", 0}, {"i", 0}, {"o", 0}, {"u", 0}, {"y", 0}
            };

            int totalVowels = 0;
            char[] characterArray = input.ToCharArray();

            foreach (char vowel in characterArray)
            {
                if (englishVowelsDictionary.ContainsKey(vowel.ToString()))
                {
                    englishVowelsDictionary[vowel.ToString()]++;
                    totalVowels++;
                }
            }

            return $"Total amount of english vowels in your input was {totalVowels}";
        }

        

    }
}
