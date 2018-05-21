using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Very_Big_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
            ;
            long result = aVeryBigSum(n, ar);

            tw.WriteLine(result);

            tw.Flush();
            tw.Close();
        }

        public static long aVeryBigSum(int n, long[] ar)
        {
            long l = 0;

            if (n == ar.Length)
            {

            }
            

            return l;
        }
    }
}
