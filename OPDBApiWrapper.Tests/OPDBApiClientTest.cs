namespace OPDBApiWrapper.Tests
{
    public class OPDBApiClientTest
    {
        string _apiToken = "";

        [Fact]
        public void OPDBApiClient_NoKey()
        {
            Assert.Throws<ArgumentNullException>(() => new OPDBApiClient(null));
        }

        [Fact]
        public async Task OPDBApiClient_Changelog_BadKey()
        {
            var apiToken = "BADTOKEN";
            var client = new OPDBApiClient(apiToken);

            var result = await client.GetChangelogAsync();
            var count = result.Count;

            Assert.NotNull(result);
            Assert.True(count > 0, "Expected count of changelog items should be greater than 0");
        }

        [Fact]
        public async Task OPDBApiClient_Changelog_GoodKey()
        {
            var apiToken = _apiToken;
            var client = new OPDBApiClient(apiToken);

            var result = await client.GetChangelogAsync();
            var count = result.Count;

            Assert.NotNull(result);
            Assert.True(count > 0, "Expected count of changelog items should be greater than 0");
        }
    }
}