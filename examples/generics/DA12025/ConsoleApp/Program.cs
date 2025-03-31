using Generics;

namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        GenericList<int> intList = new GenericList<int>();
        intList.Add(10);
        intList.Add(20);
        int itemOne = intList.Get(0);

        GenericList<string> stringList = new GenericList<string>();
        stringList.Add("Hello");
        stringList.Add("World");
        string itemTwo = stringList.Get(1);

        Console.WriteLine(itemOne);
        Console.WriteLine(itemTwo);
    }
}