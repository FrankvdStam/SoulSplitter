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

namespace SoulMemory.DarkSouls1;

internal static class ItemReader
{
    internal static List<Item> GetCurrentInventoryItems(byte[] data, int listCount, int itemCount, int keyCount)
    {
        var items = new List<Item>();
        
        for (var i = 0; i < listCount; i++)
        {
            //size of NS::FRPG_EquipInventoryDataItem is 28 or 0x1c
            var address = i * 0x1c;
            var cat = data[address + 3];
            var item = BitConverter.ToInt32(data, address + 4);
            var quantity = BitConverter.ToInt32(data, address + 8);
            
            if (item != -1)
            {
                var categories = new List<ItemCategory>();
                var hex = cat.ToString("X");
                var hexCat = int.Parse(hex[0].ToString());

                switch (hexCat)
                {
                    case 0:
                        categories.Add(ItemCategory.MeleeWeapons);
                        categories.Add(ItemCategory.RangedWeapons);
                        categories.Add(ItemCategory.Ammo);
                        categories.Add(ItemCategory.Shields);
                        categories.Add(ItemCategory.SpellTools);
                        break;

                    case 1:
                        categories.Add(ItemCategory.Armor);
                        break;

                    case 2:
                        categories.Add(ItemCategory.Rings);
                        break;

                    case 4:
                        categories.Add(ItemCategory.Consumables);
                        categories.Add(ItemCategory.Key);
                        categories.Add(ItemCategory.Spells);
                        categories.Add(ItemCategory.UpgradeMaterials);
                        categories.Add(ItemCategory.UsableItems);
                        break;
                }

                //Decode item
                int id = 0;
                ItemInfusion infusion = ItemInfusion.Normal;
                int level = 0;

                //if 4 or less digits -> non-upgradable item.
                if (categories.Contains(ItemCategory.Consumables) && item >= 200 && item <= 215 && !items.Any(j => j.ItemType == ItemType.EstusFlask))
                {
                    var estus = Item.AllItems.First(j => j.ItemType == ItemType.EstusFlask);
                    var instance = new Item(estus.Name, estus.Id, estus.ItemType, estus.Category, estus.StackLimit, estus.Upgrade);

                    //Item ID is both the item + reinforcement. Level field does not change in the games memory for the estus flask.
                    //Goes like this:
                    //200 == empty level 0
                    //201 == full  level 0
                    //202 == empty level 1
                    //203 == full  level 1
                    //203 == empty level 2
                    //204 == full  level 2
                    //etc

                    //If the flask is not empty, the amount of charges is stored in the quantity field.
                    //If the ID - 200 is an even number, the flask is empty. For this case we can even ignore the 200 and just check the ID

                    instance.Quantity = item % 2 == 0 ? 0 : quantity;

                    //Calculating the upgrade level
                    instance.UpgradeLevel = (item - 200) / 2;

                    instance.Infusion = infusion;
                    items.Add(instance);
                    continue;
                }
                else if (item < 10000)
                {
                    id = item;
                }
                else
                {
                    //Separate digits
                    int one = item % 10;
                    int ten = (item / 10) % 10;
                    int hundred = (item / 100) % 10;

                    id = item - (one + (10 * ten) + (100 * hundred));
                    infusion = (ItemInfusion)hundred;
                    level = one + (10 * ten);
                }

                var lookupItem = Item.AllItems.FirstOrDefault(j => categories.Contains(j.Category) && j.Id == id);
                if (lookupItem != null)
                {
                    var instance = new Item(lookupItem.Name, lookupItem.Id, lookupItem.ItemType, lookupItem.Category, lookupItem.StackLimit, lookupItem.Upgrade);
                    instance.Quantity = quantity;
                    instance.Infusion = infusion;
                    instance.UpgradeLevel = level;
                    items.Add(instance);
                }
            }
        }

        return items;
    }
}
