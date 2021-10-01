using System;

namespace ObjectsAsArguements
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Mustang", "red");
            ChangeColor(car1,"blue");
            Console.WriteLine(car1.color);
            Car car2 = Copy(car1);

            Console.ReadKey();
        }
        public static void ChangeColor(Car car,String Color)
        {
            car.color = Color;
        }
        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }
    class Car
    {
        public String model;
        public String color;

        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }
}
