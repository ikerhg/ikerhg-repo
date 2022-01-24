using SnakesAndLadders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.Interfaces
{
    public interface ILogicManager
    {
        void Initialize(int numberOfPlayers);
        Player GetPlayer(int position);
        MovementResponse MovePlayer(int player, int numberOfPositions);
        int RollADice();
        MovementResponse RollDiceAndMove(int player);
        void AddRule(Rule rule);
        void ClearRules();
    }
}
