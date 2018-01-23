using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foorExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n\n\n");

            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 8; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n\n\n");

            for (int i = 8; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n\n\n");

            for (int i = 0; i < 8; i++)
            {
                for (int k = 8; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
