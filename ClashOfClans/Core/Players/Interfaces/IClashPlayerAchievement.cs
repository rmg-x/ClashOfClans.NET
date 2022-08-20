using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Players.Interfaces
{
    public interface IClashPlayerAchievement
    {
        string Name { get; }

        int Stars { get; }

        int Value { get; }

        int Target { get; }

        string Description { get; }

        string CompletionInformation { get; }

        string Village { get; }
    }
}
