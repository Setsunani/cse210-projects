using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Guess My Number!");

        Console.Write("What is the magic number? ");
        int magicNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Try to guess the magic number!");

        int guess;
        int guessCount = 0;
        do
        {
            Console.Write("What is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());
            guessCount++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);

        Console.WriteLine($"You made {guessCount} guesses.");

        Console.Write("Do you want to play again? (yes/no): ");
        string playAgain = Console.ReadLine().ToLower();

        if (playAgain == "yes")
        {
            Main(args);
        }
        else
        {
            Console.WriteLine("Thanks for playing!");
        }
    }
}
