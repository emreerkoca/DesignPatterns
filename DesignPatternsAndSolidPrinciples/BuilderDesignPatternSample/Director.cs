using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPatternSample
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMedievalWarriorInventories()
        {
            this._builder.BuilPlayersArmor();
            this._builder.BuildPlayersSword();
            this._builder.BuildPlayersHorse();
        }

        public void BuildModernWarriorInventories()
        {
            this._builder.BuildPlayersGun();
            this._builder.BuilPlayersVehicle();
        }
    }
}
