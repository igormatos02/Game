using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Domain.Interfaces;
using Game.Domain.Implementations.Factories;
using Game.Domain.Enums;
using Game.Domain.Models;

namespace Game.Services.Test
{
    [TestClass]
    public class RuleSerivcesTest
    {
        private readonly IRuleService ruleService;
        public RuleSerivcesTest()
        {
            this.ruleService = new RuleService();
        } 

        [TestMethod]
        public void TestRound()
        {
            //ARRANGE
            IPlayer player1 = PlayerFactory.Create(PlayerTypeEnum.RandomComputer,GamePlayerEnum.Player1);
            IPlayer player2 = PlayerFactory.Create(PlayerTypeEnum.RandomComputer, GamePlayerEnum.Player2);
            player1.Move();
            player2.Move();

            GameRound gameRound = new GameRound();
            gameRound.player1 = player1;
            gameRound.player2 = player2;

            //ACT
            this.ruleService.ProcessRowndWinner(gameRound);

            //ASSERT
            Assert.IsNotNull(gameRound.Winner);
            Assert.IsNotNull(gameRound.Looser);
        }

        [TestMethod]
        public void TestRandomComputer()
        {
            //ARRANGE
            IPlayer player1 = PlayerFactory.Create(PlayerTypeEnum.RandomComputer, GamePlayerEnum.Player1);
            player1.Move();
           
            //ASSERT
            Assert.IsNotNull(player1.CurrentMove);
         
        }
    }
}
