using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    class PalindromeChecker
    {
        private static string _secondPart;

        public static string Check(string input)
        {
            char[] characterArray = input.ToCharArray();

            Array.Reverse(characterArray);
            _secondPart = new string(characterArray);

            bool isPalindrome = input.Equals(_secondPart.ToLower());
            if (isPalindrome)
            {
                return input + " is a palindrome!";
            }
            else
            {
                return input + " is not a palindrome!";
            }
        }


    }
}
