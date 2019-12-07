using ClashOfClans.Core.Interfaces;
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

        public static HttpClientService CreateService(string token, TimeSpan requestTimeout, bool UseRecommendedRateLimits)
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

        public async Task<T> RequestAsync<T>(string requestUri, ICustomSearchQuery searchQuery = default)
        {
            await RequestPool.WaitAsync().ConfigureAwait(false);

            if (searchQuery != default)
            {
                requestUri += "?";
                requestUri += searchQuery.GetQueryString();
            }

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
    }
}
