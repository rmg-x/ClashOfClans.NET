using ClashOfClans.Core.Clans;
using ClashOfClans.Core.Interfaces;
using ClashOfClans.Core.Utils;

namespace ClashOfClans
{
    public class ClashOfClansClient : IClashOfClansClient
    {
        public ClashOfClansClient(string token)
        {
            var httpClientService = HttpClientService.GetInstance(token);

            Clans = new ClashClans(httpClientService);
        }

        public IClashClans Clans { get; private set; }
    }
}
