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

using System.Xml.Serialization;

namespace SoulMemory.DarkSouls1
{
    [XmlType(Namespace = "SoulMemory.DarkSouls1")]
    public enum PresetFlag : uint
    {

    [AnnotationAttribute(Name = "2 | Dead, Gaping Dragon")]
    Dead_Gaping_Dragon = 2,

    [AnnotationAttribute(Name = "00000002 | Gaping Dragon")]
    Gaping_Dragon = 00000002,

    [AnnotationAttribute(Name = "3 | Dead, Bell Gargoyles")]
    Dead_Bell_Gargoyles = 3,

    [AnnotationAttribute(Name = "00000003 | Bell Gargoyles")]
    Bell_Gargoyles = 00000003,

    [AnnotationAttribute(Name = "4 | Dead, Priscilla")]
    Dead_Priscilla = 4,

    [AnnotationAttribute(Name = "00000004 | Crossbreed Priscilla")]
    Crossbreed_Priscilla = 00000004,

    [AnnotationAttribute(Name = "5 | Dead, Sif")]
    Dead_Sif = 5,

    [AnnotationAttribute(Name = "00000005 | Sif, the Great Gray Wolf")]
    Sif_the_Great_Gray_Wolf = 00000005,

    [AnnotationAttribute(Name = "6 | Dead, Pinwheel")]
    Dead_Pinwheel = 6,

    [AnnotationAttribute(Name = "00000006 | Pinwheel")]
    Pinwheel = 00000006,

    [AnnotationAttribute(Name = "7 | Dead, Nito")]
    Dead_Nito = 7,

    [AnnotationAttribute(Name = "00000007 | Gravelord Nito")]
    Gravelord_Nito = 00000007,

    [AnnotationAttribute(Name = "9 | Dead, Chaos Witch Quelaag")]
    Dead_Chaos_Witch_Quelaag = 9,

    [AnnotationAttribute(Name = "00000009 | Chaos Witch Quelaag")]
    Chaos_Witch_Quelaag = 00000009,

    [AnnotationAttribute(Name = "10 | Dead, Bed of Chaos")]
    Dead_Bed_of_Chaos = 10,

    [AnnotationAttribute(Name = "00000010 | Bed of Chaos")]
    Bed_of_Chaos = 00000010,

    [AnnotationAttribute(Name = "11 | Dead, Iron Golem")]
    Dead_Iron_Golem = 11,

    [AnnotationAttribute(Name = "00000011 | Iron Golem")]
    Iron_Golem = 00000011,

    [AnnotationAttribute(Name = "12 | Dead, Ornstein & Smough")]
    Dead_Ornstein__Smough = 12,

    [AnnotationAttribute(Name = "00000012 | Dragonslayer Ornstein & Executioner Smough")]
    Dragonslayer_Ornstein__Executioner_Smough = 00000012,

    [AnnotationAttribute(Name = "13 | Dead, 4 Kings")]
    Dead_4_Kings = 13,

    [AnnotationAttribute(Name = "00000013 | Four Kings")]
    Four_Kings = 00000013,

    [AnnotationAttribute(Name = "14 | Dead, Seath")]
    Dead_Seath = 14,

    [AnnotationAttribute(Name = "00000014 | Seath, the Scaleless")]
    Seath_the_Scaleless = 00000014,

    [AnnotationAttribute(Name = "15 | Dead, Gwyn")]
    Dead_Gwyn = 15,

    [AnnotationAttribute(Name = "00000015 | Gwyn, Lord of Cinder")]
    Gwyn_Lord_of_Cinder = 00000015,

    [AnnotationAttribute(Name = "16 | Dead, Asylum Demon")]
    Dead_Asylum_Demon = 16,

    [AnnotationAttribute(Name = "00000016 | Asylum Demon")]
    Asylum_Demon = 00000016,

    [AnnotationAttribute(Name = "120 | Unknown0")]
    Unknown0 = 120,

    [AnnotationAttribute(Name = "121 | Changed on defeating Artorias and Kalameet")]
    Changed_on_defeating_Artorias_and_Kalameet = 121,

    [AnnotationAttribute(Name = "151 | Anor Londo, Darkmoon Knightess bonfire inactive")]
    Anor_Londo_Darkmoon_Knightess_bonfire_inactive = 151,

    [AnnotationAttribute(Name = "250 | Obtained, Weapon Smithbox")]
    Obtained_Weapon_Smithbox = 250,

    [AnnotationAttribute(Name = "251 | Obtained, Armor Smithbox")]
    Obtained_Armor_Smithbox = 251,

    [AnnotationAttribute(Name = "252 | Obtained, Repairbox")]
    Obtained_Repairbox = 252,

    [AnnotationAttribute(Name = "258 | Obtained, Bottomless Box")]
    Obtained_Bottomless_Box = 258,

    [AnnotationAttribute(Name = "350 | Until 363 removes Ember from inventory if handed in")]
    Until_363_removes_Ember_from_inventory_if_handed_in = 350,

    [AnnotationAttribute(Name = "405 | Set on Seath defeated")]
    Set_on_Seath_defeated = 405,

    [AnnotationAttribute(Name = "600 | 4 bits used to count boss kills for Rhea (05.01.2022)")]
    A_bits_used_to_count_boss_kills_for_Rhea_05012022 = 600,

    [AnnotationAttribute(Name = "703 | Seemingly used to halt execution of a function. Not set anywhere")]
    Seemingly_used_to_halt_execution_of_a_function_Not_set_anywhere = 703,

    [AnnotationAttribute(Name = "706 | Used to prevent warping from Painted World or the Duke's cell when set to off (added 09.03.2020)")]
    Used_to_prevent_warping_from_Painted_World_or_the_Dukes_cell_when_set_to_off_added_09032020 = 706,

    [AnnotationAttribute(Name = "710 | Displays 'By the power of the Lordvessel' message")]
    Displays_By_the_power_of_the_Lordvessel_message = 710,

    [AnnotationAttribute(Name = "716 | Obtained, Estus Flask")]
    Obtained_Estus_Flask = 716,

    [AnnotationAttribute(Name = "719 | Unknown, Obtained First Spell?")]
    Unknown_Obtained_First_Spell = 719,

    [AnnotationAttribute(Name = "735 | For gravelording")]
    For_gravelording = 735,

    [AnnotationAttribute(Name = "743 | Touched Gwyndolin foggate")]
    Touched_Gwyndolin_foggate = 743,

    [AnnotationAttribute(Name = "744 | Triggered PvE Sin, Able to Pay Absolution")]
    Triggered_PvE_Sin_Able_to_Pay_Absolution = 744,

    [AnnotationAttribute(Name = "751 | Player cursed (12.2.21)")]
    Player_cursed_12221 = 751,

    [AnnotationAttribute(Name = "753 | Egg head (12.2.21)")]
    Egg_head_12221 = 753,

    [AnnotationAttribute(Name = "755 | Set by Oswald ESD on Absolution request (12.2.21)")]
    Set_by_Oswald_ESD_on_Absolution_request_12221 = 755,

    [AnnotationAttribute(Name = "757 | Display \"You are cursed\" message after crystallization + reload (12.2.21)")]
    Display_You_are_cursed_message_after_crystallization__reload_12221 = 757,

    [AnnotationAttribute(Name = "758 | Display \"Ring of Sacrifice shattered\" after dying with it active (12.2.21)")]
    Display_Ring_of_Sacrifice_shattered_after_dying_with_it_active_12221 = 758,

    [AnnotationAttribute(Name = "759 | Display \"Rare Ring of Sacrifice shattered\" after dying with it active (12.2.21)")]
    Display_Rare_Ring_of_Sacrifice_shattered_after_dying_with_it_active_12221 = 759,

    [AnnotationAttribute(Name = "780 | Obtained, Titanite Shard")]
    Obtained_Titanite_Shard = 780,

    [AnnotationAttribute(Name = "781 | Obtained, Large Titanite Shard")]
    Obtained_Large_Titanite_Shard = 781,

    [AnnotationAttribute(Name = "782 | Obtained, Green Titanite Shard")]
    Obtained_Green_Titanite_Shard = 782,

    [AnnotationAttribute(Name = "783 | Obtained, Titanite Chunk")]
    Obtained_Titanite_Chunk = 783,

    [AnnotationAttribute(Name = "784 | Obtained, Blue Titanite Chunk")]
    Obtained_Blue_Titanite_Chunk = 784,

    [AnnotationAttribute(Name = "785 | Obtained, White Titanite Chunk")]
    Obtained_White_Titanite_Chunk = 785,

    [AnnotationAttribute(Name = "786 | Obtained, Red Titanite Chunk")]
    Obtained_Red_Titanite_Chunk = 786,

    [AnnotationAttribute(Name = "787 | Obtained, Titanite Slab")]
    Obtained_Titanite_Slab = 787,

    [AnnotationAttribute(Name = "788 | Obtained, Blue Titanite Slab")]
    Obtained_Blue_Titanite_Slab = 788,

    [AnnotationAttribute(Name = "789 | Obtained, White Titanite Slab")]
    Obtained_White_Titanite_Slab = 789,

    [AnnotationAttribute(Name = "790 | Obtained, Red Titanite Slab")]
    Obtained_Red_Titanite_Slab = 790,

    [AnnotationAttribute(Name = "791 | Obtained, Dragon Scale")]
    Obtained_Dragon_Scale = 791,

    [AnnotationAttribute(Name = "792 | Obtained, Demon Titanite")]
    Obtained_Demon_Titanite = 792,

    [AnnotationAttribute(Name = "793 | Obtained, Twinkling Titanite")]
    Obtained_Twinkling_Titanite = 793,

    [AnnotationAttribute(Name = "800 | Dead, Sunlight Maggot Chaos Firebug")]
    Dead_Sunlight_Maggot_Chaos_Firebug = 800,

    [AnnotationAttribute(Name = "812 | Obtained, Firekeeper Soul (Blighttown)")]
    Obtained_Firekeeper_Soul_Blighttown = 812,

    [AnnotationAttribute(Name = "813 | Obtained, Firekeeper Soul (Undead Parish)")]
    Obtained_Firekeeper_Soul_Undead_Parish = 813,

    [AnnotationAttribute(Name = "819 | Make sure repairbox can only be bought once")]
    Make_sure_repairbox_can_only_be_bought_once = 819,

    [AnnotationAttribute(Name = "850 | Covenant, None")]
    Covenant_None = 850,

    [AnnotationAttribute(Name = "851 | Covenant, Way of White")]
    Covenant_Way_of_White = 851,

    [AnnotationAttribute(Name = "852 | Princess Guard")]
    Princess_Guard = 852,

    [AnnotationAttribute(Name = "853 | Covenant, Warrior of Sunlight")]
    Covenant_Warrior_of_Sunlight = 853,

    [AnnotationAttribute(Name = "854 | Covenant, Darkwraith")]
    Covenant_Darkwraith = 854,

    [AnnotationAttribute(Name = "855 | Covenant, Path of the Dragon")]
    Covenant_Path_of_the_Dragon = 855,

    [AnnotationAttribute(Name = "856 | Covenant, Gravelord Servant")]
    Covenant_Gravelord_Servant = 856,

    [AnnotationAttribute(Name = "857 | Covenant, Forest Hunter")]
    Covenant_Forest_Hunter = 857,

    [AnnotationAttribute(Name = "858 | Covenant, Darkmoon")]
    Covenant_Darkmoon = 858,

    [AnnotationAttribute(Name = "859 | Covenant, Chaos Servant")]
    Covenant_Chaos_Servant = 859,

    [AnnotationAttribute(Name = "976 | ? on Sif killed")]
    A_on_Sif_killed = 976,

    [AnnotationAttribute(Name = "979 | Twin Humanities received from Quelaag?")]
    Twin_Humanities_received_from_Quelaag = 979,

    [AnnotationAttribute(Name = "993 | Changed on Guardian killed")]
    Changed_on_Guardian_killed = 993,

    [AnnotationAttribute(Name = "994 | Changed on killing Artorias")]
    Changed_on_killing_Artorias = 994,

    [AnnotationAttribute(Name = "996 | Changed on defeating Kalameet")]
    Changed_on_defeating_Kalameet = 996,

    [AnnotationAttribute(Name = "1000 | Solaire, At First Position")]
    Solaire_At_First_Position = 1000,

    [AnnotationAttribute(Name = "1001 | Solaire, First Encounter Completed")]
    Solaire_First_Encounter_Completed = 1001,

    [AnnotationAttribute(Name = "1002 | Solaire, Hostile in Izalith")]
    Solaire_Hostile_in_Izalith = 1002,

    [AnnotationAttribute(Name = "1003 | Solaire, Rescued in Izalith")]
    Solaire_Rescued_in_Izalith = 1003,

    [AnnotationAttribute(Name = "1004 | Solaire, Hostile")]
    Solaire_Hostile = 1004,

    [AnnotationAttribute(Name = "1005 | Solaire, Dead")]
    Solaire_Dead = 1005,

    [AnnotationAttribute(Name = "1007 | Solaire, At Altar of Sunlight")]
    Solaire_At_Altar_of_Sunlight = 1007,

    [AnnotationAttribute(Name = "1008 | Solaire, In Anor Londo")]
    Solaire_In_Anor_Londo = 1008,

    [AnnotationAttribute(Name = "1009 | Solaire, After Centipede Demon")]
    Solaire_After_Centipede_Demon = 1009,

    [AnnotationAttribute(Name = "1011 | Solaire, Dead in Izalith")]
    Solaire_Dead_in_Izalith = 1011,

    [AnnotationAttribute(Name = "1012 | Solaire, Summoneable in Kiln (added: 05.06.2021)")]
    Solaire_Summoneable_in_Kiln_added_05062021 = 1012,

    [AnnotationAttribute(Name = "1031 | Darkmoon Knightess, At Starting Position?")]
    Darkmoon_Knightess_At_Starting_Position = 1031,

    [AnnotationAttribute(Name = "1033 | Darkmoon Knightess, Hostile")]
    Darkmoon_Knightess_Hostile = 1033,

    [AnnotationAttribute(Name = "1034 | Darkmoon Knightess, Dead")]
    Darkmoon_Knightess_Dead = 1034,

    [AnnotationAttribute(Name = "1036 | Unknown1")]
    Unknown1 = 1036,

    [AnnotationAttribute(Name = "1061 | Oscar, Hollow")]
    Oscar_Hollow = 1061,

    [AnnotationAttribute(Name = "1062 | Oscar, Dead (Hollow)")]
    Oscar_Dead_Hollow = 1062,

