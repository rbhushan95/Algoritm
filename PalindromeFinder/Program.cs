using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPalindrom = false;
            Console.WriteLine("Enter the word to check for the Palindrome");
            char[] inputValue = Convert.ToString(Console.ReadLine()).ToCharArray();

            int getThemidLength = (inputValue.Length) / 2;

            for (int i = 0; i <= getThemidLength - 1; i++)
            {
                Console.WriteLine(inputValue[(inputValue.Length - 1) - i] + "" + inputValue[i]);
                if (inputValue[(inputValue.Length - 1) - i] == inputValue[i])
                {
                    isPalindrom = true;
                    continue;
                }
                else
                {
                    isPalindrom = false;
                    break;
                }
            }
            if (isPalindrom)
            {
                Console.WriteLine("Yes given string is Palindrom");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("given string  is not a Palindrom");
                Console.ReadLine();
            }
        }
    }
}
