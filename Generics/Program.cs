// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


ColoredWeapon<Sword> sword = new ColoredWeapon<Sword>(new Sword(), ConsoleColor.Blue);
sword.Display();

public class Sword { }
public class Bow { }
public class Axe { }

public class ColoredWeapon<T>
{
    public T Item { get; set; }
    public ConsoleColor Color { get; set; }

    public ColoredWeapon(T item, ConsoleColor color)
    {
        Item = item;
        Color = color;

    }

    public void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(Item);
    }
}