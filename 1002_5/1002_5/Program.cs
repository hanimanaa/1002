using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
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

            switch (ch)
            {
                case '+':
                    t = x + y;
                    Console.WriteLine(" " + x + " + " + y + " = " + t);
                    break;
                case '-':
                    t = x - y;
                    Console.WriteLine(" " + x + " - " + y + " = " + t);
                    break;
                case '*':
                    t = x * y;
                    Console.WriteLine(" " + x + " * " + y + " = " + t);
                    break;
                case '/':
                    t = x / y;
                    Console.WriteLine(" " + x + " / " + y + " = " + t);
                    break;
                default:
                    Console.WriteLine("Error !!!");
                    break;
            }



            Console.ReadKey();


        }
    }
}