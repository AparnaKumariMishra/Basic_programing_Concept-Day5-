using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase8EvenOrOdd
{
    public class UC8EvenOdd
    {
        public static void evenodd()
        {
            int n;

            Console.WriteLine("Enter a number to check wether the no is even or odd : ");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " is an even number");
            }
            else
            {
                Console.WriteLine(n + " is an odd number");
            }
        }
    }
}
