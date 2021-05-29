using Fluid.Core.Inventories;

namespace Fluid.Core
{
    public abstract class Player : Entity
    {
        public override bool Is<T>() => typeof(T) == typeof(Player);

        public int Gamemode { get; set; }

        public string Name { get; set; }

        public Inventory Inventory { get; set; }
    }
}