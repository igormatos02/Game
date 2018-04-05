using Game.Domain.Enums;
using Game.Domain.Interfaces;
using Game.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.Implementations.Factories
{
    public static class PlayerFactory
    {
        public static IPlayer Create(PlayerTypeEnum type,GamePlayerEnum gamePlayer) {

            IPlayer player = new RandomComputerPlayer();
            player.Description = "RANDOM COMPUTER";
           

            if (type == PlayerTypeEnum.Human)
            {
                player = new HumanPlayer();
                player.Description = "HUMAN";
            }

            if (type == PlayerTypeEnum.TaticalComputer)
            {
                player = new TaticalComputerPlayer();
                player.Description = "TATICAL COMPUTER";
            }

            player.Index =(int)gamePlayer;
            return player;
        }
    }
}
