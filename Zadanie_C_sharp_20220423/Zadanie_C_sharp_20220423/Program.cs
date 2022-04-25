using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_C_sharp_20220423
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string baseString = " Ala ma kota , a kot ma Ale ";
            string subString = "kot";
            

            //First Exercise #1
            string edBase = StrManipulation.RemoveSubFromBase(baseString, subString);
            Console.WriteLine($"Removed \"{subString}\" from \"{baseString}\" = {edBase}" + "\n");

            //First Exercise #2
            Console.WriteLine(baseString.Trim() + "\n");

            //Third Exercise #3
            string baseStringAnagram1 = "aakr";
            string baseStringAnagram2 = "kara";
            bool isAnagram = StrManipulation.IsAnagram(baseStringAnagram1, baseStringAnagram2);
            Console.WriteLine($"Is \"{baseStringAnagram1}\" and \"{baseStringAnagram2}\" anagram?: {isAnagram}\n");


            //Fourth Exercise #4
            string exampleString = "Ala ma kota";
            Dictionary<char, int> isDuplicate = StrManipulation.IsDuplicate(exampleString);
            foreach (KeyValuePair<char, int> keyValuePair in isDuplicate)
            {
                Console.WriteLine($"{keyValuePair.Key} : {keyValuePair.Value}");
            }

            //Fifth Exercise #5
            string reversedString = StrManipulation.Reverse(exampleString);
            Console.WriteLine("\n" +reversedString + "\n");

            //Sixth exercise #6
            string palindrome = "Ile Roman ładny dyndał na moreli";
            bool isPalindrome = StrManipulation.IsPalindrome(palindrome);
            Console.WriteLine($"Is \"{palindrome}\" palindrome? {isPalindrome}");



        }



    }
}
