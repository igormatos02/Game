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
    public class HumanPlayer : Player, IPlayer
    {
        
        public HumanPlayer():base(new HumanStrategy(),PlayerTypeEnum.Human) {
            
        }

        public void Move()
        {
            this.CurrentMove = this.Strategy.Execute();
        }
       
    }
}
