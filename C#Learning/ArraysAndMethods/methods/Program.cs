using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            singHappy("ahamd",15);
            // return  = returns data back to the place where a method is invoked
            double x;
            double y;
            double result;

            Console.WriteLine("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);

            Multiply(x);
            Console.WriteLine(result);

            Console.ReadKey();
        }
        static void singHappy(String birthdayBoy, int yearsOld)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + birthdayBoy);
            Console.WriteLine("You are " + yearsOld + " years old!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }
        static void Multiply(double x)
        {
            Console.WriteLine("sdsdsd"+x);
        }
    }
}
