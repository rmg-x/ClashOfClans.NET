namespace ClashOfClans.Core.Labels.Interfaces
{
    public interface IClashLabel
    {
        int Id { get; set; }

        string Name { get; set; }

        LabelBadges Icons { get; set; }
    }
}
