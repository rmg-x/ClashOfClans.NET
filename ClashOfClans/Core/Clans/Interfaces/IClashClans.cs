using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface IClashClans
    {
        Task<IEnumerable<Clan>> SearchAsync(string clanName, ClanSearchSettings clanSearchSettings = default);

        Task<ClanInformation> GetClanByTagAsync(string clanTag);

        Task<IEnumerable<ClanMember>> GetClanMembersAsync(string clanTag, BasicSearchSettings searchSettings = default);

        Task<IEnumerable<WarLog>> GetWarLogsAsync(string clanTag);

        Task<CurrentWar> GetCurrentWarAsync(string clanTag);
    }
}
