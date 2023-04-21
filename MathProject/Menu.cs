namespace MathProject
{
    internal class Menu
    {

        GameEngine gameEngine = new();

        internal void ShowMenu(string name, string date)
        {

            bool isGammeOn = true;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Hello {name.ToUpper()}. It's {date}");
                Console.WriteLine($@"What game would you like to play? Choose from options:
V - View Previous Games
A - Addition
S - Subtraction
M - Muliplacation
D - Division
Q - Quit program");
                Console.WriteLine("---------------------------");

                string gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtractrion game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game");
                        break;
                    case "q":
                        Console.WriteLine("GoodBye");
                        isGammeOn = false;
                        break;
                    default:
                        Console.WriteLine("Invald Input");
                        break;
                }
            } while (isGammeOn);


        }
    }
}
