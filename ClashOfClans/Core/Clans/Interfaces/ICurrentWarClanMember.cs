﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface ICurrentWarClanMember
    {
        string Tag { get; }

        string Name { get; }

        int TownhallLevel { get; }

        int MapPosition { get; }

        IEnumerable<ClanMemberAttack> Attacks { get; }

        int OpponentAttackCount { get; }

        ClanMemberAttack BestOpponentAttack { get; }
    }
}
