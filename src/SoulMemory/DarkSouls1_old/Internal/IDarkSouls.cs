using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls1_Old.Internal
{
    internal interface IDarkSouls
    {
        /// <summary>
        /// Hooks the game's process. Should be called every so often to ensure the game is still running.
        /// </summary>
        /// <returns></returns>
        bool Attach();


        /// <summary>
        /// Returns the in game time in millisecond format. Returns 0 when in a menu, returns the clock value during a loading screen and starts running when fully loaded into the game.
        /// </summary>
        /// <returns></returns>
        int GetGameTimeInMilliseconds();


        /// <summary>
        /// Checks if IGT clock is running, if it is running, the player has to be loaded.
        /// </summary>
        /// <returns></returns>
        bool IsPlayerLoaded();

        /// <summary>
        /// Returns true if the given boss is still alive.
        /// </summary>
        /// <param name="boss"></param>
        /// <returns></returns>
        bool IsBossDefeated(BossType boss);

        
        /// <summary>
        /// Returns a list of the current inventory items
        /// </summary>
        /// <returns></returns>
        List<Item> GetInventory();


        /// <summary>
        /// Returns the player's position
        /// </summary>
        /// <returns></returns>
        Vector3f GetPlayerPosition();


        /// <summary>
        /// Returns the state of the given bonfire
        /// </summary>
        /// <returns></returns>
        BonfireState GetBonfireState(Bonfire bonfire);

        /// <summary>
        /// Returns the current zone
        /// </summary>
        /// <returns></returns>
        ZoneType GetZone();


        /// <summary>
        /// Resets inventory indices
        /// </summary>
        void ResetInventoryIndices();


        /// <summary>
        /// Returns the current area
        /// </summary>
        /// <returns></returns>
        Area GetArea();

        /// <summary>
        /// Returns the current amount of health the player has
        /// </summary>
        /// <returns></returns>
        int GetPlayerHealth();

        /// <summary>
        /// Returns the currently active covenant
        /// </summary>
        /// <returns></returns>
        CovenantType GetCovenant();

        /// <summary>
        /// Returns the clear count. 0 means ng, 1 means ng+, etc.
        /// </summary>
        /// <returns></returns>
        int GetClearCount();

        /// <summary>
        /// Check if arbitrary flag is set
        /// </summary>
        bool CheckFlag(int flag);

        
        int GetTestValue();
        void SetCheat(CheatType cheatType, bool enabled);
        void BonfireWarp(WarpType warpType);
        void Teleport(Vector3f position, float angle);
    }
}
