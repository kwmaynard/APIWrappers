namespace OPDBApiWrapper.Tests
{
    public class OPDBApiClientTest
    {
        private string _apiToken = "";

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

            Assert.NotNull(result);
            Assert.True(result.Count > 0, "Expected count of changelog items should be greater than 0");
        }

        [Fact]
        public async Task OPDBApiClient_Changelog_GoodKey()
        {
            var apiToken = _apiToken;
            var client = new OPDBApiClient(apiToken);

            var result = await client.GetChangelogAsync();

            Assert.NotNull(result);
            Assert.True(result.Count > 0, "Expected count of changelog items should be greater than 0");
        }

        [Fact]
        public async Task OPDBApiClient_ExportGroupsAsync_GoodKey()
        {
            var client = new OPDBApiClient(_apiToken);

            var result = await client.GetExportGroupsAsync();

            Assert.NotNull(result);
            Assert.True(result.Count > 0, "Expected count of exported machine groups should be greater than 0");
        }

        [Fact]
        public async Task OPDBApiClient_GetMachineByIpdbIdAsync_MedMad_GoodKey()
        {
            var client = new OPDBApiClient(_apiToken);
            int testIpdbId = 4032; // Use a valid IPDB ID for real test

            var result = await client.GetMachineByIpdbIdAsync(testIpdbId);

            Assert.NotNull(result);
            Assert.Equal(testIpdbId, result.IpdbId); // Adjust property as needed
        }

        [Fact]
        public async Task OPDBApiClient_GetMachineByOpdbIdAsync_MedMad_GoodKey()
        {
            var client = new OPDBApiClient(_apiToken);
            string testOpdbId = "G5pe4-MePZv"; // Use a valid OPDB ID for real test

            var result = await client.GetMachineByOpdbIdAsync(testOpdbId);

            Assert.NotNull(result);
            Assert.Equal(testOpdbId, result.OpdbId); // Adjust property as needed
        }

        [Fact]
        public async Task OPDBApiClient_GetSearchResultsAsync_MedMad_GoodKey()
        {
            var client = new OPDBApiClient(_apiToken);
            string searchTerm = "Medieval+Madness"; // Use a valid search term for real test

            var result = await client.GetSearchResultsAsync(searchTerm);

            Assert.NotNull(result);
            Assert.True(result.Count >= 0, "Search results should not be null");
        }

        [Fact]
        public async Task OPDBApiClient_GetTypeaheadSearchModelAsync_MedMad_GoodKey()
        {
            var client = new OPDBApiClient(_apiToken);
            string searchTerm = "Medieval+Madness"; // Use a valid search term for real test

            var result = await client.GetTypeaheadSearchModelAsync(searchTerm);

            Assert.NotNull(result);
            Assert.True(result.Count >= 0, "Typeahead search results should not be null");
        }
    }
}