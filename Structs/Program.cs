// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello Nate");
StructGenerator();





void StructGenerator()
{
    Console.WriteLine("Write some coordinates that are next to eachother. X and then Y");
    int x = Convert.ToInt32(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());
    Coordinate coordinate = new Coordinate(x, y);

    Console.WriteLine("Again....Write some coordinates that are next to eachother. X and then Y");
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());
    Coordinate coordinate2 = new Coordinate(x2, y2);

    Console.WriteLine(coordinate.IsAdjacent(coordinate2));
}





struct Coordinate
{
    public readonly int X { get; }
    public readonly int Y { get; }

    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void GetLocation() => Console.WriteLine($"({X},{Y})");

    public bool IsAdjacent(Coordinate coord)
    {
        (int, int) location1 = (X, Y);
        (int, int) location2 = (coord.X, coord.Y);

        if ((location1.Item1 += 1) == location2.Item1 || (location1.Item1 -= 1) == location2.Item1 || (location1.Item2 += 1) == location2.Item2 || (location1.Item2 -= 1) == location2.Item2) { return true; }
        return false;

    }
}

/* RB Whittaker's take on the problem
 * 
 * 
Coordinate a = new Coordinate(3, 3);
Coordinate b = new Coordinate(2, 3);
Coordinate c = new Coordinate(2, 2);

Console.WriteLine(Coordinate.AreAdjacent(a, b)); // Should be True
Console.WriteLine(Coordinate.AreAdjacent(b, c)); // Should be True
Console.WriteLine(Coordinate.AreAdjacent(a, c)); // Should be False
// Console.WriteLine(Coordinate.AreAdjacent(a, a)); // What should this do? Is a coordinate adjacent to itself? It depends on how you want to define it.

public struct Coordinate
{
    public int Row { get; }
    public int Column { get; }

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public static bool AreAdjacent(Coordinate a, Coordinate b)
    {
        int rowChange = a.Row - b.Row;
        int columnChange = a.Column - b.Column;

        if (Math.Abs(rowChange) <= 1 && columnChange == 0) return true;
        if (Math.Abs(columnChange) <= 1 && rowChange == 0) return true;

        return false;
    }
}
*/