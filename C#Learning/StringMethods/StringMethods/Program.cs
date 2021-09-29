using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Methods
            String fullName = "Ayman Yahia";
            String phoneNumber = "123-456-789";
            fullName=fullName.ToUpper();
            fullName = fullName.ToLower();
            phoneNumber=phoneNumber.Replace("-","/");
            String userNaame = fullName.Insert(0,"Mr.");
            int x = fullName.Length;
            String firstName = fullName.Substring(0, 5);
            String lastName = fullName.Substring(6,5);
            //Console.WriteLine(lastName);

            //If Statements
            Console.WriteLine("Please enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age>=18 && age<100)
            {
                Console.WriteLine("You are now signed up");
            }
            else if (age<=0)
            {
                Console.WriteLine("sorry you are not born yet");
            }
            else if (age>100)
            {
                Console.WriteLine("you are too old for this ");
            }
            else
            {
                Console.WriteLine("sorry you are under 18 years old.");
            }
            Console.WriteLine("Please enter your name : ");
            String name = Convert.ToString(Console.ReadLine());
            if (name == "")
            {
                Console.WriteLine("You didn't enter your name");
            }
            else
            {
                Console.WriteLine("Your name is " + name);
            }
            Console.ReadKey();
        }
    }
}
