# DSDeaths
Dark Souls death tracker. Used primarily for capture by Open Broadcaster Software; used in a Twitch.tv broadcast of Dark Souls I through III. Allows selected viewers to add deaths to the counter on screen; tracks both area (before boss), boss, and fall deaths. Allows for custom names for boss segments. Also has an option for generating a styled webpage log for the entire playthrough (example found [here](http://perterter.com/DS1)).

![Example of Usage](https://i.imgur.com/CPvMjr1.png)
![Screenshot of Software](https://i.imgur.com/eE9IMcz.png)

## Usage

```!ded [type] [+/-] [amount]```  
Where type can be the values:  
  a - area  
  b - boss  
  af - area fall (counts for 1 area death and 1 fall)  
  bf - boss fall (counts for 1 boss death and 1 fall)  

```!dedmod [+/-] [name]```  
```Can only be used by broadcaster```
Adds/removes (`+/-`) viewer with `name` to list of viewers who can modify deaths/segments.

```!newarea [remove]``` or ```!newsegment [remove]```
Begins a new segment (usually used after a boss completion).  
`remove` is an optional parameter which removes the most recently added segment. Does not allow for removal of segment with deaths already added to prevent mistakes.

## Setup
Witholding information on setup until completion of further Demon Souls games. Those saavy with C# should be able to figure out the bot setup using the IrcClient.

## TODO:
Allow viewers to change boss name per segment - the functions are already written, just not linked to commands.
