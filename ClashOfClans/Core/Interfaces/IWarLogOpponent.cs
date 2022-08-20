using ClashOfClans.Core.Clans;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Interfaces
{
    public interface IWarLogOpponent
    {
        string Tag { get; }

        string Name { get; }

        ClanBadges Badges { get; }

        int ClanLevel { get; }

        int Stars { get; }

        double DestructionPercentage { get; }
    }
}
