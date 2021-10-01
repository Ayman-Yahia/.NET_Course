using System;

namespace ArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] garage = { new Car("x5"), new Car("Corvette"), new Car("Lambo") };
            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }
            Console.ReadKey();
        }
    }
    class Car
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }
}
