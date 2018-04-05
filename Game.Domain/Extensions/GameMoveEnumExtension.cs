using Game.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.Extensions
{
    public static class GameMoveEnumExtension
    {
        public static string Description(this GameMoveEnum myEnum)
        {

            if (myEnum == GameMoveEnum.Paper)
                return "PAPER";
            if (myEnum == GameMoveEnum.Scissor)
                return "SCISSOR";
            if (myEnum == GameMoveEnum.Rock)
                return "ROCK";

            return "";
        }
        
    }
}
