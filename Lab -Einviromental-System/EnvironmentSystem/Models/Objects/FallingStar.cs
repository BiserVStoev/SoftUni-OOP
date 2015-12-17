using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace EnvironmentSystem.Models.Objects
{
    public class FallingStar: MovingObject
    {
        public FallingStar(int x, int y, int width, int height, Point direction)
            : base(x, y, width, height, direction)
        {
            this.ImageProfile = new char[,] { { 'O' } };
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObjectGroup = collisionInfo.HitObject.CollisionGroup;
            if (hitObjectGroup == CollisionGroup.Ground || hitObjectGroup == CollisionGroup.Explosion)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            var trails = new List<EnvironmentObject>();

            if (Exists)
            {
                trails.Add(new Trail(this.Bounds.TopLeft.X - this.Direction.X, this.Bounds.TopLeft.Y - this.Direction.Y, 1, 1));
                trails.Add(new Trail(this.Bounds.TopLeft.X - 2 * this.Direction.X, this.Bounds.TopLeft.Y - 2 * this.Direction.Y, 1, 1));
                trails.Add(new Trail(this.Bounds.TopLeft.X - 3 * this.Direction.X, this.Bounds.TopLeft.Y - 3 * this.Direction.Y, 1, 1));
            }

            return trails;
        }
    }
}
