using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface IClashClans
    {
        Task<IEnumerable<Clan>> SearchAsync(string clanName);

        Task<IEnumerable<Clan>> SearchAsync(ClanSearchSettings clanSearchSettings);

        Task<ClanInformation> GetClanByTagAsync(string clanTag);

        Task<IEnumerable<ClanMember>> GetClanMembersAsync(string clanTag);

        Task<IEnumerable<ClanMember>> GetClanMembersAsync(string clanTag, BasicSearchSettings searchSettings);

        Task<IEnumerable<WarLog>> GetWarLogsAsync(string clanTag);
    }
}
