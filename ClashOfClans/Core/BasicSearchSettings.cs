using ClashOfClans.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core
{
    public class BasicSearchSettings : IBasicSearchSettings
    {
        public int? Limit { get; set; }

        public int? After { get; set; }

        public int? Before { get; set; }
    }
}
