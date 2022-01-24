using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SnakesAndLadders.Interfaces;
using SnakesAndLadders.Managers;

namespace SnakeAndLaddersTest
{
    [TestClass]
    public class DiceRollsMovementsTest
    {
        private ILogicManager _logicManager;

        [TestInitialize]
        public void Initialize()
        {
            _logicManager = new LogicManager();
        }

        [TestMethod]
        [Description("Dice roll result is between 1 and 6")]
        public void UAT1()
        {
            var dice = _logicManager.RollADice();
            Assert.IsTrue(dice>=1 && dice<=6);
        }

        [TestMethod]
        [Description("Given the player rolls a 4. Then the token should move 4 spaces")]
        public void UAT2()
        {
            _logicManager.Initialize(1);
            _logicManager.MovePlayer(0, 4);
            var player = _logicManager.GetPlayer(0);
            Assert.IsTrue(player != null && player.CurrentSquare == 5);
        }
    }
}
