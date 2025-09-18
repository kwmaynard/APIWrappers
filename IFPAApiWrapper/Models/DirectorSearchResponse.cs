using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a response containing director search results.
    /// </summary>
    public class DirectorSearchResponse
    {
        /// <summary>
        /// Gets or sets the search filter used.
        /// </summary>
        [JsonProperty("search_filter")]
        public DirectorSearchFilter SearchFilter { get; set; }

        /// <summary>
        /// Gets or sets the count of results.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the total number of results.
        /// </summary>
        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        /// <summary>
        /// Gets or sets the list of director search results.
        /// </summary>
        [JsonProperty("results")]
        public List<DirectorSearchResult> Results { get; set; }
    }
}