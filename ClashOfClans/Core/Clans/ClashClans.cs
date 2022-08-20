using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
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

        /// <inheritdoc />
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

        /// <inheritdoc />
        public async Task<ClanInformation> GetClanByTagAsync(string clanTag)
        {
            var result = await _httpClient.GetFromJsonAsync<ClanInformation>($"clans/{HttpUtility.UrlEncode(clanTag)}", ClashConstants.DefaultJsonSerializerOptions);

            return result;
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public async Task<IEnumerable<WarLog>> GetWarLogsAsync(string clanTag)
        {
            var result = await _httpClient.GetFromJsonAsync<WarLogResult>($"clans/{HttpUtility.UrlEncode(clanTag)}/warlog", ClashConstants.DefaultJsonSerializerOptions);

            return result.WarLogs;
        }

        /// <inheritdoc />
        public async Task<CurrentWar> GetCurrentWarAsync(string clanTag)
        {
            var result = await _httpClient.GetFromJsonAsync<CurrentWar>($"clans/{HttpUtility.UrlEncode(clanTag)}/currentwar", ClashConstants.DefaultJsonSerializerOptions);

            if (result.WarState == WarState.NotInWar)
            {
                return null;
            }

            return result;
        }

        /// <inheritdoc />
        public async Task<LeagueGroup> GetCurrentLeagueGroupAsync(string clanTag)
        {
            var result = await _httpClient.GetFromJsonAsync<LeagueGroup>($"clans/{HttpUtility.UrlEncode(clanTag)}/currentwar/leaguegroup", ClashConstants.DefaultJsonSerializerOptions);

            return result;
        }

        /// <inheritdoc />
        public async Task<ClanWarLeague> GetClanWarLeagueAsync(string warTag)
        {
            var result = await _httpClient.GetFromJsonAsync<ClanWarLeague>($"clanwarleagues/wars/{HttpUtility.UrlEncode(warTag)}", ClashConstants.DefaultJsonSerializerOptions);

            return result;
        }
    }
}
