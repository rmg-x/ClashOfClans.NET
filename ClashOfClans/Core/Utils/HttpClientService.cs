using ClashOfClans.Core.Clans;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Utf8Json;
using Utf8Json.Resolvers;

namespace ClashOfClans.Core.Utils
{
    public class HttpClientService : HttpClient
    {
        private const string COC_BASE_ADDRESS = "https://api.clashofclans.com/v1/";

        private const string SCHEME = "Bearer";

        private const int REQUESTS_PER_SECOND = 10;

        private const string MEDIA_TYPE = "application/json";

        private TimeSpanSemaphore RequestPool { get; set; }

        public static HttpClientService GetInstance(string token, TimeSpan requestTimeout, bool UseRecommendedRateLimits)
        {
            var httpClientInstance = new HttpClientService();

            httpClientInstance.BaseAddress = new Uri(COC_BASE_ADDRESS);
            httpClientInstance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(SCHEME, token);
            httpClientInstance.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MEDIA_TYPE));

            if (requestTimeout != default)
                httpClientInstance.Timeout = requestTimeout;

            if (UseRecommendedRateLimits)
                httpClientInstance.RequestPool = new TimeSpanSemaphore(REQUESTS_PER_SECOND, TimeSpan.FromSeconds(1));
            else
                httpClientInstance.RequestPool = new TimeSpanSemaphore(1, TimeSpan.FromMilliseconds(0));

            return httpClientInstance;
        }

        public async Task<T> RequestAsync<T>(string requestUri)
        {
            await RequestPool.WaitAsync().ConfigureAwait(false);

            var response = await GetAsync(requestUri).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                if (response.IsNotCriticalFailure())
                    return default;
                else
                    response.EnsureSuccessStatusCode();
            }

            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var resultStream = await result.ToStreamAsync().ConfigureAwait(false);

            RequestPool.Release();

            return await JsonSerializer.DeserializeAsync<T>(resultStream, StandardResolver.AllowPrivate).ConfigureAwait(false);
        }

        public async Task<T> SearchClansAsync<T>(string clanName, ClanSearchSettings clanSearchSettings = default)
        {
            var requestUri = $"clans?name={clanName}";

            if (clanSearchSettings != default)
                requestUri += clanSearchSettings.GetQueryString();

            if (string.IsNullOrEmpty(clanName) || clanName.Length < 3)
                throw new ArgumentException("A clan name must be specified and greater than two characters.", nameof(clanName));

            return await RequestAsync<T>(requestUri).ConfigureAwait(false);
        }

        public async Task<T> GetClanMembersAsync<T>(string clanTag, BasicSearchSettings basicSearchSettings)
        {
            var requestUri = $"clans/{clanTag}/members";

            if (basicSearchSettings != null)
                requestUri += $"?{basicSearchSettings.GetQueryString()}";

            return await RequestAsync<T>(requestUri).ConfigureAwait(false);
        }
    }
}
