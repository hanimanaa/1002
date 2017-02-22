using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
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

            if (age >= 18)
            {
                Console.WriteLine(name + " 7maaaar :p");
            }
            else
            {
                Console.WriteLine(name + " msh 7maaaar :D");
            }


            Console.ReadKey(); 

        }
    }
}