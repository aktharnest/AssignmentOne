using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Program3
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter Number 1 = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 3 = ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("{0} is Largest", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("{0} is Largest", b);
            }
            else
            {
                Console.WriteLine("{0} is Largest", c);
            }
            Console.ReadLine();
        }
    }
}
