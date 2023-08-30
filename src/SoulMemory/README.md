<h1 align="center">
  <br>
  <img src="../../resources/soulsplitter.png" width="350"/><br>
  SoulMemory
  <br>
</h1>

<h4 align="center">Backing library of <a href="https://github.com/FrankvdStam/SoulSplitter">SoulSplitter</a></h4>

<p align="center">
  <a href="#example-usage">Usage</a> •
  <a href="#api">Api</a> •
  <a href="https://github.com/FrankvdStam/SoulSplitter#credits">Credits</a> •
  <a href="https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE">License</a>
</p>

<p align="center">
    <a href="https://github.com/FrankvdStam/SoulSplitter/actions">
        <img src="https://img.shields.io/github/actions/workflow/status/FrankvdStam/SoulSplitter/build.yml?branch=main"/>
    </a>
    <a href="http://wastedbox.nl:9000/dashboard?id=FrankvdStam_SoulSplitter_AYT9tJW7QlZ0fhD27xsa">
        <img src="http://wastedbox.nl:9000/api/project_badges/measure?project=FrankvdStam_SoulSplitter_AYT9tJW7QlZ0fhD27xsa&metric=alert_status&token=dcf5066558434982e851acb72b72235195d99b6e"/>
    </a>
    <a href="https://www.nuget.org/packages/SoulMemory/">
        <img src="https://img.shields.io/nuget/v/SoulMemory"/>
    </a>
    <br/>
    <a href="https://www.youtube.com/@1wasted">
        <img src="https://img.shields.io/badge/-YouTube-red"/>
    </a>
    <a href="https://ko-fi.com/wasted1">
        <img src="https://img.shields.io/badge/buy%20me%20a%20coffee-donate-yellow.svg"/>
    </a>    
    <a href="https://discord.com/users/281116269921566721">
        <img src="https://img.shields.io/badge/-Discord-blue"/>
    </a>
</p>

This library provides an API that lets you read/write from/to running fromsoft games (Dark Soul 1, Dark Souls 2, Dark Souls 3, Sekiro: Shadows die twice and Elden Ring). It uses the Win32 API to achieve this. It is build mainly with speedrunning in mind and focuses on timer and autosplitter features.

## Example usage

```C#
var ds1 = new DarkSouls1(); //Automatically resolves differences between PTDE & Remastered. Same applies to the DarkSouls2 object

while (true)
{
    var refreshResult = ds1.TryRefresh(); //Refresh this IGame object often - every frame or 60 times per second if possible
    if(refreshResult.IsErr)
    {
        var refreshError = refreshResult.GetErr();
        Console.WriteLine($"{refreshError.Reason} {refreshError.Message} {refreshError.Exception?.ToString() ?? ""}");
        Thread.Sleep(3000);
    }
    else
    {
        var inGameTime = ds1.GetInGameTimeMilliseconds(); //Get the amount of milliseconds played on the current character
        var isAsylumDemonAlive = ds1.ReadEventFlag((uint)SoulMemory.DarkSouls1.Boss.AsylumDemon); //Read an arbitrary event flag, in this case the boss defeated flag for asylum demon
        var inventory = ds1.GetInventory(); //Read all items in the players inventory

        //TODO: Implement your code to consume the obtained game data

        Thread.Sleep(10);
    }
}
```


## API

Bellow are the API's available on each object. They are subject to change over time.

### IGame (every game object implements these)
```C#
ResultErr<RefreshError> TryRefresh();                //Tries to refresh attachment to the specific game, refreshes memory paths. Call this every frame or 60 times per second
TreeBuilder GetTreeBuilder();                        //Returns an object that contains the relevant memory structure. Used internally, if unsure you can leave it alone
bool ReadEventFlag(uint eventFlagId);                //Read an event flag from the specific game. Not implemented in Dark Souls 2 (more info about event flags on the wiki: https://github.com/FrankvdStam/SoulSplitter/wiki/Eventflags)
int GetInGameTimeMilliseconds();                     //Get the ellapsed millis from the current loaded character
Process GetProcess();                                //Get a raw process handle, from which you can implement your own systems
```

