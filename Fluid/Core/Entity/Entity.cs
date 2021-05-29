namespace Fluid.Core
{
    public abstract class Entity
    {
        /// <summary>
        /// Checks if the other type is the same type of the inheritor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>The result</returns>
        public abstract bool Is<T>();

        public float Health { get; set; }

        public float MaxHealth { get; set; }
    }
}