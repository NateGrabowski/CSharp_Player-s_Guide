// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations.Schema;

Console.WriteLine("Hello, World!");

#region Simula's Test

//ChestState currentState = ChestState.Locked;

//while (true)
//{
//    Console.Write($"The chest is {currentState}. What do you want to do? ");

//    string input = Console.ReadLine();

//    if (currentState == ChestState.Locked && input == "unlock") currentState = ChestState.Closed;
//    if (currentState == ChestState.Closed && input == "open") currentState = ChestState.Open;
//    if (currentState == ChestState.Open && input == "close") currentState = ChestState.Closed;
//    if (currentState == ChestState.Closed && input == "lock") currentState = ChestState.Locked;
//}

//enum ChestState { Open, Closed, Locked }

#endregion

#region Simula's Soup
//(SoupType, MainIngredient, Seasoning) soup = GetSoup();
//Console.WriteLine($"{soup.Item3} {soup.Item2} {soup.Item1}");

//(SoupType, MainIngredient, Seasoning) GetSoup()
//{
//SoupType type = GetSoupType();
//MainIngredient ingredient = GetMainIngredient();
//Seasoning seasoning = GetSeasoning();
//return (type, ingredient, seasoning);
//}

//SoupType GetSoupType()
//{
//Console.Write("Soup type (soup, stew, gumbo): ");
//string input = Console.ReadLine();
//return input switch
//{
//"soup" => SoupType.Soup,
//"stew" => SoupType.Stew,
//"gumbo" => SoupType.Gumbo
//};
//}

//MainIngredient GetMainIngredient()
//{
//Console.Write("Main ingredient (mushroom, chicken, carrot, potato): ");
//string input = Console.ReadLine();
//return input switch
//{
//"mushroom" => MainIngredient.Mushroom,
//"chicken" => MainIngredient.Chicken,
//"carrot" => MainIngredient.Carrot,
//"potato" => MainIngredient.Potato
//};
//}

//Seasoning GetSeasoning()
//{
//Console.Write("Seasoning (spicy, salty, sweet): ");
//string input = Console.ReadLine();
//return input switch
//{
//"spicy" => Seasoning.Spicy,
//"salty" => Seasoning.Salty,
//"sweet" => Seasoning.Sweet,
//};
//}

//enum SoupType { Soup, Stew, Gumbo }
//enum MainIngredient { Mushroom, Chicken, Carrot, Potato }
//enum Seasoning { Spicy, Salty, Sweet }
#endregion

#region Vin Fletcher’s Arrows --Heavily Refactored In Next Challenge

//CraftArrow arrow = new(CraftArrow.ArrowheadType.steel, CraftArrow.FletchingType.goose_feathers);
//Console.WriteLine(arrow.GetCost(CraftArrow.ArrowheadType.steel, CraftArrow.FletchingType.goose_feathers));


//class CraftArrow
//{

//    public int _length = 60;
//    public ArrowheadType _ArrowHeadType;
//    public FletchingType _FletchingType;

//    public CraftArrow(ArrowheadType t1, FletchingType t2, int length = 60)
//    {

//    }

//    public float GetCost(ArrowheadType t1, FletchingType t2)
//    {
//        float gold = 0;
//        switch (t1)
//        {
//            case ArrowheadType.steel:
//                gold += 10;
//                break;
//            case ArrowheadType.wood:
//                gold += 3;
//                break;
//            case ArrowheadType.obsidian:
//                gold += 5;
//                break;
//        }
//        switch (t2)
//        {
//            case FletchingType.plastic:
//                gold += 10;
//                break;
//            case FletchingType.turkey_feathers:
//                gold += 5;
//                break;
//            case FletchingType.goose_feathers:
//                gold += 3;
//                break;
//        }
//        return (float)(gold + (this._length * 0.05));
//    }


//    public enum ArrowheadType
//    {
//        steel, wood, obsidian
//    }
//    public enum FletchingType
//    {
//        plastic, turkey_feathers, goose_feathers
//    }

//}

#endregion

#region Vin's Trouble

//CraftArrow arrow = new(65, CraftArrow.ArrowheadType.steel, CraftArrow.FletchingType.turkey_feathers);

//class CraftArrow
//{
//    private int _length = 60;
//    private ArrowheadType _ArrowHeadType;
//    private FletchingType _FletchingType;
//    public enum ArrowheadType { steel, wood, obsidian }
//    public enum FletchingType { plastic, turkey_feathers, goose_feathers }
//    public int GetLength() => this._length;
//    public ArrowheadType GetArrowType() => this._ArrowHeadType;
//    public FletchingType GetFletchingType() => this._FletchingType;

//    public CraftArrow(int length, ArrowheadType arrowHeadType, FletchingType fletchingType)
//    {
//        _length = length;
//        _ArrowHeadType = arrowHeadType;
//        _FletchingType = fletchingType;
//    }
//    public float GetCost()
//    {
//        float gold = 0;
//        switch (this._ArrowHeadType)
//        {
//            case ArrowheadType.steel:
//                gold += 10;
//                break;
//            case ArrowheadType.wood:
//                gold += 3;
//                break;
//            case ArrowheadType.obsidian:
//                gold += 5;
//                break;
//        }
//        switch (this._FletchingType)
//        {
//            case FletchingType.plastic:
//                gold += 10;
//                break;
//            case FletchingType.turkey_feathers:
//                gold += 5;
//                break;
//            case FletchingType.goose_feathers:
//                gold += 3;
//                break;
//        }
//        return (float)(gold + (this._length * 0.05));
//    }
//}

#endregion