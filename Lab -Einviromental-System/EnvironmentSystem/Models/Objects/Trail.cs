using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvironmentSystem.Models.DataStructures;

namespace EnvironmentSystem.Models.Objects
{
    public class Trail: EnvironmentObject
    {
        private int lifeSpan;

        public Trail(int x, int y, int width, int height) : this(new Rectangle(x, y, width, height))
        {
        }

        public Trail(Rectangle bounds) : base(bounds)
        {
            this.ImageProfile = new char[,] { { 'T' } };
            this.CollisionGroup = CollisionGroup.Nothing;
            this.lifeSpan = 1;
        }

        public override void Update()
        {
            lifeSpan--;
            if (lifeSpan <= 0)
            {
                this.Exists = false;
            }
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
