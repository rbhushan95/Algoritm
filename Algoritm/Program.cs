using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of series");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[number];
            x[0] = 0;
            x[1] = 1;

            for (int i = 2; i < number; i++)
            {
                x[i] = x[i - 1] + x[i - 2];
            }

            foreach (var item in x)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
