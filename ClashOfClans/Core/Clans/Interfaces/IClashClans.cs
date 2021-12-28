using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface IClashClans
    {
        /// <summary>
        /// Search all clans by name and/or filtering the results using various criteria. 
        /// <br />
        /// At least one filtering criteria must be defined and if name is used as part of search, it is required to be at least three characters long.
        /// </summary>
        /// <param name="clanName">Clan name to search for</param>
        /// <param name="clanSearchSettings">Search criteria</param>
        /// <returns><see cref="IEnumerable{Clan}"/></returns>
        /// <exception cref="ArgumentException"><paramref name="clanName"/></exception>
        Task<IEnumerable<Clan>> SearchAsync(string clanName, ClanSearchSettings clanSearchSettings = default);

        /// <summary>
        /// Get information about a single clan by clan tag.
        /// </summary>
        /// <param name="clanTag">Clan tag to search for</param>
        /// <returns><see cref="ClanInformation"/></returns>
        Task<ClanInformation> GetClanByTagAsync(string clanTag);

        /// <summary>
        /// Returns a list of clan members based on the clan tag and search criteria.
        /// </summary>
        /// <param name="clanTag">Clan tag to search for</param>
        /// <param name="searchSettings">Basic search criteria</param>
        /// <returns><see cref="IEnumerable{ClanMember}"/></returns>
        Task<IEnumerable<ClanMember>> GetClanMembersAsync(string clanTag, BasicSearchSettings searchSettings = default);

        /// <summary>
        /// Retrieve a clan war log.
        /// </summary>
        /// <param name="clanTag">Clan tag to search for</param>
        /// <returns><see cref="IEnumerable{WarLog}"/></returns>
        Task<IEnumerable<WarLog>> GetWarLogsAsync(string clanTag);

        /// <summary>
        /// Gets the current war, returns null if the clan is not currently in war.
        /// </summary>
        /// <param name="clanTag">Clan tag to get current war for</param>
        /// <returns><see cref="CurrentWar"/></returns>
        Task<CurrentWar> GetCurrentWarAsync(string clanTag);

        /// <summary>
        /// Retrieve information about clan's current clan war league group.
        /// </summary>
        /// <param name="clanTag">Clan tag to get current league group for</param>
        /// <returns><see cref="LeagueGroup"/></returns>
        Task<LeagueGroup> GetCurrentLeagueGroupAsync(string clanTag);

        /// <summary>
        /// Retrieve information about a clan war league war.
        /// </summary>
        /// <param name="warTag">War tag to retrieve information from</param>
        /// <returns><see cref="ClanWarLeague"/></returns>
        Task<ClanWarLeague> GetClanWarLeagueAsync(string warTag);
    }
}
