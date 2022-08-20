using ClashOfClans.Core.Clans;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Players.Interfaces
{
    public interface IClashPlayerClan
    {
        string Tag { get; }

        string Name { get; }

        int ClanLevel { get; }

        ClanBadges Badges { get; }
    }
}
