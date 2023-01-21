# SoulMemory

[![build](https://img.shields.io/github/actions/workflow/status/FrankvdStam/SoulSplitter/build.yml?branch=main)](https://github.com/FrankvdStam/SoulSplitter/actions) 
[![releases](https://img.shields.io/github/v/release/FrankvdStam/SoulSplitter)](https://github.com/FrankvdStam/SoulSplitter/releases) [![NuGet version (SoulMemory)](https://img.shields.io/nuget/v/SoulMemory)](https://www.nuget.org/packages/SoulMemory/)  
[![youtube](https://img.shields.io/badge/buy%20me%20a%20coffee-donate-yellow.svg)](https://ko-fi.com/wasted1) [![discord](https://img.shields.io/badge/-Discord-blue)](https://discord.com/users/281116269921566721) [![youtube](https://img.shields.io/badge/-YouTube-red)](https://www.youtube.com/@1wasted)

Backing library of [SoulSplitter](https://github.com/FrankvdStam/SoulSplitter).

This library provides an API that lets you read/write from/to running fromsoft games (Dark Soul 1, Dark Souls 2, Dark Souls 3, Sekiro: Shadows die twice and Elden Ring). It uses the Win32 API to achieve this. It is build mainly with speedrunning in mind, and focuses on timer and autosplitter features.

## Example usage

```C#
var ds1 = new DarkSouls1(); //Automatically resolves differences between PTDE & Remastered. Same applies to DarkSouls2

while (true)
{
    if (!ds1.TryRefresh(out Exception e)) //Each game object must be refreshed often, best would be 60 times per second.
    {
        //TODO: handle error
    }

    var inGameTime = ds1.GetInGameTimeMilliseconds(); //Get the amount of milliseconds played on the current character
    var isAsylumDemonAlive = ds1.ReadEventFlag((uint)DarkSouls1.Boss.AsylumDemon); //Read an arbitrary event flag, in this case the boss defeated flag for asylum demon
    var inventory = ds1.GetInventory(); //Read all items in the players inventory

    Thread.Sleep(10);
}
```


## API

#### DarkSouls1 (PTDE & remastered)
```C#
bool ReadEventFlag(uint eventFlagId);                //Read any event flag (more info about event flags on the wiki: https://github.com/FrankvdStam/SoulSplitter/wiki/Eventflags)
int GetAttribute(Attribute attribute);               //Read an attribute (one of the player's levels)
bool IsWarpRequested();                              //True if a loading screen is visible, and a warp was requested via a bonfire, homeward bone, darksign or homeward miracle
bool IsPlayerLoaded();                               //True if the player object is loaded in memory
int GetInGameTimeMilliseconds();                     //Returns the amount of milliseconds played on the current savefile. Returns 0 in the main menu
int NgCount();                                       //Returns what the current NG+ cycle is
int GetCurrentSaveSlot();                            //Returns what the current, or last loaded save slot is
Vector3f GetPosition();                              //Returns the players position in a vector of 3 floats
bool AreCreditsRolling();                            //Returns true if the credits are rolling
void ResetInventoryIndices();                        //Overwrites a number of in-game indices (current selected inventory slot for instance)
List<Item> GetInventory();                           //Returns a list of items, read from the players inventory
BonfireState GetBonfireState(Bonfire bonfire);       //Returns the state of a bonfire
string GetSaveFileLocation();                        //Attempts to find the path to the savefile, depending on locale

bool TryRefresh(out Exception exception);            //Refresh the internal structures, make sure the game is still running, etc. Must be called often for reliable return values
TreeBuilder GetTreeBuilder();                        //Returns a structure representing memory addresses, pointers and offsets. Can be used to resolve said pointers, or verified against a file. You likely won't need this, unless you want to extend the object
```

#### DarkSouls2 (Vanilla & SOTFS)
```C#
bool Refresh(out Exception exception);               //Refresh the internal structures, make sure the game is still running, etc. Must be called often for reliable return values
Vector3f GetPosition();                              //Returns the players position in a vector of 3 floats
int GetBossKillCount(BossType bossType);             //Returns a value representing the current NG+ cycle plus the amount of boss kills on this cycle. If you kill last giant once on ng, it will return 1. Kill him twice, it will retun 2. Kill him 0 times on ng+, it will return 1.
int GetAttribute(Attribute attribute);               //Read an attribute (one of the player's levels)
bool IsLoading();                                    //Returns true when a loading screen is visible
bool ReadEventFlag(uint eventFlagId);                //WARNING: not finished, will return garbage data. Event flags are weird in DS2.
```


#### DarkSouls3
```C#
bool Refresh();                                      //Refresh the internal structures, make sure the game is still running, etc. Must be called often for reliable return values
bool IsLoading();                                    //Returns true when a loading screen is visible
bool IsPlayerLoaded();                               //Returns true when the player object is loaded into memory
int GetInGameTimeMilliseconds();                     //Returns the amount of milliseconds played on the current savefile. Returns 0 in the main menu
void WriteInGameTimeMilliseconds(int millis);        //Overwrite the game's in game time with a new value (used in blackscreen removal to create the illusion of a paused timer)
Vector3f GetPosition();                              //Returns the players position in a vector of 3 floats
int ReadAttribute(Attribute attribute);              //Read an attribute (one of the player's levels)
bool ReadEventFlag(uint eventFlagId);                //Read any event flag (more info about event flags on the wiki: https://github.com/FrankvdStam/SoulSplitter/wiki/Eventflags)
bool BlackscreenActive()                             //Reads a combination of flags in memory to determine of a blackscreen is active
```


#### Sekiro

Refeshing Sekiro will install nologo and notutorial mods into the game. Additionally it installs a fix to the imprecise in game time.

```C#
bool Refresh(out Exception exception);               //Refresh the internal structures, make sure the game is still running, etc. Must be called often for reliable return values
int GetInGameTimeMilliseconds();                     //Returns the amount of milliseconds played on the current savefile. Returns 0 in the main menu
void WriteInGameTimeMilliseconds(int value);         //Overwrite the game's in game time with a new value (used in blackscreen removal to create the illusion of a paused timer)
bool IsPlayerLoaded();                               //Returns true when the player object is loaded into memory
Vector3f GetPlayerPosition();                        //Returns the players position in a vector of 3 floats
bool IsBlackscreenActive();                          //Reads a combination of flags in memory to determine of a blackscreen is active
bool ReadEventFlag(uint eventFlagId);                //Read any event flag (more info about event flags on the wiki: https://github.com/FrankvdStam/SoulSplitter/wiki/Eventflags)
```


#### EldenRing

Refreshing Elden Ring will install a fix to the imprecise in game timer

```C#
bool Refresh(out Exception exception);               //Refresh the internal structures, make sure the game is still running, etc. Must be called often for reliable return values
void EnableHud();                                    //The HUD can be on disabled or on "auto". This function sets it to always on.
Position GetPosition();                              //Returns the players position in a vector of 3 floats + the ID's of the current tile
bool IsPlayerLoaded();                               //Returns true if the player object is loaded into memory
ScreenState GetScreenState();                        //Returns the current "screenstate", can be InGame/Loading/MainMenu/Unknown
bool IsBlackscreenActive();                          //Reads a combination of flags in memory to determine of a blackscreen is active
List<Item> ReadInventory();                          //Reads the player's inventory. A part of the inventory seems stored in event flags (especially key-items) so be warned: some things might not be in this list
bool ReadEventFlag(uint flagId);                     //Read any event flag (more info about event flags on the wiki: https://github.com/FrankvdStam/SoulSplitter/wiki/Eventflags)
int GetInGameTimeMilliseconds();                     //Returns the amount of milliseconds played on the current savefile. Returns 0 in the main menu
void WriteInGameTimeMilliseconds(int milliseconds);  //Overwrite the game's in game time with a new value (used in blackscreen removal to create the illusion of a paused timer)
void ResetIgt();                                     //Overwrite the game's in game time with 0 (used to prepare NG+ save files)
```
