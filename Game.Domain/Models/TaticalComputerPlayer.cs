using Game.Domain.Enums;
using Game.Domain.Implementaions;
using Game.Domain.Implementaions.Strategies;
using Game.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.Models
{
    public class TaticalComputerPlayer : Player, IPlayer
    {
        public TaticalComputerPlayer() : base(new TaticalComputerStrategy(),PlayerTypeEnum.TaticalComputer)
        {

        }

        public void Move()
        {
            this.CurrentMove = this.Strategy.Execute();
        }

        public string GetTypeDescription()
        {
            return "TATICAL COMPUTER";
        }
    }
}
