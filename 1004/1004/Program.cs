using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, t;
            char ch;

            Console.WriteLine(" ad5el al3dad 1 : ");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine(" ad5el al3mlyah : ");
            ch = char.Parse(Console.ReadLine());

            Console.WriteLine(" ad5el al3dad 2 : ");
            y = double.Parse(Console.ReadLine());

            if (ch == '+')
            {
                t = x + y;
                Console.WriteLine(" " + x + " + " + y + " = " + t);
            }

            if (ch == '-')
            {
                t = x - y;
                Console.WriteLine(" " + x + " - " + y + " = " + t);
            }

            if (ch == '*')
            {
                t = x * y;
                Console.WriteLine(" " + x + " * " + y + " = " + t);
            }

            if (ch == '/')
            {
                t = x / y;
                Console.WriteLine(" " + x + " / " + y + " = " + t);
            }



            Console.ReadKey(); 






        }
    }
}