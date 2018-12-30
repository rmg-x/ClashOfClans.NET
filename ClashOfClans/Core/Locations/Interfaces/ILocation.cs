namespace ClashOfClans.Core.Locations.Interfaces
{
    public interface ILocation
    {
        int Id { get; }

        string Name { get; }

        bool IsCountry { get; }

        string CountryCode { get; }
    }
}
