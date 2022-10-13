using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase3PowerOf2
{
    internal class UC3Powerof2
    {
        public static void power()
        {
            int i, n;

            Console.Write("\n\n");
            Console.Write("Display the multiplication table:\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number for which you want to print the table : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} X {1} = {2} \n", n, i, n * i);
            }
        }
    }
}
