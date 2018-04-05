using Game.Domain.Enums;
using Game.Domain.Interfaces;
using Game.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Services
{
    public class RuleService : IRuleService
    {
        public void ProcessRowndWinner(GameRound gameRound)
        {

            if (this.IsGreater(gameRound.player1.CurrentMove, gameRound.player2.CurrentMove))
            {
                gameRound.Winner = gameRound.player1;
                gameRound.Looser = gameRound.player2;
            }
            else
            {
                gameRound.Winner = gameRound.player2;
                gameRound.Looser = gameRound.player1;
            }
        }

        private bool IsGreater(GameMoveEnum playerReference, GameMoveEnum playerToCompare)
        {

            if (playerReference == GameMoveEnum.Paper && playerToCompare == GameMoveEnum.Rock)
            {
                return true;
            }

            if (playerReference == GameMoveEnum.Scissor && playerToCompare == GameMoveEnum.Paper)
            {
                return true;
            }

            if (playerReference == GameMoveEnum.Rock && playerToCompare == GameMoveEnum.Scissor)
            {
                return true;
            }

            return false;
        }

        private bool TieInTheGame(IPlayer player1,IPlayer player2)
        {
            return player1.CurrentMove == player2.CurrentMove;
        }
    }
}
