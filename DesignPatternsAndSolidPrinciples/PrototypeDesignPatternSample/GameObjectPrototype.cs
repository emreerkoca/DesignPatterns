using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPatternSample
{
    public abstract class GameObjectPrototype
    {
        public abstract GameObjectPrototype Clone();
    }
}
