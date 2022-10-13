using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCorePrograming
{
    internal class UC1FlipCoin
    {
       public const int Head =0;
       public const int Tail =0;
       public static void flipcoin()
        {
           Random random = new Random();
            int coin = random.Next(0, 2);
            if (coin == Tail)
            {
                Console.WriteLine("The coin is Tail");
            }
            else
            { Console.WriteLine("The coin is Head"); }
            }
        }
    }
