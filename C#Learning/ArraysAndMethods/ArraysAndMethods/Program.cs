using System;

namespace ArraysAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //String[] cars = { "BMW", "skoda" };
            String[] cars = new string[3];
            cars[0] = "Tesla";
            cars[1] = "BMW";
            cars[2] = "audi";
            /*for (int i=0;i<cars.Length;i++)
            {
                Console.WriteLine(cars[i]);
            }*/
            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}
