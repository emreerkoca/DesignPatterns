using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPatternSample
{
    public interface IBuilder
    {
        void BuildPlayersSword();
        void BuilPlayersArmor();
        void BuildPlayersHorse();
        void BuildPlayersGun();
        void BuilPlayersVehicle();
    }
}
