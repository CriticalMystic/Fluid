using System;

namespace Fluid.Core
{
    /// <summary>
    /// Represents a Minecraft World
    /// </summary>
    public class World
    {
        // Chat
        
        /// <summary>
        /// This is the holder of the WorldChat where players can communicate inside of this world
        /// </summary>
        public WorldChat Chat = new();
        
        // Random
        
        /// <summary>
        /// This value can generate random numbers
        /// </summary>
        public static Random Random { get; set; } = new();


    }
}