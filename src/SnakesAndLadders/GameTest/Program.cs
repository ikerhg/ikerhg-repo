// See https://aka.ms/new-console-template for more information
using SnakesAndLadders.Interfaces;
using SnakesAndLadders.Managers;

Console.WriteLine("SNAKES AND LADDERS");
ILogicManager manager = new LogicManager();
manager.Initialize(2);
var i = 0;  
while (true)
{
    Console.WriteLine($"Player {i} turn.");
    var response = manager.RollDiceAndMove(i);
    if (response == null)
    {
        Console.WriteLine("A problem has occured. Game will end...");
        break;
    }
    
    if (response.HasErrors)
    {
        Console.WriteLine($"A problem has occured. Error: {response.Message} Game will end...");
        break;
    }

    Console.WriteLine($"Dice result is {response.DiceResult}.");

    if (!string.IsNullOrEmpty(response.Message))
        Console.WriteLine(response.Message);

    Console.WriteLine($"Player {i} current square is {response.Player.CurrentSquare}");

    if (response.HasWin)
    {
        Console.WriteLine($"Player {i} has win. Game has ended.");
        Console.ReadLine();
        break;
    }

    Console.WriteLine();
    Console.WriteLine("Press enter to continue with next player...");
    Console.ReadLine();

    i++;
    if (i >= 2)
        i = 0;
}

