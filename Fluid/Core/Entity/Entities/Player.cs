namespace Fluid.Core
{
    public abstract class Player : Entity
    {
        public override bool Is<T>() => typeof(T) == typeof(Player);

        private int _gamemode;
        public int Gamemode
        {
            get { return _gamemode; }
            set { _gamemode = value; }
        }

        
    }
}