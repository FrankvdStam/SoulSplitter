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
using System.Globalization;
using System.Linq;
using System.Xml;
using SoulMemory;
using SoulSplitter.UiOld.Generic;
using SoulSplitter.Utils;

namespace SoulSplitter.Migrations;

internal static class Migrator
{
    public static void Migrate(XmlNode settings)
    {
        var version = new Version(settings.GetChildNodeByName("MainViewModel").GetChildNodeByName("Version").InnerText);

        MigrateEr(version, settings);
        
    }

    /// <summary>
    /// Struct to hold the enum migration data
    /// </summary>
    /// <param name="checkVer">The version to check against</param>
    /// <param name="splitType">The type of the enums to be removed or renamed</param>
    /// <param name="entries">Entries to be removed or renamed. If value is null, the entry will be removed</param>
    private struct EnumMigrationEntries(string checkVer, string splitType, Dictionary<string, string?> entries)
    {
        public readonly Version CheckVer = Version.Parse(checkVer);
        public readonly string SplitType = splitType;
        public readonly Dictionary<string, string?> Entries = entries;
    }

    #region MigrateEr ============================================================================================================================================================

    private static readonly EnumMigrationEntries[] MigrateErEnumMigrations =
    [
        new("1.6.2", "Boss", new Dictionary<string, string?>
            {
                ["NightsCavalryAltusHighwayJunctionAltusPlateau"] = null,
            }
        ),
        new("1.6.2", "Grace", new Dictionary<string, string?>
            {
                ["UldPalaceRuins"] = "LakeFacingCliffs",
            }
        ),
        new("1.8.4", "ItemPickup", new Dictionary<string, string?>
            {
                ["CaelidWestAeoniaSwampGoldenRune5"] = "CaelidWestAeoniaSwampMeteoriteStaff",
                ["Unknown"] = null,
                ["UnknownNeutralizingBoluses"] = null,
                ["Unknown_"] = null,
                ["Unknown__"] = null,
                ["UnknownPerfumeBottle"] = null,
                ["UnknownGlowstone"] = null,
                ["RyaRyasNecklace"] = null,
                ["UnknownGlowstone_"] = null,
                ["UnknownGlowstone__"] = null,
                ["Seluvis"] = null,
                ["UnknownWhiteCipherRing"] = null,
                ["UnknownSmithingStone5"] = null,
                ["Unknown___"] = null,
                ["UnknownGlowstone___"] = null,
                ["UnknownMushroom"] = null,
                ["Unknown____"] = null,
                ["CorpseUnknownGlowstone"] = null,
                ["CorpseUnknownGlowstone_"] = null,
                ["CorpseUnknownGlowstone__"] = null,
                ["CorpseUnknownGoldenSeed"] = null,
                ["CorpseMerchantNomadicMerchantsBellBearing11"] = null,
                ["LiurniaOfTheLakesRannisRise"] = null,
                ["LiurniaOfTheLakesLaskyarRuinsGravitas"] = null,
                ["DragonsPitAncientDragonManDragonHuntersGreatKatana_"] = null,
            }
        ),
        new("1.8.4", "KnownFlag", new Dictionary<string, string?>
            {
                ["UnlocksMemorySlot0"] = null,
                ["UnlocksMemorySlot1"] = null,
                ["UnlocksMemorySlot2"] = null,
                ["UnlocksMemorySlot3"] = null,
                ["UnlocksMemorySlot4"] = null,
                ["UnlocksMemorySlot5"] = null,
                ["UnlocksMemorySlot6"] = null,
                ["UnlocksMemorySlot7"] = null,
                ["UnlocksTalismanSlot0"] = null,
                ["UnlocksTalismanSlot1"] = null,
                ["UnlocksTalismanSlot2"] = null,
            }
        ),
    ];

    private static void MigrateEr(Version version, XmlNode settings)
    {
        if (MigrateErEnumMigrations.All(entry => version > entry.CheckVer)) return;

        List<(XmlNode, XmlNode)> removePairs = [];
        var splits = settings.GetChildNodeByName("MainViewModel").GetChildNodeByName("EldenRingViewModel").GetChildNodeByName("Splits");
        splits.ForEachChildNodeByName("HierarchicalTimingTypeViewModel", hierarchicalTimingTypeViewModel =>
        {
            hierarchicalTimingTypeViewModel.GetChildNodeByName("Children").ForEachChildNodeByName("HierarchicalSplitTypeViewModel", hierarchicalSplitTypeViewModel =>
            {
                var splitType = hierarchicalSplitTypeViewModel.GetChildNodeByName("EldenRingSplitType").InnerText;
                foreach (var enumMigration in MigrateErEnumMigrations)
                {
                    if (version > enumMigration.CheckVer) continue;
                    if (splitType != enumMigration.SplitType) continue;

                    var children = hierarchicalSplitTypeViewModel.GetChildNodeByName("Children");
                    children.ForEachChildNodeByName("HierarchicalSplitViewModel", hierarchicalSplitViewModel =>
                    {
                        var split = hierarchicalSplitViewModel.GetChildNodeByName("Split");
                        if (!enumMigration.Entries.TryGetValue(split.InnerText, out var entry)) return;

                        if (entry == null)
                        {
                            removePairs.Add((children, hierarchicalSplitViewModel));
                        }
                        else
                        {
                            split.InnerText = entry;
                        }
                    });
                }
            });
        });
        foreach (var pair in removePairs)
        {
            pair.Item1.RemoveChild(pair.Item2);
            
            if (pair.Item1.ChildNodes.Count != 0) continue;
            // Remove empty list from parents
            var parentHierarchicalSplitTypeViewModel = pair.Item1.ParentNode!;
            var parentChildren = parentHierarchicalSplitTypeViewModel.ParentNode!;
            parentChildren.RemoveChild(parentHierarchicalSplitTypeViewModel);

            if (parentChildren.ChildNodes.Count > 0) continue;
            // Further remove empty list from top level
            var parentHierarchicalTimingTypeViewModel = parentChildren.ParentNode!;
            var parentSplits = parentHierarchicalTimingTypeViewModel.ParentNode!;
            parentSplits.RemoveChild(parentHierarchicalTimingTypeViewModel);
        }
        removePairs.Clear();
    }

    #endregion

}
