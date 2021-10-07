using System;
using System.Collections.Generic;
namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // List = data structure that represents a list of objects that can be accessed by index.
            //        Similar to array, but can dynamically increase/decrease in size 
            //        using System.Collections.Generic;
            List<String> food = new List<String>();
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");
            food.Remove("fries");
            Console.WriteLine(food[0]);
            Console.WriteLine(food[1]);
            Console.WriteLine(food[2]);
            food.Insert(0, "sushi");
            Console.WriteLine(food[3]);
            Console.WriteLine(food.Count);
            //Console.WriteLine(food.IndexOf("pizza"));
            //Console.WriteLine(food.LastIndexOf("fries"));
            //Console.WriteLine(food.Contains("pizza"));
            food.Sort();
            food.Reverse();
            //food.Clear();
            //String[] foodArray = food.ToArray();
            foreach (String item in food)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
