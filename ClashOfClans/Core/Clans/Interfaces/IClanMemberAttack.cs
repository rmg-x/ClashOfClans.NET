namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface IClanMemberAttack
    {
        string AttackerTag { get; }

        string DefenderTag { get; }

        int Stars { get; }

        double DestructionPercentage { get; }

        int Order { get; }
    }
}
