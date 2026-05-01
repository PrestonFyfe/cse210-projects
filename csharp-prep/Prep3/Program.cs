using System;

class Program
{
    static void Main(string[] args)
    {
        int total_guesses = 1;
        Random randomGenerator = new Random();
        int answer = randomGenerator.Next(1, 11);
        //Console.Write("What is the magic number? ");
        //int answer = int.Parse(Console.ReadLine());

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != answer)
        {
            if (guess > answer)
            {
                Console.WriteLine("Lower");
            } else
            {
                Console.WriteLine("Higher");
            }
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            total_guesses += 1;
        }

        Console.WriteLine($"You guessed it in {total_guesses} guesses!");
    }
}