using ClashOfClans.Core.Clans;
using ClashOfClans.Core.Interfaces;
using ClashOfClans.Core.Utils;
using System;

namespace ClashOfClans
{
    public class ClashOfClansClient : IClashOfClansClient
    {
        public ClashOfClansClient(string token)
        {
            HttpClientService.Intialize(token);

            Clans = new ClashClans();
        }

        public IClashClans Clans { get; private set; }
    }
}
