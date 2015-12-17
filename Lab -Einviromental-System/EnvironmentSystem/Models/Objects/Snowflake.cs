namespace EnvironmentSystem.Models.Objects
{
    using System.Collections.Generic;

    public class Snowflake : MovingObject
    {
        public Snowflake(int x, int y, int width, int height, Point direction)
            : base(x, y, width, height, direction)
        {
            this.ImageProfile = this.GenerateImageProfile();
            this.CollisionGroup = CollisionGroup.Snowflake;
        }

        protected virtual char[,] GenerateImageProfile()
        {
            return new char[,] { { '*' } };
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObjectGroup = collisionInfo.HitObject.CollisionGroup ;
            if (hitObjectGroup == CollisionGroup.Ground)
            {
                this.Exists = false;
            }

            if (hitObjectGroup == CollisionGroup.Snow)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            var list = new List<Snow>(0);

            if (!this.Exists)
            {
                
                list.Add(new Snow(this.Bounds.TopLeft.X, this.Bounds.TopLeft.Y - 1, 1, 1));
                return list;
            }
            return list;
        }

    }
}