### DarkSouls1 (PTDE & remastered)
```C#
int GetAttribute(Attribute attribute);               //Read an attribute (one of the player's levels)
bool IsWarpRequested();                              //True if a loading screen is visible, and a warp was requested via a bonfire, homeward bone, darksign or homeward miracle
bool IsPlayerLoaded();                               //True if the player object is loaded in memory
int NgCount();                                       //Returns what the current NG+ cycle is
int GetCurrentSaveSlot();                            //Returns what the current, or last loaded save slot is
Vector3f GetPosition();                              //Returns the players position in a vector of 3 floats
bool AreCreditsRolling();                            //Returns true if the credits are rolling
void ResetInventoryIndices();                        //Overwrites a number of in-game indices (current selected inventory slot for instance)
List<Item> GetInventory();                           //Returns a list of items, read from the players inventory
BonfireState GetBonfireState(Bonfire bonfire);       //Returns the state of a bonfire
string GetSaveFileLocation();                        //Attempts to find the path to the savefile, depending on locale
```

### DarkSouls2 (Vanilla & SOTFS)
```C#
Vector3f GetPosition();                              //Returns the players position in a vector of 3 floats
int GetBossKillCount(BossType bossType);             //Returns a value representing the current NG+ cycle plus the amount of boss kills on this cycle. If you kill last giant once on ng, it will return 1. Kill him twice, it will retun 2. Kill him 0 times on ng+, it will return 1.
int GetAttribute(Attribute attribute);               //Read an attribute (one of the player's levels)
bool IsLoading();                                    //Returns true when a loading screen is visible
```

### DarkSouls3
```C#
bool IsLoading();                                    //Returns true when a loading screen is visible
bool IsPlayerLoaded();                               //Returns true when the player object is loaded into memory
void WriteInGameTimeMilliseconds(int millis);        //Overwrite the game's in game time with a new value (used in blackscreen removal to create the illusion of a paused timer)
Vector3f GetPosition();                              //Returns the players position in a vector of 3 floats
int ReadAttribute(Attribute attribute);              //Read an attribute (one of the player's levels)
bool BlackscreenActive()                             //Reads a combination of flags in memory to determine of a blackscreen is active
```

### Sekiro

Refeshing Sekiro will install nologo and notutorial mods into the game. Additionally it installs a fix to the imprecise in game time.

```C#
void WriteInGameTimeMilliseconds(int value);         //Overwrite the game's in game time with a new value (used in blackscreen removal to create the illusion of a paused timer)
bool IsPlayerLoaded();                               //Returns true when the player object is loaded into memory
Vector3f GetPlayerPosition();                        //Returns the players position in a vector of 3 floats
bool IsBlackscreenActive();                          //Reads a combination of flags in memory to determine of a blackscreen is active
```

### EldenRing

Refreshing Elden Ring will install a fix to the imprecise in game timer

```C#
void EnableHud();                                    //The HUD can be on disabled or on "auto". This function sets it to always on.
Position GetPosition();                              //Returns the players position in a vector of 3 floats + the ID's of the current tile
bool IsPlayerLoaded();                               //Returns true if the player object is loaded into memory
ScreenState GetScreenState();                        //Returns the current "screenstate", can be InGame/Loading/MainMenu/Unknown
bool IsBlackscreenActive();                          //Reads a combination of flags in memory to determine of a blackscreen is active
List<Item> ReadInventory();                          //Reads the player's inventory. A part of the inventory seems stored in event flags (especially key-items) so be warned: some things might not be in this list
void WriteInGameTimeMilliseconds(int milliseconds);  //Overwrite the game's in game time with a new value (used in blackscreen removal to create the illusion of a paused timer)
void ResetIgt();                                     //Overwrite the game's in game time with 0 (used to prepare NG+ save files)
```

### Armored Core 6

Refreshing Armored Core 6 will install nologo & a fix to the imprecise in game timer

```C#
//No game specific functions yet, only IGame functions available
```