// See https://aka.ms/new-console-template for more information
using Chapter_24___Boss_Battles;

Console.WriteLine("Hello, World!");

#region Point
Point point = new Point(2, 3);
Point point1 = new Point(-4, 0);
point.Coordinates();
#endregion

#region Color
Color color = Color.White;
#endregion

#region Card
//Card newCard = new Card(Card.color.Green, Card.symbol.Up_Point);
//Console.WriteLine(newCard.Rank); //returns null
//newCard.DisplayCard();

////int count = 0;
////foreach (var i in Enum.GetNames(typeof(Card.color)))
////{
////    count++;
////    foreach (var s in Enum.GetNames(typeof(Card.rank)))
////    {
////        count++;
////        //Card deck = new Card()
////        Console.WriteLine(i + s);


////    }
////}
////Console.WriteLine(count);

//foreach (var rank in Enum.GetValues(typeof(Card.rank)))
//{
//    foreach (var enumcolor in Enum.GetValues(typeof(Card.color)))
//    {
//        Card card1 = new Card(enumcolor, rank);
//        Console.WriteLine($"The {enumcolor} {rank}");
//    }
//}
#endregion

#region The Locked Door

Door cathedral = new Door();
//DoorBuddy5000(cathedral);

string hi = PromptUser();

string PromptUser()
{
    return Console.ReadLine();
}

//void DoorBuddy5000(Door door)
//{
//    string input = Console.ReadLine();
//    while (input != "cancel")
//    {
//        input = Console.ReadLine();

//    }
//}

//Door.state DoorActions(Door door)
//{
//    return input switch
//    {
//        "lock" => door.State = Door.state.Locked,
//        "cancel" => door.State
//    };
//}

/* Method CreateDoor()
 * Would you like to create a new door?
 * --> Password is prompted via constructor
 * Door is set locked
 * Switch on string =>>> Would you like to open/close/lock/unlock the door?
 * Allow it to happen in order 
 * 
 * 
 * 
 * */
#endregion