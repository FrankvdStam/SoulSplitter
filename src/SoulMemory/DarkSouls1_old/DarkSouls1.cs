using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SoulMemory.DarkSouls1_Old.Internal;

namespace SoulMemory.DarkSouls1_Old
{
    public class DarkSouls1
    {
        public DarkSouls1()
        {
            Refresh();
        }

        private IDarkSouls _darkSouls;



        /// <summary>
        /// Returns the in game time in millisecond format. Returns 0 when in a menu, returns the clock value during a loading screen and starts running when fully loaded into the game.
        /// </summary>
        /// <returns></returns>
        public int GetGameTimeInMilliseconds()
        {
            if (_darkSouls == null)
            {
                return 0;
            }

            return _darkSouls.GetGameTimeInMilliseconds();
        }


        /// <summary>
        /// Checks if IGT clock is running, if it is running, the player has to be loaded.
        /// </summary>
        /// <returns></returns>
        public bool IsPlayerLoaded()
        {
            if (_darkSouls == null)
            {
                return false;
            }

            return _darkSouls.IsPlayerLoaded();
        }

        /// <summary>
        /// Returns true if the given boss is still alive.
        /// </summary>
        /// <param name="boss"></param>
        /// <returns></returns>
        public bool IsBossDefeated(BossType boss)
        {
            if (_darkSouls == null)
            {
                return false;
            }

            return _darkSouls.IsBossDefeated(boss);
        }

        /// <summary>
        /// Returns the player's position
        /// </summary>
        /// <returns></returns>
        public Vector3f GetPlayerPosition()
        {
            if (_darkSouls == null)
            {
                return new Vector3f(0,0,0);
            }

            return _darkSouls.GetPlayerPosition();
        }


        /// <summary>
        /// Returns the current amount of health the player has
        /// </summary>
        /// <returns></returns>
        public int GetPlayerHealth()
        {
            if (_darkSouls == null)
            {
                return 0;
            }

            return _darkSouls.GetPlayerHealth();
        }

        /// <summary>
        /// Returns the currently active covenant
        /// </summary>
        /// <returns></returns>
        public CovenantType GetCovenant()
        {
            if (_darkSouls == null)
            {
                return CovenantType.None;
            }

            return _darkSouls.GetCovenant();
        }


        /// <summary>
        /// Returns a list of the current inventory items
        /// </summary>
        /// <returns></returns>
        public List<Item> GetInventory()
        {
            if (_darkSouls == null)
            {
                return new List<Item>();
            }

            return _darkSouls.GetInventory();
        }


        /// <summary>
        /// Returns the state of the given bonfire
        /// </summary>
        /// <returns></returns>
        public BonfireState GetBonfireState(Bonfire bonfire)
        {
            if (_darkSouls == null)
            {
                return BonfireState.Undiscovered;
            }

            return _darkSouls.GetBonfireState(bonfire);
        }


        /// <summary>
        /// Returns the current zone
        /// </summary>
        /// <returns></returns>
        public ZoneType GetZone()
        {
            if (_darkSouls == null)
            {
                return ZoneType.Unknown;
            }

            return _darkSouls.GetZone();
        }
        

        /// <summary>
        /// Resets inventory indices
        /// </summary>
        public void ResetInventoryIndices()
        {
            if (_darkSouls == null)
            {
                return;
            }

            _darkSouls.ResetInventoryIndices();
        }


        /// <summary>
        /// Returns the clear count. 0 means ng, 1 means ng+, etc.
        /// </summary>
        public int GetClearCount()
        {
            if (_darkSouls == null)
            {
                return 0;
            }

            return _darkSouls.GetClearCount();
        }

        /// <summary>
        /// Check if arbitrary flag is set
        /// </summary>
        public bool CheckFlag(int flag)
        {
            if (_darkSouls == null)
            {
                return false;
            }

            return _darkSouls.CheckFlag(flag);
        }

        /// <summary>
        /// Returns true if the game is currently attached and memory can be read.
        /// </summary>
        public bool IsGameAttached => _darkSouls != null;


        /// <summary>
        /// Refreshes the process attachment, should be called every frame. Returns true if the game is attached
        /// </summary>
        /// <returns></returns>
        public bool Refresh()
        {
            if (_darkSouls == null)
            {
                var process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower().StartsWith("darksouls"));
                if (process != null)
                {
                    if (process.ProcessName == "DarkSoulsRemastered")
                    {
                        _darkSouls = new DarkSoulsRemastered();
                    }

                    if (process.ProcessName == "DARKSOULS")
                    {
                        _darkSouls = new DarkSoulsPtde();
                    }
                }
            }
            else
            {
                if (!_darkSouls.Attach())
                {
                    _darkSouls = null;
                }
            }

            return _darkSouls != null;
        }
        
        public int GetTestValue()
        {
            if (_darkSouls == null)
            {
                return 0;
            }

            return _darkSouls.GetTestValue();
        }

        public void SetCheat(CheatType cheatType, bool enabled)
        {
            if (_darkSouls == null)
            {
                return;
            }
            _darkSouls.SetCheat(cheatType, enabled);
        }

        public void BonfireWarp(WarpType warpType)
        {
            if (_darkSouls == null)
            {
                return;
            }
            _darkSouls.BonfireWarp(warpType);
        }

        public void Teleport(Vector3f position, float angle)
        {
            if (_darkSouls == null)
            {
                return;
            }
            _darkSouls.Teleport(position, angle);
        }
    }
}
