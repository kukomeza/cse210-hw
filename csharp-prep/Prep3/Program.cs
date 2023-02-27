using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        

        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int guesses = 0;
            bool guessed = false;
            while (guessed == false)
                {

                    Console.WriteLine("What is your guess?");
                    string guess = Console.ReadLine();
                    int guessNumber = int.Parse(guess);
                    guesses += 1;
                    if (guessNumber == number)
                    {
                        Console.WriteLine("You Guessed it!");
                        guessed = true;
                    }
                    else if (guessNumber < number)
                        Console.WriteLine("Higher");
                    else if (guessNumber > number)
                        Console.WriteLine("Lower"); 

                }
            Console.WriteLine($"Number of guesses {guesses}");
            Console.Write("Do you want to continue?");
            response = Console.ReadLine();
        }while(response == "yes");

            
        

    }
}