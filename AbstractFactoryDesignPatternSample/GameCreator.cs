using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternSample
{
    public class GameCreator
    {
        private Gun _gun;
        private Warrior _warrior;

        public GameCreator(GameAreaFactory gameAreaFactory)
        {
            _gun = gameAreaFactory.CreateGun();
            _warrior = gameAreaFactory.CreateWarrior();
        }

        public void StartWar()
        {
            _warrior.UseGun(_gun);
        }
    }
}
