using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OPDBApiWrapper.Models;

namespace OPDBApiWrapper
{
    /// <summary>
    /// Client for accessing the OPDB API.
    /// </summary>
    /// <seealso href="https://opdb.org/api">OPDB API Documentation</seealso>
    public class OPDBApiClient : IOPDBApiClient
    {
        /// <summary>
        /// The HTTP client used for requests.
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        /// The API token for authentication.
        /// </summary>
        private readonly string _apiToken;

        /// <summary>
        /// The base URL for the OPDB API.
        /// </summary>
        private const string BaseUrl = "https://opdb.org/api/";

        /// <summary>
        /// Initializes a new instance of the <see cref="OPDBApiClient"/> class.
        /// </summary>
        /// <param name="apiToken">The OPDB API token.</param>
        /// <exception cref="ArgumentNullException">Thrown if apiToken is null.</exception>
        public OPDBApiClient(string apiToken)
        {
            _apiToken = apiToken ?? throw new ArgumentNullException(nameof(apiToken));
            _httpClient = new HttpClient { BaseAddress = new Uri(BaseUrl) };
        }

        /// <summary>
        /// Gets the changelog from the OPDB API.
        /// </summary>
        /// <returns>A list of <see cref="Changelog"/> objects.</returns>
        public async Task<List<Changelog>> GetChangelogAsync()
        {
            var response = await _httpClient.GetAsync($"changelog");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Changelog>>(json);
        }

        /// <summary>
        /// Gets the export of machines from the OPDB API.
        /// </summary>
        /// <returns>A list of <see cref="Machine"/> objects.</returns>
        public async Task<List<Machine>> GetExportAsync()
        {
            var response = await _httpClient.GetAsync($"export?api_token={_apiToken}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Machine>>(json);
        }

        /// <summary>
        /// Gets the export of machine groups from the OPDB API.
        /// </summary>
        /// <returns>A list of <see cref="MachineGroup"/> objects.</returns>
        public async Task<List<MachineGroup>> GetExportGroupsAsync()
        {
            var response = await _httpClient.GetAsync($"export/groups?api_token={_apiToken}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<MachineGroup>>(json);
        }

        /// <summary>
        /// Gets a machine by its IPDB ID.
        /// </summary>
        /// <param name="ipdbId">The IPDB ID of the machine.</param>
        /// <returns>A <see cref="Machine"/> object.</returns>
        public async Task<Machine> GetMachineByIpdbIdAsync(int ipdbId)
        {
            var response = await _httpClient.GetAsync($"machines/ipdb/{ipdbId}&api_token={_apiToken}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Machine>(json);
        }

        /// <summary>
        /// Gets a machine by its OPDB ID.
        /// </summary>
        /// <param name="opdbId">The OPDB ID of the machine.</param>
        /// <returns>A <see cref="Machine"/> object.</returns>
        public async Task<Machine> GetMachineByOpdbIdAsync(string opdbId)
        {
            var response = await _httpClient.GetAsync($"machines/{opdbId}&api_token={_apiToken}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Machine>(json);
        }

        /// <summary>
        /// Searches for machines by a search term.
        /// </summary>
        /// <param name="searchTerm">The search term.</param>
        /// <returns>A list of <see cref="Machine"/> objects.</returns>
        public async Task<List<Machine>> GetSearchResultsAsync(string searchTerm)
        {
            var response = await _httpClient.GetAsync($"search?q={searchTerm}&api_token={_apiToken}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Machine>>(json);
        }

        /// <summary>
        /// Gets typeahead search results for machines.
        /// </summary>
        /// <param name="searchTerm">The search term.</param>
        /// <returns>A list of <see cref="SimpleMachine"/> objects.</returns>
        public async Task<List<SimpleMachine>> GetTypeaheadSearchModelAsync(string searchTerm)
        {
            var response = await _httpClient.GetAsync($"typeahead?q={searchTerm}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<SimpleMachine>>(json);
        }
    }
}