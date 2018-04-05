using Game.Domain.Enums;
using Game.Domain.Helpers;
using Game.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.Implementaions.Strategies
{
    public class HumanStrategy : IMoveStrategy
    {
        public GameMoveEnum Execute()
        {
            Console.WriteLine("INSERT PLAYER MOVE");
            return (GameMoveEnum) InputHelper.ReadKey(3);
        }
    }
}