    [AnnotationAttribute(Name = "1073 | Oscar, Dead")]
    Oscar_Dead = 1073,

    [AnnotationAttribute(Name = "1091 | Big Hat Logan, Rescued")]
    Big_Hat_Logan_Rescued = 1091,

    [AnnotationAttribute(Name = "1092 | Big Hat Logan, Spawns at Firelink")]
    Big_Hat_Logan_Spawns_at_Firelink = 1092,

    [AnnotationAttribute(Name = "1093 | Big Hat Logan, Leaves Firelink For Duke's Prison")]
    Big_Hat_Logan_Leaves_Firelink_For_Dukes_Prison = 1093,

    [AnnotationAttribute(Name = "1094 | Big Hat Logan, Rescued in Duke's")]
    Big_Hat_Logan_Rescued_in_Dukes = 1094,

    [AnnotationAttribute(Name = "1096 | Big Hat Logan, Hostile")]
    Big_Hat_Logan_Hostile = 1096,

    [AnnotationAttribute(Name = "1097 | Big Hat Logan, Dead")]
    Big_Hat_Logan_Dead = 1097,

    [AnnotationAttribute(Name = "1111 | Griggs, Rescue Completed")]
    Griggs_Rescue_Completed = 1111,

    [AnnotationAttribute(Name = "1112 | Griggs, Initial Spawn at Firelink")]
    Griggs_Initial_Spawn_at_Firelink = 1112,

    [AnnotationAttribute(Name = "1113 | Griggs, At Firelink After Logan Leaves (Sells More)")]
    Griggs_At_Firelink_After_Logan_Leaves_Sells_More = 1113,

    [AnnotationAttribute(Name = "1114 | Griggs, Hostile")]
    Griggs_Hostile = 1114,

    [AnnotationAttribute(Name = "1115 | Griggs, Dead")]
    Griggs_Dead = 1115,

    [AnnotationAttribute(Name = "1117 | Griggs, Hollow At Sen's Fortress")]
    Griggs_Hollow_At_Sens_Fortress = 1117,

    [AnnotationAttribute(Name = "1121 | Dusk Golden Golem dead")]
    Dusk_Golden_Golem_dead = 1121,

    [AnnotationAttribute(Name = "1122 | Makes Broken Pendant drop? 2")]
    Makes_Broken_Pendant_drop_2 = 1122,

    [AnnotationAttribute(Name = "1123 | Dusk finished summoning animation")]
    Dusk_finished_summoning_animation = 1123,

    [AnnotationAttribute(Name = "1125 | Dusk, Dead")]
    Dusk_Dead = 1125,

    [AnnotationAttribute(Name = "1126 | Makes Broken Pendant drop?")]
    Makes_Broken_Pendant_drop = 1126,

    [AnnotationAttribute(Name = "1129 | Dusk rescued from Manus")]
    Dusk_rescued_from_Manus = 1129,

    [AnnotationAttribute(Name = "1140 | Anastacia, Initial State")]
    Anastacia_Initial_State = 1140,

    [AnnotationAttribute(Name = "1141 | Anastacia, Dead")]
    Anastacia_Dead = 1141,

    [AnnotationAttribute(Name = "1142 | Anastacia, Revived")]
    Anastacia_Revived = 1142,

    [AnnotationAttribute(Name = "1146 | Anastacia, Dead But Ready to Revive")]
    Anastacia_Dead_But_Ready_to_Revive = 1146,

    [AnnotationAttribute(Name = "1171 | Reah, At Firelink")]
    Reah_At_Firelink = 1171,

    [AnnotationAttribute(Name = "1173 | Reah, In Tomb of the Giants")]
    Reah_In_Tomb_of_the_Giants = 1173,

    [AnnotationAttribute(Name = "1174 | Reah, Rescued in Tomb of the Giants")]
    Reah_Rescued_in_Tomb_of_the_Giants = 1174,

    [AnnotationAttribute(Name = "1175 | Reah, In Undead Parish")]
    Reah_In_Undead_Parish = 1175,

    [AnnotationAttribute(Name = "1176 | Reah, Hostile")]
    Reah_Hostile = 1176,

    [AnnotationAttribute(Name = "1177 | Reah, Dead")]
    Reah_Dead = 1177,

    [AnnotationAttribute(Name = "1181 | Reah, ? Hollow In Duke's Archives?")]
    Reah__Hollow_In_Dukes_Archives = 1181,

    [AnnotationAttribute(Name = "1192 | Petrus, Abandons Party")]
    Petrus_Abandons_Party = 1192,

    [AnnotationAttribute(Name = "1193 | Petrus, Returned to Firelink")]
    Petrus_Returned_to_Firelink = 1193,

    [AnnotationAttribute(Name = "1194 | Petrus, After Paid Lautrec for Tip")]
    Petrus_After_Paid_Lautrec_for_Tip = 1194,

    [AnnotationAttribute(Name = "1197 | Petrus, Hostile")]
    Petrus_Hostile = 1197,

    [AnnotationAttribute(Name = "1198 | Petrus, Dead")]
    Petrus_Dead = 1198,

    [AnnotationAttribute(Name = "1211 | Vince, At Firelink")]
    Vince_At_Firelink = 1211,

    [AnnotationAttribute(Name = "1213 | Vince, Hostile")]
    Vince_Hostile = 1213,

    [AnnotationAttribute(Name = "1214 | Vince, Dead")]
    Vince_Dead = 1214,

    [AnnotationAttribute(Name = "1216 | Vince, In Tomb of the Giants")]
    Vince_In_Tomb_of_the_Giants = 1216,

    [AnnotationAttribute(Name = "1221 | Nico, At Firelink")]
    Nico_At_Firelink = 1221,

    [AnnotationAttribute(Name = "1223 | Nico, Hostile")]
    Nico_Hostile = 1223,

    [AnnotationAttribute(Name = "1224 | Nico, Dead")]
    Nico_Dead = 1224,

    [AnnotationAttribute(Name = "1226 | Nico, In Tomb of the Giants")]
    Nico_In_Tomb_of_the_Giants = 1226,

    [AnnotationAttribute(Name = "1241 | Gwyndolin, Disapproves")]
    Gwyndolin_Disapproves = 1241,

    [AnnotationAttribute(Name = "1251 | Laurentius, Rescue Completed")]
    Laurentius_Rescue_Completed = 1251,

    [AnnotationAttribute(Name = "1252 | Laurentius, In Firelink Shrine")]
    Laurentius_In_Firelink_Shrine = 1252,

    [AnnotationAttribute(Name = "1253 | Laurentius, Hostile")]
    Laurentius_Hostile = 1253,

    [AnnotationAttribute(Name = "1254 | Laurentius, Dead")]
    Laurentius_Dead = 1254,

    [AnnotationAttribute(Name = "1256 | Laurentius, Informed of Quelana")]
    Laurentius_Informed_of_Quelana = 1256,

    [AnnotationAttribute(Name = "1257 | Laurentius, Hollow In Blighttown")]
    Laurentius_Hollow_In_Blighttown = 1257,

    [AnnotationAttribute(Name = "1272 | Fair Lady, Dead")]
    Fair_Lady_Dead = 1272,

    [AnnotationAttribute(Name = "1281 | Eingyi, Steps Aside")]
    Eingyi_Steps_Aside = 1281,

    [AnnotationAttribute(Name = "1283 | Eingyi, Hostile")]
    Eingyi_Hostile = 1283,

    [AnnotationAttribute(Name = "1284 | Eingyi, Dead")]
    Eingyi_Dead = 1284,

    [AnnotationAttribute(Name = "1286 | Eingyi, Gained His Trust")]
    Eingyi_Gained_His_Trust = 1286,

    [AnnotationAttribute(Name = "1294 | Quelana, Hostile")]
    Quelana_Hostile = 1294,

    [AnnotationAttribute(Name = "1295 | Quelana, Dead")]
    Quelana_Dead = 1295,

    [AnnotationAttribute(Name = "1311 | Ingward, Unknown. Triggered placing Lordvessel?")]
    Ingward_Unknown_Triggered_placing_Lordvessel = 1311,

    [AnnotationAttribute(Name = "1312 | Ingward, After Draining New Londo")]
    Ingward_After_Draining_New_Londo = 1312,

    [AnnotationAttribute(Name = "1313 | Ingward, In Firelink Shrine")]
    Ingward_In_Firelink_Shrine = 1313,

    [AnnotationAttribute(Name = "1314 | Ingward, Hostile")]
    Ingward_Hostile = 1314,

    [AnnotationAttribute(Name = "1315 | Ingward, Dead")]
    Ingward_Dead = 1315,

    [AnnotationAttribute(Name = "1321 | Andre, Hostile")]
    Andre_Hostile = 1321,

    [AnnotationAttribute(Name = "1322 | Andre, Dead")]
    Andre_Dead = 1322,

    [AnnotationAttribute(Name = "1341 | Vamos, Hostile")]
    Vamos_Hostile = 1341,

    [AnnotationAttribute(Name = "1342 | Vamos, Dead")]
    Vamos_Dead = 1342,

    [AnnotationAttribute(Name = "1361 | Giant Blacksmith, Hostile")]
    Giant_Blacksmith_Hostile = 1361,

    [AnnotationAttribute(Name = "1362 | Giant Blacksmith, Dead")]
    Giant_Blacksmith_Dead = 1362,

    [AnnotationAttribute(Name = "1381 | Rickert, Hostile")]
    Rickert_Hostile = 1381,

    [AnnotationAttribute(Name = "1382 | Rickert, Dead")]
    Rickert_Dead = 1382,

    [AnnotationAttribute(Name = "1400 | Undead Merchant, Present")]
    Undead_Merchant_Present = 1400,

    [AnnotationAttribute(Name = "1401 | Undead Merchant, Hostile")]
    Undead_Merchant_Hostile = 1401,

    [AnnotationAttribute(Name = "1402 | Undead Merchant, Dead")]
    Undead_Merchant_Dead = 1402,

    [AnnotationAttribute(Name = "1410 | Female Undead Merchant, Present")]
    Female_Undead_Merchant_Present = 1410,

    [AnnotationAttribute(Name = "1411 | Female Undead Merchant, Hostile")]
    Female_Undead_Merchant_Hostile = 1411,

    [AnnotationAttribute(Name = "1412 | Female Undead Merchant, Dead")]
    Female_Undead_Merchant_Dead = 1412,

    [AnnotationAttribute(Name = "1420 | Crestfallen Merchant, Starting Location")]
    Crestfallen_Merchant_Starting_Location = 1420,

    [AnnotationAttribute(Name = "1421 | Crestfallen Merchant, Hostile")]
    Crestfallen_Merchant_Hostile = 1421,

    [AnnotationAttribute(Name = "1422 | Crestfallen Merchant, Dead")]
    Crestfallen_Merchant_Dead = 1422,

    [AnnotationAttribute(Name = "1430 | Domhnall, Starting Location")]
    Domhnall_Starting_Location = 1430,

    [AnnotationAttribute(Name = "1431 | Domhnall, Moved to Firelink")]
    Domhnall_Moved_to_Firelink = 1431,

    [AnnotationAttribute(Name = "1434 | Domhnall, Hostile")]
    Domhnall_Hostile = 1434,

    [AnnotationAttribute(Name = "1435 | Domhnall, Dead")]
    Domhnall_Dead = 1435,

    [AnnotationAttribute(Name = "1461 | Crestfallen Warrior, Hostile")]
    Crestfallen_Warrior_Hostile = 1461,

    [AnnotationAttribute(Name = "1462 | Crestfallen Warrior, Dead")]
    Crestfallen_Warrior_Dead = 1462,

    [AnnotationAttribute(Name = "1464 | Crestfallen Warrior, Hollow in New Londo")]
    Crestfallen_Warrior_Hollow_in_New_Londo = 1464,

    [AnnotationAttribute(Name = "1490 | Siegmeyer, Starting Location")]
    Siegmeyer_Starting_Location = 1490,

    [AnnotationAttribute(Name = "1491 | Siegmeyer, Second Location (No Need to Interact Before 1493)")]
    Siegmeyer_Second_Location_No_Need_to_Interact_Before_1493 = 1491,

    [AnnotationAttribute(Name = "1492 | Siegmeyer, Second Location (Need to Interact Before 1493)")]
    Siegmeyer_Second_Location_Need_to_Interact_Before_1493 = 1492,

    [AnnotationAttribute(Name = "1493 | Siegmeyer, Anor Londo")]
    Siegmeyer_Anor_Londo = 1493,

    [AnnotationAttribute(Name = "1494 | Siegmeyer, Rescued in Anor Londo")]
    Siegmeyer_Rescued_in_Anor_Londo = 1494,

    [AnnotationAttribute(Name = "1497 | Siegmeyer, At Firelink Shrine")]
    Siegmeyer_At_Firelink_Shrine = 1497,

    [AnnotationAttribute(Name = "1501 | Siegmeyer, In Blighttown")]
    Siegmeyer_In_Blighttown = 1501,

    [AnnotationAttribute(Name = "1502 | Siegmeyer, Rescued In Blighttown")]
    Siegmeyer_Rescued_In_Blighttown = 1502,

    [AnnotationAttribute(Name = "1503 | Siegmeyer, In Lost Izalith")]
    Siegmeyer_In_Lost_Izalith = 1503,

    [AnnotationAttribute(Name = "1504 | Siegmeyer, Goes to Attack Chaos Eaters")]
    Siegmeyer_Goes_to_Attack_Chaos_Eaters = 1504,

    [AnnotationAttribute(Name = "1505 | Siegmeyer, Chaos Eaters Defeated Without Him")]
    Siegmeyer_Chaos_Eaters_Defeated_Without_Him = 1505,

    [AnnotationAttribute(Name = "1506 | Siegmeyer, Fails Chaos Eater Encounter")]
    Siegmeyer_Fails_Chaos_Eater_Encounter = 1506,

    [AnnotationAttribute(Name = "1507 | Siegmeyer, Survives Chaos Eater Encounter")]
    Siegmeyer_Survives_Chaos_Eater_Encounter = 1507,

    [AnnotationAttribute(Name = "1511 | Siegmeyer, Dead in Ash Lake")]
    Siegmeyer_Dead_in_Ash_Lake = 1511,

    [AnnotationAttribute(Name = "1512 | Siegmeyer, Hostile")]
    Siegmeyer_Hostile = 1512,

    [AnnotationAttribute(Name = "1513 | Siegmeyer, Dead")]
    Siegmeyer_Dead = 1513,

