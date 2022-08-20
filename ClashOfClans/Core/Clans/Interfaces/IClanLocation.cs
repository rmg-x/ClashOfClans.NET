namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface IClanLocation
    {
        int Id { get; }

        string Name { get; }
        
        bool IsCountry { get; }
    }
}
