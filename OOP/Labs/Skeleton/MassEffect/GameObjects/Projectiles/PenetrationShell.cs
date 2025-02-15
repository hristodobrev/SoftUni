﻿namespace MassEffect.GameObjects.Projectiles
{
    using Interfaces;
    public class PenetrationShell : Projectile
    {
        public PenetrationShell(int damage)
            : base(damage)
        {

        }

        public override void Hit(IStarship ship)
        {
            ship.Health -= this.Damage;
        }
    }
}
