using System;

namespace oop_part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();
            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("the animal goes");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("the Dog goes df");
        }
    }
    class Cat : Animal
    {

    }
}
