// See https://aka.ms/new-console-template for more information


using Fountain_Of_Objects;

Player player = new Player();
PlayerCommands command = new NorthCommand(player);
Console.WriteLine(player.Y);