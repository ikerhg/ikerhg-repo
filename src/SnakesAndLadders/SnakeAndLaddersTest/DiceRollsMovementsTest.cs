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
            var _mockLogicManager = new Mock<ILogicManager>();
            _mockLogicManager.CallBase = true;
            _mockLogicManager.Object.Initialize(1);
            _mockLogicManager.Setup(m => m.RollADice()).Returns(4);

            var response = _mockLogicManager.Object.RollDiceAndMove(0);
            Assert.IsTrue(response!=null && !response.HasErrors && response.Player.CurrentSquare == 5);
        }
    }
}
