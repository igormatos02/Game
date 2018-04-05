using Game.Domain.Enums;
using Game.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.Implementaions
{
    public abstract class Player
    {
       
        public IMoveStrategy Strategy;
        private PlayerTypeEnum Type;

        public GameMoveEnum CurrentMove { get; set; }
        public string Description { get; set; }
        public int Index { get; set; }

        public Player(IMoveStrategy strategy, PlayerTypeEnum type)
        {
            this.Strategy = strategy;
            this.Type = type;
        }
    }
}
