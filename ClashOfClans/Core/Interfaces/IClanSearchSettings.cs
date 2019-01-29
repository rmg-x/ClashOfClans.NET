namespace ClashOfClans.Core.Interfaces
{
    public interface IClanSearchSettings
    {
        WarFrequency? WarFrequency { get; set; }

        int? LocationId { get; }

        int? MinimumMembers { get; }

        int? MaximumMembers { get; }

        int? MinimumClanPoints { get; }

        int? MinimumClanLevel { get; }

        int? Limit { get; }

        int? After { get; }

        int? Before { get; }
    }
}
