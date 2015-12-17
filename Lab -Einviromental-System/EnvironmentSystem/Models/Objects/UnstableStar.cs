using System;
using System.Collections.Generic;

namespace EnvironmentSystem.Models.Objects
{
    public class UnstableStar : FallingStar
    {
        private const int radius = 2;

        private int lifetime;

        public UnstableStar(int x, int y, int width, int height, Point direction, int lifetime = 8)
            : base(x, y, width, height, direction)
        {
            this.lifetime = lifetime;
            this.ImageProfile = new char[,] { { 'E' } };
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObjectGroup = collisionInfo.HitObject.CollisionGroup;
            if (hitObjectGroup == CollisionGroup.Ground)
            {
                this.Exists = false;
            }
        }

        public override void Update()
        {
            this.Bounds.TopLeft.X += this.Direction.X;
            this.Bounds.TopLeft.Y += this.Direction.Y;
            this.lifetime--;
            if (lifetime <= 0)
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

            if (!Exists)
            {
                trails.Add(new Explosion(this.Bounds.TopLeft.X, this.Bounds.TopLeft.Y, 2, 2));
            }

            return trails;
        }
    }
}