    [AnnotationAttribute(Name = "1541 | Sieglinde, Trapped in Golem at Duke's")]
    Sieglinde_Trapped_in_Golem_at_Dukes = 1541,

    [AnnotationAttribute(Name = "1542 | Sieglinde, Rescued in Duke's Archives")]
    Sieglinde_Rescued_in_Dukes_Archives = 1542,

    [AnnotationAttribute(Name = "1543 | Sieglinde, At Firelink Shrine (1st Time)")]
    Sieglinde_At_Firelink_Shrine_1st_Time = 1543,

    [AnnotationAttribute(Name = "1545 | Sieglinde, At Firelink Shrine (2nd Time)")]
    Sieglinde_At_Firelink_Shrine_2nd_Time = 1545,

    [AnnotationAttribute(Name = "1546 | Sieglinde, In Ash Lake")]
    Sieglinde_In_Ash_Lake = 1546,

    [AnnotationAttribute(Name = "1547 | Sieglinde, Hostile")]
    Sieglinde_Hostile = 1547,

    [AnnotationAttribute(Name = "1548 | Sieglinde, Dead")]
    Sieglinde_Dead = 1548,

    [AnnotationAttribute(Name = "1570 | Lautrec, Starting Location")]
    Lautrec_Starting_Location = 1570,

    [AnnotationAttribute(Name = "1571 | Lautrec, Rescue Completed")]
    Lautrec_Rescue_Completed = 1571,

    [AnnotationAttribute(Name = "1572 | Lautrec, In Firelink Shrine (After Rescue)")]
    Lautrec_In_Firelink_Shrine_After_Rescue = 1572,

    [AnnotationAttribute(Name = "1573 | Lautrec, Temporaily Left Firelink")]
    Lautrec_Temporaily_Left_Firelink = 1573,

    [AnnotationAttribute(Name = "1574 | Lautrec, Hostile")]
    Lautrec_Hostile = 1574,

    [AnnotationAttribute(Name = "1575 | Lautrec, Dead")]
    Lautrec_Dead = 1575,

    [AnnotationAttribute(Name = "1577 | Lautrec, In Firelink Shrine (After Escape)")]
    Lautrec_In_Firelink_Shrine_After_Escape = 1577,

    [AnnotationAttribute(Name = "1578 | Lautrec, In Anor Londo")]
    Lautrec_In_Anor_Londo = 1578,

    [AnnotationAttribute(Name = "1603 | Shiva, Hostile")]
    Shiva_Hostile = 1603,

    [AnnotationAttribute(Name = "1604 | Shiva, Dead")]
    Shiva_Dead = 1604,

    [AnnotationAttribute(Name = "1621 | Patches, After Walking Over Catacombs Bridge")]
    Patches_After_Walking_Over_Catacombs_Bridge = 1621,

    [AnnotationAttribute(Name = "1623 | Patches, In Tomb of the Giants")]
    Patches_In_Tomb_of_the_Giants = 1623,

    [AnnotationAttribute(Name = "1624 | Patches, After Kicked Into Pit")]
    Patches_After_Kicked_Into_Pit = 1624,

    [AnnotationAttribute(Name = "1625 | Patches, Hostile (cleric questline)")]
    Patches_Hostile_cleric_questline = 1625,

    [AnnotationAttribute(Name = "1626 | Patches, At Firelink Shrine")]
    Patches_At_Firelink_Shrine = 1626,

    [AnnotationAttribute(Name = "1627 | Patches, Hostile")]
    Patches_Hostile = 1627,

    [AnnotationAttribute(Name = "1628 | Patches, Dead")]
    Patches_Dead = 1628,

    [AnnotationAttribute(Name = "1641 | Frampt, Snoring in Firelink Shrine")]
    Frampt_Snoring_in_Firelink_Shrine = 1641,

    [AnnotationAttribute(Name = "1642 | Frampt, Present in Firelink Shrine")]
    Frampt_Present_in_Firelink_Shrine = 1642,

    [AnnotationAttribute(Name = "1644 | Frampt, After Placing Lordvessel")]
    Frampt_After_Placing_Lordvessel = 1644,

    [AnnotationAttribute(Name = "1647 | Frampt, Disapproves and Leaves")]
    Frampt_Disapproves_and_Leaves = 1647,

    [AnnotationAttribute(Name = "1650 | ? In Firelink?")]
    A_In_Firelink = 1650,

    [AnnotationAttribute(Name = "1671 | Kaathe, Appears?")]
    Kaathe_Appears = 1671,

    [AnnotationAttribute(Name = "1677 | Kaathe, Disapproves and Leaves")]
    Kaathe_Disapproves_and_Leaves = 1677,

    [AnnotationAttribute(Name = "1700 | Oswald, Starting Location")]
    Oswald_Starting_Location = 1700,

    [AnnotationAttribute(Name = "1701 | Oswald, Hostile")]
    Oswald_Hostile = 1701,

    [AnnotationAttribute(Name = "1702 | Oswald, Dead")]
    Oswald_Dead = 1702,

    [AnnotationAttribute(Name = "1711 | Alvina, Disapproves and Leaves")]
    Alvina_Disapproves_and_Leaves = 1711,

    [AnnotationAttribute(Name = "1763 | Shiva's Bodyguard, Hostile")]
    Shivas_Bodyguard_Hostile = 1763,

    [AnnotationAttribute(Name = "1764 | Shiva's Bodyguard, Dead")]
    Shivas_Bodyguard_Dead = 1764,

    [AnnotationAttribute(Name = "1766 | Shiva's Bodyguard, ?")]
    Shivas_Bodyguard_ = 1766,

    [AnnotationAttribute(Name = "1821 | Gough, Not Present")]
    Gough_Not_Present = 1821,

    [AnnotationAttribute(Name = "1822 | Gough, Hostile")]
    Gough_Hostile = 1822,

    [AnnotationAttribute(Name = "1823 | Gough, Dead")]
    Gough_Dead = 1823,

    [AnnotationAttribute(Name = "1841 | Chester, Hostile")]
    Chester_Hostile = 1841,

    [AnnotationAttribute(Name = "1842 | Chester, Dead")]
    Chester_Dead = 1842,

    [AnnotationAttribute(Name = "1862 | Ciaran, Gifted Artorias's Soul")]
    Ciaran_Gifted_Artoriass_Soul = 1862,

    [AnnotationAttribute(Name = "1863 | Ciaran, Hostile")]
    Ciaran_Hostile = 1863,

    [AnnotationAttribute(Name = "1864 | Ciaran, Dead")]
    Ciaran_Dead = 1864,

    [AnnotationAttribute(Name = "1871 | Elizabeth, Hostile (Unused)")]
    Elizabeth_Hostile_Unused = 1871,

    [AnnotationAttribute(Name = "1872 | Elizabeth, Dead")]
    Elizabeth_Dead = 1872,

    [AnnotationAttribute(Name = "8131 | Estus Flask, Upgraded to +1")]
    Estus_Flask_Upgraded_to_1 = 8131,

    [AnnotationAttribute(Name = "8132 | Estus Flask, Upgraded to +2")]
    Estus_Flask_Upgraded_to_2 = 8132,

    [AnnotationAttribute(Name = "8133 | Estus Flask, Upgraded to +3")]
    Estus_Flask_Upgraded_to_3 = 8133,

    [AnnotationAttribute(Name = "8134 | Estus Flask, Upgraded to +4")]
    Estus_Flask_Upgraded_to_4 = 8134,

    [AnnotationAttribute(Name = "8135 | Estus Flask, Upgraded to +5")]
    Estus_Flask_Upgraded_to_5 = 8135,

    [AnnotationAttribute(Name = "8136 | Estus Flask, Upgraded to +6")]
    Estus_Flask_Upgraded_to_6 = 8136,

    [AnnotationAttribute(Name = "8137 | Estus Flask, Upgraded to +7")]
    Estus_Flask_Upgraded_to_7 = 8137,

    [AnnotationAttribute(Name = "131327 | ? on Sif's Gate character anim finished")]
    A_on_Sifs_Gate_character_anim_finished = 131327,

    [AnnotationAttribute(Name = "11000100 | Depths, Shortcut door opened")]
    Depths_Shortcut_door_opened = 11000100,

    [AnnotationAttribute(Name = "11000111 | Depths, Door to Blighttown")]
    Depths_Door_to_Blighttown = 11000111,

    [AnnotationAttribute(Name = "11000120 | Depths, Bonfire door opened")]
    Depths_Bonfire_door_opened = 11000120,

    [AnnotationAttribute(Name = "11000600 | Depths, Large Ember chest opened")]
    Depths_Large_Ember_chest_opened = 11000600,

    [AnnotationAttribute(Name = "11000800 | Dead, The Depths, Giant Rat")]
    Dead_The_Depths_Giant_Rat = 11000800,

    [AnnotationAttribute(Name = "11000850 | Dead, The Depths, Butcher's Dog")]
    Dead_The_Depths_Butchers_Dog = 11000850,

    [AnnotationAttribute(Name = "11000851 | Dead, The Depths, Butcher #2")]
    Dead_The_Depths_Butcher_2 = 11000851,

    [AnnotationAttribute(Name = "11000852 | Dead, The Depths, Butcher #1")]
    Dead_The_Depths_Butcher_1 = 11000852,

    [AnnotationAttribute(Name = "11010000 | Gargoyles, Cutscene triggered, fight starts when in Gargoyles Arena")]
    Gargoyles_Cutscene_triggered_fight_starts_when_in_Gargoyles_Arena = 11010000,

    [AnnotationAttribute(Name = "11010090 | Undead Burg, Fog Gate")]
    Undead_Burg_Fog_Gate = 11010090,

    [AnnotationAttribute(Name = "11010100 | Undead Burg, Shortcut Ladder")]
    Undead_Burg_Shortcut_Ladder = 11010100,

    [AnnotationAttribute(Name = "11010101 | Undead Burg, Gate to Female Merchant")]
    Undead_Burg_Gate_to_Female_Merchant = 11010101,

    [AnnotationAttribute(Name = "11010120 | Undead Burg, Flaming Barrel kicked down")]
    Undead_Burg_Flaming_Barrel_kicked_down = 11010120,

    [AnnotationAttribute(Name = "11010140 | Undead Burg, Master Key Door (to Gold Resin)")]
    Undead_Burg_Master_Key_Door_to_Gold_Resin = 11010140,

    [AnnotationAttribute(Name = "11010160 | Undead Burg, Shortcut Door to Lower Burg")]
    Undead_Burg_Shortcut_Door_to_Lower_Burg = 11010160,

    [AnnotationAttribute(Name = "11010171 | Undead Burg, Door to the Depths")]
    Undead_Burg_Door_to_the_Depths = 11010171,

    [AnnotationAttribute(Name = "11010172 | Undead Burg, Basement Key Door")]
    Undead_Burg_Basement_Key_Door = 11010172,

    [AnnotationAttribute(Name = "11010191 | Undead Burg, Watchtower upper door")]
    Undead_Burg_Watchtower_upper_door = 11010191,

    [AnnotationAttribute(Name = "11010192 | Undead Burg, Watchtower lower door")]
    Undead_Burg_Watchtower_lower_door = 11010192,

    [AnnotationAttribute(Name = "11010403 | Lower Undead Burg, Large Soul of a Lost Undead corpse collapsed")]
    Lower_Undead_Burg_Large_Soul_of_a_Lost_Undead_corpse_collapsed = 11010403,

    [AnnotationAttribute(Name = "11010404 | Lower Undead Burg, Sorcerer Set corpse collapsed")]
    Lower_Undead_Burg_Sorcerer_Set_corpse_collapsed = 11010404,

    [AnnotationAttribute(Name = "11010586 | Resting at Firelink Shrine")]
    Resting_at_Firelink_Shrine = 11010586,

    [AnnotationAttribute(Name = "11010591 | Obtained, White Sign Soapstone")]
    Obtained_White_Sign_Soapstone = 11010591,

    [AnnotationAttribute(Name = "11010594 | Obtained, Miracle: Lightning Spear")]
    Obtained_Miracle_Lightning_Spear = 11010594,

    [AnnotationAttribute(Name = "11010621 | Undead Burg, Sunlight Altar gate open")]
    Undead_Burg_Sunlight_Altar_gate_open = 11010621,

    [AnnotationAttribute(Name = "11010650 | Undead Burg, Black Firebomb chest opened")]
    Undead_Burg_Black_Firebomb_chest_opened = 11010650,

    [AnnotationAttribute(Name = "11010651 | Undead Burg, Gold Pine Resin chest opened")]
    Undead_Burg_Gold_Pine_Resin_chest_opened = 11010651,

    [AnnotationAttribute(Name = "11010700 | Undead Parish, First Bell of Awakening")]
    Undead_Parish_First_Bell_of_Awakening = 11010700,

    [AnnotationAttribute(Name = "11010790 | Undead Burg, Hellkite's First Appearance")]
    Undead_Burg_Hellkites_First_Appearance = 11010790,

    [AnnotationAttribute(Name = "11010791 | Undead Burg, Hellkite's Second Appearance")]
    Undead_Burg_Hellkites_Second_Appearance = 11010791,

    [AnnotationAttribute(Name = "11010860 | Dead, Undead Burg, Havel")]
    Dead_Undead_Burg_Havel = 11010860,

    [AnnotationAttribute(Name = "11010861 | Dead, Undead Burg, Black Knight")]
    Dead_Undead_Burg_Black_Knight = 11010861,

    [AnnotationAttribute(Name = "11010863 | Dead, Undead Parish, Berenike Knight")]
    Dead_Undead_Parish_Berenike_Knight = 11010863,

    [AnnotationAttribute(Name = "11010865 | Dead, Undead Parish, Channeler")]
    Dead_Undead_Parish_Channeler = 11010865,

    [AnnotationAttribute(Name = "11010866 | Dead, Undead Parish, Gate Hollow")]
    Dead_Undead_Parish_Gate_Hollow = 11010866,

    [AnnotationAttribute(Name = "11010901 | Boss Defeated, Taurus Demon")]
    Boss_Defeated_Taurus_Demon = 11010901,

    [AnnotationAttribute(Name = "11010902 | Boss Defeated, Capra Demon")]
    Boss_Defeated_Capra_Demon = 11010902,

    [AnnotationAttribute(Name = "11010903 | Dead, Undead Parish, Boar")]
    Dead_Undead_Parish_Boar = 11010903,

    [AnnotationAttribute(Name = "11015031 | Pray at the Altar of Sunlight")]
    Pray_at_the_Altar_of_Sunlight = 11015031,

    [AnnotationAttribute(Name = "11015390 | Enter Gargoyle foggate")]
    Enter_Gargoyle_foggate = 11015390,

