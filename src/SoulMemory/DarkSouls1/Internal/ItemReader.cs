using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulMemory.DarkSouls1;

namespace SoulMemory.DarkSouls1.Internal
{
    internal static class ItemReader
    {
        /// <summary>
        /// It turns out that the games store items in the same way. Since there is quite a bit of code, I opted to share this function between PTDE/remastered.
        /// The path to the start of the list and the counts is different, so those are the input of this function. Optimizations applied to this code
        /// will cause a speedup for both games.
        ///
        /// It turns out doing a read of 28 * 2048 bytes and working from there is faster than doing individual reads, hence they data array
        /// </summary>
        internal static List<Item> GetCurrentInventoryItems(byte[] data, int listCount, int itemCount, int keyCount)
        {
            //Path (remastered): GameDataMan->hostPlayerGameData->equipGameData->equipInventoryData->equipInventoryDataSub
            

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
                    switch (cat.ToHex())
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
                    if (categories.Contains(ItemCategory.Consumables) && item >= 200 && item <= 215 && !items.Any(j => j.Type == ItemType.EstusFlask))
                    {
                        var estus = Item.AllItems.First(j => j.Type == ItemType.EstusFlask);
                        var instance = new Item(estus.Name, estus.Id, estus.Type, estus.Category, estus.StackLimit, estus.Upgrade);

                        //Item ID is both the item + reinforcement. Level field does not change in the games memory for the estus flask.
                        //Goes like this:
                        //200 == empty level 0
                        //201 == full level 0
                        //202 == empty level 1
                        //203 == full level 1
                        //203 == empty level 2
                        //204 == full level 2
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
                        var instance = new Item(lookupItem.Name, lookupItem.Id, lookupItem.Type, lookupItem.Category, lookupItem.StackLimit, lookupItem.Upgrade);
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
}
