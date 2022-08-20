using ClashOfClans.Core.Clans;
using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Interfaces;
using ClashOfClans.Core.Utils;
using System;

namespace ClashOfClans
{
    public class ClashOfClansClient : IClashOfClansClient, IDisposable
    {
        private HttpClientService HttpClientService { get; set; }

        public ClashOfClansClient(string token)
        {
            HttpClientService = HttpClientService.GetInstance(token);

            Clans = new ClashClans(HttpClientService);
        }

        public void Dispose() => HttpClientService?.Dispose();

        public IClashClans Clans { get; private set; }
    }
}
