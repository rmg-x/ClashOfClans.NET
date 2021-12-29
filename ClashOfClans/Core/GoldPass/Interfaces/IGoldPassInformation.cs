using System;

namespace ClashOfClans.Core.GoldPass.Interfaces
{
    public interface IGoldPassInformation
    {
        DateTime StartTime { get; }

        DateTime EndTime { get; }
    }
}
