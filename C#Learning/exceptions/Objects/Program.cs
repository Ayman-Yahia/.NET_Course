using System;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Human ahmad = new Human();
            ahmad.sleep();
            ahmad.name = "ahmad";
            Console.ReadKey();
        }
    }
    class Human
    {
        public String name;
        public int age;
        public void eat()
        {
            Console.WriteLine(name + " is eating");

        }
        public void sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}
