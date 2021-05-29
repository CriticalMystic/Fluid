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
        public static List<OnlinePlayer> OnlinePlayers { get; private set; } = new();

        /// <summary>
        /// Stores OfflinePlayers
        /// </summary>
        public static List<OfflinePlayer> OfflinePlayers { get; private set; } = new();

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
            Console.WriteLine("");
            Initialized = true;
        }

        public static void Shutdown()
        {
            if (!Initialized) return;
            Initialized = false;
        }

        public static OnlinePlayer? GetOnlinePlayer(string name)
        {
            foreach (OnlinePlayer player in OnlinePlayers)
            {
                if (player.Name.Equals(name))
                {
                    return player;
                }
            }
            return null;
        }

        public static OfflinePlayer? GetOfflinePlayer(string name)
        {
            foreach (OfflinePlayer player in OfflinePlayers)
            {
                if (player.Name.Equals(name))
                {
                    return player;
                }
            }
            return null;
        }
    }
}