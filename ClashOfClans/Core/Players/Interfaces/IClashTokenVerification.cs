namespace ClashOfClans.Core.Players.Interfaces
{
    public interface IClashTokenVerification
    {
        string Tag { get; set; }

        string Token { get; set; }

        PlayerTokenStatus Status { get; set; }
    }
}
