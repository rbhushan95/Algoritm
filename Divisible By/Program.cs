using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible_By
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("number is div by 3 and 5");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("number is div by 3");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("number is div by 5");
            }

            Console.ReadLine();
        }


    }
}
