using ClashOfClans.Core.Interfaces;
using System.Text;

namespace ClashOfClans
{
    public class BasicSearchSettings : IBasicSearchSettings, ICustomSearchQuery
    {
        public int? Limit { get; set; }

        public int? After { get; set; }

        public int? Before { get; set; }

        public string GetQueryString()
        {
            var requestUri = new StringBuilder();

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
