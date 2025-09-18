using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a response containing ranking information.
    /// </summary>
    public class RankingResponse
    {
        /// <summary>
        /// Gets or sets the ranking system.
        /// </summary>
        [JsonProperty("system")]
        public string System { get; set; }

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
        /// Gets or sets the list of ranking results.
        /// </summary>
        [JsonProperty("results")]
        public List<RankingResult> Results { get; set; }
    }
}