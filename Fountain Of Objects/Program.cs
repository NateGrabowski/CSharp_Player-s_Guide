// See https://aka.ms/new-console-template for more information


using Fountain_Of_Objects;

Player player = new Player();
Map GameMap = new Map();


while (true)
{
    GameText();
    GameMap.Zone(player);
    Console.Write($"What do you want to do? ");
    string input = Console.ReadLine();
    PlayerCommands command = input switch
    {
        "move north" => new NorthCommand(player),
        "move south" => new SouthCommand(player),
        "move east" => new EastCommand(player),
        "move west" => new WestCommand(player)
    };
    Console.WriteLine(); //Line break;
}

void GameText()
{
    Console.WriteLine($"You are in the room at (Row={player.X}, Column={player.Y}).");
}