namespace ClashOfClans.Core.Players.Interfaces
{
    public interface IClashEntity
    {
        string Name { get; }

        int Level { get; }

        int MaxLevel { get; }

        EntityVillage Village { get; }
    }
}
