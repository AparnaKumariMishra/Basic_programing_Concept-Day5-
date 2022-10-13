using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase9
{
    public class UC9Vowel_consonent
    {
        public static void VowelConst()
        {
            char ch;
            Console.Write("Input an Alphabet (A-Z or a-z) : ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.Write("You entered a number, Please enter an alpahbet.");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;

                    case 'A':
                        Console.WriteLine("The Alphabet is vowel");
                        break;

                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;

                    case 'I':
                        Console.WriteLine("The Alphabet is vowel");
                        break;

                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;

                    case 'O':
                        Console.WriteLine("The Alphabet is vowel");
                        break;


                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;

                    case 'U':
                        Console.WriteLine("The Alphabet is vowel");
                        break;


                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;

                    case 'E':
                        Console.WriteLine("The Alphabet is vowel");
                        break;

                    default:
                        Console.WriteLine("The Alphabet is Consonent");
                        break;
                }
            }
            Console.ReadKey();
        }
}
}
