using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using ClashOfClans.Core.Players;
using ClashOfClans.Core.Clans;

namespace ClashOfClans.Testing
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var coc = new ClashOfClansClient(Environment.GetEnvironmentVariable("COC_TOKEN"), TimeSpan.FromSeconds(2));
            var tag = "#U8C2UP8L";
            var tag2 = "#22QC2YYV2";
        }
    }
}