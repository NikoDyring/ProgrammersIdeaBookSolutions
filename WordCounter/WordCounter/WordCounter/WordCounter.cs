using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCounter
{
    class WordCounter
    {

        public static int CountWords(string s)
        {
            // By using the Regex method "Matches" we can check our input for patterns. In this case, looking for whitespaces (/s).
            MatchCollection collection = Regex.Matches(s, @"[\S]+");
            return collection.Count;
        }

    }
}
