using System;

//Namespace
namespace NumberGuesserTut
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Prompts the user for their name
            Console.WriteLine("What is your name?");



            //Gets user input
            string nameInput = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game..", nameInput);

            //Play the game
            while (true)
            {

                // Create a rand number
                Random random = new Random();
                int correctNum = random.Next(1, 10);

                // Initialize the guest variable
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While the geuss is not correct 
                while (guess != correctNum)
                {
                    //Get the users input
                    string numInput = Console.ReadLine();

                    //Validate number
                    if (!int.TryParse(numInput, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This is not a number");
                        Console.ResetColor();

                        //Keep going, but why do we need this?
                        continue;
                    }

                    //Cast to an int and put in the geuss
                    guess = Int32.Parse(numInput);

                    //Match guess to correct number
                    if (guess != correctNum)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("WRONG! Try again...");
                        Console.ResetColor();

                    }
                }

                // Success Message
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You are correct!");
                Console.ResetColor();

                //Ask user to play again
                Console.WriteLine("Play again? [y] or [n]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                } else if (answer == "N")
                {
                    return;
                }
           
            }
        }
    }
}
