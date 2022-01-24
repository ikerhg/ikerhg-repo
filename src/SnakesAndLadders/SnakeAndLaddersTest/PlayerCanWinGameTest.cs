using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLadders.Interfaces;
using SnakesAndLadders.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLaddersTest
{
    [TestClass]
    public class PlayerCanWinGameTest
    {
        private ILogicManager _logicManager;

        [TestInitialize]
        public void Initialize()
        {
            _logicManager = new LogicManager();
        }

        [TestMethod]
        [Description("Given the token is on square 97. Token is moved 3 spaces and player has won the game")]
        public void UAT1()
        {
            _logicManager.Initialize(1);
            _logicManager.MovePlayer(0, 96);
            var response = _logicManager.MovePlayer(0, 3);
            Assert.IsTrue(response!=null && !response.HasErrors && response.HasWin);
        }

        [TestMethod]
        [Description("Given the token is on square 97. Token is moved 4 spaces and player has not won the game")]
        public void UAT2()
        {
            _logicManager.Initialize(1);
            _logicManager.MovePlayer(0, 96);
            var response = _logicManager.MovePlayer(0, 4);
            Assert.IsTrue(response != null && !response.HasErrors && !response.HasWin);
        }
    }
}
