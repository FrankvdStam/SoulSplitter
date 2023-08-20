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
using System.Collections.ObjectModel;
using System.Security.Cryptography;

namespace SoulMemory.DarkSouls1
{
    public class Item
    {
        public Item(string name, int id, ItemType itemType, ItemCategory category, int stackLimit, ItemUpgrade upgrade)
        {
            Name = name;
            Id = id;
            ItemType = itemType;
            Category = category;
            StackLimit = stackLimit;
            Upgrade = upgrade;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public ItemType ItemType { get; set; }
        public ItemCategory Category { get; set; }
        public int StackLimit { get; set; }
        public int Quantity { get; set; }
        public ItemUpgrade Upgrade { get; set; }
        public ItemInfusion Infusion { get; set; }
        public int UpgradeLevel { get; set; }

        //For display in debugger
        public override string ToString()
        {
            return $"{Name} {Quantity}";
        }



        public int GetGameValue()
        {
            int id = (int)ItemType;
            if (Upgrade == ItemUpgrade.PyroFlame || Upgrade == ItemUpgrade.PyroFlameAscended)
            {
                id += UpgradeLevel * 100;
            }
            else
            {
                id += UpgradeLevel;
            }

            if (Upgrade == ItemUpgrade.Infusable || Upgrade == ItemUpgrade.InfusableRestricted)
            {
                id += (int)Upgrade;
            }
            return id;
        }

        public int MaxUpgrade
        {
            get
            {
                switch (Infusion)
                {
                    default: throw new NotSupportedException($"Unknown infusion type: {Infusion}");
                    case ItemInfusion.Normal: return 15;
                    case ItemInfusion.Chaos: return 5;
                    case ItemInfusion.Crystal: return 5;
                    case ItemInfusion.Divine: return 10;
                    case ItemInfusion.Enchanted: return 5;
                    case ItemInfusion.Fire: return 10;
                    case ItemInfusion.Lightning: return 5;
                    case ItemInfusion.Magic: return 10;
                    case ItemInfusion.Occult: return 5;
                    case ItemInfusion.Raw: return 5;
                }
            }
        }

        public bool RestrictUpgrade
        {
            get
            {
                switch (Infusion)
                {
                    default: throw new NotSupportedException($"Unknown infusion type: {Infusion}");
                    case ItemInfusion.Normal: return false;
                    case ItemInfusion.Chaos: return true;
                    case ItemInfusion.Crystal: return false;
                    case ItemInfusion.Divine: return false;
                    case ItemInfusion.Enchanted: return true;
                    case ItemInfusion.Fire: return false;
                    case ItemInfusion.Lightning: return false;
                    case ItemInfusion.Magic: return false;
                    case ItemInfusion.Occult: return true;
                    case ItemInfusion.Raw: return true;
                }
            }
        }
        
        public static readonly ReadOnlyCollection<Item> AllItems = new ReadOnlyCollection<Item>(new List<Item>()
        {
            new Item("Catarina Helm"                                    ,   10000, ItemType.CatarinaHelm                           , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Catarina Armor"                                   ,   11000, ItemType.CatarinaArmor                          , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Catarina Gauntlets"                               ,   12000, ItemType.CatarinaGauntlets                      , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Catarina Leggings"                                ,   13000, ItemType.CatarinaLeggings                       , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Paladin Helm"                                     ,   20000, ItemType.PaladinHelm                            , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Paladin Armor"                                    ,   21000, ItemType.PaladinArmor                           , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Paladin Gauntlets"                                ,   22000, ItemType.PaladinGauntlets                       , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Paladin Leggings"                                 ,   23000, ItemType.PaladinLeggings                        , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Dark Mask"                                        ,   40000, ItemType.DarkMask                               , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Dark Armor"                                       ,   41000, ItemType.DarkArmor                              , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Dark Gauntlets"                                   ,   42000, ItemType.DarkGauntlets                          , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Dark Leggings"                                    ,   43000, ItemType.DarkLeggings                           , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Brigand Hood"                                     ,   50000, ItemType.BrigandHood                            , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Brigand Armor"                                    ,   51000, ItemType.BrigandArmor                           , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Brigand Gauntlets"                                ,   52000, ItemType.BrigandGauntlets                       , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Brigand Trousers"                                 ,   53000, ItemType.BrigandTrousers                        , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Shadow Mask"                                      ,   60000, ItemType.ShadowMask                             , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Shadow Garb"                                      ,   61000, ItemType.ShadowGarb                             , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Shadow Gauntlets"                                 ,   62000, ItemType.ShadowGauntlets                        , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Shadow Leggings"                                  ,   63000, ItemType.ShadowLeggings                         , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Black Iron Helm"                                  ,   70000, ItemType.BlackIronHelm                          , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Black Iron Armor"                                 ,   71000, ItemType.BlackIronArmor                         , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Black Iron Gauntlets"                             ,   72000, ItemType.BlackIronGauntlets                     , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Black Iron Leggings"                              ,   73000, ItemType.BlackIronLeggings                      , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Smough's Helm"                                    ,   80000, ItemType.SmoughsHelm                            , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Smough's Armor"                                   ,   81000, ItemType.SmoughsArmor                           , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Smough's Gauntlets"                               ,   82000, ItemType.SmoughsGauntlets                       , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Smough's Leggings"                                ,   83000, ItemType.SmoughsLeggings                        , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Six-Eyed Helm of the Channelers"                  ,   90000, ItemType.SixEyedHelmoftheChannelers             , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Robe of the Channelers"                           ,   91000, ItemType.RobeoftheChannelers                    , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Gauntlets of the Channelers"                      ,   92000, ItemType.GauntletsoftheChannelers               , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Waistcloth of the Channelers"                     ,   93000, ItemType.WaistclothoftheChannelers              , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Helm of Favor"                                    ,  100000, ItemType.HelmofFavor                            , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Embraced Armor of Favor"                          ,  101000, ItemType.EmbracedArmorofFavor                   , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Gauntlets of Favor"                               ,  102000, ItemType.GauntletsofFavor                       , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Leggings of Favor"                                ,  103000, ItemType.LeggingsofFavor                        , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Helm of the Wise"                                 ,  110000, ItemType.HelmoftheWise                          , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Armor of the Glorious"                            ,  111000, ItemType.ArmoroftheGlorious                     , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Gauntlets of the Vanquisher"                      ,  112000, ItemType.GauntletsoftheVanquisher               , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Boots of the Explorer"                            ,  113000, ItemType.BootsoftheExplorer                     , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Stone Helm"                                       ,  120000, ItemType.StoneHelm                              , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Stone Armor"                                      ,  121000, ItemType.StoneArmor                             , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Stone Gauntlets"                                  ,  122000, ItemType.StoneGauntlets                         , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Stone Leggings"                                   ,  123000, ItemType.StoneLeggings                          , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Crystalline Helm"                                 ,  130000, ItemType.CrystallineHelm                        , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Crystalline Armor"                                ,  131000, ItemType.CrystallineArmor                       , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Crystalline Gauntlets"                            ,  132000, ItemType.CrystallineGauntlets                   , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Crystalline Leggings"                             ,  133000, ItemType.CrystallineLeggings                    , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Mask of the Sealer"                               ,  140000, ItemType.MaskoftheSealer                        , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Crimson Robe"                                     ,  141000, ItemType.CrimsonRobe                            , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Crimson Gloves"                                   ,  142000, ItemType.CrimsonGloves                          , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Crimson Waistcloth"                               ,  143000, ItemType.CrimsonWaistcloth                      , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Mask of Velka"                                    ,  150000, ItemType.MaskofVelka                            , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Black Cleric Robe"                                ,  151000, ItemType.BlackClericRobe                        , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Black Manchette"                                  ,  152000, ItemType.BlackManchette                         , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Black Tights"                                     ,  153000, ItemType.BlackTights                            , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Iron Helm"                                        ,  160000, ItemType.IronHelm                               , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Armor of the Sun"                                 ,  161000, ItemType.ArmoroftheSun                          , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Iron Bracelet"                                    ,  162000, ItemType.IronBracelet                           , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Iron Leggings"                                    ,  163000, ItemType.IronLeggings                           , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Chain Helm"                                       ,  170000, ItemType.ChainHelm                              , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Chain Armor"                                      ,  171000, ItemType.ChainArmor                             , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Leather Gauntlets"                                ,  172000, ItemType.LeatherGauntlets                       , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Chain Leggings"                                   ,  173000, ItemType.ChainLeggings                          , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Cleric Helm"                                      ,  180000, ItemType.ClericHelm                             , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Cleric Armor"                                     ,  181000, ItemType.ClericArmor                            , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Cleric Gauntlets"                                 ,  182000, ItemType.ClericGauntlets                        , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Cleric Leggings"                                  ,  183000, ItemType.ClericLeggings                         , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Sunlight Maggot"                                  ,  190000, ItemType.SunlightMaggot                         , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Helm of Thorns"                                   ,  200000, ItemType.HelmofThorns                           , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Armor of Thorns"                                  ,  201000, ItemType.ArmorofThorns                          , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Gauntlets of Thorns"                              ,  202000, ItemType.GauntletsofThorns                      , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Leggings of Thorns"                               ,  203000, ItemType.LeggingsofThorns                       , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Standard Helm"                                    ,  210000, ItemType.StandardHelm                           , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Hard Leather Armor"                               ,  211000, ItemType.HardLeatherArmor                       , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Hard Leather Gauntlets"                           ,  212000, ItemType.HardLeatherGauntlets                   , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Hard Leather Boots"                               ,  213000, ItemType.HardLeatherBoots                       , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Sorcerer Hat"                                     ,  220000, ItemType.SorcererHat                            , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Sorcerer Cloak"                                   ,  221000, ItemType.SorcererCloak                          , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Sorcerer Gauntlets"                               ,  222000, ItemType.SorcererGauntlets                      , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Sorcerer Boots"                                   ,  223000, ItemType.SorcererBoots                          , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Tattered Cloth Hood"                              ,  230000, ItemType.TatteredClothHood                      , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Tattered Cloth Robe"                              ,  231000, ItemType.TatteredClothRobe                      , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Tattered Cloth Manchette"                         ,  232000, ItemType.TatteredClothManchette                 , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Heavy Boots"                                      ,  233000, ItemType.HeavyBoots                             , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Pharis's Hat"                                     ,  240000, ItemType.PharissHat                             , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Leather Armor"                                    ,  241000, ItemType.LeatherArmor                           , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Leather Gloves"                                   ,  242000, ItemType.LeatherGloves                          , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Leather Boots"                                    ,  243000, ItemType.LeatherBoots                           , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Painting Guardian Hood"                           ,  250000, ItemType.PaintingGuardianHood                   , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Painting Guardian Robe"                           ,  251000, ItemType.PaintingGuardianRobe                   , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Painting Guardian Gloves"                         ,  252000, ItemType.PaintingGuardianGloves                 , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Painting Guardian Waistcloth"                     ,  253000, ItemType.PaintingGuardianWaistcloth             , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Ornstein's Helm"                                  ,  270000, ItemType.OrnsteinsHelm                          , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Ornstein's Armor"                                 ,  271000, ItemType.OrnsteinsArmor                         , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Ornstein's Gauntlets"                             ,  272000, ItemType.OrnsteinsGauntlets                     , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Ornstein's Leggings"                              ,  273000, ItemType.OrnsteinsLeggings                      , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Eastern Helm"                                     ,  280000, ItemType.EasternHelm                            , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Eastern Armor"                                    ,  281000, ItemType.EasternArmor                           , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Eastern Gauntlets"                                ,  282000, ItemType.EasternGauntlets                       , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Eastern Leggings"                                 ,  283000, ItemType.EasternLeggings                        , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Xanthous Crown"                                   ,  290000, ItemType.XanthousCrown                          , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Xanthous Overcoat"                                ,  291000, ItemType.XanthousOvercoat                       , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Xanthous Gloves"                                  ,  292000, ItemType.XanthousGloves                         , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Xanthous Waistcloth"                              ,  293000, ItemType.XanthousWaistcloth                     , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Thief Mask"                                       ,  300000, ItemType.ThiefMask                              , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Black Leather Armor"                              ,  301000, ItemType.BlackLeatherArmor                      , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Black Leather Gloves"                             ,  302000, ItemType.BlackLeatherGloves                     , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Black Leather Boots"                              ,  303000, ItemType.BlackLeatherBoots                      , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Priest's Hat"                                     ,  310000, ItemType.PriestsHat                             , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Holy Robe"                                        ,  311000, ItemType.HolyRobe                               , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Traveling Gloves (Holy)"                          ,  312000, ItemType.TravelingGlovesHoly                    , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Holy Trousers"                                    ,  313000, ItemType.HolyTrousers                           , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Black Knight Helm"                                ,  320000, ItemType.BlackKnightHelm                        , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Black Knight Armor"                               ,  321000, ItemType.BlackKnightArmor                       , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Black Knight Gauntlets"                           ,  322000, ItemType.BlackKnightGauntlets                   , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Black Knight Leggings"                            ,  323000, ItemType.BlackKnightLeggings                    , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Crown of Dusk"                                    ,  330000, ItemType.CrownofDusk                            , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Antiquated Dress"                                 ,  331000, ItemType.AntiquatedDress                        , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Antiquated Gloves"                                ,  332000, ItemType.AntiquatedGloves                       , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Antiquated Skirt"                                 ,  333000, ItemType.AntiquatedSkirt                        , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Witch Hat"                                        ,  340000, ItemType.WitchHat                               , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Witch Cloak"                                      ,  341000, ItemType.WitchCloak                             , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Witch Gloves"                                     ,  342000, ItemType.WitchGloves                            , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Witch Skirt"                                      ,  343000, ItemType.WitchSkirt                             , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Elite Knight Helm"                                ,  350000, ItemType.EliteKnightHelm                        , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Elite Knight Armor"                               ,  351000, ItemType.EliteKnightArmor                       , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Elite Knight Gauntlets"                           ,  352000, ItemType.EliteKnightGauntlets                   , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Elite Knight Leggings"                            ,  353000, ItemType.EliteKnightLeggings                    , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Wanderer Hood"                                    ,  360000, ItemType.WandererHood                           , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Wanderer Coat"                                    ,  361000, ItemType.WandererCoat                           , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Wanderer Manchette"                               ,  362000, ItemType.WandererManchette                      , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Wanderer Boots"                                   ,  363000, ItemType.WandererBoots                          , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Big Hat"                                          ,  380000, ItemType.BigHat                                 , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Sage Robe"                                        ,  381000, ItemType.SageRobe                               , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Traveling Gloves (Sage)"                          ,  382000, ItemType.TravelingGlovesSage                    , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Traveling Boots"                                  ,  383000, ItemType.TravelingBoots                         , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Knight Helm"                                      ,  390000, ItemType.KnightHelm                             , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Knight Armor"                                     ,  391000, ItemType.KnightArmor                            , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Knight Gauntlets"                                 ,  392000, ItemType.KnightGauntlets                        , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Knight Leggings"                                  ,  393000, ItemType.KnightLeggings                         , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Dingy Hood"                                       ,  400000, ItemType.DingyHood                              , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Dingy Robe"                                       ,  401000, ItemType.DingyRobe                              , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Dingy Gloves"                                     ,  402000, ItemType.DingyGloves                            , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Blood-Stained Skirt"                              ,  403000, ItemType.BloodStainedSkirt                      , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Maiden Hood"                                      ,  410000, ItemType.MaidenHood                             , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Maiden Robe"                                      ,  411000, ItemType.MaidenRobe                             , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Maiden Gloves"                                    ,  412000, ItemType.MaidenGloves                           , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Maiden Skirt"                                     ,  413000, ItemType.MaidenSkirt                            , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Silver Knight Helm"                               ,  420000, ItemType.SilverKnightHelm                       , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Silver Knight Armor"                              ,  421000, ItemType.SilverKnightArmor                      , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Silver Knight Gauntlets"                          ,  422000, ItemType.SilverKnightGauntlets                  , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Silver Knight Leggings"                           ,  423000, ItemType.SilverKnightLeggings                   , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Havel's Helm"                                     ,  440000, ItemType.HavelsHelm                             , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Havel's Armor"                                    ,  441000, ItemType.HavelsArmor                            , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Havel's Gauntlets"                                ,  442000, ItemType.HavelsGauntlets                        , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Havel's Leggings"                                 ,  443000, ItemType.HavelsLeggings                         , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Brass Helm"                                       ,  450000, ItemType.BrassHelm                              , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Brass Armor"                                      ,  451000, ItemType.BrassArmor                             , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Brass Gauntlets"                                  ,  452000, ItemType.BrassGauntlets                         , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Brass Leggings"                                   ,  453000, ItemType.BrassLeggings                          , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Gold-Hemmed Black Hood"                           ,  460000, ItemType.GoldHemmedBlackHood                    , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Gold-Hemmed Black Cloak"                          ,  461000, ItemType.GoldHemmedBlackCloak                   , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Gold-Hemmed Black Gloves"                         ,  462000, ItemType.GoldHemmedBlackGloves                  , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Gold-Hemmed Black Skirt"                          ,  463000, ItemType.GoldHemmedBlackSkirt                   , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Golem Helm"                                       ,  470000, ItemType.GolemHelm                              , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Golem Armor"                                      ,  471000, ItemType.GolemArmor                             , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Golem Gauntlets"                                  ,  472000, ItemType.GolemGauntlets                         , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Golem Leggings"                                   ,  473000, ItemType.GolemLeggings                          , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Hollow Soldier Helm"                              ,  480000, ItemType.HollowSoldierHelm                      , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Hollow Soldier Armor"                             ,  481000, ItemType.HollowSoldierArmor                     , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Hollow Soldier Waistcloth"                        ,  483000, ItemType.HollowSoldierWaistcloth                , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Steel Helm"                                       ,  490000, ItemType.SteelHelm                              , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Steel Armor"                                      ,  491000, ItemType.SteelArmor                             , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Steel Gauntlets"                                  ,  492000, ItemType.SteelGauntlets                         , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Steel Leggings"                                   ,  493000, ItemType.SteelLeggings                          , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Hollow Thief's Hood"                              ,  500000, ItemType.HollowThiefsHood                       , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Hollow Thief's Leather Armor"                     ,  501000, ItemType.HollowThiefsLeatherArmor               , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Hollow Thief's Tights"                            ,  503000, ItemType.HollowThiefsTights                     , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Balder Helm"                                      ,  510000, ItemType.BalderHelm                             , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Balder Armor"                                     ,  511000, ItemType.BalderArmor                            , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Balder Gauntlets"                                 ,  512000, ItemType.BalderGauntlets                        , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Balder Leggings"                                  ,  513000, ItemType.BalderLeggings                         , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Hollow Warrior Helm"                              ,  520000, ItemType.HollowWarriorHelm                      , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Hollow Warrior Armor"                             ,  521000, ItemType.HollowWarriorArmor                     , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Hollow Warrior Waistcloth"                        ,  523000, ItemType.HollowWarriorWaistcloth                , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Giant Helm"                                       ,  530000, ItemType.GiantHelm                              , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Giant Armor"                                      ,  531000, ItemType.GiantArmor                             , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Giant Gauntlets"                                  ,  532000, ItemType.GiantGauntlets                         , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Giant Leggings"                                   ,  533000, ItemType.GiantLeggings                          , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Crown of the Dark Sun"                            ,  540000, ItemType.CrownoftheDarkSun                      , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Moonlight Robe"                                   ,  541000, ItemType.MoonlightRobe                          , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Moonlight Gloves"                                 ,  542000, ItemType.MoonlightGloves                        , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Moonlight Waistcloth"                             ,  543000, ItemType.MoonlightWaistcloth                    , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Crown of the Great Lord"                          ,  550000, ItemType.CrownoftheGreatLord                    , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Robe of the Great Lord"                           ,  551000, ItemType.RobeoftheGreatLord                     , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Bracelet of the Great Lord"                       ,  552000, ItemType.BraceletoftheGreatLord                 , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Anklet of the Great Lord"                         ,  553000, ItemType.AnkletoftheGreatLord                   , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Sack"                                             ,  560000, ItemType.Sack                                   , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Symbol of Avarice"                                ,  570000, ItemType.SymbolofAvarice                        , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Royal Helm"                                       ,  580000, ItemType.RoyalHelm                              , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Mask of the Father"                               ,  590000, ItemType.MaskoftheFather                        , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Mask of the Mother"                               ,  600000, ItemType.MaskoftheMother                        , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Mask of the Child"                                ,  610000, ItemType.MaskoftheChild                         , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Fang Boar Helm"                                   ,  620000, ItemType.FangBoarHelm                           , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Gargoyle Helm"                                    ,  630000, ItemType.GargoyleHelm                           , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Black Sorcerer Hat"                               ,  640000, ItemType.BlackSorcererHat                       , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Black Sorcerer Cloak"                             ,  641000, ItemType.BlackSorcererCloak                     , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Black Sorcerer Gauntlets"                         ,  642000, ItemType.BlackSorcererGauntlets                 , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Black Sorcerer Boots"                             ,  643000, ItemType.BlackSorcererBoots                     , ItemCategory.Armor          ,   1, ItemUpgrade.Armor              ),
            new Item("Helm of Artorias"                                 ,  660000, ItemType.HelmofArtorias                         , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Armor of Artorias"                                ,  661000, ItemType.ArmorofArtorias                        , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Gauntlets of Artorias"                            ,  662000, ItemType.GauntletsofArtorias                    , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Leggings of Artorias"                             ,  663000, ItemType.LeggingsofArtorias                     , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Porcelain Mask"                                   ,  670000, ItemType.PorcelainMask                          , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Lord's Blade Robe"                                ,  671000, ItemType.LordsBladeRobe                         , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Lord's Blade Gloves"                              ,  672000, ItemType.LordsBladeGloves                       , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Lord's Blade Waistcloth"                          ,  673000, ItemType.LordsBladeWaistcloth                   , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Gough's Helm"                                     ,  680000, ItemType.GoughsHelm                             , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Gough's Armor"                                    ,  681000, ItemType.GoughsArmor                            , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Gough's Gauntlets"                                ,  682000, ItemType.GoughsGauntlets                        , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Gough's Leggings"                                 ,  683000, ItemType.GoughsLeggings                         , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Guardian Helm"                                    ,  690000, ItemType.GuardianHelm                           , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Guardian Armor"                                   ,  691000, ItemType.GuardianArmor                          , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Guardian Gauntlets"                               ,  692000, ItemType.GuardianGauntlets                      , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Guardian Leggings"                                ,  693000, ItemType.GuardianLeggings                       , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Snickering Top Hat"                               ,  700000, ItemType.SnickeringTopHat                       , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Chester's Long Coat"                              ,  701000, ItemType.ChestersLongCoat                       , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Chester's Gloves"                                 ,  702000, ItemType.ChestersGloves                         , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Chester's Trousers"                               ,  703000, ItemType.ChestersTrousers                       , ItemCategory.Armor          ,   1, ItemUpgrade.Unique             ),
            new Item("Bloated Head"                                     ,  710000, ItemType.BloatedHead                            , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),
            new Item("Bloated Sorcerer Head"                            ,  720000, ItemType.BloatedSorcererHead                    , ItemCategory.Armor          ,   1, ItemUpgrade.None               ),

            new Item("Eye of Death"                                     ,      109, ItemType.EyeofDeath                             , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Cracked Red Eye Orb"                              ,      111, ItemType.CrackedRedEyeOrb                       , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Estus Flask"                                      ,      200, ItemType.EstusFlask                             , ItemCategory.Consumables    ,   1, ItemUpgrade.None               ),
            new Item("Elizabeth's Mushroom"                             ,      230, ItemType.ElizabethsMushroom                     , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Divine Blessing"                                  ,      240, ItemType.DivineBlessing                         , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Green Blossom"                                    ,      260, ItemType.GreenBlossom                           , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Bloodred Moss Clump"                              ,      270, ItemType.BloodredMossClump                      , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Purple Moss Clump"                                ,      271, ItemType.PurpleMossClump                        , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Blooming Purple Moss Clump"                       ,      272, ItemType.BloomingPurpleMossClump                , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Purging Stone"                                    ,      274, ItemType.PurgingStone                           , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Egg Vermifuge"                                    ,      275, ItemType.EggVermifuge                           , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Repair Powder"                                    ,      280, ItemType.RepairPowder                           , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Throwing Knife"                                   ,      290, ItemType.ThrowingKnife                          , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Poison Throwing Knife"                            ,      291, ItemType.PoisonThrowingKnife                    , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Firebomb"                                         ,      292, ItemType.Firebomb                               , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Dung Pie"                                         ,      293, ItemType.DungPie                                , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Alluring Skull"                                   ,      294, ItemType.AlluringSkull                          , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Lloyd's Talisman"                                 ,      296, ItemType.LloydsTalisman                         , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Black Firebomb"                                   ,      297, ItemType.BlackFirebomb                          , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Charcoal Pine Resin"                              ,      310, ItemType.CharcoalPineResin                      , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Gold Pine Resin"                                  ,      311, ItemType.GoldPineResin                          , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Transient Curse"                                  ,      312, ItemType.TransientCurse                         , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Rotten Pine Resin"                                ,      313, ItemType.RottenPineResin                        , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Homeward Bone"                                    ,      330, ItemType.HomewardBone                           , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Prism Stone"                                      ,      370, ItemType.PrismStone                             , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Indictment"                                       ,      373, ItemType.Indictment                             , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Souvenir of Reprisal"                             ,      374, ItemType.SouvenirofReprisal                     , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Sunlight Medal"                                   ,      375, ItemType.SunlightMedal                          , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Pendant"                                          ,      376, ItemType.Pendant                                , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Rubbish"                                          ,      380, ItemType.Rubbish                                , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Copper Coin"                                      ,      381, ItemType.CopperCoin                             , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Silver Coin"                                      ,      382, ItemType.SilverCoin                             , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Gold Coin"                                        ,      383, ItemType.GoldCoin                               , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Fire Keeper Soul (Anastacia of Astora)"           ,      390, ItemType.FireKeeperSoulAnastaciaofAstora        , ItemCategory.Consumables    ,   1, ItemUpgrade.None               ),
            new Item("Fire Keeper Soul (Darkmoon Knightess)"            ,      391, ItemType.FireKeeperSoulDarkmoonKnightess        , ItemCategory.Consumables    ,   1, ItemUpgrade.None               ),
            new Item("Fire Keeper Soul (Daughter of Chaos)"             ,      392, ItemType.FireKeeperSoulDaughterofChaos          , ItemCategory.Consumables    ,   1, ItemUpgrade.None               ),
            new Item("Fire Keeper Soul (New Londo)"                     ,      393, ItemType.FireKeeperSoulNewLondo                 , ItemCategory.Consumables    ,   1, ItemUpgrade.None               ),
            new Item("Fire Keeper Soul (Blighttown)"                    ,      394, ItemType.FireKeeperSoulBlighttown               , ItemCategory.Consumables    ,   1, ItemUpgrade.None               ),
            new Item("Fire Keeper Soul (Duke's Archives)"               ,      395, ItemType.FireKeeperSoulDukesArchives            , ItemCategory.Consumables    ,   1, ItemUpgrade.None               ),
            new Item("Fire Keeper Soul (Undead Parish)"                 ,      396, ItemType.FireKeeperSoulUndeadParish             , ItemCategory.Consumables    ,   1, ItemUpgrade.None               ),
            new Item("Soul of a Lost Undead"                            ,      400, ItemType.SoulofaLostUndead                      , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Large Soul of a Lost Undead"                      ,      401, ItemType.LargeSoulofaLostUndead                 , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Soul of a Nameless Soldier"                       ,      402, ItemType.SoulofaNamelessSoldier                 , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Large Soul of a Nameless Soldier"                 ,      403, ItemType.LargeSoulofaNamelessSoldier            , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Soul of a Proud Knight"                           ,      404, ItemType.SoulofaProudKnight                     , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Large Soul of a Proud Knight"                     ,      405, ItemType.LargeSoulofaProudKnight                , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Soul of a Brave Warrior"                          ,      406, ItemType.SoulofaBraveWarrior                    , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Large Soul of a Brave Warrior"                    ,      407, ItemType.LargeSoulofaBraveWarrior               , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Soul of a Hero"                                   ,      408, ItemType.SoulofaHero                            , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Soul of a Great Hero"                             ,      409, ItemType.SoulofaGreatHero                       , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Humanity"                                         ,      500, ItemType.Humanity                               , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Twin Humanities"                                  ,      501, ItemType.TwinHumanities                         , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Soul of Quelaag"                                  ,      700, ItemType.SoulofQuelaag                          , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Soul of Sif"                                      ,      701, ItemType.SoulofSif                              , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Soul of Gwyn, Lord of Cinder"                     ,      702, ItemType.SoulofGwynLordofCinder                 , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Core of an Iron Golem"                            ,      703, ItemType.CoreofanIronGolem                      , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Soul of Ornstein"                                 ,      704, ItemType.SoulofOrnstein                         , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Soul of the Moonlight Butterfly"                  ,      705, ItemType.SouloftheMoonlightButterfly            , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Soul of Smough"                                   ,      706, ItemType.SoulofSmough                           , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Soul of Priscilla"                                ,      707, ItemType.SoulofPriscilla                        , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Soul of Gwyndolin"                                ,      708, ItemType.SoulofGwyndolin                        , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Guardian Soul"                                    ,      709, ItemType.GuardianSoul                           , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Soul of Artorias"                                 ,      710, ItemType.SoulofArtorias                         , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),
            new Item("Soul of Manus"                                    ,      711, ItemType.SoulofManus                            , ItemCategory.Consumables    ,  99, ItemUpgrade.None               ),

            new Item("Peculiar Doll"                                    ,      384, ItemType.PeculiarDoll                           , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Basement Key"                                     ,     2001, ItemType.BasementKey                            , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Crest of Artorias"                                ,     2002, ItemType.CrestofArtorias                        , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Cage Key"                                         ,     2003, ItemType.CageKey                                , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Archive Tower Cell Key"                           ,     2004, ItemType.ArchiveTowerCellKey                    , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Archive Tower Giant Door Key"                     ,     2005, ItemType.ArchiveTowerGiantDoorKey               , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Archive Tower Giant Cell Key"                     ,     2006, ItemType.ArchiveTowerGiantCellKey               , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Blighttown Key"                                   ,     2007, ItemType.BlighttownKey                          , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Key to New Londo Ruins"                           ,     2008, ItemType.KeytoNewLondoRuins                     , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Annex Key"                                        ,     2009, ItemType.AnnexKey                               , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Dungeon Cell Key"                                 ,     2010, ItemType.DungeonCellKey                         , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Big Pilgrim's Key"                                ,     2011, ItemType.BigPilgrimsKey                         , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Undead Asylum F2 East Key"                        ,     2012, ItemType.UndeadAsylumF2EastKey                  , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Key to the Seal"                                  ,     2013, ItemType.KeytotheSeal                           , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Key to Depths"                                    ,     2014, ItemType.KeytoDepths                            , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Undead Asylum F2 West Key"                        ,     2016, ItemType.UndeadAsylumF2WestKey                  , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Mystery Key"                                      ,     2017, ItemType.MysteryKey                             , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Sewer Chamber Key"                                ,     2018, ItemType.SewerChamberKey                        , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Watchtower Basement Key"                          ,     2019, ItemType.WatchtowerBasementKey                  , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Archive Prison Extra Key"                         ,     2020, ItemType.ArchivePrisonExtraKey                  , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Residence Key"                                    ,     2021, ItemType.ResidenceKey                           , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Crest Key"                                        ,     2022, ItemType.CrestKey                               , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Master Key"                                       ,     2100, ItemType.MasterKey                              , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Lord Soul (Nito)"                                 ,     2500, ItemType.LordSoulNito                           , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Lord Soul (Bed of Chaos)"                         ,     2501, ItemType.LordSoulBedofChaos                     , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Bequeathed Lord Soul Shard (Four Kings)"          ,     2502, ItemType.BequeathedLordSoulShardFourKings       , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Bequeathed Lord Soul Shard (Seath)"               ,     2503, ItemType.BequeathedLordSoulShardSeath           , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Lordvessel"                                       ,     2510, ItemType.Lordvessel                             , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Broken Pendant"                                   ,     2520, ItemType.BrokenPendant                          , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Weapon Smithbox"                                  ,     2600, ItemType.WeaponSmithbox                         , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Armor Smithbox"                                   ,     2601, ItemType.ArmorSmithbox                          , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Repairbox"                                        ,     2602, ItemType.Repairbox                              , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Rite of Kindling"                                 ,     2607, ItemType.RiteofKindling                         , ItemCategory.Key            ,   1, ItemUpgrade.None               ),
            new Item("Bottomless Box"                                   ,     2608, ItemType.BottomlessBox                          , ItemCategory.Key            ,   1, ItemUpgrade.None               ),

            new Item("Dagger"                                           ,   100000, ItemType.Dagger                                 , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Parrying Dagger"                                  ,   101000, ItemType.ParryingDagger                         , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Ghost Blade"                                      ,   102000, ItemType.GhostBlade                             , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Bandit's Knife"                                   ,   103000, ItemType.BanditsKnife                           , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Priscilla's Dagger"                               ,   104000, ItemType.PriscillasDagger                       , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Shortsword"                                       ,   200000, ItemType.Shortsword                             , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Longsword"                                        ,   201000, ItemType.Longsword                              , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Broadsword"                                       ,   202000, ItemType.Broadsword                             , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Broken Straight Sword"                            ,   203000, ItemType.BrokenStraightSword                    , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Balder Side Sword"                                ,   204000, ItemType.BalderSideSword                        , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Crystal Straight Sword"                           ,   205000, ItemType.CrystalStraightSword                   , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.None               ),
            new Item("Sunlight Straight Sword"                          ,   206000, ItemType.SunlightStraightSword                  , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Barbed Straight Sword"                            ,   207000, ItemType.BarbedStraightSword                    , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Silver Knight Straight Sword"                     ,   208000, ItemType.SilverKnightStraightSword              , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Astora's Straight Sword"                          ,   209000, ItemType.AstorasStraightSword                   , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Darksword"                                        ,   210000, ItemType.Darksword                              , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Drake Sword"                                      ,   211000, ItemType.DrakeSword                             , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Straight Sword Hilt"                              ,   212000, ItemType.StraightSwordHilt                      , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Bastard Sword"                                    ,   300000, ItemType.BastardSword                           , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Claymore"                                         ,   301000, ItemType.Claymore                               , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Man-serpent Greatsword"                           ,   302000, ItemType.ManserpentGreatsword                   , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Flamberge"                                        ,   303000, ItemType.Flamberge                              , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Crystal Greatsword"                               ,   304000, ItemType.CrystalGreatsword                      , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.None               ),
            new Item("Stone Greatsword"                                 ,   306000, ItemType.StoneGreatsword                        , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Greatsword of Artorias"                           ,   307000, ItemType.GreatswordofArtorias                   , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Moonlight Greatsword"                             ,   309000, ItemType.MoonlightGreatsword                    , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Black Knight Sword"                               ,   310000, ItemType.BlackKnightSword                       , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Greatsword of Artorias (Cursed)"                  ,   311000, ItemType.GreatswordofArtoriasCursed             , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Great Lord Greatsword"                            ,   314000, ItemType.GreatLordGreatsword                    , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Zweihander"                                       ,   350000, ItemType.Zweihander                             , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Greatsword"                                       ,   351000, ItemType.Greatsword                             , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Demon Great Machete"                              ,   352000, ItemType.DemonGreatMachete                      , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Dragon Greatsword"                                ,   354000, ItemType.DragonGreatsword                       , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Black Knight Greatsword"                          ,   355000, ItemType.BlackKnightGreatsword                  , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Scimitar"                                         ,   400000, ItemType.Scimitar                               , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Falchion"                                         ,   401000, ItemType.Falchion                               , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Shotel"                                           ,   402000, ItemType.Shotel                                 , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Jagged Ghost Blade"                               ,   403000, ItemType.JaggedGhostBlade                       , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Painting Guardian Sword"                          ,   405000, ItemType.PaintingGuardianSword                  , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Quelaag's Furysword"                              ,   406000, ItemType.QuelaagsFurysword                      , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Server"                                           ,   450000, ItemType.Server                                 , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Murakumo"                                         ,   451000, ItemType.Murakumo                               , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Gravelord Sword"                                  ,   453000, ItemType.GravelordSword                         , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Uchigatana"                                       ,   500000, ItemType.Uchigatana                             , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Washing Pole"                                     ,   501000, ItemType.WashingPole                            , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Iaito"                                            ,   502000, ItemType.Iaito                                  , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Chaos Blade"                                      ,   503000, ItemType.ChaosBlade                             , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Mail Breaker"                                     ,   600000, ItemType.MailBreaker                            , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Rapier"                                           ,   601000, ItemType.Rapier                                 , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Estoc"                                            ,   602000, ItemType.Estoc                                  , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Velka's Rapier"                                   ,   603000, ItemType.VelkasRapier                           , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Ricard's Rapier"                                  ,   604000, ItemType.RicardsRapier                          , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Hand Axe"                                         ,   700000, ItemType.HandAxe                                , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Battle Axe"                                       ,   701000, ItemType.BattleAxe                              , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Crescent Axe"                                     ,   702000, ItemType.CrescentAxe                            , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Butcher Knife"                                    ,   703000, ItemType.ButcherKnife                           , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Golem Axe"                                        ,   704000, ItemType.GolemAxe                               , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Gargoyle Tail Axe"                                ,   705000, ItemType.GargoyleTailAxe                        , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Greataxe"                                         ,   750000, ItemType.Greataxe                               , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Demon's Greataxe"                                 ,   751000, ItemType.DemonsGreataxe                         , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Dragon King Greataxe"                             ,   752000, ItemType.DragonKingGreataxe                     , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Black Knight Greataxe"                            ,   753000, ItemType.BlackKnightGreataxe                    , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Club"                                             ,   800000, ItemType.Club                                   , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Mace"                                             ,   801000, ItemType.Mace                                   , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Morning Star"                                     ,   802000, ItemType.MorningStar                            , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Warpick"                                          ,   803000, ItemType.Warpick                                , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Pickaxe"                                          ,   804000, ItemType.Pickaxe                                , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Reinforced Club"                                  ,   809000, ItemType.ReinforcedClub                         , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Blacksmith Hammer"                                ,   810000, ItemType.BlacksmithHammer                       , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Blacksmith Giant Hammer"                          ,   811000, ItemType.BlacksmithGiantHammer                  , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Hammer of Vamos"                                  ,   812000, ItemType.HammerofVamos                          , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Great Club"                                       ,   850000, ItemType.GreatClub                              , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Grant"                                            ,   851000, ItemType.Grant                                  , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Demon's Great Hammer"                             ,   852000, ItemType.DemonsGreatHammer                      , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Dragon Tooth"                                     ,   854000, ItemType.DragonTooth                            , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Large Club"                                       ,   855000, ItemType.LargeClub                              , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Smough's Hammer"                                  ,   856000, ItemType.SmoughsHammer                          , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Caestus"                                          ,   901000, ItemType.Caestus                                , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Claw"                                             ,   902000, ItemType.Claw                                   , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Dragon Bone Fist"                                 ,   903000, ItemType.DragonBoneFist                         , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Dark Hand"                                        ,   904000, ItemType.DarkHand                               , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.None               ),
            new Item("Spear"                                            ,  1000000, ItemType.Spear                                  , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Winged Spear"                                     ,  1001000, ItemType.WingedSpear                            , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Partizan"                                         ,  1002000, ItemType.Partizan                               , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Demon's Spear"                                    ,  1003000, ItemType.DemonsSpear                            , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Channeler's Trident"                              ,  1004000, ItemType.ChannelersTrident                      , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Silver Knight Spear"                              ,  1006000, ItemType.SilverKnightSpear                      , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Pike"                                             ,  1050000, ItemType.Pike                                   , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Dragonslayer Spear"                               ,  1051000, ItemType.DragonslayerSpear                      , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Moonlight Butterfly Horn"                         ,  1052000, ItemType.MoonlightButterflyHorn                 , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Halberd"                                          ,  1100000, ItemType.Halberd                                , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Giant's Halberd"                                  ,  1101000, ItemType.GiantsHalberd                          , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Titanite Catch Pole"                              ,  1102000, ItemType.TitaniteCatchPole                      , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Gargoyle's Halberd"                               ,  1103000, ItemType.GargoylesHalberd                       , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Black Knight Halberd"                             ,  1105000, ItemType.BlackKnightHalberd                     , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Lucerne"                                          ,  1106000, ItemType.Lucerne                                , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Scythe"                                           ,  1107000, ItemType.Scythe                                 , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Great Scythe"                                     ,  1150000, ItemType.GreatScythe                            , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Lifehunt Scythe"                                  ,  1151000, ItemType.LifehuntScythe                         , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Whip"                                             ,  1600000, ItemType.Whip                                   , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Notched Whip"                                     ,  1601000, ItemType.NotchedWhip                            , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Gold Tracer"                                      ,  9010000, ItemType.GoldTracer                             , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Dark Silver Tracer"                               ,  9011000, ItemType.DarkSilverTracer                       , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Abyss Greatsword"                                 ,  9012000, ItemType.AbyssGreatsword                        , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Stone Greataxe"                                   ,  9015000, ItemType.StoneGreataxe                          , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),
            new Item("Four-pronged Plow"                                ,  9016000, ItemType.FourprongedPlow                        , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Guardian Tail"                                    ,  9019000, ItemType.GuardianTail                           , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Infusable          ),
            new Item("Obsidian Greatsword"                              ,  9020000, ItemType.ObsidianGreatsword                     , ItemCategory.MeleeWeapons   ,   1, ItemUpgrade.Unique             ),

            new Item("Short Bow"                                        ,  1200000, ItemType.ShortBow                               , ItemCategory.RangedWeapons  ,   1, ItemUpgrade.Infusable          ),
            new Item("Longbow"                                          ,  1201000, ItemType.Longbow                                , ItemCategory.RangedWeapons  ,   1, ItemUpgrade.Infusable          ),
            new Item("Black Bow of Pharis"                              ,  1202000, ItemType.BlackBowofPharis                       , ItemCategory.RangedWeapons  ,   1, ItemUpgrade.Infusable          ),
            new Item("Dragonslayer Greatbow"                            ,  1203000, ItemType.DragonslayerGreatbow                   , ItemCategory.RangedWeapons  ,   1, ItemUpgrade.Unique             ),
            new Item("Composite Bow"                                    ,  1204000, ItemType.CompositeBow                           , ItemCategory.RangedWeapons  ,   1, ItemUpgrade.Infusable          ),
            new Item("Darkmoon Bow"                                     ,  1205000, ItemType.DarkmoonBow                            , ItemCategory.RangedWeapons  ,   1, ItemUpgrade.Unique             ),
            new Item("Light Crossbow"                                   ,  1250000, ItemType.LightCrossbow                          , ItemCategory.RangedWeapons  ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Heavy Crossbow"                                   ,  1251000, ItemType.HeavyCrossbow                          , ItemCategory.RangedWeapons  ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Avelyn"                                           ,  1252000, ItemType.Avelyn                                 , ItemCategory.RangedWeapons  ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Sniper Crossbow"                                  ,  1253000, ItemType.SniperCrossbow                         , ItemCategory.RangedWeapons  ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Gough's Greatbow"                                 ,  9021000, ItemType.GoughsGreatbow                         , ItemCategory.RangedWeapons  ,   1, ItemUpgrade.Unique             ),

            new Item("Standard Arrow"                                   ,  2000000, ItemType.StandardArrow                          , ItemCategory.Ammo           , 999, ItemUpgrade.None               ),
            new Item("Large Arrow"                                      ,  2001000, ItemType.LargeArrow                             , ItemCategory.Ammo           , 999, ItemUpgrade.None               ),
            new Item("Feather Arrow"                                    ,  2002000, ItemType.FeatherArrow                           , ItemCategory.Ammo           , 999, ItemUpgrade.None               ),
            new Item("Fire Arrow"                                       ,  2003000, ItemType.FireArrow                              , ItemCategory.Ammo           , 999, ItemUpgrade.None               ),
            new Item("Poison Arrow"                                     ,  2004000, ItemType.PoisonArrow                            , ItemCategory.Ammo           , 999, ItemUpgrade.None               ),
            new Item("Moonlight Arrow"                                  ,  2005000, ItemType.MoonlightArrow                         , ItemCategory.Ammo           , 999, ItemUpgrade.None               ),
            new Item("Wooden Arrow"                                     ,  2006000, ItemType.WoodenArrow                            , ItemCategory.Ammo           , 999, ItemUpgrade.None               ),
            new Item("Dragonslayer Arrow"                               ,  2007000, ItemType.DragonslayerArrow                      , ItemCategory.Ammo           , 999, ItemUpgrade.None               ),
            new Item("Gough's Great Arrow"                              ,  2008000, ItemType.GoughsGreatArrow                       , ItemCategory.Ammo           , 999, ItemUpgrade.None               ),
            new Item("Standard Bolt"                                    ,  2100000, ItemType.StandardBolt                           , ItemCategory.Ammo           , 999, ItemUpgrade.None               ),
            new Item("Heavy Bolt"                                       ,  2101000, ItemType.HeavyBolt                              , ItemCategory.Ammo           , 999, ItemUpgrade.None               ),
            new Item("Sniper Bolt"                                      ,  2102000, ItemType.SniperBolt                             , ItemCategory.Ammo           , 999, ItemUpgrade.None               ),
            new Item("Wood Bolt"                                        ,  2103000, ItemType.WoodBolt                               , ItemCategory.Ammo           , 999, ItemUpgrade.None               ),
            new Item("Lightning Bolt"                                   ,  2104000, ItemType.LightningBolt                          , ItemCategory.Ammo           , 999, ItemUpgrade.None               ),

            new Item("Havel's Ring"                                     ,      100, ItemType.HavelsRing                            , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Red Tearstone Ring"                               ,      101, ItemType.RedTearstoneRing                      , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Darkmoon Blade Covenant Ring"                     ,      102, ItemType.DarkmoonBladeCovenantRing             , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Cat Covenant Ring"                                ,      103, ItemType.CatCovenantRing                       , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Cloranthy Ring"                                   ,      104, ItemType.CloranthyRing                         , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Flame Stoneplate Ring"                            ,      105, ItemType.FlameStoneplateRing                   , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Thunder Stoneplate Ring"                          ,      106, ItemType.ThunderStoneplateRing                 , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Spell Stoneplate Ring"                            ,      107, ItemType.SpellStoneplateRing                   , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Speckled Stoneplate Ring"                         ,      108, ItemType.SpeckledStoneplateRing                , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Bloodbite Ring"                                   ,      109, ItemType.BloodbiteRing                         , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Poisonbite Ring"                                  ,      110, ItemType.PoisonbiteRing                        , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Tiny Being's Ring"                                ,      111, ItemType.TinyBeingsRing                        , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Cursebite Ring"                                   ,      113, ItemType.CursebiteRing                         , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("White Seance Ring"                                ,      114, ItemType.WhiteSeanceRing                       , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Bellowing Dragoncrest Ring"                       ,      115, ItemType.BellowingDragoncrestRing              , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Dusk Crown Ring"                                  ,      116, ItemType.DuskCrownRing                         , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Hornet Ring"                                      ,      117, ItemType.HornetRing                            , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Hawk Ring"                                        ,      119, ItemType.HawkRing                              , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Ring of Steel Protection"                         ,      120, ItemType.RingofSteelProtection                 , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Covetous Gold Serpent Ring"                       ,      121, ItemType.CovetousGoldSerpentRing               , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Covetous Silver Serpent Ring"                     ,      122, ItemType.CovetousSilverSerpentRing             , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Slumbering Dragoncrest Ring"                      ,      123, ItemType.SlumberingDragoncrestRing             , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Ring of Fog"                                      ,      124, ItemType.RingofFog                             , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Rusted Iron Ring"                                 ,      125, ItemType.RustedIronRing                        , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Ring of Sacrifice"                                ,      126, ItemType.RingofSacrifice                       , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Rare Ring of Sacrifice"                           ,      127, ItemType.RareRingofSacrifice                   , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Dark Wood Grain Ring"                             ,      128, ItemType.DarkWoodGrainRing                     , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Ring of the Sun Princess"                         ,      130, ItemType.RingoftheSunPrincess                  , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Old Witch's Ring"                                 ,      137, ItemType.OldWitchsRing                         , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Covenant of Artorias"                             ,      138, ItemType.CovenantofArtorias                    , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Orange Charred Ring"                              ,      139, ItemType.OrangeCharredRing                     , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Lingering Dragoncrest Ring"                       ,      141, ItemType.LingeringDragoncrestRing              , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Ring of the Evil Eye"                             ,      142, ItemType.RingoftheEvilEye                      , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Ring of Favor and Protection"                     ,      143, ItemType.RingofFavorandProtection              , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Leo Ring"                                         ,      144, ItemType.LeoRing                               , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("East Wood Grain Ring"                             ,      145, ItemType.EastWoodGrainRing                     , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Wolf Ring"                                        ,      146, ItemType.WolfRing                              , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Blue Tearstone Ring"                              ,      147, ItemType.BlueTearstoneRing                     , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Ring of the Sun's Firstborn"                      ,      148, ItemType.RingoftheSunsFirstborn                , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Darkmoon Seance Ring"                             ,      149, ItemType.DarkmoonSeanceRing                    , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),
            new Item("Calamity Ring"                                    ,      150, ItemType.CalamityRing                          , ItemCategory.Rings           ,   1, ItemUpgrade.None               ),

            new Item("Skull Lantern"                                    ,  1396000, ItemType.SkullLantern                          , ItemCategory.Shields         ,   1, ItemUpgrade.None               ),
            new Item("East-West Shield"                                 ,  1400000, ItemType.EastWestShield                        , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Wooden Shield"                                    ,  1401000, ItemType.WoodenShield                          , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Large Leather Shield"                             ,  1402000, ItemType.LargeLeatherShield                    , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Small Leather Shield"                             ,  1403000, ItemType.SmallLeatherShield                    , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Target Shield"                                    ,  1404000, ItemType.TargetShield                          , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Buckler"                                          ,  1405000, ItemType.Buckler                               , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Cracked Round Shield"                             ,  1406000, ItemType.CrackedRoundShield                    , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Leather Shield"                                   ,  1408000, ItemType.LeatherShield                         , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Plank Shield"                                     ,  1409000, ItemType.PlankShield                           , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Caduceus Round Shield"                            ,  1410000, ItemType.CaduceusRoundShield                   , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Crystal Ring Shield"                              ,  1411000, ItemType.CrystalRingShield                     , ItemCategory.Shields         ,   1, ItemUpgrade.Unique             ),
            new Item("Heater Shield"                                    ,  1450000, ItemType.HeaterShield                          , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Knight Shield"                                    ,  1451000, ItemType.KnightShield                          , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Tower Kite Shield"                                ,  1452000, ItemType.TowerKiteShield                       , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Grass Crest Shield"                               ,  1453000, ItemType.GrassCrestShield                      , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Hollow Soldier Shield"                            ,  1454000, ItemType.HollowSoldierShield                   , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Balder Shield"                                    ,  1455000, ItemType.BalderShield                          , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Crest Shield"                                     ,  1456000, ItemType.CrestShield                           , ItemCategory.Shields         ,   1, ItemUpgrade.Unique             ),
            new Item("Dragon Crest Shield"                              ,  1457000, ItemType.DragonCrestShield                     , ItemCategory.Shields         ,   1, ItemUpgrade.Unique             ),
            new Item("Warrior's Round Shield"                           ,  1460000, ItemType.WarriorsRoundShield                   , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Iron Round Shield"                                ,  1461000, ItemType.IronRoundShield                       , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Spider Shield"                                    ,  1462000, ItemType.SpiderShield                          , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Spiked Shield"                                    ,  1470000, ItemType.SpikedShield                          , ItemCategory.Shields         ,   1, ItemUpgrade.Infusable          ),
            new Item("Crystal Shield"                                   ,  1471000, ItemType.CrystalShield                         , ItemCategory.Shields         ,   1, ItemUpgrade.None               ),
            new Item("Sunlight Shield"                                  ,  1472000, ItemType.SunlightShield                        , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Silver Knight Shield"                             ,  1473000, ItemType.SilverKnightShield                    , ItemCategory.Shields         ,   1, ItemUpgrade.Unique             ),
            new Item("Black Knight Shield"                              ,  1474000, ItemType.BlackKnightShield                     , ItemCategory.Shields         ,   1, ItemUpgrade.Unique             ),
            new Item("Pierce Shield"                                    ,  1475000, ItemType.PierceShield                          , ItemCategory.Shields         ,   1, ItemUpgrade.Infusable          ),
            new Item("Red and White Round Shield"                       ,  1476000, ItemType.RedandWhiteRoundShield                , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Caduceus Kite Shield"                             ,  1477000, ItemType.CaduceusKiteShield                    , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Gargoyle's Shield"                                ,  1478000, ItemType.GargoylesShield                       , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Eagle Shield"                                     ,  1500000, ItemType.EagleShield                           , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Tower Shield"                                     ,  1501000, ItemType.TowerShield                           , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Giant Shield"                                     ,  1502000, ItemType.GiantShield                           , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Stone Greatshield"                                ,  1503000, ItemType.StoneGreatshield                      , ItemCategory.Shields         ,   1, ItemUpgrade.Unique             ),
            new Item("Havel's Greatshield"                              ,  1505000, ItemType.HavelsGreatshield                     , ItemCategory.Shields         ,   1, ItemUpgrade.Unique             ),
            new Item("Bonewheel Shield"                                 ,  1506000, ItemType.BonewheelShield                       , ItemCategory.Shields         ,   1, ItemUpgrade.Infusable          ),
            new Item("Greatshield of Artorias"                          ,  1507000, ItemType.GreatshieldofArtorias                 , ItemCategory.Shields         ,   1, ItemUpgrade.Unique             ),
            new Item("Effigy Shield"                                    ,  9000000, ItemType.EffigyShield                          , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Sanctus"                                          ,  9001000, ItemType.Sanctus                               , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Bloodshield"                                      ,  9002000, ItemType.Bloodshield                           , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Black Iron Greatshield"                           ,  9003000, ItemType.BlackIronGreatshield                  , ItemCategory.Shields         ,   1, ItemUpgrade.InfusableRestricted),
            new Item("Cleansing Greatshield"                            ,  9014000, ItemType.CleansingGreatshield                  , ItemCategory.Shields         ,   1, ItemUpgrade.Unique             ),

            new Item("Sorcery: Soul Arrow"                              ,     3000, ItemType.SorcerySoulArrow                      , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Great Soul Arrow"                        ,     3010, ItemType.SorceryGreatSoulArrow                 , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Heavy Soul Arrow"                        ,     3020, ItemType.SorceryHeavySoulArrow                 , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Great Heavy Soul Arrow"                  ,     3030, ItemType.SorceryGreatHeavySoulArrow            , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Homing Soulmass"                         ,     3040, ItemType.SorceryHomingSoulmass                 , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Homing Crystal Soulmass"                 ,     3050, ItemType.SorceryHomingCrystalSoulmass          , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Soul Spear"                              ,     3060, ItemType.SorcerySoulSpear                      , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Crystal Soul Spear"                      ,     3070, ItemType.SorceryCrystalSoulSpear               , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Magic Weapon"                            ,     3100, ItemType.SorceryMagicWeapon                    , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Great Magic Weapon"                      ,     3110, ItemType.SorceryGreatMagicWeapon               , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Crystal Magic Weapon"                    ,     3120, ItemType.SorceryCrystalMagicWeapon             , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Magic Shield"                            ,     3300, ItemType.SorceryMagicShield                    , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Strong Magic Shield"                     ,     3310, ItemType.SorceryStrongMagicShield              , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Hidden Weapon"                           ,     3400, ItemType.SorceryHiddenWeapon                   , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Hidden Body"                             ,     3410, ItemType.SorceryHiddenBody                     , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Cast Light"                              ,     3500, ItemType.SorceryCastLight                      , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Hush"                                    ,     3510, ItemType.SorceryHush                           , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Aural Decoy"                             ,     3520, ItemType.SorceryAuralDecoy                     , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Repair"                                  ,     3530, ItemType.SorceryRepair                         , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Fall Control"                            ,     3540, ItemType.SorceryFallControl                    , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Chameleon"                               ,     3550, ItemType.SorceryChameleon                      , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Resist Curse"                            ,     3600, ItemType.SorceryResistCurse                    , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Remedy"                                  ,     3610, ItemType.SorceryRemedy                         , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: White Dragon Breath"                     ,     3700, ItemType.SorceryWhiteDragonBreath              , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Dark Orb"                                ,     3710, ItemType.SorceryDarkOrb                        , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Dark Bead"                               ,     3720, ItemType.SorceryDarkBead                       , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Dark Fog"                                ,     3730, ItemType.SorceryDarkFog                        , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Sorcery: Pursuers"                                ,     3740, ItemType.SorceryPursuers                       , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Fireball"                              ,     4000, ItemType.PyromancyFireball                     , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Fire Orb"                              ,     4010, ItemType.PyromancyFireOrb                      , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Great Fireball"                        ,     4020, ItemType.PyromancyGreatFireball                , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Firestorm"                             ,     4030, ItemType.PyromancyFirestorm                    , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Fire Tempest"                          ,     4040, ItemType.PyromancyFireTempest                  , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Fire Surge"                            ,     4050, ItemType.PyromancyFireSurge                    , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Fire Whip"                             ,     4060, ItemType.PyromancyFireWhip                     , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Combustion"                            ,     4100, ItemType.PyromancyCombustion                   , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Great Combustion"                      ,     4110, ItemType.PyromancyGreatCombustion              , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Poison Mist"                           ,     4200, ItemType.PyromancyPoisonMist                   , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Toxic Mist"                            ,     4210, ItemType.PyromancyToxicMist                    , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Acid Surge"                            ,     4220, ItemType.PyromancyAcidSurge                    , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Iron Flesh"                            ,     4300, ItemType.PyromancyIronFlesh                    , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Flash Sweat"                           ,     4310, ItemType.PyromancyFlashSweat                   , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Undead Rapport"                        ,     4360, ItemType.PyromancyUndeadRapport                , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Power Within"                          ,     4400, ItemType.PyromancyPowerWithin                  , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Great Chaos Fireball"                  ,     4500, ItemType.PyromancyGreatChaosFireball           , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Chaos Storm"                           ,     4510, ItemType.PyromancyChaosStorm                   , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Chaos Fire Whip"                       ,     4520, ItemType.PyromancyChaosFireWhip                , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Pyromancy: Black Flame"                           ,     4530, ItemType.PyromancyBlackFlame                   , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Heal"                                    ,     5000, ItemType.MiracleHeal                           , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Great Heal"                              ,     5010, ItemType.MiracleGreatHeal                      , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Great Heal Excerpt"                      ,     5020, ItemType.MiracleGreatHealExcerpt               , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Soothing Sunlight"                       ,     5030, ItemType.MiracleSoothingSunlight               , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Replenishment"                           ,     5040, ItemType.MiracleReplenishment                  , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Bountiful Sunlight"                      ,     5050, ItemType.MiracleBountifulSunlight              , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Gravelord Sword Dance"                   ,     5100, ItemType.MiracleGravelordSwordDance            , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Gravelord Greatsword Dance"              ,     5110, ItemType.MiracleGravelordGreatswordDance       , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Homeward"                                ,     5210, ItemType.MiracleHomeward                       , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Force"                                   ,     5300, ItemType.MiracleForce                          , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Wrath of the Gods"                       ,     5310, ItemType.MiracleWrathoftheGods                 , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Emit Force"                              ,     5320, ItemType.MiracleEmitForce                      , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Seek Guidance"                           ,     5400, ItemType.MiracleSeekGuidance                   , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Lightning Spear"                         ,     5500, ItemType.MiracleLightningSpear                 , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Great Lightning Spear"                   ,     5510, ItemType.MiracleGreatLightningSpear            , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Sunlight Spear"                          ,     5520, ItemType.MiracleSunlightSpear                  , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Magic Barrier"                           ,     5600, ItemType.MiracleMagicBarrier                   , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Great Magic Barrier"                     ,     5610, ItemType.MiracleGreatMagicBarrier              , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Karmic Justice"                          ,     5700, ItemType.MiracleKarmicJustice                  , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Tranquil Walk of Peace"                  ,     5800, ItemType.MiracleTranquilWalkofPeace            , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Vow of Silence"                          ,     5810, ItemType.MiracleVowofSilence                   , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Sunlight Blade"                          ,     5900, ItemType.MiracleSunlightBlade                  , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),
            new Item("Miracle: Darkmoon Blade"                          ,     5910, ItemType.MiracleDarkmoonBlade                  , ItemCategory.Spells          ,  99, ItemUpgrade.None               ),

            new Item("Sorcerer's Catalyst"                              ,  1300000, ItemType.SorcerersCatalyst                     , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Beatrice's Catalyst"                              ,  1301000, ItemType.BeatricesCatalyst                     , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Tin Banishment Catalyst"                          ,  1302000, ItemType.TinBanishmentCatalyst                 , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Logan's Catalyst"                                 ,  1303000, ItemType.LogansCatalyst                        , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Tin Darkmoon Catalyst"                            ,  1304000, ItemType.TinDarkmoonCatalyst                   , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Oolacile Ivory Catalyst"                          ,  1305000, ItemType.OolacileIvoryCatalyst                 , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Tin Crystallization Catalyst"                     ,  1306000, ItemType.TinCrystallizationCatalyst            , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Demon's Catalyst"                                 ,  1307000, ItemType.DemonsCatalyst                        , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Izalith Catalyst"                                 ,  1308000, ItemType.IzalithCatalyst                       , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Pyromancy Flame"                                  ,  1330000, ItemType.PyromancyFlame                        , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Pyromancy Flame (Ascended)"                       ,  1332000, ItemType.PyromancyFlameAscended                , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Talisman"                                         ,  1360000, ItemType.Talisman                              , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Canvas Talisman"                                  ,  1361000, ItemType.CanvasTalisman                        , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Thorolund Talisman"                               ,  1362000, ItemType.ThorolundTalisman                     , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Ivory Talisman"                                   ,  1363000, ItemType.IvoryTalisman                         , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Sunlight Talisman"                                ,  1365000, ItemType.SunlightTalisman                      , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Darkmoon Talisman"                                ,  1366000, ItemType.DarkmoonTalisman                      , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Velka's Talisman"                                 ,  1367000, ItemType.VelkasTalisman                        , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Manus Catalyst"                                   ,  9017000, ItemType.ManusCatalyst                         , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),
            new Item("Oolacile Catalyst"                                ,  9018000, ItemType.OolacileCatalyst                      , ItemCategory.SpellTools      ,   1, ItemUpgrade.None               ),

            new Item("Large Ember"                                      ,     800 , ItemType.LargeEmber                            , ItemCategory.UpgradeMaterials,   1, ItemUpgrade.None               ),
            new Item("Very Large Ember"                                 ,     801 , ItemType.VeryLargeEmber                        , ItemCategory.UpgradeMaterials,   1, ItemUpgrade.None               ),
            new Item("Crystal Ember"                                    ,     802 , ItemType.CrystalEmber                          , ItemCategory.UpgradeMaterials,   1, ItemUpgrade.None               ),
            new Item("Large Magic Ember"                                ,     806 , ItemType.LargeMagicEmber                       , ItemCategory.UpgradeMaterials,   1, ItemUpgrade.None               ),
            new Item("Enchanted Ember"                                  ,     807 , ItemType.EnchantedEmber                        , ItemCategory.UpgradeMaterials,   1, ItemUpgrade.None               ),
            new Item("Divine Ember"                                     ,     808 , ItemType.DivineEmber                           , ItemCategory.UpgradeMaterials,   1, ItemUpgrade.None               ),
            new Item("Large Divine Ember"                               ,     809 , ItemType.LargeDivineEmber                      , ItemCategory.UpgradeMaterials,   1, ItemUpgrade.None               ),
            new Item("Dark Ember"                                       ,     810 , ItemType.DarkEmber                             , ItemCategory.UpgradeMaterials,   1, ItemUpgrade.None               ),
            new Item("Large Flame Ember"                                ,     812 , ItemType.LargeFlameEmber                       , ItemCategory.UpgradeMaterials,   1, ItemUpgrade.None               ),
            new Item("Chaos Flame Ember"                                ,     813 , ItemType.ChaosFlameEmber                       , ItemCategory.UpgradeMaterials,   1, ItemUpgrade.None               ),
            new Item("Titanite Shard"                                   ,     1000, ItemType.TitaniteShard                         , ItemCategory.UpgradeMaterials,  99, ItemUpgrade.None               ),
            new Item("Large Titanite Shard"                             ,     1010, ItemType.LargeTitaniteShard                    , ItemCategory.UpgradeMaterials,  99, ItemUpgrade.None               ),
            new Item("Green Titanite Shard"                             ,     1020, ItemType.GreenTitaniteShard                    , ItemCategory.UpgradeMaterials,  99, ItemUpgrade.None               ),
            new Item("Titanite Chunk"                                   ,     1030, ItemType.TitaniteChunk                         , ItemCategory.UpgradeMaterials,  99, ItemUpgrade.None               ),
            new Item("Blue Titanite Chunk"                              ,     1040, ItemType.BlueTitaniteChunk                     , ItemCategory.UpgradeMaterials,  99, ItemUpgrade.None               ),
            new Item("White Titanite Chunk"                             ,     1050, ItemType.WhiteTitaniteChunk                    , ItemCategory.UpgradeMaterials,  99, ItemUpgrade.None               ),
            new Item("Red Titanite Chunk"                               ,     1060, ItemType.RedTitaniteChunk                      , ItemCategory.UpgradeMaterials,  99, ItemUpgrade.None               ),
            new Item("Titanite Slab"                                    ,     1070, ItemType.TitaniteSlab                          , ItemCategory.UpgradeMaterials,  99, ItemUpgrade.None               ),
            new Item("Blue Titanite Slab"                               ,     1080, ItemType.BlueTitaniteSlab                      , ItemCategory.UpgradeMaterials,  99, ItemUpgrade.None               ),
            new Item("White Titanite Slab"                              ,     1090, ItemType.WhiteTitaniteSlab                     , ItemCategory.UpgradeMaterials,  99, ItemUpgrade.None               ),
            new Item("Red Titanite Slab"                                ,     1100, ItemType.RedTitaniteSlab                       , ItemCategory.UpgradeMaterials,  99, ItemUpgrade.None               ),
            new Item("Dragon Scale"                                     ,     1110, ItemType.DragonScale                           , ItemCategory.UpgradeMaterials,  99, ItemUpgrade.None               ),
            new Item("Demon Titanite"                                   ,     1120, ItemType.DemonTitanite                         , ItemCategory.UpgradeMaterials,  99, ItemUpgrade.None               ),
            new Item("Twinkling Titanite"                               ,     1130, ItemType.TwinklingTitanite                     , ItemCategory.UpgradeMaterials,  99, ItemUpgrade.None               ),

            new Item("White Sign Soapstone"                             ,      100, ItemType.WhiteSignSoapstone                    , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Red Sign Soapstone"                               ,      101, ItemType.RedSignSoapstone                      , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Red Eye Orb"                                      ,      102, ItemType.RedEyeOrb                             , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Black Separation Crystal"                         ,      103, ItemType.BlackSeparationCrystal                , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Orange Guidance Soapstone"                        ,      106, ItemType.OrangeGuidanceSoapstone               , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Book of the Guilty"                               ,      108, ItemType.BookoftheGuilty                       , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Servant Roster"                                   ,      112, ItemType.ServantRoster                         , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Blue Eye Orb"                                     ,      113, ItemType.BlueEyeOrb                            , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Dragon Eye"                                       ,      114, ItemType.DragonEye                             , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Black Eye Orb"                                    ,      115, ItemType.BlackEyeOrb                           , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Darksign"                                         ,      117, ItemType.Darksign                              , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Purple Coward's Crystal"                          ,      118, ItemType.PurpleCowardsCrystal                  , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Silver Pendant"                                   ,      220, ItemType.SilverPendant                         , ItemCategory.UsableItems     ,  99, ItemUpgrade.None               ),
            new Item("Binoculars"                                       ,      371, ItemType.Binoculars                            , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Dragon Head Stone"                                ,      377, ItemType.DragonHeadStone                       , ItemCategory.UsableItems     ,  99, ItemUpgrade.None               ),
            new Item("Dragon Torso Stone"                               ,      378, ItemType.DragonTorsoStone                      , ItemCategory.UsableItems     ,  99, ItemUpgrade.None               ),
            new Item("Dried Finger"                                     ,      385, ItemType.DriedFinger                           , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Hello Carving"                                    ,      510, ItemType.HelloCarving                          , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Thank you Carving"                                ,      511, ItemType.ThankyouCarving                       , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Very good! Carving"                               ,      512, ItemType.VerygoodCarving                       , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("I'm sorry Carving"                                ,      513, ItemType.ImsorryCarving                        , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
            new Item("Help me! Carving"                                 ,      514, ItemType.HelpmeCarving                         , ItemCategory.UsableItems     ,   1, ItemUpgrade.None               ),
        });
    }

    public enum ItemInfusion
    {
        Normal = 0,
        Crystal = 1,
        Lightning = 2,
        Raw = 3,
        Magic = 4,
        Enchanted = 5,
        Divine = 6,
        Occult = 7,
        Fire = 8,
        Chaos = 9,
    }

    public enum ItemUpgrade
    {
        None = 0,
        Unique = 1,
        Armor = 2,
        Infusable = 3,
        InfusableRestricted = 4,
        PyroFlame = 5,
        PyroFlameAscended = 6,
    }

    public enum ItemCategory
    {
        Armor,
        Consumables,
        Key,
        MeleeWeapons,
        RangedWeapons,
        Ammo,
        Rings,
        Shields,
        Spells,
        SpellTools,
        UpgradeMaterials,
        UsableItems,
    }

    public enum ItemType
    {
            [Annotation(Name = "Catarina Helm", Description = nameof(ItemCategory.Armor))]
            CatarinaHelm = 10000,

            [Annotation(Name = "Catarina Armor", Description = nameof(ItemCategory.Armor))]
            CatarinaArmor = 11000,

            [Annotation(Name = "Catarina Gauntlets", Description = nameof(ItemCategory.Armor))]
            CatarinaGauntlets = 12000,

            [Annotation(Name = "Catarina Leggings", Description = nameof(ItemCategory.Armor))]
            CatarinaLeggings = 13000,

            [Annotation(Name = "Paladin Helm", Description = nameof(ItemCategory.Armor))]
            PaladinHelm = 20000,

            [Annotation(Name = "Paladin Armor", Description = nameof(ItemCategory.Armor))]
            PaladinArmor = 21000,

            [Annotation(Name = "Paladin Gauntlets", Description = nameof(ItemCategory.Armor))]
            PaladinGauntlets = 22000,

            [Annotation(Name = "Paladin Leggings", Description = nameof(ItemCategory.Armor))]
            PaladinLeggings = 23000,

            [Annotation(Name = "Dark Mask", Description = nameof(ItemCategory.Armor))]
            DarkMask = 40000,

            [Annotation(Name = "Dark Armor", Description = nameof(ItemCategory.Armor))]
            DarkArmor = 41000,

            [Annotation(Name = "Dark Gauntlets", Description = nameof(ItemCategory.Armor))]
            DarkGauntlets = 42000,

            [Annotation(Name = "Dark Leggings", Description = nameof(ItemCategory.Armor))]
            DarkLeggings = 43000,

            [Annotation(Name = "Brigand Hood", Description = nameof(ItemCategory.Armor))]
            BrigandHood = 50000,

            [Annotation(Name = "Brigand Armor", Description = nameof(ItemCategory.Armor))]
            BrigandArmor = 51000,

            [Annotation(Name = "Brigand Gauntlets", Description = nameof(ItemCategory.Armor))]
            BrigandGauntlets = 52000,

            [Annotation(Name = "Brigand Trousers", Description = nameof(ItemCategory.Armor))]
            BrigandTrousers = 53000,

            [Annotation(Name = "Shadow Mask", Description = nameof(ItemCategory.Armor))]
            ShadowMask = 60000,

            [Annotation(Name = "Shadow Garb", Description = nameof(ItemCategory.Armor))]
            ShadowGarb = 61000,

            [Annotation(Name = "Shadow Gauntlets", Description = nameof(ItemCategory.Armor))]
            ShadowGauntlets = 62000,

            [Annotation(Name = "Shadow Leggings", Description = nameof(ItemCategory.Armor))]
            ShadowLeggings = 63000,

            [Annotation(Name = "Black Iron Helm", Description = nameof(ItemCategory.Armor))]
            BlackIronHelm = 70000,

            [Annotation(Name = "Black Iron Armor", Description = nameof(ItemCategory.Armor))]
            BlackIronArmor = 71000,

            [Annotation(Name = "Black Iron Gauntlets", Description = nameof(ItemCategory.Armor))]
            BlackIronGauntlets = 72000,

            [Annotation(Name = "Black Iron Leggings", Description = nameof(ItemCategory.Armor))]
            BlackIronLeggings = 73000,

            [Annotation(Name = "Smough's Helm", Description = nameof(ItemCategory.Armor))]
            SmoughsHelm = 80000,

            [Annotation(Name = "Smough's Armor", Description = nameof(ItemCategory.Armor))]
            SmoughsArmor = 81000,

            [Annotation(Name = "Smough's Gauntlets", Description = nameof(ItemCategory.Armor))]
            SmoughsGauntlets = 82000,

            [Annotation(Name = "Smough's Leggings", Description = nameof(ItemCategory.Armor))]
            SmoughsLeggings = 83000,

            [Annotation(Name = "Six-Eyed Helm of the Channelers", Description = nameof(ItemCategory.Armor))]
            SixEyedHelmoftheChannelers = 90000,

            [Annotation(Name = "Robe of the Channelers", Description = nameof(ItemCategory.Armor))]
            RobeoftheChannelers = 91000,

            [Annotation(Name = "Gauntlets of the Channelers", Description = nameof(ItemCategory.Armor))]
            GauntletsoftheChannelers = 92000,

            [Annotation(Name = "Waistcloth of the Channelers", Description = nameof(ItemCategory.Armor))]
            WaistclothoftheChannelers = 93000,

            [Annotation(Name = "Helm of Favor", Description = nameof(ItemCategory.Armor))]
            HelmofFavor = 100000,

            [Annotation(Name = "Embraced Armor of Favor", Description = nameof(ItemCategory.Armor))]
            EmbracedArmorofFavor = 101000,

            [Annotation(Name = "Gauntlets of Favor", Description = nameof(ItemCategory.Armor))]
            GauntletsofFavor = 102000,

            [Annotation(Name = "Leggings of Favor", Description = nameof(ItemCategory.Armor))]
            LeggingsofFavor = 103000,

            [Annotation(Name = "Helm of the Wise", Description = nameof(ItemCategory.Armor))]
            HelmoftheWise = 110000,

            [Annotation(Name = "Armor of the Glorious", Description = nameof(ItemCategory.Armor))]
            ArmoroftheGlorious = 111000,

            [Annotation(Name = "Gauntlets of the Vanquisher", Description = nameof(ItemCategory.Armor))]
            GauntletsoftheVanquisher = 112000,

            [Annotation(Name = "Boots of the Explorer", Description = nameof(ItemCategory.Armor))]
            BootsoftheExplorer = 113000,

            [Annotation(Name = "Stone Helm", Description = nameof(ItemCategory.Armor))]
            StoneHelm = 120000,

            [Annotation(Name = "Stone Armor", Description = nameof(ItemCategory.Armor))]
            StoneArmor = 121000,

            [Annotation(Name = "Stone Gauntlets", Description = nameof(ItemCategory.Armor))]
            StoneGauntlets = 122000,

            [Annotation(Name = "Stone Leggings", Description = nameof(ItemCategory.Armor))]
            StoneLeggings = 123000,

            [Annotation(Name = "Crystalline Helm", Description = nameof(ItemCategory.Armor))]
            CrystallineHelm = 130000,

            [Annotation(Name = "Crystalline Armor", Description = nameof(ItemCategory.Armor))]
            CrystallineArmor = 131000,

            [Annotation(Name = "Crystalline Gauntlets", Description = nameof(ItemCategory.Armor))]
            CrystallineGauntlets = 132000,

            [Annotation(Name = "Crystalline Leggings", Description = nameof(ItemCategory.Armor))]
            CrystallineLeggings = 133000,

            [Annotation(Name = "Mask of the Sealer", Description = nameof(ItemCategory.Armor))]
            MaskoftheSealer = 140000,

            [Annotation(Name = "Crimson Robe", Description = nameof(ItemCategory.Armor))]
            CrimsonRobe = 141000,

            [Annotation(Name = "Crimson Gloves", Description = nameof(ItemCategory.Armor))]
            CrimsonGloves = 142000,

            [Annotation(Name = "Crimson Waistcloth", Description = nameof(ItemCategory.Armor))]
            CrimsonWaistcloth = 143000,

            [Annotation(Name = "Mask of Velka", Description = nameof(ItemCategory.Armor))]
            MaskofVelka = 150000,

            [Annotation(Name = "Black Cleric Robe", Description = nameof(ItemCategory.Armor))]
            BlackClericRobe = 151000,

            [Annotation(Name = "Black Manchette", Description = nameof(ItemCategory.Armor))]
            BlackManchette = 152000,

            [Annotation(Name = "Black Tights", Description = nameof(ItemCategory.Armor))]
            BlackTights = 153000,

            [Annotation(Name = "Iron Helm", Description = nameof(ItemCategory.Armor))]
            IronHelm = 160000,

            [Annotation(Name = "Armor of the Sun", Description = nameof(ItemCategory.Armor))]
            ArmoroftheSun = 161000,

            [Annotation(Name = "Iron Bracelet", Description = nameof(ItemCategory.Armor))]
            IronBracelet = 162000,

            [Annotation(Name = "Iron Leggings", Description = nameof(ItemCategory.Armor))]
            IronLeggings = 163000,

            [Annotation(Name = "Chain Helm", Description = nameof(ItemCategory.Armor))]
            ChainHelm = 170000,

            [Annotation(Name = "Chain Armor", Description = nameof(ItemCategory.Armor))]
            ChainArmor = 171000,

            [Annotation(Name = "Leather Gauntlets", Description = nameof(ItemCategory.Armor))]
            LeatherGauntlets = 172000,

            [Annotation(Name = "Chain Leggings", Description = nameof(ItemCategory.Armor))]
            ChainLeggings = 173000,

            [Annotation(Name = "Cleric Helm", Description = nameof(ItemCategory.Armor))]
            ClericHelm = 180000,

            [Annotation(Name = "Cleric Armor", Description = nameof(ItemCategory.Armor))]
            ClericArmor = 181000,

            [Annotation(Name = "Cleric Gauntlets", Description = nameof(ItemCategory.Armor))]
            ClericGauntlets = 182000,

            [Annotation(Name = "Cleric Leggings", Description = nameof(ItemCategory.Armor))]
            ClericLeggings = 183000,

            [Annotation(Name = "Sunlight Maggot", Description = nameof(ItemCategory.Armor))]
            SunlightMaggot = 190000,

            [Annotation(Name = "Helm of Thorns", Description = nameof(ItemCategory.Armor))]
            HelmofThorns = 200000,

            [Annotation(Name = "Armor of Thorns", Description = nameof(ItemCategory.Armor))]
            ArmorofThorns = 201000,

            [Annotation(Name = "Gauntlets of Thorns", Description = nameof(ItemCategory.Armor))]
            GauntletsofThorns = 202000,

            [Annotation(Name = "Leggings of Thorns", Description = nameof(ItemCategory.Armor))]
            LeggingsofThorns = 203000,

            [Annotation(Name = "Standard Helm", Description = nameof(ItemCategory.Armor))]
            StandardHelm = 210000,

            [Annotation(Name = "Hard Leather Armor", Description = nameof(ItemCategory.Armor))]
            HardLeatherArmor = 211000,

            [Annotation(Name = "Hard Leather Gauntlets", Description = nameof(ItemCategory.Armor))]
            HardLeatherGauntlets = 212000,

            [Annotation(Name = "Hard Leather Boots", Description = nameof(ItemCategory.Armor))]
            HardLeatherBoots = 213000,

            [Annotation(Name = "Sorcerer Hat", Description = nameof(ItemCategory.Armor))]
            SorcererHat = 220000,

            [Annotation(Name = "Sorcerer Cloak", Description = nameof(ItemCategory.Armor))]
            SorcererCloak = 221000,

            [Annotation(Name = "Sorcerer Gauntlets", Description = nameof(ItemCategory.Armor))]
            SorcererGauntlets = 222000,

            [Annotation(Name = "Sorcerer Boots", Description = nameof(ItemCategory.Armor))]
            SorcererBoots = 223000,

            [Annotation(Name = "Tattered Cloth Hood", Description = nameof(ItemCategory.Armor))]
            TatteredClothHood = 230000,

            [Annotation(Name = "Tattered Cloth Robe", Description = nameof(ItemCategory.Armor))]
            TatteredClothRobe = 231000,

            [Annotation(Name = "Tattered Cloth Manchette", Description = nameof(ItemCategory.Armor))]
            TatteredClothManchette = 232000,

            [Annotation(Name = "Heavy Boots", Description = nameof(ItemCategory.Armor))]
            HeavyBoots = 233000,

            [Annotation(Name = "Pharis's Hat", Description = nameof(ItemCategory.Armor))]
            PharissHat = 240000,

            [Annotation(Name = "Leather Armor", Description = nameof(ItemCategory.Armor))]
            LeatherArmor = 241000,

            [Annotation(Name = "Leather Gloves", Description = nameof(ItemCategory.Armor))]
            LeatherGloves = 242000,

            [Annotation(Name = "Leather Boots", Description = nameof(ItemCategory.Armor))]
            LeatherBoots = 243000,

            [Annotation(Name = "Painting Guardian Hood", Description = nameof(ItemCategory.Armor))]
            PaintingGuardianHood = 250000,

            [Annotation(Name = "Painting Guardian Robe", Description = nameof(ItemCategory.Armor))]
            PaintingGuardianRobe = 251000,

            [Annotation(Name = "Painting Guardian Gloves", Description = nameof(ItemCategory.Armor))]
            PaintingGuardianGloves = 252000,

            [Annotation(Name = "Painting Guardian Waistcloth", Description = nameof(ItemCategory.Armor))]
            PaintingGuardianWaistcloth = 253000,

            [Annotation(Name = "Ornstein's Helm", Description = nameof(ItemCategory.Armor))]
            OrnsteinsHelm = 270000,

            [Annotation(Name = "Ornstein's Armor", Description = nameof(ItemCategory.Armor))]
            OrnsteinsArmor = 271000,

            [Annotation(Name = "Ornstein's Gauntlets", Description = nameof(ItemCategory.Armor))]
            OrnsteinsGauntlets = 272000,

            [Annotation(Name = "Ornstein's Leggings", Description = nameof(ItemCategory.Armor))]
            OrnsteinsLeggings = 273000,

            [Annotation(Name = "Eastern Helm", Description = nameof(ItemCategory.Armor))]
            EasternHelm = 280000,

            [Annotation(Name = "Eastern Armor", Description = nameof(ItemCategory.Armor))]
            EasternArmor = 281000,

            [Annotation(Name = "Eastern Gauntlets", Description = nameof(ItemCategory.Armor))]
            EasternGauntlets = 282000,

            [Annotation(Name = "Eastern Leggings", Description = nameof(ItemCategory.Armor))]
            EasternLeggings = 283000,

            [Annotation(Name = "Xanthous Crown", Description = nameof(ItemCategory.Armor))]
            XanthousCrown = 290000,

            [Annotation(Name = "Xanthous Overcoat", Description = nameof(ItemCategory.Armor))]
            XanthousOvercoat = 291000,

            [Annotation(Name = "Xanthous Gloves", Description = nameof(ItemCategory.Armor))]
            XanthousGloves = 292000,

            [Annotation(Name = "Xanthous Waistcloth", Description = nameof(ItemCategory.Armor))]
            XanthousWaistcloth = 293000,

            [Annotation(Name = "Thief Mask", Description = nameof(ItemCategory.Armor))]
            ThiefMask = 300000,

            [Annotation(Name = "Black Leather Armor", Description = nameof(ItemCategory.Armor))]
            BlackLeatherArmor = 301000,

            [Annotation(Name = "Black Leather Gloves", Description = nameof(ItemCategory.Armor))]
            BlackLeatherGloves = 302000,

            [Annotation(Name = "Black Leather Boots", Description = nameof(ItemCategory.Armor))]
            BlackLeatherBoots = 303000,

            [Annotation(Name = "Priest's Hat", Description = nameof(ItemCategory.Armor))]
            PriestsHat = 310000,

            [Annotation(Name = "Holy Robe", Description = nameof(ItemCategory.Armor))]
            HolyRobe = 311000,

            [Annotation(Name = "Traveling Gloves (Holy)", Description = nameof(ItemCategory.Armor))]
            TravelingGlovesHoly = 312000,

            [Annotation(Name = "Holy Trousers", Description = nameof(ItemCategory.Armor))]
            HolyTrousers = 313000,

            [Annotation(Name = "Black Knight Helm", Description = nameof(ItemCategory.Armor))]
            BlackKnightHelm = 320000,

            [Annotation(Name = "Black Knight Armor", Description = nameof(ItemCategory.Armor))]
            BlackKnightArmor = 321000,

            [Annotation(Name = "Black Knight Gauntlets", Description = nameof(ItemCategory.Armor))]
            BlackKnightGauntlets = 322000,

            [Annotation(Name = "Black Knight Leggings", Description = nameof(ItemCategory.Armor))]
            BlackKnightLeggings = 323000,

            [Annotation(Name = "Crown of Dusk", Description = nameof(ItemCategory.Armor))]
            CrownofDusk = 330000,

            [Annotation(Name = "Antiquated Dress", Description = nameof(ItemCategory.Armor))]
            AntiquatedDress = 331000,

            [Annotation(Name = "Antiquated Gloves", Description = nameof(ItemCategory.Armor))]
            AntiquatedGloves = 332000,

            [Annotation(Name = "Antiquated Skirt", Description = nameof(ItemCategory.Armor))]
            AntiquatedSkirt = 333000,

            [Annotation(Name = "Witch Hat", Description = nameof(ItemCategory.Armor))]
            WitchHat = 340000,

            [Annotation(Name = "Witch Cloak", Description = nameof(ItemCategory.Armor))]
            WitchCloak = 341000,

            [Annotation(Name = "Witch Gloves", Description = nameof(ItemCategory.Armor))]
            WitchGloves = 342000,

            [Annotation(Name = "Witch Skirt", Description = nameof(ItemCategory.Armor))]
            WitchSkirt = 343000,

            [Annotation(Name = "Elite Knight Helm", Description = nameof(ItemCategory.Armor))]
            EliteKnightHelm = 350000,

            [Annotation(Name = "Elite Knight Armor", Description = nameof(ItemCategory.Armor))]
            EliteKnightArmor = 351000,

            [Annotation(Name = "Elite Knight Gauntlets", Description = nameof(ItemCategory.Armor))]
            EliteKnightGauntlets = 352000,

            [Annotation(Name = "Elite Knight Leggings", Description = nameof(ItemCategory.Armor))]
            EliteKnightLeggings = 353000,

            [Annotation(Name = "Wanderer Hood", Description = nameof(ItemCategory.Armor))]
            WandererHood = 360000,

            [Annotation(Name = "Wanderer Coat", Description = nameof(ItemCategory.Armor))]
            WandererCoat = 361000,

            [Annotation(Name = "Wanderer Manchette", Description = nameof(ItemCategory.Armor))]
            WandererManchette = 362000,

            [Annotation(Name = "Wanderer Boots", Description = nameof(ItemCategory.Armor))]
            WandererBoots = 363000,

            [Annotation(Name = "Big Hat", Description = nameof(ItemCategory.Armor))]
            BigHat = 380000,

            [Annotation(Name = "Sage Robe", Description = nameof(ItemCategory.Armor))]
            SageRobe = 381000,

            [Annotation(Name = "Traveling Gloves (Sage)", Description = nameof(ItemCategory.Armor))]
            TravelingGlovesSage = 382000,

            [Annotation(Name = "Traveling Boots", Description = nameof(ItemCategory.Armor))]
            TravelingBoots = 383000,

            [Annotation(Name = "Knight Helm", Description = nameof(ItemCategory.Armor))]
            KnightHelm = 390000,

            [Annotation(Name = "Knight Armor", Description = nameof(ItemCategory.Armor))]
            KnightArmor = 391000,

            [Annotation(Name = "Knight Gauntlets", Description = nameof(ItemCategory.Armor))]
            KnightGauntlets = 392000,

            [Annotation(Name = "Knight Leggings", Description = nameof(ItemCategory.Armor))]
            KnightLeggings = 393000,

            [Annotation(Name = "Dingy Hood", Description = nameof(ItemCategory.Armor))]
            DingyHood = 400000,

            [Annotation(Name = "Dingy Robe", Description = nameof(ItemCategory.Armor))]
            DingyRobe = 401000,

            [Annotation(Name = "Dingy Gloves", Description = nameof(ItemCategory.Armor))]
            DingyGloves = 402000,

            [Annotation(Name = "Blood-Stained Skirt", Description = nameof(ItemCategory.Armor))]
            BloodStainedSkirt = 403000,

            [Annotation(Name = "Maiden Hood", Description = nameof(ItemCategory.Armor))]
            MaidenHood = 410000,

            [Annotation(Name = "Maiden Robe", Description = nameof(ItemCategory.Armor))]
            MaidenRobe = 411000,

            [Annotation(Name = "Maiden Gloves", Description = nameof(ItemCategory.Armor))]
            MaidenGloves = 412000,

            [Annotation(Name = "Maiden Skirt", Description = nameof(ItemCategory.Armor))]
            MaidenSkirt = 413000,

            [Annotation(Name = "Silver Knight Helm", Description = nameof(ItemCategory.Armor))]
            SilverKnightHelm = 420000,

            [Annotation(Name = "Silver Knight Armor", Description = nameof(ItemCategory.Armor))]
            SilverKnightArmor = 421000,

            [Annotation(Name = "Silver Knight Gauntlets", Description = nameof(ItemCategory.Armor))]
            SilverKnightGauntlets = 422000,

            [Annotation(Name = "Silver Knight Leggings", Description = nameof(ItemCategory.Armor))]
            SilverKnightLeggings = 423000,

            [Annotation(Name = "Havel's Helm", Description = nameof(ItemCategory.Armor))]
            HavelsHelm = 440000,

            [Annotation(Name = "Havel's Armor", Description = nameof(ItemCategory.Armor))]
            HavelsArmor = 441000,

            [Annotation(Name = "Havel's Gauntlets", Description = nameof(ItemCategory.Armor))]
            HavelsGauntlets = 442000,

            [Annotation(Name = "Havel's Leggings", Description = nameof(ItemCategory.Armor))]
            HavelsLeggings = 443000,

            [Annotation(Name = "Brass Helm", Description = nameof(ItemCategory.Armor))]
            BrassHelm = 450000,

            [Annotation(Name = "Brass Armor", Description = nameof(ItemCategory.Armor))]
            BrassArmor = 451000,

            [Annotation(Name = "Brass Gauntlets", Description = nameof(ItemCategory.Armor))]
            BrassGauntlets = 452000,

            [Annotation(Name = "Brass Leggings", Description = nameof(ItemCategory.Armor))]
            BrassLeggings = 453000,

            [Annotation(Name = "Gold-Hemmed Black Hood", Description = nameof(ItemCategory.Armor))]
            GoldHemmedBlackHood = 460000,

            [Annotation(Name = "Gold-Hemmed Black Cloak", Description = nameof(ItemCategory.Armor))]
            GoldHemmedBlackCloak = 461000,

            [Annotation(Name = "Gold-Hemmed Black Gloves", Description = nameof(ItemCategory.Armor))]
            GoldHemmedBlackGloves = 462000,

            [Annotation(Name = "Gold-Hemmed Black Skirt", Description = nameof(ItemCategory.Armor))]
            GoldHemmedBlackSkirt = 463000,

            [Annotation(Name = "Golem Helm", Description = nameof(ItemCategory.Armor))]
            GolemHelm = 470000,

            [Annotation(Name = "Golem Armor", Description = nameof(ItemCategory.Armor))]
            GolemArmor = 471000,

            [Annotation(Name = "Golem Gauntlets", Description = nameof(ItemCategory.Armor))]
            GolemGauntlets = 472000,

            [Annotation(Name = "Golem Leggings", Description = nameof(ItemCategory.Armor))]
            GolemLeggings = 473000,

            [Annotation(Name = "Hollow Soldier Helm", Description = nameof(ItemCategory.Armor))]
            HollowSoldierHelm = 480000,

            [Annotation(Name = "Hollow Soldier Armor", Description = nameof(ItemCategory.Armor))]
            HollowSoldierArmor = 481000,

            [Annotation(Name = "Hollow Soldier Waistcloth", Description = nameof(ItemCategory.Armor))]
            HollowSoldierWaistcloth = 483000,

            [Annotation(Name = "Steel Helm", Description = nameof(ItemCategory.Armor))]
            SteelHelm = 490000,

            [Annotation(Name = "Steel Armor", Description = nameof(ItemCategory.Armor))]
            SteelArmor = 491000,

            [Annotation(Name = "Steel Gauntlets", Description = nameof(ItemCategory.Armor))]
            SteelGauntlets = 492000,

            [Annotation(Name = "Steel Leggings", Description = nameof(ItemCategory.Armor))]
            SteelLeggings = 493000,

            [Annotation(Name = "Hollow Thief's Hood", Description = nameof(ItemCategory.Armor))]
            HollowThiefsHood = 500000,

            [Annotation(Name = "Hollow Thief's Leather Armor", Description = nameof(ItemCategory.Armor))]
            HollowThiefsLeatherArmor = 501000,

            [Annotation(Name = "Hollow Thief's Tights", Description = nameof(ItemCategory.Armor))]
            HollowThiefsTights = 503000,

            [Annotation(Name = "Balder Helm", Description = nameof(ItemCategory.Armor))]
            BalderHelm = 510000,

            [Annotation(Name = "Balder Armor", Description = nameof(ItemCategory.Armor))]
            BalderArmor = 511000,

            [Annotation(Name = "Balder Gauntlets", Description = nameof(ItemCategory.Armor))]
            BalderGauntlets = 512000,

            [Annotation(Name = "Balder Leggings", Description = nameof(ItemCategory.Armor))]
            BalderLeggings = 513000,

            [Annotation(Name = "Hollow Warrior Helm", Description = nameof(ItemCategory.Armor))]
            HollowWarriorHelm = 520000,

            [Annotation(Name = "Hollow Warrior Armor", Description = nameof(ItemCategory.Armor))]
            HollowWarriorArmor = 521000,

            [Annotation(Name = "Hollow Warrior Waistcloth", Description = nameof(ItemCategory.Armor))]
            HollowWarriorWaistcloth = 523000,

            [Annotation(Name = "Giant Helm", Description = nameof(ItemCategory.Armor))]
            GiantHelm = 530000,

            [Annotation(Name = "Giant Armor", Description = nameof(ItemCategory.Armor))]
            GiantArmor = 531000,

            [Annotation(Name = "Giant Gauntlets", Description = nameof(ItemCategory.Armor))]
            GiantGauntlets = 532000,

            [Annotation(Name = "Giant Leggings", Description = nameof(ItemCategory.Armor))]
            GiantLeggings = 533000,

            [Annotation(Name = "Crown of the Dark Sun", Description = nameof(ItemCategory.Armor))]
            CrownoftheDarkSun = 540000,

            [Annotation(Name = "Moonlight Robe", Description = nameof(ItemCategory.Armor))]
            MoonlightRobe = 541000,

            [Annotation(Name = "Moonlight Gloves", Description = nameof(ItemCategory.Armor))]
            MoonlightGloves = 542000,

            [Annotation(Name = "Moonlight Waistcloth", Description = nameof(ItemCategory.Armor))]
            MoonlightWaistcloth = 543000,

            [Annotation(Name = "Crown of the Great Lord", Description = nameof(ItemCategory.Armor))]
            CrownoftheGreatLord = 550000,

            [Annotation(Name = "Robe of the Great Lord", Description = nameof(ItemCategory.Armor))]
            RobeoftheGreatLord = 551000,

            [Annotation(Name = "Bracelet of the Great Lord", Description = nameof(ItemCategory.Armor))]
            BraceletoftheGreatLord = 552000,

            [Annotation(Name = "Anklet of the Great Lord", Description = nameof(ItemCategory.Armor))]
            AnkletoftheGreatLord = 553000,

            [Annotation(Name = "Sack", Description = nameof(ItemCategory.Armor))]
            Sack = 560000,

            [Annotation(Name = "Symbol of Avarice", Description = nameof(ItemCategory.Armor))]
            SymbolofAvarice = 570000,

            [Annotation(Name = "Royal Helm", Description = nameof(ItemCategory.Armor))]
            RoyalHelm = 580000,

            [Annotation(Name = "Mask of the Father", Description = nameof(ItemCategory.Armor))]
            MaskoftheFather = 590000,

            [Annotation(Name = "Mask of the Mother", Description = nameof(ItemCategory.Armor))]
            MaskoftheMother = 600000,

            [Annotation(Name = "Mask of the Child", Description = nameof(ItemCategory.Armor))]
            MaskoftheChild = 610000,

            [Annotation(Name = "Fang Boar Helm", Description = nameof(ItemCategory.Armor))]
            FangBoarHelm = 620000,

            [Annotation(Name = "Gargoyle Helm", Description = nameof(ItemCategory.Armor))]
            GargoyleHelm = 630000,

            [Annotation(Name = "Black Sorcerer Hat", Description = nameof(ItemCategory.Armor))]
            BlackSorcererHat = 640000,

            [Annotation(Name = "Black Sorcerer Cloak", Description = nameof(ItemCategory.Armor))]
            BlackSorcererCloak = 641000,

            [Annotation(Name = "Black Sorcerer Gauntlets", Description = nameof(ItemCategory.Armor))]
            BlackSorcererGauntlets = 642000,

            [Annotation(Name = "Black Sorcerer Boots", Description = nameof(ItemCategory.Armor))]
            BlackSorcererBoots = 643000,

            [Annotation(Name = "Helm of Artorias", Description = nameof(ItemCategory.Armor))]
            HelmofArtorias = 660000,

            [Annotation(Name = "Armor of Artorias", Description = nameof(ItemCategory.Armor))]
            ArmorofArtorias = 661000,

            [Annotation(Name = "Gauntlets of Artorias", Description = nameof(ItemCategory.Armor))]
            GauntletsofArtorias = 662000,

            [Annotation(Name = "Leggings of Artorias", Description = nameof(ItemCategory.Armor))]
            LeggingsofArtorias = 663000,

            [Annotation(Name = "Porcelain Mask", Description = nameof(ItemCategory.Armor))]
            PorcelainMask = 670000,

            [Annotation(Name = "Lord's Blade Robe", Description = nameof(ItemCategory.Armor))]
            LordsBladeRobe = 671000,

            [Annotation(Name = "Lord's Blade Gloves", Description = nameof(ItemCategory.Armor))]
            LordsBladeGloves = 672000,

            [Annotation(Name = "Lord's Blade Waistcloth", Description = nameof(ItemCategory.Armor))]
            LordsBladeWaistcloth = 673000,

            [Annotation(Name = "Gough's Helm", Description = nameof(ItemCategory.Armor))]
            GoughsHelm = 680000,

            [Annotation(Name = "Gough's Armor", Description = nameof(ItemCategory.Armor))]
            GoughsArmor = 681000,

            [Annotation(Name = "Gough's Gauntlets", Description = nameof(ItemCategory.Armor))]
            GoughsGauntlets = 682000,

            [Annotation(Name = "Gough's Leggings", Description = nameof(ItemCategory.Armor))]
            GoughsLeggings = 683000,

            [Annotation(Name = "Guardian Helm", Description = nameof(ItemCategory.Armor))]
            GuardianHelm = 690000,

            [Annotation(Name = "Guardian Armor", Description = nameof(ItemCategory.Armor))]
            GuardianArmor = 691000,

            [Annotation(Name = "Guardian Gauntlets", Description = nameof(ItemCategory.Armor))]
            GuardianGauntlets = 692000,

            [Annotation(Name = "Guardian Leggings", Description = nameof(ItemCategory.Armor))]
            GuardianLeggings = 693000,

            [Annotation(Name = "Snickering Top Hat", Description = nameof(ItemCategory.Armor))]
            SnickeringTopHat = 700000,

            [Annotation(Name = "Chester's Long Coat", Description = nameof(ItemCategory.Armor))]
            ChestersLongCoat = 701000,

            [Annotation(Name = "Chester's Gloves", Description = nameof(ItemCategory.Armor))]
            ChestersGloves = 702000,

            [Annotation(Name = "Chester's Trousers", Description = nameof(ItemCategory.Armor))]
            ChestersTrousers = 703000,

            [Annotation(Name = "Bloated Head", Description = nameof(ItemCategory.Armor))]
            BloatedHead = 710000,

            [Annotation(Name = "Bloated Sorcerer Head", Description = nameof(ItemCategory.Armor))]
            BloatedSorcererHead = 720000,

            [Annotation(Name = "Eye of Death", Description = nameof(ItemCategory.Consumables))]
            EyeofDeath = 109,

            [Annotation(Name = "Cracked Red Eye Orb", Description = nameof(ItemCategory.Consumables))]
            CrackedRedEyeOrb = 111,

            [Annotation(Name = "Estus Flask", Description = nameof(ItemCategory.Consumables))]
            EstusFlask = 200,

            [Annotation(Name = "Elizabeth's Mushroom", Description = nameof(ItemCategory.Consumables))]
            ElizabethsMushroom = 230,

            [Annotation(Name = "Divine Blessing", Description = nameof(ItemCategory.Consumables))]
            DivineBlessing = 240,

            [Annotation(Name = "Green Blossom", Description = nameof(ItemCategory.Consumables))]
            GreenBlossom = 260,

            [Annotation(Name = "Bloodred Moss Clump", Description = nameof(ItemCategory.Consumables))]
            BloodredMossClump = 270,

            [Annotation(Name = "Purple Moss Clump", Description = nameof(ItemCategory.Consumables))]
            PurpleMossClump = 271,

            [Annotation(Name = "Blooming Purple Moss Clump", Description = nameof(ItemCategory.Consumables))]
            BloomingPurpleMossClump = 272,

            [Annotation(Name = "Purging Stone", Description = nameof(ItemCategory.Consumables))]
            PurgingStone = 274,

            [Annotation(Name = "Egg Vermifuge", Description = nameof(ItemCategory.Consumables))]
            EggVermifuge = 275,

            [Annotation(Name = "Repair Powder", Description = nameof(ItemCategory.Consumables))]
            RepairPowder = 280,

            [Annotation(Name = "Throwing Knife", Description = nameof(ItemCategory.Consumables))]
            ThrowingKnife = 290,

            [Annotation(Name = "Poison Throwing Knife", Description = nameof(ItemCategory.Consumables))]
            PoisonThrowingKnife = 291,

            [Annotation(Name = "Firebomb", Description = nameof(ItemCategory.Consumables))]
            Firebomb = 292,

            [Annotation(Name = "Dung Pie", Description = nameof(ItemCategory.Consumables))]
            DungPie = 293,

            [Annotation(Name = "Alluring Skull", Description = nameof(ItemCategory.Consumables))]
            AlluringSkull = 294,

            [Annotation(Name = "Lloyd's Talisman", Description = nameof(ItemCategory.Consumables))]
            LloydsTalisman = 296,

            [Annotation(Name = "Black Firebomb", Description = nameof(ItemCategory.Consumables))]
            BlackFirebomb = 297,

            [Annotation(Name = "Charcoal Pine Resin", Description = nameof(ItemCategory.Consumables))]
            CharcoalPineResin = 310,

            [Annotation(Name = "Gold Pine Resin", Description = nameof(ItemCategory.Consumables))]
            GoldPineResin = 311,

            [Annotation(Name = "Transient Curse", Description = nameof(ItemCategory.Consumables))]
            TransientCurse = 312,

            [Annotation(Name = "Rotten Pine Resin", Description = nameof(ItemCategory.Consumables))]
            RottenPineResin = 313,

            [Annotation(Name = "Homeward Bone", Description = nameof(ItemCategory.Consumables))]
            HomewardBone = 330,

            [Annotation(Name = "Prism Stone", Description = nameof(ItemCategory.Consumables))]
            PrismStone = 370,

            [Annotation(Name = "Indictment", Description = nameof(ItemCategory.Consumables))]
            Indictment = 373,

            [Annotation(Name = "Souvenir of Reprisal", Description = nameof(ItemCategory.Consumables))]
            SouvenirofReprisal = 374,

            [Annotation(Name = "Sunlight Medal", Description = nameof(ItemCategory.Consumables))]
            SunlightMedal = 375,

            [Annotation(Name = "Pendant", Description = nameof(ItemCategory.Consumables))]
            Pendant = 376,

            [Annotation(Name = "Rubbish", Description = nameof(ItemCategory.Consumables))]
            Rubbish = 380,

            [Annotation(Name = "Copper Coin", Description = nameof(ItemCategory.Consumables))]
            CopperCoin = 381,

            [Annotation(Name = "Silver Coin", Description = nameof(ItemCategory.Consumables))]
            SilverCoin = 382,

            [Annotation(Name = "Gold Coin", Description = nameof(ItemCategory.Consumables))]
            GoldCoin = 383,

            [Annotation(Name = "Fire Keeper Soul (Anastacia of Astora)", Description = nameof(ItemCategory.Consumables))]
            FireKeeperSoulAnastaciaofAstora = 390,

            [Annotation(Name = "Fire Keeper Soul (Darkmoon Knightess)", Description = nameof(ItemCategory.Consumables))]
            FireKeeperSoulDarkmoonKnightess = 391,

            [Annotation(Name = "Fire Keeper Soul (Daughter of Chaos)", Description = nameof(ItemCategory.Consumables))]
            FireKeeperSoulDaughterofChaos = 392,

            [Annotation(Name = "Fire Keeper Soul (New Londo)", Description = nameof(ItemCategory.Consumables))]
            FireKeeperSoulNewLondo = 393,

            [Annotation(Name = "Fire Keeper Soul (Blighttown)", Description = nameof(ItemCategory.Consumables))]
            FireKeeperSoulBlighttown = 394,

            [Annotation(Name = "Fire Keeper Soul (Duke's Archives)", Description = nameof(ItemCategory.Consumables))]
            FireKeeperSoulDukesArchives = 395,

            [Annotation(Name = "Fire Keeper Soul (Undead Parish)", Description = nameof(ItemCategory.Consumables))]
            FireKeeperSoulUndeadParish = 396,

            [Annotation(Name = "Soul of a Lost Undead", Description = nameof(ItemCategory.Consumables))]
            SoulofaLostUndead = 400,

            [Annotation(Name = "Large Soul of a Lost Undead", Description = nameof(ItemCategory.Consumables))]
            LargeSoulofaLostUndead = 401,

            [Annotation(Name = "Soul of a Nameless Soldier", Description = nameof(ItemCategory.Consumables))]
            SoulofaNamelessSoldier = 402,

            [Annotation(Name = "Large Soul of a Nameless Soldier", Description = nameof(ItemCategory.Consumables))]
            LargeSoulofaNamelessSoldier = 403,

            [Annotation(Name = "Soul of a Proud Knight", Description = nameof(ItemCategory.Consumables))]
            SoulofaProudKnight = 404,

            [Annotation(Name = "Large Soul of a Proud Knight", Description = nameof(ItemCategory.Consumables))]
            LargeSoulofaProudKnight = 405,

            [Annotation(Name = "Soul of a Brave Warrior", Description = nameof(ItemCategory.Consumables))]
            SoulofaBraveWarrior = 406,

            [Annotation(Name = "Large Soul of a Brave Warrior", Description = nameof(ItemCategory.Consumables))]
            LargeSoulofaBraveWarrior = 407,

            [Annotation(Name = "Soul of a Hero", Description = nameof(ItemCategory.Consumables))]
            SoulofaHero = 408,

            [Annotation(Name = "Soul of a Great Hero", Description = nameof(ItemCategory.Consumables))]
            SoulofaGreatHero = 409,

            [Annotation(Name = "Humanity", Description = nameof(ItemCategory.Consumables))]
            Humanity = 500,

            [Annotation(Name = "Twin Humanities", Description = nameof(ItemCategory.Consumables))]
            TwinHumanities = 501,

            [Annotation(Name = "Soul of Quelaag", Description = nameof(ItemCategory.Consumables))]
            SoulofQuelaag = 700,

            [Annotation(Name = "Soul of Sif", Description = nameof(ItemCategory.Consumables))]
            SoulofSif = 701,

            [Annotation(Name = "Soul of Gwyn, Lord of Cinder", Description = nameof(ItemCategory.Consumables))]
            SoulofGwynLordofCinder = 702,

            [Annotation(Name = "Core of an Iron Golem", Description = nameof(ItemCategory.Consumables))]
            CoreofanIronGolem = 703,

            [Annotation(Name = "Soul of Ornstein", Description = nameof(ItemCategory.Consumables))]
            SoulofOrnstein = 704,

            [Annotation(Name = "Soul of the Moonlight Butterfly", Description = nameof(ItemCategory.Consumables))]
            SouloftheMoonlightButterfly = 705,

            [Annotation(Name = "Soul of Smough", Description = nameof(ItemCategory.Consumables))]
            SoulofSmough = 706,

            [Annotation(Name = "Soul of Priscilla", Description = nameof(ItemCategory.Consumables))]
            SoulofPriscilla = 707,

            [Annotation(Name = "Soul of Gwyndolin", Description = nameof(ItemCategory.Consumables))]
            SoulofGwyndolin = 708,

            [Annotation(Name = "Guardian Soul", Description = nameof(ItemCategory.Consumables))]
            GuardianSoul = 709,

            [Annotation(Name = "Soul of Artorias", Description = nameof(ItemCategory.Consumables))]
            SoulofArtorias = 710,

            [Annotation(Name = "Soul of Manus", Description = nameof(ItemCategory.Consumables))]
            SoulofManus = 711,

            [Annotation(Name = "Peculiar Doll", Description = nameof(ItemCategory.Key))]
            PeculiarDoll = 384,

            [Annotation(Name = "Basement Key", Description = nameof(ItemCategory.Key))]
            BasementKey = 2001,

            [Annotation(Name = "Crest of Artorias", Description = nameof(ItemCategory.Key))]
            CrestofArtorias = 2002,

            [Annotation(Name = "Cage Key", Description = nameof(ItemCategory.Key))]
            CageKey = 2003,

            [Annotation(Name = "Archive Tower Cell Key", Description = nameof(ItemCategory.Key))]
            ArchiveTowerCellKey = 2004,

            [Annotation(Name = "Archive Tower Giant Door Key", Description = nameof(ItemCategory.Key))]
            ArchiveTowerGiantDoorKey = 2005,

            [Annotation(Name = "Archive Tower Giant Cell Key", Description = nameof(ItemCategory.Key))]
            ArchiveTowerGiantCellKey = 2006,

            [Annotation(Name = "Blighttown Key", Description = nameof(ItemCategory.Key))]
            BlighttownKey = 2007,

            [Annotation(Name = "Key to New Londo Ruins", Description = nameof(ItemCategory.Key))]
            KeytoNewLondoRuins = 2008,

            [Annotation(Name = "Annex Key", Description = nameof(ItemCategory.Key))]
            AnnexKey = 2009,

            [Annotation(Name = "Dungeon Cell Key", Description = nameof(ItemCategory.Key))]
            DungeonCellKey = 2010,

            [Annotation(Name = "Big Pilgrim's Key", Description = nameof(ItemCategory.Key))]
            BigPilgrimsKey = 2011,

            [Annotation(Name = "Undead Asylum F2 East Key", Description = nameof(ItemCategory.Key))]
            UndeadAsylumF2EastKey = 2012,

            [Annotation(Name = "Key to the Seal", Description = nameof(ItemCategory.Key))]
            KeytotheSeal = 2013,

            [Annotation(Name = "Key to Depths", Description = nameof(ItemCategory.Key))]
            KeytoDepths = 2014,

            [Annotation(Name = "Undead Asylum F2 West Key", Description = nameof(ItemCategory.Key))]
            UndeadAsylumF2WestKey = 2016,

            [Annotation(Name = "Mystery Key", Description = nameof(ItemCategory.Key))]
            MysteryKey = 2017,

            [Annotation(Name = "Sewer Chamber Key", Description = nameof(ItemCategory.Key))]
            SewerChamberKey = 2018,

            [Annotation(Name = "Watchtower Basement Key", Description = nameof(ItemCategory.Key))]
            WatchtowerBasementKey = 2019,

            [Annotation(Name = "Archive Prison Extra Key", Description = nameof(ItemCategory.Key))]
            ArchivePrisonExtraKey = 2020,

            [Annotation(Name = "Residence Key", Description = nameof(ItemCategory.Key))]
            ResidenceKey = 2021,

            [Annotation(Name = "Crest Key", Description = nameof(ItemCategory.Key))]
            CrestKey = 2022,

            [Annotation(Name = "Master Key", Description = nameof(ItemCategory.Key))]
            MasterKey = 2100,

            [Annotation(Name = "Lord Soul (Nito)", Description = nameof(ItemCategory.Key))]
            LordSoulNito = 2500,

            [Annotation(Name = "Lord Soul (Bed of Chaos)", Description = nameof(ItemCategory.Key))]
            LordSoulBedofChaos = 2501,

            [Annotation(Name = "Bequeathed Lord Soul Shard (Four Kings)", Description = nameof(ItemCategory.Key))]
            BequeathedLordSoulShardFourKings = 2502,

            [Annotation(Name = "Bequeathed Lord Soul Shard (Seath)", Description = nameof(ItemCategory.Key))]
            BequeathedLordSoulShardSeath = 2503,

            [Annotation(Name = "Lordvessel", Description = nameof(ItemCategory.Key))]
            Lordvessel = 2510,

            [Annotation(Name = "Broken Pendant", Description = nameof(ItemCategory.Key))]
            BrokenPendant = 2520,

            [Annotation(Name = "Weapon Smithbox", Description = nameof(ItemCategory.Key))]
            WeaponSmithbox = 2600,

            [Annotation(Name = "Armor Smithbox", Description = nameof(ItemCategory.Key))]
            ArmorSmithbox = 2601,

            [Annotation(Name = "Repairbox", Description = nameof(ItemCategory.Key))]
            Repairbox = 2602,

            [Annotation(Name = "Rite of Kindling", Description = nameof(ItemCategory.Key))]
            RiteofKindling = 2607,

            [Annotation(Name = "Bottomless Box", Description = nameof(ItemCategory.Key))]
            BottomlessBox = 2608,

            [Annotation(Name = "Dagger", Description = nameof(ItemCategory.MeleeWeapons))]
            Dagger = 100000,

            [Annotation(Name = "Parrying Dagger", Description = nameof(ItemCategory.MeleeWeapons))]
            ParryingDagger = 101000,

            [Annotation(Name = "Ghost Blade", Description = nameof(ItemCategory.MeleeWeapons))]
            GhostBlade = 102000,

            [Annotation(Name = "Bandit's Knife", Description = nameof(ItemCategory.MeleeWeapons))]
            BanditsKnife = 103000,

            [Annotation(Name = "Priscilla's Dagger", Description = nameof(ItemCategory.MeleeWeapons))]
            PriscillasDagger = 104000,

            [Annotation(Name = "Shortsword", Description = nameof(ItemCategory.MeleeWeapons))]
            Shortsword = 200000,

            [Annotation(Name = "Longsword", Description = nameof(ItemCategory.MeleeWeapons))]
            Longsword = 201000,

            [Annotation(Name = "Broadsword", Description = nameof(ItemCategory.MeleeWeapons))]
            Broadsword = 202000,

            [Annotation(Name = "Broken Straight Sword", Description = nameof(ItemCategory.MeleeWeapons))]
            BrokenStraightSword = 203000,

            [Annotation(Name = "Balder Side Sword", Description = nameof(ItemCategory.MeleeWeapons))]
            BalderSideSword = 204000,

            [Annotation(Name = "Crystal Straight Sword", Description = nameof(ItemCategory.MeleeWeapons))]
            CrystalStraightSword = 205000,

            [Annotation(Name = "Sunlight Straight Sword", Description = nameof(ItemCategory.MeleeWeapons))]
            SunlightStraightSword = 206000,

            [Annotation(Name = "Barbed Straight Sword", Description = nameof(ItemCategory.MeleeWeapons))]
            BarbedStraightSword = 207000,

            [Annotation(Name = "Silver Knight Straight Sword", Description = nameof(ItemCategory.MeleeWeapons))]
            SilverKnightStraightSword = 208000,

            [Annotation(Name = "Astora's Straight Sword", Description = nameof(ItemCategory.MeleeWeapons))]
            AstorasStraightSword = 209000,

            [Annotation(Name = "Darksword", Description = nameof(ItemCategory.MeleeWeapons))]
            Darksword = 210000,

            [Annotation(Name = "Drake Sword", Description = nameof(ItemCategory.MeleeWeapons))]
            DrakeSword = 211000,

            [Annotation(Name = "Straight Sword Hilt", Description = nameof(ItemCategory.MeleeWeapons))]
            StraightSwordHilt = 212000,

            [Annotation(Name = "Bastard Sword", Description = nameof(ItemCategory.MeleeWeapons))]
            BastardSword = 300000,

            [Annotation(Name = "Claymore", Description = nameof(ItemCategory.MeleeWeapons))]
            Claymore = 301000,

            [Annotation(Name = "Man-serpent Greatsword", Description = nameof(ItemCategory.MeleeWeapons))]
            ManserpentGreatsword = 302000,

            [Annotation(Name = "Flamberge", Description = nameof(ItemCategory.MeleeWeapons))]
            Flamberge = 303000,

            [Annotation(Name = "Crystal Greatsword", Description = nameof(ItemCategory.MeleeWeapons))]
            CrystalGreatsword = 304000,

            [Annotation(Name = "Stone Greatsword", Description = nameof(ItemCategory.MeleeWeapons))]
            StoneGreatsword = 306000,

            [Annotation(Name = "Greatsword of Artorias", Description = nameof(ItemCategory.MeleeWeapons))]
            GreatswordofArtorias = 307000,

            [Annotation(Name = "Moonlight Greatsword", Description = nameof(ItemCategory.MeleeWeapons))]
            MoonlightGreatsword = 309000,

            [Annotation(Name = "Black Knight Sword", Description = nameof(ItemCategory.MeleeWeapons))]
            BlackKnightSword = 310000,

            [Annotation(Name = "Greatsword of Artorias (Cursed)", Description = nameof(ItemCategory.MeleeWeapons))]
            GreatswordofArtoriasCursed = 311000,

            [Annotation(Name = "Great Lord Greatsword", Description = nameof(ItemCategory.MeleeWeapons))]
            GreatLordGreatsword = 314000,

            [Annotation(Name = "Zweihander", Description = nameof(ItemCategory.MeleeWeapons))]
            Zweihander = 350000,

            [Annotation(Name = "Greatsword", Description = nameof(ItemCategory.MeleeWeapons))]
            Greatsword = 351000,

            [Annotation(Name = "Demon Great Machete", Description = nameof(ItemCategory.MeleeWeapons))]
            DemonGreatMachete = 352000,

            [Annotation(Name = "Dragon Greatsword", Description = nameof(ItemCategory.MeleeWeapons))]
            DragonGreatsword = 354000,

            [Annotation(Name = "Black Knight Greatsword", Description = nameof(ItemCategory.MeleeWeapons))]
            BlackKnightGreatsword = 355000,

            [Annotation(Name = "Scimitar", Description = nameof(ItemCategory.MeleeWeapons))]
            Scimitar = 400000,

            [Annotation(Name = "Falchion", Description = nameof(ItemCategory.MeleeWeapons))]
            Falchion = 401000,

            [Annotation(Name = "Shotel", Description = nameof(ItemCategory.MeleeWeapons))]
            Shotel = 402000,

            [Annotation(Name = "Jagged Ghost Blade", Description = nameof(ItemCategory.MeleeWeapons))]
            JaggedGhostBlade = 403000,

            [Annotation(Name = "Painting Guardian Sword", Description = nameof(ItemCategory.MeleeWeapons))]
            PaintingGuardianSword = 405000,

            [Annotation(Name = "Quelaag's Furysword", Description = nameof(ItemCategory.MeleeWeapons))]
            QuelaagsFurysword = 406000,

            [Annotation(Name = "Server", Description = nameof(ItemCategory.MeleeWeapons))]
            Server = 450000,

            [Annotation(Name = "Murakumo", Description = nameof(ItemCategory.MeleeWeapons))]
            Murakumo = 451000,

            [Annotation(Name = "Gravelord Sword", Description = nameof(ItemCategory.MeleeWeapons))]
            GravelordSword = 453000,

            [Annotation(Name = "Uchigatana", Description = nameof(ItemCategory.MeleeWeapons))]
            Uchigatana = 500000,

            [Annotation(Name = "Washing Pole", Description = nameof(ItemCategory.MeleeWeapons))]
            WashingPole = 501000,

            [Annotation(Name = "Iaito", Description = nameof(ItemCategory.MeleeWeapons))]
            Iaito = 502000,

            [Annotation(Name = "Chaos Blade", Description = nameof(ItemCategory.MeleeWeapons))]
            ChaosBlade = 503000,

            [Annotation(Name = "Mail Breaker", Description = nameof(ItemCategory.MeleeWeapons))]
            MailBreaker = 600000,

            [Annotation(Name = "Rapier", Description = nameof(ItemCategory.MeleeWeapons))]
            Rapier = 601000,

            [Annotation(Name = "Estoc", Description = nameof(ItemCategory.MeleeWeapons))]
            Estoc = 602000,

            [Annotation(Name = "Velka's Rapier", Description = nameof(ItemCategory.MeleeWeapons))]
            VelkasRapier = 603000,

            [Annotation(Name = "Ricard's Rapier", Description = nameof(ItemCategory.MeleeWeapons))]
            RicardsRapier = 604000,

            [Annotation(Name = "Hand Axe", Description = nameof(ItemCategory.MeleeWeapons))]
            HandAxe = 700000,

            [Annotation(Name = "Battle Axe", Description = nameof(ItemCategory.MeleeWeapons))]
            BattleAxe = 701000,

            [Annotation(Name = "Crescent Axe", Description = nameof(ItemCategory.MeleeWeapons))]
            CrescentAxe = 702000,

            [Annotation(Name = "Butcher Knife", Description = nameof(ItemCategory.MeleeWeapons))]
            ButcherKnife = 703000,

            [Annotation(Name = "Golem Axe", Description = nameof(ItemCategory.MeleeWeapons))]
            GolemAxe = 704000,

            [Annotation(Name = "Gargoyle Tail Axe", Description = nameof(ItemCategory.MeleeWeapons))]
            GargoyleTailAxe = 705000,

            [Annotation(Name = "Greataxe", Description = nameof(ItemCategory.MeleeWeapons))]
            Greataxe = 750000,

            [Annotation(Name = "Demon's Greataxe", Description = nameof(ItemCategory.MeleeWeapons))]
            DemonsGreataxe = 751000,

            [Annotation(Name = "Dragon King Greataxe", Description = nameof(ItemCategory.MeleeWeapons))]
            DragonKingGreataxe = 752000,

            [Annotation(Name = "Black Knight Greataxe", Description = nameof(ItemCategory.MeleeWeapons))]
            BlackKnightGreataxe = 753000,

            [Annotation(Name = "Club", Description = nameof(ItemCategory.MeleeWeapons))]
            Club = 800000,

            [Annotation(Name = "Mace", Description = nameof(ItemCategory.MeleeWeapons))]
            Mace = 801000,

            [Annotation(Name = "Morning Star", Description = nameof(ItemCategory.MeleeWeapons))]
            MorningStar = 802000,

            [Annotation(Name = "Warpick", Description = nameof(ItemCategory.MeleeWeapons))]
            Warpick = 803000,

            [Annotation(Name = "Pickaxe", Description = nameof(ItemCategory.MeleeWeapons))]
            Pickaxe = 804000,

            [Annotation(Name = "Reinforced Club", Description = nameof(ItemCategory.MeleeWeapons))]
            ReinforcedClub = 809000,

            [Annotation(Name = "Blacksmith Hammer", Description = nameof(ItemCategory.MeleeWeapons))]
            BlacksmithHammer = 810000,

            [Annotation(Name = "Blacksmith Giant Hammer", Description = nameof(ItemCategory.MeleeWeapons))]
            BlacksmithGiantHammer = 811000,

            [Annotation(Name = "Hammer of Vamos", Description = nameof(ItemCategory.MeleeWeapons))]
            HammerofVamos = 812000,

            [Annotation(Name = "Great Club", Description = nameof(ItemCategory.MeleeWeapons))]
            GreatClub = 850000,

            [Annotation(Name = "Grant", Description = nameof(ItemCategory.MeleeWeapons))]
            Grant = 851000,

            [Annotation(Name = "Demon's Great Hammer", Description = nameof(ItemCategory.MeleeWeapons))]
            DemonsGreatHammer = 852000,

            [Annotation(Name = "Dragon Tooth", Description = nameof(ItemCategory.MeleeWeapons))]
            DragonTooth = 854000,

            [Annotation(Name = "Large Club", Description = nameof(ItemCategory.MeleeWeapons))]
            LargeClub = 855000,

            [Annotation(Name = "Smough's Hammer", Description = nameof(ItemCategory.MeleeWeapons))]
            SmoughsHammer = 856000,

            [Annotation(Name = "Caestus", Description = nameof(ItemCategory.MeleeWeapons))]
            Caestus = 901000,

            [Annotation(Name = "Claw", Description = nameof(ItemCategory.MeleeWeapons))]
            Claw = 902000,

            [Annotation(Name = "Dragon Bone Fist", Description = nameof(ItemCategory.MeleeWeapons))]
            DragonBoneFist = 903000,

            [Annotation(Name = "Dark Hand", Description = nameof(ItemCategory.MeleeWeapons))]
            DarkHand = 904000,

            [Annotation(Name = "Spear", Description = nameof(ItemCategory.MeleeWeapons))]
            Spear = 1000000,

            [Annotation(Name = "Winged Spear", Description = nameof(ItemCategory.MeleeWeapons))]
            WingedSpear = 1001000,

            [Annotation(Name = "Partizan", Description = nameof(ItemCategory.MeleeWeapons))]
            Partizan = 1002000,

            [Annotation(Name = "Demon's Spear", Description = nameof(ItemCategory.MeleeWeapons))]
            DemonsSpear = 1003000,

            [Annotation(Name = "Channeler's Trident", Description = nameof(ItemCategory.MeleeWeapons))]
            ChannelersTrident = 1004000,

            [Annotation(Name = "Silver Knight Spear", Description = nameof(ItemCategory.MeleeWeapons))]
            SilverKnightSpear = 1006000,

            [Annotation(Name = "Pike", Description = nameof(ItemCategory.MeleeWeapons))]
            Pike = 1050000,

            [Annotation(Name = "Dragonslayer Spear", Description = nameof(ItemCategory.MeleeWeapons))]
            DragonslayerSpear = 1051000,

            [Annotation(Name = "Moonlight Butterfly Horn", Description = nameof(ItemCategory.MeleeWeapons))]
            MoonlightButterflyHorn = 1052000,

            [Annotation(Name = "Halberd", Description = nameof(ItemCategory.MeleeWeapons))]
            Halberd = 1100000,

            [Annotation(Name = "Giant's Halberd", Description = nameof(ItemCategory.MeleeWeapons))]
            GiantsHalberd = 1101000,

            [Annotation(Name = "Titanite Catch Pole", Description = nameof(ItemCategory.MeleeWeapons))]
            TitaniteCatchPole = 1102000,

            [Annotation(Name = "Gargoyle's Halberd", Description = nameof(ItemCategory.MeleeWeapons))]
            GargoylesHalberd = 1103000,

            [Annotation(Name = "Black Knight Halberd", Description = nameof(ItemCategory.MeleeWeapons))]
            BlackKnightHalberd = 1105000,

            [Annotation(Name = "Lucerne", Description = nameof(ItemCategory.MeleeWeapons))]
            Lucerne = 1106000,

            [Annotation(Name = "Scythe", Description = nameof(ItemCategory.MeleeWeapons))]
            Scythe = 1107000,

            [Annotation(Name = "Great Scythe", Description = nameof(ItemCategory.MeleeWeapons))]
            GreatScythe = 1150000,

            [Annotation(Name = "Lifehunt Scythe", Description = nameof(ItemCategory.MeleeWeapons))]
            LifehuntScythe = 1151000,

            [Annotation(Name = "Whip", Description = nameof(ItemCategory.MeleeWeapons))]
            Whip = 1600000,

            [Annotation(Name = "Notched Whip", Description = nameof(ItemCategory.MeleeWeapons))]
            NotchedWhip = 1601000,

            [Annotation(Name = "Gold Tracer", Description = nameof(ItemCategory.MeleeWeapons))]
            GoldTracer = 9010000,

            [Annotation(Name = "Dark Silver Tracer", Description = nameof(ItemCategory.MeleeWeapons))]
            DarkSilverTracer = 9011000,

            [Annotation(Name = "Abyss Greatsword", Description = nameof(ItemCategory.MeleeWeapons))]
            AbyssGreatsword = 9012000,

            [Annotation(Name = "Stone Greataxe", Description = nameof(ItemCategory.MeleeWeapons))]
            StoneGreataxe = 9015000,

            [Annotation(Name = "Four-pronged Plow", Description = nameof(ItemCategory.MeleeWeapons))]
            FourprongedPlow = 9016000,

            [Annotation(Name = "Guardian Tail", Description = nameof(ItemCategory.MeleeWeapons))]
            GuardianTail = 9019000,

            [Annotation(Name = "Obsidian Greatsword", Description = nameof(ItemCategory.MeleeWeapons))]
            ObsidianGreatsword = 9020000,

            [Annotation(Name = "Short Bow", Description = nameof(ItemCategory.RangedWeapons))]
            ShortBow = 1200000,

            [Annotation(Name = "Longbow", Description = nameof(ItemCategory.RangedWeapons))]
            Longbow = 1201000,

            [Annotation(Name = "Black Bow of Pharis", Description = nameof(ItemCategory.RangedWeapons))]
            BlackBowofPharis = 1202000,

            [Annotation(Name = "Dragonslayer Greatbow", Description = nameof(ItemCategory.RangedWeapons))]
            DragonslayerGreatbow = 1203000,

            [Annotation(Name = "Composite Bow", Description = nameof(ItemCategory.RangedWeapons))]
            CompositeBow = 1204000,

            [Annotation(Name = "Darkmoon Bow", Description = nameof(ItemCategory.RangedWeapons))]
            DarkmoonBow = 1205000,

            [Annotation(Name = "Light Crossbow", Description = nameof(ItemCategory.RangedWeapons))]
            LightCrossbow = 1250000,

            [Annotation(Name = "Heavy Crossbow", Description = nameof(ItemCategory.RangedWeapons))]
            HeavyCrossbow = 1251000,

            [Annotation(Name = "Avelyn", Description = nameof(ItemCategory.RangedWeapons))]
            Avelyn = 1252000,

            [Annotation(Name = "Sniper Crossbow", Description = nameof(ItemCategory.RangedWeapons))]
            SniperCrossbow = 1253000,

            [Annotation(Name = "Gough's Greatbow", Description = nameof(ItemCategory.RangedWeapons))]
            GoughsGreatbow = 9021000,

            [Annotation(Name = "Standard Arrow", Description = nameof(ItemCategory.Ammo))]
            StandardArrow = 2000000,

            [Annotation(Name = "Large Arrow", Description = nameof(ItemCategory.Ammo))]
            LargeArrow = 2001000,

            [Annotation(Name = "Feather Arrow", Description = nameof(ItemCategory.Ammo))]
            FeatherArrow = 2002000,

            [Annotation(Name = "Fire Arrow", Description = nameof(ItemCategory.Ammo))]
            FireArrow = 2003000,

            [Annotation(Name = "Poison Arrow", Description = nameof(ItemCategory.Ammo))]
            PoisonArrow = 2004000,

            [Annotation(Name = "Moonlight Arrow", Description = nameof(ItemCategory.Ammo))]
            MoonlightArrow = 2005000,

            [Annotation(Name = "Wooden Arrow", Description = nameof(ItemCategory.Ammo))]
            WoodenArrow = 2006000,

            [Annotation(Name = "Dragonslayer Arrow", Description = nameof(ItemCategory.Ammo))]
            DragonslayerArrow = 2007000,

            [Annotation(Name = "Gough's Great Arrow", Description = nameof(ItemCategory.Ammo))]
            GoughsGreatArrow = 2008000,

            [Annotation(Name = "Standard Bolt", Description = nameof(ItemCategory.Ammo))]
            StandardBolt = 2100000,

            [Annotation(Name = "Heavy Bolt", Description = nameof(ItemCategory.Ammo))]
            HeavyBolt = 2101000,

            [Annotation(Name = "Sniper Bolt", Description = nameof(ItemCategory.Ammo))]
            SniperBolt = 2102000,

            [Annotation(Name = "Wood Bolt", Description = nameof(ItemCategory.Ammo))]
            WoodBolt = 2103000,

            [Annotation(Name = "Lightning Bolt", Description = nameof(ItemCategory.Ammo))]
            LightningBolt = 2104000,

            [Annotation(Name = "Havel's Ring", Description = nameof(ItemCategory.Rings))]
            HavelsRing = 100,

            [Annotation(Name = "Red Tearstone Ring", Description = nameof(ItemCategory.Rings))]
            RedTearstoneRing = 101,

            [Annotation(Name = "Darkmoon Blade Covenant Ring", Description = nameof(ItemCategory.Rings))]
            DarkmoonBladeCovenantRing = 102,

            [Annotation(Name = "Cat Covenant Ring", Description = nameof(ItemCategory.Rings))]
            CatCovenantRing = 103,

            [Annotation(Name = "Cloranthy Ring", Description = nameof(ItemCategory.Rings))]
            CloranthyRing = 104,

            [Annotation(Name = "Flame Stoneplate Ring", Description = nameof(ItemCategory.Rings))]
            FlameStoneplateRing = 105,

            [Annotation(Name = "Thunder Stoneplate Ring", Description = nameof(ItemCategory.Rings))]
            ThunderStoneplateRing = 106,

            [Annotation(Name = "Spell Stoneplate Ring", Description = nameof(ItemCategory.Rings))]
            SpellStoneplateRing = 107,

            [Annotation(Name = "Speckled Stoneplate Ring", Description = nameof(ItemCategory.Rings))]
            SpeckledStoneplateRing = 108,

            [Annotation(Name = "Bloodbite Ring", Description = nameof(ItemCategory.Rings))]
            BloodbiteRing = 109,

            [Annotation(Name = "Poisonbite Ring", Description = nameof(ItemCategory.Rings))]
            PoisonbiteRing = 110,

            [Annotation(Name = "Tiny Being's Ring", Description = nameof(ItemCategory.Rings))]
            TinyBeingsRing = 111,

            [Annotation(Name = "Cursebite Ring", Description = nameof(ItemCategory.Rings))]
            CursebiteRing = 113,

            [Annotation(Name = "White Seance Ring", Description = nameof(ItemCategory.Rings))]
            WhiteSeanceRing = 114,

            [Annotation(Name = "Bellowing Dragoncrest Ring", Description = nameof(ItemCategory.Rings))]
            BellowingDragoncrestRing = 115,

            [Annotation(Name = "Dusk Crown Ring", Description = nameof(ItemCategory.Rings))]
            DuskCrownRing = 116,

            [Annotation(Name = "Hornet Ring", Description = nameof(ItemCategory.Rings))]
            HornetRing = 117,

            [Annotation(Name = "Hawk Ring", Description = nameof(ItemCategory.Rings))]
            HawkRing = 119,

            [Annotation(Name = "Ring of Steel Protection", Description = nameof(ItemCategory.Rings))]
            RingofSteelProtection = 120,

            [Annotation(Name = "Covetous Gold Serpent Ring", Description = nameof(ItemCategory.Rings))]
            CovetousGoldSerpentRing = 121,

            [Annotation(Name = "Covetous Silver Serpent Ring", Description = nameof(ItemCategory.Rings))]
            CovetousSilverSerpentRing = 122,

            [Annotation(Name = "Slumbering Dragoncrest Ring", Description = nameof(ItemCategory.Rings))]
            SlumberingDragoncrestRing = 123,

            [Annotation(Name = "Ring of Fog", Description = nameof(ItemCategory.Rings))]
            RingofFog = 124,

            [Annotation(Name = "Rusted Iron Ring", Description = nameof(ItemCategory.Rings))]
            RustedIronRing = 125,

            [Annotation(Name = "Ring of Sacrifice", Description = nameof(ItemCategory.Rings))]
            RingofSacrifice = 126,

            [Annotation(Name = "Rare Ring of Sacrifice", Description = nameof(ItemCategory.Rings))]
            RareRingofSacrifice = 127,

            [Annotation(Name = "Dark Wood Grain Ring", Description = nameof(ItemCategory.Rings))]
            DarkWoodGrainRing = 128,

            [Annotation(Name = "Ring of the Sun Princess", Description = nameof(ItemCategory.Rings))]
            RingoftheSunPrincess = 130,

            [Annotation(Name = "Old Witch's Ring", Description = nameof(ItemCategory.Rings))]
            OldWitchsRing = 137,

            [Annotation(Name = "Covenant of Artorias", Description = nameof(ItemCategory.Rings))]
            CovenantofArtorias = 138,

            [Annotation(Name = "Orange Charred Ring", Description = nameof(ItemCategory.Rings))]
            OrangeCharredRing = 139,

            [Annotation(Name = "Lingering Dragoncrest Ring", Description = nameof(ItemCategory.Rings))]
            LingeringDragoncrestRing = 141,

            [Annotation(Name = "Ring of the Evil Eye", Description = nameof(ItemCategory.Rings))]
            RingoftheEvilEye = 142,

            [Annotation(Name = "Ring of Favor and Protection", Description = nameof(ItemCategory.Rings))]
            RingofFavorandProtection = 143,

            [Annotation(Name = "Leo Ring", Description = nameof(ItemCategory.Rings))]
            LeoRing = 144,

            [Annotation(Name = "East Wood Grain Ring", Description = nameof(ItemCategory.Rings))]
            EastWoodGrainRing = 145,

            [Annotation(Name = "Wolf Ring", Description = nameof(ItemCategory.Rings))]
            WolfRing = 146,

            [Annotation(Name = "Blue Tearstone Ring", Description = nameof(ItemCategory.Rings))]
            BlueTearstoneRing = 147,

            [Annotation(Name = "Ring of the Sun's Firstborn", Description = nameof(ItemCategory.Rings))]
            RingoftheSunsFirstborn = 148,

            [Annotation(Name = "Darkmoon Seance Ring", Description = nameof(ItemCategory.Rings))]
            DarkmoonSeanceRing = 149,

            [Annotation(Name = "Calamity Ring", Description = nameof(ItemCategory.Rings))]
            CalamityRing = 150,

            [Annotation(Name = "Skull Lantern", Description = nameof(ItemCategory.Shields))]
            SkullLantern = 1396000,

            [Annotation(Name = "East-West Shield", Description = nameof(ItemCategory.Shields))]
            EastWestShield = 1400000,

            [Annotation(Name = "Wooden Shield", Description = nameof(ItemCategory.Shields))]
            WoodenShield = 1401000,

            [Annotation(Name = "Large Leather Shield", Description = nameof(ItemCategory.Shields))]
            LargeLeatherShield = 1402000,

            [Annotation(Name = "Small Leather Shield", Description = nameof(ItemCategory.Shields))]
            SmallLeatherShield = 1403000,

            [Annotation(Name = "Target Shield", Description = nameof(ItemCategory.Shields))]
            TargetShield = 1404000,

            [Annotation(Name = "Buckler", Description = nameof(ItemCategory.Shields))]
            Buckler = 1405000,

            [Annotation(Name = "Cracked Round Shield", Description = nameof(ItemCategory.Shields))]
            CrackedRoundShield = 1406000,

            [Annotation(Name = "Leather Shield", Description = nameof(ItemCategory.Shields))]
            LeatherShield = 1408000,

            [Annotation(Name = "Plank Shield", Description = nameof(ItemCategory.Shields))]
            PlankShield = 1409000,

            [Annotation(Name = "Caduceus Round Shield", Description = nameof(ItemCategory.Shields))]
            CaduceusRoundShield = 1410000,

            [Annotation(Name = "Crystal Ring Shield", Description = nameof(ItemCategory.Shields))]
            CrystalRingShield = 1411000,

            [Annotation(Name = "Heater Shield", Description = nameof(ItemCategory.Shields))]
            HeaterShield = 1450000,

            [Annotation(Name = "Knight Shield", Description = nameof(ItemCategory.Shields))]
            KnightShield = 1451000,

            [Annotation(Name = "Tower Kite Shield", Description = nameof(ItemCategory.Shields))]
            TowerKiteShield = 1452000,

            [Annotation(Name = "Grass Crest Shield", Description = nameof(ItemCategory.Shields))]
            GrassCrestShield = 1453000,

            [Annotation(Name = "Hollow Soldier Shield", Description = nameof(ItemCategory.Shields))]
            HollowSoldierShield = 1454000,

            [Annotation(Name = "Balder Shield", Description = nameof(ItemCategory.Shields))]
            BalderShield = 1455000,

            [Annotation(Name = "Crest Shield", Description = nameof(ItemCategory.Shields))]
            CrestShield = 1456000,

            [Annotation(Name = "Dragon Crest Shield", Description = nameof(ItemCategory.Shields))]
            DragonCrestShield = 1457000,

            [Annotation(Name = "Warrior's Round Shield", Description = nameof(ItemCategory.Shields))]
            WarriorsRoundShield = 1460000,

            [Annotation(Name = "Iron Round Shield", Description = nameof(ItemCategory.Shields))]
            IronRoundShield = 1461000,

            [Annotation(Name = "Spider Shield", Description = nameof(ItemCategory.Shields))]
            SpiderShield = 1462000,

            [Annotation(Name = "Spiked Shield", Description = nameof(ItemCategory.Shields))]
            SpikedShield = 1470000,

            [Annotation(Name = "Crystal Shield", Description = nameof(ItemCategory.Shields))]
            CrystalShield = 1471000,

            [Annotation(Name = "Sunlight Shield", Description = nameof(ItemCategory.Shields))]
            SunlightShield = 1472000,

            [Annotation(Name = "Silver Knight Shield", Description = nameof(ItemCategory.Shields))]
            SilverKnightShield = 1473000,

            [Annotation(Name = "Black Knight Shield", Description = nameof(ItemCategory.Shields))]
            BlackKnightShield = 1474000,

            [Annotation(Name = "Pierce Shield", Description = nameof(ItemCategory.Shields))]
            PierceShield = 1475000,

            [Annotation(Name = "Red and White Round Shield", Description = nameof(ItemCategory.Shields))]
            RedandWhiteRoundShield = 1476000,

            [Annotation(Name = "Caduceus Kite Shield", Description = nameof(ItemCategory.Shields))]
            CaduceusKiteShield = 1477000,

            [Annotation(Name = "Gargoyle's Shield", Description = nameof(ItemCategory.Shields))]
            GargoylesShield = 1478000,

            [Annotation(Name = "Eagle Shield", Description = nameof(ItemCategory.Shields))]
            EagleShield = 1500000,

            [Annotation(Name = "Tower Shield", Description = nameof(ItemCategory.Shields))]
            TowerShield = 1501000,

            [Annotation(Name = "Giant Shield", Description = nameof(ItemCategory.Shields))]
            GiantShield = 1502000,

            [Annotation(Name = "Stone Greatshield", Description = nameof(ItemCategory.Shields))]
            StoneGreatshield = 1503000,

            [Annotation(Name = "Havel's Greatshield", Description = nameof(ItemCategory.Shields))]
            HavelsGreatshield = 1505000,

            [Annotation(Name = "Bonewheel Shield", Description = nameof(ItemCategory.Shields))]
            BonewheelShield = 1506000,

            [Annotation(Name = "Greatshield of Artorias", Description = nameof(ItemCategory.Shields))]
            GreatshieldofArtorias = 1507000,

            [Annotation(Name = "Effigy Shield", Description = nameof(ItemCategory.Shields))]
            EffigyShield = 9000000,

            [Annotation(Name = "Sanctus", Description = nameof(ItemCategory.Shields))]
            Sanctus = 9001000,

            [Annotation(Name = "Bloodshield", Description = nameof(ItemCategory.Shields))]
            Bloodshield = 9002000,

            [Annotation(Name = "Black Iron Greatshield", Description = nameof(ItemCategory.Shields))]
            BlackIronGreatshield = 9003000,

            [Annotation(Name = "Cleansing Greatshield", Description = nameof(ItemCategory.Shields))]
            CleansingGreatshield = 9014000,

            [Annotation(Name = "Sorcery: Soul Arrow", Description = nameof(ItemCategory.Spells))]
            SorcerySoulArrow = 3000,

            [Annotation(Name = "Sorcery: Great Soul Arrow", Description = nameof(ItemCategory.Spells))]
            SorceryGreatSoulArrow = 3010,

            [Annotation(Name = "Sorcery: Heavy Soul Arrow", Description = nameof(ItemCategory.Spells))]
            SorceryHeavySoulArrow = 3020,

            [Annotation(Name = "Sorcery: Great Heavy Soul Arrow", Description = nameof(ItemCategory.Spells))]
            SorceryGreatHeavySoulArrow = 3030,

            [Annotation(Name = "Sorcery: Homing Soulmass", Description = nameof(ItemCategory.Spells))]
            SorceryHomingSoulmass = 3040,

            [Annotation(Name = "Sorcery: Homing Crystal Soulmass", Description = nameof(ItemCategory.Spells))]
            SorceryHomingCrystalSoulmass = 3050,

            [Annotation(Name = "Sorcery: Soul Spear", Description = nameof(ItemCategory.Spells))]
            SorcerySoulSpear = 3060,

            [Annotation(Name = "Sorcery: Crystal Soul Spear", Description = nameof(ItemCategory.Spells))]
            SorceryCrystalSoulSpear = 3070,

            [Annotation(Name = "Sorcery: Magic Weapon", Description = nameof(ItemCategory.Spells))]
            SorceryMagicWeapon = 3100,

            [Annotation(Name = "Sorcery: Great Magic Weapon", Description = nameof(ItemCategory.Spells))]
            SorceryGreatMagicWeapon = 3110,

            [Annotation(Name = "Sorcery: Crystal Magic Weapon", Description = nameof(ItemCategory.Spells))]
            SorceryCrystalMagicWeapon = 3120,

            [Annotation(Name = "Sorcery: Magic Shield", Description = nameof(ItemCategory.Spells))]
            SorceryMagicShield = 3300,

            [Annotation(Name = "Sorcery: Strong Magic Shield", Description = nameof(ItemCategory.Spells))]
            SorceryStrongMagicShield = 3310,

            [Annotation(Name = "Sorcery: Hidden Weapon", Description = nameof(ItemCategory.Spells))]
            SorceryHiddenWeapon = 3400,

            [Annotation(Name = "Sorcery: Hidden Body", Description = nameof(ItemCategory.Spells))]
            SorceryHiddenBody = 3410,

            [Annotation(Name = "Sorcery: Cast Light", Description = nameof(ItemCategory.Spells))]
            SorceryCastLight = 3500,

            [Annotation(Name = "Sorcery: Hush", Description = nameof(ItemCategory.Spells))]
            SorceryHush = 3510,

            [Annotation(Name = "Sorcery: Aural Decoy", Description = nameof(ItemCategory.Spells))]
            SorceryAuralDecoy = 3520,

            [Annotation(Name = "Sorcery: Repair", Description = nameof(ItemCategory.Spells))]
            SorceryRepair = 3530,

            [Annotation(Name = "Sorcery: Fall Control", Description = nameof(ItemCategory.Spells))]
            SorceryFallControl = 3540,

            [Annotation(Name = "Sorcery: Chameleon", Description = nameof(ItemCategory.Spells))]
            SorceryChameleon = 3550,

            [Annotation(Name = "Sorcery: Resist Curse", Description = nameof(ItemCategory.Spells))]
            SorceryResistCurse = 3600,

            [Annotation(Name = "Sorcery: Remedy", Description = nameof(ItemCategory.Spells))]
            SorceryRemedy = 3610,

            [Annotation(Name = "Sorcery: White Dragon Breath", Description = nameof(ItemCategory.Spells))]
            SorceryWhiteDragonBreath = 3700,

            [Annotation(Name = "Sorcery: Dark Orb", Description = nameof(ItemCategory.Spells))]
            SorceryDarkOrb = 3710,

            [Annotation(Name = "Sorcery: Dark Bead", Description = nameof(ItemCategory.Spells))]
            SorceryDarkBead = 3720,

            [Annotation(Name = "Sorcery: Dark Fog", Description = nameof(ItemCategory.Spells))]
            SorceryDarkFog = 3730,

            [Annotation(Name = "Sorcery: Pursuers", Description = nameof(ItemCategory.Spells))]
            SorceryPursuers = 3740,

            [Annotation(Name = "Pyromancy: Fireball", Description = nameof(ItemCategory.Spells))]
            PyromancyFireball = 4000,

            [Annotation(Name = "Pyromancy: Fire Orb", Description = nameof(ItemCategory.Spells))]
            PyromancyFireOrb = 4010,

            [Annotation(Name = "Pyromancy: Great Fireball", Description = nameof(ItemCategory.Spells))]
            PyromancyGreatFireball = 4020,

            [Annotation(Name = "Pyromancy: Firestorm", Description = nameof(ItemCategory.Spells))]
            PyromancyFirestorm = 4030,

            [Annotation(Name = "Pyromancy: Fire Tempest", Description = nameof(ItemCategory.Spells))]
            PyromancyFireTempest = 4040,

            [Annotation(Name = "Pyromancy: Fire Surge", Description = nameof(ItemCategory.Spells))]
            PyromancyFireSurge = 4050,

            [Annotation(Name = "Pyromancy: Fire Whip", Description = nameof(ItemCategory.Spells))]
            PyromancyFireWhip = 4060,

            [Annotation(Name = "Pyromancy: Combustion", Description = nameof(ItemCategory.Spells))]
            PyromancyCombustion = 4100,

            [Annotation(Name = "Pyromancy: Great Combustion", Description = nameof(ItemCategory.Spells))]
            PyromancyGreatCombustion = 4110,

            [Annotation(Name = "Pyromancy: Poison Mist", Description = nameof(ItemCategory.Spells))]
            PyromancyPoisonMist = 4200,

            [Annotation(Name = "Pyromancy: Toxic Mist", Description = nameof(ItemCategory.Spells))]
            PyromancyToxicMist = 4210,

            [Annotation(Name = "Pyromancy: Acid Surge", Description = nameof(ItemCategory.Spells))]
            PyromancyAcidSurge = 4220,

            [Annotation(Name = "Pyromancy: Iron Flesh", Description = nameof(ItemCategory.Spells))]
            PyromancyIronFlesh = 4300,

            [Annotation(Name = "Pyromancy: Flash Sweat", Description = nameof(ItemCategory.Spells))]
            PyromancyFlashSweat = 4310,

            [Annotation(Name = "Pyromancy: Undead Rapport", Description = nameof(ItemCategory.Spells))]
            PyromancyUndeadRapport = 4360,

            [Annotation(Name = "Pyromancy: Power Within", Description = nameof(ItemCategory.Spells))]
            PyromancyPowerWithin = 4400,

            [Annotation(Name = "Pyromancy: Great Chaos Fireball", Description = nameof(ItemCategory.Spells))]
            PyromancyGreatChaosFireball = 4500,

            [Annotation(Name = "Pyromancy: Chaos Storm", Description = nameof(ItemCategory.Spells))]
            PyromancyChaosStorm = 4510,

            [Annotation(Name = "Pyromancy: Chaos Fire Whip", Description = nameof(ItemCategory.Spells))]
            PyromancyChaosFireWhip = 4520,

            [Annotation(Name = "Pyromancy: Black Flame", Description = nameof(ItemCategory.Spells))]
            PyromancyBlackFlame = 4530,

            [Annotation(Name = "Miracle: Heal", Description = nameof(ItemCategory.Spells))]
            MiracleHeal = 5000,

            [Annotation(Name = "Miracle: Great Heal", Description = nameof(ItemCategory.Spells))]
            MiracleGreatHeal = 5010,

            [Annotation(Name = "Miracle: Great Heal Excerpt", Description = nameof(ItemCategory.Spells))]
            MiracleGreatHealExcerpt = 5020,

            [Annotation(Name = "Miracle: Soothing Sunlight", Description = nameof(ItemCategory.Spells))]
            MiracleSoothingSunlight = 5030,

            [Annotation(Name = "Miracle: Replenishment", Description = nameof(ItemCategory.Spells))]
            MiracleReplenishment = 5040,

            [Annotation(Name = "Miracle: Bountiful Sunlight", Description = nameof(ItemCategory.Spells))]
            MiracleBountifulSunlight = 5050,

            [Annotation(Name = "Miracle: Gravelord Sword Dance", Description = nameof(ItemCategory.Spells))]
            MiracleGravelordSwordDance = 5100,

            [Annotation(Name = "Miracle: Gravelord Greatsword Dance", Description = nameof(ItemCategory.Spells))]
            MiracleGravelordGreatswordDance = 5110,

            [Annotation(Name = "Miracle: Homeward", Description = nameof(ItemCategory.Spells))]
            MiracleHomeward = 5210,

            [Annotation(Name = "Miracle: Force", Description = nameof(ItemCategory.Spells))]
            MiracleForce = 5300,

            [Annotation(Name = "Miracle: Wrath of the Gods", Description = nameof(ItemCategory.Spells))]
            MiracleWrathoftheGods = 5310,

            [Annotation(Name = "Miracle: Emit Force", Description = nameof(ItemCategory.Spells))]
            MiracleEmitForce = 5320,

            [Annotation(Name = "Miracle: Seek Guidance", Description = nameof(ItemCategory.Spells))]
            MiracleSeekGuidance = 5400,

            [Annotation(Name = "Miracle: Lightning Spear", Description = nameof(ItemCategory.Spells))]
            MiracleLightningSpear = 5500,

            [Annotation(Name = "Miracle: Great Lightning Spear", Description = nameof(ItemCategory.Spells))]
            MiracleGreatLightningSpear = 5510,

            [Annotation(Name = "Miracle: Sunlight Spear", Description = nameof(ItemCategory.Spells))]
            MiracleSunlightSpear = 5520,

            [Annotation(Name = "Miracle: Magic Barrier", Description = nameof(ItemCategory.Spells))]
            MiracleMagicBarrier = 5600,

            [Annotation(Name = "Miracle: Great Magic Barrier", Description = nameof(ItemCategory.Spells))]
            MiracleGreatMagicBarrier = 5610,

            [Annotation(Name = "Miracle: Karmic Justice", Description = nameof(ItemCategory.Spells))]
            MiracleKarmicJustice = 5700,

            [Annotation(Name = "Miracle: Tranquil Walk of Peace", Description = nameof(ItemCategory.Spells))]
            MiracleTranquilWalkofPeace = 5800,

            [Annotation(Name = "Miracle: Vow of Silence", Description = nameof(ItemCategory.Spells))]
            MiracleVowofSilence = 5810,

            [Annotation(Name = "Miracle: Sunlight Blade", Description = nameof(ItemCategory.Spells))]
            MiracleSunlightBlade = 5900,

            [Annotation(Name = "Miracle: Darkmoon Blade", Description = nameof(ItemCategory.Spells))]
            MiracleDarkmoonBlade = 5910,

            [Annotation(Name = "Sorcerer's Catalyst", Description = nameof(ItemCategory.SpellTools))]
            SorcerersCatalyst = 1300000,

            [Annotation(Name = "Beatrice's Catalyst", Description = nameof(ItemCategory.SpellTools))]
            BeatricesCatalyst = 1301000,

            [Annotation(Name = "Tin Banishment Catalyst", Description = nameof(ItemCategory.SpellTools))]
            TinBanishmentCatalyst = 1302000,

            [Annotation(Name = "Logan's Catalyst", Description = nameof(ItemCategory.SpellTools))]
            LogansCatalyst = 1303000,

            [Annotation(Name = "Tin Darkmoon Catalyst", Description = nameof(ItemCategory.SpellTools))]
            TinDarkmoonCatalyst = 1304000,

            [Annotation(Name = "Oolacile Ivory Catalyst", Description = nameof(ItemCategory.SpellTools))]
            OolacileIvoryCatalyst = 1305000,

            [Annotation(Name = "Tin Crystallization Catalyst", Description = nameof(ItemCategory.SpellTools))]
            TinCrystallizationCatalyst = 1306000,

            [Annotation(Name = "Demon's Catalyst", Description = nameof(ItemCategory.SpellTools))]
            DemonsCatalyst = 1307000,

            [Annotation(Name = "Izalith Catalyst", Description = nameof(ItemCategory.SpellTools))]
            IzalithCatalyst = 1308000,

            [Annotation(Name = "Pyromancy Flame", Description = nameof(ItemCategory.SpellTools))]
            PyromancyFlame = 1330000,

            [Annotation(Name = "Pyromancy Flame (Ascended)", Description = nameof(ItemCategory.SpellTools))]
            PyromancyFlameAscended = 1332000,

            [Annotation(Name = "Talisman", Description = nameof(ItemCategory.SpellTools))]
            Talisman = 1360000,

            [Annotation(Name = "Canvas Talisman", Description = nameof(ItemCategory.SpellTools))]
            CanvasTalisman = 1361000,

            [Annotation(Name = "Thorolund Talisman", Description = nameof(ItemCategory.SpellTools))]
            ThorolundTalisman = 1362000,

            [Annotation(Name = "Ivory Talisman", Description = nameof(ItemCategory.SpellTools))]
            IvoryTalisman = 1363000,

            [Annotation(Name = "Sunlight Talisman", Description = nameof(ItemCategory.SpellTools))]
            SunlightTalisman = 1365000,

            [Annotation(Name = "Darkmoon Talisman", Description = nameof(ItemCategory.SpellTools))]
            DarkmoonTalisman = 1366000,

            [Annotation(Name = "Velka's Talisman", Description = nameof(ItemCategory.SpellTools))]
            VelkasTalisman = 1367000,

            [Annotation(Name = "Manus Catalyst", Description = nameof(ItemCategory.SpellTools))]
            ManusCatalyst = 9017000,

            [Annotation(Name = "Oolacile Catalyst", Description = nameof(ItemCategory.SpellTools))]
            OolacileCatalyst = 9018000,

            [Annotation(Name = "Large Ember", Description = nameof(ItemCategory.UpgradeMaterials))]
            LargeEmber = 800,

            [Annotation(Name = "Very Large Ember", Description = nameof(ItemCategory.UpgradeMaterials))]
            VeryLargeEmber = 801,

            [Annotation(Name = "Crystal Ember", Description = nameof(ItemCategory.UpgradeMaterials))]
            CrystalEmber = 802,

            [Annotation(Name = "Large Magic Ember", Description = nameof(ItemCategory.UpgradeMaterials))]
            LargeMagicEmber = 806,

            [Annotation(Name = "Enchanted Ember", Description = nameof(ItemCategory.UpgradeMaterials))]
            EnchantedEmber = 807,

            [Annotation(Name = "Divine Ember", Description = nameof(ItemCategory.UpgradeMaterials))]
            DivineEmber = 808,

            [Annotation(Name = "Large Divine Ember", Description = nameof(ItemCategory.UpgradeMaterials))]
            LargeDivineEmber = 809,

            [Annotation(Name = "Dark Ember", Description = nameof(ItemCategory.UpgradeMaterials))]
            DarkEmber = 810,

            [Annotation(Name = "Large Flame Ember", Description = nameof(ItemCategory.UpgradeMaterials))]
            LargeFlameEmber = 812,

            [Annotation(Name = "Chaos Flame Ember", Description = nameof(ItemCategory.UpgradeMaterials))]
            ChaosFlameEmber = 813,

            [Annotation(Name = "Titanite Shard", Description = nameof(ItemCategory.UpgradeMaterials))]
            TitaniteShard = 1000,

            [Annotation(Name = "Large Titanite Shard", Description = nameof(ItemCategory.UpgradeMaterials))]
            LargeTitaniteShard = 1010,

            [Annotation(Name = "Green Titanite Shard", Description = nameof(ItemCategory.UpgradeMaterials))]
            GreenTitaniteShard = 1020,

            [Annotation(Name = "Titanite Chunk", Description = nameof(ItemCategory.UpgradeMaterials))]
            TitaniteChunk = 1030,

            [Annotation(Name = "Blue Titanite Chunk", Description = nameof(ItemCategory.UpgradeMaterials))]
            BlueTitaniteChunk = 1040,

            [Annotation(Name = "White Titanite Chunk", Description = nameof(ItemCategory.UpgradeMaterials))]
            WhiteTitaniteChunk = 1050,

            [Annotation(Name = "Red Titanite Chunk", Description = nameof(ItemCategory.UpgradeMaterials))]
            RedTitaniteChunk = 1060,

            [Annotation(Name = "Titanite Slab", Description = nameof(ItemCategory.UpgradeMaterials))]
            TitaniteSlab = 1070,

            [Annotation(Name = "Blue Titanite Slab", Description = nameof(ItemCategory.UpgradeMaterials))]
            BlueTitaniteSlab = 1080,

            [Annotation(Name = "White Titanite Slab", Description = nameof(ItemCategory.UpgradeMaterials))]
            WhiteTitaniteSlab = 1090,

            [Annotation(Name = "Red Titanite Slab", Description = nameof(ItemCategory.UpgradeMaterials))]
            RedTitaniteSlab = 1100,

            [Annotation(Name = "Dragon Scale", Description = nameof(ItemCategory.UpgradeMaterials))]
            DragonScale = 1110,

            [Annotation(Name = "Demon Titanite", Description = nameof(ItemCategory.UpgradeMaterials))]
            DemonTitanite = 1120,

            [Annotation(Name = "Twinkling Titanite", Description = nameof(ItemCategory.UpgradeMaterials))]
            TwinklingTitanite = 1130,

            [Annotation(Name = "White Sign Soapstone", Description = nameof(ItemCategory.UsableItems))]
            WhiteSignSoapstone = 100,

            [Annotation(Name = "Red Sign Soapstone", Description = nameof(ItemCategory.UsableItems))]
            RedSignSoapstone = 101,

            [Annotation(Name = "Red Eye Orb", Description = nameof(ItemCategory.UsableItems))]
            RedEyeOrb = 102,

            [Annotation(Name = "Black Separation Crystal", Description = nameof(ItemCategory.UsableItems))]
            BlackSeparationCrystal = 103,

            [Annotation(Name = "Orange Guidance Soapstone", Description = nameof(ItemCategory.UsableItems))]
            OrangeGuidanceSoapstone = 106,

            [Annotation(Name = "Book of the Guilty", Description = nameof(ItemCategory.UsableItems))]
            BookoftheGuilty = 108,

            [Annotation(Name = "Servant Roster", Description = nameof(ItemCategory.UsableItems))]
            ServantRoster = 112,

            [Annotation(Name = "Blue Eye Orb", Description = nameof(ItemCategory.UsableItems))]
            BlueEyeOrb = 113,

            [Annotation(Name = "Dragon Eye", Description = nameof(ItemCategory.UsableItems))]
            DragonEye = 114,

            [Annotation(Name = "Black Eye Orb", Description = nameof(ItemCategory.UsableItems))]
            BlackEyeOrb = 115,

            [Annotation(Name = "Darksign", Description = nameof(ItemCategory.UsableItems))]
            Darksign = 117,

            [Annotation(Name = "Purple Coward's Crystal", Description = nameof(ItemCategory.UsableItems))]
            PurpleCowardsCrystal = 118,

            [Annotation(Name = "Silver Pendant", Description = nameof(ItemCategory.UsableItems))]
            SilverPendant = 220,

            [Annotation(Name = "Binoculars", Description = nameof(ItemCategory.UsableItems))]
            Binoculars = 371,

            [Annotation(Name = "Dragon Head Stone", Description = nameof(ItemCategory.UsableItems))]
            DragonHeadStone = 377,

            [Annotation(Name = "Dragon Torso Stone", Description = nameof(ItemCategory.UsableItems))]
            DragonTorsoStone = 378,

            [Annotation(Name = "Dried Finger", Description = nameof(ItemCategory.UsableItems))]
            DriedFinger = 385,

            [Annotation(Name = "Hello Carving", Description = nameof(ItemCategory.UsableItems))]
            HelloCarving = 510,

            [Annotation(Name = "Thank you Carving", Description = nameof(ItemCategory.UsableItems))]
            ThankyouCarving = 511,

            [Annotation(Name = "Very good! Carving", Description = nameof(ItemCategory.UsableItems))]
            VerygoodCarving = 512,

            [Annotation(Name = "I'm sorry Carving", Description = nameof(ItemCategory.UsableItems))]
            ImsorryCarving = 513,

            [Annotation(Name = "Help me! Carving", Description = nameof(ItemCategory.UsableItems))]
            HelpmeCarving = 514,


    }
}
