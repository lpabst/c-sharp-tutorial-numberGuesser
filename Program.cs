using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            GetAppInfo();
            GreetUser();

            bool gameIsRunning = true;

            while (gameIsRunning)
            {
                
                int guess = 0;

                int correctNumber = 7;
                Random random = new Random();
                correctNumber = random.Next(1, 10);

                // while guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    Console.WriteLine("Please enter a number 1-10.");
                    string userGuess = Console.ReadLine();

                    // Make sure user entered a number
                    if (!int.TryParse(userGuess, out guess))
                    {
                        Tools.ColorConsole("That was not a number, please enter a number", ConsoleColor.Red);
                        continue;
                    }

                    // Cast to an integer from string
                    guess = Int32.Parse(userGuess);

                    if (guess != correctNumber)
                    {
                        Tools.ColorConsole("Wrong number, please try again.", ConsoleColor.Red);
                    }
                    else
                    {
                        Tools.ColorConsole("Correct!", ConsoleColor.Green);
                    }
                }

                Console.WriteLine("Do you want to play again? Y/N");
                string playAgain = Console.ReadLine().ToUpper();

                if (playAgain != "Y")
                {
                    gameIsRunning = false;
                }
            }
        }

        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "v1.0.0";
            string author = "Loren Pabst";
            
            Tools.ColorConsole($"{appName}: Version {appVersion} by {author}", ConsoleColor.Yellow);
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}! Please enter a number 1-10.");
        }
    }
}
