using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class StringReverser
    {
        public static string Reverse(string input)
        {
            char[] characterArray = input.ToCharArray();
            string reversedInput = "";

            for (int i = characterArray.Length - 1; i >= 0; i--)
            {
                reversedInput += input[i];
            }

            return reversedInput;
        }
    }
}
