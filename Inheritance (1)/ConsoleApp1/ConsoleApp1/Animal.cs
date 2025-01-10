using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        private int id;
        private string name;
        private int age;

        public Animal(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public void setId(int id)
        {  this.id = id; }
        public void setName(string name) 
        { this.name = name;}
        public void setAge(int age)
        {  this.age = age;}

        public int getId() { return this.id;}
        public string getName() { return this.name;}
        public int getAge() { return this.age;}

        public void printDetailsA() 
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("----------------");
        }

        public virtual void printDetailsAA()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("----------------");
        }

    }
}