    [AnnotationAttribute(Name = "11015392 | Set on Gargoyle fight start (always)")]
    Set_on_Gargoyle_fight_start_always = 11015392,

    [AnnotationAttribute(Name = "11015393 | Halfway through Gargoyle foggate")]
    Halfway_through_Gargoyle_foggate = 11015393,

    [AnnotationAttribute(Name = "11015394 | Set on Gargoyle fight start (always)")]
    Set_on_Gargoyle_fight_start_always_1 = 11015394,

    [AnnotationAttribute(Name = "11020300 | Undead Parish, Elevator to Firelink active")]
    Undead_Parish_Elevator_to_Firelink_active = 11020300,

    [AnnotationAttribute(Name = "11020302 | Undead Parish, Elevator to Firelink (left elevator down)")]
    Undead_Parish_Elevator_to_Firelink_left_elevator_down = 11020302,

    [AnnotationAttribute(Name = "11020575 | Laurentius, Knows About Quelana")]
    Laurentius_Knows_About_Quelana = 11020575,

    [AnnotationAttribute(Name = "11020599 | Petrus, Gifts Copper Coin")]
    Petrus_Gifts_Copper_Coin = 11020599,

    [AnnotationAttribute(Name = "11020602 | Laurentius, Gifts Pyromancy Flame")]
    Laurentius_Gifts_Pyromancy_Flame = 11020602,

    [AnnotationAttribute(Name = "11020700 | Firelink Shrine, Lloyd's Talisman chest opened")]
    Firelink_Shrine_Lloyds_Talisman_chest_opened = 11020700,

    [AnnotationAttribute(Name = "11020701 | Firelink Shrine, Talisman chest opened")]
    Firelink_Shrine_Talisman_chest_opened = 11020701,

    [AnnotationAttribute(Name = "11020702 | Firelink Shrine, Homeward Bone chest opened")]
    Firelink_Shrine_Homeward_Bone_chest_opened = 11020702,

    [AnnotationAttribute(Name = "11020703 | Firelink Shrine, Cracked Red Eye Orb opened")]
    Firelink_Shrine_Cracked_Red_Eye_Orb_opened = 11020703,

    [AnnotationAttribute(Name = "11025060 | Firelink Shrine, Curled Up Like A Ball")]
    Firelink_Shrine_Curled_Up_Like_A_Ball = 11025060,

    [AnnotationAttribute(Name = "11025200 | Firelink Shrine, Skeleton Stands Up")]
    Firelink_Shrine_Skeleton_Stands_Up = 11025200,

    [AnnotationAttribute(Name = "11025201 | Firelink Shrine, Skeleton Stands Up")]
    Firelink_Shrine_Skeleton_Stands_Up_1 = 11025201,

    [AnnotationAttribute(Name = "11025202 | Firelink Shrine, Skeleton Stands Up")]
    Firelink_Shrine_Skeleton_Stands_Up_2 = 11025202,

    [AnnotationAttribute(Name = "11025203 | Firelink Shrine, Skeleton Stands Up")]
    Firelink_Shrine_Skeleton_Stands_Up_3 = 11025203,

    [AnnotationAttribute(Name = "11025206 | Firelink Shrine, Skeleton Stands Up")]
    Firelink_Shrine_Skeleton_Stands_Up_4 = 11025206,

    [AnnotationAttribute(Name = "11025207 | Firelink Shrine, Skeleton Stands Up")]
    Firelink_Shrine_Skeleton_Stands_Up_5 = 11025207,

    [AnnotationAttribute(Name = "11025208 | Firelink Shrine, Skeleton Stands Up")]
    Firelink_Shrine_Skeleton_Stands_Up_6 = 11025208,

    [AnnotationAttribute(Name = "11025209 | Firelink Shrine, Skeleton Stands Up")]
    Firelink_Shrine_Skeleton_Stands_Up_7 = 11025209,

    [AnnotationAttribute(Name = "11025210 | Firelink Shrine, Skeleton Stands Up")]
    Firelink_Shrine_Skeleton_Stands_Up_8 = 11025210,

    [AnnotationAttribute(Name = "11025211 | Firelink Shrine, Skeleton Stands Up")]
    Firelink_Shrine_Skeleton_Stands_Up_9 = 11025211,

    [AnnotationAttribute(Name = "11025212 | Firelink Shrine, Skeleton Stands Up")]
    Firelink_Shrine_Skeleton_Stands_Up_10 = 11025212,

    [AnnotationAttribute(Name = "11025213 | Firelink Shrine, Skeleton Stands Up")]
    Firelink_Shrine_Skeleton_Stands_Up_11 = 11025213,

    [AnnotationAttribute(Name = "11100030 | Painted World, Shortcut gate at the bonfire")]
    Painted_World_Shortcut_gate_at_the_bonfire = 11100030,

    [AnnotationAttribute(Name = "11100120 | Painted World, Annex Key door")]
    Painted_World_Annex_Key_door = 11100120,

    [AnnotationAttribute(Name = "11100135 | Painted World, Main gate to Priscilla")]
    Painted_World_Main_gate_to_Priscilla = 11100135,

    [AnnotationAttribute(Name = "11200000 | ? on Sif fight started")]
    A_on_Sif_fight_started = 11200000,

    [AnnotationAttribute(Name = "11200001 | ? on Sif killed")]
    A_on_Sif_killed_1 = 11200001,

    [AnnotationAttribute(Name = "11200002 | ? on Sif fight started")]
    A_on_Sif_fight_started_1 = 11200002,

    [AnnotationAttribute(Name = "11200101 | ? on Sif's Gate character anim finished")]
    A_on_Sifs_Gate_character_anim_finished_1 = 11200101,

    [AnnotationAttribute(Name = "11200110 | Darkroot, Crest of Artorias door")]
    Darkroot_Crest_of_Artorias_door = 11200110,

    [AnnotationAttribute(Name = "11200111 | ? on Touched Sif's Gate")]
    A_on_Touched_Sifs_Gate = 11200111,

    [AnnotationAttribute(Name = "11200215 | Touched Dusk Summon Sign")]
    Touched_Dusk_Summon_Sign = 11200215,

    [AnnotationAttribute(Name = "11200530 | Dusk freed from Golem?")]
    Dusk_freed_from_Golem = 11200530,

    [AnnotationAttribute(Name = "11200531 | Dusk disappeared after saying 'yes' to her")]
    Dusk_disappeared_after_saying_yes_to_her = 11200531,

    [AnnotationAttribute(Name = "11200532 | Dusk disappeared after saying 'No' to her")]
    Dusk_disappeared_after_saying_No_to_her = 11200532,

    [AnnotationAttribute(Name = "11200533 | Said yes to Dusk")]
    Said_yes_to_Dusk = 11200533,

    [AnnotationAttribute(Name = "11200592 | Alvina, Gift Cat Covenant Ring")]
    Alvina_Gift_Cat_Covenant_Ring = 11200592,

    [AnnotationAttribute(Name = "11200810 | Dead, Darkroot Forest, Possessed Tree #2")]
    Dead_Darkroot_Forest_Possessed_Tree_2 = 11200810,

    [AnnotationAttribute(Name = "11200811 | Dead, Darkroot Forest, Possessed Tree #1")]
    Dead_Darkroot_Forest_Possessed_Tree_1 = 11200811,

    [AnnotationAttribute(Name = "11200818 | Dead, Darkroot Forest, Pharis")]
    Dead_Darkroot_Forest_Pharis = 11200818,

    [AnnotationAttribute(Name = "11200900 | Boss Defeated, Moonlight Butterfly")]
    Boss_Defeated_Moonlight_Butterfly = 11200900,

    [AnnotationAttribute(Name = "11205310 | Dusk finished summoning animation")]
    Dusk_finished_summoning_animation_1 = 11205310,

    [AnnotationAttribute(Name = "11205390 | ? on Sif cutscene triggered")]
    A_on_Sif_cutscene_triggered = 11205390,

    [AnnotationAttribute(Name = "11205391 | ? on Sif cutscene triggered")]
    A_on_Sif_cutscene_triggered_1 = 11205391,

    [AnnotationAttribute(Name = "11205393 | ? on Sif cutscene triggered")]
    A_on_Sif_cutscene_triggered_2 = 11205393,

    [AnnotationAttribute(Name = "11205394 | ? on Sif fight started")]
    A_on_Sif_fight_started_2 = 11205394,

    [AnnotationAttribute(Name = "11205395 | ? on Sif killed")]
    A_on_Sif_killed_2 = 11205395,

    [AnnotationAttribute(Name = "11205396 | ? on Sif 0 HP")]
    A_on_Sif_0_HP = 11205396,

    [AnnotationAttribute(Name = "11210000 | Boss Defeated, Sanctuary Guardian")]
    Boss_Defeated_Sanctuary_Guardian = 11210000,

    [AnnotationAttribute(Name = "11210001 | Boss Defeated, Artorias")]
    Boss_Defeated_Artorias = 11210001,

    [AnnotationAttribute(Name = "11210002 | Boss Defeated, Manus")]
    Boss_Defeated_Manus = 11210002,

    [AnnotationAttribute(Name = "11210004 | Boss Defeated, Kalameet")]
    Boss_Defeated_Kalameet = 11210004,

    [AnnotationAttribute(Name = "11210005 | Changed on defeating Kalameet")]
    Changed_on_defeating_Kalameet_1 = 11210005,

    [AnnotationAttribute(Name = "11210021 | Chasm of the Abyss, Sif Rescued")]
    Chasm_of_the_Abyss_Sif_Rescued = 11210021,

    [AnnotationAttribute(Name = "11210025 | Chasm of the Abyss, Illusory Wall")]
    Chasm_of_the_Abyss_Illusory_Wall = 11210025,

    [AnnotationAttribute(Name = "11210030 | Changed on entering Artorias Fight")]
    Changed_on_entering_Artorias_Fight = 11210030,

    [AnnotationAttribute(Name = "11210040 | Set after passing the center of Kalameet burn area")]
    Set_after_passing_the_center_of_Kalameet_burn_area = 11210040,

    [AnnotationAttribute(Name = "11210041 | Player left Kalameet burn area additional flag")]
    Player_left_Kalameet_burn_area_additional_flag = 11210041,

    [AnnotationAttribute(Name = "11210050 | First Kalameet encounter")]
    First_Kalameet_encounter = 11210050,

    [AnnotationAttribute(Name = "11210052 | Kalameet burning area flag")]
    Kalameet_burning_area_flag = 11210052,

    [AnnotationAttribute(Name = "11210056 | Kalameet burning area flag")]
    Kalameet_burning_area_flag_1 = 11210056,

    [AnnotationAttribute(Name = "11210057 | Kalameet burning area flag")]
    Kalameet_burning_area_flag_2 = 11210057,

    [AnnotationAttribute(Name = "11210063 | Black Dragon Kalameet (Goughless)")]
    Black_Dragon_Kalameet_Goughless = 11210063,

    [AnnotationAttribute(Name = "11210065 | Kalameet comes flying to burn everything")]
    Kalameet_comes_flying_to_burn_everything = 11210065,

    [AnnotationAttribute(Name = "11210066 | Kalameet burning area flag")]
    Kalameet_burning_area_flag_3 = 11210066,

    [AnnotationAttribute(Name = "11210067 | Kalameet burning area flag")]
    Kalameet_burning_area_flag_4 = 11210067,

    [AnnotationAttribute(Name = "11210068 | Kalameet burning area flag")]
    Kalameet_burning_area_flag_5 = 11210068,

    [AnnotationAttribute(Name = "11210070 | Kalameet burning area flag")]
    Kalameet_burning_area_flag_6 = 11210070,

    [AnnotationAttribute(Name = "11210071 | Kalameet burning area flag")]
    Kalameet_burning_area_flag_7 = 11210071,

    [AnnotationAttribute(Name = "11210072 | Kalameet burning area flag")]
    Kalameet_burning_area_flag_8 = 11210072,

    [AnnotationAttribute(Name = "11210073 | Kalameet burning area flag")]
    Kalameet_burning_area_flag_9 = 11210073,

    [AnnotationAttribute(Name = "11210101 | Oolacile, Elevator (Position - needs interaction beforehand)")]
    Oolacile_Elevator_Position__needs_interaction_beforehand = 11210101,

    [AnnotationAttribute(Name = "11210102 | Oolacile, Elevator (Operability - combine w/ next)")]
    Oolacile_Elevator_Operability__combine_w_next = 11210102,

    [AnnotationAttribute(Name = "11210103 | Oolacile, Elevator (Unlocked - combine w/ previous)")]
    Oolacile_Elevator_Unlocked__combine_w_previous = 11210103,

    [AnnotationAttribute(Name = "11210110 | Stepped off Royal Wood elevator 1")]
    Stepped_off_Royal_Wood_elevator_1 = 11210110,

    [AnnotationAttribute(Name = "11210111 | Determines position of RW elevator 1 and which plate is active")]
    Determines_position_of_RW_elevator_1_and_which_plate_is_active = 11210111,

    [AnnotationAttribute(Name = "11210121 | Royal Wood, Elevator #2 (Position)")]
    Royal_Wood_Elevator_2_Position = 11210121,

    [AnnotationAttribute(Name = "11210122 | Royal Wood, Elevator #2 (Operability - combine w/ next)")]
    Royal_Wood_Elevator_2_Operability__combine_w_next = 11210122,

    [AnnotationAttribute(Name = "11210123 | Royal Wood Skip Elevator active")]
    Royal_Wood_Skip_Elevator_active = 11210123,

    [AnnotationAttribute(Name = "11210131 | Chasm of the Abyss, Shortcut Elevator (Position)")]
    Chasm_of_the_Abyss_Shortcut_Elevator_Position = 11210131,

    [AnnotationAttribute(Name = "11210132 | Chasm of the Abyss, Shortcut Elevator (Operability - combine w/ next)")]
    Chasm_of_the_Abyss_Shortcut_Elevator_Operability__combine_w_next = 11210132,

    [AnnotationAttribute(Name = "11210133 | Chasm of the Abyss, Shortcut Elevator (Unlocked - combine w/ previous)")]
    Chasm_of_the_Abyss_Shortcut_Elevator_Unlocked__combine_w_previous = 11210133,

    [AnnotationAttribute(Name = "11210141 | Oolacile, Elevator to Chasm (Position)")]
    Oolacile_Elevator_to_Chasm_Position = 11210141,

    [AnnotationAttribute(Name = "11210205 | Oolacile, Sound Effect for Illusory Wall #1")]
    Oolacile_Sound_Effect_for_Illusory_Wall_1 = 11210205,

