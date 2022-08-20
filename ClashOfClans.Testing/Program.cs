using System;
using ClashOfClans;
using System.Linq;
using ClashOfClans.Core.Clans;

namespace ClashOfClans.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var coc = new ClashOfClansClient(Environment.GetEnvironmentVariable("COC_TOKEN"));
            var tag = "#U8C2UP8L";
            var warlogs = coc.Clans.GetWarLogsAsync(tag).GetAwaiter().GetResult();
        }
    }
}