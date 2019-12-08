using System;

namespace BuilderDesignPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConcreteBuilder();

            director.Builder = builder;

            Console.Write("Medieval Warrior Inventories: ");
            director.BuildMedievalWarriorInventories();
            Console.WriteLine(builder.GetPlayersInventories().CollectInventories());

            Console.Write("Modern Warrior Inventories: ");
            director.BuildModernWarriorInventories();
            Console.WriteLine(builder.GetPlayersInventories().CollectInventories());
        }
    }
}
