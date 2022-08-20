using ClashOfClans.Core.Leagues.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ClashOfClans.Testing
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var coc = new ClashOfClansClient(Environment.GetEnvironmentVariable("COC_TOKEN"), TimeSpan.FromSeconds(2));
            var tag = "#U8C2UP8L";
            var tag2 = "#22QC2YYV2";

            var x = await coc.Clans.GetCurrentWarAsync(tag);

            if (x != null)
            {
                Console.WriteLine(x.Opponent.Name);
            }
        }
    }
}