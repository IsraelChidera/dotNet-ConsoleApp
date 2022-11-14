using System;

namespace Guessingame
{
    public class Guessingame
    {
        public int count;
        public int correctNumber;
        public int countNumber;
        Random random = new Random();

        public Guessingame()
        {
            count = 0;
            correctNumber = GenerateCorrectNumber();
            countNumber = GenerateCountNumber();
        }

        private int GenerateCorrectNumber()
        {
            return random.Next(0, 10);
        }

        private int GenerateCountNumber()
        {
            return random.Next(1, 10);
        }

        public void Guessnumber()
        {
            // using a while loop
            // to loop through your guess
            // and using a conditional statement to know 
            // if it is correct or not
            while (count < countNumber)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Hello, please guess a number between 0 and 10");
                Console.ResetColor();
                string guessNumber = Console.ReadLine();

                try
                {
                    int guess = Convert.ToInt32(guessNumber);
                    count = count + 1;
                    // Console.WriteLine("count" + count);
                    Console.WriteLine("guessed number" + guess);

                    if (guess == correctNumber)
                    {
                        Console.WriteLine("Congratulations, You guessed correctly!");
                        Console.WriteLine("Number of tries: " + count);
                        break;
                    }

                    else if (guess < correctNumber)
                    {
                        Console.WriteLine("You guessed LOWER, try again!");
                        continue;
                    }

                    else if (guess > correctNumber)
                    {
                        Console.WriteLine("You guessed HIGHER, try again!");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number");
                    continue;
                }
            }

            // if number of tries is exceeded
            if (count >= countNumber)
            {
                Console.WriteLine("You have exceeded the number of tries");
                Console.WriteLine("The correct guess is : " + correctNumber);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Guessingame guessingame = new Guessingame();
            guessingame.Guessnumber();
        }
    }
}