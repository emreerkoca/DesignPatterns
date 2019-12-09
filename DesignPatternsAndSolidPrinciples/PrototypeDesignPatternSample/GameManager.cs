using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPatternSample
{
    class GameManager
    {
        public List<GameObjectPrototype> GameObjects { get; set; }

        public GameManager()
        {
            GameObjects = new List<GameObjectPrototype>();
        }
    }
}
