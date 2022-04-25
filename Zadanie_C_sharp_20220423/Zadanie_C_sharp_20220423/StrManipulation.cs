using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_C_sharp_20220423
{
    public class StrManipulation
    {
        public static string RemoveSubFromBase(string baseString, string subString)
        {
            string resultString = baseString.Replace(subString, "");

            return resultString;
        }

        public static bool IsAnagram(string baseStringAnagram1, string baseStringAnagram2)
        {
            bool result = false;
            string stringTest1 = Alphabetize(baseStringAnagram1);
            string stringTest2 = Alphabetize(baseStringAnagram2);

            if (stringTest1 == stringTest2)
            {
                result = true;
            }

            return result;
        }

        public static string Alphabetize(string s)
        {

            // Convert to char array.
            var a = s.ToLower().ToCharArray();

            Array.Sort(a);
            // Sort letters.
            string newString = new string(a);

            // Return modified string.
            return newString;
        }


        public static Dictionary<char, int> CountStringLetters(string duplicateString)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            var charArray = duplicateString.ToLower().ToCharArray();

            foreach (char c in charArray)
            {
                if (!result.ContainsKey(c) && !Char.IsWhiteSpace(c))
                {
                    result.Add(c, 1);
                }
                else if (!Char.IsWhiteSpace(c))
                {
                    result[c] += 1;
                }

            }

            return result;
        }

        public static string Reverse(string exampleString)
        {
            var charString = exampleString.ToCharArray();
            var sb = new StringBuilder();

            for (int i = charString.Length-1; i >= 0; i--)
            {
                sb.Append(charString[i]);
            }

            return sb.ToString();
        }

        public static bool IsPalindrome(string palindrome)
        {
            bool isPalindrome = false;
            string reversed = StrManipulation.Reverse(palindrome.ToLower());

            var sb1 = RemoveWhiteSpacesFromString(palindrome.ToLower());
            var sb2 = RemoveWhiteSpacesFromString(reversed);

            if (sb1.ToString() == sb2.ToString())
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }

        private static StringBuilder RemoveWhiteSpacesFromString(string palindrome)
        {
            var sb = new StringBuilder();
            foreach (char c in palindrome)
            {
                if (!Char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }

            return sb;
        }

        public static Dictionary<char, int> IsDuplicate(string duplicateString)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            Dictionary<char, int> analyzedStringDictionary = StrManipulation.CountStringLetters(duplicateString);

            foreach (KeyValuePair<char, int> keyValuePair in analyzedStringDictionary)
            {
                if (analyzedStringDictionary[keyValuePair.Key] > 1)
                {
                    result.Add(keyValuePair.Key, keyValuePair.Value);
                }
            }
            return result;
        }


        
        


    }
}
