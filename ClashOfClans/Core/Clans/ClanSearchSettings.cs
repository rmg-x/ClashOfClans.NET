using ClashOfClans.Core.Interfaces;
using ClashOfClans.Core.Utils;
using System.Text;

namespace ClashOfClans
{
    public class ClanSearchSettings : IClanSearchSettings, ICustomSearchQuery
    {
        public WarFrequency? WarFrequency { get; set; }

        public int? LocationId { get; set; }

        public int? MinimumMembers { get; set; }

        public int? MaximumMembers { get; set; }

        public int? MinimumClanPoints { get; set; }

        public int? MinimumClanLevel { get; set; }

        public int? Limit { get; set; }

        public int? After { get; set; }

        public int? Before { get; set; }

        public string GetQueryString()
        {
            var requestUri = new StringBuilder();

            if (WarFrequency != null)
                requestUri.Append($"&warFrequency={WarFrequency.GetWarFrequency()}");

            if (LocationId != null)
                requestUri.Append($"&locationId={LocationId}");

            if (MinimumMembers != null)
                requestUri.Append($"&minMembers={MinimumMembers}");

            if (MaximumMembers != null)
                requestUri.Append($"&maxMembers={MaximumMembers}");

            if (MinimumClanPoints != null)
                requestUri.Append($"&minClanPoints={MinimumClanPoints}");

            if (MinimumClanLevel != null)
                requestUri.Append($"&minClanLevel={MinimumClanLevel}");

            if (Limit != null)
                requestUri.Append($"&limit={Limit}");

            if (After != null)
                requestUri.Append($"&after={After}");

            if (Before != null)
                requestUri.Append($"&before={Before}");

            return requestUri.ToString();
        }
    }
}
