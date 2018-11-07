using ClashOfClans.Core.Clans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utf8Json;
using Utf8Json.Resolvers;
using ClashOfClans.Core.Utils;
using System.Web;

namespace ClashOfClans.Core.Utils
{
    public class HttpClientService : HttpClient
    {
        private static HttpClientService Instance { get; } = new HttpClientService();

        private const string COC_BASE_ADDRESS = "https://api.clashofclans.com/v1/";

        private const string SCHEME = "Bearer";

        public static Task Intialize(string token)
        {
            Instance.BaseAddress = new Uri(COC_BASE_ADDRESS);
            Instance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(SCHEME, token);
            Instance.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return Task.CompletedTask;
        }

        public static async Task<T> RequestAsync<T>(string requestUri, CancellationToken ct = default)
        {
            var response = await Instance.GetAsync(requestUri, ct);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonSerializer.Deserialize<T>(result, StandardResolver.AllowPrivate);
        }

        public static async Task<T> SearchClansAsync<T>(ClanSearchSettings clanSearchSettings, CancellationToken ct = default)
        {
            var requestUri = $"clans?{clanSearchSettings.GetQueryString()}";

            if (requestUri.Length == 6)
                throw new Exception("At least one search parameter must be specified.");

            var response = await Instance.GetAsync(requestUri, ct);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonSerializer.Deserialize<T>(result, StandardResolver.AllowPrivate);
        }

        public static async Task<T> GetClanMembersAsync<T>(string clanTag, BasicSearchSettings basicSearchSettings, CancellationToken ct = default)
        {
            var requestUri = $"clans/{clanTag}/members?{basicSearchSettings.GetQueryString()}";

            var response = await Instance.GetAsync(requestUri, ct);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonSerializer.Deserialize<T>(result, StandardResolver.AllowPrivate);
        }
    }
}
