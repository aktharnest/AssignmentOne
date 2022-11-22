using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Program5
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter number 1 = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2 = ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
                Console.WriteLine("Numbers are equal");
            else
                Console.WriteLine("not equal");
            Console.ReadLine();
        }

    }
}
