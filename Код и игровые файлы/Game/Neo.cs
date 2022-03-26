﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Matrix.Game
{
    class Neo : Transform, IGameObject
    {
        bool isBreak = false;        
        public Neo(int x, int y, int sx, int sy)
        {
            SetPosition(new Vector(x, y));
            SetSize(new Vector(sx, sy));
        }
        public void Break() => isBreak = true;
        public bool IsBreak => isBreak;
        public void Draw(Graphics g) => g.DrawImage(isBreak ? Resources.GetFrame("HouseBreak") : Resources.GetFrame("House"),
            Position.X, Position.Y, Size.X, Size.Y);
    }
}
