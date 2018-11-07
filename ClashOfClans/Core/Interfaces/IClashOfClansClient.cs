using ClashOfClans.Core.Clans;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Interfaces
{
    public interface IClashOfClansClient
    {
        IClashClans Clans { get; }
    }
}
