using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cat : Animal
    {
        private string color;

        public Cat(int id,  string name, int age, string color): base(id,name,age)
        {
            this.color = color;
        }

        public void setColor(string color) 
        {
            this.color = color;
        }
        public string getColor() 
        {
            return this.color;
        }

        public void printDetailsC()
        {
            Console.WriteLine("Id: " + base.getId());
            Console.WriteLine("Name: " + base.getName());
            Console.WriteLine("Age "+base.getAge());
            Console.WriteLine("Color: " + color);
            Console.WriteLine("---------------------");
        }

        public void printDetailsCC()
        {
            base.printDetailsA();
            Console.WriteLine("Color: " + color);
            Console.WriteLine("---------------------");
        }

        public override void printDetailsAA()
        {
            base.printDetailsA();
            Console.WriteLine("Color: " + color);
            Console.WriteLine("---------------------");
        }

    }
}
