using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a response containing region ranking information.
    /// </summary>
    public class RegionRankingResponse
    {
        /// <summary>
        /// Gets or sets the region code.
        /// </summary>
        [JsonProperty("region_code")]
        public string RegionCode { get; set; }

        /// <summary>
        /// Gets or sets the count of results returned.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the list of ranking results for the region.
        /// </summary>
        [JsonProperty("results")]
        public List<RankingResult> Results { get; set; }
    }
}