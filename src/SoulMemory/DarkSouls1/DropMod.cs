// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoulMemory.DarkSouls1.Parameters;
using SoulMemory.EldenRing;

namespace SoulMemory.DarkSouls1
{
    public class DropMod
    {
        private readonly DarkSouls1 _darkSouls;

        public DropMod(DarkSouls1 darkSouls)
        {
            _darkSouls = darkSouls;
        }

        public void InitBkh()
        {
            _darkSouls.WriteWeaponDescription(1105000, "Dropmod!\n\nAffected:\nBlack Knight Halberd\n\n\n\n\n\n\n\n\n\nBy Ducksual & Wasted");
            for (int i = 0; i < 62; i++)
            {
                _darkSouls.SetLoadingScreenItem(i, 1105000);
            }
            GuaranteeDrop(27901000, 1105000);
        }

        public void InitAllAchievements()
        {
            _darkSouls.WriteWeaponDescription(1004000, "Dropmod!\n\nAffected:\nBlack Knight Halberd/Sword/Greatsword/Greataxe/Shield\nSilver Knight Straight Sword/Spear/Shield\nStone Greatsword/Greatshield\nChanneler's Trident\nSouvenir of Reprisal\nEye of Death\n\n\n\n\nBy Ducksual & Wasted");

            for (int i = 0; i < 62; i++)
            {
                _darkSouls.SetLoadingScreenItem(i, 1004000);
            }
            
            //trident
            GuaranteeDrop(23700000, 1004000);
            GuaranteeDrop(23700100, 1004000);
            GuaranteeDrop(23700200, 1004000);

            //Eye of death
            GuaranteeDrop(32700000, 109);
            GuaranteeDrop(32700100, 109);

            //Souvenir
            GuaranteeDrop(23100000, 374);

            foreach (var s in _switchableWeapons)
            {
                GuaranteeDrop(s.RowId, s.ItemId1);
            }
        }

        public void UpdateAllAchievements()
        {
            var items = _darkSouls.GetInventory();

            foreach (SwitchableDrop temp in _switchableWeapons)
            {
                var s = temp; //structs need to be put in a variable in order to be mutable. Meme.
                if (s.ShouldSwitch && items.Any(j => j.ItemType == s.SwitchItem))
                {
                    //Console.WriteLine($"Switching {s.RowId} {s.SwitchItem}");
                    GuaranteeDrop(s.RowId, s.ItemId2);
                    s.ShouldSwitch = false;
                }
            }
        }

        public void ResetAllAchievements()
        {
            foreach (SwitchableDrop temp in _switchableWeapons)
            {
                var s = temp; //structs need to be put in a variable in order to be mutable. Meme.
                s.ShouldSwitch = true;
            }
        }

        private void GuaranteeDrop(int rowId, int itemId)
        {
            _darkSouls.WriteItemLotParam(rowId, (itemLot) =>
            {
                itemLot.LotItemBasePoint01 = (ushort)(itemLot.LotItemId01 == itemId ? 100 : 0);
                itemLot.LotItemBasePoint02 = (ushort)(itemLot.LotItemId02 == itemId ? 100 : 0);
                itemLot.LotItemBasePoint03 = (ushort)(itemLot.LotItemId03 == itemId ? 100 : 0);
                itemLot.LotItemBasePoint04 = (ushort)(itemLot.LotItemId04 == itemId ? 100 : 0);
                itemLot.LotItemBasePoint05 = (ushort)(itemLot.LotItemId05 == itemId ? 100 : 0);
                itemLot.LotItemBasePoint06 = (ushort)(itemLot.LotItemId06 == itemId ? 100 : 0);
                itemLot.LotItemBasePoint07 = (ushort)(itemLot.LotItemId07 == itemId ? 100 : 0);
                itemLot.LotItemBasePoint08 = (ushort)(itemLot.LotItemId08 == itemId ? 100 : 0);
            });
        }
        

        private List<SwitchableDrop> _switchableWeapons = new List<SwitchableDrop>()
        {
            //Darkroot
            new SwitchableDrop(ItemType.StoneGreatsword          , 23800000, 306000 , 1503000),

            //Anor londo
            new SwitchableDrop(ItemType.SilverKnightStraightSword, 24100000, 208000 , 1473000),
            new SwitchableDrop(ItemType.SilverKnightSpear        , 24100300, 1006000, 1473000),
            
            //kiln
            new SwitchableDrop(ItemType.BlackKnightHalberd       , 27905300, 1105000, 1474000),
            new SwitchableDrop(ItemType.BlackKnightGreataxe      , 27905200, 753000 , 1474000),
            new SwitchableDrop(ItemType.BlackKnightSword         , 27905000, 310000 , 1474000),
            new SwitchableDrop(ItemType.BlackKnightGreatsword    , 27905100, 355000 , 1474000),
            
            //Darkroot Garden
            new SwitchableDrop(ItemType.BlackKnightHalberd       , 27901000, 1105000, 1474000),
            
            //undead burg
            new SwitchableDrop(ItemType.BlackKnightSword         , 27900000, 1105000, 1474000),

            //Asylum
            new SwitchableDrop(ItemType.BlackKnightSword         , 27907000, 310000 , 1474000),

            //Catacombs
            new SwitchableDrop(ItemType.BlackKnightGreataxe      , 27902000, 753000 , 1474000),
            new SwitchableDrop(ItemType.BlackKnightHalberd       , 27903000, 1105000, 1474000),
        };

        private struct SwitchableDrop
        {
            public SwitchableDrop(ItemType switchItem, int rowId, int itemId1, int itemId2)
            {
                ShouldSwitch = true;
                SwitchItem   = switchItem  ;
                RowId        = rowId       ;
                ItemId1      = itemId1     ;
                ItemId2      = itemId2     ;
            }
            
            public bool ShouldSwitch;
            public ItemType SwitchItem;
            public int RowId;
            public int ItemId1;
            public int ItemId2;
        }
    }
}
