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
{
    //Console.ForegroundColor = ConsoleColor.Green;
    //Console.WriteLine($"Troops are being sent out to surround the ship!\nDeployed troops at:\n({row}, {column - 1})\n({row - 1}, {column})\n({row}, {column + 1})\n({row + 1}, {column}) ");
    //Console.Beep();
    //Console.ResetColor();
}
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
Console.WriteLine("The following items are available\n1 -- Rope\n2 -- Torches\n3 -- Climbing Equipment\n4 -- Clean Water\n5 -- Machete\nWhat number do you want to see the price of?");
int numChoice = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Do you have any secret passcodes to enter? ");
string passCode = Console.ReadLine();
if (passCode == "cheese")
{
    string response = numChoice switch
    {
        1 => $"Rope is {10 / 2} gold",
        2 => $"Torch is {15 / 2} gold",
        3 => $"Climbing Equipment is {25 / 2} gold",
        4 => $"Clean Water is 1 gold",
        5 => $"Machete.... here you go kind sir"
    };
    Console.WriteLine(response);
}
else
{
    string response = numChoice switch
    {
        1 => $"Rope is 10 gold",
        2 => $"Torch is 15 gold",
        3 => $"Climbing Equipment is 25 gold",
        4 => $"Clean Water is 1 gold",
        5 => $"Machete.... that will cost your liver!"
    };
    Console.WriteLine(response);
}
#endregion