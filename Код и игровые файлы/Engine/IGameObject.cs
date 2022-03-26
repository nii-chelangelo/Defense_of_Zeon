using System.Collections.Generic;
using System.Drawing;

namespace The_Matrix
{
    interface IGameObject
    {
        void Draw(Graphics g);
        bool Colision(int x, int y);
    }
}
