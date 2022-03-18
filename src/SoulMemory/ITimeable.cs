using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory
{
    public interface ITimeable
    {
        /// <summary>
        /// Gets the current in game time in milliseconds.
        /// </summary>
        /// <returns></returns>
        int GetInGameTimeMilliseconds();

        /// <summary>
        /// Only returns true when the game is loaded and the timer should be running. False during load screens or on the main menu.
        /// </summary>
        /// <returns></returns>
        bool IsInGame();

        ///// <summary>
        ///// Returns true when the auto start conditions for a specific game are detected
        ///// </summary>
        ///// <returns></returns>
        //bool StartAutomatically();

        /// <summary>
        /// Returns true when initial load removal conditions have been met
        /// </summary>
        /// <returns></returns>
        bool InitialLoadRemoval();

        /// <summary>
        /// Reset IGT for initial load removal
        /// </summary>
        void ResetIgt();
    }
}
