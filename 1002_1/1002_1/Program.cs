using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    { 
        static void Main(string[] args)
        {
            string name;
            double age;

            Console.WriteLine(" ad5el name : ");
            name = Console.ReadLine();
            Console.WriteLine(" ad5el age : ");
            age = double.Parse(Console.ReadLine());

            Console.WriteLine(name + " 3omroho " + age + " snen :P");

            Console.ReadKey();
        }
    }
}