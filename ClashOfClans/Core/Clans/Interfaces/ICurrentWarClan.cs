using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface ICurrentWarClan
    {
        ClanBadges Badges { get; }

        int ClanLevel { get; }

        int Attacks { get; }

        int Stars { get; }

        double DestructionPercentage { get; }
    }
}
