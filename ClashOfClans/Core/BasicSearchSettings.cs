using ClashOfClans.Core.Interfaces;

namespace ClashOfClans.Core
{
    public class BasicSearchSettings : IBasicSearchSettings
    {
        public int? Limit { get; set; }

        public int? After { get; set; }

        public int? Before { get; set; }
    }
}
