using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls2
{
    public interface IDarkSouls2
    {

        /// <summary>
        /// Returns the kill count of a given boss, affected by ng+ state and bonfire ascetics.
        /// </summary>
        /// <param name="bossType"></param>
        /// <returns></returns>
        int GetBossKillCount(BossType bossType);



        /// <summary>
        /// Setting this to true will disable the AI globally
        /// </summary>
        bool DisableAllAi { get; set; }

        /// <summary>
        /// Gets/sets the damage multiplier for right weapon 1. Default value is 1
        /// </summary>
        float RightWeapon1DamageMultiplier { get; set; }

        /// <summary>
        /// Gets/sets the damage multiplier for left weapon 1. Default value is 1
        /// </summary>
        float LeftWeapon1DamageMultiplier { get; set; }

        /// <summary>
        /// Set to true when the game is loaded into a save file, false when loading or in main menu
        /// </summary>
        bool Loaded { get; }

        /// <summary>
        /// Get or set gravity
        /// </summary>
        bool Gravity { get; set; }


        ushort LastBonfireId { get; set; }
        int LastBonfireAreaId { get; set; }
        bool Warp(ushort id, bool rest = false);
        void Warp(WarpType warpType, bool rest = false);

        float StableX { get; set; }
        float StableY { get; set; }
        float StableZ { get; set; }
        float AngX    { get; set; }
        float AngY    { get; set; }
        float AngZ    { get; set; }
    }
}
