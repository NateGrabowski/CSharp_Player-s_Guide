// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;


int input = 0;
Console.WriteLine("What would you like to add into your pack? Note: Your pack has a predefined weight and volume max amount.");
Pack pack = new Pack();
while (true)
{
    Console.WriteLine($"Pack is currently at items {pack.currentItems}/{pack.totalItems}");
    Console.WriteLine("1 - Arrow\n2 - Bow\n3 - Rope\n4 - Water\n5 - Food Ration\n6 - Sword\n7 - Cancel");
    input = Convert.ToInt32(Console.ReadLine());
    InventoryItem newItem = input switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword()
    };
    pack.Add(newItem);
}

class Pack
{
    //Maximum
    public readonly int totalItems = 10;
    public readonly float maxmimumWeight = 12f;
    public readonly float maximumVolume = 12f;
    //Current
    public float currentItems { get; private set; }
    public float currentWeight { get; private set; }
    public float currentVolume { get; private set; }
    //Items held
    public InventoryItem[] items = new InventoryItem[10];

    public void ItemCount() => Console.WriteLine(items.Length);

    public bool Add(InventoryItem item)
    {
        if (currentItems >= totalItems) { return ReturnFalse(); }
        else if (currentWeight >= maxmimumWeight) { return ReturnFalse(); }
        else if (currentVolume >= maxmimumWeight) { return ReturnFalse(); }
        else
        {
            currentItems++;
            currentWeight += item.Weight;
            currentVolume += item.Volume;
            items.Append(item);
            Console.WriteLine("Your item has been successfully added to your pack!");
            return true;
        }
    }
    public bool ReturnFalse()
    {
        Console.WriteLine("Sorry your inventory is too full to accept that new item!");
        return false;
    }
}

class InventoryItem : Pack
{
    float weight;
    float volume;
    public float Weight { get => weight; }
    public float Volume { get => volume; }
    public InventoryItem(float weight, float volume)
    {
        //Weight = weight;
        //Volume = volume;
    }
}

class Arrow : InventoryItem
{

    public Arrow() : base(0.1f, 0.05f)
    {

    }
}

class Bow : InventoryItem
{
    public Bow() : base(1f, 4f)
    { }
}

class Rope : InventoryItem
{
    public Rope() : base(1f, 1.5f)
    { }
}

class Water : InventoryItem
{
    public Water() : base(2f, 3f)
    { }
}

class Food : InventoryItem
{
    public Food() : base(1f, 1.5f)
    { }
}

class Sword : InventoryItem
{
    public Sword() : base(5f, 3f)
    { }
}