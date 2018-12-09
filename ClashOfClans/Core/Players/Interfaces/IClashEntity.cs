using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Players.Interfaces
{
    public interface IClashEntity
    {
        string Name { get; }

        int Level { get; }

        int MaxLevel { get; }

        string Village { get; }
    }
}
