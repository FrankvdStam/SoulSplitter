# SoulSplitter

![build](https://github.com/FrankvdStam/SoulSplitter/actions/workflows/build.yml/badge.svg) ![github__version](https://img.shields.io/github/v/release/FrankvdStam/SoulSplitter) <a href='https://ko-fi.com/wasted1' target='_blank'><img height='35' style='border:0px;height:21px;' src='https://az743702.vo.msecnd.net/cdn/kofi6.png?v=0' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>

Soulsgames speedrun timer, load remover and autosplitter  

Currently supports:  
Elden Ring: MIGT, initial black screen removal and autosplitting   
DarkSouls3: IGT, blackscreen removal and autosplitting  
Sekiro: IGT, blackscreen removal and autosplitting  


For Elden Ring specific information, see https://github.com/FrankvdStam/SoulSplitter/wiki/Elden-Ring


# Installation
You can find detailed installation instructions with screenshots here: https://github.com/FrankvdStam/SoulSplitter/wiki/Installation

# Wiki
Not everything is documented, the things that are documented can be found on the [wiki](https://github.com/FrankvdStam/SoulSplitter/wiki).

# Contact
If you are having trouble, have questions, feature requests or anything else, come find me on discord. Feel free to ping me (@wasted) in the help channel of the respective soulsgame on the speedsouls server, or DM me by user wasted#2747 (DM's are open, no need to send a friend request).

# Credits

Thank you strimmers, for risking your PB's, to test my broken code!  
[Catalystz!](https://www.twitch.tv/catalystz)  
[Johndisandonato!](https://www.twitch.tv/johndisandonato)  
[siegbruh!](https://www.twitch.tv/siegbruh)  
[Holm!](https://www.twitch.tv/holm_gg)  
[Pennek!](https://www.twitch.tv/pennek)  
[nyk_style!](https://www.twitch.tv/nyk_style)  
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

I use Clion and Resharper from jetbrains to develop SoulSplitter. They have been giving me a free opensource license to use all their products for non-comercial use for a couple years now. Totally awesome, thanks Jetbrains!  

[![Alt jetbrainslogo](./jetbrains/jetbrains.svg)](https://www.jetbrains.com/?from=SoulSplitter)

# build

The .net build relies on some local files, all can be obtained by cloning livesplit.  

Building soulinjectee can be done in the root directory of the repository. You can build it for 32 bit (DS1 PTDE & DS2 vanilla) or for 64 bit (all other soulsgames) - you need the right toolchain/target for each build respectively  
64 bit: `cargo build --lib`  
32 bit: `cargo build --lib --target=i686-pc-windows-msvc`  



