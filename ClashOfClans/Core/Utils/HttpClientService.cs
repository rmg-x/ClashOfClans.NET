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
        private static HttpClientService Instance { get; } = new HttpClientService();

        private const string COC_BASE_ADDRESS = "https://api.clashofclans.com/v1/";

        private const string SCHEME = "Bearer";

        public static HttpClientService GetInstance(string token)
        {
            Instance.BaseAddress = new Uri(COC_BASE_ADDRESS);
            Instance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(SCHEME, token);
            Instance.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return Instance;
        }

        public async Task<T> RequestAsync<T>(string requestUri, CancellationToken ct = default)
        {
            var response = await Instance.GetAsync(requestUri, ct);

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

        public async Task<T> SearchClansAsync<T>(ClanSearchSettings clanSearchSettings, CancellationToken ct = default)
        {
            var requestUri = $"clans?{clanSearchSettings.GetQueryString()}";

            if (requestUri.Length == 6)
                throw new Exception("At least one search parameter must be specified.");

            var response = await Instance.GetAsync(requestUri, ct);

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

            var response = await Instance.GetAsync(requestUri, ct);

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
