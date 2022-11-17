# SoulSplitter

[![build](https://img.shields.io/github/workflow/status/FrankvdStam/SoulSplitter/build)](https://github.com/FrankvdStam/SoulSplitter/actions) ![github__version](https://img.shields.io/github/v/release/FrankvdStam/SoulSplitter) [![NuGet version (SoulMemory)](https://img.shields.io/nuget/v/SoulMemory)](https://www.nuget.org/packages/SoulMemory/)  
![GitHub last commit](https://img.shields.io/github/last-commit/FrankvdStam/SoulSplitter) ![GitHub repo size](https://img.shields.io/github/repo-size/FrankvdStam/SoulSplitter)  
<a href="https://ko-fi.com/wasted1" title="Donate to this project using Buy Me A Coffee"><img src="https://img.shields.io/badge/buy%20me%20a%20coffee-donate-yellow.svg" alt="Buy Me A Coffee donate button" /></a> [![build](https://img.shields.io/badge/-Discord-blue)](https://discord.com/users/281116269921566721) <a href="https://www.youtube.com/@1wasted"><img src="https://img.shields.io/badge/-YouTube-red"></a>




Souls games speedrun timer, load remover and autosplitter  
Currently the official timer for Dark Souls 1, Dark Souls 3, Elden Ring and Sekiro  


# Installation
You can find detailed installation instructions with screenshots here: https://github.com/FrankvdStam/SoulSplitter/wiki/Installation

# Wiki
Not everything is documented, the things that are documented can be found on the [wiki](https://github.com/FrankvdStam/SoulSplitter/wiki).

# Contact
If you are having trouble, have questions, feature requests or anything else, come find me on discord. Feel free to ping me (@wasted) in the help channel of the respective soulsgame on the speedsouls server, or DM me by user wasted#2747 (DM's are open, no need to send a friend request).

# Credits

Thank you strimmers, for risking your PB's, to test my broken code!  
[Catalystz](https://www.twitch.tv/catalystz)  
[Johndisandonato](https://www.twitch.tv/johndisandonato)  
[Siegbruh](https://www.twitch.tv/siegbruh)  
[Holm](https://www.twitch.tv/holm_gg)  
[Pennek](https://www.twitch.tv/pennek)  
[Nyk_style](https://www.twitch.tv/nyk_style)  
[Maarionete](https://www.twitch.tv/maarionete)  
Thank you all!

Special thanks to [B3LYP](https://github.com/pawREP), for his many contributions to the speedrunning community:  
- writing the initial MIGT code injection for Elden Ring.  
- writing the original Sekiro plugin, which features have been included  
- OG ds3 plugin, together with [Jiiks](https://github.com/Jiiks/)  

Thanks Pav, for the Elden Ring cheat engine table.  
Thanks [Johndisandonato](https://github.com/veeenu), pretty much always willing to exhange some ideas about tech stuff  
[Yapped](https://github.com/vawser/Yapped-Rune-Bear) helped speed up mapping event flags to bosses and graces  
And thanks to the soulsmodding community at large, I'm standing on the shoulders of these giants: http://soulsmodding.wikidot.com/  

Uses the excellent material design library by James Willock: https://materialdesigninxaml.net/  

Thanks to Nordgaren, his tools can be found here:  
https://github.com/Nordgaren/DS2S-META  
https://github.com/Nordgaren/DS2-META  
https://github.com/Nordgaren/Erd-Tools  

Thanks thefifthmatt for all the hard work on figuring out how the ER map system works, insane effort! http://soulsmodding.wikidot.com/reference:elden-ring-map-list

Thanks [CapitaineToinon](https://github.com/CapitaineToinon/LiveSplit.DarkSoulsIGT) for letting me use his DS1 timer code + inventory index reset code!

Thanks [Blade](https://github.com/bladecoding/DarkSouls3RemoveIntroScreens) for the nologo code!  

I use Clion and Resharper from jetbrains to develop SoulSplitter. They have been giving me a free opensource license to use all their products for non-comercial use for a couple years now. Totally awesome, thanks Jetbrains!  

[![Alt jetbrainslogo](./jetbrains/jetbrains.svg)](https://www.jetbrains.com/?from=SoulSplitter)

# build

The .net build relies on some local files, all can be obtained by cloning livesplit.  

Building soulinjectee can be done in the root directory of the repository. You can build it for 32 bit (DS1 PTDE & DS2 vanilla) or for 64 bit (all other soulsgames) - you need the right toolchain/target for each build respectively  
64 bit: `cargo build --lib`  
32 bit: `cargo build --lib --target=i686-pc-windows-msvc`  
