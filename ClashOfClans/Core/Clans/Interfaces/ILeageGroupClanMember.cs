using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface ILeageGroupClanMember
    {
        string Tag { get; }

        string Name { get; }

        int TownhallLevel { get; }
    }
}
