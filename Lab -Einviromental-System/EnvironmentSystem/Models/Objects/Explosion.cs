using System.Collections.Generic;
using EnvironmentSystem.Models.DataStructures;

namespace EnvironmentSystem.Models.Objects
{
    public class Explosion: EnvironmentObject
    {
        private int lifetime;

        public Explosion(int x, int y, int width, int height, int lifetime = 2) : this(new Rectangle(x, y, width, height))
        {
            this.ImageProfile = new char[,] { { '\0' } };
            this.CollisionGroup = CollisionGroup.Explosion;
            this.lifetime = 2;
        }

        public Explosion(Rectangle bounds) : base(bounds)
        {
        }

        public override void Update()
        {
            this.lifetime--;
            if (this.lifetime <= 0)
            {
                this.Exists = false;
            }
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new List<EnvironmentObject>(0);
        }
    }
}
