using PrototypeDesignPatternSample.Objects;
using System;

namespace PrototypeDesignPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();

            GameArea groundArea = new GameArea(1, 20, 500, 0, 0, Helpers.GameAreaType.Ground);
            GameArea seaArea = new GameArea(2, 200, 800, 500, 0, Helpers.GameAreaType.Sea);
            GameArea brickArea = new GameArea(3, 10, 50, 200, 15, Helpers.GameAreaType.WeakBrick);

            Player medievalWarrior = new Player(1, 100, 10, "Sword,Armor", 0);
            Player modernWarrior = new Player(2, 100, 20, "Gun", 0);

            gameManager.GameObjects.Add(groundArea);
            gameManager.GameObjects.Add(seaArea);
            gameManager.GameObjects.Add(brickArea);
            gameManager.GameObjects.Add(medievalWarrior);
            gameManager.GameObjects.Add(modernWarrior);

            //Objects cloned from instances
            gameManager.GameObjects.Add(groundArea.Clone() as GameArea);
            gameManager.GameObjects.Add(modernWarrior.Clone() as Player);
        }
    }
}
