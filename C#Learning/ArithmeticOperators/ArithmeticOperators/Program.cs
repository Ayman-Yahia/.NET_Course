using System;

namespace ArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int friends = 5;
            //friends += 1;
            //Console.WriteLine(friends);

            double x = 3.99;
            double y = 5;
            //double a = Math.Pow(x, 3);
            //double a = Math.Sqrt(x);
            //double c = Math.Abs(x);
            //double c = Math.Round(x);
            //double c = Math.Ceiling(x);
            //double c = Math.Floor(x);
            //double c = Math.Max(x, y);
            //double c = Math.Min(x, y);
            //Console.WriteLine(c);


            //Random Numbers
            Random random = new Random();
            //int num=random.Next(1,21);
            double num = random.NextDouble();
            Console.WriteLine(num);

            //hypotenuse calculator program:-
            Console.WriteLine("Enter side A");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter side B");
            double b = Convert.ToDouble(Console.ReadLine());
            double m = (Math.Sqrt(a * a)) +( Math.Sqrt(b * b));
            Console.WriteLine("the hypotenuse is "+m);

            Console.ReadKey();
        }
    }
}
