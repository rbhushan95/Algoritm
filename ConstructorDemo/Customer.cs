using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Customer
    {
        private static string _id;
        private int Counter;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        static Customer()
        {
            _id = Guid.NewGuid().ToString();
            Console.WriteLine("static one");
        }
        private Customer(int counter)
        {
            //Counter = 10;
            Counter = counter;
            Console.WriteLine("Private one" + Counter);
        }
        public Customer(Customer cust)
        {
            Console.WriteLine("Copy one" + Counter);
        }
        public Customer(string firstname, string lastname) : this(100)
        {
            Counter = Counter++;

            this.FirstName = firstname;
            this.LastName = lastname;
            Console.WriteLine("parameterized one" + Counter);
        }
        //public Customer(string str) : this(int.Parse(str))
        //{
        //}
    }
}
