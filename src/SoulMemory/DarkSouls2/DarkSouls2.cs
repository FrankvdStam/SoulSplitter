using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.DarkSouls2.Sotfs;
using SoulMemory.DarkSouls2.Vanilla;

namespace SoulMemory.DarkSouls2
{
    public class DarkSouls2
    {
        private IDarkSouls2 _darkSouls2;
        private Process _process;

        public DarkSouls2()
        {
            Refresh();
        }

        /// <summary>
        /// Returns true if the game is currently attached
        /// </summary>
        public bool IsAttached => _process != null;



        /// <summary>
        /// Returns the kill count of a given boss, affected by ng+ state and bonfire ascetics.
        /// </summary>
        /// <param name="bossType"></param>
        /// <returns></returns>
        public int GetBossKillCount(BossType bossType)
        {
            return _darkSouls2?.GetBossKillCount(bossType) ?? 0;
        }


        /// <summary>
        /// Setting this to true will disable the AI globally
        /// </summary>
        public bool DisableAllAi
        {
            get => _darkSouls2 != null && _darkSouls2.DisableAllAi;
            set
            {
                if (_darkSouls2 != null)
                {
                    _darkSouls2.DisableAllAi = value;
                }
            }
        }

        /// <summary>
        /// Gets/sets the damage multiplier for right weapon 1. Default value is 1
        /// </summary>
        public float RightWeapon1DamageMultiplier
        {
            get
            {
                if (_darkSouls2 != null)
                {
                    return _darkSouls2.RightWeapon1DamageMultiplier;
                }
                return 0;
            }
            set
            {
                if (_darkSouls2 != null)
                {
                    _darkSouls2.RightWeapon1DamageMultiplier = value;
                }
            }
        }

        public float LeftWeapon1DamageMultiplier
        {
            get => _darkSouls2.LeftWeapon1DamageMultiplier;
            set => _darkSouls2.LeftWeapon1DamageMultiplier = value;
        }


        public bool Loaded => _darkSouls2 != null && _darkSouls2.Loaded;

        public bool Gravity
        {
            get => _darkSouls2.Gravity;
            set => _darkSouls2.Gravity = value;
        }


        public ushort LastBonfireId
        {
            get => _darkSouls2.LastBonfireId;
            set => _darkSouls2.LastBonfireId = value;
        }

        public int LastBonfireAreaId
        {
            get => _darkSouls2.LastBonfireAreaId;
            set => _darkSouls2.LastBonfireAreaId = value;
        }

        public bool Warp(ushort id, bool rest = false)
        {
            if (_darkSouls2 != null)
            {
                return _darkSouls2.Warp(id, rest);
            }
            return false;
        }

        public void Warp(WarpType warpType, bool rest = false)
        {
            if (_darkSouls2 != null)
            {
                _darkSouls2.Warp(warpType, rest);
            }
        }

        public float StableX
        {
            get => _darkSouls2.StableX;
            set => _darkSouls2.StableX = value;
        }

        public float StableY
        {
            get => _darkSouls2.StableY;
            set => _darkSouls2.StableY = value;
        }

        public float StableZ
        {
            get => _darkSouls2.StableZ;
            set => _darkSouls2.StableZ = value;
        }

        public float AngX
        {
            get => _darkSouls2.AngX;
            set => _darkSouls2.AngX = value;
        }

        public float AngY
        {
            get => _darkSouls2.AngY;
            set => _darkSouls2.AngY = value;
        }

        public float AngZ
        {
            get => _darkSouls2.AngZ;
            set => _darkSouls2.AngZ = value;
        }

        /// <summary>
        /// Refreshes the process attachment, should be called every frame. Returns true if the game is attached
        /// </summary>
        /// <returns></returns>
        public bool Refresh()
        {
            if (_darkSouls2 == null)
            {
                var process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.StartsWith("DarkSoulsII"));
                if (process != null)
                {
                    var isScholar = process.MainModule.FileName.ToLower().Contains("scholar");

                    if (isScholar)
                    {
                        //var dsHook = new DarkSouls2SotfsHook(5000, 5000);
                        //dsHook.Refresh();
                        //_darkSouls2 = dsHook;
                    }
                    else
                    {
                        //var dsHook = new DarkSouls2VanillaHook(5000, 5000);
                        //dsHook.Refresh();
                        //_darkSouls2 = dsHook;
                    }
                }
            }
            else
            {
                //if (!_darkSouls2.Setup())
                //{
                //    _darkSouls2 = null;
                //}
            }

            return _darkSouls2 != null;
        }
    }
}
