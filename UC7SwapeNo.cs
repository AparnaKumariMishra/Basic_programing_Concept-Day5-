using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase7SwapeNo
{
    internal class UC7SwapeNo
    {
        public static void swape()
        {
            int a, b;
            Console.WriteLine("Please enter your first no: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second no: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;      
            b = a / b;    
            a = a / b;   
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}
