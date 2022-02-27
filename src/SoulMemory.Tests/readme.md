
# Dark souls 1

# Automated testing
This project has automated test code, for instance to check if all boss flags are correctly read from the games memory. They are supported for all games. However, it is heavily dependant on timing. Older computers with slower load times will probably not be able to run these tests.

## save file warning

Embedded in this test suite is a save file for each game. The testsuite willt try to backup your saves, run on a premade save, then restore the old save. Backup your save!


## Requirements

You must specifiy the path to nbgi and the gametype in [OneTimeSetUp] (just search for it in the code)
DSFIX + running the game at 60fps is required for the timings to work.

Bellow keybinds are required. Some are weird, mainly because ptde takes input very weirdly, it would not accept arrow keys for instance. 

Note that up/down/left/right can not be remapped in remastered. Those keys will be switched automatically.

| Menu control    | key |
|-----------------|-----|
| Open start menu | ESC |
| Up              | Z   |
| Down            | x   |
| Left            | c   |
| Right           | v   |
| Confirm         | e   |


| Actions                       | key |
|-------------------------------|-----|
| Left weapon action (block)    | p   |
| Use item                      | r   |
| Action/Gesture                | e   |


# Dark souls 2

Coming soon. Maybe.