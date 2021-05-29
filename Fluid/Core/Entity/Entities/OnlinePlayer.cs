namespace Fluid.Core
{
    public class OnlinePlayer : Player
    {
        public override bool Is<T>() => typeof(T) == typeof(OnlinePlayer);

        private int gamemode = 1;

        public int getGamemode()
        {
            return this.gamemode;
        }
    }
}