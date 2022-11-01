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
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Troops are being sent out to surround the ship!\nDeployed troops at:\n({row}, {column - 1})\n({row - 1}, {column})\n({row}, {column + 1})\n({row + 1}, {column}) ");
    Console.Beep();
    Console.ResetColor();
}
#endregion

