namespace Fluid.Core
{
    public abstract class OfflinePlayer : Player
    {
        public override bool Is<T>() => typeof(T) == typeof(OfflinePlayer);
    }
}