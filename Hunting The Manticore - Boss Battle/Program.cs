/* The Uncoded One’s airship, the Manticore, has begun an all-out attack on the city of Consolas. It must be
destroyed, or the city will fall. Only by combining Mylara’s prototype, Skorin’s cannon, and your
programming skills will you have a chance to win this fight. You must build a program that allows one
user—the pilot of the Manticore—to enter the airship’s range from the city and a second user—the city’s
defenses—to attempt to find what distance the airship is at and destroy it before it can lay waste to the
town.
The first user begins by secretly establishing how far the Manticore is from the city, in the range 0 to 100.
The program then allows a second player to repeatedly attempt to destroy the airship by picking the
range to target until either the city of Consolas or the Manticore is destroyed. In each attempt, the player
is told if they overshot (too far), fell short(not far enough), or hit the Manticore. The damage dealt to the
Manticore depends on the turn number. For most turns, 1 point of damage is dealt. But if the turn number
is a multiple of 3, a fire blast deals 3 points of damage; a multiple of 5, an electric blast deals 3 points of
damage, and if it is a multiple of both 3 and 5, a mighty fire-electric blast deals 10 points of damage. The
Manticore is destroyed after taking 10 points of damage.
However, if the Manticore survives a turn, it will deal a guaranteed 1 point of damage to the city of
Consolas. The city can only take 15 points of damage before being annihilated.
Before a round begins, the user should see the current status: the current round number, the city’s health,
and the Manticore’s health. */

//TODO: Refactor code


//Starting Points
using System.Text;

int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;

//Starting Dialogue
int manticoreLocation = AskForNumberInRange("Player 1, how far away from the city do you want to station the Manticore?", 0, 100);
Console.Clear();


//Gameplay Loop
while (manticoreHealth > 0 && cityHealth > 0)
{
    Round(round);
    WeaponDamage(round);
    round++;

}

//Ending
Console.WriteLine($"{(manticoreHealth == 0 ? "The Manticore has been destroyed! The city of Consolas has been saved!" : "The Manticore has reached the city...complete destruction is imminent...")}");


//Methods
void Round(int round)
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine($"Round: {round}  City: {cityHealth}/15  Manticore: {manticoreHealth}/10 ");
    Console.ResetColor();
}

void WeaponDamage(int round)
{

    if (round % 5 == 0 && round % 3 == 0) //combined blast that deals Fire + Electricity 
    {
        int dmg = 10;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"The cannon is expected to deal {dmg} damage this round. Shooting Fire & Electricity.");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.ForegroundColor = ConsoleColor.Black;
        int blastWeapon = AskForNumber("Enter the desired cannon range: ");
        Console.ResetColor();
        if (blastWeapon > manticoreLocation)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("That round OVERSHOT the target.");
            cityHealth -= 1;
            Console.ResetColor();
        }
        else if (blastWeapon < manticoreLocation)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("That round FELL SHORT of the target.");
            cityHealth -= 1;
            Console.ResetColor();
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("That round was a DIRECT HIT!");
            Console.ResetColor();
            manticoreHealth -= dmg;
        }

    }
    else if (round % 5 == 0)
    {
        int dmg = 3;
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"The cannon is expected to deal {dmg} damage this round. Shooting Electricity.");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.ForegroundColor = ConsoleColor.Black;
        int blastWeapon = AskForNumber("Enter the desired cannon range: ");
        Console.ResetColor();
        if (blastWeapon > manticoreLocation)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("That round OVERSHOT the target.");
            cityHealth -= 1;
            Console.ResetColor();
        }
        else if (blastWeapon < manticoreLocation)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("That round FELL SHORT of the target.");
            cityHealth -= 1;
            Console.ResetColor();
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("That round was a DIRECT HIT!");
            Console.ResetColor();
            manticoreHealth -= dmg;
        }
    }
    else if (round % 3 == 0)
    {
        int dmg = 3;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"The cannon is expected to deal {dmg} damage this round. Shooting Fire.");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.ForegroundColor = ConsoleColor.Black;
        int blastWeapon = AskForNumber("Enter the desired cannon range: ");
        Console.ResetColor();
        if (blastWeapon > manticoreLocation)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("That round OVERSHOT the target.");
            cityHealth -= 1;
            Console.ResetColor();
        }
        else if (blastWeapon < manticoreLocation)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("That round FELL SHORT of the target.");
            cityHealth -= 1;
            Console.ResetColor();
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("That round was a DIRECT HIT!");
            Console.ResetColor();
            manticoreHealth -= dmg;
        }
    }
    else
    {
        int dmg = 1;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"The cannon is expected to deal {dmg} damage this round.");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.ForegroundColor = ConsoleColor.Black;
        int blastWeapon = AskForNumber("Enter the desired cannon range: ");
        Console.ResetColor();

        if (blastWeapon > manticoreLocation)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("That round OVERSHOT the target.");
            cityHealth -= 1;
            Console.ResetColor();
        }
        else if (blastWeapon < manticoreLocation)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("That round FELL SHORT of the target.");
            cityHealth -= 1;
            Console.ResetColor();
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("That round was a DIRECT HIT!");
            Console.ResetColor();
            manticoreHealth -= dmg;
        }
    }
}


//Reference & Methods from Part 1
#region Taking a Number ---includes method AskForNumber & AskForNumberInRange
int AskForNumber(string text, int type = 0)
{
    if (type == 0)
    {
        Console.Write($"{text} ");
        var x = Console.ReadLine();
        return Convert.ToInt32(x);
    }
    else
    {
        Console.WriteLine(text);
        var x = Console.ReadLine();
        return Convert.ToInt32(x);
    }
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);
        if (number >= min && number <= max)
            return number;
    }
}
#endregion

