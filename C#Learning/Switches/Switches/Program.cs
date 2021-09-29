using System;

namespace Switches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is it today?");
            String day = Convert.ToString(Console.ReadLine());
            switch (day)
            {
                case "monday":
                    Console.WriteLine("it is monday");
                    break;
                case "sunday":
                    Console.WriteLine("it is sunday");
                    break;
                case "tuesday":
                    Console.WriteLine("it is tuesday");
                    break;
                case "friday":
                    Console.WriteLine("it is friday");
                    break;
                case "thursday":
                    Console.WriteLine("it is thursday");
                    break;
                case "wednesday":
                    Console.WriteLine("it is wednesday");
                    break;
                case "saturday":
                    Console.WriteLine("it is saturday");
                    break;
                default:
                    Console.WriteLine(day+"");
                    break;
            }
            //logical operators
            Console.WriteLine("What's the temperature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("DO NOT GO OUTSIDE!");
            }

            // while loop = repeats some code while some condition remains true

            String name = "";

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }
    }
}
