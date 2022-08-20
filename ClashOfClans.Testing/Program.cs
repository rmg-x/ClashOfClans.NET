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
            var tag2 = "#22QC2YYV2";
            var result = await coc.Clans.GetCurrentWarAsync(tag2);

            Console.WriteLine(result == null);
        }
    }
}