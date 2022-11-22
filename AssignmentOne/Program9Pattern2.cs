using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Program9Pattern2
    {
        static void Main(string[] args)
        {
            int n = 5;
            int blank = 0;
            for (int i = 5; i >= 0; i--)
            {
                for (int j = 1; j <= blank; j++)
                {
                    Console.Write(" ");
                }
                blank++;
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
