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
            var clan = coc.Clans.GetClanByTagAsync("#U8C2UP8L").GetAwaiter().GetResult();

            foreach (var member in clan.Members.Where(x => x.Trophies > 950))
            {
                Console.WriteLine($"{member.Name} | {member.League} | {member.Trophies}");
            }
        }
    }
}