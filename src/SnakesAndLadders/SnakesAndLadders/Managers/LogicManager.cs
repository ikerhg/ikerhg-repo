using SnakesAndLadders.Constants;
using SnakesAndLadders.Entities;
using SnakesAndLadders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.Managers
{
    public class LogicManager : ILogicManager
    {
        private int NumberOfPlayers;
        private Player[]? PlayerList;
        private Dictionary<int, Rule> Rules = new Dictionary<int, Rule>();

        /// <summary>
        /// Initialize Game with a number of players
        /// </summary>
        /// <param name="numberOfPlayers">Number of players</param>
        public void Initialize(int numberOfPlayers)
        {
            NumberOfPlayers = numberOfPlayers;
            PlayerList = new Player[NumberOfPlayers];
            
            //By default some rules on a board are set
            Rules = AppConstants.Rules;

            for (int i = 0; i < PlayerList.Length; i++)
            {
                PlayerList[i] = new Player();
            }
        }

        /// <summary>
        /// Get the player in a determined position
        /// </summary>
        /// <param name="position">Position or index of the player</param>
        /// <returns>Player with that position in the array</returns>
        public Player GetPlayer(int position)
        {
            if (PlayerList == null || PlayerList.Length > position + 1)
                return null;

            return PlayerList[position];
        }

        /// <summary>
        /// Move player from the current position to a number of positions ahead
        /// </summary>
        /// <param name="player">Position or index of the player</param>
        /// <param name="numberOfPositions">Number of positions ahead</param>
        /// <returns>Response of the the movement with possible errors and data</returns>
        public MovementResponse MovePlayer(int player, int numberOfPositions)
        {
            var response = new MovementResponse();
            response.DiceResult = numberOfPositions;
            if (PlayerList == null || PlayerList.Length < player + 1 || PlayerList[player] == null)
            {
                response.HasErrors = true;
                response.Message = "Player does not exist.";
                return response;
            }

            response.Player = PlayerList[player];
            PlayerList[player].CurrentSquare += numberOfPositions;

            //Check if there is any rule in that square
            if (Rules.Any() && Rules.ContainsKey(PlayerList[player].CurrentSquare))
            {
                var rule = Rules[PlayerList[player].CurrentSquare];
                PlayerList[player].CurrentSquare = rule.EndPosition;
                response.Message = $"Player has gone throw a {rule.Type}";
            }

            //If player current square is equal to the latest position that player has win the game
            if (PlayerList[player].CurrentSquare == AppConstants.LastPosition)
            {
                response.HasWin = true;
                return response;
            }

            //Calculation of the current square based on the last position
            if (PlayerList[player].CurrentSquare > AppConstants.LastPosition)
                PlayerList[player].CurrentSquare = AppConstants.LastPosition - (PlayerList[player].CurrentSquare - AppConstants.LastPosition);

            return response;

        }

        /// <summary>
        /// Roll a dice
        /// </summary>
        /// <returns>Result</returns>
        public int RollADice()
        {
            var dice = new Random();
            return dice.Next(1, 7);
        }

        /// <summary>
        /// Roll the dice for a player and move it on the board
        /// </summary>
        /// <param name="player">Position or index of the player</param>
        /// <returns>Response of the the movement with possible errors and data</returns>
        public MovementResponse RollDiceAndMove(int player)
        {
            var dice = RollADice();
            return MovePlayer(player, dice);
        }

        /// <summary>
        /// Adds a rule to the current ones with a type and starting and ending positions
        /// </summary>
        /// <param name="rule">Rule with type and start and end position</param>
        public void AddRule(Rule rule)
        {
            if (Rules == null)
                Rules = new Dictionary<int, Rule>();

            Rules.Add(rule.StartPosition, rule);
        }

        /// <summary>
        /// Clears the list of the rules
        /// </summary>
        public void ClearRules()
        {
            if (Rules!=null && Rules.Any())
                Rules.Clear();
        }
    }
}
