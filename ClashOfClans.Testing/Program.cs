using System;
using ClashOfClans;
using System.Linq;
using ClashOfClans.Core.Clans;
using System.Threading.Tasks;

namespace ClashOfClans.Testing
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var coc = new ClashOfClansClient(Environment.GetEnvironmentVariable("COC_TOKEN"));

            var tag = "#U8C2UP8L";
            var result = await coc.Clans.SearchAsync("crimson tide", new ClanSearchSettings() { Limit = 35 });

            foreach (var a in result.Where(x => x.Location != null))
            {
                Console.WriteLine($"{a.Tag} | {a.Name} | {a.Location.Name} | {a.Location.CountryCode ?? "None" }");
            }
        }
    }
}