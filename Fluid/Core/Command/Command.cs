namespace Fluid.Core
{
    public abstract class Command
    {
        /// <summary>
        /// Is being displayed when calling /help
        /// </summary>
        public abstract string FullName { get; }
        
        /// <summary>
        /// Is being used to determine the commandname /...
        /// </summary>
        public abstract string CommandName { get; }
    }
}