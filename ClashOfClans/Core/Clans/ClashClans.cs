using ClashOfClans.Core.Interfaces;
using ClashOfClans.Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ClashOfClans.Core.Clans
{
    public class ClashClans : IClashClans
    {
        /// <summary>
        /// Search all clans by name.
        /// </summary>
        /// <param name="clanName">Name of the clan to search for</param>
        /// <returns><see cref="IEnumerable{Clan}"/></returns>
        public async Task<IEnumerable<Clan>> SearchAsync(string clanName)
        {
            var result = await HttpClientService.RequestAsync<ClanSearchResult>($"clans?name={HttpUtility.UrlEncode(clanName)}");

            return result.Clans;
        }

        /// <summary>
        /// Search all clans by name and/or filtering the results using various criteria. At least one filtering criteria must be defined and if name is used as part of search, it is required to be at least three characters long.
        /// </summary>
        /// <param name="clanSearchSettings">Search criteria</param>
        /// <returns><see cref="IEnumerable{Clan}"/></returns>
        public async Task<IEnumerable<Clan>> SearchAsync(ClanSearchSettings clanSearchSettings)
        {
            var result = await HttpClientService.SearchClansAsync<ClanSearchResult>(clanSearchSettings);

            return result.Clans;
        }

        /// <summary>
        /// Get information about a single clan by clan tag.
        /// </summary>
        /// <param name="clanTag">Clan tag to search for</param>
        /// <returns><see cref="ClanInformation"/></returns>
        public async Task<ClanInformation> GetClanByTagAsync(string clanTag)
        {
            var result = await HttpClientService.RequestAsync<ClanInformation>($"clans/{HttpUtility.UrlEncode(clanTag)}");

            return result;
        }

        /// <summary>
        /// Returns a list of clan members based on the clan tag.
        /// </summary>
        /// <param name="clanTag">Clan tag to search for</param>
        /// <returns><see cref="IEnumerable{ClanMember}"/></returns>
        public async Task<IEnumerable<ClanMember>> GetClanMembersAsync(string clanTag)
        {
            var result = await HttpClientService.RequestAsync<ClanMembersResult>($"clans/{HttpUtility.UrlEncode(clanTag)}/members");

            return result.Members;
        }

        /// <summary>
        /// Returns a list of clan members based on the clan tag and search criteria.
        /// </summary>
        /// <param name="clanTag">Clan tag to search for</param>
        /// <param name="searchSettings">Basic search criteria</param>
        /// <returns><see cref="IEnumerable{ClanMember}"/></returns>
        public async Task<IEnumerable<ClanMember>> GetClanMembersAsync(string clanTag, BasicSearchSettings searchSettings)
        {
            var result = await HttpClientService.GetClanMembersAsync<ClanMembersResult>(HttpUtility.UrlEncode(clanTag), searchSettings);

            return result.Members;
        }
    }
}
