using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmStrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three degit armstrong number 
            Console.WriteLine("Starting time " + DateTime.Now.ToString());
            //XYZ = (X^3+Y^3+Z^3) possible 101 to 999
            int mainNumber = 0;
            int armQB = 0;

            int FirstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;

            int FirstNumberQb = 0;
            int secondNumberQb = 0;
            int thirdNumberQb = 0;

            for (int i = 100; i < 1000; i++)
            {
                mainNumber = 0;
                armQB = 0;
                FirstNumber = 0;
                secondNumber = 0;
                thirdNumber = 0;

                FirstNumberQb = 0;
                secondNumberQb = 0;
                thirdNumberQb = 0;

                mainNumber = i;
                string numberString = (i).ToString();
                char[] chr = numberString.ToCharArray();
                FirstNumber = Convert.ToInt32(char.GetNumericValue(chr[0]));
                secondNumber = Convert.ToInt32(char.GetNumericValue(chr[1]));
                thirdNumber = Convert.ToInt32(char.GetNumericValue(chr[2]));

                FirstNumberQb = (FirstNumber * FirstNumber) * FirstNumber;
                secondNumberQb = (secondNumber * secondNumber) * secondNumber;
                thirdNumberQb = (thirdNumber * thirdNumber) * thirdNumber;

                armQB = (FirstNumberQb + secondNumberQb + thirdNumberQb);
                if (mainNumber == armQB)
                {
                    Console.WriteLine(i.ToString());
                Console.WriteLine("armQB" + armQB.ToString());
                }
                //Console.WriteLine(i.ToString());
            }
            Console.WriteLine("completed");
            Console.ReadLine();
        }
    }
}
