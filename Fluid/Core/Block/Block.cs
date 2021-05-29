namespace Fluid.Core
{
    public abstract class Block
    {
        /// <summary>
        /// Checks if the other type is the same type of the inheritor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public abstract bool Is<T>();
        
        /// <summary>
        /// Copies this object
        /// </summary>
        /// <returns>Copy of this object</returns>
        public abstract Block Copy();
    }
}