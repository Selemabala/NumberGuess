using System;


namespace CNumberGuessing31Jan;

class Program
{
    static void Main(string[] args)
    {
        const int GUESS_START = 0;
        const int GUESS_LIMIT = 100;
        const int NUMBER_OF_TRIALS = 10;
        const int CLOSE_GUESS = 5;
        const int ABOVE_GUESS = 6;

        string name = "";
        Console.WriteLine("Hello, Welcome!");
        Console.WriteLine("Please enter your name");
        name = Console.ReadLine();
        Console.WriteLine("This is a number guessing game");
        Console.WriteLine($"The number you can guess is between {GUESS_START} to {GUESS_LIMIT}, number {GUESS_LIMIT} is included");
        Console.WriteLine($"You have {NUMBER_OF_TRIALS} trials");

        int trials = 0;
        int guess = 0;
        Random rng = new Random();
        int randomNumber = rng.Next(0, 101);

        for (trials = 1; trials <= NUMBER_OF_TRIALS; trials++)
        {
            Console.WriteLine($"{name} enter your guess");
            guess = Convert.ToInt32(Console.ReadLine());

            bool correct = guess == randomNumber;
            bool negativeNumber = guess < GUESS_START;
            bool tooBigNumber = guess > GUESS_LIMIT;
            int closeMinus = randomNumber - guess;
            int closePlus = guess - randomNumber;

            if (negativeNumber || tooBigNumber)
            {
                Console.WriteLine($"Please {name} the number should be within the instructions");
            }

            if (correct)
            {
                Console.WriteLine($"{name} you won, conglatulations");
                return;
            }

            if (closeMinus < ABOVE_GUESS && closeMinus >= GUESS_START || closePlus < ABOVE_GUESS && closePlus >= GUESS_START)
            {
                Console.WriteLine($"You are close");
            }

            if (closePlus > CLOSE_GUESS && closePlus < GUESS_LIMIT)
            {
                Console.WriteLine($"{name} that was not correct, the number is too high.");
            }

            if (closeMinus > CLOSE_GUESS && guess >= GUESS_START)
            {
                Console.WriteLine($"{name} that was not correct, the number is too low");
            }

            Console.WriteLine($"Hey remember this was your {trials} trial, you are remainded with {NUMBER_OF_TRIALS - trials}");
            Console.WriteLine("Try again");
        }

        Console.WriteLine($"Hey {name}, you have now guessed {NUMBER_OF_TRIALS} times");
        Console.WriteLine($"You have reached the limit of your trials");
        Console.WriteLine($"You lost {name}, bye");
        return;
    }

}

