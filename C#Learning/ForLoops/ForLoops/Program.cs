using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sympol: ");
            String sympol = Convert.ToString(Console.ReadLine());
            for (int x=0;x< rows; x++)
            {
                for (int s = 0; s < columns; s++)
                {
                    Console.Write(sympol);
                }
                Console.WriteLine(sympol);
            }


            //Number guessing   game
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min,max+1);
                response = "";
                while (guess!=number)
                {
                    Console.WriteLine("guess a number between " + min + " and " + max);
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess = "+guess);
                    if (guess > number)
                    {
                        Console.WriteLine("Guess is too high");
                    }else if (guess < number)
                    {
                        Console.WriteLine("Guess is too low");
                    }
                    guesses ++;
                }
                Console.WriteLine("Number is : " + number);
                Console.WriteLine("You Win");
                Console.WriteLine("Guesses :" + guesses);
                Console.WriteLine("Would you like to play again (Y/N)?");
                response = Console.ReadLine();
                response = response.ToUpper();
                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("thanks for playing ");


            Console.ReadKey();

        }
    }
}
