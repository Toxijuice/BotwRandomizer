# BOTW Randomizer Mod

## Table of contents

- [Quick start](#quick-start)
- [What's new](#whats-new)
- [What's randomized](#whats-randomized)
- [How it works](#how-it-works)
- [Known Bugs](#known-bugs)
- [Contributing](#contributing)
- [Creators](#creators)
- [Thanks](#special-thanks)
- [Copyright and license](#copyright-and-license)


## Quick start

Head over to the [Releases](https://github.com/Toxijuice/BotwRandomizer/releases) section and download the latest built .exe file. Run it and configure it. Once the randomization process starts, it will create a new Cemu graphic pack in the proper folder. Make sure to enable it in Cemu's graphic packs settings!

If the app doesn't launch for you when double clicking it, then you might be missing the latest [.NET Desktop Runtime 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

The BOTW Randomizer expects you to have an extracted copy of the Wii U version of BOTW, including the following:
- The base game
- The latest update (1.5.0)
- The 2 DLCs

It is also recommended (for now) to use Cemu to play the Randomizer, as it wasn't tested on an actual Wii U console yet.

## What's new?

### Swap Mode
This makes it so item/enemy types are randomized, rather than individual items. For example: with swap mode **off**, every Apple will randomize to any other fruit. With swap mode **on**, every Apple will randomize to the same fruit (or at least something in the same item pool as Apples).

When Swap Mode is enabled, you have the option of changing the "variety" of each item pool. This changes the amount of possibilities an item has to randomize into. With a variety value of 1, each item is guaranteed to randomize to the same thing. With a variety value of 2, an item has a 50/50 chance to randomize between 2 items, but it will always randomize to one of those two.

To follow the same example from earlier: with the Material Variety set to 1, you may have a seed where all Apples may become Hearty Durians. But with a Material Variety of 2, each Apple will have a 50% chance of becoming a Hearty Durian and a 50% chance of becoming a Fortified Pumpkin.

**WARNING** - While very unlikely, there is a chance with a variety above 1 that you will cause an item to never spawn (or otherwise become very rare). This is because at variety 1, types of items can only be randomized to by one other type of item. Once the randomizer decides Apples will become Hearty Durians, no other type of item can randomize to Hearty Durian. Variety 1 guarantees that each type of item will still exist somewhere in the world.

I personally prefer most things to be at variety 1, and let the Chaos Chance sprinkle in variety to the item spawns.


### Chaos Chance
This is the percent chance something will completely ignore the rules when randomizing. The object being randomized will choose from any item pool, they are not limited to similar items. This means that items can become enemies and vice-versa.

**WARNING** - The higher the value, the more likely the game will crash. I recommend anywhere from 0-5% for a little spiciness in the randomization.


*Randomization with Swap Mode and Chaos Chance enabled only affects items that spawn in the world, it does not change chest contents.*

## What's randomized

Here's what's randomized with the latest version of the Randomizer:

 - Enemy Types
 - Enemy Levels
 - Enemy Weapons
 - Enemy Arrows
 - Taluses
 - Hinoxes
 - Lynels
 - Overworld & Shrine Weapons
 - Overworld & Shrine Chest Drops
 - Armors in Chests
 - Armor Shops
 - Food Shops
 - Arrow Shops

## How it works

Every time the randomizer is run, it creates a new graphic pack, and generates a new seed. This means that every object and item will always be the same until you do a new seed.

On top of everything above being randomized, the Randomizer changes slightly the goal of the game.

First of all, the Paraglider is randomized within the Great Plateau in a random chest. (Monster camp chests don't count.)

Next, to enter Ganon, you need the Master Sword. This makes it so you need at least 13 hearts to beat the game.

Secondly, completing shrines doesn't give you Spirit Orbs anymore, so how do you get more hearts?

The answer is simple! Spirit Orbs can now be found throughout Hyrule within it's numerous chests.

There are more Spirit Orbs placed in chests than you need. This is done so runs are shorter and so they don't last for days.

PS: You start the game with the Camera rune, which allows you to scan a treasure chest, and use the Sheikah Sensor to easily find all the other ones!

## Contributing

Feel free to fork and make any modifications you feel like, but consider taking a look at the [original repo by MelonSpeedruns](https://github.com/MelonSpeedruns/BotwRandomizer) as there's always a chance that or another fork will be updated to do what you want.

### Dependencies
You need to have the [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) installed to build this app in Visual Studio.

## Known Bugs

 - Butterfly
 - Dragonfly
 - Beetle
 - Cricket
 - Firefly

## Creators

* [MelonSpeedruns](https://github.com/MelonSpeedruns/)
* [Miepee](https://github.com/miepee/)
* [Toxijuice](https://github.com/Toxijuice) Added swap and chaos

## Special Thanks

* [Linkus7](https://www.twitch.tv/linkus7/) For helping out with design, bug hunting, beta testing, advertising and general support!
* [Leoetlino](https://github.com/leoetlino/) For answering my dumb Python questions, and being very patient with me!
* [LinoYeen](https://www.twitch.tv/linoyeen/) For helping out with design ideas, beta testing, advertising and general support!
* [tLeves](https://www.twitch.tv/tLeves/) For helping out with design ideas, beta testing, advertising and general support!

If I forgot your name, let me know and I'll add you!

## Copyright and license

The code is released under the [GPL-3.0 License](https://github.com/MelonSpeedruns/BotwRandomizer/blob/main/LICENSE).

Toolbox.Library is available as part of Switch Toolbox made by KillzXGaming!
Here's a link to it's source code: https://github.com/KillzXGaming/Switch-Toolbox
