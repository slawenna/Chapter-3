using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            bool even = a % 2 == 0 ? true : false;
            Console.WriteLine("{0} is even? {1}", a, even);
        }
    }
}