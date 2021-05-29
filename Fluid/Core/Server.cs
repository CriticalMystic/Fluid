using System;
using System.Collections.Generic;
using System.Globalization;

namespace Fluid.Core
{
    /// <summary>
    /// This is the core instance of this server, the server itself 
    /// </summary>
    public static class Server
    {
        // Instance
        
        /// <summary>
        /// This variable is being used to determine if the server is ready to use
        /// </summary>
        private static bool Initialized { get; set; } = false;
        
        // Players
        
        /// <summary>
        /// Stores OnlinePlayers
        /// </summary>
        public static List<OnlinePlayer> Players { get; private set; } = new();

        /// <summary>
        /// Determines the maximal playercount
        /// </summary>
        public static uint MaxPlayerCount { get; private set; } = 32;

        // World

        /// <summary>
        /// Determines if the server saves the game state automatically
        /// </summary>
        public static bool AutoSave { get; private set; } = true;

        // Language
        
        /// <summary>
        /// Determines the language and in which language display messages are being displayed 
        /// </summary>
        public static CultureInfo Language { get; private set; } = CultureInfo.CurrentCulture;
        
        // Worlds
        
        /// <summary>
        /// Stores the references of the current worlds
        /// </summary>
        public static List<World> Worlds { get; private set; } = new();
        
        // Random

        /// <summary>
        /// This value can generate random numbers
        /// </summary>
        public static Random Random { get; set; } = new();

        /// <summary>
        /// Starts the Server
        /// </summary>
        public static void Start()
        {
            if (Initialized) return;
            Initialized = true;
        }

        public static void Shutdown()
        {
            if (!Initialized) return;
            Initialized = false;
        }
        

        public OnlinePlayer getOnlinePlayer(string name)
        {
            foreach(OnlinePlayer player in Players)
            {
                player.Name.Equals(name);
            }
        }
    }
}