    [AnnotationAttribute(Name = "11210206 | Oolacile, Sound Effect for Illusory Wall #2")]
    Oolacile_Sound_Effect_for_Illusory_Wall_2 = 11210206,

    [AnnotationAttribute(Name = "11210340 | Chasm of the Abyss, Alvina 1st Warp")]
    Chasm_of_the_Abyss_Alvina_1st_Warp = 11210340,

    [AnnotationAttribute(Name = "11210341 | Chasm of the Abyss, Alvina 2nd Warp")]
    Chasm_of_the_Abyss_Alvina_2nd_Warp = 11210341,

    [AnnotationAttribute(Name = "11210345 | Chasm of the Abyss, Alvina 3rd Warp")]
    Chasm_of_the_Abyss_Alvina_3rd_Warp = 11210345,

    [AnnotationAttribute(Name = "11210346 | Chasm of the Abyss, Alvina Gone?")]
    Chasm_of_the_Abyss_Alvina_Gone = 11210346,

    [AnnotationAttribute(Name = "11210350 | Kalameet Lizard killed")]
    Kalameet_Lizard_killed = 11210350,

    [AnnotationAttribute(Name = "11210537 | Changed on triggering Artorias cutscene")]
    Changed_on_triggering_Artorias_cutscene = 11210537,

    [AnnotationAttribute(Name = "11210590 | Gets you Ciaran's tracers (but there are only one of each, setting this repeatedly doesn't do anything)")]
    Gets_you_Ciarans_tracers_but_there_are_only_one_of_each_setting_this_repeatedly_doesnt_do_anything = 11210590,

    [AnnotationAttribute(Name = "11210600 | Royal Wood, Blue Titanite Slab chest opened")]
    Royal_Wood_Blue_Titanite_Slab_chest_opened = 11210600,

    [AnnotationAttribute(Name = "11210605 | Opened Kalameet Titanite Slab chest")]
    Opened_Kalameet_Titanite_Slab_chest = 11210605,

    [AnnotationAttribute(Name = "11210650 | Oolacile, Crest Key Door")]
    Oolacile_Crest_Key_Door = 11210650,

    [AnnotationAttribute(Name = "11210681 | Dead, Oolacile Township, Carving Mimic")]
    Dead_Oolacile_Township_Carving_Mimic = 11210681,

    [AnnotationAttribute(Name = "11210878 | Set every second while in Battle of Stoicisim")]
    Set_every_second_while_in_Battle_of_Stoicisim = 11210878,

    [AnnotationAttribute(Name = "11210901 | Dead, Oolacile, Chester Invasion")]
    Dead_Oolacile_Chester_Invasion = 11210901,

    [AnnotationAttribute(Name = "11215000 | Changed when entering Guardian fight")]
    Changed_when_entering_Guardian_fight = 11215000,

    [AnnotationAttribute(Name = "11215002 | Changed when entering Guardian fight")]
    Changed_when_entering_Guardian_fight_1 = 11215002,

    [AnnotationAttribute(Name = "11215003 | Changed when entering Guardian fight")]
    Changed_when_entering_Guardian_fight_2 = 11215003,

    [AnnotationAttribute(Name = "11215004 | Changed when entering Guardian fight")]
    Changed_when_entering_Guardian_fight_3 = 11215004,

    [AnnotationAttribute(Name = "11215005 | Changed on Guardian killed")]
    Changed_on_Guardian_killed_1 = 11215005,

    [AnnotationAttribute(Name = "11215006 | Changed on Guardian killed")]
    Changed_on_Guardian_killed_2 = 11215006,

    [AnnotationAttribute(Name = "11215010 | Changed on entering Artorias Fight")]
    Changed_on_entering_Artorias_Fight_1 = 11215010,

    [AnnotationAttribute(Name = "11215012 | Changed on triggering Artorias cutscene")]
    Changed_on_triggering_Artorias_cutscene_1 = 11215012,

    [AnnotationAttribute(Name = "11215013 | Changed on entering Artorias Fight")]
    Changed_on_entering_Artorias_Fight_2 = 11215013,

    [AnnotationAttribute(Name = "11215014 | Changed on entering Artorias Fight")]
    Changed_on_entering_Artorias_Fight_3 = 11215014,

    [AnnotationAttribute(Name = "11215015 | Changed on killing Artorias")]
    Changed_on_killing_Artorias_1 = 11215015,

    [AnnotationAttribute(Name = "11215051 | Kalameet at 0 HP")]
    Kalameet_at_0_HP = 11215051,

    [AnnotationAttribute(Name = "11215055 | Player is in Kalameet burn area 2")]
    Player_is_in_Kalameet_burn_area_2 = 11215055,

    [AnnotationAttribute(Name = "11215056 | Player is in Kalameet burn area 1")]
    Player_is_in_Kalameet_burn_area_1 = 11215056,

    [AnnotationAttribute(Name = "11215060 | Went through Kalameet foggate")]
    Went_through_Kalameet_foggate = 11215060,

    [AnnotationAttribute(Name = "11215062 | Went through Kalameet foggate")]
    Went_through_Kalameet_foggate_1 = 11215062,

    [AnnotationAttribute(Name = "11215063 | Triggered Kalameet fight")]
    Triggered_Kalameet_fight = 11215063,

    [AnnotationAttribute(Name = "11215064 | Triggered Kalameet fight")]
    Triggered_Kalameet_fight_1 = 11215064,

    [AnnotationAttribute(Name = "11215065 | Changed on defeating Kalameet")]
    Changed_on_defeating_Kalameet_2 = 11215065,

    [AnnotationAttribute(Name = "11215140 | Gets set every like 40s while in the DLC")]
    Gets_set_every_like_40s_while_in_the_DLC = 11215140,

    [AnnotationAttribute(Name = "11215141 | Gets set every like 30s while in the DLC")]
    Gets_set_every_like_30s_while_in_the_DLC = 11215141,

    [AnnotationAttribute(Name = "11215151 | Set on Township bonfire rest")]
    Set_on_Township_bonfire_rest = 11215151,

    [AnnotationAttribute(Name = "11215152 | Set on Township bonfire rest")]
    Set_on_Township_bonfire_rest_1 = 11215152,

    [AnnotationAttribute(Name = "11215153 | Set on Township bonfire rest")]
    Set_on_Township_bonfire_rest_2 = 11215153,

    [AnnotationAttribute(Name = "11215221 | Currently on Royal Wood elevator 1")]
    Currently_on_Royal_Wood_elevator_1 = 11215221,

    [AnnotationAttribute(Name = "11217060 | Changed on killing Artorias")]
    Changed_on_killing_Artorias_2 = 11217060,

    [AnnotationAttribute(Name = "11217070 | Changed on killing Artorias")]
    Changed_on_killing_Artorias_3 = 11217070,

    [AnnotationAttribute(Name = "11217080 | Changed on killing Artorias")]
    Changed_on_killing_Artorias_4 = 11217080,

    [AnnotationAttribute(Name = "11217090 | Changed on killing Artorias")]
    Changed_on_killing_Artorias_5 = 11217090,

    [AnnotationAttribute(Name = "11300090 | Catacombs, Fog Gate")]
    Catacombs_Fog_Gate = 11300090,

    [AnnotationAttribute(Name = "11300100 | Catacombs, Breakaway Floor")]
    Catacombs_Breakaway_Floor = 11300100,

    [AnnotationAttribute(Name = "11300101 | Catacombs, Breakaway Floor")]
    Catacombs_Breakaway_Floor_1 = 11300101,

    [AnnotationAttribute(Name = "11300102 | Catacombs, Breakaway Floor")]
    Catacombs_Breakaway_Floor_2 = 11300102,

    [AnnotationAttribute(Name = "11300103 | Catacombs, Breakaway Floor")]
    Catacombs_Breakaway_Floor_3 = 11300103,

    [AnnotationAttribute(Name = "11300104 | Catacombs, Breakaway Floor")]
    Catacombs_Breakaway_Floor_4 = 11300104,

    [AnnotationAttribute(Name = "11300105 | Catacombs, Breakaway Floor")]
    Catacombs_Breakaway_Floor_5 = 11300105,

    [AnnotationAttribute(Name = "11300150 | Catacombs, Giant Skeleton Jumps Down")]
    Catacombs_Giant_Skeleton_Jumps_Down = 11300150,

    [AnnotationAttribute(Name = "11300160 | Catacombs, Illusory Wall")]
    Catacombs_Illusory_Wall = 11300160,

    [AnnotationAttribute(Name = "11300210 | Catacombs, Path to Vamos Open")]
    Catacombs_Path_to_Vamos_Open = 11300210,

    [AnnotationAttribute(Name = "11300402 | Catacombs, Bridge #1")]
    Catacombs_Bridge_1 = 11300402,

    [AnnotationAttribute(Name = "11300403 | Catacombs, Bridge #2")]
    Catacombs_Bridge_2 = 11300403,

