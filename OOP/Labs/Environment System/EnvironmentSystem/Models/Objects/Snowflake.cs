﻿namespace EnvironmentSystem.Models.Objects
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
            if (hitObjectGroup == CollisionGroup.Ground ||
                hitObjectGroup == CollisionGroup.Snow ||
                hitObjectGroup == CollisionGroup.Explosion)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            var producedObjects = new List<EnvironmentObject>();
            if (!this.Exists)
            {
                producedObjects.Add(new Snow(this.Bounds.TopLeft.X, this.Bounds.TopLeft.Y - 1, 1, 1));
            }
            return producedObjects;
        }
    }
}
