using Fluid.Core;
using System;

namespace Fluid.Core
{
    public abstract class Player : LivingEntity
    {
        public override bool Is<T>() => typeof(T) == typeof(Player);

        public int Gamemode { get; set; }

        public string Name { get; set; }

        public Guid UUID { get; set; }

        public Inventory Inventory { get; set; }
    }
}