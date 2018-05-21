using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to get factorial");
            int inputnumn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((Program.Factorial(inputnumn)).ToString());
            Console.ReadLine();
        }
        public static int Factorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                return (num * Factorial(num - 1));
            }
        }
    }
}
