using System;
using System.Collections.Generic;
using EnvironmentSystem.Models.DataStructures;

namespace EnvironmentSystem.Models.Objects
{
    public class Star: EnvironmentObject
    {
        private const int turnBlinker = 10;

        private static readonly Random randomGenerator = new Random();
        private int turnCounter;

        public Star(int x, int y, int width, int height) : this(new Rectangle(x, y, width, height))
        {
        }

        public Star(Rectangle bounds) : base(bounds)
        {
            this.ImageProfile = new char[,] { { GetStarType()} };
            this.CollisionGroup = CollisionGroup.Nothing;
        }

        public override void Update()
        {
            if (this.turnCounter % turnBlinker == 0)
            {
                this.ImageProfile = new char[,] { { GetStarType() } };
            }

            this.turnCounter++;
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {

            var hitObjectGroup = collisionInfo.HitObject.CollisionGroup;
            if (hitObjectGroup == CollisionGroup.Explosion)
            {
                this.Exists = false;
            }

        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new EnvironmentObject[0];
        }

        private char GetStarType()
        {
            int rNumber = randomGenerator.Next(1, 4);
           
            switch (rNumber)
            {
                case 1:
                    return 'O';
                case 2:
                    return '@';
                case 3:
                    return '0';
                default:
                    return '\0';
            }
        }
    }
}
