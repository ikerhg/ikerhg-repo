# ikerhg-repo

# Snakes and Ladders
This is a library that have different methods that can be used as backend of this game. This methods will be described. For using this,
it is enough with adding a reference to SnakesAndLadders project or dll and then creating an object of ILogicManager.

## LogicManager
Implements different methods for the logic of the game:

### Initialize
Initialize the game with the number of players received

### GetPlayer
Gets the player in a given position. A player has a current square and a name.

### MovePlayer
Move player from the current position to a number of positions ahead. It returns a movement response. If there is any error, it will be informed.
Also if a player has win, it will be returned here.

### RollADice
Returns a number between 1 and 6

### RollDiceAndMove
Roll a dice and call move player method.

### AddRule
Adds a new rule to the list of the rules of the game. A rule has a type that actually can be snake or ladder. You can setup start and end position.

### ClearRules
Clear all the rules in the list

### Game Test
Example of util of the library with a couple of players.


