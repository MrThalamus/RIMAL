using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class M
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal(1, "trump", 3);
            a1.printDetailsA();

            Cat c1 = new Cat(2, "Biden", 4, "White");
            c1.printDetailsC();
            c1.printDetailsCC();
            c1.printDetailsAA();



            Console.ReadKey();  
        }
    }
}
