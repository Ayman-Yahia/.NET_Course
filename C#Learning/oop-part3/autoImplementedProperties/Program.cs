using System;

namespace autoImplementedProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auto-Implemented properties =  shortcut when no additional logic is required in the property
            //                                you do not have to define a field for a property,
            //                                you only have to write get; and/or set; inside the property                             

            Car car = new Car("Porsche");

            Console.WriteLine(car.Model);
            Console.ReadKey();
        }
    }
    class Car
    {
        
        public String Model { get; set; }

        public Car(String model)
        {
            this.Model = model;
        }
    }
}
