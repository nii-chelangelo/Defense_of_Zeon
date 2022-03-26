using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Matrix.Game
{
    class AgentSmith : Transform, IGameObject
    {
        int speed;
        int speedOfset;
        int curSpeed;
        Scene scene;
        Random random = new Random();
        public AgentSmith(int sx, int sy, int speed, int offsetSpeed, Scene scene)
        {
            this.scene = scene;
            SetSize(new Vector(sx, sy));
            this.speed = speed;
            this.speedOfset = offsetSpeed;
            NextPlane();
        }
        public void NextPlane()
        {
            curSpeed = speed + random.Next(-speedOfset, speedOfset);
            SetPosition(scene.planes[random.Next(0, scene.planes.Count)].Position);
        }
        public void Draw(Graphics g)
        {
            AddPosition(new Vector(0, curSpeed));
            g.DrawImage(Resources.GetFrame("Bomb"),
            Position.X, Position.Y, Size.X, Size.Y);
            if (Position.Y > Render.Resolution.Y)
                NextPlane();
        }
        public void Break()
        {
            scene.UseEffect(Position);
            NextPlane();            
        }
    }
}
