// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region Triangle Farmer
//Console.WriteLine(AreaTriangle(3, 10));

//int AreaTriangle(int baseOfTriangle, int height)
//{
//	return (baseOfTriangle * height) / 2;
//} 
#endregion

#region The Four Sisters and the Duckbear
//Console.WriteLine("How many eggs were gathered that day?");
//int amountOfEggs = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Each sister will recieve {amountOfEggs / 3} eggs and feed the duckbear {amountOfEggs % 3} eggs."); 
#endregion

#region Formatting Fun
//Formatting tests
//Console.WriteLine($"{Math.PI:0.00000000}");
//float maxHealth = 40f;
//float currentHealth = 17f;
//Console.WriteLine($"{currentHealth / maxHealth:0.0%}"); 
#endregion

#region Defense of Consolas
//Console.Title = "Defense of Consolas";
//Console.WriteLine("Where is the manticore located?");
//Console.Write("Target row? ");
//int row = Convert.ToInt16(Console.ReadLine());
//Console.Write("Target Column? ");
//int column = Convert.ToInt16(Console.ReadLine());
//Defense(row, column);

//void Defense(int row, int column)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine($"Troops are being sent out to surround the ship!\nDeployed troops at:\n({row}, {column - 1})\n({row - 1}, {column})\n({row}, {column + 1})\n({row + 1}, {column}) ");
//    Console.Beep();
//    Console.ResetColor();
//}
#endregion

#region Reparing the Clocktower
////Reparing the Clocktower
//Console.Write("Give me a whole number so I can make the Clocktower 'tick' & 'tock'! ");
//int tickortock = Convert.ToInt16(Console.ReadLine());
//var result = tickortock % 2 == 0 ? "Tick" : "Tock";
//Console.Write(result);
#endregion

#region Watchtower
//Console.WriteLine("We must defend the watch tower!!\nGive me an X coordinate of the Watchtower: ");
//int x = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("Great! Now give me the Y coordinate: ");
//int y = Convert.ToInt16(Console.ReadLine());
//if (x < 0 && y > 0)
//{
//    Console.WriteLine("The enemy is Northwest!");
//}
///////Not going to complete this one since it's pretty straight forward logic statements
#endregion

#region Buying Inventory / Discounted Inventory
//Console.WriteLine("The following items are available\n1 -- Rope\n2 -- Torches\n3 -- Climbing Equipment\n4 -- Clean Water\n5 -- Machete\nWhat number do you want to see the price of?");
//int numChoice = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("Do you have any secret passcodes to enter? ");
//string passCode = Console.ReadLine();
//if (passCode == "cheese")
//{
//    string response = numChoice switch
//    {
//        1 => $"Rope is {10 / 2} gold",
//        2 => $"Torch is {15 / 2} gold",
//        3 => $"Climbing Equipment is {25 / 2} gold",
//        4 => $"Clean Water is 1 gold",
//        5 => $"Machete.... here you go kind sir"
//    };
//    Console.WriteLine(response);
//}
//else
//{
//    string response = numChoice switch
//    {
//        1 => $"Rope is 10 gold",
//        2 => $"Torch is 15 gold",
//        3 => $"Climbing Equipment is 25 gold",
//        4 => $"Clean Water is 1 gold",
//        5 => $"Machete.... that will cost your liver!"
//    };
//    Console.WriteLine(response);
//}
#endregion

#region The Prototype
//int numSet = AskForNumber("Enter a number between 0 and 50", 1);
//Console.Clear();
//Console.WriteLine("What is your guess to the number?");
//int guess = Convert.ToInt32(Console.ReadLine());


//while (numSet != guess)
//{
//    if (guess > numSet) { Console.WriteLine("Number is too high"); }
//    else if (guess < numSet) { Console.WriteLine("Number is too low"); }
//    Console.Write("Try again: ");
//    guess = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("Congrats you got it");

#endregion

#region The Magic Cannon
/*
 * Skorin, a member of Consolas’s wall guard, has constructed a magic cannon that draws power from two
gems: a fire gem and an electric gem. Every third turn of a crank, the fire gem activates, and the cannon
produces a fire blast. The electric gem activates every fifth turn of the crank, and the cannon makes an
electric blast. When the two line up, it generates a potent combined blast. Skorin would like your help to
produce a program that can warn the crew about which turns of the crank will produce the different
blasts before they do it.
*/

//for (int i = 1; i <= 100; i++)
//{

//    if (i % 5 == 0 && i % 3 == 0) { Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"{i}: Combined Blast"); }
//    else if (i % 3 == 0) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"{i}: Fire Blast"); }
//    else if (i % 5 == 0) { Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"{i}: Electric Blast"); }
//    else { Console.ForegroundColor = ConsoleColor.White; Console.WriteLine($"{i}: Normal"); }

//}

#endregion

#region The Replicator of D'To

//int[] ints = new int[5];

//for (int i = 0; i < ints.Length; i++)
//{
//    Console.WriteLine($"Enter number {i + 1}: ");
//    int numPlacer = Convert.ToInt32(Console.ReadLine());
//    ints[i] += numPlacer;
//}

//for (int i = 0; i < ints.Length; i++)
//{
//    Console.WriteLine($"Array ints[{i}] = {ints[i]}");
//}

//int[] ints2 = ints[0..5]; //ommitted to creating another for loop and wanted to try something else

//for (int i = 0; i < ints.Length; i++)
//{
//    Console.WriteLine($"Array ints2[{i}] = {ints2[i]}");
//}


#endregion

#region The Laws of Freach
//int[] ints = new int[] { 1, 2, 5, 7, 9 };

//foreach (var item in ints)
//{
//    Console.WriteLine(item);
//}

#endregion

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

//var x = AskForNumber("What is a number?");
//Console.WriteLine(x);



#endregion

#region Countdown

//int Countdown(int number)
//{
//    if (number == 1) { Console.WriteLine("1"); return 1; }
//    else
//    {
//        Console.WriteLine(number);
//        return Countdown(number - 1);
//    }
//}

//Countdown(10);


#endregion

