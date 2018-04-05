using Game.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.Interfaces
{
    public interface IPlayer
    {
        GameMoveEnum CurrentMove { get; set; }
        void Move();
        string Description { get; set; }
        int Index { get; set; }
    }
}
