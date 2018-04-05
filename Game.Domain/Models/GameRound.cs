using Game.Domain.Enums;
using Game.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.Models
{
    public class GameRound
    {
        public IPlayer player1 { get; set; }
        public IPlayer player2 { get; set; }
        public IPlayer Winner { get; set; }
        public IPlayer Looser { get; set; }

        public bool IsTieMatch { get; set; }
    }
}
