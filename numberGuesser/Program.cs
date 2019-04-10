using System;

// Namespace
namespace numberGuesser
{   // Main Class
    class Program
    { // Entry Point Method
        static void Main(string[] args)
        {
            // Set app vars
            GetAppInfo(); //run app info function


            GreetUser(); // ask for users name and greet


            while (true)
            {

                // Init correct Number
                //int correctNumber = 7;

                // Create new random Object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);


                // Init Guess var
                int guess = 0;

                // Ask User for Number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // MAke sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use only numbers");
                        // Keep Going
                        continue;

                    }


                    // Cast to int and put into guess var
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // show error messagew
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
