// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello World, it's time to do some coding!");


//int i = 1;
//Increment(ref i);
//Console.WriteLine(i);

//void Increment(ref int i)
//{
//    i++;
//}

test test = new test();
test.Start();


class test
{
    public Action action;


    public void Start()
    {
        TestMultipleGenerics<string, int>("hi", 5);


        //var arr = CreateArray("word", 5);

        //int[] intArray = CreateArray<int>(5, 6);
        //Console.WriteLine(intArray.Length + " " + intArray[0] + " " + intArray[1]);
        //Console.WriteLine(intArray.GetType());


        //Console.WriteLine(CreateArray<string>("word1", "word2").GetType());
        MyClass<IEnemy> myClass = new MyClass<IEnemy>(new EnemyMinion());
        MyClass<EnemyArcher> myClassArcher = new MyClass<EnemyArcher>(new EnemyArcher());
    }

    public T[] CreateArray<T>(T firstElement, T secondElement)
    {
        return new T[] { firstElement, secondElement };
    }

    public void TestMultipleGenerics<T1, T2>(T1 t1, T2 t2)
    {
        Console.WriteLine(t1.GetType());
        Console.WriteLine(t2.GetType());
    }

}

public class MyClass<T> where T : IEnemy
{ 
{
    public T value;

    public MyClass(T value)
    {
        value.Damage();
    }

    public T[] CreateArray(T firstElement, T secondElement)
    {
        return new T[] { firstElement, secondElement };
    }
}

public interface IEnemy
{
    public void Damage();
}

public class EnemyMinion : IEnemy
{
    public void Damage()
    {
        Console.WriteLine("Enenmy Archer.Damage()");
    }
}

public class EnemyArcher : IEnemy
{
    public void Damage()
    {
        Console.WriteLine("Enenmy Archer.Damage()");
    }
}