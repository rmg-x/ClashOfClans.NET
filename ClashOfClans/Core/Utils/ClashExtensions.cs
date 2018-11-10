using ClashOfClans.Core.Clans;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Utils
{
    public static class ClashExtensions
    {
        public static bool IsNotCriticalFailure(this HttpResponseMessage httpMsg) => httpMsg.StatusCode == HttpStatusCode.NotFound;

        public static string GetWarFrequency(this WarFrequency? warFrequency)
        {
            string warFreq;

            switch (warFrequency)
            {
                case WarFrequency.Always:
                    warFreq = "always";
                    break;
                case WarFrequency.LessThanOncePerWeek:
                    warFreq = "lessThanOncePerWeek";
                    break;
                case WarFrequency.MoreThanOncePerWeek:
                    warFreq = "moreThanOncePerWeek";
                    break;
                case WarFrequency.Never:
                    warFreq = "never";
                    break;
                case WarFrequency.Unknown:
                    warFreq = "unknown";
                    break;
                default:
                    throw new Exception($"Invalid war frequency \"{warFrequency.ToString()}\"");
            }

            return warFreq;
        }

        public static string GetQueryString(this ClanSearchSettings clanSearchSettings)
        {
            var requestUri = new StringBuilder();

            if (clanSearchSettings.Name != null && clanSearchSettings.Name.Length >= 3)
                requestUri.Append($"&name={clanSearchSettings.Name}");

            if (clanSearchSettings.WarFrequency != null)
                requestUri.Append($"&warFrequency={clanSearchSettings.WarFrequency.GetWarFrequency()}");

            if (clanSearchSettings.LocationId != null)
                requestUri.Append($"&locationId={clanSearchSettings.LocationId}");

            if (clanSearchSettings.MinimumMembers != null)
                requestUri.Append($"&minMembers={clanSearchSettings.MinimumMembers}");

            if (clanSearchSettings.MaximumMembers != null)
                requestUri.Append($"&maxMembers={clanSearchSettings.MaximumMembers}");

            if (clanSearchSettings.MinimumClanPoints != null)
                requestUri.Append($"&minClanPoints={clanSearchSettings.MinimumClanPoints}");

            if (clanSearchSettings.MinimumClanLevel != null)
                requestUri.Append($"&minClanLevel={clanSearchSettings.MinimumClanLevel}");

            if (clanSearchSettings.Limit != null)
                requestUri.Append($"&limit={clanSearchSettings.Limit}");

            if (clanSearchSettings.After != null)
                requestUri.Append($"&after={clanSearchSettings.After}");

            if (clanSearchSettings.Before != null)
                requestUri.Append($"&before={clanSearchSettings.Before}");

            return requestUri.ToString();
        }

        public static string GetQueryString(this BasicSearchSettings basicSearchSettings)
        {
            var requestUri = new StringBuilder();

            if (basicSearchSettings.Limit != null)
                requestUri.Append($"&limit={basicSearchSettings.Limit}");

            if (basicSearchSettings.After != null)
                requestUri.Append($"&after={basicSearchSettings.After}");

            if (basicSearchSettings.Before != null)
                requestUri.Append($"&before={basicSearchSettings.Before}");

            return requestUri.ToString();
        }
    }
}
