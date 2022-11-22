using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Program1
    {
        static void Main(string[] args)
        {

            int s = 0, r;
            Console.Write("Enter Number =");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                r = n % 10;
                s = s + r;
                n = n / 10;

            }
            Console.WriteLine("Sum = " + s);
            Console.ReadLine();
        }
    }
}
