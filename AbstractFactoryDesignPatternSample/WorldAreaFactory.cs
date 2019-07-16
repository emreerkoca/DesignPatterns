using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternSample
{
    class WorldAreaFactory : GameAreaFactory
    {
        public override Gun CreateGun()
        {
            return new ShotGun();
        }

        public override Warrior CreateWarrior()
        {
            return new Soldier();
        }
    }

    class ShotGun : Gun
    {

    }

    class Soldier : Warrior
    {
        public override void UseGun(Gun gun)
        {
            Console.WriteLine(this.GetType().Name + " uses " + gun.GetType().Name);
        }
    }

}
