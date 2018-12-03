using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using System.Linq;
using System;

namespace ClashOfClans.Core.Clans
{
    public class ClashClans : IClashClans
    {
        private HttpClientService _httpClientService { get; set; }

        public ClashClans(HttpClientService httpClientService) => _httpClientService = httpClientService;

        /// <summary>
        /// Search all clans by name and/or filtering the results using various criteria. At least one filtering criteria must be defined and if name is used as part of search, it is required to be at least three characters long.
        /// </summary>
        /// <param name="clanName">Clan name to search for</param>
        /// <param name="clanSearchSettings">Search criteria</param>
        /// <returns><see cref="IEnumerable{Clan}"/></returns>
        /// <exception cref="ArgumentException"><paramref name="clanName"/></exception>
        public async Task<IEnumerable<Clan>> SearchAsync(string clanName, ClanSearchSettings clanSearchSettings = default)
        {
            var result = await _httpClientService.SearchClansAsync<ClanSearchResult>(HttpUtility.UrlEncode(clanName), clanSearchSettings);
            return result.Clans;
        }

        /// <summary>
        /// Get information about a single clan by clan tag.
        /// </summary>
        /// <param name="clanTag">Clan tag to search for</param>
        /// <returns><see cref="ClanInformation"/></returns>
        public async Task<ClanInformation> GetClanByTagAsync(string clanTag)
        {
            var result = await _httpClientService.RequestAsync<ClanInformation>($"clans/{HttpUtility.UrlEncode(clanTag)}");

            return result;
        }

        /// <summary>
        /// Returns a list of clan members based on the clan tag and search criteria.
        /// </summary>
        /// <param name="clanTag">Clan tag to search for</param>
        /// <param name="searchSettings">Basic search criteria</param>
        /// <returns><see cref="IEnumerable{ClanMember}"/></returns>
        public async Task<IEnumerable<ClanMember>> GetClanMembersAsync(string clanTag, BasicSearchSettings searchSettings = default)
        {
            var result = await _httpClientService.GetClanMembersAsync<ClanMembersResult>(HttpUtility.UrlEncode(clanTag), searchSettings);

            return result.Members;
        }

        /// <summary>
        /// Retrieve a clan war log.
        /// </summary>
        /// <param name="clanTag">Clan tag to search for</param>
        /// <returns><see cref="IEnumerable{WarLog}"/></returns>
        public async Task<IEnumerable<WarLog>> GetWarLogsAsync(string clanTag)
        {
            var result = await _httpClientService.RequestAsync<WarLogResult>($"clans/{HttpUtility.UrlEncode(clanTag)}/warlog");

            return result.WarLogs;
        }

        /// <summary>
        /// Gets the current war, returns null if the clan is not currently in war.
        /// </summary>
        /// <param name="clanTag">Clan tag to get current war for</param>
        /// <returns><see cref="CurrentWar"/></returns>
        public async Task<CurrentWar> GetCurrentWarAsync(string clanTag)
        {
            var result = await _httpClientService.RequestAsync<CurrentWar>($"clans/{HttpUtility.UrlEncode(clanTag)}/currentwar");

            if (result.WarState == WarState.NotInWar)
                return null;

            return result;
        }
    }
}
