using System;
using System.Threading.Tasks;
using ClashOfClans;

namespace ClashOfClans.Testing
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var coc = new ClashOfClansClient(Environment.GetEnvironmentVariable("COC_TOKEN"));
            var tag = "#U8C2UP8L";
            var tag2 = "#22QC2YYV2";
        }
    }
}