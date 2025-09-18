using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents the response for a tournament search.
    /// </summary>
    public class TournamentSearchResponse
    {
        /// <summary>
        /// Gets or sets the search filter used for the tournament search.
        /// </summary>
        [JsonProperty("search_filter")]
        public TournamentSearchFilter SearchFilter { get; set; }

        /// <summary>
        /// Gets or sets the count of results returned.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the total number of results available.
        /// </summary>
        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        /// <summary>
        /// Gets or sets the list of tournament search results.
        /// </summary>
        [JsonProperty("results")]
        public List<TournamentSearchResult> Results { get; set; }
    }
}