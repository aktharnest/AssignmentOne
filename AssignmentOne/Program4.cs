using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Program4
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter Number = ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
                Console.WriteLine("Negative Number");
            else
                Console.WriteLine("Positive Number");
            Console.ReadLine();
        }

    }
}
