using ClashOfClans.Core.Leagues;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface IClanMember
    {
        string Tag { get; }

        string Name { get; }

        ClanMemberRole Role { get; } 

        int ExpLevel { get; }

        League League { get; }

        int Trophies { get; }

        int VersusTrophies { get; }

        int ClanRank { get; }

        int PreviousClanRank { get; }

        int Donations { get; }

        int DonationsRecieved { get; }
    }
}
