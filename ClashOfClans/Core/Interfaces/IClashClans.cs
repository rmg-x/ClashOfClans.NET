using ClashOfClans.Core.Clans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Interfaces
{
    public interface IClashClans
    {
        Task<IEnumerable<Clan>> SearchAsync(string clanName);

        Task<IEnumerable<Clan>> SearchAsync(ClanSearchSettings clanSearchSettings);

        Task<ClanInformation> GetClanByTagAsync(string clanTag);

        Task<IEnumerable<ClanMember>> GetClanMembersAsync(string clanTag);

        Task<IEnumerable<ClanMember>> GetClanMembersAsync(string clanTag, BasicSearchSettings searchSettings);
    }
}
