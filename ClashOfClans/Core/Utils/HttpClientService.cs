using ClashOfClans.Core.Clans;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Utf8Json;
using Utf8Json.Resolvers;

namespace ClashOfClans.Core.Utils
{
    public class HttpClientService : HttpClient
    {
        private const string COC_BASE_ADDRESS = "https://api.clashofclans.com/v1/";

        private const string SCHEME = "Bearer";

        public static HttpClientService GetInstance(string token)
        {
            var httpClientInstance = new HttpClientService();

            httpClientInstance.BaseAddress = new Uri(COC_BASE_ADDRESS);
            httpClientInstance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(SCHEME, token);
            httpClientInstance.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return httpClientInstance;
        }

        public async Task<T> RequestAsync<T>(string requestUri, CancellationToken ct = default)
        {
            var response = await GetAsync(requestUri, ct);

            if (!response.IsSuccessStatusCode)
            {
                if (response.IsNotCriticalFailure())
                    return default;
                else
                    response.EnsureSuccessStatusCode();
            }

            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonSerializer.Deserialize<T>(result, StandardResolver.AllowPrivate);
        }

        public async Task<T> SearchClansAsync<T>(string clanName, ClanSearchSettings clanSearchSettings = default, CancellationToken ct = default)
        {
            var requestUri = $"clans?name={clanName}";

            if (clanSearchSettings != default)
                requestUri += clanSearchSettings.GetQueryString();

            if (string.IsNullOrEmpty(clanName) || clanName.Length < 3)
                throw new ArgumentException("A clan name must be specified and greater than two characters.", nameof(clanName));

            var response = await GetAsync(requestUri, ct);

            if (!response.IsSuccessStatusCode)
            {
                if (response.IsNotCriticalFailure())
                    return default;
                else
                    response.EnsureSuccessStatusCode();
            }

            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonSerializer.Deserialize<T>(result, StandardResolver.AllowPrivate);
        }

        public async Task<T> GetClanMembersAsync<T>(string clanTag, BasicSearchSettings basicSearchSettings, CancellationToken ct = default)
        {
            var requestUri = $"clans/{clanTag}/members?{basicSearchSettings.GetQueryString()}";

            var response = await GetAsync(requestUri, ct);

            if (!response.IsSuccessStatusCode)
            {
                if (response.IsNotCriticalFailure())
                    return default;
                else
                    response.EnsureSuccessStatusCode();
            }

            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonSerializer.Deserialize<T>(result, StandardResolver.AllowPrivate);
        }
    }
}
