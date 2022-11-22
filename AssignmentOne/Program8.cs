using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Program8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N =");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int s = 0;
            Console.WriteLine("Odd Numbers");
            while (i <= n)
            {
                Console.WriteLine(i);
                s = s + i;
                i = i + 2;
            }
            Console.WriteLine("Sum = " + s);
            Console.ReadLine();
        }

    }
}
