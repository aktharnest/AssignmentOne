using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Program6
    {
        static void Main(string[] args)
        {
            int rno;
            string name;
            int[] marks = new int[3];
            Console.Write("Enter Roll No = ");
            rno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name = ");
            name = Console.ReadLine();
            Console.Write("Enter Mark 1 = ");
            marks[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Mark 2 = ");
            marks[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Mark 3 = ");
            marks[2] = Convert.ToInt32(Console.ReadLine());
            double total = marks[0] + marks[1] + marks[2];
            double percentage = (total / 300) * 100;
            Console.WriteLine("Roll Number =" + rno);
            Console.WriteLine("Name =" + name);
            Console.WriteLine("Mark 1 =" + marks[0]);
            Console.WriteLine("Mark 2 =" + marks[1]);
            Console.WriteLine("Mark 3 =" + marks[2]);
            Console.WriteLine("Total =" + total);
            Console.WriteLine("Percentage =" + percentage + "%");
            Console.ReadLine();
        }

    }
}
