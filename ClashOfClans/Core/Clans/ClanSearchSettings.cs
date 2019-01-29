using ClashOfClans.Core.Interfaces;

namespace ClashOfClans
{
    public class ClanSearchSettings : IClanSearchSettings
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
    }
}
