using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Ravi","Bhushan");
            Customer c2 = new Customer("Mohan", "Bhushan");
            Customer c3 = new Customer("Sohan", "Bhushan");
            Customer c = new Customer(c3);
            Console.ReadLine();
        }
    }
}
