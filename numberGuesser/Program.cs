using System;
namespace numberGuesser
{   
    class Program
    { 
        static void Main(string[] args)
        {
            GetAppInfo(); //run app info function
            GreetUser(); // ask for users name and greet


            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use only numbers");
                        continue;
                    }
                    guess = Int32.Parse(input);
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "wrong number, please try again");
                    }

                }

                // SUccess Message
                PrintColorMessage(ConsoleColor.Yellow, "you are CORRECT!!!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }

        static void GetAppInfo()
        {
            string appName = "NumberGuesser";
            string appVersion = "1.0.0";
            string appAuthor = "Shoshone Arnold";

            // Chnage Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset Tect Color
            Console.ResetColor();

        }

        static void GreetUser()
        {
            // Ask user's name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);
        }

        // Print color Message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            // Tell user its the right number
            Console.WriteLine(message);

            // Reset Tect Color
            Console.ResetColor();
        }
    }
}
