namespace Fluid.Core
{
    public class OfflinePlayer : Player
    {
        public override bool Is<T>() => typeof(T) == typeof(OfflinePlayer);
    }
}