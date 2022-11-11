int i = 0;
Robot robo = new Robot();
Console.WriteLine("You come across this old robot in the sand...what would you like to do?");
Console.WriteLine("1 - Turn On\n2 - Turn Off\n3 - Move North\n4 - Move South\n5 - Move West\n6 - Move East");


while (i != 3)
{
    int input = Convert.ToInt16(Console.ReadLine());
    IRobotCommand RC = input switch
    {
        1 => new OnCommand(),
        2 => new OffCommand(),
        3 => new NorthCommand(),
        4 => new SouthCommand(),
        5 => new WestCommand(),
        6 => new EastCommand(),
    };
    RC.Run(robo);
    i++;
}
Console.WriteLine("Beep Boop Beep Boop");
robo.Run();


public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];
    public void Run()
    {
        foreach (IRobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}
public interface IRobotCommand
{
    void Run(Robot robo);
}
public class OnCommand : IRobotCommand
{
    public void Run(Robot robo) => robo.IsPowered = true;
}
public class OffCommand : IRobotCommand
{
    public void Run(Robot robo) => robo.IsPowered = false;
}
public class NorthCommand : IRobotCommand
{
    public void Run(Robot robo)
    {
        if (robo.IsPowered) { robo.Y += 1; }
    }
}
public class SouthCommand : IRobotCommand
{
    public void Run(Robot robo)
    {
        if (robo.IsPowered) { robo.Y -= 1; }
    }
}
public class WestCommand : IRobotCommand
{
    public void Run(Robot robo)
    {
        if (robo.IsPowered) { robo.X -= 1; }
    }
}
public class EastCommand : IRobotCommand
{
    public void Run(Robot robo)
    {
        if (robo.IsPowered) { robo.X += 1; }
    }
}