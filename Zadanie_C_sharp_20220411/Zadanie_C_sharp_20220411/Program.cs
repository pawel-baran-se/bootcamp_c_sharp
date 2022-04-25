using System;


namespace Zadanie_C_sharp_20220411
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToAsci();
        }

        private static void ToAsci()
        {
            char providedKeyChar;
            bool doWhile = true;
            do
            {
                Console.WriteLine("Please press any key, program will check if the key is digid or functional kay, \notherwise will return ASCI number:\n");
                var providedKey = Console.ReadKey();
                Console.WriteLine();
                providedKeyChar = providedKey.KeyChar;
                if (char.IsDigit(providedKeyChar) == true)
                {
                    Console.WriteLine("Key is digid");
                }
                else if (char.IsControl(providedKeyChar) == true)
                {
                    Console.WriteLine("Is a functional kay");
                }
                else if (providedKeyChar == 'q' || providedKeyChar == 'Q')
                {
                    break;
                }
                else
                {
                    Console.WriteLine((int)providedKeyChar);
                }
                doWhile = Menu(doWhile);
            } while (doWhile);
        }

        private static bool Menu(bool doWhile)
        {
            Console.WriteLine("\nPress any key to continue or [q] to exit:");
            var menuKey = Console.ReadKey();
            char menuKeyChar = menuKey.KeyChar;
            if (menuKeyChar == 'q' || menuKeyChar == 'Q')
            {
                doWhile = false;
            }
            else
            {
                Console.Clear();
            }

            return doWhile;
        }
    }
}
