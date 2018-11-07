using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Interfaces
{
    public interface IBasicSearchSettings
    {
        int? Limit { get; }

        int? After { get; }

        int? Before { get; }
    }
}
