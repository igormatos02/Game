using Game.Domain.Enums;
using Game.Domain.Extensions;
using Game.Domain.Helpers;
using Game.Domain.Implementations.Factories;
using Game.Domain.Interfaces;
using Game.Domain.Models;
using Game.UI.Constants;
using Game.UI.UIHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.UI
{
    public class ApplicationGame : IApplicationGame
    {
       
        private readonly IRuleService ruleService;
      
        private IPlayer player1 { get; set; }
        private IPlayer player2 { get; set; }
        private List<GameRound> GameRounds { get; set; }

        public ApplicationGame(IRuleService ruleService)
        {
            this.ruleService = ruleService;
        }
        
        public void EndGame()
        {
            ConsoleHelper.PrintEndGame();
        }

        public void FinishMatch()
        {
            ConsoleHelper.PrintEndMatch();
        }

        public void NextRownd()
        {
          
            var gameRound = new GameRound();
            this.GameRounds.Add(gameRound);
            ConsoleHelper.PrintLine();
            ConsoleHelper.PrintBlue(String.Format(UIConstants.Round, this.GameRounds.Count()));
            ConsoleHelper.ShowGameMenuForPlayer();

            ReadPlayerMove(this.player1);
            ReadPlayerMove(this.player2);

            gameRound.player1 = player1;
            gameRound.player2 = player2;

            ruleService.ProcessRowndWinner(gameRound);

            if (gameRound.IsTieMatch)
            {
                ConsoleHelper.PrintTieInTheGame(
                    player1.CurrentMove.Description(), 
                    player2.CurrentMove.Description()
                );
            }
            else
            {

                ConsoleHelper.PrintWinner(
                      gameRound.Winner.Description,
                      gameRound.Looser.CurrentMove.Description(),
                      gameRound.Winner.CurrentMove.Description()
                   );
            }

            ConsoleHelper.PrinEndTurn();

        }
        
        private void ReadPlayerMove(IPlayer player)
        {
            ConsoleHelper.PrintWhite(String.Format(UIConstants.PlayerRound, player.Description,player.Index));
            player.Move();
            ConsoleHelper.PrintYellow(String.Format(UIConstants.PlayerMove, player.Index, player.CurrentMove.Description()));
            ConsoleHelper.PrintLine();
        }

        public void GetPlayer(GamePlayerEnum player) {
            ConsoleHelper.PrintYellow(String.Format(UIConstants.SetPlayerText, player));
            var userSelectionPlayer = InputHelper.ReadKey(3);
            var actualPlayer = this.AddPlayer(
               this.ResolvePlayer(userSelectionPlayer),
              player
           );
            ConsoleHelper.PrintLine();
            ConsoleHelper.PrintBlue(String.Format(UIConstants.SelectedPlayerText, actualPlayer.Description));
        }

        public  void Start()
        {
            ConsoleHelper.PrintMainMenu();
            this.GetPlayer(GamePlayerEnum.Player1);
            this.GetPlayer(GamePlayerEnum.Player2);

            this.GameRounds = new List<GameRound>();
            this.NextRownd();
            this.NextRownd();
            this.NextRownd();

            this.FinishMatch();

        }

        private PlayerTypeEnum ResolvePlayer(int playerType)
        {
            return (PlayerTypeEnum)playerType;
        }

        private IPlayer AddPlayer(PlayerTypeEnum playerType, GamePlayerEnum gamePlayer)
        {
            if (gamePlayer == GamePlayerEnum.Player1)
            {
                this.player1 = PlayerFactory.Create(playerType, gamePlayer);
                return this.player1;
            }
            else
            {
                this.player2 = PlayerFactory.Create(playerType, gamePlayer);
                return this.player2;
            }
        }
    }
}
