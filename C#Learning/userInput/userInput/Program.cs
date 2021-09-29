using System;

namespace userInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("whats your name?");
            String name = Console.ReadLine();
            Console.WriteLine("whats your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hello " + name);
            Console.WriteLine("your age is right ? " + age);
            Console.ReadKey();
        }
    }
}
