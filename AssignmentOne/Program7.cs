using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Program7
    {
        static void Main(String[] args)
        {
            int a = 6;
            Console.WriteLine("Multiplication Table");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", i, a, a * i);
            }
            Console.ReadLine();
        }

    }
}
