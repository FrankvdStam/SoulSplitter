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

using System.Collections.Generic;
using System.Linq;

namespace SoulMemory.DarkSouls1;

public class DropMod(IDarkSouls1 darkSouls)
{
    public void InitBkh()
    {
        darkSouls.WriteWeaponDescription(1105000, "Dropmod!\n\nAffected:\nBlack Knight Halberd\nBlack Knight Ultra GreatSword\nBlack Knight Greatsword\nLarge Club\nShort Bow\nBalder Knight Rapier\nGargoyle's Halberd\n\n\n");
        for (var i = 0; i < 62; i++)
        {
            darkSouls.SetLoadingScreenItem(i, 1105000);
        }
        GuaranteeDrop(27901000, 1105000); //black knight halberd
        GuaranteeDrop(27900100, 355000);  //black knight ultra greatsword
        GuaranteeDrop(27900000, 310000);  //black knight greatsword
        GuaranteeDrop(28100000, 855000);  //large club
        GuaranteeDrop(25002100, 1200000); //Short Bow (affects asylum & painted world
        GuaranteeDrop(25600200, 601000);  //Balder knight rapier
        GuaranteeDrop(53500100, 1103000); //gargoyle's halberd
    }

    public void InitAllAchievements()
    {
        darkSouls.WriteWeaponDescription(1004000, "Dropmod!\n\nAffected:\nBlack Knight Halberd/Sword/Greatsword/Greataxe/Shield\nSilver Knight Straight Sword/Spear/Shield\nStone Greatsword/Greatshield\nChanneler's Trident\nSouvenir of Reprisal\nEye of Death\n\n\n\n\n");

        for (var i = 0; i < 62; i++)
        {
            darkSouls.SetLoadingScreenItem(i, 1004000);
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
        var items = darkSouls.GetInventory();

        foreach (var temp in _switchableWeapons)
        {
            var s = temp; //structs need to be put in a variable in order to be mutable. Meme.
            if (s.ShouldSwitch && items.Any(j => j.ItemType == s.SwitchItem))
            {
                GuaranteeDrop(s.RowId, s.ItemId2);
                s.ShouldSwitch = false;
            }
        }
    }

    public void ResetAllAchievements()
    {
        foreach (var temp in _switchableWeapons)
        {
            var s = temp; //structs need to be put in a variable in order to be mutable. Meme.
            s.ShouldSwitch = true;
        }
    }

    private void GuaranteeDrop(int rowId, int itemId)
    {
        darkSouls.WriteItemLotParam(rowId, (itemLot) =>
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
    

    private readonly List<SwitchableDrop> _switchableWeapons =
    [
        new (ItemType.StoneGreatsword, 23800000, 306000, 1503000),

        //Anor londo
        new (ItemType.SilverKnightStraightSword, 24100000, 208000, 1473000),
        new (ItemType.SilverKnightSpear, 24100300, 1006000, 1473000),

        //kiln
        new (ItemType.BlackKnightHalberd, 27905300, 1105000, 1474000),
        new (ItemType.BlackKnightGreataxe, 27905200, 753000, 1474000),
        new (ItemType.BlackKnightSword, 27905000, 310000, 1474000),
        new (ItemType.BlackKnightGreatsword, 27905100, 355000, 1474000),

        //Darkroot Garden
        new (ItemType.BlackKnightHalberd, 27901000, 1105000, 1474000),

        //undead burg
        new (ItemType.BlackKnightSword, 27900000, 1105000, 1474000),

        //Asylum
        new (ItemType.BlackKnightSword, 27907000, 310000, 1474000),

        //Catacombs
        new (ItemType.BlackKnightGreataxe, 27902000, 753000, 1474000),
        new (ItemType.BlackKnightHalberd, 27903000, 1105000, 1474000)
    ];

    private struct SwitchableDrop(ItemType switchItem, int rowId, int itemId1, int itemId2)
    {
        public bool ShouldSwitch = true;
        public readonly ItemType SwitchItem = switchItem;
        public readonly int RowId = rowId;
        public readonly int ItemId1 = itemId1;
        public readonly int ItemId2 = itemId2;
    }
}
