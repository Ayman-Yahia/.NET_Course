using System;

namespace ParamasUsing
{
    class Program
{
    static void Main(string[] args)
    {
        //params keyword = a method parameter that takes a variable number of arguments.
        //                 The parameter type must be a single - dimensional array
        double totla = sumTotal(3.99, 5, 7.8, 8.3);
        Console.ReadKey();
    }
    static double sumTotal(params double[] prices)
    {
        double total = 0;
        foreach (double price in prices)
        {
            total += price;
        }
        Console.WriteLine(total);
        return total;
    }
}
}
