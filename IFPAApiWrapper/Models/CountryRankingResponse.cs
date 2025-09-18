using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a response containing country ranking information.
    /// </summary>
    public class CountryRankingResponse
    {
        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the count of results.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the list of ranking results.
        /// </summary>
        [JsonProperty("results")]
        public List<RankingResult> Results { get; set; }
    }
}