using Game.Domain.Enums;
using Game.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.Implementaions.Strategies
{
    public class RandomComputerStrategy : IMoveStrategy
    {
        public GameMoveEnum Execute()
        {
            Random r = new Random();
            int rInt = r.Next(0, 3);
            return (GameMoveEnum)rInt;
        }
    }
}
