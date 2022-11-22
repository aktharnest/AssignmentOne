using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Program9Pattern1
    {
        static void Main(string[] args)
        {
            int n = 5;
            int blank = n - 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= blank; j++)
                {
                    Console.Write(" ");
                }
                blank--;
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
