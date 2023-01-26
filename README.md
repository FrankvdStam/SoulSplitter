<h1 align="center">
  <br>
  <img src="resources/soulsplitter.png" width="350"/><br>
  SoulSplitter
  <br>
</h1>

<h4 align="center">A livesplit plugin for souls-games</h4>

<p align="center">
  <a href="#features">Features</a> •
  <a href="#installation">Installation</a> •
  <a href="https://github.com/FrankvdStam/SoulSplitter/wiki">Wiki</a> •
  <a href="#credits">Contact</a> •
  <a href="#credits">Credits</a> •
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
    <a href="https://ko-fi.com/wasted1">
        <img src="https://img.shields.io/badge/buy%20me%20a%20coffee-donate-yellow.svg"/>
    </a>
    <a href="https://www.youtube.com/@1wasted">
        <img src="https://img.shields.io/badge/-YouTube-red"/>
    </a>
    <a href="https://discord.com/users/281116269921566721">
        <img src="https://img.shields.io/badge/-Discord-blue"/>
    </a>
</p>

# Features

- Official timer for
    - Dark Souls 1
    - Dark Souls 3
    - Elden Ring
    - Sekiro: Shadows Die Twice
- Blackscreens/loadingscreen time is removed in
    - Dark Souls 3
    - Elden Ring
    - Sekiro: Shadows Die Twice
- Comes with a built-in event flag logger for all the games (use this to find flags to autosplit on, more info [here](https://github.com/FrankvdStam/SoulSplitter/wiki/Eventflags))
- Event flag tracker (for 100% completion style runs, or maybe all bosses in Elden Ring)
- Game memory reading functionality available as a standalone library on [![NuGet version (SoulMemory)](https://img.shields.io/nuget/v/SoulMemory)](https://www.nuget.org/packages/SoulMemory/), it has it's own [readme](./src/SoulMemory/README.md)

Easily configure automatic splitting based on the in-game route you are running. Pick from a variety of timings and in-game events and share your setup with friends (setup is stored in the livesplit .lss files)
  
<p align="center">
    <img src="https://user-images.githubusercontent.com/37239092/214152219-433b1ea3-8d25-4800-9780-664c4af975ec.png"/>
</p>
<br/>

Easily track arbitrary event flags for 100% style runs, or all bosses in Elden Ring. Background colors and fontsize can be adjusted to be OBS/stream overlay friendly.

<p align="center">
    <img src="https://user-images.githubusercontent.com/37239092/214557544-2abeb450-beaa-4c93-8e46-38dd079c2731.png">
</p>



# Installation

Install [LiveSplit](https://github.com/LiveSplit/LiveSplit), enter the name of the souls-game you want to run and click "activate" - this will download and install everything for you. Click on "settings" to the right of it to configure it.

<p align="center">
    <img src="https://user-images.githubusercontent.com/37239092/214122849-99988bb0-6204-4348-94dc-333fc38c61f0.png"/>
</p>
<br/>

Don't forget to set livesplit to compare against game time  

<p align="center">
    <img src="https://user-images.githubusercontent.com/37239092/214124915-bdfdee84-4eb1-40e4-ba23-8f837e708917.png"/>
</p>

# Contact

Make sure to checkout the [troubleshooting](https://github.com/FrankvdStam/SoulSplitter/wiki/troubleshooting) page before you contact me. If you get stuck, you can find me in the [speedsouls discord](https://discord.gg/speedsouls), ping @wasted in any of the help channels, or DM [wasted#2747](https://discord.com/users/281116269921566721) directly with your questions.

If you find a bug you can let me know via the above methods, or you can [submit a github issue](https://github.com/FrankvdStam/SoulSplitter/issues/new).

# Credits

Thank you strimmers, for risking your PB's, to test my broken code!  
- [Catalystz](https://www.twitch.tv/catalystz)  
- [Johndisandonato](https://www.twitch.tv/johndisandonato)  
- [Siegbruh](https://www.twitch.tv/siegbruh)  
- [Holm](https://www.twitch.tv/holm_gg)  
- [Pennek](https://www.twitch.tv/pennek)  
- [Nyk_style](https://www.twitch.tv/nyk_style)  
- [Maarionete](https://www.twitch.tv/maarionete)  
- [Moochyy](https://www.twitch.tv/moochyy_)  
  
Thank you all!

Special thanks to [B3LYP](https://github.com/pawREP), for his many contributions to the speedrunning community:  
- writing the initial MIGT code injection for Elden Ring
- writing the original Sekiro plugin, which features have been included
- OG ds3 plugin, together with [Jiiks](https://github.com/Jiiks/)
<br/>

- Thanks Pav, for the Elden Ring cheat engine table
- Thanks [Johndisandonato](https://github.com/veeenu), pretty much always willing to exhange some ideas about tech stuff
- [Yapped](https://github.com/vawser/Yapped-Rune-Bear) helped speed up mapping event flags to bosses and graces
- Uses the excellent [material design](https://materialdesigninxaml.net/) library by James Willock
- Thanks [Nordgaren](https://github.com/Nordgaren/)
- Thanks thefifthmatt for all the hard work on figuring out how the [ER map system](http://soulsmodding.wikidot.com/reference:elden-ring-map-list) works, insane effort!
- Thanks [CapitaineToinon](https://github.com/CapitaineToinon/LiveSplit.DarkSoulsIGT) for letting me use his DS1 timer code + inventory index reset code!
- Thanks [Blade](https://github.com/bladecoding/DarkSouls3RemoveIntroScreens) for the nologo code!
- Thanks [Uberhalit](https://github.com/uberhalit) for the [Sekiro savefile mod](https://github.com/uberhalit/SimpleSekiroSavegameHelper) from his tool
- And thanks to the [soulsmodding](http://soulsmodding.wikidot.com/) community at large, I'm standing on the shoulders of these giants

I use Clion and Resharper from jetbrains to develop SoulSplitter. They have been giving me a free opensource license to use all their products for non-comercial use for a couple years now. Totally awesome, thanks Jetbrains!  

<p align="center">
    <img src="https://github.com/devicons/devicon/blob/master/icons/jetbrains/jetbrains-original.svg" width="300"/>
</p>

Check out this [visualization of the git history](https://www.youtube.com/watch?v=2u7MwySLOUE), made with [Gource](https://gource.io/)
