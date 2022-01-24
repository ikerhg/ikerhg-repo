using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLadders.Interfaces;
using SnakesAndLadders.Managers;
using System;

namespace SnakeAndLaddersTest
{
    [TestClass]
    public class TokenCanMoveAcrossBoardUnitTest
    {
        private ILogicManager _logicManager;

        [TestInitialize]
        public void Initialize()
        {
            _logicManager = new LogicManager();
        }

        [TestMethod]
        [Description("When the token is placed on the board. Then the token is on square 1")]
        public void UAT1()
        {
            _logicManager.Initialize(1);
            var player = _logicManager.GetPlayer(0);
            Assert.IsTrue(player != null && player.CurrentSquare == 1);
        }

        [TestMethod]
        [Description("Given the token is on square 1. When it is moved 3 spaces, then token is on square 4")]
        public void UAT2()
        {
            _logicManager.Initialize(1);
            var response = _logicManager.MovePlayer(0, 3);
            Assert.IsTrue(response != null && !response.HasErrors && response.Player!=null && response.Player.CurrentSquare == 4);
        }

        [TestMethod]
        [Description("Given the token is on square 1. When it is moved 3 spaces and then moved 4 spaces. Then token is on square 8")]
        public void UAT3()
        {
            _logicManager.Initialize(1);
            _logicManager.ClearRules();
            _logicManager.MovePlayer(0, 3);
            _logicManager.MovePlayer(0, 4);
            var player = _logicManager.GetPlayer(0);
            Assert.IsTrue(player != null && player.CurrentSquare == 8);
        }
    }
}
