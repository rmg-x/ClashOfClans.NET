namespace ClashOfClans.Core.Leagues.Interfaces
{
    public interface ILeague
    {
        int Id { get; }

        string Name { get; }

        LeagueIcons Icons { get; }
    }
}
