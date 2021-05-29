namespace Fluid.Core
{
    public abstract class Player : Entity
    {
        public override bool Is<T>() => typeof(T) == typeof(Player);
    }
}