using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPatternSample
{
    public class ConcreteBuilder : IBuilder
    {
        private PlayerInventory _playerInventory = new PlayerInventory();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._playerInventory = new PlayerInventory();
        }

        #region Medieval Warrior
        public void BuildPlayersHorse()
        {
            this._playerInventory.Add("Horse");
        }

        public void BuildPlayersSword()
        {
            this._playerInventory.Add("Sword");
        }

        public void BuilPlayersArmor()
        {
            this._playerInventory.Add("Armor");
        }
        #endregion

        #region Modern Warrior
        public void BuildPlayersGun()
        {
            this._playerInventory.Add("Machine Gun");
        }

        public void BuilPlayersVehicle()
        {
            this._playerInventory.Add("Tank");
        } 
        #endregion

        public PlayerInventory GetPlayersInventories()
        {
            PlayerInventory result = this._playerInventory;

            this.Reset();

            return result;
        }
    }
}
