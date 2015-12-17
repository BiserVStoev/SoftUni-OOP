using System.Collections.Generic;
using EnvironmentSystem.Models.DataStructures;

namespace EnvironmentSystem.Models.Objects
{
    public class Snow: EnvironmentObject
    {
        public Snow(int x, int y, int width, int height) : this(new Rectangle(x, y, width, height))
        {
        }

        public Snow(Rectangle bounds) : base(bounds)
        {
            this.ImageProfile = new char[,] { { '.' } };
            this.CollisionGroup = CollisionGroup.Snow;
        }


        public override void Update()
        {
            
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new EnvironmentObject[0];
        }
    }
}
