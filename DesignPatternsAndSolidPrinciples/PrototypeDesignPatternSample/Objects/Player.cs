using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPatternSample.Objects
{
    public class Player : GameObjectPrototype
    {
        public int Id { get; set; }
        public int Health { get; set; }
        public int Velocity { get; set; }
        public string Skills { get; set; }
        public int Score { get; set; }

        public Player(int id, int health, int velocity, string skills, int score)
        {
            Id = id;   
            Health = health;
            Velocity = velocity;
            Skills = skills;
            Score = score;
        }

        public override GameObjectPrototype Clone()
        {
            return this.MemberwiseClone() as GameObjectPrototype;
        }
    }
}
