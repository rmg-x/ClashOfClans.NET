using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;

namespace ClashOfClans.Core.Clans
{
    public class ClashClans : IClashClans
    {
        private readonly HttpClient _httpClient;

        public ClashClans(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Search all clans by name and/or filtering the results using various criteria. 
        /// <br />
        /// At least one filtering criteria must be defined and if name is used as part of search, it is required to be at least three characters long.
        /// </summary>
        /// <param name="clanName">Clan name to search for</param>
        /// <param name="clanSearchSettings">Search criteria</param>
        /// <returns><see cref="IEnumerable{Clan}"/></returns>
        /// <exception cref="ArgumentException"><paramref name="clanName"/></exception>
        public async Task<IEnumerable<Clan>> SearchAsync(string clanName, ClanSearchSettings clanSearchSettings = default)
        {
            if (string.IsNullOrEmpty(clanName) || clanName.Length < 3)
            {
                throw new ArgumentException("A clan name must be specified and greater than two characters.", nameof(clanName));
            }

            string encodedClanName = HttpUtility.UrlEncode(clanName);
            string requestUri = $"clans?name={encodedClanName}";

            if (clanSearchSettings != default)
            {
                requestUri += "?" + clanSearchSettings.GetQueryString();
            }

            var result = await _httpClient.GetFromJsonAsync<ClanSearchResult>(requestUri, ClashConstants.DefaultJsonSerializerOptions);

            return result.Clans;
        }

        /// <summary>
        /// Get information about a single clan by clan tag.
        /// </summary>
        /// <param name="clanTag">Clan tag to search for</param>
        /// <returns><see cref="ClanInformation"/></returns>
        public async Task<ClanInformation> GetClanByTagAsync(string clanTag)
        {
            var result = await _httpClient.GetFromJsonAsync<ClanInformation>($"clans/{HttpUtility.UrlEncode(clanTag)}", ClashConstants.DefaultJsonSerializerOptions);

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
            string requestUri = $"clans/{HttpUtility.UrlEncode(clanTag)}/members";

            if (searchSettings != default)
            {
                requestUri = "?" + searchSettings.GetQueryString();
            }

            var result = await _httpClient.GetFromJsonAsync<ClanMembersResult>(requestUri, ClashConstants.DefaultJsonSerializerOptions);

            return result.Members;
        }

        /// <summary>
        /// Retrieve a clan war log.
        /// </summary>
        /// <param name="clanTag">Clan tag to search for</param>
        /// <returns><see cref="IEnumerable{WarLog}"/></returns>
        public async Task<IEnumerable<WarLog>> GetWarLogsAsync(string clanTag)
        {
            var result = await _httpClient.GetFromJsonAsync<WarLogResult>($"clans/{HttpUtility.UrlEncode(clanTag)}/warlog", ClashConstants.DefaultJsonSerializerOptions);

            return result.WarLogs;
        }

        /// <summary>
        /// Gets the current war, returns null if the clan is not currently in war.
        /// </summary>
        /// <param name="clanTag">Clan tag to get current war for</param>
        /// <returns><see cref="CurrentWar"/></returns>
        public async Task<CurrentWar> GetCurrentWarAsync(string clanTag)
        {
            var result = await _httpClient.GetFromJsonAsync<CurrentWar>($"clans/{HttpUtility.UrlEncode(clanTag)}/currentwar", ClashConstants.DefaultJsonSerializerOptions);

            if (result.WarState == WarState.NotInWar)
            {
                return null;
            }

            return result;
        }

        /// <summary>
        /// Retrieve information about clan's current clan war league group.
        /// </summary>
        /// <param name="clanTag">Clan tag to get current league group for</param>
        /// <returns><see cref="LeagueGroup"/></returns>
        public async Task<LeagueGroup> GetCurrentLeagueGroupAsync(string clanTag)
        {
            var result = await _httpClient.GetFromJsonAsync<LeagueGroup>($"clans/{HttpUtility.UrlEncode(clanTag)}/currentwar/leaguegroup", ClashConstants.DefaultJsonSerializerOptions);

            return result;
        }

        /// <summary>
        /// Retrieve information about a clan war league war.
        /// </summary>
        /// <param name="warTag">War tag to retrieve information from</param>
        /// <returns><see cref="ClanWarLeague"/></returns>
        public async Task<ClanWarLeague> GetClanWarLeagueAsync(string warTag)
        {
            var result = await _httpClient.GetFromJsonAsync<ClanWarLeague>($"clanwarleagues/wars/{HttpUtility.UrlEncode(warTag)}", ClashConstants.DefaultJsonSerializerOptions);

            return result;
        }
    }
}
