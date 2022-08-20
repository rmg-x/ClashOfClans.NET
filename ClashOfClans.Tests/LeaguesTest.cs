using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClashOfClans.Tests
{
    public class LeaguesTest
    {
        ClashOfClansClient _cocClient;

        public LeaguesTest()
        {
            string token = File.ReadAllText("coc_token.txt");

            _cocClient = new ClashOfClansClient(token, TimeSpan.FromSeconds(2));
        }

        [Fact]
        public async Task GetLeaguesAsync_NotEmpty()
        {
            var leagues = await _cocClient.Leagues.GetLeaguesAsync();

            Assert.NotEmpty(leagues);
        }

        [Fact]
        public async Task GetLeagueSeasonsAsync_NotEmpty()
        {
            var leagueSeasons = await _cocClient.Leagues.GetLeagueSeasonsAsync(LeagueConstants.LegendLeague);
            
            Assert.NotEmpty(leagueSeasons);
        }

        [Fact]
        public async Task GetLeagueSeasonsAsync_ThrowsArgException()
        {
            await Assert.ThrowsAsync<ArgumentException>(async () => await _cocClient.Leagues.GetLeagueSeasonsAsync(LeagueConstants.GoldLeague1));
        }

        [Fact]
        public async Task GetLeagueSeasonRankingsAsync_NotEmpty()
        {
            var leagueSeasonRankings = await _cocClient.Leagues.GetLeagueSeasonRankingsAsync(LeagueConstants.LegendLeague, "2015-07");

            Assert.NotEmpty(leagueSeasonRankings);
        }

        [Fact]
        public async Task GetLeagueByIdAsync_NotNull()
        {
            var legendLeague = await _cocClient.Leagues.GetLeagueByIdAsync(LeagueConstants.LegendLeague);

            Assert.NotNull(legendLeague);
        }
    }
}
