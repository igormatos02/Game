using Game.Domain.Enums;
using Game.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.Interfaces
{
    public interface IRuleService
    {
        void ProcessRowndWinner(GameRound gameRound);
       
    }
}
