using PrototypeDesignPatternSample.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPatternSample
{
    public class GameArea : GameObjectPrototype
    {
        public int Id { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public GameAreaType GameAreaType { get; set; }

        public GameArea(int id, int height, int width, int coordinateX, int coordinateY, GameAreaType gameAreaType)
        {
            Id = id;
            Height = height;
            Width = width;
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            GameAreaType = gameAreaType;
        }

        public override GameObjectPrototype Clone()
        {
            return this.MemberwiseClone() as GameObjectPrototype;
        }
    }


}