    [AnnotationAttribute(Name = "11300700 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap = 11300700,

    [AnnotationAttribute(Name = "11300701 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_1 = 11300701,

    [AnnotationAttribute(Name = "11300703 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_2 = 11300703,

    [AnnotationAttribute(Name = "11300704 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_3 = 11300704,

    [AnnotationAttribute(Name = "11300705 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_4 = 11300705,

    [AnnotationAttribute(Name = "11300706 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_5 = 11300706,

    [AnnotationAttribute(Name = "11300707 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_6 = 11300707,

    [AnnotationAttribute(Name = "11300708 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_7 = 11300708,

    [AnnotationAttribute(Name = "11300709 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_8 = 11300709,

    [AnnotationAttribute(Name = "11300710 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_9 = 11300710,

    [AnnotationAttribute(Name = "11300712 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_10 = 11300712,

    [AnnotationAttribute(Name = "11300713 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_11 = 11300713,

    [AnnotationAttribute(Name = "11300714 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_12 = 11300714,

    [AnnotationAttribute(Name = "11300715 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_13 = 11300715,

    [AnnotationAttribute(Name = "11300716 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_14 = 11300716,

    [AnnotationAttribute(Name = "11300717 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_15 = 11300717,

    [AnnotationAttribute(Name = "11300718 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_16 = 11300718,

    [AnnotationAttribute(Name = "11300719 | Catacombs, Spike Trap")]
    Catacombs_Spike_Trap_17 = 11300719,

    [AnnotationAttribute(Name = "11300850 | Dead, Catacombs, Necromancer #2")]
    Dead_Catacombs_Necromancer_2 = 11300850,

    [AnnotationAttribute(Name = "11300851 | Dead, Catacombs, Necromancer #4")]
    Dead_Catacombs_Necromancer_4 = 11300851,

    [AnnotationAttribute(Name = "11300852 | Dead, Catacombs, Necromancer #5")]
    Dead_Catacombs_Necromancer_5 = 11300852,

    [AnnotationAttribute(Name = "11300853 | Dead, Catacombs, Necromancer #3")]
    Dead_Catacombs_Necromancer_3 = 11300853,

    [AnnotationAttribute(Name = "11300854 | Dead, Catacombs, Necromancer #1")]
    Dead_Catacombs_Necromancer_1 = 11300854,

    [AnnotationAttribute(Name = "11300855 | Dead, Catacombs, Necromancer #6")]
    Dead_Catacombs_Necromancer_6 = 11300855,

    [AnnotationAttribute(Name = "11300858 | Dead, Catacombs, Prowling Demon")]
    Dead_Catacombs_Prowling_Demon = 11300858,

    [AnnotationAttribute(Name = "11300859 | Dead, Catacombs, Black Knight")]
    Dead_Catacombs_Black_Knight = 11300859,

    [AnnotationAttribute(Name = "11300900 | Catacombs, Door #1 (Lever Operated)")]
    Catacombs_Door_1_Lever_Operated = 11300900,

    [AnnotationAttribute(Name = "11300901 | Catacombs, Door #2 (Lever Operated)")]
    Catacombs_Door_2_Lever_Operated = 11300901,

    [AnnotationAttribute(Name = "11305060 | Catacombs, ? Related to: Path to Vamos Open?")]
    Catacombs__Related_to_Path_to_Vamos_Open = 11305060,

    [AnnotationAttribute(Name = "11305070 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up = 11305070,

    [AnnotationAttribute(Name = "11305071 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up_1 = 11305071,

    [AnnotationAttribute(Name = "11305072 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up_2 = 11305072,

    [AnnotationAttribute(Name = "11305073 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up_3 = 11305073,

    [AnnotationAttribute(Name = "11305074 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up_4 = 11305074,

    [AnnotationAttribute(Name = "11305075 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up_5 = 11305075,

    [AnnotationAttribute(Name = "11305076 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up_6 = 11305076,

    [AnnotationAttribute(Name = "11305077 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up_7 = 11305077,

    [AnnotationAttribute(Name = "11305078 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up_8 = 11305078,

    [AnnotationAttribute(Name = "11305079 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up_9 = 11305079,

    [AnnotationAttribute(Name = "11305080 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up_10 = 11305080,

    [AnnotationAttribute(Name = "11305081 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up_11 = 11305081,

    [AnnotationAttribute(Name = "11305082 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up_12 = 11305082,

    [AnnotationAttribute(Name = "11305083 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up_13 = 11305083,

    [AnnotationAttribute(Name = "11305086 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up_14 = 11305086,

    [AnnotationAttribute(Name = "11305087 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up_15 = 11305087,

    [AnnotationAttribute(Name = "11305088 | Catacombs, Skeleton Stands Up")]
    Catacombs_Skeleton_Stands_Up_16 = 11305088,

    [AnnotationAttribute(Name = "11305100 | Catacombs, Relates to Necromancer #2")]
    Catacombs_Relates_to_Necromancer_2 = 11305100,

    [AnnotationAttribute(Name = "11305101 | Catacombs, Relates to Necromancer #2")]
    Catacombs_Relates_to_Necromancer_1 = 11305101,

    [AnnotationAttribute(Name = "11305102 | Catacombs, Relates to Necromancer #2")]
    Catacombs_Relates_to_Necromancer_3 = 11305102,

    [AnnotationAttribute(Name = "11305103 | Catacombs, Relates to Necromancer #2")]
    Catacombs_Relates_to_Necromancer_4 = 11305103,

    [AnnotationAttribute(Name = "11305104 | Catacombs, Relates to Necromancer #2")]
    Catacombs_Relates_to_Necromancer_5 = 11305104,

    [AnnotationAttribute(Name = "11305105 | Catacombs, Relates to Necromancer #2")]
    Catacombs_Relates_to_Necromancer_6 = 11305105,

    [AnnotationAttribute(Name = "11305106 | Catacombs, Relates to Necromancer #2")]
    Catacombs_Relates_to_Necromancer_7 = 11305106,

    [AnnotationAttribute(Name = "11305107 | Catacombs, Relates to Necromancer #2")]
    Catacombs_Relates_to_Necromancer_8 = 11305107,

    [AnnotationAttribute(Name = "11305108 | Catacombs, Relates to Necromancer #2")]
    Catacombs_Relates_to_Necromancer_9 = 11305108,

    [AnnotationAttribute(Name = "11305109 | Catacombs, Relates to Necromancer #2")]
    Catacombs_Relates_to_Necromancer_10 = 11305109,

    [AnnotationAttribute(Name = "11305110 | Catacombs, Relates to Necromancer #2")]
    Catacombs_Relates_to_Necromancer_11 = 11305110,

    [AnnotationAttribute(Name = "11305111 | Catacombs, Relates to Necromancer #2")]
    Catacombs_Relates_to_Necromancer_12 = 11305111,

    [AnnotationAttribute(Name = "11305112 | Catacombs, Relates to Necromancer #2")]
    Catacombs_Relates_to_Necromancer_13 = 11305112,

    [AnnotationAttribute(Name = "11305113 | Catacombs, Relates to Necromancer #2")]
    Catacombs_Relates_to_Necromancer_14 = 11305113,

    [AnnotationAttribute(Name = "11305114 | Catacombs, Relates to Necromancer #4")]
    Catacombs_Relates_to_Necromancer_15 = 11305114,

    [AnnotationAttribute(Name = "11305115 | Catacombs, Relates to Necromancer #4")]
    Catacombs_Relates_to_Necromancer_16 = 11305115,

    [AnnotationAttribute(Name = "11305116 | Catacombs, Relates to Necromancer #4")]
    Catacombs_Relates_to_Necromancer_17 = 11305116,

    [AnnotationAttribute(Name = "11305117 | Catacombs, Relates to Necromancer #4")]
    Catacombs_Relates_to_Necromancer_18 = 11305117,

    [AnnotationAttribute(Name = "11305118 | Catacombs, Relates to Necromancer #4")]
    Catacombs_Relates_to_Necromancer_19 = 11305118,

    [AnnotationAttribute(Name = "11305119 | Catacombs, Relates to Necromancer #4")]
    Catacombs_Relates_to_Necromancer_20 = 11305119,

    [AnnotationAttribute(Name = "11305120 | Catacombs, Relates to Necromancer #4")]
    Catacombs_Relates_to_Necromancer_21 = 11305120,

    [AnnotationAttribute(Name = "11305121 | Catacombs, Relates to Necromancer #4")]
    Catacombs_Relates_to_Necromancer_22 = 11305121,

    [AnnotationAttribute(Name = "11305122 | Catacombs, Relates to Necromancer #5")]
    Catacombs_Relates_to_Necromancer_23 = 11305122,

    [AnnotationAttribute(Name = "11305123 | Catacombs, Relates to Necromancer #5")]
    Catacombs_Relates_to_Necromancer_24 = 11305123,

    [AnnotationAttribute(Name = "11305124 | Catacombs, Relates to Necromancer #5")]
    Catacombs_Relates_to_Necromancer_25 = 11305124,

    [AnnotationAttribute(Name = "11305125 | Catacombs, Relates to Necromancer #5")]
    Catacombs_Relates_to_Necromancer_26 = 11305125,

    [AnnotationAttribute(Name = "11305126 | Catacombs, Relates to Necromancer #5")]
    Catacombs_Relates_to_Necromancer_27 = 11305126,

    [AnnotationAttribute(Name = "11305127 | Catacombs, Relates to Necromancer #5")]
    Catacombs_Relates_to_Necromancer_28 = 11305127,

    [AnnotationAttribute(Name = "11305128 | Catacombs, Relates to Necromancer #5")]
    Catacombs_Relates_to_Necromancer_29 = 11305128,

    [AnnotationAttribute(Name = "11305129 | Catacombs, Relates to Necromancer #3")]
    Catacombs_Relates_to_Necromancer_30 = 11305129,

    [AnnotationAttribute(Name = "11305130 | Catacombs, Relates to Necromancer #3")]
    Catacombs_Relates_to_Necromancer_31 = 11305130,

    [AnnotationAttribute(Name = "11305131 | Catacombs, Relates to Necromancer #3")]
    Catacombs_Relates_to_Necromancer_32 = 11305131,

    [AnnotationAttribute(Name = "11305132 | Catacombs, Relates to Necromancer #3")]
    Catacombs_Relates_to_Necromancer_33 = 11305132,

    [AnnotationAttribute(Name = "11305133 | Catacombs, Relates to Necromancer #3")]
    Catacombs_Relates_to_Necromancer_34 = 11305133,

    [AnnotationAttribute(Name = "11305134 | Catacombs, Relates to Necromancer #3")]
    Catacombs_Relates_to_Necromancer_35 = 11305134,

    [AnnotationAttribute(Name = "11305135 | Catacombs, Relates to Necromancer #1")]
    Catacombs_Relates_to_Necromancer_36 = 11305135,

    [AnnotationAttribute(Name = "11305136 | Catacombs, Relates to Necromancer #1")]
    Catacombs_Relates_to_Necromancer_37 = 11305136,

    [AnnotationAttribute(Name = "11305137 | Catacombs, Relates to Necromancer #1")]
    Catacombs_Relates_to_Necromancer_38 = 11305137,

    [AnnotationAttribute(Name = "11305138 | Catacombs, Relates to Necromancer #1")]
    Catacombs_Relates_to_Necromancer_39 = 11305138,

    [AnnotationAttribute(Name = "11305139 | Catacombs, Relates to Necromancer #1")]
    Catacombs_Relates_to_Necromancer_40 = 11305139,

    [AnnotationAttribute(Name = "11305140 | Catacombs, Relates to Necromancer #1")]
    Catacombs_Relates_to_Necromancer_41 = 11305140,

    [AnnotationAttribute(Name = "11305141 | Catacombs, Relates to Necromancer #1")]
    Catacombs_Relates_to_Necromancer_42 = 11305141,

    [AnnotationAttribute(Name = "11305144 | Catacombs, Relates to Necromancer #6")]
    Catacombs_Relates_to_Necromancer_43 = 11305144,

    [AnnotationAttribute(Name = "11305145 | Catacombs, Relates to Necromancer #6")]
    Catacombs_Relates_to_Necromancer_44 = 11305145,

    [AnnotationAttribute(Name = "11305146 | Catacombs, Relates to Necromancer #6")]
    Catacombs_Relates_to_Necromancer_45 = 11305146,

    [AnnotationAttribute(Name = "11305147 | Catacombs, Relates to Necromancer #6")]
    Catacombs_Relates_to_Necromancer_46 = 11305147,

    [AnnotationAttribute(Name = "11305148 | Catacombs, Relates to Necromancer #6")]
    Catacombs_Relates_to_Necromancer_47 = 11305148,

    [AnnotationAttribute(Name = "11305149 | Catacombs, Relates to Necromancer #6")]
    Catacombs_Relates_to_Necromancer_48 = 11305149,

    [AnnotationAttribute(Name = "11305150 | Catacombs, Relates to Necromancer #6")]
    Catacombs_Relates_to_Necromancer_49 = 11305150,

    [AnnotationAttribute(Name = "11305210 | Catacombs, Wisp")]
    Catacombs_Wisp = 11305210,

    [AnnotationAttribute(Name = "11305211 | Catacombs, Wisp")]
    Catacombs_Wisp_1 = 11305211,

    [AnnotationAttribute(Name = "11305212 | Catacombs, Wisp")]
    Catacombs_Wisp_2 = 11305212,

    [AnnotationAttribute(Name = "11305213 | Catacombs, Wisp")]
    Catacombs_Wisp_3 = 11305213,

    [AnnotationAttribute(Name = "11305214 | Catacombs, Wisp")]
    Catacombs_Wisp_4 = 11305214,

    [AnnotationAttribute(Name = "11305215 | Catacombs, Wisp")]
    Catacombs_Wisp_5 = 11305215,

    [AnnotationAttribute(Name = "11305216 | Catacombs, Wisp")]
    Catacombs_Wisp_6 = 11305216,

    [AnnotationAttribute(Name = "11305217 | Catacombs, Wisp")]
    Catacombs_Wisp_7 = 11305217,

    [AnnotationAttribute(Name = "11305218 | Catacombs, Wisp")]
    Catacombs_Wisp_8 = 11305218,

    [AnnotationAttribute(Name = "11305219 | Catacombs, Wisp")]
    Catacombs_Wisp_9 = 11305219,

    [AnnotationAttribute(Name = "11305223 | Catacombs, Wisp")]
    Catacombs_Wisp_10 = 11305223,

    [AnnotationAttribute(Name = "11310090 | Tomb of the Giants, Fog Gate")]
    Tomb_of_the_Giants_Fog_Gate = 11310090,

    [AnnotationAttribute(Name = "11310100 | Tomb of the Giants, Illusory Wall")]
    Tomb_of_the_Giants_Illusory_Wall = 11310100,

    [AnnotationAttribute(Name = "11310820 | Dead, Tomb of the Giants, Black Knight")]
    Dead_Tomb_of_the_Giants_Black_Knight = 11310820,

    [AnnotationAttribute(Name = "11315060 | Tomb of the Giants, Bone Tower in Pit")]
    Tomb_of_the_Giants_Bone_Tower_in_Pit = 11315060,

    [AnnotationAttribute(Name = "11315061 | Tomb of the Giants, Bone Tower in Pit")]
    Tomb_of_the_Giants_Bone_Tower_in_Pit_1 = 11315061,

    [AnnotationAttribute(Name = "11315062 | Tomb of the Giants, Bone Tower in Pit")]
    Tomb_of_the_Giants_Bone_Tower_in_Pit_2 = 11315062,

    [AnnotationAttribute(Name = "11315063 | Tomb of the Giants, Bone Tower in Pit")]
    Tomb_of_the_Giants_Bone_Tower_in_Pit_3 = 11315063,

    [AnnotationAttribute(Name = "11315070 | Tomb of the Giants, Bone Tower by Silver Serpent Ring")]
    Tomb_of_the_Giants_Bone_Tower_by_Silver_Serpent_Ring = 11315070,

    [AnnotationAttribute(Name = "11315071 | Tomb of the Giants, Bone Tower by Silver Serpent Ring")]
    Tomb_of_the_Giants_Bone_Tower_by_Silver_Serpent_Ring_1 = 11315071,

    [AnnotationAttribute(Name = "11315072 | Tomb of the Giants, Bone Tower by Silver Serpent Ring")]
    Tomb_of_the_Giants_Bone_Tower_by_Silver_Serpent_Ring_2 = 11315072,

    [AnnotationAttribute(Name = "11315073 | Tomb of the Giants, Bone Tower by Silver Serpent Ring")]
    Tomb_of_the_Giants_Bone_Tower_by_Silver_Serpent_Ring_3 = 11315073,

    [AnnotationAttribute(Name = "11315074 | Tomb of the Giants, Bone Tower by Silver Serpent Ring")]
    Tomb_of_the_Giants_Bone_Tower_by_Silver_Serpent_Ring_4 = 11315074,

    [AnnotationAttribute(Name = "11315390 | Gravelord Nito")]
    Gravelord_Nito_1 = 11315390,

    [AnnotationAttribute(Name = "11400000 | Quelaag, Cutscene triggered")]
    Quelaag_Cutscene_triggered = 11400000,

    [AnnotationAttribute(Name = "11400091 | Blighttown, Fog Gate")]
    Blighttown_Fog_Gate = 11400091,

    [AnnotationAttribute(Name = "11400200 | Rung the second bell, bell lever disabled")]
    Rung_the_second_bell_bell_lever_disabled = 11400200,

    [AnnotationAttribute(Name = "11400850 | Dead, Blighttown, Blowdart Sniper")]
    Dead_Blighttown_Blowdart_Sniper = 11400850,

    [AnnotationAttribute(Name = "11400851 | Dead, Blighttown, Blowdart Sniper")]
    Dead_Blighttown_Blowdart_Sniper_1 = 11400851,

    [AnnotationAttribute(Name = "11400853 | Dead, Blighttown, Blowdart Sniper")]
    Dead_Blighttown_Blowdart_Sniper_2 = 11400853,

    [AnnotationAttribute(Name = "11400854 | Dead, Blighttown, Blowdart Sniper.")]
    Dead_Blighttown_Blowdart_Sniper_3 = 11400854,

    [AnnotationAttribute(Name = "11400855 | Dead, Blighttown, Blowdart Sniper")]
    Dead_Blighttown_Blowdart_Sniper_4 = 11400855,

    [AnnotationAttribute(Name = "11400856 | Dead, Blighttown, Blowdart Sniper")]
    Dead_Blighttown_Blowdart_Sniper_5 = 11400856,

    [AnnotationAttribute(Name = "11400857 | Dead, Blighttown, Blowdart Sniper")]
    Dead_Blighttown_Blowdart_Sniper_6 = 11400857,

    [AnnotationAttribute(Name = "11400858 | Dead, Blighttown, Blowdart Sniper")]
    Dead_Blighttown_Blowdart_Sniper_7 = 11400858,

    [AnnotationAttribute(Name = "11405394 | Chaos Witch Quelaag")]
    Chaos_Witch_Quelaag_1 = 11405394,

    [AnnotationAttribute(Name = "11410106 | Dead, Lost Izalith, Daughter of Chaos")]
    Dead_Lost_Izalith_Daughter_of_Chaos = 11410106,

    [AnnotationAttribute(Name = "11410340 | Lost Izalith, Shortcut to Demon Ruins")]
    Lost_Izalith_Shortcut_to_Demon_Ruins = 11410340,

    [AnnotationAttribute(Name = "11410401 | Demon Ruins, Elevator to Quelaag's Domain")]
    Demon_Ruins_Elevator_to_Quelaags_Domain = 11410401,

    [AnnotationAttribute(Name = "11410410 | Boss Defeated, Demon Firesage")]
    Boss_Defeated_Demon_Firesage = 11410410,

    [AnnotationAttribute(Name = "11410533 | Lost Izalith, After Talking to Rescued Solaire?")]
    Lost_Izalith_After_Talking_to_Rescued_Solaire = 11410533,

    [AnnotationAttribute(Name = "11410801 | Demon Ruins, Lava Drained")]
    Demon_Ruins_Lava_Drained = 11410801,

    [AnnotationAttribute(Name = "11410900 | Boss Defeated, Ceaseless Discharge")]
    Boss_Defeated_Ceaseless_Discharge = 11410900,

    [AnnotationAttribute(Name = "11410901 | Boss Defeated, Centipede Demon")]
    Boss_Defeated_Centipede_Demon = 11410901,

    [AnnotationAttribute(Name = "11415382 | Centipede Demon")]
    Centipede_Demon = 11415382,

    [AnnotationAttribute(Name = "11415390 | Lost Izalith, Enter Bed of Chaos Fog Gate")]
    Lost_Izalith_Enter_Bed_of_Chaos_Fog_Gate = 11415390,

    [AnnotationAttribute(Name = "11500090 | Sen's Fortress, Fog Gate 1")]
    Sens_Fortress_Fog_Gate_1 = 11500090,

    [AnnotationAttribute(Name = "11500091 | Sen's Fortress, Pre-Bonfire fog gate")]
    Sens_Fortress_PreBonfire_fog_gate = 11500091,

    [AnnotationAttribute(Name = "11500100 | Sen's Fortress, exited Cage Elevator")]
    Sens_Fortress_exited_Cage_Elevator = 11500100,

    [AnnotationAttribute(Name = "11500101 | Sen's Fortress, Cage Elevator")]
    Sens_Fortress_Cage_Elevator = 11500101,

    [AnnotationAttribute(Name = "11500102 | Sen's Fortress, Cage Elevator open")]
    Sens_Fortress_Cage_Elevator_open = 11500102,

    [AnnotationAttribute(Name = "11500105 | Sen's Fortress, Shortcut door at Hush")]
    Sens_Fortress_Shortcut_door_at_Hush = 11500105,

    [AnnotationAttribute(Name = "11500110 | Sen's Fortress, Empty Cage #2 open")]
    Sens_Fortress_Empty_Cage_2_open = 11500110,

    [AnnotationAttribute(Name = "11500111 | Sen's Fortress, Empty Cage #3 open")]
    Sens_Fortress_Empty_Cage_3_open = 11500111,

    [AnnotationAttribute(Name = "11500112 | Sen's Fortress, Big Hat Logan Cage open")]
    Sens_Fortress_Big_Hat_Logan_Cage_open = 11500112,

    [AnnotationAttribute(Name = "11500113 | Sen's Fortress, Empty Cage #4 open")]
    Sens_Fortress_Empty_Cage_4_open = 11500113,

    [AnnotationAttribute(Name = "11500115 | Sen's Fortress, Empty Cage #1 open")]
    Sens_Fortress_Empty_Cage_1_open = 11500115,

    [AnnotationAttribute(Name = "11500116 | Sen's Fortress, Soul of a Hero Cage open")]
    Sens_Fortress_Soul_of_a_Hero_Cage_open = 11500116,

    [AnnotationAttribute(Name = "11500200 | Sen's Fortress is opened")]
    Sens_Fortress_is_opened = 11500200,

    [AnnotationAttribute(Name = "11500602 | Sen's Fortress, 2x Large Titanite Shard chest opened")]
    Sens_Fortress_2x_Large_Titanite_Shard_chest_opened = 11500602,

    [AnnotationAttribute(Name = "11500604 | Sen's Fortress, Divine Blessing chest opened")]
    Sens_Fortress_Divine_Blessing_chest_opened = 11500604,

    [AnnotationAttribute(Name = "11500609 | Sen's Fortress, Flame Stoneplate Ring chest opened")]
    Sens_Fortress_Flame_Stoneplate_Ring_chest_opened = 11500609,

    [AnnotationAttribute(Name = "11500610 | Sen's Fortress, Rare Ring of Sacrifice chest opened")]
    Sens_Fortress_Rare_Ring_of_Sacrifice_chest_opened = 11500610,

    [AnnotationAttribute(Name = "11500710 | Sen's Fortess, Unknown (Boulder Trap?)")]
    Sens_Fortess_Unknown_Boulder_Trap = 11500710,

    [AnnotationAttribute(Name = "11500711 | Sen's Fortess, Unknown (Boulder Trap?)")]
    Sens_Fortess_Unknown_Boulder_Trap_1 = 11500711,

    [AnnotationAttribute(Name = "11500790 | Sen's Fortess, Unknown (Boulder Trap?)")]
    Sens_Fortess_Unknown_Boulder_Trap_2 = 11500790,

    [AnnotationAttribute(Name = "11500795 | Sen's Fortess, Unknown (Boulder Trap?)")]
    Sens_Fortess_Unknown_Boulder_Trap_3 = 11500795,

    [AnnotationAttribute(Name = "11500796 | Sen's Fortess, Unknown (Boulder Trap?)")]
    Sens_Fortess_Unknown_Boulder_Trap_4 = 11500796,

    [AnnotationAttribute(Name = "11500803 | Sen's Fortess, Boulder Lever (Facing Exterior Path?)")]
    Sens_Fortess_Boulder_Lever_Facing_Exterior_Path = 11500803,

    [AnnotationAttribute(Name = "11500806 | Sen's Fortress, Boulder Lever (Facing Path to Logan?)")]
    Sens_Fortress_Boulder_Lever_Facing_Path_to_Logan = 11500806,

    [AnnotationAttribute(Name = "11500809 | Sen's Fortess, Boulder Lever (Facing Interoir Path?)")]
    Sens_Fortess_Boulder_Lever_Facing_Interoir_Path = 11500809,

    [AnnotationAttribute(Name = "11500812 | Sen's Fortess, Boulder Lever (Facing Safe Drop?)")]
    Sens_Fortess_Boulder_Lever_Facing_Safe_Drop = 11500812,

    [AnnotationAttribute(Name = "11500850 | Sen's Fortress, Boulder Lever (Operable?)")]
    Sens_Fortress_Boulder_Lever_Operable = 11500850,

    [AnnotationAttribute(Name = "11500860 | Dead, Sen's Fortress, Undead Prince Ricard")]
    Dead_Sens_Fortress_Undead_Prince_Ricard = 11500860,

    [AnnotationAttribute(Name = "11500861 | Dead, Sen's Fortress, Prowling Demon #4")]
    Dead_Sens_Fortress_Prowling_Demon_4 = 11500861,

    [AnnotationAttribute(Name = "11500862 | Dead, Sen's Fortress, Prowling Demon #3")]
    Dead_Sens_Fortress_Prowling_Demon_3 = 11500862,

    [AnnotationAttribute(Name = "11500863 | Dead, Sen's Fortress, Prowling Demon #2")]
    Dead_Sens_Fortress_Prowling_Demon_2 = 11500863,

    [AnnotationAttribute(Name = "11500864 | Dead, Sen's Fortress, Prowling Demon #1")]
    Dead_Sens_Fortress_Prowling_Demon_1 = 11500864,

    [AnnotationAttribute(Name = "11500865 | Dead, Sen's Fortress, Bomb-Tossing Giant")]
    Dead_Sens_Fortress_BombTossing_Giant = 11500865,

    [AnnotationAttribute(Name = "11500867 | Dead, Sen's Fortress, Chain-Pulling Giant")]
    Dead_Sens_Fortress_ChainPulling_Giant = 11500867,

    [AnnotationAttribute(Name = "11505052 | Sen's Fortess, Unknown (Boulder Trap?)")]
    Sens_Fortess_Unknown_Boulder_Trap_5 = 11505052,

    [AnnotationAttribute(Name = "11505210 | Sen's Fortess, Unknown (Boulder Trap?)")]
    Sens_Fortess_Unknown_Boulder_Trap_6 = 11505210,

    [AnnotationAttribute(Name = "11505211 | Sen's Fortess, Unknown (Boulder Trap?)")]
    Sens_Fortess_Unknown_Boulder_Trap_7 = 11505211,

    [AnnotationAttribute(Name = "11505220 | Sen's Fortess, Unknown (Boulder Trap?)")]
    Sens_Fortess_Unknown_Boulder_Trap_8 = 11505220,

    [AnnotationAttribute(Name = "11505221 | Sen's Fortess, Unknown (Boulder Trap?)")]
    Sens_Fortess_Unknown_Boulder_Trap_9 = 11505221,

    [AnnotationAttribute(Name = "11505250 | Sen's Fortress, Boulder Lever (Being Operated?)")]
    Sens_Fortress_Boulder_Lever_Being_Operated = 11505250,

    [AnnotationAttribute(Name = "11505280 | Sen's Fortress, First Arrow Trap")]
    Sens_Fortress_First_Arrow_Trap = 11505280,

    [AnnotationAttribute(Name = "11505281 | Sen's Fortess, Second Arrow Trap")]
    Sens_Fortess_Second_Arrow_Trap = 11505281,

    [AnnotationAttribute(Name = "11505282 | Sen's Fortress, Third Arrow Trap")]
    Sens_Fortress_Third_Arrow_Trap = 11505282,

    [AnnotationAttribute(Name = "11505283 | Sen's Fortress, Arrow Trap #4 fired")]
    Sens_Fortress_Arrow_Trap_4_fired = 11505283,

    [AnnotationAttribute(Name = "11505284 | Sen's Fortess, Fourth Arrow Trap")]
    Sens_Fortess_Fourth_Arrow_Trap = 11505284,

    [AnnotationAttribute(Name = "11505285 | Sen's Fortress, Arrow Trap #5 fired")]
    Sens_Fortress_Arrow_Trap_5_fired = 11505285,

    [AnnotationAttribute(Name = "11505394 | Iron Golem")]
    Iron_Golem_1 = 11505394,

    [AnnotationAttribute(Name = "11510090 | Foggate after Rafters")]
    Foggate_after_Rafters = 11510090,

    [AnnotationAttribute(Name = "11510091 | Foggate after Silver Knight Archers")]
    Foggate_after_Silver_Knight_Archers = 11510091,

    [AnnotationAttribute(Name = "11510100 | Anor Londo, Giant Chandelier")]
    Anor_Londo_Giant_Chandelier = 11510100,

    [AnnotationAttribute(Name = "11510110 | Gwynevere Door opened")]
    Gwynevere_Door_opened = 11510110,

    [AnnotationAttribute(Name = "11510120 | Allows Darkmoon invasions in Dark AL. Is set to 1 twice a second while in MP-Zones in Dark AL with Gwyndolin alive")]
    Allows_Darkmoon_invasions_in_Dark_AL_Is_set_to_1_twice_a_second_while_in_MPZones_in_Dark_AL_with_Gwyndolin_alive = 11510120,

    [AnnotationAttribute(Name = "11510200 | Anor Londo, Large Doorway to Main Hall")]
    Anor_Londo_Large_Doorway_to_Main_Hall = 11510200,

    [AnnotationAttribute(Name = "11510210 | Anor Londo, Shortcut Door to Giant Blacksmith")]
    Anor_Londo_Shortcut_Door_to_Giant_Blacksmith = 11510210,

    [AnnotationAttribute(Name = "11510220 | Anor Londo Elevator activated")]
    Anor_Londo_Elevator_activated = 11510220,

    [AnnotationAttribute(Name = "11510230 | Display 'Contraption does not move' on Painted World painting")]
    Display_Contraption_does_not_move_on_Painted_World_painting = 11510230,

    [AnnotationAttribute(Name = "11510251 | Anor Londo, Shortcut Door to Solaire Bonfire")]
    Anor_Londo_Shortcut_Door_to_Solaire_Bonfire = 11510251,

    [AnnotationAttribute(Name = "11510257 | Anor Londo, second shotcut door in cathedral")]
    Anor_Londo_second_shotcut_door_in_cathedral = 11510257,

    [AnnotationAttribute(Name = "11510272 | Dark Anor Londo")]
    Dark_Anor_Londo = 11510272,

    [AnnotationAttribute(Name = "11510304 | Disables Backstab on Staircase Elevator?")]
    Disables_Backstab_on_Staircase_Elevator = 11510304,

    [AnnotationAttribute(Name = "11510310 | Display 'Contraption does not move' on AL Staircase Elevator levers")]
    Display_Contraption_does_not_move_on_AL_Staircase_Elevator_levers = 11510310,

    [AnnotationAttribute(Name = "11510319 | Moved off AL Staircase Elevator")]
    Moved_off_AL_Staircase_Elevator = 11510319,

    [AnnotationAttribute(Name = "11510340 | Started moving staircase elevator")]
    Started_moving_staircase_elevator = 11510340,

    [AnnotationAttribute(Name = "11510400 | Dark Anor Londo Active")]
    Dark_Anor_Londo_Active = 11510400,

    [AnnotationAttribute(Name = "11510521 | Set on Darkmoon Knightess dead")]
    Set_on_Darkmoon_Knightess_dead = 11510521,

    [AnnotationAttribute(Name = "11510592 | Receive Lordvessel With Gwynevere Still Alive")]
    Receive_Lordvessel_With_Gwynevere_Still_Alive = 11510592,

    [AnnotationAttribute(Name = "11510601 | Chest at beginning of AL with Demon Titanite opened")]
    Chest_at_beginning_of_AL_with_Demon_Titanite_opened = 11510601,

    [AnnotationAttribute(Name = "11510615 | Anor Londo, Empty chest opened")]
    Anor_Londo_Empty_chest_opened = 11510615,

    [AnnotationAttribute(Name = "11510616 | Anor Londo, Brass set chest opened")]
    Anor_Londo_Brass_set_chest_opened = 11510616,

    [AnnotationAttribute(Name = "11510617 | Anor Londo, Twinkling Titanite chest opened")]
    Anor_Londo_Twinkling_Titanite_chest_opened = 11510617,

    [AnnotationAttribute(Name = "11510618 | Anor Londo, Demon Titanite chest opened")]
    Anor_Londo_Demon_Titanite_chest_opened = 11510618,

    [AnnotationAttribute(Name = "11510851 | Dead, Anor Londo, First Mimic")]
    Dead_Anor_Londo_First_Mimic = 11510851,

    [AnnotationAttribute(Name = "11510863 | Dark AL Knight 2 dead")]
    Dark_AL_Knight_2_dead = 11510863,

    [AnnotationAttribute(Name = "11510864 | Dark AL Knight 1 dead")]
    Dark_AL_Knight_1_dead = 11510864,

    [AnnotationAttribute(Name = "11510900 | Boss Defeated, Gwyndolin")]
    Boss_Defeated_Gwyndolin = 11510900,

    [AnnotationAttribute(Name = "11515193 | Set when sitting down on Darkmoon Tomb bonfire 2")]
    Set_when_sitting_down_on_Darkmoon_Tomb_bonfire_2 = 11515193,

    [AnnotationAttribute(Name = "11515250 | First Painting Guardian triggered")]
    First_Painting_Guardian_triggered = 11515250,

    [AnnotationAttribute(Name = "11515300 | AL Staircase Elevator is moving")]
    AL_Staircase_Elevator_is_moving = 11515300,

    [AnnotationAttribute(Name = "11515383 | Gwyndolin cutscene")]
    Gwyndolin_cutscene = 11515383,

    [AnnotationAttribute(Name = "11515386 | Gwyndolin cutscene")]
    Gwyndolin_cutscene_1 = 11515386,

    [AnnotationAttribute(Name = "11515392 | Rest at Darkmoon Tomb/Entering O&S fight")]
    Rest_at_Darkmoon_TombEntering_OS_fight = 11515392,

    [AnnotationAttribute(Name = "11515394 | Dragonslayer Ornstein & Executioner Smough")]
    Dragonslayer_Ornstein__Executioner_Smough_1 = 11515394,

    [AnnotationAttribute(Name = "11515399 | Rest at Chamber of Princess")]
    Rest_at_Chamber_of_Princess = 11515399,

    [AnnotationAttribute(Name = "11600100 | New Londo Ruins, Drained")]
    New_Londo_Ruins_Drained = 11600100,

    [AnnotationAttribute(Name = "11600110 | New Londo Ruins, Door to the Seal")]
    New_Londo_Ruins_Door_to_the_Seal = 11600110,

    [AnnotationAttribute(Name = "11600120 | New Londo Ruins, Valley of Drakes Door")]
    New_Londo_Ruins_Valley_of_Drakes_Door = 11600120,

    [AnnotationAttribute(Name = "11600160 | New Londo Ruins, Shortcut Ladder")]
    New_Londo_Ruins_Shortcut_Ladder = 11600160,

    [AnnotationAttribute(Name = "11600200 | New Londo Ruins, Seal Opened")]
    New_Londo_Ruins_Seal_Opened = 11600200,

    [AnnotationAttribute(Name = "11600201 | New Londo Ruins, Elevator to Firelink")]
    New_Londo_Ruins_Elevator_to_Firelink = 11600201,

    [AnnotationAttribute(Name = "11600231 | Valley of Drakes, Elevator to Darkroot")]
    Valley_of_Drakes_Elevator_to_Darkroot = 11600231,

    [AnnotationAttribute(Name = "11600251 | Display 'Contraption does not move' on first New Londo Lever")]
    Display_Contraption_does_not_move_on_first_New_Londo_Lever = 11600251,

    [AnnotationAttribute(Name = "11600252 | Display 'Contraption does not move' at Seal New Londo Lever")]
    Display_Contraption_does_not_move_at_Seal_New_Londo_Lever = 11600252,

    [AnnotationAttribute(Name = "11600592 | Obtained, Key to the Seal")]
    Obtained_Key_to_the_Seal = 11600592,

    [AnnotationAttribute(Name = "11600602 | Chest behind illusory wall in New Londo opened")]
    Chest_behind_illusory_wall_in_New_Londo_opened = 11600602,

    [AnnotationAttribute(Name = "11600650 | New Londo, Estoc-carrying Corpse Collapsed")]
    New_Londo_Estoccarrying_Corpse_Collapsed = 11600650,

    [AnnotationAttribute(Name = "11605123 | Valley of Drakes, Elevator to Darkroot Inoperable")]
    Valley_of_Drakes_Elevator_to_Darkroot_Inoperable = 11605123,

    [AnnotationAttribute(Name = "11605177 | Set every 5 seconds while New Londo is in the loading queue")]
    Set_every_5_seconds_while_New_Londo_is_in_the_loading_queue = 11605177,

    [AnnotationAttribute(Name = "11700001 | Set shortly after Seath defeated")]
    Set_shortly_after_Seath_defeated = 11700001,

    [AnnotationAttribute(Name = "11700083 | Duke's Archives, Fog Gate")]
    Dukes_Archives_Fog_Gate = 11700083,

    [AnnotationAttribute(Name = "11700110 | Duke's Archives, small staircase before garden")]
    Dukes_Archives_small_staircase_before_garden = 11700110,

    [AnnotationAttribute(Name = "11700120 | Duke's Archives, Bookshelf Door")]
    Dukes_Archives_Bookshelf_Door = 11700120,

    [AnnotationAttribute(Name = "11700125 | Opens the shortcut shelf between first and second hall of Duke's after killing Seath (this is the ID for the shortcut shelf!)")]
    Opens_the_shortcut_shelf_between_first_and_second_hall_of_Dukes_after_killing_Seath_this_is_the_ID_for_the_shortcut_shelf = 11700125,

    [AnnotationAttribute(Name = "11700140 | Opens the big door to the Prison Area after killing Seath")]
    Opens_the_big_door_to_the_Prison_Area_after_killing_Seath = 11700140,

    [AnnotationAttribute(Name = "11700300 | Duke's Archives, Archive Tower Cell Door")]
    Dukes_Archives_Archive_Tower_Cell_Door = 11700300,

    [AnnotationAttribute(Name = "11700301 | Duke's Archives, Prison Extra Key Cell Door #4")]
    Dukes_Archives_Prison_Extra_Key_Cell_Door_4 = 11700301,

    [AnnotationAttribute(Name = "11700302 | Duke's Archives, Prison Extra Key Cell Door #1")]
    Dukes_Archives_Prison_Extra_Key_Cell_Door_1 = 11700302,

    [AnnotationAttribute(Name = "11700303 | Duke's Archives, Prison Extra Key Cell Door #2")]
    Dukes_Archives_Prison_Extra_Key_Cell_Door_2 = 11700303,

    [AnnotationAttribute(Name = "11700304 | Duke's Archives, Prison Extra Key Cell Door #3")]
    Dukes_Archives_Prison_Extra_Key_Cell_Door_3 = 11700304,

    [AnnotationAttribute(Name = "11700305 | Duke's Archives, Normal Cell Door #2")]
    Dukes_Archives_Normal_Cell_Door_2 = 11700305,

    [AnnotationAttribute(Name = "11700306 | Duke's Archives, Archive Tower Giant Cell?")]
    Dukes_Archives_Archive_Tower_Giant_Cell = 11700306,

    [AnnotationAttribute(Name = "11700320 | Duke's Archives, Archive Tower Giant Cell?")]
    Dukes_Archives_Archive_Tower_Giant_Cell_1 = 11700320,

    [AnnotationAttribute(Name = "11700700 | Received Broken Pendant")]
    Received_Broken_Pendant = 11700700,

    [AnnotationAttribute(Name = "11700810 | Dead, The Duke's Archives, Crystal General")]
    Dead_The_Dukes_Archives_Crystal_General = 11700810,

    [AnnotationAttribute(Name = "11700811 | Dead, The Duke's Archives, Crystal Lizard first Seath encounter")]
    Dead_The_Dukes_Archives_Crystal_Lizard_first_Seath_encounter = 11700811,

    [AnnotationAttribute(Name = "11700815 | Dead, Duke's Archives, Boar #1")]
    Dead_Dukes_Archives_Boar_1 = 11700815,

    [AnnotationAttribute(Name = "11700816 | Dead, Duke's Archives, Boar #2")]
    Dead_Dukes_Archives_Boar_2 = 11700816,

    [AnnotationAttribute(Name = "11700822 | Duke's Archives, Crying Pisaca 1")]
    Dukes_Archives_Crying_Pisaca_1 = 11700822,

    [AnnotationAttribute(Name = "11700823 | Duke's Archives, Crying Pisaca 2")]
    Dukes_Archives_Crying_Pisaca_2 = 11700823,

    [AnnotationAttribute(Name = "11705090 | Duke's Archives, Second Lever")]
    Dukes_Archives_Second_Lever = 11705090,

    [AnnotationAttribute(Name = "11705091 | First Duke's Elevator is moving")]
    First_Dukes_Elevator_is_moving = 11705091,

    [AnnotationAttribute(Name = "11705394 | Seath")]
    Seath = 11705394,

    [AnnotationAttribute(Name = "11705395 | Set on Seath defeated")]
    Set_on_Seath_defeated_1 = 11705395,

    [AnnotationAttribute(Name = "11705396 | Seath is vulnerable")]
    Seath_is_vulnerable = 11705396,

    [AnnotationAttribute(Name = "11705397 | Seath HP hits 0")]
    Seath_HP_hits_0 = 11705397,

    [AnnotationAttribute(Name = "11800100 | Placed Lordvessel, makes golden foggates disappear")]
    Placed_Lordvessel_makes_golden_foggates_disappear = 11800100,

    [AnnotationAttribute(Name = "11800101 | Placed Lordvessel 2 ?")]
    Placed_Lordvessel_2_ = 11800101,

    [AnnotationAttribute(Name = "11805394 | Gwyn, Lord of Cinder")]
    Gwyn_Lord_of_Cinder_1 = 11805394,

    [AnnotationAttribute(Name = "11810090 | Undead Asylum, Pre-Oscar Fog Gate")]
    Undead_Asylum_PreOscar_Fog_Gate = 11810090,

    [AnnotationAttribute(Name = "11810103 | Undead Asylum, Cell Door")]
    Undead_Asylum_Cell_Door = 11810103,

    [AnnotationAttribute(Name = "11810104 | Undead Asylum, F2 West Door")]
    Undead_Asylum_F2_West_Door = 11810104,

    [AnnotationAttribute(Name = "11810105 | Undead Asylum, Shortcut Door")]
    Undead_Asylum_Shortcut_Door = 11810105,

    [AnnotationAttribute(Name = "11810106 | Undead Asylum, F2 East Door")]
    Undead_Asylum_F2_East_Door = 11810106,

    [AnnotationAttribute(Name = "11810110 | Undead Asylum, Big Pilgrim Door")]
    Undead_Asylum_Big_Pilgrim_Door = 11810110,

    [AnnotationAttribute(Name = "11810112 | Undead Asylum, Boss Door")]
    Undead_Asylum_Boss_Door = 11810112,

    [AnnotationAttribute(Name = "11810211 | Undead Asylum, Trap Sprung Near Oscar")]
    Undead_Asylum_Trap_Sprung_Near_Oscar = 11810211,

    [AnnotationAttribute(Name = "11810590 | Oscar, Gift Estus Flask")]
    Oscar_Gift_Estus_Flask = 11810590,

    [AnnotationAttribute(Name = "11810591 | Oscar, Gift Undead Asylum F2 East Key")]
    Oscar_Gift_Undead_Asylum_F2_East_Key = 11810591,

    [AnnotationAttribute(Name = "11810851 | Dead, Undead Asylum, Sword Black Knight #1")]
    Dead_Undead_Asylum_Sword_Black_Knight_1 = 11810851,

    [AnnotationAttribute(Name = "11810900 | Stray Demon")]
    Stray_Demon = 11810900,

    [AnnotationAttribute(Name = "11815010 | Resting at Firelink Shrine")]
    Resting_at_Firelink_Shrine_1 = 11815010,

    [AnnotationAttribute(Name = "11815392 | Resting at Firelink Shrine")]
    Resting_at_Firelink_Shrine_2 = 11815392,

    [AnnotationAttribute(Name = "50000010 | Tiny Being's Ring")]
    Tiny_Beings_Ring = 50000010,

    [AnnotationAttribute(Name = "50000070 | Speckled Stoneplate Ring (Looted or Given)")]
    Speckled_Stoneplate_Ring_Looted_or_Given = 50000070,

    [AnnotationAttribute(Name = "50000081 | Oscar, Don't gift Big Pilgrim Key")]
    Oscar_Dont_gift_Big_Pilgrim_Key = 50000081,

    [AnnotationAttribute(Name = "50000090 | Receive Lordvessel (Gwynevere Alive or Dead)")]
    Receive_Lordvessel_Gwynevere_Alive_or_Dead = 50000090,

    [AnnotationAttribute(Name = "51020130 | Firelink Shrine, Ring of Sacrifice")]
    Firelink_Shrine_Ring_of_Sacrifice = 51020130,

    [AnnotationAttribute(Name = "51200200 | Darkroot Basin, Grass Crest Shield")]
    Darkroot_Basin_Grass_Crest_Shield = 51200200,

    [AnnotationAttribute(Name = "51300020 | Catacombs, Darkmoon Seance Ring")]
    Catacombs_Darkmoon_Seance_Ring = 51300020,

    [AnnotationAttribute(Name = "51310140 | Tomb of the Giants, Covetous Silver Serpent Ring")]
    Tomb_of_the_Giants_Covetous_Silver_Serpent_Ring = 51310140,

    [AnnotationAttribute(Name = "51510560 | Anor Londo, Dragon Tooth")]
    Anor_Londo_Dragon_Tooth = 51510560,

    [AnnotationAttribute(Name = "51510940 | Anor Londo, Blacksmith Giant Hammer")]
    Anor_Londo_Blacksmith_Giant_Hammer = 51510940,

    [AnnotationAttribute(Name = "51600380 | Valley of the Drakes, Red Tearstone Ring")]
    Valley_of_the_Drakes_Red_Tearstone_Ring = 51600380,

    [AnnotationAttribute(Name = "51810060 | Northern Undead Asylum, Rusted Iron Ring")]
    Northern_Undead_Asylum_Rusted_Iron_Ring = 51810060,

    [AnnotationAttribute(Name = "51810080 | Northern Undead Asylum, Peculiar Doll")]
    Northern_Undead_Asylum_Peculiar_Doll = 51810080,

    [AnnotationAttribute(Name = "61200500 | Darkroot Garden, Crest of Artorias Door")]
    Darkroot_Garden_Crest_of_Artorias_Door = 61200500,

    [AnnotationAttribute(Name = "61200501 | ? on Touched Sif's Gate")]
    A_on_Touched_Sifs_Gate_1 = 61200501,

    [AnnotationAttribute(Name = "71010000 | Andre, Talk To For First Time")]
    Andre_Talk_To_For_First_Time = 71010000,

    [AnnotationAttribute(Name = "71500001 | Crestfallen Merchant, Talk To For First Time")]
    Crestfallen_Merchant_Talk_To_For_First_Time = 71500001,

    [AnnotationAttribute(Name = "71510000 | Blacksmith Giant, Talk To For First Time")]
    Blacksmith_Giant_Talk_To_For_First_Time = 71510000,

    [AnnotationAttribute(Name = "103249371 | Set when sitting down on Darkmoon Tomb bonfire 1")]
    Set_when_sitting_down_on_Darkmoon_Tomb_bonfire_1 = 103249371,
    }

}
