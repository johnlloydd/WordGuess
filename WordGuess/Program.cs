using System;

namespace ColorGuess
{
    class SecondGame
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "yellow", "orange", "green", "blue", "purple", "black", "brown" };

            Random randcolor = new Random();
            string colorToGuess = colors[randcolor.Next(0, colors.Length)];

            char[] guessedColors = new char[colorToGuess.Length];
            Array.Fill(guessedColors, '_');

            int attempts = colorToGuess.Length * 2;
            bool colorGuessed = false;

                Console.WriteLine("Welcome to Color Guess!");
                Console.WriteLine("Try to guess the color. You have " + attempts + " attempts.");

            while (!colorGuessed && attempts > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Color: " + string.Join(" ", guessedColors));
                Console.Write("Enter a Letter: ");
                char guessedLetter = char.ToLower(Console.ReadKey().KeyChar);

            if (!char.IsLetter(guessedLetter))
                {
                    Console.WriteLine("\nPlease enter a valid letter.");
                    continue;
                }
                bool letterFound = false;

            for (int i = 0; i < colorToGuess.Length; i++)
                {
                if (colorToGuess[i] == guessedLetter)
                    {
                        guessedColors[i] = guessedLetter;
                        letterFound = true;
                    }
                }
                if (!letterFound)
                    {
                    Console.WriteLine("\nIncorrect guess! You have " + --attempts + " attempts left.");
                    }

                if (string.Join("", guessedColors) == colorToGuess)
                    {
                    colorGuessed = true;
                    }
                }

                if (colorGuessed)
                {
                    Console.WriteLine("\nCongratulations! You guessed the color: " + colorToGuess);
                }
                else
                {
                    Console.WriteLine("\nSorry, you ran out of attempts. The color was: " + colorToGuess);
                }

                    Console.WriteLine("Thank you for playing Color Guess!");
        }
    }
}
