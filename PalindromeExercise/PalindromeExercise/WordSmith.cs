using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsPalindrome(string word)
        {
            var charArray = word.ToCharArray();
            Array.Reverse(charArray);
            var reversed = new string(charArray);
            var isPalindrome = word.Equals(reversed, StringComparison.OrdinalIgnoreCase);
            return isPalindrome;
        }
    }
}
