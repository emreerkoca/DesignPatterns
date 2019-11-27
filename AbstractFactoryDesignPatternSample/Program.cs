using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaFactory space = new SpaceAreaFactory();
            GameCreator spaceAreaCreator = new GameCreator(space);

            AreaFactory world = new WorldAreaFactory();
            GameCreator worldAreaCreator = new GameCreator(world);

            worldAreaCreator.StartWar();
            spaceAreaCreator.StartWar();

            Console.ReadLine();
        }
    }
}
