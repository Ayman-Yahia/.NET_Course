using System;

namespace conditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // conditional operator = used in conditional assignment if a condition is true/false

            //(condition) ? x : y
            double temperature = 20;
            String message;
            message = (temperature >= 15) ? "It is warm outside" : "it is cold out side";
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
