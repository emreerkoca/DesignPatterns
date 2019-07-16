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
            GameAreaFactory space = new SpaceAreaFactory();
            GameCreator gameCreator = new GameCreator(space);
            gameCreator.StartWar();

            GameAreaFactory world = new WorldAreaFactory();
            gameCreator = new GameCreator(world);
            gameCreator.StartWar();

            Console.ReadLine();
        }
    }
}
