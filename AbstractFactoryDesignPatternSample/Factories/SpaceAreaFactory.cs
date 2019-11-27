using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternSample
{
    class SpaceAreaFactory : AreaFactory
    {
        public override Gun CreateGun()
        {
            return new BeamGun();
        }

        public override Warrior CreateWarrior()
        {
            return new Alien();
        }
    }

    class BeamGun : Gun
    {
        
    }

    class Alien : Warrior
    {
        public override void UseGun(Gun gun)
        {
            Console.WriteLine(this.GetType().Name + " uses " + gun.GetType().Name);
        }
    }
}
